// Copyright 2024 Google LLC
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

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Cloud.Trace.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTraceServiceClientSnippets
    {
        /// <summary>Snippet for ListTraces</summary>
        public void ListTracesRequestObject()
        {
            // Snippet: ListTraces(ListTracesRequest, CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            ListTracesRequest request = new ListTracesRequest
            {
                ProjectId = "",
                View = ListTracesRequest.Types.ViewType.Unspecified,
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListTracesResponse, Trace> response = traceServiceClient.ListTraces(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTracesAsync</summary>
        public async Task ListTracesRequestObjectAsync()
        {
            // Snippet: ListTracesAsync(ListTracesRequest, CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTracesRequest request = new ListTracesRequest
            {
                ProjectId = "",
                View = ListTracesRequest.Types.ViewType.Unspecified,
                StartTime = new Timestamp(),
                EndTime = new Timestamp(),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListTracesResponse, Trace> response = traceServiceClient.ListTracesAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTraces</summary>
        public void ListTraces()
        {
            // Snippet: ListTraces(string, string, int?, CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            PagedEnumerable<ListTracesResponse, Trace> response = traceServiceClient.ListTraces(projectId);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTracesAsync</summary>
        public async Task ListTracesAsync()
        {
            // Snippet: ListTracesAsync(string, string, int?, CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            // Make the request
            PagedAsyncEnumerable<ListTracesResponse, Trace> response = traceServiceClient.ListTracesAsync(projectId);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTrace</summary>
        public void GetTraceRequestObject()
        {
            // Snippet: GetTrace(GetTraceRequest, CallSettings)
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

        /// <summary>Snippet for GetTraceAsync</summary>
        public async Task GetTraceRequestObjectAsync()
        {
            // Snippet: GetTraceAsync(GetTraceRequest, CallSettings)
            // Additional: GetTraceAsync(GetTraceRequest, CancellationToken)
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

        /// <summary>Snippet for GetTrace</summary>
        public void GetTrace()
        {
            // Snippet: GetTrace(string, string, CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string traceId = "";
            // Make the request
            Trace response = traceServiceClient.GetTrace(projectId, traceId);
            // End snippet
        }

        /// <summary>Snippet for GetTraceAsync</summary>
        public async Task GetTraceAsync()
        {
            // Snippet: GetTraceAsync(string, string, CallSettings)
            // Additional: GetTraceAsync(string, string, CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            string traceId = "";
            // Make the request
            Trace response = await traceServiceClient.GetTraceAsync(projectId, traceId);
            // End snippet
        }

        /// <summary>Snippet for PatchTraces</summary>
        public void PatchTracesRequestObject()
        {
            // Snippet: PatchTraces(PatchTracesRequest, CallSettings)
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

        /// <summary>Snippet for PatchTracesAsync</summary>
        public async Task PatchTracesRequestObjectAsync()
        {
            // Snippet: PatchTracesAsync(PatchTracesRequest, CallSettings)
            // Additional: PatchTracesAsync(PatchTracesRequest, CancellationToken)
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

        /// <summary>Snippet for PatchTraces</summary>
        public void PatchTraces()
        {
            // Snippet: PatchTraces(string, Traces, CallSettings)
            // Create client
            TraceServiceClient traceServiceClient = TraceServiceClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            Traces traces = new Traces();
            // Make the request
            traceServiceClient.PatchTraces(projectId, traces);
            // End snippet
        }

        /// <summary>Snippet for PatchTracesAsync</summary>
        public async Task PatchTracesAsync()
        {
            // Snippet: PatchTracesAsync(string, Traces, CallSettings)
            // Additional: PatchTracesAsync(string, Traces, CancellationToken)
            // Create client
            TraceServiceClient traceServiceClient = await TraceServiceClient.CreateAsync();
            // Initialize request argument(s)
            string projectId = "";
            Traces traces = new Traces();
            // Make the request
            await traceServiceClient.PatchTracesAsync(projectId, traces);
            // End snippet
        }
    }
}
