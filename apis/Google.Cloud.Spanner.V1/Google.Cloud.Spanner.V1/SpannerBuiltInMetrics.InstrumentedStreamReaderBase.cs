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
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;

internal static partial class SpannerBuiltInMetrics
{
    /// <summary>
    /// Base class for decorators of <see cref="IAsyncStreamReader{T}"/> that measure the elapsed duration
    /// and completion status of a stream. Metrics are emitted at most once, when the stream completes,
    /// fails, or when <see cref="EmitMetricsAsync"/> is called explicitly.
    /// </summary>
    internal abstract class InstrumentedStreamReaderBase<TResponse> : IAsyncStreamReader<TResponse>
    {
        private readonly IAsyncStreamReader<TResponse> _inner;
        private readonly IStopwatch _stopwatch;
        private readonly string _methodName;
        private readonly IDatabaseNameProvider _dbNameProvider;
        private readonly ClientIdentity _clientIdentity;
        private int _metricsEmitted;

        private protected InstrumentedStreamReaderBase(
            IAsyncStreamReader<TResponse> inner,
            IStopwatch stopwatch,
            string methodName,
            IDatabaseNameProvider dbNameProvider,
            ClientIdentity clientIdentity)
        {
            _inner = GaxPreconditions.CheckNotNull(inner, nameof(inner));
            _stopwatch = GaxPreconditions.CheckNotNull(stopwatch, nameof(stopwatch));
            _methodName = GaxPreconditions.CheckNotNull(methodName, nameof(methodName));
            _dbNameProvider = GaxPreconditions.CheckNotNull(dbNameProvider, nameof(dbNameProvider));
            _clientIdentity = clientIdentity;
        }

        /// <summary>
        /// The decorated stream.
        /// </summary>
        private protected IAsyncStreamReader<TResponse> Inner => _inner;

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
            var labels = Labeler.GetLabels(_methodName, _dbNameProvider, status, _clientIdentity);
            await RecordAsync(_stopwatch.ElapsedMilliseconds, labels).ConfigureAwait(false);
        }

        /// <summary>
        /// Records the metrics for this stream when it completes, fails, or is disposed.
        /// </summary>
        /// <param name="latencyMs">The elapsed duration of the stream in milliseconds.</param>
        /// <param name="labels">The metric labels to apply to the measurements.</param>
        private protected abstract Task RecordAsync(double latencyMs, KeyValuePair<string, object>[] labels);
    }
}
