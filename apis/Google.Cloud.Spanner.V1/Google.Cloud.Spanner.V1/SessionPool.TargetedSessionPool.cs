// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Spanner.Common.V1;
using Google.Protobuf;
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Spanner.V1.TransactionOptions;

namespace Google.Cloud.Spanner.V1
{
    public partial class SessionPool
    {
        // Note: Internal for test purposes.
        internal sealed class TargetedSessionPool : SessionPoolBase
        {
            private static readonly TransactionOptions s_readWriteOptions = new TransactionOptions { ReadWrite = new TransactionOptions.Types.ReadWrite() };

            // Read-only state
            private readonly object _lock = new object();
            private readonly DatabaseName _databaseName;
            // Clone before use, this will hold the amount of sessions to create in each batch
            // so it can't be shared amongst requests.
            private readonly BatchCreateSessionsRequest _batchCreateSessionRequestTemplate;

            // Mutable state, which should be accessed within the lock

            private readonly ConcurrentStack<PooledSession> _readOnlySessions = new ConcurrentStack<PooledSession>();
            private readonly ConcurrentStack<PooledSession> _readWriteSessions = new ConcurrentStack<PooledSession>();
            private readonly ConcurrentQueue<TaskCompletionSource<PooledSession>> _pendingAcquisitions =
                new ConcurrentQueue<TaskCompletionSource<PooledSession>>();

            // Tasks waiting for the pool to reach its minimum size or become unhealthy.
            private readonly LinkedList<TaskCompletionSource<int>> _minimumSizeWaiters = new LinkedList<TaskCompletionSource<int>>();

            // The size of the last unhealthy batch.
            // If 0, the pool is healthy.
            // Assume the pool is healthy to start with.
            private int _lastUnhealthyBatchSize;
            private bool Healthy => Interlocked.CompareExchange(ref _lastUnhealthyBatchSize, 0, 0) == 0;
            private int LastUnhealthyBatchSize => Interlocked.CompareExchange(ref _lastUnhealthyBatchSize, -1, -1);

            // The task (completion source) associated with shutting down the session pool, if any.
            // Note that this task has no cancellation token associated with it, even if the original call did.
            private TaskCompletionSource<int> _shutdownTask = null;
            private bool Shutdown => Interlocked.CompareExchange(ref _shutdownTask, null, null) != null;

            // The task (completion source) associated with nursing the pool back to health, if any.
            // The pool can only be being nursed back to health by at most one task at any given moment.
            private TaskCompletionSource<int> _nurseBackToHealthTask = null;

            /// <summary>
            /// The difference between "acquire" and "release" calls, including pending "acquire" calls. Not guarded by the lock,
            /// but should be modified using Interlocked and accessed via the property.
            /// </summary>
            private int _activeSessionCount;

            /// <summary>
            /// The number of sessions we're currently trying to create. Not guarded by the lock, but should be accessed using Interlocked.
            /// </summary>
            private int _inFlightSessionCreationCount;

            /// <summary>
            /// The number of sessions we know we've started creating and haven't yet deleted. This isn't the same as _activeSessionCount,
            /// for two reasons. Firstly, sessions in the pool (or being refreshed etc) still count against this value.
            /// Secondly, the number of *caller-requested* sessions can mount up, but we throttle how many *we* ask for.
            /// This value is how we obey <see cref="SessionPoolOptions.MaximumActiveSessions"/>.
            /// </summary>
            private int _liveOrRequestedSessionCount;

            /// <summary>
            /// Thread-safe read-only access to active session count.
            /// </summary>
            internal int ActiveSessionCount => Interlocked.CompareExchange(ref _activeSessionCount, 0, 0);

            /// <summary>
            /// Thread-safe read-only access to in-flight session creation count.
            /// </summary>
            internal int InFlightSessionCreationCount => Interlocked.CompareExchange(ref _inFlightSessionCreationCount, 0, 0);

            /// <summary>
            /// Thread-safe read-only access to live or requested session count.
            /// </summary>
            internal int LiveOrRequestedSessionCount => Interlocked.CompareExchange(ref _liveOrRequestedSessionCount, 0, 0);

            // Statistics maintained purely for diagnostic purposes. This lets us evaluate
            // how effective transaction pre-warming is.
            private long _rwTransactionRequests;
            private long _rwTransactionRequestsPrewarmed;

            internal TargetedSessionPool(SessionPool parent, DatabaseName databaseName, bool acquireSessionsImmediately) : base(parent)
            {
                _databaseName = GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
                _batchCreateSessionRequestTemplate = new BatchCreateSessionsRequest
                {
                    DatabaseAsDatabaseName = databaseName,
                    SessionTemplate = new Session
                    {
                        Labels = { parent.Options.SessionLabels }
                    }
                };

                if (acquireSessionsImmediately)
                {
                    StartSessionCreationTasksIfNecessary();
                }
            }

