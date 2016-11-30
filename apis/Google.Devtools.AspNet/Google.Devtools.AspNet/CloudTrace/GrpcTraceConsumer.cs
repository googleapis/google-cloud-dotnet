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
using Google.Devtools.Cloudtrace.V1;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Devtools.AspNet
{
    /// <summary>
    /// A <see cref="ITraceConsumer"/> that will send received traces to the Stackdriver Trace API.
    /// </summary>
    internal sealed class GrpcTraceConsumer : ITraceConsumer
    {
        // The max number of tasks that will be allowed when waiting for the client task.
        internal const int MaxWaitingTasks = 100;

        private readonly Task<TraceServiceClient> _clientTask;

        // The number tasks that have been created while waiting for the client task.
        private int taskCounter = 0;

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

            // Ensure the client is complete or we haven't started too many tasks already.
            if (!_clientTask.IsCompleted && Interlocked.Increment(ref taskCounter) > MaxWaitingTasks)
            {
                return;
            }

            _clientTask.ContinueWith(clientTask =>
            {
                return clientTask.Result.PatchTracesAsync(traces.Traces_[0].ProjectId, traces);
            });
        }
    }
}