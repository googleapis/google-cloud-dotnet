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
    /// <remarks>
    /// Used to record attempt metrics on low-level gRPC server streams, as well as overarching operation
    /// metrics across resilient streams.
    /// </remarks>
    internal sealed class InstrumentedAsyncStreamReader<TResponse> : IAsyncStreamReader<TResponse>, IDisposable
    {
        private readonly IAsyncStreamReader<TResponse> _inner;
        private readonly IStopwatchProvider _stopwatchProvider;
        private readonly Action<double, string> _onCompletion;
        private IStopwatch _stopwatch;
        private bool _completed;

        /// <summary>
        /// Initializes a new reader instance using an already running stopwatch.
        /// </summary>
        /// <remarks>
        /// Used for low-level RPC attempts where the network call was already dispatched before the stream reader is iterated.
        /// </remarks>
        /// <param name="inner">The underlying stream reader to consume.</param>
        /// <param name="stopwatch">The active stopwatch measuring elapsed attempt duration.</param>
        /// <param name="onCompletion">The callback invoked exactly once upon stream completion with elapsed milliseconds and status.</param>
        public InstrumentedAsyncStreamReader(
            IAsyncStreamReader<TResponse> inner,
            IStopwatch stopwatch,
            Action<double, string> onCompletion)
        {
            _inner = GaxPreconditions.CheckNotNull(inner, nameof(inner));
            _stopwatch = GaxPreconditions.CheckNotNull(stopwatch, nameof(stopwatch));
            _onCompletion = GaxPreconditions.CheckNotNull(onCompletion, nameof(onCompletion));
        }

        /// <summary>
        /// Initializes a new reader instance using a stopwatch provider to start measuring on the first read.
        /// </summary>
        /// <remarks>
        /// Used for overarching operations so that idle time between stream creation and the first <see cref="MoveNext"/>
        /// invocation is not charged to operation latency.
        /// </remarks>
        /// <param name="inner">The underlying stream reader to consume.</param>
        /// <param name="stopwatchProvider">The provider used to lazily start timing on first <see cref="MoveNext"/>.</param>
        /// <param name="onCompletion">The callback invoked exactly once upon stream completion with elapsed milliseconds and status.</param>
        public InstrumentedAsyncStreamReader(
            IAsyncStreamReader<TResponse> inner,
            IStopwatchProvider stopwatchProvider,
            Action<double, string> onCompletion)
        {
            _inner = GaxPreconditions.CheckNotNull(inner, nameof(inner));
            _stopwatchProvider = GaxPreconditions.CheckNotNull(stopwatchProvider, nameof(stopwatchProvider));
            _onCompletion = GaxPreconditions.CheckNotNull(onCompletion, nameof(onCompletion));
        }

        /// <inheritdoc/>
        public TResponse Current => _inner.Current;

        /// <inheritdoc/>
        public async Task<bool> MoveNext(CancellationToken cancellationToken)
        {
            if (_completed)
            {
                return false;
            }

            // Lazily start timing on first read for operations, or continue existing timer for attempts.
            _stopwatch ??= _stopwatchProvider?.StartNew();

            try
            {
                bool hasNext = await _inner.MoveNext(cancellationToken).ConfigureAwait(false);
                if (!hasNext)
                {
                    // Server closed the stream cleanly; all responses have been received.
                    RecordCompletion(s_statusOk);
                }
                return hasNext;
            }
            catch (RpcException ex)
            {
                RecordCompletion(ex.StatusCode.ToString());
                throw;
            }
            catch (Exception)
            {
                // Unhandled non-RPC failure during iteration.
                RecordCompletion(s_statusUnknown);
                throw;
            }
        }

        /// <inheritdoc/>
        public void Dispose() => OnDispose();

        /// <summary>
        /// Completes metric tracking upon stream disposal if not already completed.
        /// </summary>
        /// <param name="getStatus">An optional accessor for retrieving the final gRPC status from the call.</param>
        public void OnDispose(Func<Status> getStatus = null)
        {
            if (!_completed)
            {
                string status = null;
                if (getStatus != null)
                {
                    try
                    {
                        status = getStatus().StatusCode.ToString();
                    }
                    catch
                    {
                        // Fall back to Cancelled if status cannot be retrieved (e.g. call disposed mid-flight).
                    }
                }
                RecordCompletion(status ?? StatusCode.Cancelled.ToString());
            }
            (_inner as IDisposable)?.Dispose();
        }

        /// <summary>
        /// Invokes the completion callback exactly once and marks the reader completed.
        /// </summary>
        private void RecordCompletion(string status)
        {
            if (_completed)
            {
                return;
            }
            _completed = true;
            _onCompletion(_stopwatch?.ElapsedMilliseconds ?? 0, status);
        }
    }
}