            public async Task<PooledSession> AcquireSessionAsync(TransactionOptions transactionOptions, CancellationToken cancellationToken)
            {
                bool success = false;
                try
                {
                    int sessionCount = Interlocked.Increment(ref _activeSessionCount);
                    if (sessionCount > Options.MaximumActiveSessions && Options.WaitOnResourcesExhausted == ResourcesExhaustedBehavior.Fail)
                    {
                        // Not really an RpcException, but the cleanest way of representing it.
                        // (The ADO.NET provider will convert it to a SpannerException with the same code.)
                        throw new RpcException(new Status(StatusCode.ResourceExhausted, "Local maximum number of active sessions exceeded. Possibly resource leak in client code?"));
                    }

                    // We check for shutdown after incrementing ActiveSessionCount, and we *set* shutdown before checking ActiveSessionCount,
                    // so it shouldn't be possible for us to miss this check but still end up with an acquisition task which waits forever because
                    // the shutdown loop starts and finishes too quickly.
                    if (Shutdown)
                    {
                        throw new InvalidOperationException("Session pool has already been shut down");
                    }

                    PooledSession session = await AcquireSessionImplAsync(transactionOptions, cancellationToken).ConfigureAwait(false);
                    success = true;
                    return session;
                }
                finally
                {
                    if (!success)
                    {
                        Interlocked.Decrement(ref _activeSessionCount);
                    }
                }
            }

            private async Task<PooledSession> AcquireSessionImplAsync(TransactionOptions transactionOptions, CancellationToken cancellationToken)
            {
                var transactionMode = transactionOptions?.ModeCase ?? ModeOneofCase.None;
                var sessionAcquisitionTask = GetSessionAcquisitionTask(transactionMode, cancellationToken);

                // We've either fetched a task from the pool, or registered that a caller is waiting for one.
                // We may want to start creation tasks, either to replenish the pool or (if there were no pool entries)
                // to make sure that there's something creating a session for us.
                StartSessionCreationTasksIfNecessary();

                var session = await sessionAcquisitionTask.ConfigureAwait(false);

                // Note: deliberately no test for refresh or eviction.
                // We do this when a session is released, and in the maintenance task.
                // These happen frequently enough that we shouldn't need to worry about them here.

                // Update statistics for prewarming - only after we've already acquired the session.
                if (transactionMode == ModeOneofCase.ReadWrite)
                {
                    Interlocked.Increment(ref _rwTransactionRequests);
                    if (session.TransactionMode == transactionMode)
                    {
                        Interlocked.Increment(ref _rwTransactionRequestsPrewarmed);
                    }
                }

                // If we've already got the right transaction mode, we're done.
                if (session.TransactionMode == transactionMode)
                {
                    return session;
                }
                // Otherwise, we may need to forget an existing transaction, or request a new one.
                else
                {
                    // If we asked for a session with no transaction but we got one *with* a tranasction,
                    // we don't need to perform any RPCs - but we do need to return a PooledSession with
                    // no transaction ID.
                    if (transactionMode == ModeOneofCase.None)
                    {
                        return session.WithTransaction(null, ModeOneofCase.None);
                    }
                    else
                    {
                        bool success = false;
                        try
                        {
                            session = await BeginTransactionAsync(session, transactionOptions, cancellationToken).ConfigureAwait(false);
                            success = true;
                            return session;
                        }
                        finally
                        {
                            // If we succeeded in getting a session but not a transaction, we can reuse the session later, but still fail this call.
                            // It counts as "inactive" because the failure will decrement the active session count already.
                            // Note that the only way success is false is if we're throwing an exception, so we'll never release it
                            // *and* then return it.
                            if (!success)
                            {
                                ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: false);
                            }
                        }
                    }
                }
            }

