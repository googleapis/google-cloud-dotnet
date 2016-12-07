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
using System.Threading.Tasks;

namespace Google.Cloud.Diagnostics.AspNet
{
    /// <summary>
    /// A <see cref="ITraceConsumer"/> that will send received traces to the Stackdriver Trace API.
    /// </summary>
    internal sealed class GrpcTraceConsumer : ITraceConsumer
    {
        private readonly Task<TraceServiceClient> _clientTask;

        /// <param name="client">The trace client that will push traces to the Stackdriver Trace API.</param>
        internal GrpcTraceConsumer(Task<TraceServiceClient> client)
        {
            _clientTask = GaxPreconditions.CheckNotNull(client, nameof(client));
        }

        /// <inheritdoc />
        public void Receive(Traces traces)
        {
            GaxPreconditions.CheckNotNull(traces, nameof(traces));

            // If their are no traces do not try to send them.
            if (traces.Traces_.Count == 0)
            {
                return;
            }

            // If the client task has faulted this will throw when accessing 'Result'
            _clientTask.Result.PatchTracesAsync(traces.Traces_[0].ProjectId, traces);
        }
    }
}