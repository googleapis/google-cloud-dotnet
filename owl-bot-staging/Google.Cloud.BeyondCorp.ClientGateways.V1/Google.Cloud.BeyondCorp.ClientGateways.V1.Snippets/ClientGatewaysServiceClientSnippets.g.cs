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
    using Google.Cloud.BeyondCorp.ClientGateways.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedClientGatewaysServiceClientSnippets
    {
        /// <summary>Snippet for ListClientGateways</summary>
        public void ListClientGatewaysRequestObject()
        {
            // Snippet: ListClientGateways(ListClientGatewaysRequest, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            ListClientGatewaysRequest request = new ListClientGatewaysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListClientGatewaysResponse, ClientGateway> response = clientGatewaysServiceClient.ListClientGateways(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ClientGateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClientGatewaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientGateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientGatewaysAsync</summary>
        public async Task ListClientGatewaysRequestObjectAsync()
        {
            // Snippet: ListClientGatewaysAsync(ListClientGatewaysRequest, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = await ClientGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListClientGatewaysRequest request = new ListClientGatewaysRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListClientGatewaysResponse, ClientGateway> response = clientGatewaysServiceClient.ListClientGatewaysAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ClientGateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClientGatewaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientGateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientGateways</summary>
        public void ListClientGateways()
        {
            // Snippet: ListClientGateways(string, string, int?, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListClientGatewaysResponse, ClientGateway> response = clientGatewaysServiceClient.ListClientGateways(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ClientGateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClientGatewaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientGateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientGatewaysAsync</summary>
        public async Task ListClientGatewaysAsync()
        {
            // Snippet: ListClientGatewaysAsync(string, string, int?, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = await ClientGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListClientGatewaysResponse, ClientGateway> response = clientGatewaysServiceClient.ListClientGatewaysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ClientGateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClientGatewaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientGateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientGateways</summary>
        public void ListClientGatewaysResourceNames()
        {
            // Snippet: ListClientGateways(LocationName, string, int?, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListClientGatewaysResponse, ClientGateway> response = clientGatewaysServiceClient.ListClientGateways(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ClientGateway item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClientGatewaysResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientGateway> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientGatewaysAsync</summary>
        public async Task ListClientGatewaysResourceNamesAsync()
        {
            // Snippet: ListClientGatewaysAsync(LocationName, string, int?, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = await ClientGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListClientGatewaysResponse, ClientGateway> response = clientGatewaysServiceClient.ListClientGatewaysAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ClientGateway item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClientGatewaysResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientGateway item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientGateway> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientGateway item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetClientGateway</summary>
        public void GetClientGatewayRequestObject()
        {
            // Snippet: GetClientGateway(GetClientGatewayRequest, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            GetClientGatewayRequest request = new GetClientGatewayRequest
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
            };
            // Make the request
            ClientGateway response = clientGatewaysServiceClient.GetClientGateway(request);
            // End snippet
        }

        /// <summary>Snippet for GetClientGatewayAsync</summary>
        public async Task GetClientGatewayRequestObjectAsync()
        {
            // Snippet: GetClientGatewayAsync(GetClientGatewayRequest, CallSettings)
            // Additional: GetClientGatewayAsync(GetClientGatewayRequest, CancellationToken)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = await ClientGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetClientGatewayRequest request = new GetClientGatewayRequest
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
            };
            // Make the request
            ClientGateway response = await clientGatewaysServiceClient.GetClientGatewayAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetClientGateway</summary>
        public void GetClientGateway()
        {
            // Snippet: GetClientGateway(string, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientGateways/[CLIENT_GATEWAY]";
            // Make the request
            ClientGateway response = clientGatewaysServiceClient.GetClientGateway(name);
            // End snippet
        }

        /// <summary>Snippet for GetClientGatewayAsync</summary>
        public async Task GetClientGatewayAsync()
        {
            // Snippet: GetClientGatewayAsync(string, CallSettings)
            // Additional: GetClientGatewayAsync(string, CancellationToken)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = await ClientGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientGateways/[CLIENT_GATEWAY]";
            // Make the request
            ClientGateway response = await clientGatewaysServiceClient.GetClientGatewayAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetClientGateway</summary>
        public void GetClientGatewayResourceNames()
        {
            // Snippet: GetClientGateway(ClientGatewayName, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            ClientGatewayName name = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]");
            // Make the request
            ClientGateway response = clientGatewaysServiceClient.GetClientGateway(name);
            // End snippet
        }

        /// <summary>Snippet for GetClientGatewayAsync</summary>
        public async Task GetClientGatewayResourceNamesAsync()
        {
            // Snippet: GetClientGatewayAsync(ClientGatewayName, CallSettings)
            // Additional: GetClientGatewayAsync(ClientGatewayName, CancellationToken)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = await ClientGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClientGatewayName name = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]");
            // Make the request
            ClientGateway response = await clientGatewaysServiceClient.GetClientGatewayAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateClientGateway</summary>
        public void CreateClientGatewayRequestObject()
        {
            // Snippet: CreateClientGateway(CreateClientGatewayRequest, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            CreateClientGatewayRequest request = new CreateClientGatewayRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClientGatewayId = "",
                ClientGateway = new ClientGateway(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<ClientGateway, ClientGatewayOperationMetadata> response = clientGatewaysServiceClient.CreateClientGateway(request);

            // Poll until the returned long-running operation is complete
            Operation<ClientGateway, ClientGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientGateway, ClientGatewayOperationMetadata> retrievedResponse = clientGatewaysServiceClient.PollOnceCreateClientGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientGateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientGatewayAsync</summary>
        public async Task CreateClientGatewayRequestObjectAsync()
        {
            // Snippet: CreateClientGatewayAsync(CreateClientGatewayRequest, CallSettings)
            // Additional: CreateClientGatewayAsync(CreateClientGatewayRequest, CancellationToken)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = await ClientGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateClientGatewayRequest request = new CreateClientGatewayRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClientGatewayId = "",
                ClientGateway = new ClientGateway(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<ClientGateway, ClientGatewayOperationMetadata> response = await clientGatewaysServiceClient.CreateClientGatewayAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ClientGateway, ClientGatewayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientGateway, ClientGatewayOperationMetadata> retrievedResponse = await clientGatewaysServiceClient.PollOnceCreateClientGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientGateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientGateway</summary>
        public void CreateClientGateway()
        {
            // Snippet: CreateClientGateway(string, ClientGateway, string, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ClientGateway clientGateway = new ClientGateway();
            string clientGatewayId = "";
            // Make the request
            Operation<ClientGateway, ClientGatewayOperationMetadata> response = clientGatewaysServiceClient.CreateClientGateway(parent, clientGateway, clientGatewayId);

            // Poll until the returned long-running operation is complete
            Operation<ClientGateway, ClientGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientGateway, ClientGatewayOperationMetadata> retrievedResponse = clientGatewaysServiceClient.PollOnceCreateClientGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientGateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientGatewayAsync</summary>
        public async Task CreateClientGatewayAsync()
        {
            // Snippet: CreateClientGatewayAsync(string, ClientGateway, string, CallSettings)
            // Additional: CreateClientGatewayAsync(string, ClientGateway, string, CancellationToken)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = await ClientGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ClientGateway clientGateway = new ClientGateway();
            string clientGatewayId = "";
            // Make the request
            Operation<ClientGateway, ClientGatewayOperationMetadata> response = await clientGatewaysServiceClient.CreateClientGatewayAsync(parent, clientGateway, clientGatewayId);

            // Poll until the returned long-running operation is complete
            Operation<ClientGateway, ClientGatewayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientGateway, ClientGatewayOperationMetadata> retrievedResponse = await clientGatewaysServiceClient.PollOnceCreateClientGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientGateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientGateway</summary>
        public void CreateClientGatewayResourceNames()
        {
            // Snippet: CreateClientGateway(LocationName, ClientGateway, string, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ClientGateway clientGateway = new ClientGateway();
            string clientGatewayId = "";
            // Make the request
            Operation<ClientGateway, ClientGatewayOperationMetadata> response = clientGatewaysServiceClient.CreateClientGateway(parent, clientGateway, clientGatewayId);

            // Poll until the returned long-running operation is complete
            Operation<ClientGateway, ClientGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientGateway, ClientGatewayOperationMetadata> retrievedResponse = clientGatewaysServiceClient.PollOnceCreateClientGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientGateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientGatewayAsync</summary>
        public async Task CreateClientGatewayResourceNamesAsync()
        {
            // Snippet: CreateClientGatewayAsync(LocationName, ClientGateway, string, CallSettings)
            // Additional: CreateClientGatewayAsync(LocationName, ClientGateway, string, CancellationToken)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = await ClientGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ClientGateway clientGateway = new ClientGateway();
            string clientGatewayId = "";
            // Make the request
            Operation<ClientGateway, ClientGatewayOperationMetadata> response = await clientGatewaysServiceClient.CreateClientGatewayAsync(parent, clientGateway, clientGatewayId);

            // Poll until the returned long-running operation is complete
            Operation<ClientGateway, ClientGatewayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientGateway result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientGateway, ClientGatewayOperationMetadata> retrievedResponse = await clientGatewaysServiceClient.PollOnceCreateClientGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientGateway retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientGateway</summary>
        public void DeleteClientGatewayRequestObject()
        {
            // Snippet: DeleteClientGateway(DeleteClientGatewayRequest, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            DeleteClientGatewayRequest request = new DeleteClientGatewayRequest
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, ClientGatewayOperationMetadata> response = clientGatewaysServiceClient.DeleteClientGateway(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClientGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClientGatewayOperationMetadata> retrievedResponse = clientGatewaysServiceClient.PollOnceDeleteClientGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientGatewayAsync</summary>
        public async Task DeleteClientGatewayRequestObjectAsync()
        {
            // Snippet: DeleteClientGatewayAsync(DeleteClientGatewayRequest, CallSettings)
            // Additional: DeleteClientGatewayAsync(DeleteClientGatewayRequest, CancellationToken)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = await ClientGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClientGatewayRequest request = new DeleteClientGatewayRequest
            {
                ClientGatewayName = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, ClientGatewayOperationMetadata> response = await clientGatewaysServiceClient.DeleteClientGatewayAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClientGatewayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClientGatewayOperationMetadata> retrievedResponse = await clientGatewaysServiceClient.PollOnceDeleteClientGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientGateway</summary>
        public void DeleteClientGateway()
        {
            // Snippet: DeleteClientGateway(string, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientGateways/[CLIENT_GATEWAY]";
            // Make the request
            Operation<Empty, ClientGatewayOperationMetadata> response = clientGatewaysServiceClient.DeleteClientGateway(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClientGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClientGatewayOperationMetadata> retrievedResponse = clientGatewaysServiceClient.PollOnceDeleteClientGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientGatewayAsync</summary>
        public async Task DeleteClientGatewayAsync()
        {
            // Snippet: DeleteClientGatewayAsync(string, CallSettings)
            // Additional: DeleteClientGatewayAsync(string, CancellationToken)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = await ClientGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientGateways/[CLIENT_GATEWAY]";
            // Make the request
            Operation<Empty, ClientGatewayOperationMetadata> response = await clientGatewaysServiceClient.DeleteClientGatewayAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClientGatewayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClientGatewayOperationMetadata> retrievedResponse = await clientGatewaysServiceClient.PollOnceDeleteClientGatewayAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientGateway</summary>
        public void DeleteClientGatewayResourceNames()
        {
            // Snippet: DeleteClientGateway(ClientGatewayName, CallSettings)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = ClientGatewaysServiceClient.Create();
            // Initialize request argument(s)
            ClientGatewayName name = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]");
            // Make the request
            Operation<Empty, ClientGatewayOperationMetadata> response = clientGatewaysServiceClient.DeleteClientGateway(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClientGatewayOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClientGatewayOperationMetadata> retrievedResponse = clientGatewaysServiceClient.PollOnceDeleteClientGateway(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientGatewayAsync</summary>
        public async Task DeleteClientGatewayResourceNamesAsync()
        {
            // Snippet: DeleteClientGatewayAsync(ClientGatewayName, CallSettings)
            // Additional: DeleteClientGatewayAsync(ClientGatewayName, CancellationToken)
            // Create client
            ClientGatewaysServiceClient clientGatewaysServiceClient = await ClientGatewaysServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClientGatewayName name = ClientGatewayName.FromProjectLocationClientGateway("[PROJECT]", "[LOCATION]", "[CLIENT_GATEWAY]");
            // Make the request
            Operation<Empty, ClientGatewayOperationMetadata> response = await clientGatewaysServiceClient.DeleteClientGatewayAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClientGatewayOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClientGatewayOperationMetadata> retrievedResponse = await clientGatewaysServiceClient.PollOnceDeleteClientGatewayAsync(operationName);
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