            private Task<PooledSession> GetSessionAcquisitionTask(ModeOneofCase transactionMode, CancellationToken cancellationToken)
            {
                // Three scenarios for initial session picking:
                // - No transaction options: take a read-only session as-is
                // - Read/write transaction options: take a read/write session as-is
                // - Other options (a non-single-use read-only bound, or PDML): take a read-only session, but fetch a transaction with it before returning it.
                // If there's no session of the appropriate type, take the other kind instead - at the cost of either wasting an existing read/write
                // transaction, or having to acquire a read/write transaction.
                ConcurrentStack<PooledSession> preferredStack = _readOnlySessions;
                ConcurrentStack<PooledSession> alternateStack = _readWriteSessions;
                if (transactionMode == ModeOneofCase.ReadWrite)
                {
                    preferredStack = _readWriteSessions;
                    alternateStack = _readOnlySessions;
                }
                lock (_lock)
                {
                    // First try the pool.
                    if (preferredStack.TryPop(out var session) || alternateStack.TryPop(out session))
                    {
                        // Slight inefficiency wrapping this in a task, but it makes the implementation simpler.
                        return Task.FromResult(session);
                    }

                    // No pool entries.
                    // If the pool is currently healthy, register a TCS in the queue that will be checked by incoming sessions.
                    if (Healthy)
                    {
                        TaskCompletionSource<PooledSession> receivingTcs = new TaskCompletionSource<PooledSession>();
                        _pendingAcquisitions.Enqueue(receivingTcs);
                        return receivingTcs.WithCancellationToken(cancellationToken);
                    }
                    else
                    {
                        // Otherwise, drop out of the lock to create sessions from scratch "inline" (still asynchronously, but not via an in-flight request).
                        // This means basically to try and nurse the pool back to health.
                    }
                }
                // Effectively the "else" block above, but outside the lock
                return NurseAndRetryAsync();

                // Just to hide the "await" here so we don't have to make this method (GetSessionAcquisitionTask) async.
                // Because we cannot await inside the lock, the only way to make GetSessionAcquisitionTask
                // async is to have it return Task<Task<PooledSession>> which is weird.
                async Task<PooledSession> NurseAndRetryAsync()
                {
                    await GetNursePoolBackToHealthTask(cancellationToken).ConfigureAwait(false);

                    // If we reached this point the nursing task succeeded and the pool is healthy.
                    var acquisitionTask = GetSessionAcquisitionTask(transactionMode, cancellationToken);
                    // Although the pool is back to being healthy, it might be depleted, since for making it healthy
                    // we only created the last failed batch worth of sessions. Let's try and make it ready again.
                    StartSessionCreationTasksIfNecessary();
                    return await acquisitionTask.ConfigureAwait(false);
                }
            }

            private void EvictSession(PooledSession session)
            {
                Interlocked.Decrement(ref _liveOrRequestedSessionCount);
                Parent.DeleteSessionFireAndForget(session);
            }

            /// <summary>
            /// Release a session back to the pool (or refresh) but don't change the number of active sessions.
            /// </summary>
            /// <param name="session">The session to stack. Should be "active" (i.e. not disposed)</param>
            /// <param name="maybeCreateReadWriteTransaction">Whether to allow the session to go through a cycle of acquiring a read/write transaction.
            /// This is true unless we've just come from attempting to create a read/write transaction, in which case either we succeeded (no need
            /// to create a new one) or failed (in which case we should just keep it read-only).
            /// </param>
            private void ReleaseInactiveSession(PooledSession session, bool maybeCreateReadWriteTransaction)
            {
                if (Shutdown)
                {
                    EvictSession(session);
                    return;
                }

                if (session.RequiresRefresh)
                {
                    // RefreshAsync will then release the refreshed session itself - which
                    // may trigger a transaction request as well. But eventually, it'll get
                    // back to the pool (or a waiting consumer).
                    Parent.ConsumeBackgroundTask(RefreshAsync(session), "session refresh");
                    return;
                }

                // There are a couple of cases where we need to take an action outside the lock after breaking
                // out of the loop. It's simplest to remember that in a delegate.
                Action outsideLockAction = null;

                // We need to atomically (within the lock) decide between:
                // - Adding the session to a pool stack (adding performed within the lock)
                // - Providing the session to a waiting caller (setting the result peformed outside the lock)
                // - If it's currently not got a transaction but we need more read/write transactions, starting a transaction
                // In the last case, we will come back to this code to make another decision later.
                while (true)
                {
                    TaskCompletionSource<PooledSession> pendingAquisition;
                    lock (_lock)
                    {
                        // Only add a session to a stack if there are no pending acquisitions.
                        if (!_pendingAcquisitions.TryDequeue(out pendingAquisition))
                        {
                            // Options:
                            // - Decide to create a new read/write transaction (will get back here later)
                            // - Push the current session as read-only or read/write depending on its mode
                            ConcurrentStack<PooledSession> stack;

                            // If the session already has a read/write transaction, add it to the read/write pool immediately.
                            // Otherwise, work out whether we *want* it to be read/write.
                            if (session.TransactionMode == ModeOneofCase.ReadWrite)
                            {
                                stack = _readWriteSessions;
                            }
                            else
                            {
                                var readCount = _readOnlySessions.Count;
                                var writeCount = _readWriteSessions.Count;
                                // Avoid division by zero by including the new session in the denominator.
                                var writeProportion = writeCount / (writeCount + readCount + 1.0);
                                bool createReadWriteTransaction = maybeCreateReadWriteTransaction && writeProportion < Options.WriteSessionsFraction;
                                if (createReadWriteTransaction)
                                {
                                    // Exit the loop, and acquire a read/write transaction
                                    outsideLockAction = () => Parent.ConsumeBackgroundTask(TryCreateReadWriteTransactionAndReturnToPool(session), "transaction creation");
                                    break;
                                }
                                else
                                {
                                    // At this point we didn't already have a r/w transaction, and we don't want to
                                    // create one, so add it to the pool of read-only sessions.
                                    stack = _readOnlySessions;
                                }
                            }
                            // We definitely have a stack now, so add the session to it, and
                            // potentially release tasks waiting for the pool to reach minimum size.
                            stack.Push(session);

                            int poolSize = _readOnlySessions.Count + _readWriteSessions.Count;
                            if (poolSize >= Options.MinimumPooledSessions && _minimumSizeWaiters.Count > 0)
                            {
                                var minimumSizeWaiters = _minimumSizeWaiters.ToList();
                                outsideLockAction = () => minimumSizeWaiters.ForEach(tcs => tcs.TrySetResult(0));
                            }
                            break;
                        }
                    }

                    // We perform TrySetResult outside the lock, to avoid executing any synchronous continuations inside the lock.
                    if (pendingAquisition.TrySetResult(session))
                    {
                        return;
                    }
                    // The task had been cancelled by the caller. Go round the loop again. (There may or may not be more pending acquisitions.)
                }

                // If we've got anything to execute outside the lock, do so now.
                outsideLockAction?.Invoke();
            }

