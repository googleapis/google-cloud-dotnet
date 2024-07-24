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
    using Google.Cloud.PolicySimulator.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSimulatorClientSnippets
    {
        /// <summary>Snippet for GetReplay</summary>
        public void GetReplayRequestObject()
        {
            // Snippet: GetReplay(GetReplayRequest, CallSettings)
            // Create client
            SimulatorClient simulatorClient = SimulatorClient.Create();
            // Initialize request argument(s)
            GetReplayRequest request = new GetReplayRequest
            {
                ReplayName = ReplayName.FromProjectLocationReplay("[PROJECT]", "[LOCATION]", "[REPLAY]"),
            };
            // Make the request
            Replay response = simulatorClient.GetReplay(request);
            // End snippet
        }

        /// <summary>Snippet for GetReplayAsync</summary>
        public async Task GetReplayRequestObjectAsync()
        {
            // Snippet: GetReplayAsync(GetReplayRequest, CallSettings)
            // Additional: GetReplayAsync(GetReplayRequest, CancellationToken)
            // Create client
            SimulatorClient simulatorClient = await SimulatorClient.CreateAsync();
            // Initialize request argument(s)
            GetReplayRequest request = new GetReplayRequest
            {
                ReplayName = ReplayName.FromProjectLocationReplay("[PROJECT]", "[LOCATION]", "[REPLAY]"),
            };
            // Make the request
            Replay response = await simulatorClient.GetReplayAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReplay</summary>
        public void GetReplay()
        {
            // Snippet: GetReplay(string, CallSettings)
            // Create client
            SimulatorClient simulatorClient = SimulatorClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/replays/[REPLAY]";
            // Make the request
            Replay response = simulatorClient.GetReplay(name);
            // End snippet
        }

        /// <summary>Snippet for GetReplayAsync</summary>
        public async Task GetReplayAsync()
        {
            // Snippet: GetReplayAsync(string, CallSettings)
            // Additional: GetReplayAsync(string, CancellationToken)
            // Create client
            SimulatorClient simulatorClient = await SimulatorClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/replays/[REPLAY]";
            // Make the request
            Replay response = await simulatorClient.GetReplayAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReplay</summary>
        public void GetReplayResourceNames()
        {
            // Snippet: GetReplay(ReplayName, CallSettings)
            // Create client
            SimulatorClient simulatorClient = SimulatorClient.Create();
            // Initialize request argument(s)
            ReplayName name = ReplayName.FromProjectLocationReplay("[PROJECT]", "[LOCATION]", "[REPLAY]");
            // Make the request
            Replay response = simulatorClient.GetReplay(name);
            // End snippet
        }

        /// <summary>Snippet for GetReplayAsync</summary>
        public async Task GetReplayResourceNamesAsync()
        {
            // Snippet: GetReplayAsync(ReplayName, CallSettings)
            // Additional: GetReplayAsync(ReplayName, CancellationToken)
            // Create client
            SimulatorClient simulatorClient = await SimulatorClient.CreateAsync();
            // Initialize request argument(s)
            ReplayName name = ReplayName.FromProjectLocationReplay("[PROJECT]", "[LOCATION]", "[REPLAY]");
            // Make the request
            Replay response = await simulatorClient.GetReplayAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateReplay</summary>
        public void CreateReplayRequestObject()
        {
            // Snippet: CreateReplay(CreateReplayRequest, CallSettings)
            // Create client
            SimulatorClient simulatorClient = SimulatorClient.Create();
            // Initialize request argument(s)
            CreateReplayRequest request = new CreateReplayRequest
            {
                Parent = "",
                Replay = new Replay(),
            };
            // Make the request
            Operation<Replay, ReplayOperationMetadata> response = simulatorClient.CreateReplay(request);

            // Poll until the returned long-running operation is complete
            Operation<Replay, ReplayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Replay result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replay, ReplayOperationMetadata> retrievedResponse = simulatorClient.PollOnceCreateReplay(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replay retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReplayAsync</summary>
        public async Task CreateReplayRequestObjectAsync()
        {
            // Snippet: CreateReplayAsync(CreateReplayRequest, CallSettings)
            // Additional: CreateReplayAsync(CreateReplayRequest, CancellationToken)
            // Create client
            SimulatorClient simulatorClient = await SimulatorClient.CreateAsync();
            // Initialize request argument(s)
            CreateReplayRequest request = new CreateReplayRequest
            {
                Parent = "",
                Replay = new Replay(),
            };
            // Make the request
            Operation<Replay, ReplayOperationMetadata> response = await simulatorClient.CreateReplayAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Replay, ReplayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Replay result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replay, ReplayOperationMetadata> retrievedResponse = await simulatorClient.PollOnceCreateReplayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replay retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReplay</summary>
        public void CreateReplay()
        {
            // Snippet: CreateReplay(string, Replay, CallSettings)
            // Create client
            SimulatorClient simulatorClient = SimulatorClient.Create();
            // Initialize request argument(s)
            string parent = "";
            Replay replay = new Replay();
            // Make the request
            Operation<Replay, ReplayOperationMetadata> response = simulatorClient.CreateReplay(parent, replay);

            // Poll until the returned long-running operation is complete
            Operation<Replay, ReplayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Replay result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replay, ReplayOperationMetadata> retrievedResponse = simulatorClient.PollOnceCreateReplay(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replay retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateReplayAsync</summary>
        public async Task CreateReplayAsync()
        {
            // Snippet: CreateReplayAsync(string, Replay, CallSettings)
            // Additional: CreateReplayAsync(string, Replay, CancellationToken)
            // Create client
            SimulatorClient simulatorClient = await SimulatorClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            Replay replay = new Replay();
            // Make the request
            Operation<Replay, ReplayOperationMetadata> response = await simulatorClient.CreateReplayAsync(parent, replay);

            // Poll until the returned long-running operation is complete
            Operation<Replay, ReplayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Replay result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Replay, ReplayOperationMetadata> retrievedResponse = await simulatorClient.PollOnceCreateReplayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Replay retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListReplayResults</summary>
        public void ListReplayResultsRequestObject()
        {
            // Snippet: ListReplayResults(ListReplayResultsRequest, CallSettings)
            // Create client
            SimulatorClient simulatorClient = SimulatorClient.Create();
            // Initialize request argument(s)
            ListReplayResultsRequest request = new ListReplayResultsRequest
            {
                ParentAsReplayName = ReplayName.FromProjectLocationReplay("[PROJECT]", "[LOCATION]", "[REPLAY]"),
            };
            // Make the request
            PagedEnumerable<ListReplayResultsResponse, ReplayResult> response = simulatorClient.ListReplayResults(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReplayResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReplayResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReplayResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReplayResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReplayResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplayResultsAsync</summary>
        public async Task ListReplayResultsRequestObjectAsync()
        {
            // Snippet: ListReplayResultsAsync(ListReplayResultsRequest, CallSettings)
            // Create client
            SimulatorClient simulatorClient = await SimulatorClient.CreateAsync();
            // Initialize request argument(s)
            ListReplayResultsRequest request = new ListReplayResultsRequest
            {
                ParentAsReplayName = ReplayName.FromProjectLocationReplay("[PROJECT]", "[LOCATION]", "[REPLAY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListReplayResultsResponse, ReplayResult> response = simulatorClient.ListReplayResultsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReplayResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReplayResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReplayResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReplayResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReplayResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplayResults</summary>
        public void ListReplayResults()
        {
            // Snippet: ListReplayResults(string, string, int?, CallSettings)
            // Create client
            SimulatorClient simulatorClient = SimulatorClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/replays/[REPLAY]";
            // Make the request
            PagedEnumerable<ListReplayResultsResponse, ReplayResult> response = simulatorClient.ListReplayResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReplayResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReplayResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReplayResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReplayResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReplayResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplayResultsAsync</summary>
        public async Task ListReplayResultsAsync()
        {
            // Snippet: ListReplayResultsAsync(string, string, int?, CallSettings)
            // Create client
            SimulatorClient simulatorClient = await SimulatorClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/replays/[REPLAY]";
            // Make the request
            PagedAsyncEnumerable<ListReplayResultsResponse, ReplayResult> response = simulatorClient.ListReplayResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReplayResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReplayResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReplayResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReplayResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReplayResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplayResults</summary>
        public void ListReplayResultsResourceNames()
        {
            // Snippet: ListReplayResults(ReplayName, string, int?, CallSettings)
            // Create client
            SimulatorClient simulatorClient = SimulatorClient.Create();
            // Initialize request argument(s)
            ReplayName parent = ReplayName.FromProjectLocationReplay("[PROJECT]", "[LOCATION]", "[REPLAY]");
            // Make the request
            PagedEnumerable<ListReplayResultsResponse, ReplayResult> response = simulatorClient.ListReplayResults(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReplayResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReplayResultsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReplayResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReplayResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReplayResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReplayResultsAsync</summary>
        public async Task ListReplayResultsResourceNamesAsync()
        {
            // Snippet: ListReplayResultsAsync(ReplayName, string, int?, CallSettings)
            // Create client
            SimulatorClient simulatorClient = await SimulatorClient.CreateAsync();
            // Initialize request argument(s)
            ReplayName parent = ReplayName.FromProjectLocationReplay("[PROJECT]", "[LOCATION]", "[REPLAY]");
            // Make the request
            PagedAsyncEnumerable<ListReplayResultsResponse, ReplayResult> response = simulatorClient.ListReplayResultsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReplayResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReplayResultsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReplayResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReplayResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReplayResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
