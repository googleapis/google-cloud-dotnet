// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Google.Api.Gax;
using Google.Cloud.Spanner.V1.Internal;
using Google.Cloud.Spanner.V1.Internal.Logging;
using Google.Protobuf;
using Google.Api.Gax.Grpc;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// The TransactionPool works in conjunction with the Session pool to warm pooled Sessions
    /// with the transaction semantics it last used (if appropriate).
    /// When requesting a pooled session, the request can include TransactionOptions which
    /// is then used as a key in the SessionPool.
    /// </summary>
    public static class TransactionPool
    {
        // Holds transaction state on sessions, including the last created transaction and options used.
        static readonly ConcurrentDictionary<Session, SessionInfo> s_sessionInfoTable = new ConcurrentDictionary<Session, SessionInfo>();

        // Holds a list of all active transactions with back pointers to the owning session.
        static readonly ConcurrentDictionary<ByteString, Session> s_activeTransactionTable = new ConcurrentDictionary<ByteString, Session>();

        private static Logger Logger { get; } = Logger.DefaultLogger;

        /// <summary>
        /// Creates a transaction with the given transaction options.
        /// Depending on the state of the session, this may or may not result in a request
        /// to Spanner over the network.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="client"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static async Task<Transaction> BeginPooledTransactionAsync(this SpannerClient client, Session session,
            TransactionOptions options)
        {
            var info = s_sessionInfoTable.GetOrAdd(session, s => new SessionInfo(client));

            //we need to await for previous task completion anyway -- otherwise there is a bad race condition.
            await info.WaitForPreWarmAsync().ConfigureAwait(false);

            //now we see if we can return the prewarmed transaction.
            // a lot has to be correct for us to return the precreated transaction.
            // we have to have a valid transaction object.
            // it needs to exist in the activetransactiontable to indicate that it hasn't been closed
            // the options on it must equal the passed in options.
            if (info.HasActiveTransaction
                && s_activeTransactionTable.ContainsKey(info.ActiveTransaction.Id))
            {
                if (info.TransactionOptions != null
                    && info.TransactionOptions.Equals(options))
                {
                    Logger.LogPerformanceCounterFn("Transaction.CacheHit", (x) => x + 1);
                    return info.ActiveTransaction;
                }
                //cache hit, but no match on options
                Session ignored;
                s_activeTransactionTable.TryRemove(info.ActiveTransaction.GetTransactionId(), out ignored);
            }

            //ok, our cache hit didnt work for whatever reason.  Let's create a transaction with the given options and return it.
            Logger.LogPerformanceCounterFn("Transaction.CacheMiss", (x) => x + 1);
            await info.CreateTransactionAsync(session, options).ConfigureAwait(false);
            if (info.ActiveTransaction != null)
            {
                s_activeTransactionTable.AddOrUpdate(info.ActiveTransaction.GetTransactionId(), session, (id, s) => session);
            }
            return info.ActiveTransaction;
        }

        /// <summary>
        /// When a session is deleted or no longer used, this will remove it from the transaction pool.
        /// </summary>
        /// <param name="session"></param>
        public static async Task RemoveFromTransactionPoolAsync(this Session session)
        {
            SessionInfo info;
            if (s_sessionInfoTable.TryGetValue(session, out info))
            {
                //we need to await for previous task completion anyway -- otherwise there is a bad race condition.
                await info.WaitForPreWarmAsync().ConfigureAwait(false);
                if (info.HasActiveTransaction)
                {
                    Session ignored;
                    s_activeTransactionTable.TryRemove(info.ActiveTransaction.GetTransactionId(), out ignored); //clear out old tx.
                }
                s_sessionInfoTable.TryRemove(session, out info); //implicit transaction is active on session.
            }
        }

        /// <summary>
        /// Returns the last used transactionoptions for CreateTransactionAsync.
        /// It may return null if the the session was set to use implicit transactions.
        /// </summary>
        /// <param name="session"></param>
        /// <returns></returns>
        internal static TransactionOptions GetLastUsedTransactionOptions(this Session session)
        {
            SessionInfo info;
            if (s_sessionInfoTable.TryGetValue(session, out info))
            {
                return info.TransactionOptions;
            }
            return null;
        }

        internal static bool IsPreWarmedTransactionReady(this Session session)
        {
            SessionInfo info;
            if (s_sessionInfoTable.TryGetValue(session, out info))
            {
                return info.HasActiveTransaction;
            }
            return false;
        }

        /// <summary>
        /// Starts a pre-warm background task to create a transaction on the given session with the
        /// last used transaction options.  This method will only work if CreateTransactionAsync
        /// was previously used to create the transaction on the session.
        /// </summary>
        /// <param name="session"></param>
        /// <param name="client"></param>
        internal static void StartPreWarmTransaction(this SpannerClient client, Session session)
        {
            TransactionOptions options = session.GetLastUsedTransactionOptions();
            var info = s_sessionInfoTable.GetOrAdd(session, s => new SessionInfo(client));
            info.StartPreWarmTransaction(session, options);
        }

        /// <summary>
        /// Commits a transaction and internally marks the transaction as used.
        /// </summary>
        /// <param name="transaction"></param>
        /// <param name="session"></param>
        /// <param name="mutations"></param>
        /// <param name="timeoutSeconds"></param>
        /// <returns></returns>
        public static Task<CommitResponse> CommitAsync(this Transaction transaction, Session session,
            IEnumerable<Mutation> mutations, int timeoutSeconds)
        {
            return RunFinalMethodAsync(transaction, session, info => info.SpannerClient.CommitAsync(
                            session.SessionName, info.ActiveTransaction.GetTransactionId(), mutations,
                            info.SpannerClient.Settings.CommitSettings.WithExpiration(info.SpannerClient.Settings.ConvertTimeoutToExpiration(timeoutSeconds)))
                        .WithSessionChecking(() => session));
        }

        /// <summary>
        /// Rolls back a transaction and internally marks the transaction as used.
        /// </summary>
        /// <param name="transaction"></param>
        /// <param name="session"></param>
        /// <param name="timeoutSeconds"></param>
        /// <returns></returns>
        public static Task<bool> RollbackAsync(this Transaction transaction, Session session, int timeoutSeconds)
        {
            return RunFinalMethodAsync(transaction, session,
                async info =>
                {
                    await info.SpannerClient
                        .RollbackAsync(
                            session.GetSessionName(),
                            info.ActiveTransaction.GetTransactionId(),
                            info.SpannerClient.Settings.RollbackSettings.WithExpiration(
                                info.SpannerClient.Settings.ConvertTimeoutToExpiration(timeoutSeconds)))
                        .WithSessionChecking(() => session).ConfigureAwait(false);
                    return true;
                });
        }

        private static async Task<T> RunFinalMethodAsync<T>(Transaction transaction, Session session, Func<SessionInfo, Task<T>> commitOrRollbackAction)
        {
            SessionInfo info;
            if (s_sessionInfoTable.TryGetValue(session, out info))
            {
                //we should have already waited, but extra checking cannot hurt.
                await info.WaitForPreWarmAsync().ConfigureAwait(false);
                if (!info.HasActiveTransaction)
                {
                    throw new InvalidOperationException("The transaction being committed was not found to have an entry.");
                }
                if (info.ActiveTransaction.Id != transaction.Id)
                {
                    throw new InvalidOperationException("The transaction being committed was not found to have a valid entry.");
                }

                try
                {
                    return await commitOrRollbackAction(info).ConfigureAwait(false);
                }
                finally
                {
                    Session ignored;
                    s_activeTransactionTable.TryRemove(info.ActiveTransaction.GetTransactionId(), out ignored);
                    info.MarkTransactionUsed();
                }
            }
            throw new ArgumentException(
                "The given transaction was not found in the transaction pool. Only " +
                "use this method on Transactions returned from TransactionPool." +
                "CreateTransactionAsync.");
        }

        private class SessionInfo
        {
            public SessionInfo(SpannerClient spannerClient)
            {
                SpannerClient = spannerClient;
            }

            public bool HasActiveTransaction
                => ActiveTransaction != null && !ActiveTransaction.Id.IsEmpty;
            public Transaction ActiveTransaction { get; private set; }
            public TransactionOptions TransactionOptions { get; private set; }
            public SpannerClient SpannerClient { get; }
            private Task PreWarmTask { get; set; }

            public void MarkTransactionUsed()
            {
                ActiveTransaction = null;
            }

            public async Task WaitForPreWarmAsync()
            {
                try
                {
                    Task prewarmTask = PreWarmTask;
                    if (prewarmTask != null && !prewarmTask.IsCompleted)
                    {
                        await prewarmTask.ConfigureAwait(false);
                    }
                    PreWarmTask = null;
                }
                catch (Exception e)
                {
                    Logger.Error(() => "An error occurred attemping to prewarm a session.", e);
                }
            }

            public Task CreateTransactionAsync(Session session, TransactionOptions options)
            {
                return CreateTransactionImplAsync(session, options, PreWarmTask);
            }

            private async Task CreateTransactionImplAsync(Session session, TransactionOptions options, Task oldPrewarmTask)
            {
                //we need to await for previous task completion anyway -- otherwise there is a bad race condition.
                //this is a little redundant, but just to be sure.
                if (oldPrewarmTask != null)
                {
                    await oldPrewarmTask.ConfigureAwait(false);
                }
                var sw = Stopwatch.StartNew();
                ActiveTransaction = await SpannerClient.BeginTransactionAsync(new BeginTransactionRequest
                {
                    SessionAsSessionName = session.SessionName,
                    Options = options
                }).WithSessionChecking(() => session).ConfigureAwait(false);

                Logger.LogPerformanceCounterFn("Transaction.Begin.Duration", x => sw.ElapsedMilliseconds);
                TransactionOptions = options;
                s_activeTransactionTable.AddOrUpdate(ActiveTransaction.Id, session, (id, s) => session);
            }

            public void StartPreWarmTransaction(Session session, TransactionOptions options)
            {
                MarkTransactionUsed();

                // for now, we only prewarm readwrite transactions because the read transaction semantics are usually
                // dependent on the time the transaction begins.
                if (options?.ModeCase == TransactionOptions.ModeOneofCase.ReadWrite)
                {
                    var oldTask = PreWarmTask;
                    Logger.Debug(
                        () => $"Pre-warming session transaction state. Mode={options.ModeCase}");
                    PreWarmTask = Task.Run(() => CreateTransactionImplAsync(session, options, oldTask));
                }
                else
                {
                    PreWarmTask = null;
                }
            }
        }

    }
}
