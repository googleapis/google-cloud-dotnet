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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.GkeMultiCloud.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAzureClustersClientSnippets
    {
        /// <summary>Snippet for CreateAzureClient</summary>
        public void CreateAzureClientRequestObject()
        {
            // Snippet: CreateAzureClient(CreateAzureClientRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            CreateAzureClientRequest request = new CreateAzureClientRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AzureClient = new AzureClient(),
                ValidateOnly = false,
                AzureClientId = "",
            };
            // Make the request
            Operation<AzureClient, OperationMetadata> response = azureClustersClient.CreateAzureClient(request);

            // Poll until the returned long-running operation is complete
            Operation<AzureClient, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureClient result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureClient, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureClient(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureClient retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureClientAsync</summary>
        public async Task CreateAzureClientRequestObjectAsync()
        {
            // Snippet: CreateAzureClientAsync(CreateAzureClientRequest, CallSettings)
            // Additional: CreateAzureClientAsync(CreateAzureClientRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            CreateAzureClientRequest request = new CreateAzureClientRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AzureClient = new AzureClient(),
                ValidateOnly = false,
                AzureClientId = "",
            };
            // Make the request
            Operation<AzureClient, OperationMetadata> response = await azureClustersClient.CreateAzureClientAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AzureClient, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureClient result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureClient, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureClientAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureClient retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureClient</summary>
        public void CreateAzureClient()
        {
            // Snippet: CreateAzureClient(string, AzureClient, string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AzureClient azureClient = new AzureClient();
            string azureClientId = "";
            // Make the request
            Operation<AzureClient, OperationMetadata> response = azureClustersClient.CreateAzureClient(parent, azureClient, azureClientId);

            // Poll until the returned long-running operation is complete
            Operation<AzureClient, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureClient result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureClient, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureClient(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureClient retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureClientAsync</summary>
        public async Task CreateAzureClientAsync()
        {
            // Snippet: CreateAzureClientAsync(string, AzureClient, string, CallSettings)
            // Additional: CreateAzureClientAsync(string, AzureClient, string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AzureClient azureClient = new AzureClient();
            string azureClientId = "";
            // Make the request
            Operation<AzureClient, OperationMetadata> response = await azureClustersClient.CreateAzureClientAsync(parent, azureClient, azureClientId);

            // Poll until the returned long-running operation is complete
            Operation<AzureClient, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureClient result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureClient, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureClientAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureClient retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureClient</summary>
        public void CreateAzureClientResourceNames()
        {
            // Snippet: CreateAzureClient(LocationName, AzureClient, string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AzureClient azureClient = new AzureClient();
            string azureClientId = "";
            // Make the request
            Operation<AzureClient, OperationMetadata> response = azureClustersClient.CreateAzureClient(parent, azureClient, azureClientId);

            // Poll until the returned long-running operation is complete
            Operation<AzureClient, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureClient result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureClient, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureClient(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureClient retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureClientAsync</summary>
        public async Task CreateAzureClientResourceNamesAsync()
        {
            // Snippet: CreateAzureClientAsync(LocationName, AzureClient, string, CallSettings)
            // Additional: CreateAzureClientAsync(LocationName, AzureClient, string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AzureClient azureClient = new AzureClient();
            string azureClientId = "";
            // Make the request
            Operation<AzureClient, OperationMetadata> response = await azureClustersClient.CreateAzureClientAsync(parent, azureClient, azureClientId);

            // Poll until the returned long-running operation is complete
            Operation<AzureClient, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureClient result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureClient, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureClientAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureClient retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAzureClient</summary>
        public void GetAzureClientRequestObject()
        {
            // Snippet: GetAzureClient(GetAzureClientRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            GetAzureClientRequest request = new GetAzureClientRequest
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
            };
            // Make the request
            AzureClient response = azureClustersClient.GetAzureClient(request);
            // End snippet
        }

        /// <summary>Snippet for GetAzureClientAsync</summary>
        public async Task GetAzureClientRequestObjectAsync()
        {
            // Snippet: GetAzureClientAsync(GetAzureClientRequest, CallSettings)
            // Additional: GetAzureClientAsync(GetAzureClientRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAzureClientRequest request = new GetAzureClientRequest
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
            };
            // Make the request
            AzureClient response = await azureClustersClient.GetAzureClientAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAzureClient</summary>
        public void GetAzureClient()
        {
            // Snippet: GetAzureClient(string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureClients/[AZURE_CLIENT]";
            // Make the request
            AzureClient response = azureClustersClient.GetAzureClient(name);
            // End snippet
        }

        /// <summary>Snippet for GetAzureClientAsync</summary>
        public async Task GetAzureClientAsync()
        {
            // Snippet: GetAzureClientAsync(string, CallSettings)
            // Additional: GetAzureClientAsync(string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureClients/[AZURE_CLIENT]";
            // Make the request
            AzureClient response = await azureClustersClient.GetAzureClientAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAzureClient</summary>
        public void GetAzureClientResourceNames()
        {
            // Snippet: GetAzureClient(AzureClientName, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureClientName name = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]");
            // Make the request
            AzureClient response = azureClustersClient.GetAzureClient(name);
            // End snippet
        }

        /// <summary>Snippet for GetAzureClientAsync</summary>
        public async Task GetAzureClientResourceNamesAsync()
        {
            // Snippet: GetAzureClientAsync(AzureClientName, CallSettings)
            // Additional: GetAzureClientAsync(AzureClientName, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureClientName name = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]");
            // Make the request
            AzureClient response = await azureClustersClient.GetAzureClientAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAzureClients</summary>
        public void ListAzureClientsRequestObject()
        {
            // Snippet: ListAzureClients(ListAzureClientsRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            ListAzureClientsRequest request = new ListAzureClientsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListAzureClientsResponse, AzureClient> response = azureClustersClient.ListAzureClients(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AzureClient item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAzureClientsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureClient item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureClient> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureClient item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureClientsAsync</summary>
        public async Task ListAzureClientsRequestObjectAsync()
        {
            // Snippet: ListAzureClientsAsync(ListAzureClientsRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            ListAzureClientsRequest request = new ListAzureClientsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAzureClientsResponse, AzureClient> response = azureClustersClient.ListAzureClientsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AzureClient item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAzureClientsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureClient item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureClient> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureClient item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureClients</summary>
        public void ListAzureClients()
        {
            // Snippet: ListAzureClients(string, string, int?, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAzureClientsResponse, AzureClient> response = azureClustersClient.ListAzureClients(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AzureClient item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAzureClientsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureClient item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureClient> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureClient item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureClientsAsync</summary>
        public async Task ListAzureClientsAsync()
        {
            // Snippet: ListAzureClientsAsync(string, string, int?, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAzureClientsResponse, AzureClient> response = azureClustersClient.ListAzureClientsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AzureClient item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAzureClientsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureClient item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureClient> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureClient item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureClients</summary>
        public void ListAzureClientsResourceNames()
        {
            // Snippet: ListAzureClients(LocationName, string, int?, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAzureClientsResponse, AzureClient> response = azureClustersClient.ListAzureClients(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AzureClient item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAzureClientsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureClient item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureClient> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureClient item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureClientsAsync</summary>
        public async Task ListAzureClientsResourceNamesAsync()
        {
            // Snippet: ListAzureClientsAsync(LocationName, string, int?, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAzureClientsResponse, AzureClient> response = azureClustersClient.ListAzureClientsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AzureClient item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAzureClientsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureClient item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureClient> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureClient item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureClient</summary>
        public void DeleteAzureClientRequestObject()
        {
            // Snippet: DeleteAzureClient(DeleteAzureClientRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            DeleteAzureClientRequest request = new DeleteAzureClientRequest
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureClient(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureClient(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureClientAsync</summary>
        public async Task DeleteAzureClientRequestObjectAsync()
        {
            // Snippet: DeleteAzureClientAsync(DeleteAzureClientRequest, CallSettings)
            // Additional: DeleteAzureClientAsync(DeleteAzureClientRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAzureClientRequest request = new DeleteAzureClientRequest
            {
                AzureClientName = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]"),
                AllowMissing = false,
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureClientAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureClientAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureClient</summary>
        public void DeleteAzureClient()
        {
            // Snippet: DeleteAzureClient(string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureClients/[AZURE_CLIENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureClient(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureClient(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureClientAsync</summary>
        public async Task DeleteAzureClientAsync()
        {
            // Snippet: DeleteAzureClientAsync(string, CallSettings)
            // Additional: DeleteAzureClientAsync(string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureClients/[AZURE_CLIENT]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureClientAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureClientAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureClient</summary>
        public void DeleteAzureClientResourceNames()
        {
            // Snippet: DeleteAzureClient(AzureClientName, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureClientName name = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureClient(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureClient(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureClientAsync</summary>
        public async Task DeleteAzureClientResourceNamesAsync()
        {
            // Snippet: DeleteAzureClientAsync(AzureClientName, CallSettings)
            // Additional: DeleteAzureClientAsync(AzureClientName, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureClientName name = AzureClientName.FromProjectLocationAzureClient("[PROJECT]", "[LOCATION]", "[AZURE_CLIENT]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureClientAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureClientAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureCluster</summary>
        public void CreateAzureClusterRequestObject()
        {
            // Snippet: CreateAzureCluster(CreateAzureClusterRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            CreateAzureClusterRequest request = new CreateAzureClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AzureCluster = new AzureCluster(),
                AzureClusterId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AzureCluster, OperationMetadata> response = azureClustersClient.CreateAzureCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<AzureCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureCluster, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureClusterAsync</summary>
        public async Task CreateAzureClusterRequestObjectAsync()
        {
            // Snippet: CreateAzureClusterAsync(CreateAzureClusterRequest, CallSettings)
            // Additional: CreateAzureClusterAsync(CreateAzureClusterRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            CreateAzureClusterRequest request = new CreateAzureClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AzureCluster = new AzureCluster(),
                AzureClusterId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AzureCluster, OperationMetadata> response = await azureClustersClient.CreateAzureClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AzureCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureCluster, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureCluster</summary>
        public void CreateAzureCluster()
        {
            // Snippet: CreateAzureCluster(string, AzureCluster, string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AzureCluster azureCluster = new AzureCluster();
            string azureClusterId = "";
            // Make the request
            Operation<AzureCluster, OperationMetadata> response = azureClustersClient.CreateAzureCluster(parent, azureCluster, azureClusterId);

            // Poll until the returned long-running operation is complete
            Operation<AzureCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureCluster, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureClusterAsync</summary>
        public async Task CreateAzureClusterAsync()
        {
            // Snippet: CreateAzureClusterAsync(string, AzureCluster, string, CallSettings)
            // Additional: CreateAzureClusterAsync(string, AzureCluster, string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AzureCluster azureCluster = new AzureCluster();
            string azureClusterId = "";
            // Make the request
            Operation<AzureCluster, OperationMetadata> response = await azureClustersClient.CreateAzureClusterAsync(parent, azureCluster, azureClusterId);

            // Poll until the returned long-running operation is complete
            Operation<AzureCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureCluster, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureCluster</summary>
        public void CreateAzureClusterResourceNames()
        {
            // Snippet: CreateAzureCluster(LocationName, AzureCluster, string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AzureCluster azureCluster = new AzureCluster();
            string azureClusterId = "";
            // Make the request
            Operation<AzureCluster, OperationMetadata> response = azureClustersClient.CreateAzureCluster(parent, azureCluster, azureClusterId);

            // Poll until the returned long-running operation is complete
            Operation<AzureCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureCluster, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureClusterAsync</summary>
        public async Task CreateAzureClusterResourceNamesAsync()
        {
            // Snippet: CreateAzureClusterAsync(LocationName, AzureCluster, string, CallSettings)
            // Additional: CreateAzureClusterAsync(LocationName, AzureCluster, string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AzureCluster azureCluster = new AzureCluster();
            string azureClusterId = "";
            // Make the request
            Operation<AzureCluster, OperationMetadata> response = await azureClustersClient.CreateAzureClusterAsync(parent, azureCluster, azureClusterId);

            // Poll until the returned long-running operation is complete
            Operation<AzureCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureCluster, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAzureCluster</summary>
        public void UpdateAzureClusterRequestObject()
        {
            // Snippet: UpdateAzureCluster(UpdateAzureClusterRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            UpdateAzureClusterRequest request = new UpdateAzureClusterRequest
            {
                AzureCluster = new AzureCluster(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AzureCluster, OperationMetadata> response = azureClustersClient.UpdateAzureCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<AzureCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureCluster, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceUpdateAzureCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAzureClusterAsync</summary>
        public async Task UpdateAzureClusterRequestObjectAsync()
        {
            // Snippet: UpdateAzureClusterAsync(UpdateAzureClusterRequest, CallSettings)
            // Additional: UpdateAzureClusterAsync(UpdateAzureClusterRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAzureClusterRequest request = new UpdateAzureClusterRequest
            {
                AzureCluster = new AzureCluster(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AzureCluster, OperationMetadata> response = await azureClustersClient.UpdateAzureClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AzureCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureCluster, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceUpdateAzureClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAzureCluster</summary>
        public void UpdateAzureCluster()
        {
            // Snippet: UpdateAzureCluster(AzureCluster, FieldMask, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureCluster azureCluster = new AzureCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AzureCluster, OperationMetadata> response = azureClustersClient.UpdateAzureCluster(azureCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AzureCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureCluster, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceUpdateAzureCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAzureClusterAsync</summary>
        public async Task UpdateAzureClusterAsync()
        {
            // Snippet: UpdateAzureClusterAsync(AzureCluster, FieldMask, CallSettings)
            // Additional: UpdateAzureClusterAsync(AzureCluster, FieldMask, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureCluster azureCluster = new AzureCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AzureCluster, OperationMetadata> response = await azureClustersClient.UpdateAzureClusterAsync(azureCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AzureCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureCluster, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceUpdateAzureClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAzureCluster</summary>
        public void GetAzureClusterRequestObject()
        {
            // Snippet: GetAzureCluster(GetAzureClusterRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            GetAzureClusterRequest request = new GetAzureClusterRequest
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            // Make the request
            AzureCluster response = azureClustersClient.GetAzureCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetAzureClusterAsync</summary>
        public async Task GetAzureClusterRequestObjectAsync()
        {
            // Snippet: GetAzureClusterAsync(GetAzureClusterRequest, CallSettings)
            // Additional: GetAzureClusterAsync(GetAzureClusterRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAzureClusterRequest request = new GetAzureClusterRequest
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            // Make the request
            AzureCluster response = await azureClustersClient.GetAzureClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAzureCluster</summary>
        public void GetAzureCluster()
        {
            // Snippet: GetAzureCluster(string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]";
            // Make the request
            AzureCluster response = azureClustersClient.GetAzureCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetAzureClusterAsync</summary>
        public async Task GetAzureClusterAsync()
        {
            // Snippet: GetAzureClusterAsync(string, CallSettings)
            // Additional: GetAzureClusterAsync(string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]";
            // Make the request
            AzureCluster response = await azureClustersClient.GetAzureClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAzureCluster</summary>
        public void GetAzureClusterResourceNames()
        {
            // Snippet: GetAzureCluster(AzureClusterName, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureClusterName name = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]");
            // Make the request
            AzureCluster response = azureClustersClient.GetAzureCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetAzureClusterAsync</summary>
        public async Task GetAzureClusterResourceNamesAsync()
        {
            // Snippet: GetAzureClusterAsync(AzureClusterName, CallSettings)
            // Additional: GetAzureClusterAsync(AzureClusterName, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureClusterName name = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]");
            // Make the request
            AzureCluster response = await azureClustersClient.GetAzureClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAzureClusters</summary>
        public void ListAzureClustersRequestObject()
        {
            // Snippet: ListAzureClusters(ListAzureClustersRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            ListAzureClustersRequest request = new ListAzureClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListAzureClustersResponse, AzureCluster> response = azureClustersClient.ListAzureClusters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AzureCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAzureClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureClustersAsync</summary>
        public async Task ListAzureClustersRequestObjectAsync()
        {
            // Snippet: ListAzureClustersAsync(ListAzureClustersRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            ListAzureClustersRequest request = new ListAzureClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAzureClustersResponse, AzureCluster> response = azureClustersClient.ListAzureClustersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AzureCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAzureClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureClusters</summary>
        public void ListAzureClusters()
        {
            // Snippet: ListAzureClusters(string, string, int?, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAzureClustersResponse, AzureCluster> response = azureClustersClient.ListAzureClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AzureCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAzureClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureClustersAsync</summary>
        public async Task ListAzureClustersAsync()
        {
            // Snippet: ListAzureClustersAsync(string, string, int?, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAzureClustersResponse, AzureCluster> response = azureClustersClient.ListAzureClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AzureCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAzureClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureClusters</summary>
        public void ListAzureClustersResourceNames()
        {
            // Snippet: ListAzureClusters(LocationName, string, int?, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAzureClustersResponse, AzureCluster> response = azureClustersClient.ListAzureClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AzureCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAzureClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureClustersAsync</summary>
        public async Task ListAzureClustersResourceNamesAsync()
        {
            // Snippet: ListAzureClustersAsync(LocationName, string, int?, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAzureClustersResponse, AzureCluster> response = azureClustersClient.ListAzureClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AzureCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAzureClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureCluster</summary>
        public void DeleteAzureClusterRequestObject()
        {
            // Snippet: DeleteAzureCluster(DeleteAzureClusterRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            DeleteAzureClusterRequest request = new DeleteAzureClusterRequest
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
                AllowMissing = false,
                ValidateOnly = false,
                Etag = "",
                IgnoreErrors = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureClusterAsync</summary>
        public async Task DeleteAzureClusterRequestObjectAsync()
        {
            // Snippet: DeleteAzureClusterAsync(DeleteAzureClusterRequest, CallSettings)
            // Additional: DeleteAzureClusterAsync(DeleteAzureClusterRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAzureClusterRequest request = new DeleteAzureClusterRequest
            {
                AzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
                AllowMissing = false,
                ValidateOnly = false,
                Etag = "",
                IgnoreErrors = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureCluster</summary>
        public void DeleteAzureCluster()
        {
            // Snippet: DeleteAzureCluster(string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureClusterAsync</summary>
        public async Task DeleteAzureClusterAsync()
        {
            // Snippet: DeleteAzureClusterAsync(string, CallSettings)
            // Additional: DeleteAzureClusterAsync(string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureCluster</summary>
        public void DeleteAzureClusterResourceNames()
        {
            // Snippet: DeleteAzureCluster(AzureClusterName, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureClusterName name = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureClusterAsync</summary>
        public async Task DeleteAzureClusterResourceNamesAsync()
        {
            // Snippet: DeleteAzureClusterAsync(AzureClusterName, CallSettings)
            // Additional: DeleteAzureClusterAsync(AzureClusterName, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureClusterName name = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateAzureClusterAgentToken</summary>
        public void GenerateAzureClusterAgentTokenRequestObject()
        {
            // Snippet: GenerateAzureClusterAgentToken(GenerateAzureClusterAgentTokenRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            GenerateAzureClusterAgentTokenRequest request = new GenerateAzureClusterAgentTokenRequest
            {
                AzureClusterAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
                SubjectToken = "",
                SubjectTokenType = "",
                Version = "",
                NodePoolId = "",
                GrantType = "",
                Audience = "",
                Scope = "",
                RequestedTokenType = "",
                Options = "",
            };
            // Make the request
            GenerateAzureClusterAgentTokenResponse response = azureClustersClient.GenerateAzureClusterAgentToken(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAzureClusterAgentTokenAsync</summary>
        public async Task GenerateAzureClusterAgentTokenRequestObjectAsync()
        {
            // Snippet: GenerateAzureClusterAgentTokenAsync(GenerateAzureClusterAgentTokenRequest, CallSettings)
            // Additional: GenerateAzureClusterAgentTokenAsync(GenerateAzureClusterAgentTokenRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            GenerateAzureClusterAgentTokenRequest request = new GenerateAzureClusterAgentTokenRequest
            {
                AzureClusterAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
                SubjectToken = "",
                SubjectTokenType = "",
                Version = "",
                NodePoolId = "",
                GrantType = "",
                Audience = "",
                Scope = "",
                RequestedTokenType = "",
                Options = "",
            };
            // Make the request
            GenerateAzureClusterAgentTokenResponse response = await azureClustersClient.GenerateAzureClusterAgentTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAzureAccessToken</summary>
        public void GenerateAzureAccessTokenRequestObject()
        {
            // Snippet: GenerateAzureAccessToken(GenerateAzureAccessTokenRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            GenerateAzureAccessTokenRequest request = new GenerateAzureAccessTokenRequest
            {
                AzureClusterAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            // Make the request
            GenerateAzureAccessTokenResponse response = azureClustersClient.GenerateAzureAccessToken(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAzureAccessTokenAsync</summary>
        public async Task GenerateAzureAccessTokenRequestObjectAsync()
        {
            // Snippet: GenerateAzureAccessTokenAsync(GenerateAzureAccessTokenRequest, CallSettings)
            // Additional: GenerateAzureAccessTokenAsync(GenerateAzureAccessTokenRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            GenerateAzureAccessTokenRequest request = new GenerateAzureAccessTokenRequest
            {
                AzureClusterAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            // Make the request
            GenerateAzureAccessTokenResponse response = await azureClustersClient.GenerateAzureAccessTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAzureNodePool</summary>
        public void CreateAzureNodePoolRequestObject()
        {
            // Snippet: CreateAzureNodePool(CreateAzureNodePoolRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            CreateAzureNodePoolRequest request = new CreateAzureNodePoolRequest
            {
                ParentAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
                AzureNodePool = new AzureNodePool(),
                AzureNodePoolId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AzureNodePool, OperationMetadata> response = azureClustersClient.CreateAzureNodePool(request);

            // Poll until the returned long-running operation is complete
            Operation<AzureNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureNodePoolAsync</summary>
        public async Task CreateAzureNodePoolRequestObjectAsync()
        {
            // Snippet: CreateAzureNodePoolAsync(CreateAzureNodePoolRequest, CallSettings)
            // Additional: CreateAzureNodePoolAsync(CreateAzureNodePoolRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            CreateAzureNodePoolRequest request = new CreateAzureNodePoolRequest
            {
                ParentAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
                AzureNodePool = new AzureNodePool(),
                AzureNodePoolId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AzureNodePool, OperationMetadata> response = await azureClustersClient.CreateAzureNodePoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AzureNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureNodePool</summary>
        public void CreateAzureNodePool()
        {
            // Snippet: CreateAzureNodePool(string, AzureNodePool, string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]";
            AzureNodePool azureNodePool = new AzureNodePool();
            string azureNodePoolId = "";
            // Make the request
            Operation<AzureNodePool, OperationMetadata> response = azureClustersClient.CreateAzureNodePool(parent, azureNodePool, azureNodePoolId);

            // Poll until the returned long-running operation is complete
            Operation<AzureNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureNodePoolAsync</summary>
        public async Task CreateAzureNodePoolAsync()
        {
            // Snippet: CreateAzureNodePoolAsync(string, AzureNodePool, string, CallSettings)
            // Additional: CreateAzureNodePoolAsync(string, AzureNodePool, string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]";
            AzureNodePool azureNodePool = new AzureNodePool();
            string azureNodePoolId = "";
            // Make the request
            Operation<AzureNodePool, OperationMetadata> response = await azureClustersClient.CreateAzureNodePoolAsync(parent, azureNodePool, azureNodePoolId);

            // Poll until the returned long-running operation is complete
            Operation<AzureNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureNodePool</summary>
        public void CreateAzureNodePoolResourceNames()
        {
            // Snippet: CreateAzureNodePool(AzureClusterName, AzureNodePool, string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureClusterName parent = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]");
            AzureNodePool azureNodePool = new AzureNodePool();
            string azureNodePoolId = "";
            // Make the request
            Operation<AzureNodePool, OperationMetadata> response = azureClustersClient.CreateAzureNodePool(parent, azureNodePool, azureNodePoolId);

            // Poll until the returned long-running operation is complete
            Operation<AzureNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAzureNodePoolAsync</summary>
        public async Task CreateAzureNodePoolResourceNamesAsync()
        {
            // Snippet: CreateAzureNodePoolAsync(AzureClusterName, AzureNodePool, string, CallSettings)
            // Additional: CreateAzureNodePoolAsync(AzureClusterName, AzureNodePool, string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureClusterName parent = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]");
            AzureNodePool azureNodePool = new AzureNodePool();
            string azureNodePoolId = "";
            // Make the request
            Operation<AzureNodePool, OperationMetadata> response = await azureClustersClient.CreateAzureNodePoolAsync(parent, azureNodePool, azureNodePoolId);

            // Poll until the returned long-running operation is complete
            Operation<AzureNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAzureNodePool</summary>
        public void UpdateAzureNodePoolRequestObject()
        {
            // Snippet: UpdateAzureNodePool(UpdateAzureNodePoolRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            UpdateAzureNodePoolRequest request = new UpdateAzureNodePoolRequest
            {
                AzureNodePool = new AzureNodePool(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AzureNodePool, OperationMetadata> response = azureClustersClient.UpdateAzureNodePool(request);

            // Poll until the returned long-running operation is complete
            Operation<AzureNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceUpdateAzureNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAzureNodePoolAsync</summary>
        public async Task UpdateAzureNodePoolRequestObjectAsync()
        {
            // Snippet: UpdateAzureNodePoolAsync(UpdateAzureNodePoolRequest, CallSettings)
            // Additional: UpdateAzureNodePoolAsync(UpdateAzureNodePoolRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAzureNodePoolRequest request = new UpdateAzureNodePoolRequest
            {
                AzureNodePool = new AzureNodePool(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AzureNodePool, OperationMetadata> response = await azureClustersClient.UpdateAzureNodePoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AzureNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceUpdateAzureNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAzureNodePool</summary>
        public void UpdateAzureNodePool()
        {
            // Snippet: UpdateAzureNodePool(AzureNodePool, FieldMask, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureNodePool azureNodePool = new AzureNodePool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AzureNodePool, OperationMetadata> response = azureClustersClient.UpdateAzureNodePool(azureNodePool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AzureNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AzureNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceUpdateAzureNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAzureNodePoolAsync</summary>
        public async Task UpdateAzureNodePoolAsync()
        {
            // Snippet: UpdateAzureNodePoolAsync(AzureNodePool, FieldMask, CallSettings)
            // Additional: UpdateAzureNodePoolAsync(AzureNodePool, FieldMask, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureNodePool azureNodePool = new AzureNodePool();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AzureNodePool, OperationMetadata> response = await azureClustersClient.UpdateAzureNodePoolAsync(azureNodePool, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AzureNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AzureNodePool result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceUpdateAzureNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AzureNodePool retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAzureNodePool</summary>
        public void GetAzureNodePoolRequestObject()
        {
            // Snippet: GetAzureNodePool(GetAzureNodePoolRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            GetAzureNodePoolRequest request = new GetAzureNodePoolRequest
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
            };
            // Make the request
            AzureNodePool response = azureClustersClient.GetAzureNodePool(request);
            // End snippet
        }

        /// <summary>Snippet for GetAzureNodePoolAsync</summary>
        public async Task GetAzureNodePoolRequestObjectAsync()
        {
            // Snippet: GetAzureNodePoolAsync(GetAzureNodePoolRequest, CallSettings)
            // Additional: GetAzureNodePoolAsync(GetAzureNodePoolRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAzureNodePoolRequest request = new GetAzureNodePoolRequest
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
            };
            // Make the request
            AzureNodePool response = await azureClustersClient.GetAzureNodePoolAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAzureNodePool</summary>
        public void GetAzureNodePool()
        {
            // Snippet: GetAzureNodePool(string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]/azureNodePools/[AZURE_NODE_POOL]";
            // Make the request
            AzureNodePool response = azureClustersClient.GetAzureNodePool(name);
            // End snippet
        }

        /// <summary>Snippet for GetAzureNodePoolAsync</summary>
        public async Task GetAzureNodePoolAsync()
        {
            // Snippet: GetAzureNodePoolAsync(string, CallSettings)
            // Additional: GetAzureNodePoolAsync(string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]/azureNodePools/[AZURE_NODE_POOL]";
            // Make the request
            AzureNodePool response = await azureClustersClient.GetAzureNodePoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAzureNodePool</summary>
        public void GetAzureNodePoolResourceNames()
        {
            // Snippet: GetAzureNodePool(AzureNodePoolName, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureNodePoolName name = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]");
            // Make the request
            AzureNodePool response = azureClustersClient.GetAzureNodePool(name);
            // End snippet
        }

        /// <summary>Snippet for GetAzureNodePoolAsync</summary>
        public async Task GetAzureNodePoolResourceNamesAsync()
        {
            // Snippet: GetAzureNodePoolAsync(AzureNodePoolName, CallSettings)
            // Additional: GetAzureNodePoolAsync(AzureNodePoolName, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureNodePoolName name = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]");
            // Make the request
            AzureNodePool response = await azureClustersClient.GetAzureNodePoolAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAzureNodePools</summary>
        public void ListAzureNodePoolsRequestObject()
        {
            // Snippet: ListAzureNodePools(ListAzureNodePoolsRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            ListAzureNodePoolsRequest request = new ListAzureNodePoolsRequest
            {
                ParentAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            // Make the request
            PagedEnumerable<ListAzureNodePoolsResponse, AzureNodePool> response = azureClustersClient.ListAzureNodePools(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AzureNodePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAzureNodePoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureNodePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureNodePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureNodePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureNodePoolsAsync</summary>
        public async Task ListAzureNodePoolsRequestObjectAsync()
        {
            // Snippet: ListAzureNodePoolsAsync(ListAzureNodePoolsRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            ListAzureNodePoolsRequest request = new ListAzureNodePoolsRequest
            {
                ParentAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAzureNodePoolsResponse, AzureNodePool> response = azureClustersClient.ListAzureNodePoolsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AzureNodePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAzureNodePoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureNodePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureNodePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureNodePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureNodePools</summary>
        public void ListAzureNodePools()
        {
            // Snippet: ListAzureNodePools(string, string, int?, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]";
            // Make the request
            PagedEnumerable<ListAzureNodePoolsResponse, AzureNodePool> response = azureClustersClient.ListAzureNodePools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AzureNodePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAzureNodePoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureNodePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureNodePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureNodePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureNodePoolsAsync</summary>
        public async Task ListAzureNodePoolsAsync()
        {
            // Snippet: ListAzureNodePoolsAsync(string, string, int?, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListAzureNodePoolsResponse, AzureNodePool> response = azureClustersClient.ListAzureNodePoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AzureNodePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAzureNodePoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureNodePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureNodePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureNodePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureNodePools</summary>
        public void ListAzureNodePoolsResourceNames()
        {
            // Snippet: ListAzureNodePools(AzureClusterName, string, int?, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureClusterName parent = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]");
            // Make the request
            PagedEnumerable<ListAzureNodePoolsResponse, AzureNodePool> response = azureClustersClient.ListAzureNodePools(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AzureNodePool item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAzureNodePoolsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureNodePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureNodePool> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureNodePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAzureNodePoolsAsync</summary>
        public async Task ListAzureNodePoolsResourceNamesAsync()
        {
            // Snippet: ListAzureNodePoolsAsync(AzureClusterName, string, int?, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureClusterName parent = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListAzureNodePoolsResponse, AzureNodePool> response = azureClustersClient.ListAzureNodePoolsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AzureNodePool item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAzureNodePoolsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AzureNodePool item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AzureNodePool> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AzureNodePool item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureNodePool</summary>
        public void DeleteAzureNodePoolRequestObject()
        {
            // Snippet: DeleteAzureNodePool(DeleteAzureNodePoolRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            DeleteAzureNodePoolRequest request = new DeleteAzureNodePoolRequest
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
                ValidateOnly = false,
                AllowMissing = false,
                Etag = "",
                IgnoreErrors = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureNodePool(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureNodePoolAsync</summary>
        public async Task DeleteAzureNodePoolRequestObjectAsync()
        {
            // Snippet: DeleteAzureNodePoolAsync(DeleteAzureNodePoolRequest, CallSettings)
            // Additional: DeleteAzureNodePoolAsync(DeleteAzureNodePoolRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAzureNodePoolRequest request = new DeleteAzureNodePoolRequest
            {
                AzureNodePoolName = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]"),
                ValidateOnly = false,
                AllowMissing = false,
                Etag = "",
                IgnoreErrors = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureNodePoolAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureNodePool</summary>
        public void DeleteAzureNodePool()
        {
            // Snippet: DeleteAzureNodePool(string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]/azureNodePools/[AZURE_NODE_POOL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureNodePool(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureNodePoolAsync</summary>
        public async Task DeleteAzureNodePoolAsync()
        {
            // Snippet: DeleteAzureNodePoolAsync(string, CallSettings)
            // Additional: DeleteAzureNodePoolAsync(string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]/azureNodePools/[AZURE_NODE_POOL]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureNodePoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureNodePool</summary>
        public void DeleteAzureNodePoolResourceNames()
        {
            // Snippet: DeleteAzureNodePool(AzureNodePoolName, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureNodePoolName name = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureNodePool(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureNodePool(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAzureNodePoolAsync</summary>
        public async Task DeleteAzureNodePoolResourceNamesAsync()
        {
            // Snippet: DeleteAzureNodePoolAsync(AzureNodePoolName, CallSettings)
            // Additional: DeleteAzureNodePoolAsync(AzureNodePoolName, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureNodePoolName name = AzureNodePoolName.FromProjectLocationAzureClusterAzureNodePool("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]", "[AZURE_NODE_POOL]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureNodePoolAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureNodePoolAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAzureOpenIdConfig</summary>
        public void GetAzureOpenIdConfigRequestObject()
        {
            // Snippet: GetAzureOpenIdConfig(GetAzureOpenIdConfigRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            GetAzureOpenIdConfigRequest request = new GetAzureOpenIdConfigRequest
            {
                AzureClusterAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            // Make the request
            AzureOpenIdConfig response = azureClustersClient.GetAzureOpenIdConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetAzureOpenIdConfigAsync</summary>
        public async Task GetAzureOpenIdConfigRequestObjectAsync()
        {
            // Snippet: GetAzureOpenIdConfigAsync(GetAzureOpenIdConfigRequest, CallSettings)
            // Additional: GetAzureOpenIdConfigAsync(GetAzureOpenIdConfigRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAzureOpenIdConfigRequest request = new GetAzureOpenIdConfigRequest
            {
                AzureClusterAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            // Make the request
            AzureOpenIdConfig response = await azureClustersClient.GetAzureOpenIdConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAzureOpenIdConfig</summary>
        public void GetAzureOpenIdConfig()
        {
            // Snippet: GetAzureOpenIdConfig(string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string azureCluster = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]";
            // Make the request
            AzureOpenIdConfig response = azureClustersClient.GetAzureOpenIdConfig(azureCluster);
            // End snippet
        }

        /// <summary>Snippet for GetAzureOpenIdConfigAsync</summary>
        public async Task GetAzureOpenIdConfigAsync()
        {
            // Snippet: GetAzureOpenIdConfigAsync(string, CallSettings)
            // Additional: GetAzureOpenIdConfigAsync(string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string azureCluster = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]";
            // Make the request
            AzureOpenIdConfig response = await azureClustersClient.GetAzureOpenIdConfigAsync(azureCluster);
            // End snippet
        }

        /// <summary>Snippet for GetAzureOpenIdConfig</summary>
        public void GetAzureOpenIdConfigResourceNames()
        {
            // Snippet: GetAzureOpenIdConfig(AzureClusterName, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureClusterName azureCluster = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]");
            // Make the request
            AzureOpenIdConfig response = azureClustersClient.GetAzureOpenIdConfig(azureCluster);
            // End snippet
        }

        /// <summary>Snippet for GetAzureOpenIdConfigAsync</summary>
        public async Task GetAzureOpenIdConfigResourceNamesAsync()
        {
            // Snippet: GetAzureOpenIdConfigAsync(AzureClusterName, CallSettings)
            // Additional: GetAzureOpenIdConfigAsync(AzureClusterName, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureClusterName azureCluster = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]");
            // Make the request
            AzureOpenIdConfig response = await azureClustersClient.GetAzureOpenIdConfigAsync(azureCluster);
            // End snippet
        }

        /// <summary>Snippet for GetAzureJsonWebKeys</summary>
        public void GetAzureJsonWebKeysRequestObject()
        {
            // Snippet: GetAzureJsonWebKeys(GetAzureJsonWebKeysRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            GetAzureJsonWebKeysRequest request = new GetAzureJsonWebKeysRequest
            {
                AzureClusterAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            // Make the request
            AzureJsonWebKeys response = azureClustersClient.GetAzureJsonWebKeys(request);
            // End snippet
        }

        /// <summary>Snippet for GetAzureJsonWebKeysAsync</summary>
        public async Task GetAzureJsonWebKeysRequestObjectAsync()
        {
            // Snippet: GetAzureJsonWebKeysAsync(GetAzureJsonWebKeysRequest, CallSettings)
            // Additional: GetAzureJsonWebKeysAsync(GetAzureJsonWebKeysRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAzureJsonWebKeysRequest request = new GetAzureJsonWebKeysRequest
            {
                AzureClusterAsAzureClusterName = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]"),
            };
            // Make the request
            AzureJsonWebKeys response = await azureClustersClient.GetAzureJsonWebKeysAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAzureJsonWebKeys</summary>
        public void GetAzureJsonWebKeys()
        {
            // Snippet: GetAzureJsonWebKeys(string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string azureCluster = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]";
            // Make the request
            AzureJsonWebKeys response = azureClustersClient.GetAzureJsonWebKeys(azureCluster);
            // End snippet
        }

        /// <summary>Snippet for GetAzureJsonWebKeysAsync</summary>
        public async Task GetAzureJsonWebKeysAsync()
        {
            // Snippet: GetAzureJsonWebKeysAsync(string, CallSettings)
            // Additional: GetAzureJsonWebKeysAsync(string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string azureCluster = "projects/[PROJECT]/locations/[LOCATION]/azureClusters/[AZURE_CLUSTER]";
            // Make the request
            AzureJsonWebKeys response = await azureClustersClient.GetAzureJsonWebKeysAsync(azureCluster);
            // End snippet
        }

        /// <summary>Snippet for GetAzureJsonWebKeys</summary>
        public void GetAzureJsonWebKeysResourceNames()
        {
            // Snippet: GetAzureJsonWebKeys(AzureClusterName, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureClusterName azureCluster = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]");
            // Make the request
            AzureJsonWebKeys response = azureClustersClient.GetAzureJsonWebKeys(azureCluster);
            // End snippet
        }

        /// <summary>Snippet for GetAzureJsonWebKeysAsync</summary>
        public async Task GetAzureJsonWebKeysResourceNamesAsync()
        {
            // Snippet: GetAzureJsonWebKeysAsync(AzureClusterName, CallSettings)
            // Additional: GetAzureJsonWebKeysAsync(AzureClusterName, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureClusterName azureCluster = AzureClusterName.FromProjectLocationAzureCluster("[PROJECT]", "[LOCATION]", "[AZURE_CLUSTER]");
            // Make the request
            AzureJsonWebKeys response = await azureClustersClient.GetAzureJsonWebKeysAsync(azureCluster);
            // End snippet
        }

        /// <summary>Snippet for GetAzureServerConfig</summary>
        public void GetAzureServerConfigRequestObject()
        {
            // Snippet: GetAzureServerConfig(GetAzureServerConfigRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            GetAzureServerConfigRequest request = new GetAzureServerConfigRequest
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            AzureServerConfig response = azureClustersClient.GetAzureServerConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetAzureServerConfigAsync</summary>
        public async Task GetAzureServerConfigRequestObjectAsync()
        {
            // Snippet: GetAzureServerConfigAsync(GetAzureServerConfigRequest, CallSettings)
            // Additional: GetAzureServerConfigAsync(GetAzureServerConfigRequest, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAzureServerConfigRequest request = new GetAzureServerConfigRequest
            {
                AzureServerConfigName = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            AzureServerConfig response = await azureClustersClient.GetAzureServerConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAzureServerConfig</summary>
        public void GetAzureServerConfig()
        {
            // Snippet: GetAzureServerConfig(string, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureServerConfig";
            // Make the request
            AzureServerConfig response = azureClustersClient.GetAzureServerConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetAzureServerConfigAsync</summary>
        public async Task GetAzureServerConfigAsync()
        {
            // Snippet: GetAzureServerConfigAsync(string, CallSettings)
            // Additional: GetAzureServerConfigAsync(string, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/azureServerConfig";
            // Make the request
            AzureServerConfig response = await azureClustersClient.GetAzureServerConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAzureServerConfig</summary>
        public void GetAzureServerConfigResourceNames()
        {
            // Snippet: GetAzureServerConfig(AzureServerConfigName, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
            AzureServerConfigName name = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            AzureServerConfig response = azureClustersClient.GetAzureServerConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetAzureServerConfigAsync</summary>
        public async Task GetAzureServerConfigResourceNamesAsync()
        {
            // Snippet: GetAzureServerConfigAsync(AzureServerConfigName, CallSettings)
            // Additional: GetAzureServerConfigAsync(AzureServerConfigName, CancellationToken)
            // Create client
            AzureClustersClient azureClustersClient = await AzureClustersClient.CreateAsync();
            // Initialize request argument(s)
            AzureServerConfigName name = AzureServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            AzureServerConfig response = await azureClustersClient.GetAzureServerConfigAsync(name);
            // End snippet
        }
    }
}
