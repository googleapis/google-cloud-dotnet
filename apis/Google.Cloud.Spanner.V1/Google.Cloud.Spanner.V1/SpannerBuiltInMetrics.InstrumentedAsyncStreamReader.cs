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
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;

internal static partial class SpannerBuiltInMetrics
{
    /// <summary>
    /// Decorates an <see cref="IAsyncStreamReader{T}"/> to measure the elapsed duration and completion status of a stream.
    /// </summary>
    internal sealed class InstrumentedAsyncStreamReader<TResponse> : IAsyncStreamReader<TResponse>
    {
        private readonly IAsyncStreamReader<TResponse> _inner;
        private readonly IStopwatch _stopwatch;
        private readonly string _methodName;
        private readonly IDatabaseNameProvider _dbNameProvider;
        private readonly ClientIdentity _clientIdentity;
        private readonly Task<Metadata> _responseHeadersAsync;
        private int _metricsEmitted;

        internal InstrumentedAsyncStreamReader(
            IAsyncStreamReader<TResponse> inner,
            IStopwatch stopwatch,
            string methodName,
            IDatabaseNameProvider dbNameProvider,
            ClientIdentity clientIdentity,
            Task<Metadata> responseHeadersAsync)
        {
            _inner = GaxPreconditions.CheckNotNull(inner, nameof(inner));
            _stopwatch = GaxPreconditions.CheckNotNull(stopwatch, nameof(stopwatch));
            _methodName = GaxPreconditions.CheckNotNull(methodName, nameof(methodName));
            _dbNameProvider = GaxPreconditions.CheckNotNull(dbNameProvider, nameof(dbNameProvider));
            _clientIdentity = clientIdentity;
            _responseHeadersAsync = GaxPreconditions.CheckNotNull(responseHeadersAsync, nameof(responseHeadersAsync));
        }

        /// <inheritdoc/>
        public TResponse Current => _inner.Current;

        /// <inheritdoc/>
        public async Task<bool> MoveNext(CancellationToken cancellationToken)
        {
            try
            {
                bool hasNext = await _inner.MoveNext(cancellationToken).ConfigureAwait(false);
                if (!hasNext)
                {
                    // Server closed the stream and all responses have been received, we consider this OK.
                    await EmitMetricsAsync(StatusCode.OK).ConfigureAwait(false);
                }
                return hasNext;
            }
            catch (Exception ex)
            {
                await EmitMetricsAsync(GetStatus(ex)).ConfigureAwait(false);
                throw;
            }
        }

        /// <summary>
        /// Emits metrics, unless they were previously emitted.
        /// </summary>
        internal async Task EmitMetricsAsync(StatusCode status = StatusCode.Unknown)
        {
            if (Interlocked.CompareExchange(ref _metricsEmitted, 1, 0) != 0)
            {
                return;
            }

            _stopwatch.Stop();
            double elapsedMs = _stopwatch.ElapsedMilliseconds;
            var labels = Labeler.GetLabels(_methodName, _dbNameProvider, status, _clientIdentity);
            RecordAttemptMetrics(elapsedMs, labels);
            await RecordServerTimingMetricsAsync(_responseHeadersAsync, labels).ConfigureAwait(false);
        }
    }
}
