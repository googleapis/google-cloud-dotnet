// Copyright 2026 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Grpc.Core;
using System.Diagnostics;
using System;

namespace Google.Cloud.Spanner.V1;

internal partial class SpannerBuiltInMetrics
{
    /// <summary>
    /// Tracer for recording built-in metrics (attempt/operation) for streaming RPCs.
    /// </summary>
    internal class StreamTracer
    {
        private readonly string _methodName;
        private readonly IDatabaseNameProvider _dbNameProvider;
        private readonly ClientIdentity _clientIdentity;

        private Stopwatch _operationStopwatch;
        private Stopwatch _attemptStopwatch;

        public StreamTracer(SpannerClient client, ReadOrQueryRequest request)
        {
            _methodName = request?.IsQuery == true ? "ExecuteStreamingSql" : "StreamingRead";
            _dbNameProvider = request;
            _clientIdentity = client?.ClientIdentity ?? default;
        }

        public void StartOperation() => _operationStopwatch = Stopwatch.StartNew();

        public void StartAttempt() => _attemptStopwatch = Stopwatch.StartNew();

        public void RecordOperationSuccess() => RecordOperation(s_statusOk);

        public void RecordOperationError(RpcException ex) => RecordOperation(ex?.StatusCode.ToString() ?? s_statusUnknown);
        public void RecordOperationError(Exception ex) => RecordOperation(s_statusUnknown);
        public void RecordOperationPrematureClose() => RecordOperation("CANCELLED");

        private void RecordOperation(string status)
        {
            if (_operationStopwatch != null)
            {
                SpannerBuiltInMetrics.RecordOperationMetrics(_methodName, _dbNameProvider, status, _operationStopwatch.Elapsed.TotalMilliseconds, _clientIdentity);
                _operationStopwatch = null;
            }
        }


        public void RecordAttempt<TResponse>(AsyncServerStreamingCall<TResponse> grpcCall, string status)
        {
            if (_attemptStopwatch != null)
            {
                var latencyMs = _attemptStopwatch.Elapsed.TotalMilliseconds;
                if (grpcCall != null)
                {
                    _ = SpannerBuiltInMetrics.RecordAttemptMetricsAsync(grpcCall.ResponseHeadersAsync, _methodName, _dbNameProvider, status, latencyMs, _clientIdentity);
                }
                else
                {
                    SpannerBuiltInMetrics.RecordAttemptMetrics(_methodName, _dbNameProvider, status, latencyMs, _clientIdentity);
                }
            }
        }

        public void RecordAttempt<TResponse>(AsyncServerStreamingCall<TResponse> grpcCall, Exception ex)
        {
            RecordAttempt(grpcCall, ex is RpcException rpcException ? rpcException.StatusCode.ToString() : s_statusUnknown);
        }
    }
}
