﻿// Copyright 2017 Google Inc. All Rights Reserved.
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

using Google.Cloud.ClientTesting;
using Google.Cloud.Trace.V1;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
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
        private readonly string _projectId = TestEnvironment.GetTestProjectId();

        /// <summary>Client to use to send RPCs.</summary>
        private readonly TraceServiceClient _client = TraceServiceClient.Create();

        private TraceEntryPolling(TimeSpan? timeout, TimeSpan? sleepInterval)
            : base(timeout, sleepInterval)
        { }

        public static TraceEntryPolling Default { get; } = new TraceEntryPolling(null, null);

        public static TraceEntryPolling NoRetry { get; } = new TraceEntryPolling(TimeSpan.Zero, TimeSpan.Zero);

        /// <summary>
        /// A poller specially configured for when we want to check that no entries were stored.
        /// The configuration is just on timeout and sleepInterval.
        /// We sleep 1 minute, because 90% of the entries are guaranteed to be available after 10 seconds
        /// which means that we make sure that tests using this poller for checking no entries written
        /// will fail > 90% of the time if there are actual entries being written.
        /// </summary>
        public static TraceEntryPolling NoEntry { get; } = new TraceEntryPolling(TimeSpan.FromMinutes(1), null);

        public TraceProto GetTrace(string traceId) => 
            GetEntries(1, () => new[] { _client.GetTrace(_projectId, traceId) })
                .SingleOrDefault();

        /// <summary>
        /// Gets a trace that contains a span with the given name.
        /// </summary>
        /// <param name="expectTrace">True if the trace is expected to exist.  This is used
        ///     to minimize RPC calls.</param>
        public TraceProto GetTrace(string spanName, DateTimeOffset startTime, bool expectTrace = true) =>
            GetTraces(spanName, startTime, expectTrace ? 1 : 0).SingleOrDefault();

        /// <summary>
        /// Gets traces containing the giving <paramref name="spanName"/>.
        /// </summary>
        /// <param name="spanName"> The name for the traces to get.</param>
        /// <param name="startTime"> The start time of traces to get.</param>
        /// <param name="minEntries"> Optional. The minimum number of entries to expect.
        /// Default value is 1.</param>
        /// <param name="pageSize"> Optional. The page size to use when making RPC calls.
        /// Default value is 250.</param>
        /// <returns></returns>
        public IEnumerable<TraceProto> GetTraces(string spanName, DateTimeOffset startTime, int minEntries = 1, int pageSize = 250)
        {
            var traceList = GetEntries(minEntries, () =>
            {
                ListTracesRequest request = new ListTracesRequest
                {
                    ProjectId = _projectId,
                    // We substract 5 minutes because on ocasion we were polling too fast after startTime
                    // and the backend clock was a little behind, we were getting InvalidArgument.
                    StartTime = Timestamp.FromDateTimeOffset(startTime - TimeSpan.FromMinutes(5)),
                    View = ListTracesRequest.Types.ViewType.Complete,
                    Filter = $"span:\"{spanName}\"",
                    PageSize = pageSize
                };

                return _client.ListTraces(request);
            });
            return traceList;
        }
    }
}
