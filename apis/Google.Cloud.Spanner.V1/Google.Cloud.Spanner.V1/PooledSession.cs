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
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Threading;
using System.Threading.Tasks;
using static Google.Cloud.Spanner.V1.TransactionOptions;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// A session from a <see cref="SessionPool"/>, with an associated transaction if
    /// requested. Instances must be released back to the pool via <see cref="ReleaseToPool(bool)"/>.
    /// </summary>
    /// <remarks>
    /// <para>
    /// Each method in this class modifies requests passed as arguments to RPC methods, to populate
    /// the session and transaction properties.
    /// </para>
    /// <para>
    /// This class keeps track of successful RPCs to update its internal refresh timer. This can't
    /// be applied for streaming SQL calls, as <see cref="ReliableStreamReader"/> performs the actual
    /// RPCs in that case.
    /// </para>
    /// </remarks>
    public sealed class PooledSession : IDisposable
    {
        private readonly ManagedTransaction _managedTransaction;

        /// <summary>
        /// The name of the session. This is never null.
        /// </summary>
        public SessionName SessionName => _managedTransaction.SessionName;

        /// <summary>
        /// The ID of the transaction. May be null.
        /// </summary>
        /// <remarks>
        /// Transactions are acquired when they are needed so this will be null in the
        /// following cases:
        /// <list type="bullet">
        /// <item>
        /// <see cref="TransactionOptions"/> is <see cref="TransactionOptions.ModeOneofCase.None"/>,
        /// including when the session is idle in the pool.
        /// </item>
        /// <item>
        /// This is a single use transaction. No transactions will exist client side.
        /// </item>
        /// <item>
        /// The session has been acquired from the pool with some transaction options but no command execution has
        /// been attempted since.
        /// </item>
        /// <item>
        /// The first command execution is underway and the transaction is being created either
        /// by inlining or explicitly.
        /// </item>
        /// </list>
        /// </remarks>
        public ByteString TransactionId => _managedTransaction.TransactionId;

        /// <summary>
        /// Whether this session is detached from the session pool or not.
        /// </summary>
        /// <remarks>
        /// Detached sessions are used for transactional operations performed across several processes,
        /// for instance, partitioned reads. See the <see cref="ReleaseToPool(bool)"/> documentation for
        /// information on how to release resources of a detached session gracefully.
        /// </remarks>
#pragma warning disable CS0618 // Type or member is obsolete
        public bool IsDetached => _managedTransaction.Shared;
#pragma warning restore CS0618 // Type or member is obsolete

        /// <summary>
        /// The read timestamp of the transaction. May be null.
        /// </summary>
        /// <remarks>
        /// Will be set iif a transaction has been started and <see cref="TransactionOptions"/> represents read-only options
        /// with <see cref="Types.ReadOnly.ReturnReadTimestamp"/> set to true
        /// or if this session was created using <see cref="SessionPool.CreateDetachedSession(SessionName, ByteString, ModeOneofCase, Timestamp)"/>
        /// and a value was provided for the <see cref="Timestamp"/> parameter.
        /// </remarks>
        public Timestamp ReadTimestamp => _managedTransaction.ReadTimestamp;

        internal ManagedTransaction ManagedTransaction => _managedTransaction;

        internal PooledSession(ManagedTransaction managedTransaction) =>
            _managedTransaction = GaxPreconditions.CheckNotNull(managedTransaction, nameof(managedTransaction));

        /// <summary>
        /// Always returns a new instance of <see cref="PooledSession"/>. The new instance can:
        /// 1. represent the same session as this one, with the same transaction options,
        /// but it won't have a transaction associated to it
        /// 2. represent an entirely different session with the same transaction options
        /// as this <see cref="PooledSession"/> did and no transaction associated to it
        /// If this session has expired then this method will acquire a new session in the normal way.
        /// This <see cref="PooledSession"/> instance will be disposed of to ensure that all operations
        /// with the underlying session are done through the new instance.
        /// </summary>
        /// <remarks>
        /// Use this method when executing operations that are best done using the same
        /// session. For instance, when retrying aborted commits it is better if the transaction work and commit
        /// are retried with the same session, because after each abort the sessions' lock priority increments.
        /// </remarks>
        public Task<PooledSession> RefreshedOrNewAsync(CancellationToken cancellationToken) =>
            Task.FromResult(new PooledSession(_managedTransaction.FreshAfterAbort()));

        /// <summary>
        /// Releases this session back to the session pool. This method should only be called once per instance; subsequent
        /// calls are ignored. No other methods can be called after this.
        /// </summary>
        /// <remarks>
        /// This method is equivalent to calling <see cref="ReleaseToPool(bool)"/> with an argument of <c>false</c>.
        /// </remarks>
        public void Dispose() => ReleaseToPool(false);

        /// <summary>
        /// Returns this session to the session pool from which it was acquired, unless this is a detached session
        /// or it has become invalid. This method should only be called once per instance; subsequent
        /// calls are ignored. No other methods can be called after this.
        /// </summary>
        /// <param name="forceDelete">true to force the session to be deleted; false to allow the session to be reused.</param>
        /// <remarks>
        /// If <see cref="IsDetached"/> is true, the session won't be returned to the pool because its underlying
        /// resources may be being used by other processes. The last process to use this session's underlying resources should
        /// call <see cref="ReleaseToPool(bool)"/> with <paramref name="forceDelete"/> set to true, so that the session resources
        /// are gracefully freed.
        /// </remarks>
        public void ReleaseToPool(bool forceDelete) => Task.Run(() => _managedTransaction.DisposeAsync());

        /// <summary>
        /// Executes a Commit RPC asynchronously.
        /// </summary>
        /// <param name="request">The commit request. Must not be null. The request will be modified with session and transaction details
        /// from this object.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<CommitResponse> CommitAsync(CommitRequest request, CallSettings callSettings) =>
            _managedTransaction.CommitAsync(request, callSettings);

        /// <summary>
        /// Executes a Rollback RPC asynchronously.
        /// </summary>
        /// <param name="request">The rollback request. Must not be null. The request will be modified with session and transaction details
        /// from this object.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        public Task RollbackAsync(RollbackRequest request, CallSettings callSettings) =>
            _managedTransaction?.RollbackAsync(request, callSettings);

        /// <summary>
        /// Executes a PartitionRead RPC asynchronously.
        /// </summary>
        /// <param name="request">The partitioning request. Must not be null. The request will be modified with session details
        /// from this object.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<PartitionResponse> PartitionReadAsync(PartitionReadRequest request, CallSettings callSettings) =>
            _managedTransaction.PartitionReadAsync(request, callSettings);

        /// <summary>
        /// Executes a PartitionQuery RPC asynchronously.
        /// </summary>
        /// <param name="request">The partitioning request. Must not be null. The request will be modified with session details
        /// from this object.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<PartitionResponse> PartitionQueryAsync(PartitionQueryRequest request, CallSettings callSettings) =>
            _managedTransaction.PartitionQueryAsync(request, callSettings);

        /// <summary>
        /// Creates a <see cref="ReliableStreamReader"/> for the given request.
        /// </summary>
        /// <param name="request">
        /// The read request. Must not be null.
        /// Will be modified to include session information from this pooled session.
        /// May be modified to include transaction and directed read options information
        /// from this pooled session and its underlying <see cref="SpannerClient"/>.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A <see cref="ReliableStreamReader"/> for the streaming SQL request.</returns>
        public ReliableStreamReader ReadStreamReader(ReadRequest request, CallSettings callSettings) =>
            _managedTransaction.ReadStreamReader(request, callSettings);

        /// <summary>
        /// Creates a <see cref="ReliableStreamReader"/> for the given request.
        /// </summary>
        /// <param name="request">
        /// The query request. Must not be null.
        /// Will be modified to include session information from this pooled session.
        /// May be modified to include transaction and directed read options information
        /// from this pooled session and its underlying <see cref="SpannerClient"/>.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A <see cref="ReliableStreamReader"/> for the streaming SQL request.</returns>
        public ReliableStreamReader ExecuteSqlStreamReader(ExecuteSqlRequest request, CallSettings callSettings) =>
            _managedTransaction.ExecuteSqlStreamReader(request, callSettings);

        /// <summary>
        /// Executes an ExecuteSql RPC asynchronously.
        /// </summary>
        /// <param name="request">The query request. Must not be null.
        /// Will be modified to include session information from this pooled session.
        /// May be modified to include transaction and directed read options information
        /// from this pooled session and its underlying <see cref="SpannerClient"/>.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<ResultSet> ExecuteSqlAsync(ExecuteSqlRequest request, CallSettings callSettings) =>
            _managedTransaction.ExecuteSqlAsync(request, callSettings);

        /// <summary>
        /// Executes an ExecuteBatchDml RPC asynchronously.
        /// </summary>
        /// <param name="request">The query request. Must not be null. The request will be modified with session and transaction details
        /// from this object. If this object's <see cref="TransactionId"/> is null, the request's transaction is not modified.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the asynchronous operation. When the task completes, the result is the response from the RPC.</returns>
        public Task<ExecuteBatchDmlResponse> ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, CallSettings callSettings) =>
            _managedTransaction.ExecuteBatchDmlAsync(request, callSettings);
    }
}
