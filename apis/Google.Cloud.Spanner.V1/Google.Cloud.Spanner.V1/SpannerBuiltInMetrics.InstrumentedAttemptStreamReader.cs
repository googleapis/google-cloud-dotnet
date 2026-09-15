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

using Google.Api.Gax;
using Grpc.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;

internal static partial class SpannerBuiltInMetrics
{
    /// <summary>
    /// Decorates an <see cref="IAsyncStreamReader{T}"/> to record attempt metrics, including server-timing metrics,
    /// for a single gRPC stream.
    /// </summary>
    /// <remarks>
    /// This type does not implement <see cref="System.IDisposable"/> because callers dispose the gRPC call rather than its
    /// response stream, so <see cref="MetricsInterceptor"/> emits metrics from the call's dispose action instead.
    /// </remarks>
    internal sealed class InstrumentedAttemptStreamReader<TResponse> : InstrumentedStreamReaderBase<TResponse>
    {
        private readonly Task<Metadata> _responseHeadersAsync;

        internal InstrumentedAttemptStreamReader(
            IAsyncStreamReader<TResponse> inner,
            IStopwatch stopwatch,
            string methodName,
            IDatabaseNameProvider dbNameProvider,
            ClientIdentity clientIdentity,
            Task<Metadata> responseHeadersAsync)
            : base(inner, stopwatch, methodName, dbNameProvider, clientIdentity)
        {
            _responseHeadersAsync = GaxPreconditions.CheckNotNull(responseHeadersAsync, nameof(responseHeadersAsync));
        }

        /// <inheritdoc/>
        private protected override async Task RecordAsync(double latencyMs, KeyValuePair<string, object>[] labels)
        {
            RecordAttemptMetrics(latencyMs, labels);
            await RecordServerTimingMetricsAsync(_responseHeadersAsync, labels).ConfigureAwait(false);
        }
    }
}
