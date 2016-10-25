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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Devtools.Cloudtrace.V1.Snippets
{
    public class GeneratedTraceServiceClientSnippets
    {
        public async Task PatchTracesAsync()
        {
            // Snippet: PatchTracesAsync(string,Traces,CallSettings)
            // Additional: PatchTracesAsync(string,Traces,CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            Traces traces = new Traces();
            // Make the request
            await traceServiceClient.PatchTracesAsync(projectId, traces);
            // End snippet
        }

        public void PatchTraces()
        {
            // Snippet: PatchTraces(string,Traces,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            Traces traces = new Traces();
            // Make the request
            traceServiceClient.PatchTraces(projectId, traces);
            // End snippet
        }

        public async Task GetTraceAsync()
        {
            // Snippet: GetTraceAsync(string,string,CallSettings)
            // Additional: GetTraceAsync(string,string,CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string traceId = "";
            // Make the request
            Trace response = await traceServiceClient.GetTraceAsync(projectId, traceId);
            // End snippet
        }

        public void GetTrace()
        {
            // Snippet: GetTrace(string,string,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string traceId = "";
            // Make the request
            Trace response = traceServiceClient.GetTrace(projectId, traceId);
            // End snippet
        }

        public async Task ListTracesAsync()
        {
            // Snippet: ListTracesAsync(string,string,int?,CallSettings)
            // Additional: ListTracesAsync(string,string,int?,CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            IPagedAsyncEnumerable<ListTracesResponse,Trace> response =
                traceServiceClient.ListTracesAsync(projectId);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Trace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            IAsyncEnumerable<FixedSizePage<Trace>> fixedSizePages = response.AsPages().WithFixedSize(pageSize);
            await fixedSizePages.ForEachAsync((FixedSizePage<Trace> page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trace item in page)
                {
                    Console.WriteLine(item);
                }
            });
            // End snippet
        }

        public void ListTraces()
        {
            // Snippet: ListTraces(string,string,int?,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            IPagedEnumerable<ListTracesResponse,Trace> response =
                traceServiceClient.ListTraces(projectId);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Trace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over fixed-sized pages, lazily performing RPCs as required
            int pageSize = 10;
            foreach (FixedSizePage<Trace> page in response.AsPages().WithFixedSize(pageSize))
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trace item in page)
                {
                    Console.WriteLine(item);
                }
            }
            // End snippet
        }

    }
}
