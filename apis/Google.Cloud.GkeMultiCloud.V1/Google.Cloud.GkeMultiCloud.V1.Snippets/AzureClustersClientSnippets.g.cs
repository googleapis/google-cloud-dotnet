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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.GkeMultiCloud.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    [ObsoleteAttribute]
    public sealed class AllGeneratedAzureClustersClientSnippets
    {
        /// <summary>Snippet for CreateAzureClient</summary>
        public void CreateAzureClientRequestObject()
        {
            // Snippet: CreateAzureClient(CreateAzureClientRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            CreateAzureClientRequest request = new CreateAzureClientRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> response = azureClustersClient.CreateAzureClient(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureClient result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureClient(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureClient retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            CreateAzureClientRequest request = new CreateAzureClientRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> response = await azureClustersClient.CreateAzureClientAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureClient result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureClientAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureClient retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureClient azureClient = new AzureClient();
#pragma warning restore CS0612
            string azureClientId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> response = azureClustersClient.CreateAzureClient(parent, azureClient, azureClientId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureClient result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureClient(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureClient retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureClient azureClient = new AzureClient();
#pragma warning restore CS0612
            string azureClientId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> response = await azureClustersClient.CreateAzureClientAsync(parent, azureClient, azureClientId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureClient result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureClientAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureClient retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureClient azureClient = new AzureClient();
#pragma warning restore CS0612
            string azureClientId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> response = azureClustersClient.CreateAzureClient(parent, azureClient, azureClientId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureClient result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureClient(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureClient retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureClient azureClient = new AzureClient();
#pragma warning restore CS0612
            string azureClientId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> response = await azureClustersClient.CreateAzureClientAsync(parent, azureClient, azureClientId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureClient result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureClient, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureClientAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureClient retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAzureClientRequest request = new GetAzureClientRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AzureClient response = azureClustersClient.GetAzureClient(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAzureClientRequest request = new GetAzureClientRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AzureClient response = await azureClustersClient.GetAzureClientAsync(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureClient response = azureClustersClient.GetAzureClient(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureClient response = await azureClustersClient.GetAzureClientAsync(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureClient response = azureClustersClient.GetAzureClient(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureClient response = await azureClustersClient.GetAzureClientAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListAzureClients</summary>
        public void ListAzureClientsRequestObject()
        {
            // Snippet: ListAzureClients(ListAzureClientsRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListAzureClientsRequest request = new ListAzureClientsRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListAzureClientsResponse, AzureClient> response = azureClustersClient.ListAzureClients(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AzureClient item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAzureClientsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureClient item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureClient> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureClient item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            ListAzureClientsRequest request = new ListAzureClientsRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAzureClientsResponse, AzureClient> response = azureClustersClient.ListAzureClientsAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((AzureClient item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListAzureClientsResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureClient item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureClient> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureClient item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedEnumerable<ListAzureClientsResponse, AzureClient> response = azureClustersClient.ListAzureClients(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AzureClient item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAzureClientsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureClient item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureClient> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureClient item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAzureClientsResponse, AzureClient> response = azureClustersClient.ListAzureClientsAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((AzureClient item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListAzureClientsResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureClient item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureClient> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureClient item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedEnumerable<ListAzureClientsResponse, AzureClient> response = azureClustersClient.ListAzureClients(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AzureClient item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAzureClientsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureClient item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureClient> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureClient item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAzureClientsResponse, AzureClient> response = azureClustersClient.ListAzureClientsAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((AzureClient item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListAzureClientsResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureClient item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureClient> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureClient item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            DeleteAzureClientRequest request = new DeleteAzureClientRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureClient(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureClient(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            DeleteAzureClientRequest request = new DeleteAzureClientRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureClientAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureClientAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureClient(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureClient(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureClientAsync(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureClientAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureClient(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureClient(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureClientAsync(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureClientAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            CreateAzureClusterRequest request = new CreateAzureClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> response = azureClustersClient.CreateAzureCluster(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureCluster(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            CreateAzureClusterRequest request = new CreateAzureClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> response = await azureClustersClient.CreateAzureClusterAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureClusterAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureCluster azureCluster = new AzureCluster();
#pragma warning restore CS0612
            string azureClusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> response = azureClustersClient.CreateAzureCluster(parent, azureCluster, azureClusterId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureCluster(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureCluster azureCluster = new AzureCluster();
#pragma warning restore CS0612
            string azureClusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> response = await azureClustersClient.CreateAzureClusterAsync(parent, azureCluster, azureClusterId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureClusterAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureCluster azureCluster = new AzureCluster();
#pragma warning restore CS0612
            string azureClusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> response = azureClustersClient.CreateAzureCluster(parent, azureCluster, azureClusterId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureCluster(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureCluster azureCluster = new AzureCluster();
#pragma warning restore CS0612
            string azureClusterId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> response = await azureClustersClient.CreateAzureClusterAsync(parent, azureCluster, azureClusterId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureClusterAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            UpdateAzureClusterRequest request = new UpdateAzureClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> response = azureClustersClient.UpdateAzureCluster(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceUpdateAzureCluster(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            UpdateAzureClusterRequest request = new UpdateAzureClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> response = await azureClustersClient.UpdateAzureClusterAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceUpdateAzureClusterAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureCluster azureCluster = new AzureCluster();
#pragma warning restore CS0612
            FieldMask updateMask = new FieldMask();
            // Make the request
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> response = azureClustersClient.UpdateAzureCluster(azureCluster, updateMask);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceUpdateAzureCluster(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureCluster azureCluster = new AzureCluster();
#pragma warning restore CS0612
            FieldMask updateMask = new FieldMask();
            // Make the request
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> response = await azureClustersClient.UpdateAzureClusterAsync(azureCluster, updateMask);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureCluster result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureCluster, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceUpdateAzureClusterAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureCluster retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAzureClusterRequest request = new GetAzureClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AzureCluster response = azureClustersClient.GetAzureCluster(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAzureClusterRequest request = new GetAzureClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AzureCluster response = await azureClustersClient.GetAzureClusterAsync(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureCluster response = azureClustersClient.GetAzureCluster(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureCluster response = await azureClustersClient.GetAzureClusterAsync(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureCluster response = azureClustersClient.GetAzureCluster(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureCluster response = await azureClustersClient.GetAzureClusterAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListAzureClusters</summary>
        public void ListAzureClustersRequestObject()
        {
            // Snippet: ListAzureClusters(ListAzureClustersRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListAzureClustersRequest request = new ListAzureClustersRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListAzureClustersResponse, AzureCluster> response = azureClustersClient.ListAzureClusters(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AzureCluster item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAzureClustersResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureCluster item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureCluster> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureCluster item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            ListAzureClustersRequest request = new ListAzureClustersRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAzureClustersResponse, AzureCluster> response = azureClustersClient.ListAzureClustersAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((AzureCluster item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListAzureClustersResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureCluster item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureCluster> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureCluster item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedEnumerable<ListAzureClustersResponse, AzureCluster> response = azureClustersClient.ListAzureClusters(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AzureCluster item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAzureClustersResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureCluster item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureCluster> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureCluster item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAzureClustersResponse, AzureCluster> response = azureClustersClient.ListAzureClustersAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((AzureCluster item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListAzureClustersResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureCluster item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureCluster> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureCluster item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedEnumerable<ListAzureClustersResponse, AzureCluster> response = azureClustersClient.ListAzureClusters(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AzureCluster item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAzureClustersResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureCluster item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureCluster> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureCluster item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAzureClustersResponse, AzureCluster> response = azureClustersClient.ListAzureClustersAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((AzureCluster item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListAzureClustersResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureCluster item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureCluster> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureCluster item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            DeleteAzureClusterRequest request = new DeleteAzureClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureCluster(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureCluster(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            DeleteAzureClusterRequest request = new DeleteAzureClusterRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureClusterAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureClusterAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureCluster(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureCluster(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureClusterAsync(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureClusterAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureCluster(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureCluster(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureClusterAsync(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureClusterAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GenerateAzureClusterAgentTokenRequest request = new GenerateAzureClusterAgentTokenRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            GenerateAzureClusterAgentTokenResponse response = azureClustersClient.GenerateAzureClusterAgentToken(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GenerateAzureClusterAgentTokenRequest request = new GenerateAzureClusterAgentTokenRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            GenerateAzureClusterAgentTokenResponse response = await azureClustersClient.GenerateAzureClusterAgentTokenAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GenerateAzureAccessToken</summary>
        public void GenerateAzureAccessTokenRequestObject()
        {
            // Snippet: GenerateAzureAccessToken(GenerateAzureAccessTokenRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            GenerateAzureAccessTokenRequest request = new GenerateAzureAccessTokenRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            GenerateAzureAccessTokenResponse response = azureClustersClient.GenerateAzureAccessToken(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GenerateAzureAccessTokenRequest request = new GenerateAzureAccessTokenRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            GenerateAzureAccessTokenResponse response = await azureClustersClient.GenerateAzureAccessTokenAsync(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CreateAzureNodePool</summary>
        public void CreateAzureNodePoolRequestObject()
        {
            // Snippet: CreateAzureNodePool(CreateAzureNodePoolRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            CreateAzureNodePoolRequest request = new CreateAzureNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> response = azureClustersClient.CreateAzureNodePool(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureNodePool(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            CreateAzureNodePoolRequest request = new CreateAzureNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> response = await azureClustersClient.CreateAzureNodePoolAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureNodePoolAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureNodePool azureNodePool = new AzureNodePool();
#pragma warning restore CS0612
            string azureNodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> response = azureClustersClient.CreateAzureNodePool(parent, azureNodePool, azureNodePoolId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureNodePool(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureNodePool azureNodePool = new AzureNodePool();
#pragma warning restore CS0612
            string azureNodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> response = await azureClustersClient.CreateAzureNodePoolAsync(parent, azureNodePool, azureNodePoolId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureNodePoolAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureNodePool azureNodePool = new AzureNodePool();
#pragma warning restore CS0612
            string azureNodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> response = azureClustersClient.CreateAzureNodePool(parent, azureNodePool, azureNodePoolId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceCreateAzureNodePool(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureNodePool azureNodePool = new AzureNodePool();
#pragma warning restore CS0612
            string azureNodePoolId = "";
            // Make the request
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> response = await azureClustersClient.CreateAzureNodePoolAsync(parent, azureNodePool, azureNodePoolId);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceCreateAzureNodePoolAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            UpdateAzureNodePoolRequest request = new UpdateAzureNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> response = azureClustersClient.UpdateAzureNodePool(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceUpdateAzureNodePool(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            UpdateAzureNodePoolRequest request = new UpdateAzureNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> response = await azureClustersClient.UpdateAzureNodePoolAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceUpdateAzureNodePoolAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureNodePool azureNodePool = new AzureNodePool();
#pragma warning restore CS0612
            FieldMask updateMask = new FieldMask();
            // Make the request
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> response = azureClustersClient.UpdateAzureNodePool(azureNodePool, updateMask);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> completedResponse = response.PollUntilCompleted();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceUpdateAzureNodePool(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureNodePool azureNodePool = new AzureNodePool();
#pragma warning restore CS0612
            FieldMask updateMask = new FieldMask();
            // Make the request
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> response = await azureClustersClient.UpdateAzureNodePoolAsync(azureNodePool, updateMask);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
#pragma warning restore CS0612
            // Retrieve the operation result
#pragma warning disable CS0612
            AzureNodePool result = completedResponse.Result;
#pragma warning restore CS0612

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<AzureNodePool, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceUpdateAzureNodePoolAsync(operationName);
#pragma warning restore CS0612
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
#pragma warning disable CS0612
                AzureNodePool retrievedResult = retrievedResponse.Result;
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAzureNodePoolRequest request = new GetAzureNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AzureNodePool response = azureClustersClient.GetAzureNodePool(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAzureNodePoolRequest request = new GetAzureNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AzureNodePool response = await azureClustersClient.GetAzureNodePoolAsync(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureNodePool response = azureClustersClient.GetAzureNodePool(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureNodePool response = await azureClustersClient.GetAzureNodePoolAsync(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureNodePool response = azureClustersClient.GetAzureNodePool(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureNodePool response = await azureClustersClient.GetAzureNodePoolAsync(name);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for ListAzureNodePools</summary>
        public void ListAzureNodePoolsRequestObject()
        {
            // Snippet: ListAzureNodePools(ListAzureNodePoolsRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListAzureNodePoolsRequest request = new ListAzureNodePoolsRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListAzureNodePoolsResponse, AzureNodePool> response = azureClustersClient.ListAzureNodePools(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AzureNodePool item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAzureNodePoolsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureNodePool item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureNodePool> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureNodePool item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            ListAzureNodePoolsRequest request = new ListAzureNodePoolsRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAzureNodePoolsResponse, AzureNodePool> response = azureClustersClient.ListAzureNodePoolsAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((AzureNodePool item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListAzureNodePoolsResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureNodePool item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureNodePool> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureNodePool item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedEnumerable<ListAzureNodePoolsResponse, AzureNodePool> response = azureClustersClient.ListAzureNodePools(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AzureNodePool item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAzureNodePoolsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureNodePool item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureNodePool> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureNodePool item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAzureNodePoolsResponse, AzureNodePool> response = azureClustersClient.ListAzureNodePoolsAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((AzureNodePool item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListAzureNodePoolsResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureNodePool item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureNodePool> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureNodePool item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedEnumerable<ListAzureNodePoolsResponse, AzureNodePool> response = azureClustersClient.ListAzureNodePools(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (AzureNodePool item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListAzureNodePoolsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureNodePool item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureNodePool> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureNodePool item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListAzureNodePoolsResponse, AzureNodePool> response = azureClustersClient.ListAzureNodePoolsAsync(parent);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((AzureNodePool item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListAzureNodePoolsResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (AzureNodePool item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<AzureNodePool> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (AzureNodePool item in singlePage)
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            DeleteAzureNodePoolRequest request = new DeleteAzureNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureNodePool(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureNodePool(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            DeleteAzureNodePoolRequest request = new DeleteAzureNodePoolRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureNodePoolAsync(request);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureNodePoolAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureNodePool(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureNodePool(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureNodePoolAsync(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureNodePoolAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = azureClustersClient.DeleteAzureNodePool(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = azureClustersClient.PollOnceDeleteAzureNodePool(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> response = await azureClustersClient.DeleteAzureNodePoolAsync(name);
#pragma warning restore CS0612

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
#pragma warning disable CS0612
            Operation<Empty, OperationMetadata> retrievedResponse = await azureClustersClient.PollOnceDeleteAzureNodePoolAsync(operationName);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAzureOpenIdConfigRequest request = new GetAzureOpenIdConfigRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AzureOpenIdConfig response = azureClustersClient.GetAzureOpenIdConfig(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAzureOpenIdConfigRequest request = new GetAzureOpenIdConfigRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AzureOpenIdConfig response = await azureClustersClient.GetAzureOpenIdConfigAsync(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureOpenIdConfig response = azureClustersClient.GetAzureOpenIdConfig(azureCluster);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureOpenIdConfig response = await azureClustersClient.GetAzureOpenIdConfigAsync(azureCluster);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureOpenIdConfig response = azureClustersClient.GetAzureOpenIdConfig(azureCluster);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureOpenIdConfig response = await azureClustersClient.GetAzureOpenIdConfigAsync(azureCluster);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetAzureJsonWebKeys</summary>
        public void GetAzureJsonWebKeysRequestObject()
        {
            // Snippet: GetAzureJsonWebKeys(GetAzureJsonWebKeysRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            GetAzureJsonWebKeysRequest request = new GetAzureJsonWebKeysRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AzureJsonWebKeys response = azureClustersClient.GetAzureJsonWebKeys(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAzureJsonWebKeysRequest request = new GetAzureJsonWebKeysRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AzureJsonWebKeys response = await azureClustersClient.GetAzureJsonWebKeysAsync(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureJsonWebKeys response = azureClustersClient.GetAzureJsonWebKeys(azureCluster);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureJsonWebKeys response = await azureClustersClient.GetAzureJsonWebKeysAsync(azureCluster);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureJsonWebKeys response = azureClustersClient.GetAzureJsonWebKeys(azureCluster);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureJsonWebKeys response = await azureClustersClient.GetAzureJsonWebKeysAsync(azureCluster);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for GetAzureServerConfig</summary>
        public void GetAzureServerConfigRequestObject()
        {
            // Snippet: GetAzureServerConfig(GetAzureServerConfigRequest, CallSettings)
            // Create client
            AzureClustersClient azureClustersClient = AzureClustersClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            GetAzureServerConfigRequest request = new GetAzureServerConfigRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AzureServerConfig response = azureClustersClient.GetAzureServerConfig(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            GetAzureServerConfigRequest request = new GetAzureServerConfigRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            AzureServerConfig response = await azureClustersClient.GetAzureServerConfigAsync(request);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureServerConfig response = azureClustersClient.GetAzureServerConfig(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureServerConfig response = await azureClustersClient.GetAzureServerConfigAsync(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureServerConfig response = azureClustersClient.GetAzureServerConfig(name);
#pragma warning restore CS0612
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
#pragma warning disable CS0612
            AzureServerConfig response = await azureClustersClient.GetAzureServerConfigAsync(name);
#pragma warning restore CS0612
            // End snippet
        }
    }
}
