// Copyright 2026 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSs tE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;

internal static partial class SpannerBuiltInMetrics
{
    /// <summary>
    /// A delegating wrapper around <see cref="SpannerClient"/> that intercepts
    /// execution of all methods to record metrics.
    /// </summary>
    internal class BuiltInMetricsWrapper : SpannerClient
    {
        private const string UnknownStatus = "UNKNOWN";
        private const string OkStatus = "OK";

        private readonly SpannerClient _inner;
        private readonly ClientIdentity _clientIdentity;

        /// <summary>
        /// Gets the underlying native gRPC client synchronously tracking downstream metrics.
        /// </summary>
        public override Spanner.SpannerClient GrpcClient => _inner.GrpcClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuiltInMetricsWrapper"/> class.
        /// </summary>
        /// <param name="inner">The underlying client to delegate calls to.</param>
        public BuiltInMetricsWrapper(SpannerClient inner)
        {
            _inner = GaxPreconditions.CheckNotNull(inner, nameof(inner));
            _clientIdentity = Labeler.GenerateIdentity();
        }

        public override Session CreateSession(CreateSessionRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(CreateSession), request, () => _inner.CreateSession(request, callSettings));
        public override Task<Session> CreateSessionAsync(CreateSessionRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentationAsync(nameof(CreateSessionAsync), request, () => _inner.CreateSessionAsync(request, callSettings));
        public override BatchCreateSessionsResponse BatchCreateSessions(BatchCreateSessionsRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(BatchCreateSessions), request, () => _inner.BatchCreateSessions(request, callSettings));
        public override Task<BatchCreateSessionsResponse> BatchCreateSessionsAsync(BatchCreateSessionsRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentationAsync(nameof(BatchCreateSessionsAsync), request, () => _inner.BatchCreateSessionsAsync(request, callSettings));
        public override Session GetSession(GetSessionRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(GetSession), request, () => _inner.GetSession(request, callSettings));
        public override Task<Session> GetSessionAsync(GetSessionRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentationAsync(nameof(GetSessionAsync), request, () => _inner.GetSessionAsync(request, callSettings));
        public override PagedEnumerable<ListSessionsResponse, Session> ListSessions(ListSessionsRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(ListSessions), request, () => _inner.ListSessions(request, callSettings));
        public override PagedAsyncEnumerable<ListSessionsResponse, Session> ListSessionsAsync(ListSessionsRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(ListSessionsAsync), request, () => _inner.ListSessionsAsync(request, callSettings));
        public override void DeleteSession(DeleteSessionRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(DeleteSession), request, () => _inner.DeleteSession(request, callSettings));
        public override Task DeleteSessionAsync(DeleteSessionRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentationAsync(nameof(DeleteSessionAsync), request, () => _inner.DeleteSessionAsync(request, callSettings));
        public override ResultSet ExecuteSql(ExecuteSqlRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(ExecuteSql), request, () => _inner.ExecuteSql(request, callSettings));
        public override Task<ResultSet> ExecuteSqlAsync(ExecuteSqlRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentationAsync(nameof(ExecuteSqlAsync), request, () => _inner.ExecuteSqlAsync(request, callSettings));
        public override ExecuteBatchDmlResponse ExecuteBatchDml(ExecuteBatchDmlRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(ExecuteBatchDml), request, () => _inner.ExecuteBatchDml(request, callSettings));
        public override Task<ExecuteBatchDmlResponse> ExecuteBatchDmlAsync(ExecuteBatchDmlRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentationAsync(nameof(ExecuteBatchDmlAsync), request, () => _inner.ExecuteBatchDmlAsync(request, callSettings));
        public override ResultSet Read(ReadRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(Read), request, () => _inner.Read(request, callSettings));
        public override Task<ResultSet> ReadAsync(ReadRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentationAsync(nameof(ReadAsync), request, () => _inner.ReadAsync(request, callSettings));
        public override Transaction BeginTransaction(BeginTransactionRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(BeginTransaction), request, () => _inner.BeginTransaction(request, callSettings));
        public override Task<Transaction> BeginTransactionAsync(BeginTransactionRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentationAsync(nameof(BeginTransactionAsync), request, () => _inner.BeginTransactionAsync(request, callSettings));
        public override CommitResponse Commit(CommitRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(Commit), request, () => _inner.Commit(request, callSettings));
        public override Task<CommitResponse> CommitAsync(CommitRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentationAsync(nameof(CommitAsync), request, () => _inner.CommitAsync(request, callSettings));
        public override void Rollback(RollbackRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(Rollback), request, () => _inner.Rollback(request, callSettings));
        public override Task RollbackAsync(RollbackRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentationAsync(nameof(RollbackAsync), request, () => _inner.RollbackAsync(request, callSettings));
        public override PartitionResponse PartitionQuery(PartitionQueryRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(PartitionQuery), request, () => _inner.PartitionQuery(request, callSettings));
        public override Task<PartitionResponse> PartitionQueryAsync(PartitionQueryRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentationAsync(nameof(PartitionQueryAsync), request, () => _inner.PartitionQueryAsync(request, callSettings));
        public override PartitionResponse PartitionRead(PartitionReadRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentation(nameof(PartitionRead), request, () => _inner.PartitionRead(request, callSettings));
        public override Task<PartitionResponse> PartitionReadAsync(PartitionReadRequest request, CallSettings callSettings = null)
            => ExecuteWithInstrumentationAsync(nameof(PartitionReadAsync), request, () => _inner.PartitionReadAsync(request, callSettings));

        // The streaming themselves instrument and record metrics.
        public override ExecuteStreamingSqlStream ExecuteStreamingSql(ExecuteSqlRequest request, CallSettings callSettings = null)
            => _inner.ExecuteStreamingSql(request, callSettings);
        public override StreamingReadStream StreamingRead(ReadRequest request, CallSettings callSettings = null)
            => _inner.StreamingRead(request, callSettings);
        public override BatchWriteStream BatchWrite(BatchWriteRequest request, CallSettings callSettings = null)
            => _inner.BatchWrite(request, callSettings);
        public override FetchCacheUpdateStream FetchCacheUpdate(FetchCacheUpdateRequest request, CallSettings callSettings = null)
            => _inner.FetchCacheUpdate(request, callSettings);

        /// <summary>
        /// Executes an async action and records metrics.
        /// </summary>
        private async Task ExecuteWithInstrumentationAsync(string method, object request, Func<Task> action)
        {
            var stopwatch = Stopwatch.StartNew();
            string status = OkStatus;
            try
            {
                await action().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                status = GetStatus(ex);
                throw;
            }
            finally
            {
                RecordMetrics(method, request, status, stopwatch.Elapsed.TotalMilliseconds);
            }
        }

        /// <summary>
        /// Executes an async action and records metrics.
        /// </summary>
        private async Task<TResponse> ExecuteWithInstrumentationAsync<TResponse>(string method, object request, Func<Task<TResponse>> action)
        {
            var stopwatch = Stopwatch.StartNew();
            string status = OkStatus;
            try
            {
                return await action().ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                status = GetStatus(ex);
                throw;
            }
            finally
            {
                RecordMetrics(method, request, status, stopwatch.Elapsed.TotalMilliseconds);
            }
        }

        /// <summary>
        /// Executes a synchronous action and records metrics.
        /// </summary>
        private TResponse ExecuteWithInstrumentation<TResponse>(string method, object request, Func<TResponse> action)
        {
            var stopwatch = Stopwatch.StartNew();
            string status = OkStatus;
            try
            {
                return action();
            }
            catch (Exception ex)
            {
                status = GetStatus(ex);
                throw;
            }
            finally
            {
                RecordMetrics(method, request, status, stopwatch.Elapsed.TotalMilliseconds);
            }
        }

        /// <summary>
        /// Executes a synchronous action and records metrics.
        /// </summary>
        private void ExecuteWithInstrumentation(string method, object request, Action action)
        {
            var stopwatch = Stopwatch.StartNew();
            string status = OkStatus;
            try
            {
                action();
            }
            catch (Exception ex)
            {
                status = GetStatus(ex);
                throw;
            }
            finally
            {
                RecordMetrics(method, request, status, stopwatch.Elapsed.TotalMilliseconds);
            }
        }

        /// <summary>
        /// Determines the appropriate status code for a given exception.
        /// </summary>
        /// <param name="ex">The internally thrown exception.</param>
        /// <returns>A string representation of the parsed status code.</returns>
        private string GetStatus(Exception ex)
        {
            if (ex is Grpc.Core.RpcException rpcEx)
            {
                return rpcEx.StatusCode.ToString();
            }
            return UnknownStatus;
        }

        /// <summary>
        /// Records metrics to built-in instruments.
        /// </summary>
        private void RecordMetrics(string method, object request, string status, double latencyMs)
        {
            var provider = request as IDatabaseNameProvider;
            SpannerBuiltInMetrics.RecordOperationMetrics(method, provider, status, latencyMs, _clientIdentity);
        }
    }
}
