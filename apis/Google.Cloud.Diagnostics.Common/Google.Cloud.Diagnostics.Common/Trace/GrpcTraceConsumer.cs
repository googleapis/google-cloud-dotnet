// Copyright 2016 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Cloud.Trace.V1;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common
{
    /// <summary>
    /// A <see cref="IConsumer{TraceProto}"/> that will send received traces to the Stackdriver Trace API.
    /// </summary>
    internal sealed class GrpcTraceConsumer : IConsumer<TraceProto>
    {
        private readonly TraceServiceClient _client;

        /// <param name="client">The trace client that will push traces to the Stackdriver Trace API.</param>
        internal GrpcTraceConsumer(TraceServiceClient client)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
        }

        /// <inheritdoc />
        public void Receive(IEnumerable<TraceProto> traces)
        {
            GaxPreconditions.CheckNotNull(traces, nameof(traces));

            TraceProto trace = traces.FirstOrDefault();
            // If there are no traces do not try to send them.
            if (trace == null)
            {
                return;
            }

            Traces tracesObj = new Traces { Traces_ = { traces } };
            // If the client task has faulted this will throw when accessing 'Result'
            _client.PatchTraces(trace.ProjectId, tracesObj);
        }

        /// <inheritdoc />
        public Task ReceiveAsync(IEnumerable<TraceProto> traces, CancellationToken cancellationToken = default(CancellationToken))
        {
            GaxPreconditions.CheckNotNull(traces, nameof(traces));

            TraceProto trace = traces.FirstOrDefault();
            // If there are no traces do not try to send them.
            if (trace == null)
            {
                return CommonUtils.CompletedTask;
            }

            Traces tracesObj = new Traces { Traces_ = { traces } };
            // If the client task has faulted this will throw when accessing 'Result'
            return _client.PatchTracesAsync(trace.ProjectId, tracesObj, cancellationToken);
        }

        /// <inheritdoc />
        public void Dispose() { }
    }
}