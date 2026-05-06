// Copyright 2026 Google LLC
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
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedReasoningEngineRuntimeRevisionServiceClientSnippets
    {
        /// <summary>Snippet for GetReasoningEngineRuntimeRevision</summary>
        public void GetReasoningEngineRuntimeRevisionRequestObject()
        {
            // Snippet: GetReasoningEngineRuntimeRevision(GetReasoningEngineRuntimeRevisionRequest, CallSettings)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = ReasoningEngineRuntimeRevisionServiceClient.Create();
            // Initialize request argument(s)
            GetReasoningEngineRuntimeRevisionRequest request = new GetReasoningEngineRuntimeRevisionRequest
            {
                ReasoningEngineRuntimeRevisionName = ReasoningEngineRuntimeRevisionName.FromProjectLocationReasoningEngineRuntimeRevision("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[RUNTIME_REVISION]"),
            };
            // Make the request
            ReasoningEngineRuntimeRevision response = reasoningEngineRuntimeRevisionServiceClient.GetReasoningEngineRuntimeRevision(request);
            // End snippet
        }

        /// <summary>Snippet for GetReasoningEngineRuntimeRevisionAsync</summary>
        public async Task GetReasoningEngineRuntimeRevisionRequestObjectAsync()
        {
            // Snippet: GetReasoningEngineRuntimeRevisionAsync(GetReasoningEngineRuntimeRevisionRequest, CallSettings)
            // Additional: GetReasoningEngineRuntimeRevisionAsync(GetReasoningEngineRuntimeRevisionRequest, CancellationToken)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = await ReasoningEngineRuntimeRevisionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetReasoningEngineRuntimeRevisionRequest request = new GetReasoningEngineRuntimeRevisionRequest
            {
                ReasoningEngineRuntimeRevisionName = ReasoningEngineRuntimeRevisionName.FromProjectLocationReasoningEngineRuntimeRevision("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[RUNTIME_REVISION]"),
            };
            // Make the request
            ReasoningEngineRuntimeRevision response = await reasoningEngineRuntimeRevisionServiceClient.GetReasoningEngineRuntimeRevisionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReasoningEngineRuntimeRevision</summary>
        public void GetReasoningEngineRuntimeRevision()
        {
            // Snippet: GetReasoningEngineRuntimeRevision(string, CallSettings)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = ReasoningEngineRuntimeRevisionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]/runtimeRevisions/[RUNTIME_REVISION]";
            // Make the request
            ReasoningEngineRuntimeRevision response = reasoningEngineRuntimeRevisionServiceClient.GetReasoningEngineRuntimeRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetReasoningEngineRuntimeRevisionAsync</summary>
        public async Task GetReasoningEngineRuntimeRevisionAsync()
        {
            // Snippet: GetReasoningEngineRuntimeRevisionAsync(string, CallSettings)
            // Additional: GetReasoningEngineRuntimeRevisionAsync(string, CancellationToken)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = await ReasoningEngineRuntimeRevisionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]/runtimeRevisions/[RUNTIME_REVISION]";
            // Make the request
            ReasoningEngineRuntimeRevision response = await reasoningEngineRuntimeRevisionServiceClient.GetReasoningEngineRuntimeRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReasoningEngineRuntimeRevision</summary>
        public void GetReasoningEngineRuntimeRevisionResourceNames()
        {
            // Snippet: GetReasoningEngineRuntimeRevision(ReasoningEngineRuntimeRevisionName, CallSettings)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = ReasoningEngineRuntimeRevisionServiceClient.Create();
            // Initialize request argument(s)
            ReasoningEngineRuntimeRevisionName name = ReasoningEngineRuntimeRevisionName.FromProjectLocationReasoningEngineRuntimeRevision("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[RUNTIME_REVISION]");
            // Make the request
            ReasoningEngineRuntimeRevision response = reasoningEngineRuntimeRevisionServiceClient.GetReasoningEngineRuntimeRevision(name);
            // End snippet
        }

        /// <summary>Snippet for GetReasoningEngineRuntimeRevisionAsync</summary>
        public async Task GetReasoningEngineRuntimeRevisionResourceNamesAsync()
        {
            // Snippet: GetReasoningEngineRuntimeRevisionAsync(ReasoningEngineRuntimeRevisionName, CallSettings)
            // Additional: GetReasoningEngineRuntimeRevisionAsync(ReasoningEngineRuntimeRevisionName, CancellationToken)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = await ReasoningEngineRuntimeRevisionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReasoningEngineRuntimeRevisionName name = ReasoningEngineRuntimeRevisionName.FromProjectLocationReasoningEngineRuntimeRevision("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[RUNTIME_REVISION]");
            // Make the request
            ReasoningEngineRuntimeRevision response = await reasoningEngineRuntimeRevisionServiceClient.GetReasoningEngineRuntimeRevisionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReasoningEngineRuntimeRevisions</summary>
        public void ListReasoningEngineRuntimeRevisionsRequestObject()
        {
            // Snippet: ListReasoningEngineRuntimeRevisions(ListReasoningEngineRuntimeRevisionsRequest, CallSettings)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = ReasoningEngineRuntimeRevisionServiceClient.Create();
            // Initialize request argument(s)
            ListReasoningEngineRuntimeRevisionsRequest request = new ListReasoningEngineRuntimeRevisionsRequest
            {
                ParentAsReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> response = reasoningEngineRuntimeRevisionServiceClient.ListReasoningEngineRuntimeRevisions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReasoningEngineRuntimeRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReasoningEngineRuntimeRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReasoningEngineRuntimeRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReasoningEngineRuntimeRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReasoningEngineRuntimeRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReasoningEngineRuntimeRevisionsAsync</summary>
        public async Task ListReasoningEngineRuntimeRevisionsRequestObjectAsync()
        {
            // Snippet: ListReasoningEngineRuntimeRevisionsAsync(ListReasoningEngineRuntimeRevisionsRequest, CallSettings)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = await ReasoningEngineRuntimeRevisionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListReasoningEngineRuntimeRevisionsRequest request = new ListReasoningEngineRuntimeRevisionsRequest
            {
                ParentAsReasoningEngineName = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> response = reasoningEngineRuntimeRevisionServiceClient.ListReasoningEngineRuntimeRevisionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ReasoningEngineRuntimeRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListReasoningEngineRuntimeRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReasoningEngineRuntimeRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReasoningEngineRuntimeRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReasoningEngineRuntimeRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReasoningEngineRuntimeRevisions</summary>
        public void ListReasoningEngineRuntimeRevisions()
        {
            // Snippet: ListReasoningEngineRuntimeRevisions(string, string, int?, CallSettings)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = ReasoningEngineRuntimeRevisionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]";
            // Make the request
            PagedEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> response = reasoningEngineRuntimeRevisionServiceClient.ListReasoningEngineRuntimeRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReasoningEngineRuntimeRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReasoningEngineRuntimeRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReasoningEngineRuntimeRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReasoningEngineRuntimeRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReasoningEngineRuntimeRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReasoningEngineRuntimeRevisionsAsync</summary>
        public async Task ListReasoningEngineRuntimeRevisionsAsync()
        {
            // Snippet: ListReasoningEngineRuntimeRevisionsAsync(string, string, int?, CallSettings)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = await ReasoningEngineRuntimeRevisionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]";
            // Make the request
            PagedAsyncEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> response = reasoningEngineRuntimeRevisionServiceClient.ListReasoningEngineRuntimeRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ReasoningEngineRuntimeRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListReasoningEngineRuntimeRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReasoningEngineRuntimeRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReasoningEngineRuntimeRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReasoningEngineRuntimeRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReasoningEngineRuntimeRevisions</summary>
        public void ListReasoningEngineRuntimeRevisionsResourceNames()
        {
            // Snippet: ListReasoningEngineRuntimeRevisions(ReasoningEngineName, string, int?, CallSettings)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = ReasoningEngineRuntimeRevisionServiceClient.Create();
            // Initialize request argument(s)
            ReasoningEngineName parent = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            // Make the request
            PagedEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> response = reasoningEngineRuntimeRevisionServiceClient.ListReasoningEngineRuntimeRevisions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReasoningEngineRuntimeRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReasoningEngineRuntimeRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReasoningEngineRuntimeRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReasoningEngineRuntimeRevision> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReasoningEngineRuntimeRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReasoningEngineRuntimeRevisionsAsync</summary>
        public async Task ListReasoningEngineRuntimeRevisionsResourceNamesAsync()
        {
            // Snippet: ListReasoningEngineRuntimeRevisionsAsync(ReasoningEngineName, string, int?, CallSettings)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = await ReasoningEngineRuntimeRevisionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReasoningEngineName parent = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            // Make the request
            PagedAsyncEnumerable<ListReasoningEngineRuntimeRevisionsResponse, ReasoningEngineRuntimeRevision> response = reasoningEngineRuntimeRevisionServiceClient.ListReasoningEngineRuntimeRevisionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ReasoningEngineRuntimeRevision item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListReasoningEngineRuntimeRevisionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReasoningEngineRuntimeRevision item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReasoningEngineRuntimeRevision> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReasoningEngineRuntimeRevision item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteReasoningEngineRuntimeRevision</summary>
        public void DeleteReasoningEngineRuntimeRevisionRequestObject()
        {
            // Snippet: DeleteReasoningEngineRuntimeRevision(DeleteReasoningEngineRuntimeRevisionRequest, CallSettings)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = ReasoningEngineRuntimeRevisionServiceClient.Create();
            // Initialize request argument(s)
            DeleteReasoningEngineRuntimeRevisionRequest request = new DeleteReasoningEngineRuntimeRevisionRequest
            {
                ReasoningEngineRuntimeRevisionName = ReasoningEngineRuntimeRevisionName.FromProjectLocationReasoningEngineRuntimeRevision("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[RUNTIME_REVISION]"),
            };
            // Make the request
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> response = reasoningEngineRuntimeRevisionServiceClient.DeleteReasoningEngineRuntimeRevision(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> retrievedResponse = reasoningEngineRuntimeRevisionServiceClient.PollOnceDeleteReasoningEngineRuntimeRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReasoningEngineRuntimeRevisionAsync</summary>
        public async Task DeleteReasoningEngineRuntimeRevisionRequestObjectAsync()
        {
            // Snippet: DeleteReasoningEngineRuntimeRevisionAsync(DeleteReasoningEngineRuntimeRevisionRequest, CallSettings)
            // Additional: DeleteReasoningEngineRuntimeRevisionAsync(DeleteReasoningEngineRuntimeRevisionRequest, CancellationToken)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = await ReasoningEngineRuntimeRevisionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReasoningEngineRuntimeRevisionRequest request = new DeleteReasoningEngineRuntimeRevisionRequest
            {
                ReasoningEngineRuntimeRevisionName = ReasoningEngineRuntimeRevisionName.FromProjectLocationReasoningEngineRuntimeRevision("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[RUNTIME_REVISION]"),
            };
            // Make the request
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> response = await reasoningEngineRuntimeRevisionServiceClient.DeleteReasoningEngineRuntimeRevisionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> retrievedResponse = await reasoningEngineRuntimeRevisionServiceClient.PollOnceDeleteReasoningEngineRuntimeRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReasoningEngineRuntimeRevision</summary>
        public void DeleteReasoningEngineRuntimeRevision()
        {
            // Snippet: DeleteReasoningEngineRuntimeRevision(string, CallSettings)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = ReasoningEngineRuntimeRevisionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]/runtimeRevisions/[RUNTIME_REVISION]";
            // Make the request
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> response = reasoningEngineRuntimeRevisionServiceClient.DeleteReasoningEngineRuntimeRevision(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> retrievedResponse = reasoningEngineRuntimeRevisionServiceClient.PollOnceDeleteReasoningEngineRuntimeRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReasoningEngineRuntimeRevisionAsync</summary>
        public async Task DeleteReasoningEngineRuntimeRevisionAsync()
        {
            // Snippet: DeleteReasoningEngineRuntimeRevisionAsync(string, CallSettings)
            // Additional: DeleteReasoningEngineRuntimeRevisionAsync(string, CancellationToken)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = await ReasoningEngineRuntimeRevisionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/reasoningEngines/[REASONING_ENGINE]/runtimeRevisions/[RUNTIME_REVISION]";
            // Make the request
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> response = await reasoningEngineRuntimeRevisionServiceClient.DeleteReasoningEngineRuntimeRevisionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> retrievedResponse = await reasoningEngineRuntimeRevisionServiceClient.PollOnceDeleteReasoningEngineRuntimeRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReasoningEngineRuntimeRevision</summary>
        public void DeleteReasoningEngineRuntimeRevisionResourceNames()
        {
            // Snippet: DeleteReasoningEngineRuntimeRevision(ReasoningEngineRuntimeRevisionName, CallSettings)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = ReasoningEngineRuntimeRevisionServiceClient.Create();
            // Initialize request argument(s)
            ReasoningEngineRuntimeRevisionName name = ReasoningEngineRuntimeRevisionName.FromProjectLocationReasoningEngineRuntimeRevision("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[RUNTIME_REVISION]");
            // Make the request
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> response = reasoningEngineRuntimeRevisionServiceClient.DeleteReasoningEngineRuntimeRevision(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> retrievedResponse = reasoningEngineRuntimeRevisionServiceClient.PollOnceDeleteReasoningEngineRuntimeRevision(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteReasoningEngineRuntimeRevisionAsync</summary>
        public async Task DeleteReasoningEngineRuntimeRevisionResourceNamesAsync()
        {
            // Snippet: DeleteReasoningEngineRuntimeRevisionAsync(ReasoningEngineRuntimeRevisionName, CallSettings)
            // Additional: DeleteReasoningEngineRuntimeRevisionAsync(ReasoningEngineRuntimeRevisionName, CancellationToken)
            // Create client
            ReasoningEngineRuntimeRevisionServiceClient reasoningEngineRuntimeRevisionServiceClient = await ReasoningEngineRuntimeRevisionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReasoningEngineRuntimeRevisionName name = ReasoningEngineRuntimeRevisionName.FromProjectLocationReasoningEngineRuntimeRevision("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]", "[RUNTIME_REVISION]");
            // Make the request
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> response = await reasoningEngineRuntimeRevisionServiceClient.DeleteReasoningEngineRuntimeRevisionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteReasoningEngineRuntimeRevisionOperationMetadata> retrievedResponse = await reasoningEngineRuntimeRevisionServiceClient.PollOnceDeleteReasoningEngineRuntimeRevisionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
