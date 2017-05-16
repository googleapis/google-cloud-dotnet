// Copyright 2017, Google Inc. All rights reserved.
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
using Google.Cloud.Trace.V1;
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

namespace Google.Cloud.Trace.V1.Snippets
{
    public class GeneratedTraceServiceClientSnippets
    {
        public async Task PatchTracesAsync()
        {
            // Snippet: PatchTracesAsync(string,Traces,CallSettings)
            // Additional: PatchTracesAsync(string,Traces,CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
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

        public async Task PatchTracesAsync_RequestObject()
        {
            // Snippet: PatchTracesAsync(PatchTracesRequest,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            PatchTracesRequest request = new PatchTracesRequest
            {
                ProjectId = "",
                Traces = new Traces(),
            };
            // Make the request
            await traceServiceClient.PatchTracesAsync(request);
            // End snippet
        }

        public void PatchTraces_RequestObject()
        {
            // Snippet: PatchTraces(PatchTracesRequest,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            PatchTracesRequest request = new PatchTracesRequest
            {
                ProjectId = "",
                Traces = new Traces(),
            };
            // Make the request
            traceServiceClient.PatchTraces(request);
            // End snippet
        }

        public async Task GetTraceAsync()
        {
            // Snippet: GetTraceAsync(string,string,CallSettings)
            // Additional: GetTraceAsync(string,string,CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
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

        public async Task GetTraceAsync_RequestObject()
        {
            // Snippet: GetTraceAsync(GetTraceRequest,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTraceRequest request = new GetTraceRequest
            {
                ProjectId = "",
                TraceId = "",
            };
            // Make the request
            Trace response = await traceServiceClient.GetTraceAsync(request);
            // End snippet
        }

        public void GetTrace_RequestObject()
        {
            // Snippet: GetTrace(GetTraceRequest,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            GetTraceRequest request = new GetTraceRequest
            {
                ProjectId = "",
                TraceId = "",
            };
            // Make the request
            Trace response = traceServiceClient.GetTrace(request);
            // End snippet
        }

        public async Task ListTracesAsync()
        {
            // Snippet: ListTracesAsync(string,string,int?,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            PagedAsyncEnumerable<ListTracesResponse, Trace> response =
                traceServiceClient.ListTracesAsync(projectId);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Trace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTracesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trace item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trace item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
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
            PagedEnumerable<ListTracesResponse, Trace> response =
                traceServiceClient.ListTraces(projectId);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Trace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTracesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trace item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trace item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public async Task ListTracesAsync_RequestObject()
        {
            // Snippet: ListTracesAsync(ListTracesRequest,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTracesRequest request = new ListTracesRequest
            {
                ProjectId = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTracesResponse, Trace> response =
                traceServiceClient.ListTracesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Trace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTracesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trace item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trace item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        public void ListTraces_RequestObject()
        {
            // Snippet: ListTraces(ListTracesRequest,CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            ListTracesRequest request = new ListTracesRequest
            {
                ProjectId = "",
            };
            // Make the request
            PagedEnumerable<ListTracesResponse, Trace> response =
                traceServiceClient.ListTraces(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Trace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTracesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Trace item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Trace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Trace item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

    }
}