            /// <summary>
            /// Refreshes a session by setting executing a trivial SELECT SQL statement.
            /// This is performed via the client session itself so it can update its next refresh time.
            /// </summary>
            private async Task RefreshAsync(PooledSession session)
            {
                // While we're refreshing a session, it's as if we're creating a new one - it's a period of time
                // where there's already an RPC in flight, and when it completes a session will be available.
                Interlocked.Increment(ref _inFlightSessionCreationCount);
                try
                {
                    var callSettings = Client.Settings.ExecuteSqlSettings.WithExpiration(Expiration.FromTimeout(Options.Timeout));
                    await session.ExecuteSqlAsync(new ExecuteSqlRequest { Sql = "SELECT 1" }, callSettings).ConfigureAwait(false);
                }
                catch (RpcException e)
                {
                    Parent._logger.LogWarning(e, "Failed to refresh session. Session will be deleted.");
                    EvictSession(session);
                    return;
                }
                finally
                {
                    Interlocked.Decrement(ref _inFlightSessionCreationCount);
                }
                // We now definitely don't have a transaction.
                ReleaseInactiveSession(session.WithTransaction(null, ModeOneofCase.None), maybeCreateReadWriteTransaction: true);
            }

            private async Task TryCreateReadWriteTransactionAndReturnToPool(PooledSession session)
            {
                try
                {
                    session = await BeginTransactionAsync(session, s_readWriteOptions, CancellationToken.None).ConfigureAwait(false);
                }
                catch (RpcException e)
                {
                    // Failed to create a read/write transaction; release this back to the pool, but making
                    // sure we don't come back here.
                    Parent._logger.LogWarning(e, "Failed to create read/write transaction for pooled session");
                }
                ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: false);
            }

            private async Task<PooledSession> BeginTransactionAsync(PooledSession session, TransactionOptions options, CancellationToken cancellationToken, bool isSessionAcquired = false)
            {
                // While we're creating a transaction, it's as if we're preparing a new session - it's a period of time
                // where there's already an RPC in flight, and when it completes a session will be available.
                // But if that session is being held by calling code already, and we are here because client code
                // requested a transaction refresh then we can't count the session as if it were being prepared
                // because after the transaction is refreshed the session won't be release back to the pool, it will still
                // be held by calling code.
                if (!isSessionAcquired)
                {
                    Interlocked.Increment(ref _inFlightSessionCreationCount);
                }
                var request = new BeginTransactionRequest { Options = options };
                try
                {
                    var callSettings = Client.Settings.BeginTransactionSettings
                        .WithExpiration(Expiration.FromTimeout(Options.Timeout))
                        .WithCancellationToken(cancellationToken);
                    var transaction = await session.BeginTransactionAsync(request, callSettings).ConfigureAwait(false);
                    return session.WithTransaction(transaction.Id, options.ModeCase, transaction.ReadTimestamp);
                }
                finally
                {
                    if (!isSessionAcquired)
                    {
                        Interlocked.Decrement(ref _inFlightSessionCreationCount);
                    }
                }
            }

            public override Task<PooledSession> WithFreshTransactionOrNewAsync(PooledSession session, TransactionOptions transactionOptions, CancellationToken cancellationToken)
            {
                if (session.RequiresRefresh)
                {
                    // Let's just release it back to the pool, that will handle the refreshing etc.
                    session.ReleaseToPool(false);
                }
                else
                {
                    try
                    {
                        // Let's try to begin a new transaction for this same session.
                        return BeginTransactionAsync(session, transactionOptions, cancellationToken, true);
                    }
                    catch(RpcException e)
                    {
                        Parent._logger.LogWarning(e, "Failed to create transaction for acquired session");
                        // Failed to create the transaction for the session.
                        // Release the session back to the pool.
                        // We'll try to acquire a new session now.
                        session.ReleaseToPool(false);
                    }
                }
                // If we are here we need to acquire a new session.
                return AcquireSessionAsync(transactionOptions, cancellationToken);
            }

            /// <summary>
            /// Release a session back to the pool (or refresh or evict it) and decrement the number of active sessions.
            /// All the work is done in a background task, as it can involve RPCs.
            /// </summary>
            public override void Release(PooledSession session, ByteString transactionId, bool deleteSession) =>
                Parent.ConsumeBackgroundTask(ReleaseAsync(session, transactionId, deleteSession), "session release");

