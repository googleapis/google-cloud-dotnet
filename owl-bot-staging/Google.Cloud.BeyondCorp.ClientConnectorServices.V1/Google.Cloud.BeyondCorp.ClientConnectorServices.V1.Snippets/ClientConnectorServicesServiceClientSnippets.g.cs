// Copyright 2023 Google LLC
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
    using Google.Cloud.BeyondCorp.ClientConnectorServices.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedClientConnectorServicesServiceClientSnippets
    {
        /// <summary>Snippet for ListClientConnectorServices</summary>
        public void ListClientConnectorServicesRequestObject()
        {
            // Snippet: ListClientConnectorServices(ListClientConnectorServicesRequest, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            ListClientConnectorServicesRequest request = new ListClientConnectorServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> response = clientConnectorServicesServiceClient.ListClientConnectorServices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ClientConnectorService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClientConnectorServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientConnectorService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientConnectorService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientConnectorService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientConnectorServicesAsync</summary>
        public async Task ListClientConnectorServicesRequestObjectAsync()
        {
            // Snippet: ListClientConnectorServicesAsync(ListClientConnectorServicesRequest, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListClientConnectorServicesRequest request = new ListClientConnectorServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> response = clientConnectorServicesServiceClient.ListClientConnectorServicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ClientConnectorService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClientConnectorServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientConnectorService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientConnectorService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientConnectorService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientConnectorServices</summary>
        public void ListClientConnectorServices()
        {
            // Snippet: ListClientConnectorServices(string, string, int?, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> response = clientConnectorServicesServiceClient.ListClientConnectorServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ClientConnectorService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClientConnectorServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientConnectorService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientConnectorService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientConnectorService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientConnectorServicesAsync</summary>
        public async Task ListClientConnectorServicesAsync()
        {
            // Snippet: ListClientConnectorServicesAsync(string, string, int?, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> response = clientConnectorServicesServiceClient.ListClientConnectorServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ClientConnectorService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClientConnectorServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientConnectorService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientConnectorService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientConnectorService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientConnectorServices</summary>
        public void ListClientConnectorServicesResourceNames()
        {
            // Snippet: ListClientConnectorServices(LocationName, string, int?, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> response = clientConnectorServicesServiceClient.ListClientConnectorServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ClientConnectorService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListClientConnectorServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientConnectorService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientConnectorService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientConnectorService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListClientConnectorServicesAsync</summary>
        public async Task ListClientConnectorServicesResourceNamesAsync()
        {
            // Snippet: ListClientConnectorServicesAsync(LocationName, string, int?, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> response = clientConnectorServicesServiceClient.ListClientConnectorServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ClientConnectorService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListClientConnectorServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ClientConnectorService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ClientConnectorService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ClientConnectorService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetClientConnectorService</summary>
        public void GetClientConnectorServiceRequestObject()
        {
            // Snippet: GetClientConnectorService(GetClientConnectorServiceRequest, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            GetClientConnectorServiceRequest request = new GetClientConnectorServiceRequest
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
            };
            // Make the request
            ClientConnectorService response = clientConnectorServicesServiceClient.GetClientConnectorService(request);
            // End snippet
        }

        /// <summary>Snippet for GetClientConnectorServiceAsync</summary>
        public async Task GetClientConnectorServiceRequestObjectAsync()
        {
            // Snippet: GetClientConnectorServiceAsync(GetClientConnectorServiceRequest, CallSettings)
            // Additional: GetClientConnectorServiceAsync(GetClientConnectorServiceRequest, CancellationToken)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetClientConnectorServiceRequest request = new GetClientConnectorServiceRequest
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
            };
            // Make the request
            ClientConnectorService response = await clientConnectorServicesServiceClient.GetClientConnectorServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetClientConnectorService</summary>
        public void GetClientConnectorService()
        {
            // Snippet: GetClientConnectorService(string, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientConnectorServices/[CLIENT_CONNECTOR_SERVICE]";
            // Make the request
            ClientConnectorService response = clientConnectorServicesServiceClient.GetClientConnectorService(name);
            // End snippet
        }

        /// <summary>Snippet for GetClientConnectorServiceAsync</summary>
        public async Task GetClientConnectorServiceAsync()
        {
            // Snippet: GetClientConnectorServiceAsync(string, CallSettings)
            // Additional: GetClientConnectorServiceAsync(string, CancellationToken)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientConnectorServices/[CLIENT_CONNECTOR_SERVICE]";
            // Make the request
            ClientConnectorService response = await clientConnectorServicesServiceClient.GetClientConnectorServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetClientConnectorService</summary>
        public void GetClientConnectorServiceResourceNames()
        {
            // Snippet: GetClientConnectorService(ClientConnectorServiceName, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            ClientConnectorServiceName name = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]");
            // Make the request
            ClientConnectorService response = clientConnectorServicesServiceClient.GetClientConnectorService(name);
            // End snippet
        }

        /// <summary>Snippet for GetClientConnectorServiceAsync</summary>
        public async Task GetClientConnectorServiceResourceNamesAsync()
        {
            // Snippet: GetClientConnectorServiceAsync(ClientConnectorServiceName, CallSettings)
            // Additional: GetClientConnectorServiceAsync(ClientConnectorServiceName, CancellationToken)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClientConnectorServiceName name = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]");
            // Make the request
            ClientConnectorService response = await clientConnectorServicesServiceClient.GetClientConnectorServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateClientConnectorService</summary>
        public void CreateClientConnectorServiceRequestObject()
        {
            // Snippet: CreateClientConnectorService(CreateClientConnectorServiceRequest, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            CreateClientConnectorServiceRequest request = new CreateClientConnectorServiceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClientConnectorServiceId = "",
                ClientConnectorService = new ClientConnectorService(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> response = clientConnectorServicesServiceClient.CreateClientConnectorService(request);

            // Poll until the returned long-running operation is complete
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientConnectorService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> retrievedResponse = clientConnectorServicesServiceClient.PollOnceCreateClientConnectorService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientConnectorService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientConnectorServiceAsync</summary>
        public async Task CreateClientConnectorServiceRequestObjectAsync()
        {
            // Snippet: CreateClientConnectorServiceAsync(CreateClientConnectorServiceRequest, CallSettings)
            // Additional: CreateClientConnectorServiceAsync(CreateClientConnectorServiceRequest, CancellationToken)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateClientConnectorServiceRequest request = new CreateClientConnectorServiceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClientConnectorServiceId = "",
                ClientConnectorService = new ClientConnectorService(),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> response = await clientConnectorServicesServiceClient.CreateClientConnectorServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientConnectorService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> retrievedResponse = await clientConnectorServicesServiceClient.PollOnceCreateClientConnectorServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientConnectorService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientConnectorService</summary>
        public void CreateClientConnectorService()
        {
            // Snippet: CreateClientConnectorService(string, ClientConnectorService, string, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ClientConnectorService clientConnectorService = new ClientConnectorService();
            string clientConnectorServiceId = "";
            // Make the request
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> response = clientConnectorServicesServiceClient.CreateClientConnectorService(parent, clientConnectorService, clientConnectorServiceId);

            // Poll until the returned long-running operation is complete
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientConnectorService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> retrievedResponse = clientConnectorServicesServiceClient.PollOnceCreateClientConnectorService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientConnectorService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientConnectorServiceAsync</summary>
        public async Task CreateClientConnectorServiceAsync()
        {
            // Snippet: CreateClientConnectorServiceAsync(string, ClientConnectorService, string, CallSettings)
            // Additional: CreateClientConnectorServiceAsync(string, ClientConnectorService, string, CancellationToken)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ClientConnectorService clientConnectorService = new ClientConnectorService();
            string clientConnectorServiceId = "";
            // Make the request
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> response = await clientConnectorServicesServiceClient.CreateClientConnectorServiceAsync(parent, clientConnectorService, clientConnectorServiceId);

            // Poll until the returned long-running operation is complete
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientConnectorService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> retrievedResponse = await clientConnectorServicesServiceClient.PollOnceCreateClientConnectorServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientConnectorService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientConnectorService</summary>
        public void CreateClientConnectorServiceResourceNames()
        {
            // Snippet: CreateClientConnectorService(LocationName, ClientConnectorService, string, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ClientConnectorService clientConnectorService = new ClientConnectorService();
            string clientConnectorServiceId = "";
            // Make the request
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> response = clientConnectorServicesServiceClient.CreateClientConnectorService(parent, clientConnectorService, clientConnectorServiceId);

            // Poll until the returned long-running operation is complete
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientConnectorService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> retrievedResponse = clientConnectorServicesServiceClient.PollOnceCreateClientConnectorService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientConnectorService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateClientConnectorServiceAsync</summary>
        public async Task CreateClientConnectorServiceResourceNamesAsync()
        {
            // Snippet: CreateClientConnectorServiceAsync(LocationName, ClientConnectorService, string, CallSettings)
            // Additional: CreateClientConnectorServiceAsync(LocationName, ClientConnectorService, string, CancellationToken)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ClientConnectorService clientConnectorService = new ClientConnectorService();
            string clientConnectorServiceId = "";
            // Make the request
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> response = await clientConnectorServicesServiceClient.CreateClientConnectorServiceAsync(parent, clientConnectorService, clientConnectorServiceId);

            // Poll until the returned long-running operation is complete
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientConnectorService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> retrievedResponse = await clientConnectorServicesServiceClient.PollOnceCreateClientConnectorServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientConnectorService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClientConnectorService</summary>
        public void UpdateClientConnectorServiceRequestObject()
        {
            // Snippet: UpdateClientConnectorService(UpdateClientConnectorServiceRequest, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            UpdateClientConnectorServiceRequest request = new UpdateClientConnectorServiceRequest
            {
                UpdateMask = new FieldMask(),
                ClientConnectorService = new ClientConnectorService(),
                RequestId = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> response = clientConnectorServicesServiceClient.UpdateClientConnectorService(request);

            // Poll until the returned long-running operation is complete
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientConnectorService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> retrievedResponse = clientConnectorServicesServiceClient.PollOnceUpdateClientConnectorService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientConnectorService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClientConnectorServiceAsync</summary>
        public async Task UpdateClientConnectorServiceRequestObjectAsync()
        {
            // Snippet: UpdateClientConnectorServiceAsync(UpdateClientConnectorServiceRequest, CallSettings)
            // Additional: UpdateClientConnectorServiceAsync(UpdateClientConnectorServiceRequest, CancellationToken)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateClientConnectorServiceRequest request = new UpdateClientConnectorServiceRequest
            {
                UpdateMask = new FieldMask(),
                ClientConnectorService = new ClientConnectorService(),
                RequestId = "",
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> response = await clientConnectorServicesServiceClient.UpdateClientConnectorServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientConnectorService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> retrievedResponse = await clientConnectorServicesServiceClient.PollOnceUpdateClientConnectorServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientConnectorService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClientConnectorService</summary>
        public void UpdateClientConnectorService()
        {
            // Snippet: UpdateClientConnectorService(ClientConnectorService, FieldMask, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            ClientConnectorService clientConnectorService = new ClientConnectorService();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> response = clientConnectorServicesServiceClient.UpdateClientConnectorService(clientConnectorService, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ClientConnectorService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> retrievedResponse = clientConnectorServicesServiceClient.PollOnceUpdateClientConnectorService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientConnectorService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateClientConnectorServiceAsync</summary>
        public async Task UpdateClientConnectorServiceAsync()
        {
            // Snippet: UpdateClientConnectorServiceAsync(ClientConnectorService, FieldMask, CallSettings)
            // Additional: UpdateClientConnectorServiceAsync(ClientConnectorService, FieldMask, CancellationToken)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClientConnectorService clientConnectorService = new ClientConnectorService();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> response = await clientConnectorServicesServiceClient.UpdateClientConnectorServiceAsync(clientConnectorService, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientConnectorService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> retrievedResponse = await clientConnectorServicesServiceClient.PollOnceUpdateClientConnectorServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientConnectorService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientConnectorService</summary>
        public void DeleteClientConnectorServiceRequestObject()
        {
            // Snippet: DeleteClientConnectorService(DeleteClientConnectorServiceRequest, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            DeleteClientConnectorServiceRequest request = new DeleteClientConnectorServiceRequest
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, ClientConnectorServiceOperationMetadata> response = clientConnectorServicesServiceClient.DeleteClientConnectorService(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClientConnectorServiceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClientConnectorServiceOperationMetadata> retrievedResponse = clientConnectorServicesServiceClient.PollOnceDeleteClientConnectorService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientConnectorServiceAsync</summary>
        public async Task DeleteClientConnectorServiceRequestObjectAsync()
        {
            // Snippet: DeleteClientConnectorServiceAsync(DeleteClientConnectorServiceRequest, CallSettings)
            // Additional: DeleteClientConnectorServiceAsync(DeleteClientConnectorServiceRequest, CancellationToken)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteClientConnectorServiceRequest request = new DeleteClientConnectorServiceRequest
            {
                ClientConnectorServiceName = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]"),
                RequestId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<Empty, ClientConnectorServiceOperationMetadata> response = await clientConnectorServicesServiceClient.DeleteClientConnectorServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClientConnectorServiceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClientConnectorServiceOperationMetadata> retrievedResponse = await clientConnectorServicesServiceClient.PollOnceDeleteClientConnectorServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientConnectorService</summary>
        public void DeleteClientConnectorService()
        {
            // Snippet: DeleteClientConnectorService(string, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientConnectorServices/[CLIENT_CONNECTOR_SERVICE]";
            // Make the request
            Operation<Empty, ClientConnectorServiceOperationMetadata> response = clientConnectorServicesServiceClient.DeleteClientConnectorService(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClientConnectorServiceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClientConnectorServiceOperationMetadata> retrievedResponse = clientConnectorServicesServiceClient.PollOnceDeleteClientConnectorService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientConnectorServiceAsync</summary>
        public async Task DeleteClientConnectorServiceAsync()
        {
            // Snippet: DeleteClientConnectorServiceAsync(string, CallSettings)
            // Additional: DeleteClientConnectorServiceAsync(string, CancellationToken)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/clientConnectorServices/[CLIENT_CONNECTOR_SERVICE]";
            // Make the request
            Operation<Empty, ClientConnectorServiceOperationMetadata> response = await clientConnectorServicesServiceClient.DeleteClientConnectorServiceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClientConnectorServiceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClientConnectorServiceOperationMetadata> retrievedResponse = await clientConnectorServicesServiceClient.PollOnceDeleteClientConnectorServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientConnectorService</summary>
        public void DeleteClientConnectorServiceResourceNames()
        {
            // Snippet: DeleteClientConnectorService(ClientConnectorServiceName, CallSettings)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = ClientConnectorServicesServiceClient.Create();
            // Initialize request argument(s)
            ClientConnectorServiceName name = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]");
            // Make the request
            Operation<Empty, ClientConnectorServiceOperationMetadata> response = clientConnectorServicesServiceClient.DeleteClientConnectorService(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClientConnectorServiceOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClientConnectorServiceOperationMetadata> retrievedResponse = clientConnectorServicesServiceClient.PollOnceDeleteClientConnectorService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteClientConnectorServiceAsync</summary>
        public async Task DeleteClientConnectorServiceResourceNamesAsync()
        {
            // Snippet: DeleteClientConnectorServiceAsync(ClientConnectorServiceName, CallSettings)
            // Additional: DeleteClientConnectorServiceAsync(ClientConnectorServiceName, CancellationToken)
            // Create client
            ClientConnectorServicesServiceClient clientConnectorServicesServiceClient = await ClientConnectorServicesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ClientConnectorServiceName name = ClientConnectorServiceName.FromProjectLocationClientConnectorService("[PROJECT]", "[LOCATION]", "[CLIENT_CONNECTOR_SERVICE]");
            // Make the request
            Operation<Empty, ClientConnectorServiceOperationMetadata> response = await clientConnectorServicesServiceClient.DeleteClientConnectorServiceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ClientConnectorServiceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ClientConnectorServiceOperationMetadata> retrievedResponse = await clientConnectorServicesServiceClient.PollOnceDeleteClientConnectorServiceAsync(operationName);
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
