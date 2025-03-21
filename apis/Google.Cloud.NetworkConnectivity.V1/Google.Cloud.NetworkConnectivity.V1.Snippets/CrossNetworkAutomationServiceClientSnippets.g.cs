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
    using Google.Cloud.NetworkConnectivity.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCrossNetworkAutomationServiceClientSnippets
    {
        /// <summary>Snippet for ListServiceConnectionMaps</summary>
        public void ListServiceConnectionMapsRequestObject()
        {
            // Snippet: ListServiceConnectionMaps(ListServiceConnectionMapsRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ListServiceConnectionMapsRequest request = new ListServiceConnectionMapsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> response = crossNetworkAutomationServiceClient.ListServiceConnectionMaps(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceConnectionMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceConnectionMapsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionMapsAsync</summary>
        public async Task ListServiceConnectionMapsRequestObjectAsync()
        {
            // Snippet: ListServiceConnectionMapsAsync(ListServiceConnectionMapsRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceConnectionMapsRequest request = new ListServiceConnectionMapsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> response = crossNetworkAutomationServiceClient.ListServiceConnectionMapsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceConnectionMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceConnectionMapsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionMaps</summary>
        public void ListServiceConnectionMaps()
        {
            // Snippet: ListServiceConnectionMaps(string, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> response = crossNetworkAutomationServiceClient.ListServiceConnectionMaps(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceConnectionMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceConnectionMapsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionMapsAsync</summary>
        public async Task ListServiceConnectionMapsAsync()
        {
            // Snippet: ListServiceConnectionMapsAsync(string, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> response = crossNetworkAutomationServiceClient.ListServiceConnectionMapsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceConnectionMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceConnectionMapsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionMaps</summary>
        public void ListServiceConnectionMapsResourceNames()
        {
            // Snippet: ListServiceConnectionMaps(LocationName, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> response = crossNetworkAutomationServiceClient.ListServiceConnectionMaps(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceConnectionMap item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceConnectionMapsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionMap> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionMapsAsync</summary>
        public async Task ListServiceConnectionMapsResourceNamesAsync()
        {
            // Snippet: ListServiceConnectionMapsAsync(LocationName, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListServiceConnectionMapsResponse, ServiceConnectionMap> response = crossNetworkAutomationServiceClient.ListServiceConnectionMapsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceConnectionMap item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceConnectionMapsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionMap item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionMap> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionMap item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionMap</summary>
        public void GetServiceConnectionMapRequestObject()
        {
            // Snippet: GetServiceConnectionMap(GetServiceConnectionMapRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            GetServiceConnectionMapRequest request = new GetServiceConnectionMapRequest
            {
                ServiceConnectionMapName = ServiceConnectionMapName.FromProjectLocationServiceConnectionMap("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_MAP]"),
            };
            // Make the request
            ServiceConnectionMap response = crossNetworkAutomationServiceClient.GetServiceConnectionMap(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionMapAsync</summary>
        public async Task GetServiceConnectionMapRequestObjectAsync()
        {
            // Snippet: GetServiceConnectionMapAsync(GetServiceConnectionMapRequest, CallSettings)
            // Additional: GetServiceConnectionMapAsync(GetServiceConnectionMapRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceConnectionMapRequest request = new GetServiceConnectionMapRequest
            {
                ServiceConnectionMapName = ServiceConnectionMapName.FromProjectLocationServiceConnectionMap("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_MAP]"),
            };
            // Make the request
            ServiceConnectionMap response = await crossNetworkAutomationServiceClient.GetServiceConnectionMapAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionMap</summary>
        public void GetServiceConnectionMap()
        {
            // Snippet: GetServiceConnectionMap(string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceConnectionMaps/[SERVICE_CONNECTION_MAP]";
            // Make the request
            ServiceConnectionMap response = crossNetworkAutomationServiceClient.GetServiceConnectionMap(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionMapAsync</summary>
        public async Task GetServiceConnectionMapAsync()
        {
            // Snippet: GetServiceConnectionMapAsync(string, CallSettings)
            // Additional: GetServiceConnectionMapAsync(string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceConnectionMaps/[SERVICE_CONNECTION_MAP]";
            // Make the request
            ServiceConnectionMap response = await crossNetworkAutomationServiceClient.GetServiceConnectionMapAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionMap</summary>
        public void GetServiceConnectionMapResourceNames()
        {
            // Snippet: GetServiceConnectionMap(ServiceConnectionMapName, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ServiceConnectionMapName name = ServiceConnectionMapName.FromProjectLocationServiceConnectionMap("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_MAP]");
            // Make the request
            ServiceConnectionMap response = crossNetworkAutomationServiceClient.GetServiceConnectionMap(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionMapAsync</summary>
        public async Task GetServiceConnectionMapResourceNamesAsync()
        {
            // Snippet: GetServiceConnectionMapAsync(ServiceConnectionMapName, CallSettings)
            // Additional: GetServiceConnectionMapAsync(ServiceConnectionMapName, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceConnectionMapName name = ServiceConnectionMapName.FromProjectLocationServiceConnectionMap("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_MAP]");
            // Make the request
            ServiceConnectionMap response = await crossNetworkAutomationServiceClient.GetServiceConnectionMapAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionMap</summary>
        public void CreateServiceConnectionMapRequestObject()
        {
            // Snippet: CreateServiceConnectionMap(CreateServiceConnectionMapRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            CreateServiceConnectionMapRequest request = new CreateServiceConnectionMapRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceConnectionMapId = "",
                ServiceConnectionMap = new ServiceConnectionMap(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceConnectionMap, OperationMetadata> response = crossNetworkAutomationServiceClient.CreateServiceConnectionMap(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionMap, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionMap, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionMapAsync</summary>
        public async Task CreateServiceConnectionMapRequestObjectAsync()
        {
            // Snippet: CreateServiceConnectionMapAsync(CreateServiceConnectionMapRequest, CallSettings)
            // Additional: CreateServiceConnectionMapAsync(CreateServiceConnectionMapRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceConnectionMapRequest request = new CreateServiceConnectionMapRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceConnectionMapId = "",
                ServiceConnectionMap = new ServiceConnectionMap(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceConnectionMap, OperationMetadata> response = await crossNetworkAutomationServiceClient.CreateServiceConnectionMapAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionMap, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionMap, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionMap</summary>
        public void CreateServiceConnectionMap()
        {
            // Snippet: CreateServiceConnectionMap(string, ServiceConnectionMap, string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServiceConnectionMap serviceConnectionMap = new ServiceConnectionMap();
            string serviceConnectionMapId = "";
            // Make the request
            Operation<ServiceConnectionMap, OperationMetadata> response = crossNetworkAutomationServiceClient.CreateServiceConnectionMap(parent, serviceConnectionMap, serviceConnectionMapId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionMap, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionMap, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionMapAsync</summary>
        public async Task CreateServiceConnectionMapAsync()
        {
            // Snippet: CreateServiceConnectionMapAsync(string, ServiceConnectionMap, string, CallSettings)
            // Additional: CreateServiceConnectionMapAsync(string, ServiceConnectionMap, string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServiceConnectionMap serviceConnectionMap = new ServiceConnectionMap();
            string serviceConnectionMapId = "";
            // Make the request
            Operation<ServiceConnectionMap, OperationMetadata> response = await crossNetworkAutomationServiceClient.CreateServiceConnectionMapAsync(parent, serviceConnectionMap, serviceConnectionMapId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionMap, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionMap, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionMap</summary>
        public void CreateServiceConnectionMapResourceNames()
        {
            // Snippet: CreateServiceConnectionMap(LocationName, ServiceConnectionMap, string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServiceConnectionMap serviceConnectionMap = new ServiceConnectionMap();
            string serviceConnectionMapId = "";
            // Make the request
            Operation<ServiceConnectionMap, OperationMetadata> response = crossNetworkAutomationServiceClient.CreateServiceConnectionMap(parent, serviceConnectionMap, serviceConnectionMapId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionMap, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionMap, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionMapAsync</summary>
        public async Task CreateServiceConnectionMapResourceNamesAsync()
        {
            // Snippet: CreateServiceConnectionMapAsync(LocationName, ServiceConnectionMap, string, CallSettings)
            // Additional: CreateServiceConnectionMapAsync(LocationName, ServiceConnectionMap, string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServiceConnectionMap serviceConnectionMap = new ServiceConnectionMap();
            string serviceConnectionMapId = "";
            // Make the request
            Operation<ServiceConnectionMap, OperationMetadata> response = await crossNetworkAutomationServiceClient.CreateServiceConnectionMapAsync(parent, serviceConnectionMap, serviceConnectionMapId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionMap, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionMap, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceConnectionMap</summary>
        public void UpdateServiceConnectionMapRequestObject()
        {
            // Snippet: UpdateServiceConnectionMap(UpdateServiceConnectionMapRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            UpdateServiceConnectionMapRequest request = new UpdateServiceConnectionMapRequest
            {
                UpdateMask = new FieldMask(),
                ServiceConnectionMap = new ServiceConnectionMap(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceConnectionMap, OperationMetadata> response = crossNetworkAutomationServiceClient.UpdateServiceConnectionMap(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionMap, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionMap, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceUpdateServiceConnectionMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceConnectionMapAsync</summary>
        public async Task UpdateServiceConnectionMapRequestObjectAsync()
        {
            // Snippet: UpdateServiceConnectionMapAsync(UpdateServiceConnectionMapRequest, CallSettings)
            // Additional: UpdateServiceConnectionMapAsync(UpdateServiceConnectionMapRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServiceConnectionMapRequest request = new UpdateServiceConnectionMapRequest
            {
                UpdateMask = new FieldMask(),
                ServiceConnectionMap = new ServiceConnectionMap(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceConnectionMap, OperationMetadata> response = await crossNetworkAutomationServiceClient.UpdateServiceConnectionMapAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionMap, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionMap, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceUpdateServiceConnectionMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceConnectionMap</summary>
        public void UpdateServiceConnectionMap()
        {
            // Snippet: UpdateServiceConnectionMap(ServiceConnectionMap, FieldMask, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ServiceConnectionMap serviceConnectionMap = new ServiceConnectionMap();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServiceConnectionMap, OperationMetadata> response = crossNetworkAutomationServiceClient.UpdateServiceConnectionMap(serviceConnectionMap, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionMap, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionMap, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceUpdateServiceConnectionMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceConnectionMapAsync</summary>
        public async Task UpdateServiceConnectionMapAsync()
        {
            // Snippet: UpdateServiceConnectionMapAsync(ServiceConnectionMap, FieldMask, CallSettings)
            // Additional: UpdateServiceConnectionMapAsync(ServiceConnectionMap, FieldMask, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceConnectionMap serviceConnectionMap = new ServiceConnectionMap();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServiceConnectionMap, OperationMetadata> response = await crossNetworkAutomationServiceClient.UpdateServiceConnectionMapAsync(serviceConnectionMap, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionMap, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionMap result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionMap, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceUpdateServiceConnectionMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionMap retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionMap</summary>
        public void DeleteServiceConnectionMapRequestObject()
        {
            // Snippet: DeleteServiceConnectionMap(DeleteServiceConnectionMapRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            DeleteServiceConnectionMapRequest request = new DeleteServiceConnectionMapRequest
            {
                ServiceConnectionMapName = ServiceConnectionMapName.FromProjectLocationServiceConnectionMap("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_MAP]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = crossNetworkAutomationServiceClient.DeleteServiceConnectionMap(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionMapAsync</summary>
        public async Task DeleteServiceConnectionMapRequestObjectAsync()
        {
            // Snippet: DeleteServiceConnectionMapAsync(DeleteServiceConnectionMapRequest, CallSettings)
            // Additional: DeleteServiceConnectionMapAsync(DeleteServiceConnectionMapRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceConnectionMapRequest request = new DeleteServiceConnectionMapRequest
            {
                ServiceConnectionMapName = ServiceConnectionMapName.FromProjectLocationServiceConnectionMap("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_MAP]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await crossNetworkAutomationServiceClient.DeleteServiceConnectionMapAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionMap</summary>
        public void DeleteServiceConnectionMap()
        {
            // Snippet: DeleteServiceConnectionMap(string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceConnectionMaps/[SERVICE_CONNECTION_MAP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = crossNetworkAutomationServiceClient.DeleteServiceConnectionMap(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionMapAsync</summary>
        public async Task DeleteServiceConnectionMapAsync()
        {
            // Snippet: DeleteServiceConnectionMapAsync(string, CallSettings)
            // Additional: DeleteServiceConnectionMapAsync(string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceConnectionMaps/[SERVICE_CONNECTION_MAP]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await crossNetworkAutomationServiceClient.DeleteServiceConnectionMapAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionMap</summary>
        public void DeleteServiceConnectionMapResourceNames()
        {
            // Snippet: DeleteServiceConnectionMap(ServiceConnectionMapName, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ServiceConnectionMapName name = ServiceConnectionMapName.FromProjectLocationServiceConnectionMap("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_MAP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = crossNetworkAutomationServiceClient.DeleteServiceConnectionMap(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionMap(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionMapAsync</summary>
        public async Task DeleteServiceConnectionMapResourceNamesAsync()
        {
            // Snippet: DeleteServiceConnectionMapAsync(ServiceConnectionMapName, CallSettings)
            // Additional: DeleteServiceConnectionMapAsync(ServiceConnectionMapName, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceConnectionMapName name = ServiceConnectionMapName.FromProjectLocationServiceConnectionMap("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_MAP]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await crossNetworkAutomationServiceClient.DeleteServiceConnectionMapAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionMapAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionPolicies</summary>
        public void ListServiceConnectionPoliciesRequestObject()
        {
            // Snippet: ListServiceConnectionPolicies(ListServiceConnectionPoliciesRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ListServiceConnectionPoliciesRequest request = new ListServiceConnectionPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> response = crossNetworkAutomationServiceClient.ListServiceConnectionPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceConnectionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceConnectionPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionPoliciesAsync</summary>
        public async Task ListServiceConnectionPoliciesRequestObjectAsync()
        {
            // Snippet: ListServiceConnectionPoliciesAsync(ListServiceConnectionPoliciesRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceConnectionPoliciesRequest request = new ListServiceConnectionPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> response = crossNetworkAutomationServiceClient.ListServiceConnectionPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceConnectionPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceConnectionPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionPolicies</summary>
        public void ListServiceConnectionPolicies()
        {
            // Snippet: ListServiceConnectionPolicies(string, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> response = crossNetworkAutomationServiceClient.ListServiceConnectionPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceConnectionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceConnectionPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionPoliciesAsync</summary>
        public async Task ListServiceConnectionPoliciesAsync()
        {
            // Snippet: ListServiceConnectionPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> response = crossNetworkAutomationServiceClient.ListServiceConnectionPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceConnectionPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceConnectionPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionPolicies</summary>
        public void ListServiceConnectionPoliciesResourceNames()
        {
            // Snippet: ListServiceConnectionPolicies(LocationName, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> response = crossNetworkAutomationServiceClient.ListServiceConnectionPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceConnectionPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceConnectionPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionPoliciesAsync</summary>
        public async Task ListServiceConnectionPoliciesResourceNamesAsync()
        {
            // Snippet: ListServiceConnectionPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListServiceConnectionPoliciesResponse, ServiceConnectionPolicy> response = crossNetworkAutomationServiceClient.ListServiceConnectionPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceConnectionPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceConnectionPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionPolicy</summary>
        public void GetServiceConnectionPolicyRequestObject()
        {
            // Snippet: GetServiceConnectionPolicy(GetServiceConnectionPolicyRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            GetServiceConnectionPolicyRequest request = new GetServiceConnectionPolicyRequest
            {
                ServiceConnectionPolicyName = ServiceConnectionPolicyName.FromProjectLocationServiceConnectionPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_POLICY]"),
            };
            // Make the request
            ServiceConnectionPolicy response = crossNetworkAutomationServiceClient.GetServiceConnectionPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionPolicyAsync</summary>
        public async Task GetServiceConnectionPolicyRequestObjectAsync()
        {
            // Snippet: GetServiceConnectionPolicyAsync(GetServiceConnectionPolicyRequest, CallSettings)
            // Additional: GetServiceConnectionPolicyAsync(GetServiceConnectionPolicyRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceConnectionPolicyRequest request = new GetServiceConnectionPolicyRequest
            {
                ServiceConnectionPolicyName = ServiceConnectionPolicyName.FromProjectLocationServiceConnectionPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_POLICY]"),
            };
            // Make the request
            ServiceConnectionPolicy response = await crossNetworkAutomationServiceClient.GetServiceConnectionPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionPolicy</summary>
        public void GetServiceConnectionPolicy()
        {
            // Snippet: GetServiceConnectionPolicy(string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceConnectionPolicies/[SERVICE_CONNECTION_POLICY]";
            // Make the request
            ServiceConnectionPolicy response = crossNetworkAutomationServiceClient.GetServiceConnectionPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionPolicyAsync</summary>
        public async Task GetServiceConnectionPolicyAsync()
        {
            // Snippet: GetServiceConnectionPolicyAsync(string, CallSettings)
            // Additional: GetServiceConnectionPolicyAsync(string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceConnectionPolicies/[SERVICE_CONNECTION_POLICY]";
            // Make the request
            ServiceConnectionPolicy response = await crossNetworkAutomationServiceClient.GetServiceConnectionPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionPolicy</summary>
        public void GetServiceConnectionPolicyResourceNames()
        {
            // Snippet: GetServiceConnectionPolicy(ServiceConnectionPolicyName, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ServiceConnectionPolicyName name = ServiceConnectionPolicyName.FromProjectLocationServiceConnectionPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_POLICY]");
            // Make the request
            ServiceConnectionPolicy response = crossNetworkAutomationServiceClient.GetServiceConnectionPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionPolicyAsync</summary>
        public async Task GetServiceConnectionPolicyResourceNamesAsync()
        {
            // Snippet: GetServiceConnectionPolicyAsync(ServiceConnectionPolicyName, CallSettings)
            // Additional: GetServiceConnectionPolicyAsync(ServiceConnectionPolicyName, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceConnectionPolicyName name = ServiceConnectionPolicyName.FromProjectLocationServiceConnectionPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_POLICY]");
            // Make the request
            ServiceConnectionPolicy response = await crossNetworkAutomationServiceClient.GetServiceConnectionPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionPolicy</summary>
        public void CreateServiceConnectionPolicyRequestObject()
        {
            // Snippet: CreateServiceConnectionPolicy(CreateServiceConnectionPolicyRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            CreateServiceConnectionPolicyRequest request = new CreateServiceConnectionPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceConnectionPolicyId = "",
                ServiceConnectionPolicy = new ServiceConnectionPolicy(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceConnectionPolicy, OperationMetadata> response = crossNetworkAutomationServiceClient.CreateServiceConnectionPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionPolicy, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionPolicyAsync</summary>
        public async Task CreateServiceConnectionPolicyRequestObjectAsync()
        {
            // Snippet: CreateServiceConnectionPolicyAsync(CreateServiceConnectionPolicyRequest, CallSettings)
            // Additional: CreateServiceConnectionPolicyAsync(CreateServiceConnectionPolicyRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceConnectionPolicyRequest request = new CreateServiceConnectionPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceConnectionPolicyId = "",
                ServiceConnectionPolicy = new ServiceConnectionPolicy(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceConnectionPolicy, OperationMetadata> response = await crossNetworkAutomationServiceClient.CreateServiceConnectionPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionPolicy, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionPolicy</summary>
        public void CreateServiceConnectionPolicy()
        {
            // Snippet: CreateServiceConnectionPolicy(string, ServiceConnectionPolicy, string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServiceConnectionPolicy serviceConnectionPolicy = new ServiceConnectionPolicy();
            string serviceConnectionPolicyId = "";
            // Make the request
            Operation<ServiceConnectionPolicy, OperationMetadata> response = crossNetworkAutomationServiceClient.CreateServiceConnectionPolicy(parent, serviceConnectionPolicy, serviceConnectionPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionPolicy, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionPolicyAsync</summary>
        public async Task CreateServiceConnectionPolicyAsync()
        {
            // Snippet: CreateServiceConnectionPolicyAsync(string, ServiceConnectionPolicy, string, CallSettings)
            // Additional: CreateServiceConnectionPolicyAsync(string, ServiceConnectionPolicy, string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServiceConnectionPolicy serviceConnectionPolicy = new ServiceConnectionPolicy();
            string serviceConnectionPolicyId = "";
            // Make the request
            Operation<ServiceConnectionPolicy, OperationMetadata> response = await crossNetworkAutomationServiceClient.CreateServiceConnectionPolicyAsync(parent, serviceConnectionPolicy, serviceConnectionPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionPolicy, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionPolicy</summary>
        public void CreateServiceConnectionPolicyResourceNames()
        {
            // Snippet: CreateServiceConnectionPolicy(LocationName, ServiceConnectionPolicy, string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServiceConnectionPolicy serviceConnectionPolicy = new ServiceConnectionPolicy();
            string serviceConnectionPolicyId = "";
            // Make the request
            Operation<ServiceConnectionPolicy, OperationMetadata> response = crossNetworkAutomationServiceClient.CreateServiceConnectionPolicy(parent, serviceConnectionPolicy, serviceConnectionPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionPolicy, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionPolicyAsync</summary>
        public async Task CreateServiceConnectionPolicyResourceNamesAsync()
        {
            // Snippet: CreateServiceConnectionPolicyAsync(LocationName, ServiceConnectionPolicy, string, CallSettings)
            // Additional: CreateServiceConnectionPolicyAsync(LocationName, ServiceConnectionPolicy, string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServiceConnectionPolicy serviceConnectionPolicy = new ServiceConnectionPolicy();
            string serviceConnectionPolicyId = "";
            // Make the request
            Operation<ServiceConnectionPolicy, OperationMetadata> response = await crossNetworkAutomationServiceClient.CreateServiceConnectionPolicyAsync(parent, serviceConnectionPolicy, serviceConnectionPolicyId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionPolicy, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceConnectionPolicy</summary>
        public void UpdateServiceConnectionPolicyRequestObject()
        {
            // Snippet: UpdateServiceConnectionPolicy(UpdateServiceConnectionPolicyRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            UpdateServiceConnectionPolicyRequest request = new UpdateServiceConnectionPolicyRequest
            {
                UpdateMask = new FieldMask(),
                ServiceConnectionPolicy = new ServiceConnectionPolicy(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceConnectionPolicy, OperationMetadata> response = crossNetworkAutomationServiceClient.UpdateServiceConnectionPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionPolicy, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceUpdateServiceConnectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceConnectionPolicyAsync</summary>
        public async Task UpdateServiceConnectionPolicyRequestObjectAsync()
        {
            // Snippet: UpdateServiceConnectionPolicyAsync(UpdateServiceConnectionPolicyRequest, CallSettings)
            // Additional: UpdateServiceConnectionPolicyAsync(UpdateServiceConnectionPolicyRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServiceConnectionPolicyRequest request = new UpdateServiceConnectionPolicyRequest
            {
                UpdateMask = new FieldMask(),
                ServiceConnectionPolicy = new ServiceConnectionPolicy(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceConnectionPolicy, OperationMetadata> response = await crossNetworkAutomationServiceClient.UpdateServiceConnectionPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionPolicy, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceUpdateServiceConnectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceConnectionPolicy</summary>
        public void UpdateServiceConnectionPolicy()
        {
            // Snippet: UpdateServiceConnectionPolicy(ServiceConnectionPolicy, FieldMask, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ServiceConnectionPolicy serviceConnectionPolicy = new ServiceConnectionPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServiceConnectionPolicy, OperationMetadata> response = crossNetworkAutomationServiceClient.UpdateServiceConnectionPolicy(serviceConnectionPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionPolicy, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionPolicy, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceUpdateServiceConnectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceConnectionPolicyAsync</summary>
        public async Task UpdateServiceConnectionPolicyAsync()
        {
            // Snippet: UpdateServiceConnectionPolicyAsync(ServiceConnectionPolicy, FieldMask, CallSettings)
            // Additional: UpdateServiceConnectionPolicyAsync(ServiceConnectionPolicy, FieldMask, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceConnectionPolicy serviceConnectionPolicy = new ServiceConnectionPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServiceConnectionPolicy, OperationMetadata> response = await crossNetworkAutomationServiceClient.UpdateServiceConnectionPolicyAsync(serviceConnectionPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionPolicy, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceUpdateServiceConnectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionPolicy retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionPolicy</summary>
        public void DeleteServiceConnectionPolicyRequestObject()
        {
            // Snippet: DeleteServiceConnectionPolicy(DeleteServiceConnectionPolicyRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            DeleteServiceConnectionPolicyRequest request = new DeleteServiceConnectionPolicyRequest
            {
                ServiceConnectionPolicyName = ServiceConnectionPolicyName.FromProjectLocationServiceConnectionPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_POLICY]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = crossNetworkAutomationServiceClient.DeleteServiceConnectionPolicy(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionPolicyAsync</summary>
        public async Task DeleteServiceConnectionPolicyRequestObjectAsync()
        {
            // Snippet: DeleteServiceConnectionPolicyAsync(DeleteServiceConnectionPolicyRequest, CallSettings)
            // Additional: DeleteServiceConnectionPolicyAsync(DeleteServiceConnectionPolicyRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceConnectionPolicyRequest request = new DeleteServiceConnectionPolicyRequest
            {
                ServiceConnectionPolicyName = ServiceConnectionPolicyName.FromProjectLocationServiceConnectionPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_POLICY]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await crossNetworkAutomationServiceClient.DeleteServiceConnectionPolicyAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionPolicy</summary>
        public void DeleteServiceConnectionPolicy()
        {
            // Snippet: DeleteServiceConnectionPolicy(string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceConnectionPolicies/[SERVICE_CONNECTION_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = crossNetworkAutomationServiceClient.DeleteServiceConnectionPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionPolicyAsync</summary>
        public async Task DeleteServiceConnectionPolicyAsync()
        {
            // Snippet: DeleteServiceConnectionPolicyAsync(string, CallSettings)
            // Additional: DeleteServiceConnectionPolicyAsync(string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceConnectionPolicies/[SERVICE_CONNECTION_POLICY]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await crossNetworkAutomationServiceClient.DeleteServiceConnectionPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionPolicy</summary>
        public void DeleteServiceConnectionPolicyResourceNames()
        {
            // Snippet: DeleteServiceConnectionPolicy(ServiceConnectionPolicyName, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ServiceConnectionPolicyName name = ServiceConnectionPolicyName.FromProjectLocationServiceConnectionPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = crossNetworkAutomationServiceClient.DeleteServiceConnectionPolicy(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionPolicy(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionPolicyAsync</summary>
        public async Task DeleteServiceConnectionPolicyResourceNamesAsync()
        {
            // Snippet: DeleteServiceConnectionPolicyAsync(ServiceConnectionPolicyName, CallSettings)
            // Additional: DeleteServiceConnectionPolicyAsync(ServiceConnectionPolicyName, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceConnectionPolicyName name = ServiceConnectionPolicyName.FromProjectLocationServiceConnectionPolicy("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_POLICY]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await crossNetworkAutomationServiceClient.DeleteServiceConnectionPolicyAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListServiceClasses</summary>
        public void ListServiceClassesRequestObject()
        {
            // Snippet: ListServiceClasses(ListServiceClassesRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ListServiceClassesRequest request = new ListServiceClassesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListServiceClassesResponse, ServiceClass> response = crossNetworkAutomationServiceClient.ListServiceClasses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceClass item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceClassesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceClass item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceClass> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceClass item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceClassesAsync</summary>
        public async Task ListServiceClassesRequestObjectAsync()
        {
            // Snippet: ListServiceClassesAsync(ListServiceClassesRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceClassesRequest request = new ListServiceClassesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListServiceClassesResponse, ServiceClass> response = crossNetworkAutomationServiceClient.ListServiceClassesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceClass item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceClassesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceClass item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceClass> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceClass item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceClasses</summary>
        public void ListServiceClasses()
        {
            // Snippet: ListServiceClasses(string, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListServiceClassesResponse, ServiceClass> response = crossNetworkAutomationServiceClient.ListServiceClasses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceClass item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceClassesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceClass item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceClass> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceClass item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceClassesAsync</summary>
        public async Task ListServiceClassesAsync()
        {
            // Snippet: ListServiceClassesAsync(string, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListServiceClassesResponse, ServiceClass> response = crossNetworkAutomationServiceClient.ListServiceClassesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceClass item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceClassesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceClass item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceClass> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceClass item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceClasses</summary>
        public void ListServiceClassesResourceNames()
        {
            // Snippet: ListServiceClasses(LocationName, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListServiceClassesResponse, ServiceClass> response = crossNetworkAutomationServiceClient.ListServiceClasses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceClass item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceClassesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceClass item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceClass> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceClass item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceClassesAsync</summary>
        public async Task ListServiceClassesResourceNamesAsync()
        {
            // Snippet: ListServiceClassesAsync(LocationName, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListServiceClassesResponse, ServiceClass> response = crossNetworkAutomationServiceClient.ListServiceClassesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceClass item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceClassesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceClass item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceClass> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceClass item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetServiceClass</summary>
        public void GetServiceClassRequestObject()
        {
            // Snippet: GetServiceClass(GetServiceClassRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            GetServiceClassRequest request = new GetServiceClassRequest
            {
                ServiceClassName = ServiceClassName.FromProjectLocationServiceClass("[PROJECT]", "[LOCATION]", "[SERVICE_CLASS]"),
            };
            // Make the request
            ServiceClass response = crossNetworkAutomationServiceClient.GetServiceClass(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceClassAsync</summary>
        public async Task GetServiceClassRequestObjectAsync()
        {
            // Snippet: GetServiceClassAsync(GetServiceClassRequest, CallSettings)
            // Additional: GetServiceClassAsync(GetServiceClassRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceClassRequest request = new GetServiceClassRequest
            {
                ServiceClassName = ServiceClassName.FromProjectLocationServiceClass("[PROJECT]", "[LOCATION]", "[SERVICE_CLASS]"),
            };
            // Make the request
            ServiceClass response = await crossNetworkAutomationServiceClient.GetServiceClassAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceClass</summary>
        public void GetServiceClass()
        {
            // Snippet: GetServiceClass(string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceClasses/[SERVICE_CLASS]";
            // Make the request
            ServiceClass response = crossNetworkAutomationServiceClient.GetServiceClass(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceClassAsync</summary>
        public async Task GetServiceClassAsync()
        {
            // Snippet: GetServiceClassAsync(string, CallSettings)
            // Additional: GetServiceClassAsync(string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceClasses/[SERVICE_CLASS]";
            // Make the request
            ServiceClass response = await crossNetworkAutomationServiceClient.GetServiceClassAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceClass</summary>
        public void GetServiceClassResourceNames()
        {
            // Snippet: GetServiceClass(ServiceClassName, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ServiceClassName name = ServiceClassName.FromProjectLocationServiceClass("[PROJECT]", "[LOCATION]", "[SERVICE_CLASS]");
            // Make the request
            ServiceClass response = crossNetworkAutomationServiceClient.GetServiceClass(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceClassAsync</summary>
        public async Task GetServiceClassResourceNamesAsync()
        {
            // Snippet: GetServiceClassAsync(ServiceClassName, CallSettings)
            // Additional: GetServiceClassAsync(ServiceClassName, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceClassName name = ServiceClassName.FromProjectLocationServiceClass("[PROJECT]", "[LOCATION]", "[SERVICE_CLASS]");
            // Make the request
            ServiceClass response = await crossNetworkAutomationServiceClient.GetServiceClassAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceClass</summary>
        public void UpdateServiceClassRequestObject()
        {
            // Snippet: UpdateServiceClass(UpdateServiceClassRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            UpdateServiceClassRequest request = new UpdateServiceClassRequest
            {
                UpdateMask = new FieldMask(),
                ServiceClass = new ServiceClass(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceClass, OperationMetadata> response = crossNetworkAutomationServiceClient.UpdateServiceClass(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceClass, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceUpdateServiceClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceClassAsync</summary>
        public async Task UpdateServiceClassRequestObjectAsync()
        {
            // Snippet: UpdateServiceClassAsync(UpdateServiceClassRequest, CallSettings)
            // Additional: UpdateServiceClassAsync(UpdateServiceClassRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServiceClassRequest request = new UpdateServiceClassRequest
            {
                UpdateMask = new FieldMask(),
                ServiceClass = new ServiceClass(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceClass, OperationMetadata> response = await crossNetworkAutomationServiceClient.UpdateServiceClassAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceClass, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceUpdateServiceClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceClass</summary>
        public void UpdateServiceClass()
        {
            // Snippet: UpdateServiceClass(ServiceClass, FieldMask, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ServiceClass serviceClass = new ServiceClass();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServiceClass, OperationMetadata> response = crossNetworkAutomationServiceClient.UpdateServiceClass(serviceClass, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServiceClass, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceClass, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceUpdateServiceClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceClassAsync</summary>
        public async Task UpdateServiceClassAsync()
        {
            // Snippet: UpdateServiceClassAsync(ServiceClass, FieldMask, CallSettings)
            // Additional: UpdateServiceClassAsync(ServiceClass, FieldMask, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceClass serviceClass = new ServiceClass();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ServiceClass, OperationMetadata> response = await crossNetworkAutomationServiceClient.UpdateServiceClassAsync(serviceClass, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ServiceClass, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceClass result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceClass, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceUpdateServiceClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceClass retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceClass</summary>
        public void DeleteServiceClassRequestObject()
        {
            // Snippet: DeleteServiceClass(DeleteServiceClassRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            DeleteServiceClassRequest request = new DeleteServiceClassRequest
            {
                ServiceClassName = ServiceClassName.FromProjectLocationServiceClass("[PROJECT]", "[LOCATION]", "[SERVICE_CLASS]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = crossNetworkAutomationServiceClient.DeleteServiceClass(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceDeleteServiceClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceClassAsync</summary>
        public async Task DeleteServiceClassRequestObjectAsync()
        {
            // Snippet: DeleteServiceClassAsync(DeleteServiceClassRequest, CallSettings)
            // Additional: DeleteServiceClassAsync(DeleteServiceClassRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceClassRequest request = new DeleteServiceClassRequest
            {
                ServiceClassName = ServiceClassName.FromProjectLocationServiceClass("[PROJECT]", "[LOCATION]", "[SERVICE_CLASS]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await crossNetworkAutomationServiceClient.DeleteServiceClassAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceDeleteServiceClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceClass</summary>
        public void DeleteServiceClass()
        {
            // Snippet: DeleteServiceClass(string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceClasses/[SERVICE_CLASS]";
            // Make the request
            Operation<Empty, OperationMetadata> response = crossNetworkAutomationServiceClient.DeleteServiceClass(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceDeleteServiceClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceClassAsync</summary>
        public async Task DeleteServiceClassAsync()
        {
            // Snippet: DeleteServiceClassAsync(string, CallSettings)
            // Additional: DeleteServiceClassAsync(string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceClasses/[SERVICE_CLASS]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await crossNetworkAutomationServiceClient.DeleteServiceClassAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceDeleteServiceClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceClass</summary>
        public void DeleteServiceClassResourceNames()
        {
            // Snippet: DeleteServiceClass(ServiceClassName, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ServiceClassName name = ServiceClassName.FromProjectLocationServiceClass("[PROJECT]", "[LOCATION]", "[SERVICE_CLASS]");
            // Make the request
            Operation<Empty, OperationMetadata> response = crossNetworkAutomationServiceClient.DeleteServiceClass(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceDeleteServiceClass(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceClassAsync</summary>
        public async Task DeleteServiceClassResourceNamesAsync()
        {
            // Snippet: DeleteServiceClassAsync(ServiceClassName, CallSettings)
            // Additional: DeleteServiceClassAsync(ServiceClassName, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceClassName name = ServiceClassName.FromProjectLocationServiceClass("[PROJECT]", "[LOCATION]", "[SERVICE_CLASS]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await crossNetworkAutomationServiceClient.DeleteServiceClassAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceDeleteServiceClassAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionToken</summary>
        public void GetServiceConnectionTokenRequestObject()
        {
            // Snippet: GetServiceConnectionToken(GetServiceConnectionTokenRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            GetServiceConnectionTokenRequest request = new GetServiceConnectionTokenRequest
            {
                ServiceConnectionTokenName = ServiceConnectionTokenName.FromProjectLocationServiceConnectionToken("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_TOKEN]"),
            };
            // Make the request
            ServiceConnectionToken response = crossNetworkAutomationServiceClient.GetServiceConnectionToken(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionTokenAsync</summary>
        public async Task GetServiceConnectionTokenRequestObjectAsync()
        {
            // Snippet: GetServiceConnectionTokenAsync(GetServiceConnectionTokenRequest, CallSettings)
            // Additional: GetServiceConnectionTokenAsync(GetServiceConnectionTokenRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceConnectionTokenRequest request = new GetServiceConnectionTokenRequest
            {
                ServiceConnectionTokenName = ServiceConnectionTokenName.FromProjectLocationServiceConnectionToken("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_TOKEN]"),
            };
            // Make the request
            ServiceConnectionToken response = await crossNetworkAutomationServiceClient.GetServiceConnectionTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionToken</summary>
        public void GetServiceConnectionToken()
        {
            // Snippet: GetServiceConnectionToken(string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceConnectionTokens/[SERVICE_CONNECTION_TOKEN]";
            // Make the request
            ServiceConnectionToken response = crossNetworkAutomationServiceClient.GetServiceConnectionToken(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionTokenAsync</summary>
        public async Task GetServiceConnectionTokenAsync()
        {
            // Snippet: GetServiceConnectionTokenAsync(string, CallSettings)
            // Additional: GetServiceConnectionTokenAsync(string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceConnectionTokens/[SERVICE_CONNECTION_TOKEN]";
            // Make the request
            ServiceConnectionToken response = await crossNetworkAutomationServiceClient.GetServiceConnectionTokenAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionToken</summary>
        public void GetServiceConnectionTokenResourceNames()
        {
            // Snippet: GetServiceConnectionToken(ServiceConnectionTokenName, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ServiceConnectionTokenName name = ServiceConnectionTokenName.FromProjectLocationServiceConnectionToken("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_TOKEN]");
            // Make the request
            ServiceConnectionToken response = crossNetworkAutomationServiceClient.GetServiceConnectionToken(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConnectionTokenAsync</summary>
        public async Task GetServiceConnectionTokenResourceNamesAsync()
        {
            // Snippet: GetServiceConnectionTokenAsync(ServiceConnectionTokenName, CallSettings)
            // Additional: GetServiceConnectionTokenAsync(ServiceConnectionTokenName, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceConnectionTokenName name = ServiceConnectionTokenName.FromProjectLocationServiceConnectionToken("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_TOKEN]");
            // Make the request
            ServiceConnectionToken response = await crossNetworkAutomationServiceClient.GetServiceConnectionTokenAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionTokens</summary>
        public void ListServiceConnectionTokensRequestObject()
        {
            // Snippet: ListServiceConnectionTokens(ListServiceConnectionTokensRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ListServiceConnectionTokensRequest request = new ListServiceConnectionTokensRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> response = crossNetworkAutomationServiceClient.ListServiceConnectionTokens(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceConnectionToken item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceConnectionTokensResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionToken item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionToken> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionToken item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionTokensAsync</summary>
        public async Task ListServiceConnectionTokensRequestObjectAsync()
        {
            // Snippet: ListServiceConnectionTokensAsync(ListServiceConnectionTokensRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceConnectionTokensRequest request = new ListServiceConnectionTokensRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> response = crossNetworkAutomationServiceClient.ListServiceConnectionTokensAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceConnectionToken item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceConnectionTokensResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionToken item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionToken> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionToken item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionTokens</summary>
        public void ListServiceConnectionTokens()
        {
            // Snippet: ListServiceConnectionTokens(string, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> response = crossNetworkAutomationServiceClient.ListServiceConnectionTokens(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceConnectionToken item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceConnectionTokensResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionToken item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionToken> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionToken item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionTokensAsync</summary>
        public async Task ListServiceConnectionTokensAsync()
        {
            // Snippet: ListServiceConnectionTokensAsync(string, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> response = crossNetworkAutomationServiceClient.ListServiceConnectionTokensAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceConnectionToken item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceConnectionTokensResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionToken item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionToken> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionToken item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionTokens</summary>
        public void ListServiceConnectionTokensResourceNames()
        {
            // Snippet: ListServiceConnectionTokens(LocationName, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> response = crossNetworkAutomationServiceClient.ListServiceConnectionTokens(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceConnectionToken item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceConnectionTokensResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionToken item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionToken> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionToken item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConnectionTokensAsync</summary>
        public async Task ListServiceConnectionTokensResourceNamesAsync()
        {
            // Snippet: ListServiceConnectionTokensAsync(LocationName, string, int?, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListServiceConnectionTokensResponse, ServiceConnectionToken> response = crossNetworkAutomationServiceClient.ListServiceConnectionTokensAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceConnectionToken item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceConnectionTokensResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceConnectionToken item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceConnectionToken> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceConnectionToken item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionToken</summary>
        public void CreateServiceConnectionTokenRequestObject()
        {
            // Snippet: CreateServiceConnectionToken(CreateServiceConnectionTokenRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            CreateServiceConnectionTokenRequest request = new CreateServiceConnectionTokenRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceConnectionTokenId = "",
                ServiceConnectionToken = new ServiceConnectionToken(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceConnectionToken, OperationMetadata> response = crossNetworkAutomationServiceClient.CreateServiceConnectionToken(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionToken, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionToken result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionToken, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionToken(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionToken retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionTokenAsync</summary>
        public async Task CreateServiceConnectionTokenRequestObjectAsync()
        {
            // Snippet: CreateServiceConnectionTokenAsync(CreateServiceConnectionTokenRequest, CallSettings)
            // Additional: CreateServiceConnectionTokenAsync(CreateServiceConnectionTokenRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceConnectionTokenRequest request = new CreateServiceConnectionTokenRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ServiceConnectionTokenId = "",
                ServiceConnectionToken = new ServiceConnectionToken(),
                RequestId = "",
            };
            // Make the request
            Operation<ServiceConnectionToken, OperationMetadata> response = await crossNetworkAutomationServiceClient.CreateServiceConnectionTokenAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionToken, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionToken result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionToken, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionTokenAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionToken retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionToken</summary>
        public void CreateServiceConnectionToken()
        {
            // Snippet: CreateServiceConnectionToken(string, ServiceConnectionToken, string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServiceConnectionToken serviceConnectionToken = new ServiceConnectionToken();
            string serviceConnectionTokenId = "";
            // Make the request
            Operation<ServiceConnectionToken, OperationMetadata> response = crossNetworkAutomationServiceClient.CreateServiceConnectionToken(parent, serviceConnectionToken, serviceConnectionTokenId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionToken, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionToken result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionToken, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionToken(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionToken retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionTokenAsync</summary>
        public async Task CreateServiceConnectionTokenAsync()
        {
            // Snippet: CreateServiceConnectionTokenAsync(string, ServiceConnectionToken, string, CallSettings)
            // Additional: CreateServiceConnectionTokenAsync(string, ServiceConnectionToken, string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            ServiceConnectionToken serviceConnectionToken = new ServiceConnectionToken();
            string serviceConnectionTokenId = "";
            // Make the request
            Operation<ServiceConnectionToken, OperationMetadata> response = await crossNetworkAutomationServiceClient.CreateServiceConnectionTokenAsync(parent, serviceConnectionToken, serviceConnectionTokenId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionToken, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionToken result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionToken, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionTokenAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionToken retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionToken</summary>
        public void CreateServiceConnectionTokenResourceNames()
        {
            // Snippet: CreateServiceConnectionToken(LocationName, ServiceConnectionToken, string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServiceConnectionToken serviceConnectionToken = new ServiceConnectionToken();
            string serviceConnectionTokenId = "";
            // Make the request
            Operation<ServiceConnectionToken, OperationMetadata> response = crossNetworkAutomationServiceClient.CreateServiceConnectionToken(parent, serviceConnectionToken, serviceConnectionTokenId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionToken, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ServiceConnectionToken result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionToken, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionToken(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionToken retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConnectionTokenAsync</summary>
        public async Task CreateServiceConnectionTokenResourceNamesAsync()
        {
            // Snippet: CreateServiceConnectionTokenAsync(LocationName, ServiceConnectionToken, string, CallSettings)
            // Additional: CreateServiceConnectionTokenAsync(LocationName, ServiceConnectionToken, string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ServiceConnectionToken serviceConnectionToken = new ServiceConnectionToken();
            string serviceConnectionTokenId = "";
            // Make the request
            Operation<ServiceConnectionToken, OperationMetadata> response = await crossNetworkAutomationServiceClient.CreateServiceConnectionTokenAsync(parent, serviceConnectionToken, serviceConnectionTokenId);

            // Poll until the returned long-running operation is complete
            Operation<ServiceConnectionToken, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ServiceConnectionToken result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ServiceConnectionToken, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceCreateServiceConnectionTokenAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ServiceConnectionToken retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionToken</summary>
        public void DeleteServiceConnectionTokenRequestObject()
        {
            // Snippet: DeleteServiceConnectionToken(DeleteServiceConnectionTokenRequest, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            DeleteServiceConnectionTokenRequest request = new DeleteServiceConnectionTokenRequest
            {
                ServiceConnectionTokenName = ServiceConnectionTokenName.FromProjectLocationServiceConnectionToken("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_TOKEN]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = crossNetworkAutomationServiceClient.DeleteServiceConnectionToken(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionToken(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionTokenAsync</summary>
        public async Task DeleteServiceConnectionTokenRequestObjectAsync()
        {
            // Snippet: DeleteServiceConnectionTokenAsync(DeleteServiceConnectionTokenRequest, CallSettings)
            // Additional: DeleteServiceConnectionTokenAsync(DeleteServiceConnectionTokenRequest, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceConnectionTokenRequest request = new DeleteServiceConnectionTokenRequest
            {
                ServiceConnectionTokenName = ServiceConnectionTokenName.FromProjectLocationServiceConnectionToken("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_TOKEN]"),
                RequestId = "",
                Etag = "",
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await crossNetworkAutomationServiceClient.DeleteServiceConnectionTokenAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionTokenAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionToken</summary>
        public void DeleteServiceConnectionToken()
        {
            // Snippet: DeleteServiceConnectionToken(string, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceConnectionTokens/[SERVICE_CONNECTION_TOKEN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = crossNetworkAutomationServiceClient.DeleteServiceConnectionToken(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionToken(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionTokenAsync</summary>
        public async Task DeleteServiceConnectionTokenAsync()
        {
            // Snippet: DeleteServiceConnectionTokenAsync(string, CallSettings)
            // Additional: DeleteServiceConnectionTokenAsync(string, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/serviceConnectionTokens/[SERVICE_CONNECTION_TOKEN]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await crossNetworkAutomationServiceClient.DeleteServiceConnectionTokenAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionTokenAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionToken</summary>
        public void DeleteServiceConnectionTokenResourceNames()
        {
            // Snippet: DeleteServiceConnectionToken(ServiceConnectionTokenName, CallSettings)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = CrossNetworkAutomationServiceClient.Create();
            // Initialize request argument(s)
            ServiceConnectionTokenName name = ServiceConnectionTokenName.FromProjectLocationServiceConnectionToken("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_TOKEN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = crossNetworkAutomationServiceClient.DeleteServiceConnectionToken(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionToken(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceConnectionTokenAsync</summary>
        public async Task DeleteServiceConnectionTokenResourceNamesAsync()
        {
            // Snippet: DeleteServiceConnectionTokenAsync(ServiceConnectionTokenName, CallSettings)
            // Additional: DeleteServiceConnectionTokenAsync(ServiceConnectionTokenName, CancellationToken)
            // Create client
            CrossNetworkAutomationServiceClient crossNetworkAutomationServiceClient = await CrossNetworkAutomationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceConnectionTokenName name = ServiceConnectionTokenName.FromProjectLocationServiceConnectionToken("[PROJECT]", "[LOCATION]", "[SERVICE_CONNECTION_TOKEN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await crossNetworkAutomationServiceClient.DeleteServiceConnectionTokenAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await crossNetworkAutomationServiceClient.PollOnceDeleteServiceConnectionTokenAsync(operationName);
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
