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
    using Google.Cloud.Dialogflow.V2;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConversationDatasetsClientSnippets
    {
        /// <summary>Snippet for CreateConversationDataset</summary>
        public void CreateConversationDatasetRequestObject()
        {
            // Snippet: CreateConversationDataset(CreateConversationDatasetRequest, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            CreateConversationDatasetRequest request = new CreateConversationDatasetRequest
            {
                Parent = "",
                ConversationDataset = new ConversationDataset(),
            };
            // Make the request
            Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> response = conversationDatasetsClient.CreateConversationDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversationDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> retrievedResponse = conversationDatasetsClient.PollOnceCreateConversationDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversationDatasetAsync</summary>
        public async Task CreateConversationDatasetRequestObjectAsync()
        {
            // Snippet: CreateConversationDatasetAsync(CreateConversationDatasetRequest, CallSettings)
            // Additional: CreateConversationDatasetAsync(CreateConversationDatasetRequest, CancellationToken)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = await ConversationDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            CreateConversationDatasetRequest request = new CreateConversationDatasetRequest
            {
                Parent = "",
                ConversationDataset = new ConversationDataset(),
            };
            // Make the request
            Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> response = await conversationDatasetsClient.CreateConversationDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversationDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> retrievedResponse = await conversationDatasetsClient.PollOnceCreateConversationDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversationDataset</summary>
        public void CreateConversationDataset()
        {
            // Snippet: CreateConversationDataset(string, ConversationDataset, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            string parent = "";
            ConversationDataset conversationDataset = new ConversationDataset();
            // Make the request
            Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> response = conversationDatasetsClient.CreateConversationDataset(parent, conversationDataset);

            // Poll until the returned long-running operation is complete
            Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ConversationDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> retrievedResponse = conversationDatasetsClient.PollOnceCreateConversationDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateConversationDatasetAsync</summary>
        public async Task CreateConversationDatasetAsync()
        {
            // Snippet: CreateConversationDatasetAsync(string, ConversationDataset, CallSettings)
            // Additional: CreateConversationDatasetAsync(string, ConversationDataset, CancellationToken)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = await ConversationDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            ConversationDataset conversationDataset = new ConversationDataset();
            // Make the request
            Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> response = await conversationDatasetsClient.CreateConversationDatasetAsync(parent, conversationDataset);

            // Poll until the returned long-running operation is complete
            Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ConversationDataset result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ConversationDataset, CreateConversationDatasetOperationMetadata> retrievedResponse = await conversationDatasetsClient.PollOnceCreateConversationDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ConversationDataset retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetConversationDataset</summary>
        public void GetConversationDatasetRequestObject()
        {
            // Snippet: GetConversationDataset(GetConversationDatasetRequest, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            GetConversationDatasetRequest request = new GetConversationDatasetRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
            };
            // Make the request
            ConversationDataset response = conversationDatasetsClient.GetConversationDataset(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversationDatasetAsync</summary>
        public async Task GetConversationDatasetRequestObjectAsync()
        {
            // Snippet: GetConversationDatasetAsync(GetConversationDatasetRequest, CallSettings)
            // Additional: GetConversationDatasetAsync(GetConversationDatasetRequest, CancellationToken)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = await ConversationDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            GetConversationDatasetRequest request = new GetConversationDatasetRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
            };
            // Make the request
            ConversationDataset response = await conversationDatasetsClient.GetConversationDatasetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversationDataset</summary>
        public void GetConversationDataset()
        {
            // Snippet: GetConversationDataset(string, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversationDatasets/[CONVERSATION_DATASET]";
            // Make the request
            ConversationDataset response = conversationDatasetsClient.GetConversationDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationDatasetAsync</summary>
        public async Task GetConversationDatasetAsync()
        {
            // Snippet: GetConversationDatasetAsync(string, CallSettings)
            // Additional: GetConversationDatasetAsync(string, CancellationToken)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = await ConversationDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversationDatasets/[CONVERSATION_DATASET]";
            // Make the request
            ConversationDataset response = await conversationDatasetsClient.GetConversationDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationDataset</summary>
        public void GetConversationDatasetResourceNames()
        {
            // Snippet: GetConversationDataset(ConversationDatasetName, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            ConversationDatasetName name = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]");
            // Make the request
            ConversationDataset response = conversationDatasetsClient.GetConversationDataset(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationDatasetAsync</summary>
        public async Task GetConversationDatasetResourceNamesAsync()
        {
            // Snippet: GetConversationDatasetAsync(ConversationDatasetName, CallSettings)
            // Additional: GetConversationDatasetAsync(ConversationDatasetName, CancellationToken)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = await ConversationDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationDatasetName name = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]");
            // Make the request
            ConversationDataset response = await conversationDatasetsClient.GetConversationDatasetAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConversationDatasets</summary>
        public void ListConversationDatasetsRequestObject()
        {
            // Snippet: ListConversationDatasets(ListConversationDatasetsRequest, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            ListConversationDatasetsRequest request = new ListConversationDatasetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListConversationDatasetsResponse, ConversationDataset> response = conversationDatasetsClient.ListConversationDatasets(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversationDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationDataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationDatasetsAsync</summary>
        public async Task ListConversationDatasetsRequestObjectAsync()
        {
            // Snippet: ListConversationDatasetsAsync(ListConversationDatasetsRequest, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = await ConversationDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            ListConversationDatasetsRequest request = new ListConversationDatasetsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListConversationDatasetsResponse, ConversationDataset> response = conversationDatasetsClient.ListConversationDatasetsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversationDataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationDataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationDatasets</summary>
        public void ListConversationDatasets()
        {
            // Snippet: ListConversationDatasets(string, string, int?, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListConversationDatasetsResponse, ConversationDataset> response = conversationDatasetsClient.ListConversationDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversationDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationDataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationDatasetsAsync</summary>
        public async Task ListConversationDatasetsAsync()
        {
            // Snippet: ListConversationDatasetsAsync(string, string, int?, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = await ConversationDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListConversationDatasetsResponse, ConversationDataset> response = conversationDatasetsClient.ListConversationDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversationDataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationDataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationDatasets</summary>
        public void ListConversationDatasetsResourceNames()
        {
            // Snippet: ListConversationDatasets(LocationName, string, int?, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConversationDatasetsResponse, ConversationDataset> response = conversationDatasetsClient.ListConversationDatasets(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversationDataset item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationDatasetsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationDataset> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationDatasetsAsync</summary>
        public async Task ListConversationDatasetsResourceNamesAsync()
        {
            // Snippet: ListConversationDatasetsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = await ConversationDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConversationDatasetsResponse, ConversationDataset> response = conversationDatasetsClient.ListConversationDatasetsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversationDataset item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationDatasetsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationDataset item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationDataset> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationDataset item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationDataset</summary>
        public void DeleteConversationDatasetRequestObject()
        {
            // Snippet: DeleteConversationDataset(DeleteConversationDatasetRequest, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            DeleteConversationDatasetRequest request = new DeleteConversationDatasetRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
            };
            // Make the request
            Operation<Empty, DeleteConversationDatasetOperationMetadata> response = conversationDatasetsClient.DeleteConversationDataset(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteConversationDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteConversationDatasetOperationMetadata> retrievedResponse = conversationDatasetsClient.PollOnceDeleteConversationDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationDatasetAsync</summary>
        public async Task DeleteConversationDatasetRequestObjectAsync()
        {
            // Snippet: DeleteConversationDatasetAsync(DeleteConversationDatasetRequest, CallSettings)
            // Additional: DeleteConversationDatasetAsync(DeleteConversationDatasetRequest, CancellationToken)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = await ConversationDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConversationDatasetRequest request = new DeleteConversationDatasetRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
            };
            // Make the request
            Operation<Empty, DeleteConversationDatasetOperationMetadata> response = await conversationDatasetsClient.DeleteConversationDatasetAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteConversationDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteConversationDatasetOperationMetadata> retrievedResponse = await conversationDatasetsClient.PollOnceDeleteConversationDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationDataset</summary>
        public void DeleteConversationDataset()
        {
            // Snippet: DeleteConversationDataset(string, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversationDatasets/[CONVERSATION_DATASET]";
            // Make the request
            Operation<Empty, DeleteConversationDatasetOperationMetadata> response = conversationDatasetsClient.DeleteConversationDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteConversationDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteConversationDatasetOperationMetadata> retrievedResponse = conversationDatasetsClient.PollOnceDeleteConversationDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationDatasetAsync</summary>
        public async Task DeleteConversationDatasetAsync()
        {
            // Snippet: DeleteConversationDatasetAsync(string, CallSettings)
            // Additional: DeleteConversationDatasetAsync(string, CancellationToken)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = await ConversationDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversationDatasets/[CONVERSATION_DATASET]";
            // Make the request
            Operation<Empty, DeleteConversationDatasetOperationMetadata> response = await conversationDatasetsClient.DeleteConversationDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteConversationDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteConversationDatasetOperationMetadata> retrievedResponse = await conversationDatasetsClient.PollOnceDeleteConversationDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationDataset</summary>
        public void DeleteConversationDatasetResourceNames()
        {
            // Snippet: DeleteConversationDataset(ConversationDatasetName, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            ConversationDatasetName name = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]");
            // Make the request
            Operation<Empty, DeleteConversationDatasetOperationMetadata> response = conversationDatasetsClient.DeleteConversationDataset(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteConversationDatasetOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteConversationDatasetOperationMetadata> retrievedResponse = conversationDatasetsClient.PollOnceDeleteConversationDataset(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationDatasetAsync</summary>
        public async Task DeleteConversationDatasetResourceNamesAsync()
        {
            // Snippet: DeleteConversationDatasetAsync(ConversationDatasetName, CallSettings)
            // Additional: DeleteConversationDatasetAsync(ConversationDatasetName, CancellationToken)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = await ConversationDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationDatasetName name = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]");
            // Make the request
            Operation<Empty, DeleteConversationDatasetOperationMetadata> response = await conversationDatasetsClient.DeleteConversationDatasetAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteConversationDatasetOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteConversationDatasetOperationMetadata> retrievedResponse = await conversationDatasetsClient.PollOnceDeleteConversationDatasetAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportConversationData</summary>
        public void ImportConversationDataRequestObject()
        {
            // Snippet: ImportConversationData(ImportConversationDataRequest, CallSettings)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = ConversationDatasetsClient.Create();
            // Initialize request argument(s)
            ImportConversationDataRequest request = new ImportConversationDataRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
                InputConfig = new InputConfig(),
            };
            // Make the request
            Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata> response = conversationDatasetsClient.ImportConversationData(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportConversationDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata> retrievedResponse = conversationDatasetsClient.PollOnceImportConversationData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportConversationDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportConversationDataAsync</summary>
        public async Task ImportConversationDataRequestObjectAsync()
        {
            // Snippet: ImportConversationDataAsync(ImportConversationDataRequest, CallSettings)
            // Additional: ImportConversationDataAsync(ImportConversationDataRequest, CancellationToken)
            // Create client
            ConversationDatasetsClient conversationDatasetsClient = await ConversationDatasetsClient.CreateAsync();
            // Initialize request argument(s)
            ImportConversationDataRequest request = new ImportConversationDataRequest
            {
                ConversationDatasetName = ConversationDatasetName.FromProjectLocationConversationDataset("[PROJECT]", "[LOCATION]", "[CONVERSATION_DATASET]"),
                InputConfig = new InputConfig(),
            };
            // Make the request
            Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata> response = await conversationDatasetsClient.ImportConversationDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportConversationDataOperationResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportConversationDataOperationResponse, ImportConversationDataOperationMetadata> retrievedResponse = await conversationDatasetsClient.PollOnceImportConversationDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportConversationDataOperationResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
