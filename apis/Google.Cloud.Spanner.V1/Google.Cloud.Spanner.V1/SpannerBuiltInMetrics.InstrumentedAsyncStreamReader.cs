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
        private readonly Action<double, StatusCode> _onClose;
        private readonly IStopwatch _stopwatch;
        private int _completed;

        internal InstrumentedAsyncStreamReader(
            IAsyncStreamReader<TResponse> inner,
            IStopwatch stopwatch,
            Action<double, StatusCode> onClose)
        {
            _inner = GaxPreconditions.CheckNotNull(inner, nameof(inner));
            _onClose = GaxPreconditions.CheckNotNull(onClose, nameof(onClose));
            _stopwatch = GaxPreconditions.CheckNotNull(stopwatch, nameof(stopwatch));
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
                    TryRecordClose(StatusCode.OK);
                }
                return hasNext;
            }
            catch (Exception ex)
            {
                TryRecordClose(ex is RpcException rpcEx ? rpcEx.StatusCode : StatusCode.Unknown);
                throw;
            }
        }

        /// <summary>
        /// Records the close of the stream when the consumer abandons it before completion.
        /// </summary>
        public void NotifyClosed()
        {
            // The consumer stopped reading before the stream ended so we do not have a status, we record unknown.
            // If the stream was already consumed or broke with an exception this is a no-op, see MoveNext.
            TryRecordClose(StatusCode.Unknown);
        }

        /// <summary>
        /// Invokes the close callback, unless the stream has already closed.
        /// </summary>
        private void TryRecordClose(StatusCode status)
        {
            if (Interlocked.CompareExchange(ref _completed, 1, 0) != 0)
            {
                return;
            }

            _stopwatch.Stop();
            try
            {
                _onClose(_stopwatch.ElapsedMilliseconds, status);
            }
            catch
            {
                // Silently swallow exceptions.
            }
        }
    }
}
