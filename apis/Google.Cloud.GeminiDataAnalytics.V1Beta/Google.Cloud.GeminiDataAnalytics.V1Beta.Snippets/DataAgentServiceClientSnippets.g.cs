// Copyright 2025 Google LLC
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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.GeminiDataAnalytics.V1Beta;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataAgentServiceClientSnippets
    {
        /// <summary>Snippet for ListDataAgents</summary>
        public void ListDataAgentsRequestObject()
        {
            // Snippet: ListDataAgents(ListDataAgentsRequest, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            ListDataAgentsRequest request = new ListDataAgentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListDataAgentsResponse, DataAgent> response = dataAgentServiceClient.ListDataAgents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataAgent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAgent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAgentsAsync</summary>
        public async Task ListDataAgentsRequestObjectAsync()
        {
            // Snippet: ListDataAgentsAsync(ListDataAgentsRequest, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataAgentsRequest request = new ListDataAgentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListDataAgentsResponse, DataAgent> response = dataAgentServiceClient.ListDataAgentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataAgent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataAgentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAgent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAgents</summary>
        public void ListDataAgents()
        {
            // Snippet: ListDataAgents(string, string, int?, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListDataAgentsResponse, DataAgent> response = dataAgentServiceClient.ListDataAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataAgent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAgent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAgentsAsync</summary>
        public async Task ListDataAgentsAsync()
        {
            // Snippet: ListDataAgentsAsync(string, string, int?, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListDataAgentsResponse, DataAgent> response = dataAgentServiceClient.ListDataAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataAgent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataAgentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAgent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAgents</summary>
        public void ListDataAgentsResourceNames()
        {
            // Snippet: ListDataAgents(LocationName, string, int?, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListDataAgentsResponse, DataAgent> response = dataAgentServiceClient.ListDataAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataAgent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAgent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataAgentsAsync</summary>
        public async Task ListDataAgentsResourceNamesAsync()
        {
            // Snippet: ListDataAgentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListDataAgentsResponse, DataAgent> response = dataAgentServiceClient.ListDataAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataAgent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDataAgentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAgent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessibleDataAgents</summary>
        public void ListAccessibleDataAgentsRequestObject()
        {
            // Snippet: ListAccessibleDataAgents(ListAccessibleDataAgentsRequest, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            ListAccessibleDataAgentsRequest request = new ListAccessibleDataAgentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ShowDeleted = false,
                CreatorFilter = ListAccessibleDataAgentsRequest.Types.CreatorFilter.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListAccessibleDataAgentsResponse, DataAgent> response = dataAgentServiceClient.ListAccessibleDataAgents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataAgent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessibleDataAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAgent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessibleDataAgentsAsync</summary>
        public async Task ListAccessibleDataAgentsRequestObjectAsync()
        {
            // Snippet: ListAccessibleDataAgentsAsync(ListAccessibleDataAgentsRequest, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAccessibleDataAgentsRequest request = new ListAccessibleDataAgentsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
                ShowDeleted = false,
                CreatorFilter = ListAccessibleDataAgentsRequest.Types.CreatorFilter.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListAccessibleDataAgentsResponse, DataAgent> response = dataAgentServiceClient.ListAccessibleDataAgentsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataAgent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessibleDataAgentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAgent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessibleDataAgents</summary>
        public void ListAccessibleDataAgents()
        {
            // Snippet: ListAccessibleDataAgents(string, string, int?, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAccessibleDataAgentsResponse, DataAgent> response = dataAgentServiceClient.ListAccessibleDataAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataAgent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessibleDataAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAgent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessibleDataAgentsAsync</summary>
        public async Task ListAccessibleDataAgentsAsync()
        {
            // Snippet: ListAccessibleDataAgentsAsync(string, string, int?, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAccessibleDataAgentsResponse, DataAgent> response = dataAgentServiceClient.ListAccessibleDataAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataAgent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessibleDataAgentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAgent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessibleDataAgents</summary>
        public void ListAccessibleDataAgentsResourceNames()
        {
            // Snippet: ListAccessibleDataAgents(LocationName, string, int?, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAccessibleDataAgentsResponse, DataAgent> response = dataAgentServiceClient.ListAccessibleDataAgents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataAgent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAccessibleDataAgentsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAgent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAccessibleDataAgentsAsync</summary>
        public async Task ListAccessibleDataAgentsResourceNamesAsync()
        {
            // Snippet: ListAccessibleDataAgentsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAccessibleDataAgentsResponse, DataAgent> response = dataAgentServiceClient.ListAccessibleDataAgentsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((DataAgent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAccessibleDataAgentsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataAgent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataAgent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataAgent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDataAgent</summary>
        public void GetDataAgentRequestObject()
        {
            // Snippet: GetDataAgent(GetDataAgentRequest, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            GetDataAgentRequest request = new GetDataAgentRequest
            {
                DataAgentName = DataAgentName.FromProjectLocationDataAgent("[PROJECT]", "[LOCATION]", "[DATA_AGENT]"),
            };
            // Make the request
            DataAgent response = dataAgentServiceClient.GetDataAgent(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataAgentAsync</summary>
        public async Task GetDataAgentRequestObjectAsync()
        {
            // Snippet: GetDataAgentAsync(GetDataAgentRequest, CallSettings)
            // Additional: GetDataAgentAsync(GetDataAgentRequest, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataAgentRequest request = new GetDataAgentRequest
            {
                DataAgentName = DataAgentName.FromProjectLocationDataAgent("[PROJECT]", "[LOCATION]", "[DATA_AGENT]"),
            };
            // Make the request
            DataAgent response = await dataAgentServiceClient.GetDataAgentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataAgent</summary>
        public void GetDataAgent()
        {
            // Snippet: GetDataAgent(string, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataAgents/[DATA_AGENT]";
            // Make the request
            DataAgent response = dataAgentServiceClient.GetDataAgent(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAgentAsync</summary>
        public async Task GetDataAgentAsync()
        {
            // Snippet: GetDataAgentAsync(string, CallSettings)
            // Additional: GetDataAgentAsync(string, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataAgents/[DATA_AGENT]";
            // Make the request
            DataAgent response = await dataAgentServiceClient.GetDataAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAgent</summary>
        public void GetDataAgentResourceNames()
        {
            // Snippet: GetDataAgent(DataAgentName, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            DataAgentName name = DataAgentName.FromProjectLocationDataAgent("[PROJECT]", "[LOCATION]", "[DATA_AGENT]");
            // Make the request
            DataAgent response = dataAgentServiceClient.GetDataAgent(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataAgentAsync</summary>
        public async Task GetDataAgentResourceNamesAsync()
        {
            // Snippet: GetDataAgentAsync(DataAgentName, CallSettings)
            // Additional: GetDataAgentAsync(DataAgentName, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataAgentName name = DataAgentName.FromProjectLocationDataAgent("[PROJECT]", "[LOCATION]", "[DATA_AGENT]");
            // Make the request
            DataAgent response = await dataAgentServiceClient.GetDataAgentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateDataAgent</summary>
        public void CreateDataAgentRequestObject()
        {
            // Snippet: CreateDataAgent(CreateDataAgentRequest, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            CreateDataAgentRequest request = new CreateDataAgentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataAgentId = "",
                DataAgent = new DataAgent(),
                RequestId = "",
            };
            // Make the request
            Operation<DataAgent, OperationMetadata> response = dataAgentServiceClient.CreateDataAgent(request);

            // Poll until the returned long-running operation is complete
            Operation<DataAgent, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataAgent, OperationMetadata> retrievedResponse = dataAgentServiceClient.PollOnceCreateDataAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAgentAsync</summary>
        public async Task CreateDataAgentRequestObjectAsync()
        {
            // Snippet: CreateDataAgentAsync(CreateDataAgentRequest, CallSettings)
            // Additional: CreateDataAgentAsync(CreateDataAgentRequest, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataAgentRequest request = new CreateDataAgentRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DataAgentId = "",
                DataAgent = new DataAgent(),
                RequestId = "",
            };
            // Make the request
            Operation<DataAgent, OperationMetadata> response = await dataAgentServiceClient.CreateDataAgentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DataAgent, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataAgent, OperationMetadata> retrievedResponse = await dataAgentServiceClient.PollOnceCreateDataAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAgent</summary>
        public void CreateDataAgent()
        {
            // Snippet: CreateDataAgent(string, DataAgent, string, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DataAgent dataAgent = new DataAgent();
            string dataAgentId = "";
            // Make the request
            Operation<DataAgent, OperationMetadata> response = dataAgentServiceClient.CreateDataAgent(parent, dataAgent, dataAgentId);

            // Poll until the returned long-running operation is complete
            Operation<DataAgent, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataAgent, OperationMetadata> retrievedResponse = dataAgentServiceClient.PollOnceCreateDataAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAgentAsync</summary>
        public async Task CreateDataAgentAsync()
        {
            // Snippet: CreateDataAgentAsync(string, DataAgent, string, CallSettings)
            // Additional: CreateDataAgentAsync(string, DataAgent, string, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            DataAgent dataAgent = new DataAgent();
            string dataAgentId = "";
            // Make the request
            Operation<DataAgent, OperationMetadata> response = await dataAgentServiceClient.CreateDataAgentAsync(parent, dataAgent, dataAgentId);

            // Poll until the returned long-running operation is complete
            Operation<DataAgent, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataAgent, OperationMetadata> retrievedResponse = await dataAgentServiceClient.PollOnceCreateDataAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAgent</summary>
        public void CreateDataAgentResourceNames()
        {
            // Snippet: CreateDataAgent(LocationName, DataAgent, string, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DataAgent dataAgent = new DataAgent();
            string dataAgentId = "";
            // Make the request
            Operation<DataAgent, OperationMetadata> response = dataAgentServiceClient.CreateDataAgent(parent, dataAgent, dataAgentId);

            // Poll until the returned long-running operation is complete
            Operation<DataAgent, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataAgent, OperationMetadata> retrievedResponse = dataAgentServiceClient.PollOnceCreateDataAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDataAgentAsync</summary>
        public async Task CreateDataAgentResourceNamesAsync()
        {
            // Snippet: CreateDataAgentAsync(LocationName, DataAgent, string, CallSettings)
            // Additional: CreateDataAgentAsync(LocationName, DataAgent, string, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            DataAgent dataAgent = new DataAgent();
            string dataAgentId = "";
            // Make the request
            Operation<DataAgent, OperationMetadata> response = await dataAgentServiceClient.CreateDataAgentAsync(parent, dataAgent, dataAgentId);

            // Poll until the returned long-running operation is complete
            Operation<DataAgent, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataAgent, OperationMetadata> retrievedResponse = await dataAgentServiceClient.PollOnceCreateDataAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAgent</summary>
        public void UpdateDataAgentRequestObject()
        {
            // Snippet: UpdateDataAgent(UpdateDataAgentRequest, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataAgentRequest request = new UpdateDataAgentRequest
            {
                UpdateMask = new FieldMask(),
                DataAgent = new DataAgent(),
                RequestId = "",
            };
            // Make the request
            Operation<DataAgent, OperationMetadata> response = dataAgentServiceClient.UpdateDataAgent(request);

            // Poll until the returned long-running operation is complete
            Operation<DataAgent, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataAgent, OperationMetadata> retrievedResponse = dataAgentServiceClient.PollOnceUpdateDataAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAgentAsync</summary>
        public async Task UpdateDataAgentRequestObjectAsync()
        {
            // Snippet: UpdateDataAgentAsync(UpdateDataAgentRequest, CallSettings)
            // Additional: UpdateDataAgentAsync(UpdateDataAgentRequest, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataAgentRequest request = new UpdateDataAgentRequest
            {
                UpdateMask = new FieldMask(),
                DataAgent = new DataAgent(),
                RequestId = "",
            };
            // Make the request
            Operation<DataAgent, OperationMetadata> response = await dataAgentServiceClient.UpdateDataAgentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DataAgent, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataAgent, OperationMetadata> retrievedResponse = await dataAgentServiceClient.PollOnceUpdateDataAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAgent</summary>
        public void UpdateDataAgent()
        {
            // Snippet: UpdateDataAgent(DataAgent, FieldMask, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            DataAgent dataAgent = new DataAgent();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DataAgent, OperationMetadata> response = dataAgentServiceClient.UpdateDataAgent(dataAgent, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DataAgent, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DataAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataAgent, OperationMetadata> retrievedResponse = dataAgentServiceClient.PollOnceUpdateDataAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDataAgentAsync</summary>
        public async Task UpdateDataAgentAsync()
        {
            // Snippet: UpdateDataAgentAsync(DataAgent, FieldMask, CallSettings)
            // Additional: UpdateDataAgentAsync(DataAgent, FieldMask, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataAgent dataAgent = new DataAgent();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<DataAgent, OperationMetadata> response = await dataAgentServiceClient.UpdateDataAgentAsync(dataAgent, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<DataAgent, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DataAgent result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DataAgent, OperationMetadata> retrievedResponse = await dataAgentServiceClient.PollOnceUpdateDataAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DataAgent retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAgent</summary>
        public void DeleteDataAgentRequestObject()
        {
            // Snippet: DeleteDataAgent(DeleteDataAgentRequest, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataAgentRequest request = new DeleteDataAgentRequest
            {
                DataAgentName = DataAgentName.FromProjectLocationDataAgent("[PROJECT]", "[LOCATION]", "[DATA_AGENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = dataAgentServiceClient.DeleteDataAgent(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataAgentServiceClient.PollOnceDeleteDataAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAgentAsync</summary>
        public async Task DeleteDataAgentRequestObjectAsync()
        {
            // Snippet: DeleteDataAgentAsync(DeleteDataAgentRequest, CallSettings)
            // Additional: DeleteDataAgentAsync(DeleteDataAgentRequest, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataAgentRequest request = new DeleteDataAgentRequest
            {
                DataAgentName = DataAgentName.FromProjectLocationDataAgent("[PROJECT]", "[LOCATION]", "[DATA_AGENT]"),
                RequestId = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataAgentServiceClient.DeleteDataAgentAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataAgentServiceClient.PollOnceDeleteDataAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAgent</summary>
        public void DeleteDataAgent()
        {
            // Snippet: DeleteDataAgent(string, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataAgents/[DATA_AGENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = dataAgentServiceClient.DeleteDataAgent(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataAgentServiceClient.PollOnceDeleteDataAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAgentAsync</summary>
        public async Task DeleteDataAgentAsync()
        {
            // Snippet: DeleteDataAgentAsync(string, CallSettings)
            // Additional: DeleteDataAgentAsync(string, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataAgents/[DATA_AGENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataAgentServiceClient.DeleteDataAgentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataAgentServiceClient.PollOnceDeleteDataAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAgent</summary>
        public void DeleteDataAgentResourceNames()
        {
            // Snippet: DeleteDataAgent(DataAgentName, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            DataAgentName name = DataAgentName.FromProjectLocationDataAgent("[PROJECT]", "[LOCATION]", "[DATA_AGENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = dataAgentServiceClient.DeleteDataAgent(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = dataAgentServiceClient.PollOnceDeleteDataAgent(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteDataAgentAsync</summary>
        public async Task DeleteDataAgentResourceNamesAsync()
        {
            // Snippet: DeleteDataAgentAsync(DataAgentName, CallSettings)
            // Additional: DeleteDataAgentAsync(DataAgentName, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataAgentName name = DataAgentName.FromProjectLocationDataAgent("[PROJECT]", "[LOCATION]", "[DATA_AGENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await dataAgentServiceClient.DeleteDataAgentAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await dataAgentServiceClient.PollOnceDeleteDataAgentAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = dataAgentServiceClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await dataAgentServiceClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = dataAgentServiceClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await dataAgentServiceClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = dataAgentServiceClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await dataAgentServiceClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = dataAgentServiceClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await dataAgentServiceClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = dataAgentServiceClient.SetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, CallSettings)
            // Additional: SetIamPolicyAsync(string, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await dataAgentServiceClient.SetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, CallSettings)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = DataAgentServiceClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = dataAgentServiceClient.SetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            DataAgentServiceClient dataAgentServiceClient = await DataAgentServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await dataAgentServiceClient.SetIamPolicyAsync(resource);
            // End snippet
        }
    }
}
