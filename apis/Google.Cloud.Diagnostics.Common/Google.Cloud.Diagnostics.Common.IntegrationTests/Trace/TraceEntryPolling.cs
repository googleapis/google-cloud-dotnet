// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Cloud.Diagnostics.Common.Tests;
using Google.Cloud.Trace.V1;
using Google.Protobuf.WellKnownTypes;
using System.Linq;

using TraceProto = Google.Cloud.Trace.V1.Trace;

namespace Google.Cloud.Diagnostics.Common.IntegrationTests
{
    /// <summary>
    /// An implementation of <see cref="BaseEntryPolling{T}"/> for <see cref="TraceProto"/>s.
    /// </summary>
    internal class TraceEntryPolling : BaseEntryPolling<TraceProto>
    {
        /// <summary>Project id to run the test on.</summary>
        private readonly string _projectId = Utils.GetProjectIdFromEnvironment();

        /// <summary>Client to use to send RPCs.</summary>
        private readonly TraceServiceClient _client = TraceServiceClient.Create();

        /// <summary>
        /// Gets a trace that contains a span with the given name.
        /// </summary>
        /// <param name="expectTrace">True if the trace is expected to exist.  This is used
        ///     to minimize RPC calls.</param>
        public TraceProto GetTrace(string spanName, Timestamp startTime, bool expectTrace = true)
        {
            var minEntries = expectTrace ? 1 : 0;
            var traceList = GetEntries(minEntries, () =>
            {
                ListTracesRequest request = new ListTracesRequest
                {
                    ProjectId = _projectId,
                    StartTime = startTime,
                    View = ListTracesRequest.Types.ViewType.Complete
                };
                var traces = _client.ListTraces(request);
                return traces.Where(t => t.Spans.Any(s => s.Name == spanName));
            });
            return traceList.FirstOrDefault();
        }
    }
}
