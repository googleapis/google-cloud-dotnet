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
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.V1;

internal static partial class SpannerBuiltInMetrics
{
    /// <summary>
    /// Decorates the retrying stream of <see cref="PartialResultSet"/> that backs a <see cref="ReliableStreamReader"/>
    /// to record operation metrics.
    /// </summary>
    /// <remarks>
    /// The inner stream retries transient errors itself, so each gRPC stream it opens is a separate attempt,
    /// recorded by <see cref="InstrumentedAttemptStreamReader{TResponse}"/>. This decorator records the operation as a whole.
    /// The operation completes when the inner stream is fully consumed, fails with an error that won't be retried,
    /// or is disposed before completion, which <see cref="ReliableStreamReader.Close"/> does.
    /// </remarks>
    internal sealed class InstrumentedOperationStreamReader : InstrumentedStreamReaderBase<PartialResultSet>, IDisposable
    {
        internal InstrumentedOperationStreamReader(
            IAsyncStreamReader<PartialResultSet> inner,
            IStopwatch stopwatch,
            string methodName,
            IDatabaseNameProvider dbNameProvider,
            ClientIdentity clientIdentity)
            : base(inner, stopwatch, methodName, dbNameProvider, clientIdentity)
        {
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            // The stream was disposed before it was fully consumed. If metrics were already emitted, this is a no-op.
            // Recording operation metrics is synchronous, so the returned task is already complete.
            _ = EmitMetricsAsync(StatusCode.Unknown);
            if (Inner is IDisposable disposable)
            {
                disposable.Dispose();
            }
        }

        /// <inheritdoc/>
        private protected override Task RecordAsync(double latencyMs, KeyValuePair<string, object>[] labels)
        {
            RecordOperationMetrics(latencyMs, labels);
            return Task.CompletedTask;
        }
    }
}
