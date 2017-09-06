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
using Google.Cloud.ClientTesting;
using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Trace.V1.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(TraceServiceFixture))]
    public class TraceServiceClientSnippets
    {
        private readonly TraceServiceFixture _fixture;

        public TraceServiceClientSnippets(TraceServiceFixture fixture)
        {
            _fixture = fixture;
        }

        [Fact]
        public void ListTraces()
        {
            string projectId = _fixture.ProjectId;
            // Sample: ListTraces
            // Additional: ListTraces(*,*,*,*)
            TraceServiceClient client = TraceServiceClient.Create();
            PagedEnumerable<ListTracesResponse, Trace> traces = client.ListTraces(projectId);
            foreach (Trace trace in traces.Take(10))
            {
                Console.WriteLine($"{trace.TraceId}:");
                foreach (TraceSpan span in trace.Spans)
                {
                    Console.WriteLine($"  {span.StartTime}-{span.EndTime}: {span.Kind}");
                }
            }
            // End sample
        }
    }
}
