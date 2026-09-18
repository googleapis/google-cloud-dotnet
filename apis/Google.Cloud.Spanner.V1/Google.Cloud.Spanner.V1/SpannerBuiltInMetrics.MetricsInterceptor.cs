// Copyright 2026 Google LLC
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

using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;

internal static partial class SpannerBuiltInMetrics
{
    /// <summary>
    /// Intercepts gRPC calls to record attempt-level metrics.
    /// </summary>
    /// <remarks>
    /// ClientStreaming and Duplex streaming are explicitly not instrumented, no methods currently use these protocols.
    /// </remarks>
    internal class MetricsInterceptor(ClientIdentity clientIdentity, IStopwatchProvider stopwatchProvider = null) : Interceptor
    {
        private readonly ClientIdentity _clientIdentity = clientIdentity;
        private readonly IStopwatchProvider _stopwatchProvider = stopwatchProvider ?? DefaultStopwatchProvider.Instance;

        /// <inheritdoc/>
        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            if (request is not IDatabaseNameProvider dbNameProvider)
            {
                return continuation(request, context);
            }

            AsyncUnaryCall<TResponse> call;
            IStopwatch stopwatch = _stopwatchProvider.StartNew();
            try
            {
                call = continuation(request, context);
                return new AsyncUnaryCall<TResponse>(
                    InstrumentCallAsync(),
                    call.ResponseHeadersAsync,
                    call.GetStatus,
                    call.GetTrailers,
                    call.Dispose);
            }
            catch (Exception ex)
            {
                stopwatch.Stop();
                double elapsedMs = stopwatch.ElapsedMilliseconds;
                // No headers are available if continuation fails, but we can record status (if RpcException) and latency.
                // An RpcException here is unexpected but defensively handled in case a previous interceptor throws it.
                StatusCode status = ex is RpcException rpcEx ? rpcEx.StatusCode : StatusCode.Unknown;
                RecordAttemptMetrics(elapsedMs, context.Method.Name, dbNameProvider, status, _clientIdentity);
                throw;
            }

            async Task<TResponse> InstrumentCallAsync()
            {
                double elapsedMs = 0;
                try
                {
                    return await call.ResponseAsync.ConfigureAwait(false);
                }
                finally
                {
                    stopwatch.Stop();
                    elapsedMs = stopwatch.ElapsedMilliseconds;
                    var labels = Labeler.GetLabels(context.Method.Name, dbNameProvider, call.GetStatus().StatusCode, _clientIdentity);
                    var recordTimingTask = RecordServerTimingMetricsAsync(call.ResponseHeadersAsync, labels).ConfigureAwait(false);
                    RecordAttemptMetrics(elapsedMs, labels);
                    await recordTimingTask;
                }
            }
        }

        // NOTE: We do not need to intercept blocking unary calls. All such calls resolve through the async
        // pipeline because each call now has a response metadata handler.

        // TODO: Add instrumentation for server streaming calls
    }
}
