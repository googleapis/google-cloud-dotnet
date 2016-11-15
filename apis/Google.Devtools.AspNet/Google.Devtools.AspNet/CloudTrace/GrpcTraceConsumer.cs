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
using System.Threading.Tasks;

namespace Google.Devtools.AspNet
{
    /// <summary>
    /// A <see cref="ITraceConsumer"/> that will send recieved traces to the Stackdriver Trace API.
    /// </summary>
    public sealed class GrpcTraceConsumer : ITraceConsumer
    {
        private readonly Task<TraceServiceClient> _client;

        private GrpcTraceConsumer(Task<TraceServiceClient> client)
        {
            _client = GaxPreconditions.CheckNotNull(client, nameof(client));
        }

        /// <summary>
        /// Creates a new <see cref="GrpcTraceConsumer"/>.
        /// </summary>
        /// <param name="client">The trace client that will push traces to the Stackdriver Trace API.</param>
        public static GrpcTraceConsumer Create(Task<TraceServiceClient> client)
        {
            return new GrpcTraceConsumer(client);
        }

        /// <inheritdoc />
        public void Recieve(Traces traces)
        {
            GaxPreconditions.CheckNotNull(traces, nameof(traces));

            // If their are no traces do not try to send them.
            if (traces.Traces_.Count == 0)
            {
                return;
            }

            // If the client has not completed fail silently until it is.  This prevents us
            // from having to wait for a client which cannot be done in all cases.
            if (!_client.IsCompleted)
            {
                return;
            }
            _client.Result.PatchTracesAsync(traces.Traces_[0].ProjectId, traces);
        }
    }
}