            private async Task ReleaseAsync(PooledSession session, ByteString transactionId, bool deleteSession)
            {
                Interlocked.Decrement(ref _activeSessionCount);
                // If we've got a transaction to rollback, do that first.
                if (transactionId is object)
                {
                    var request = new RollbackRequest { SessionAsSessionName = session.SessionName, TransactionId = transactionId };
                    try
                    {
                        await Client.RollbackAsync(request).ConfigureAwait(false);
                    }
                    catch (RpcException e)
                    {
                        // Rollback failed. Evict the session as it's effectively unstable now.
                        Parent._logger.LogWarning(e, "Failed to rollback transaction for pooled session");
                        deleteSession = true;
                    }
                }
                if (deleteSession)
                {
                    EvictSession(session);
                }
                else
                {
                    ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: true);
                }
            }

            internal void MaintainPool()
            {
                if (Shutdown)
                {
                    return;
                }
                EvictAndRefreshSessions();
                StartSessionCreationTasksIfNecessary();
                if (Parent._logger.IsEnabled(LogLevel.Debug))
                {
                    Parent._logger.LogDebug("After maintenance: {stats}", GetStatisticsSnapshot());
                }
            }

            private void EvictAndRefreshSessions()
            {
                LinkedList<PooledSession> sessionsToEvict = new LinkedList<PooledSession>();
                LinkedList<PooledSession> staleSessions = new LinkedList<PooledSession>();
                lock (_lock)
                {
                    RemoveStaleOrExpiredItemsFromStack(_readOnlySessions);
                    RemoveStaleOrExpiredItemsFromStack(_readWriteSessions);
                }

                foreach (var session in sessionsToEvict)
                {
                    EvictSession(session);
                }
                foreach (var session in staleSessions)
                {
                    Parent.ConsumeBackgroundTask(RefreshAsync(session), "session refresh");
                }

                void RemoveStaleOrExpiredItemsFromStack(ConcurrentStack<PooledSession> stack)
                {
                    // TryPopRange will fail when receiving a zero sized array even if the stack is empty.
                    // So we always create the array one element bigger than the stack size.
                    PooledSession[] sessions = new PooledSession[stack.Count + 1];
                    // Use the actual count of elements popped to check for evicted sessions.
                    // It doesn't matter that the array might be bigger or smaller than the stack
                    // current size. TryPopRange will try to pop as many elements as sessions.Length
                    // but will return the actual number of elements popped.
                    // Also, because right now this code is executed inside the lock, the stack won't
                    // probably change from when we created the array to this point, but by using the 
                    // actual number of elements popped we are making it more robust for any future changes.
                    int count;
                    if ((count = stack.TryPopRange(sessions)) > 0)
                    {
                        // TryPopRange will store elements in the array in the same order
                        // they would have been popped individually starting at index 0.
                        // That is, the element at index 0 would have been the first to pop,
                        // the element at index 1 would have popped after that, etc.
                        // For sessions that are not stale, we want to maintain the same order
                        // on the stack, so we need to check the popped sessions from last to first
                        // before adding them back on to the stack.
                        for (int i = count - 1; i >= 0; i--)
                        {
                            PooledSession session = sessions[i];
                            if (session.ShouldBeEvicted)
                            {
                                sessionsToEvict.AddLast(session);
                            }
                            else if (session.RequiresRefresh)
                            {
                                staleSessions.AddLast(session);
                            }
                            else
                            {
                                // The session is fine - put it back on the stack.
                                stack.Push(session);
                            }
                        }
                    }
                }
            }

            /// <summary>
            /// Starts tasks to create new sessions if that's necessary to get the pool to a minimum size or to
            /// service queued callers. It's possible that we'll end up with more sessions than we want or need
            /// if an active request calls this at exactly the same time as the maintenance task, but that's not too
            /// bad.
            /// </summary>
            private void StartSessionCreationTasksIfNecessary()
            {
                // Let's start the loop on the background as well, since it acquires the lock
                // on each iteration to check if there are sessions to be created.
                Parent.ConsumeBackgroundTask(Task.Run(() =>
                {
                    while (Healthy && !Shutdown && ShouldCreateMoreSessions(out int _))
                    {
                        Parent.ConsumeBackgroundTask(PrepareNewSessionsAsync(), "session creation");
                    }
                }), "start session creation if necessary");

                async Task PrepareNewSessionsAsync()
                {
                    try
                    {
                        var sessions = await CreatePooledSessionsAsync(CancellationToken.None).ConfigureAwait(false);
                        foreach (var session in sessions)
                        {
                            ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: true);
                        }
                    }
                    // Note: we expect this to always actually be an RpcException, but we don't want to end up unhealthy
                    // with a lot of waiting callers.
                    catch (Exception e)
                    {
                        // CreatePooledSessionAsync will have caused the session pool to become unhealthy already, so we shouldn't get
                        // any new waiting callers at this point. 
                        // Propagate this exception to all waiting callers.
                        List<TaskCompletionSource<PooledSession>> pendingAcquisitionsList = new List<TaskCompletionSource<PooledSession>>();
                        List<TaskCompletionSource<int>> minimumSizeWaiters;
                        lock (_lock)
                        {
                            // Don't set the exception in the lock.
                            while (_pendingAcquisitions.TryDequeue(out var acquisition))
                            {
                                pendingAcquisitionsList.Add(acquisition);
                            }
                            minimumSizeWaiters = _minimumSizeWaiters.ToList();
                        }
                        // TODO: Is this too drastic, just for a single failure?
                        pendingAcquisitionsList.ForEach(tcs => tcs.TrySetException(e));
                        minimumSizeWaiters.ForEach(tcs => tcs.TrySetException(e));
                    }
                }
            } 

            private Task GetNursePoolBackToHealthTask(CancellationToken cancellationToken)
            {
                if (Healthy || Shutdown)
                {
                    return Task.FromResult(1);
                }
                // If already being nursed back to health, wait for that to be done.
                var newTcs = new TaskCompletionSource<int>();
                var previousTcs = Interlocked.CompareExchange(ref _nurseBackToHealthTask, newTcs, null);
                if (previousTcs != null)
                {
                    return WithCancellationTokenAsync(previousTcs.Task, cancellationToken);
                }

                // We want to try and nurse the pool back to health even if the (first) caller cancels the call.
                // That is if the caller cancels the call, we want to stop waiting for the nursing but we actually
                // want the nursing to continue.
                Parent.ConsumeBackgroundTask(Task.Run(async () =>
                {
                    try
                    {
                        // Not using the cancellation token here so this can go on even if the caller cancels the call.
                        var sessions = await CreatePooledSessionsAsync(CancellationToken.None).ConfigureAwait(false);
                        foreach (var session in sessions)
                        {
                            ReleaseInactiveSession(session, maybeCreateReadWriteTransaction: true);
                        }

                        // We have succesfully nursed the pool back to health.
                        newTcs.TrySetResult(1);
                    }
                    // Note: we expect this to always actually be an RpcException, but we don't want to end up unhealthy
                    // with a lot of waiting callers.
                    catch (Exception e)
                    {
                        // We couldn't nurse the pool back to health.
                        // Notify all callers waiting for the pool to be healthy again.
                        // This includes the caller that initiated the nursing, that one is also waiting on
                        // newTcs and not on this task, we are executing this task as a fire and forget task.
                        newTcs.TrySetException(e);

                        // In contrast with StartSessionCreationTasksIfNecessary.PrepareNewSessionsAsync here
                        // we don't need to notify callers waiting for new sessions to become available that the
                        // pool is now unhealthy, this method is only called when the pool is already unhealthy
                        // so callers waiting for sessions had already been notified by 
                        // StartSessionCreationTasksIfNecessary.PrepareNewSessionsAsync, which is the method that
                        // first "discovers" that the pool has become unhealthy.
                    }
                    finally
                    {
                        // Whatever happened we are done nursing the pool back to health.
                        Interlocked.CompareExchange(ref _nurseBackToHealthTask, null, newTcs);
                    }
                }), "nurse pool back to health" );

                // Use the cancellation token now, if the caller cancels, the task they are waiting on will be canceled,
                // but not the nursing.
                return WithCancellationTokenAsync(newTcs.Task, cancellationToken);

                async Task<TTaskResult> WithCancellationTokenAsync<TTaskResult>(Task<TTaskResult> underlying, CancellationToken token)
                {
                    TaskCompletionSource<TTaskResult> cancellable = new TaskCompletionSource<TTaskResult>();
                    using (token.Register(() => cancellable.TrySetCanceled()))
                    {
                        Task<TTaskResult> completedTask = await Task.WhenAny(underlying, cancellable.Task).ConfigureAwait(false);
                        return await completedTask.ConfigureAwait(false);
                    }
                }
            }

            private async Task<IList<PooledSession>> CreatePooledSessionsAsync(CancellationToken cancellationToken)
            {
                int batchSize;
                lock (_lock)
                {
                    if (ShouldCreateMoreSessions(out batchSize))
                    {
                        Interlocked.Add(ref _inFlightSessionCreationCount, batchSize);
                        Interlocked.Add(ref _liveOrRequestedSessionCount, batchSize);
                    }
                    else
                    {
                        return new List<PooledSession>();
                    }
                }

                bool success = false;
                bool canceled = false;
                int actualCreatedSessions = 0;
                try
                {
                    var callSettings = Client.Settings.BatchCreateSessionsSettings
                        .WithExpiration(Expiration.FromTimeout(Options.Timeout))
                        .WithCancellationToken(cancellationToken);

                    BatchCreateSessionsRequest batchCreateSessionRequest = _batchCreateSessionRequestTemplate.Clone();
                    batchCreateSessionRequest.SessionCount = batchSize;

                    BatchCreateSessionsResponse batchSessionCreateResponse;
                    IList<PooledSession> pooledSessions = new List<PooledSession>(batchSize);

                    bool acquiredSemaphore = false;
                    try
                    {
                        await Parent._batchSessionCreateSemaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
                        acquiredSemaphore = true;
                        batchSessionCreateResponse = await Client.BatchCreateSessionsAsync(batchCreateSessionRequest, callSettings).ConfigureAwait(false);
                        success = true;
                        actualCreatedSessions = batchSessionCreateResponse.Session.Count;

                        foreach(var sessionProto in batchSessionCreateResponse.Session)
                        {
                            pooledSessions.Add(PooledSession.FromSessionName(this, sessionProto.SessionName));
                        }
                        return pooledSessions;
                    }
                    catch (OperationCanceledException)
                    {
                        canceled = true;
                        throw;
                    }
                    finally
                    {
                        if (acquiredSemaphore)
                        {
                            Parent._batchSessionCreateSemaphore.Release();
                        }
                    }
                }
                catch(Exception e)
                {
                    Parent._logger.LogWarning(e, "Failed to batch create sessions for {db}", _databaseName);
                    throw;
                }
                finally
                {
                    bool writeHealthChangedLog = false;
                    lock (_lock)
                    {
                        // Atomically set _lastUnhealthyBatchSize and determine whether we were previously healthy, but only if either we've succeeded,
                        // or we failed for a reason other than cancellation. We don't want to go unhealthy just because a caller cancelled
                        // a cancellation token before we had chance to create the session.
                        if (success || !canceled)
                        {
                            bool wasHealthy = Interlocked.Exchange(ref _lastUnhealthyBatchSize, success ? 0 : batchSize) == 0;
                            writeHealthChangedLog = wasHealthy != success;
                        }

                        // We requested batchSize sessions to be created, but in reality actualCreatedSession were created, which are now live.
                        // Note that actualCreatedSessions might be 0 either because the call failed or because no sessions were created.
                        Interlocked.Add(ref _liveOrRequestedSessionCount, -batchSize + actualCreatedSessions);

                        Interlocked.Add(ref _inFlightSessionCreationCount, -batchSize);
                    }
                    if (writeHealthChangedLog)
                    {
                        Parent._logger.LogInformation("Session pool for {db} is now {status}.", _databaseName, success ? "healthy" : "unhealthy");
                    }
                }
            }

            private bool ShouldCreateMoreSessions(out int batchSize)
            {
                lock (_lock)
                {
                    if (Healthy)
                    {
                        int poolSize = _readWriteSessions.Count + _readOnlySessions.Count;

                        // Determine how many more sessions to create.
                        // We want to make sure that if all existing and new requests for session creation succeed:
                        // - All queuing callers will have a session
                        // - The pool will have at least as many entries as the options specify
                        // However, we don't want to end up with more than the maximum number of active sessions
                        // in the options.

                        // In reality, the current pool size should be 0 if pendingAcquisitionCount is non-zero, and
                        // vice versa. However, we don't strictly enforce this, and the maths works out more simply if
                        // we don't worry about it.

                        // How many more sessions do we need to create in order to get the pool to the minimum size, after satisfying
                        // pending callers, assuming that all the in-flight session requests succeed, and there are no more requests?
                        int newSessionsToSatisfyPool = (_pendingAcquisitions.Count + Options.MinimumPooledSessions) - (poolSize + InFlightSessionCreationCount);
                        // How many more sessions *can* we create without going over the maximum number of active sessions?
                        int maxPossibleNewSessions = Options.MaximumActiveSessions - LiveOrRequestedSessionCount;

                        int remainingNewSessions = Math.Min(newSessionsToSatisfyPool, maxPossibleNewSessions);
                        batchSize = Math.Min(remainingNewSessions, Options.CreateSessionMaximumBatchSize);
                    }
                    else
                    {
                        batchSize = LastUnhealthyBatchSize;
                    }

                    return batchSize > 0;
                }
            }

            internal DatabaseStatistics GetStatisticsSnapshot()
            {
                lock (_lock)
                {
                    return new DatabaseStatistics(
                        _databaseName,
                        ActiveSessionCount,
                        _readOnlySessions.Count,
                        _readWriteSessions.Count,
                        InFlightSessionCreationCount,
                        _pendingAcquisitions.Count,
                        Interlocked.CompareExchange(ref _rwTransactionRequests, 0L, 0L),
                        Interlocked.CompareExchange(ref _rwTransactionRequestsPrewarmed, 0L, 0L),
                        Healthy,
                        Shutdown);
                }
            }

            /// <summary>
            /// Returns a task indicating when the session pool is populated up to its minimum size.
            /// </summary>
            /// <remarks>
            /// If the pool is unhealthy or becomes unhealthy before it reaches its minimum size,
            /// the returned task will be faulted with an <see cref="RpcException"/>.
            /// </remarks>
            /// <param name="cancellationToken">An optional token for canceling the call.</param>
            /// <returns>A task which will complete when the session pool has reached its minimum size.</returns>
            internal async Task WhenPoolReady(CancellationToken cancellationToken = default)
            {
                Task task;
                LinkedListNode<TaskCompletionSource<int>> node;
                // Check whether we know the result immediately.
                lock (_lock)
                {
                    if (!Healthy)
                    {
                        throw new RpcException(new Status(StatusCode.Unknown, "Session pool was unhealthy"));
                    }
                    if (_readOnlySessions.Count + _readWriteSessions.Count >= Options.MinimumPooledSessions)
                    {
                        return;
                    }
                    var tcs = new TaskCompletionSource<int>();
                    node = _minimumSizeWaiters.AddLast(tcs);
                    task = tcs.WithCancellationToken(cancellationToken);
                }
                await task.ConfigureAwait(false);
                lock (_lock)
                {
                    node.List.Remove(node);
                }
            }

            internal Task ShutdownPoolAsync(CancellationToken cancellationToken)
            {
                // Shutdown can only be started once, but we can acquire the same task as often as we want.
                var newTcs = new TaskCompletionSource<int>();
                var previousTcs = Interlocked.CompareExchange(ref _shutdownTask, newTcs, null);

                if (previousTcs == null)
                {
                    Parent.ConsumeBackgroundTask(ExecuteShutdownAsync(newTcs), "shutdown");
                }

                // Return the appropriate TCS, with the given cancellation token.
                var tcs = previousTcs ?? newTcs;
                return tcs.WithCancellationToken(cancellationToken);
            }

            /// <summary>
            /// Performs the actual shutdown of the pool. This method should only be called once per pool.
            /// </summary>
            private async Task ExecuteShutdownAsync(TaskCompletionSource<int> tcsToSignal)
            {
                // It's somewhat ugly to do this in a loop, and after the first iteration we'll *mostly* just be waiting for
                // the active session count and in-flight session creation count to hit 0... but it means we don't need to worry
                // about race conditions of one thread checking the shutdown flag just before it was set, but then adding a
                // pending acquisition just after we've cancelled everything.
                Parent._logger.LogDebug("Executing shutdown for {db}", _databaseName);
                try
                {
                    while (true)
                    {
                        lock (_lock)
                        {
                            if (_readWriteSessions.Count == 0 &&
                                _readOnlySessions.Count == 0 &&
                                ActiveSessionCount == 0 &&
                                InFlightSessionCreationCount == 0 &&
                                _pendingAcquisitions.Count == 0 &&
                                _minimumSizeWaiters.Count == 0)
                            {
                                // It's possible that there are some sessions still being deleted at this point, but waiting for those
                                // tasks to complete would be awkward and it's very unlikely to make any material difference.
                                break;
                            }
                        }

                        Parent._logger.LogDebug("Pending shutdown: {statistics}", GetStatisticsSnapshot());

                        var nursingTask = Interlocked.Exchange(ref _nurseBackToHealthTask, null);
                        nursingTask?.TrySetCanceled();

                        var sessionsToDelete = new List<PooledSession>();
                        List<TaskCompletionSource<int>> minSizeWaitersToCancel;
                        List<TaskCompletionSource<PooledSession>> pendingAcquisitionsToCancel = new List<TaskCompletionSource<PooledSession>>();
                        lock (_lock)
                        {
                            while (_readOnlySessions.TryPop(out var session))
                            {
                                sessionsToDelete.Add(session);
                            }
                            while (_readWriteSessions.TryPop(out var session))
                            {
                                sessionsToDelete.Add(session);
                            }
                            // These will clear themselves out of the list when they complete, even with a fault.
                            minSizeWaitersToCancel = _minimumSizeWaiters.ToList();
                            while (_pendingAcquisitions.TryDequeue(out var pendingAcquisitions))
                            {
                                pendingAcquisitionsToCancel.Add(pendingAcquisitions);
                            }
                        }

                        pendingAcquisitionsToCancel.ForEach(tcs => tcs.TrySetCanceled());
                        minSizeWaitersToCancel.ForEach(tcs => tcs.TrySetCanceled());
                        List<Task> tasks = sessionsToDelete.Select(cs => Parent.DeleteSessionAsync(cs)).ToList();

                        try
                        {
                            await Task.WhenAll(tasks).ConfigureAwait(false);
                        }
                        catch
                        {
                            var failureCount = tasks.Count(t => t.Status != TaskStatus.RanToCompletion);
                            Parent._logger.LogWarning("{failureCount} out of {totalCount} deletion tasks failed during shutdown", failureCount, tasks.Count);
                        }

                        await Parent._scheduler.Delay(TimeSpan.FromSeconds(1), CancellationToken.None).ConfigureAwait(false);
                    }
                }
                // However we complete, signal that shutdown is finished.
                finally
                {
                    Parent._logger.LogDebug("Shutdown complete for {db}", _databaseName);
                    tcsToSignal.TrySetResult(0);
                }
            }
        }
    }
}
