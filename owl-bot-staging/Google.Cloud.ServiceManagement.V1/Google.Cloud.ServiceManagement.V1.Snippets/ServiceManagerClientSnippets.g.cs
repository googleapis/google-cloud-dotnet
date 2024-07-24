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
    using Google.Api;
    using Google.Api.Gax;
    using Google.Cloud.ServiceManagement.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedServiceManagerClientSnippets
    {
        /// <summary>Snippet for ListServices</summary>
        public void ListServicesRequestObject()
        {
            // Snippet: ListServices(ListServicesRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ProducerProjectId = "",
            };
            // Make the request
            PagedEnumerable<ListServicesResponse, ManagedService> response = serviceManagerClient.ListServices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagedService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesRequestObjectAsync()
        {
            // Snippet: ListServicesAsync(ListServicesRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ProducerProjectId = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, ManagedService> response = serviceManagerClient.ListServicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagedService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServices()
        {
            // Snippet: ListServices(string, string, string, int?, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            string producerProjectId = "";
            string consumerId = "";
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListServicesResponse, ManagedService> response = serviceManagerClient.ListServices(producerProjectId, consumerId);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ManagedService item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedService> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesAsync()
        {
            // Snippet: ListServicesAsync(string, string, string, int?, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string producerProjectId = "";
            string consumerId = "";
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListServicesResponse, ManagedService> response = serviceManagerClient.ListServicesAsync(producerProjectId, consumerId);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ManagedService item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ManagedService item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ManagedService> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ManagedService item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceRequestObject()
        {
            // Snippet: GetService(GetServiceRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest { ServiceName = "", };
            // Make the request
            ManagedService response = serviceManagerClient.GetService(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceRequestObjectAsync()
        {
            // Snippet: GetServiceAsync(GetServiceRequest, CallSettings)
            // Additional: GetServiceAsync(GetServiceRequest, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest { ServiceName = "", };
            // Make the request
            ManagedService response = await serviceManagerClient.GetServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetService()
        {
            // Snippet: GetService(string, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            string serviceName = "";
            // Make the request
            ManagedService response = serviceManagerClient.GetService(serviceName);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceAsync()
        {
            // Snippet: GetServiceAsync(string, CallSettings)
            // Additional: GetServiceAsync(string, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string serviceName = "";
            // Make the request
            ManagedService response = await serviceManagerClient.GetServiceAsync(serviceName);
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceRequestObject()
        {
            // Snippet: CreateService(CreateServiceRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                Service = new ManagedService(),
            };
            // Make the request
            Operation<ManagedService, OperationMetadata> response = serviceManagerClient.CreateService(request);

            // Poll until the returned long-running operation is complete
            Operation<ManagedService, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagedService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagedService, OperationMetadata> retrievedResponse = serviceManagerClient.PollOnceCreateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagedService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceRequestObjectAsync()
        {
            // Snippet: CreateServiceAsync(CreateServiceRequest, CallSettings)
            // Additional: CreateServiceAsync(CreateServiceRequest, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                Service = new ManagedService(),
            };
            // Make the request
            Operation<ManagedService, OperationMetadata> response = await serviceManagerClient.CreateServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ManagedService, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagedService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagedService, OperationMetadata> retrievedResponse = await serviceManagerClient.PollOnceCreateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagedService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateService()
        {
            // Snippet: CreateService(ManagedService, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            ManagedService service = new ManagedService();
            // Make the request
            Operation<ManagedService, OperationMetadata> response = serviceManagerClient.CreateService(service);

            // Poll until the returned long-running operation is complete
            Operation<ManagedService, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ManagedService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagedService, OperationMetadata> retrievedResponse = serviceManagerClient.PollOnceCreateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagedService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceAsync()
        {
            // Snippet: CreateServiceAsync(ManagedService, CallSettings)
            // Additional: CreateServiceAsync(ManagedService, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ManagedService service = new ManagedService();
            // Make the request
            Operation<ManagedService, OperationMetadata> response = await serviceManagerClient.CreateServiceAsync(service);

            // Poll until the returned long-running operation is complete
            Operation<ManagedService, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ManagedService result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ManagedService, OperationMetadata> retrievedResponse = await serviceManagerClient.PollOnceCreateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ManagedService retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteServiceRequestObject()
        {
            // Snippet: DeleteService(DeleteServiceRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            DeleteServiceRequest request = new DeleteServiceRequest { ServiceName = "", };
            // Make the request
            Operation<Empty, OperationMetadata> response = serviceManagerClient.DeleteService(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = serviceManagerClient.PollOnceDeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceRequestObjectAsync()
        {
            // Snippet: DeleteServiceAsync(DeleteServiceRequest, CallSettings)
            // Additional: DeleteServiceAsync(DeleteServiceRequest, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceRequest request = new DeleteServiceRequest { ServiceName = "", };
            // Make the request
            Operation<Empty, OperationMetadata> response = await serviceManagerClient.DeleteServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await serviceManagerClient.PollOnceDeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteService()
        {
            // Snippet: DeleteService(string, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            string serviceName = "";
            // Make the request
            Operation<Empty, OperationMetadata> response = serviceManagerClient.DeleteService(serviceName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = serviceManagerClient.PollOnceDeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceAsync()
        {
            // Snippet: DeleteServiceAsync(string, CallSettings)
            // Additional: DeleteServiceAsync(string, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string serviceName = "";
            // Make the request
            Operation<Empty, OperationMetadata> response = await serviceManagerClient.DeleteServiceAsync(serviceName);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await serviceManagerClient.PollOnceDeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteService</summary>
        public void UndeleteServiceRequestObject()
        {
            // Snippet: UndeleteService(UndeleteServiceRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            UndeleteServiceRequest request = new UndeleteServiceRequest { ServiceName = "", };
            // Make the request
            Operation<UndeleteServiceResponse, OperationMetadata> response = serviceManagerClient.UndeleteService(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeleteServiceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeleteServiceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeleteServiceResponse, OperationMetadata> retrievedResponse = serviceManagerClient.PollOnceUndeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeleteServiceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteServiceAsync</summary>
        public async Task UndeleteServiceRequestObjectAsync()
        {
            // Snippet: UndeleteServiceAsync(UndeleteServiceRequest, CallSettings)
            // Additional: UndeleteServiceAsync(UndeleteServiceRequest, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteServiceRequest request = new UndeleteServiceRequest { ServiceName = "", };
            // Make the request
            Operation<UndeleteServiceResponse, OperationMetadata> response = await serviceManagerClient.UndeleteServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeleteServiceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeleteServiceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeleteServiceResponse, OperationMetadata> retrievedResponse = await serviceManagerClient.PollOnceUndeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeleteServiceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteService</summary>
        public void UndeleteService()
        {
            // Snippet: UndeleteService(string, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            string serviceName = "";
            // Make the request
            Operation<UndeleteServiceResponse, OperationMetadata> response = serviceManagerClient.UndeleteService(serviceName);

            // Poll until the returned long-running operation is complete
            Operation<UndeleteServiceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeleteServiceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeleteServiceResponse, OperationMetadata> retrievedResponse = serviceManagerClient.PollOnceUndeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeleteServiceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteServiceAsync</summary>
        public async Task UndeleteServiceAsync()
        {
            // Snippet: UndeleteServiceAsync(string, CallSettings)
            // Additional: UndeleteServiceAsync(string, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string serviceName = "";
            // Make the request
            Operation<UndeleteServiceResponse, OperationMetadata> response = await serviceManagerClient.UndeleteServiceAsync(serviceName);

            // Poll until the returned long-running operation is complete
            Operation<UndeleteServiceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeleteServiceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeleteServiceResponse, OperationMetadata> retrievedResponse = await serviceManagerClient.PollOnceUndeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeleteServiceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListServiceConfigs</summary>
        public void ListServiceConfigsRequestObject()
        {
            // Snippet: ListServiceConfigs(ListServiceConfigsRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            ListServiceConfigsRequest request = new ListServiceConfigsRequest { ServiceName = "", };
            // Make the request
            PagedEnumerable<ListServiceConfigsResponse, Service> response = serviceManagerClient.ListServiceConfigs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConfigsAsync</summary>
        public async Task ListServiceConfigsRequestObjectAsync()
        {
            // Snippet: ListServiceConfigsAsync(ListServiceConfigsRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceConfigsRequest request = new ListServiceConfigsRequest { ServiceName = "", };
            // Make the request
            PagedAsyncEnumerable<ListServiceConfigsResponse, Service> response = serviceManagerClient.ListServiceConfigsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Service item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConfigs</summary>
        public void ListServiceConfigs()
        {
            // Snippet: ListServiceConfigs(string, string, int?, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            string serviceName = "";
            // Make the request
            PagedEnumerable<ListServiceConfigsResponse, Service> response = serviceManagerClient.ListServiceConfigs(serviceName);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceConfigsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceConfigsAsync</summary>
        public async Task ListServiceConfigsAsync()
        {
            // Snippet: ListServiceConfigsAsync(string, string, int?, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string serviceName = "";
            // Make the request
            PagedAsyncEnumerable<ListServiceConfigsResponse, Service> response = serviceManagerClient.ListServiceConfigsAsync(serviceName);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Service item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceConfigsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetServiceConfig</summary>
        public void GetServiceConfigRequestObject()
        {
            // Snippet: GetServiceConfig(GetServiceConfigRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            GetServiceConfigRequest request = new GetServiceConfigRequest
            {
                ServiceName = "",
                ConfigId = "",
                View = GetServiceConfigRequest.Types.ConfigView.Basic,
            };
            // Make the request
            Service response = serviceManagerClient.GetServiceConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConfigAsync</summary>
        public async Task GetServiceConfigRequestObjectAsync()
        {
            // Snippet: GetServiceConfigAsync(GetServiceConfigRequest, CallSettings)
            // Additional: GetServiceConfigAsync(GetServiceConfigRequest, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceConfigRequest request = new GetServiceConfigRequest
            {
                ServiceName = "",
                ConfigId = "",
                View = GetServiceConfigRequest.Types.ConfigView.Basic,
            };
            // Make the request
            Service response = await serviceManagerClient.GetServiceConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConfig</summary>
        public void GetServiceConfig()
        {
            // Snippet: GetServiceConfig(string, string, GetServiceConfigRequest.Types.ConfigView, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            string serviceName = "";
            string configId = "";
            GetServiceConfigRequest.Types.ConfigView view = GetServiceConfigRequest.Types.ConfigView.Basic;
            // Make the request
            Service response = serviceManagerClient.GetServiceConfig(serviceName, configId, view);
            // End snippet
        }

        /// <summary>Snippet for GetServiceConfigAsync</summary>
        public async Task GetServiceConfigAsync()
        {
            // Snippet: GetServiceConfigAsync(string, string, GetServiceConfigRequest.Types.ConfigView, CallSettings)
            // Additional: GetServiceConfigAsync(string, string, GetServiceConfigRequest.Types.ConfigView, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string serviceName = "";
            string configId = "";
            GetServiceConfigRequest.Types.ConfigView view = GetServiceConfigRequest.Types.ConfigView.Basic;
            // Make the request
            Service response = await serviceManagerClient.GetServiceConfigAsync(serviceName, configId, view);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConfig</summary>
        public void CreateServiceConfigRequestObject()
        {
            // Snippet: CreateServiceConfig(CreateServiceConfigRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            CreateServiceConfigRequest request = new CreateServiceConfigRequest
            {
                ServiceName = "",
                ServiceConfig = new Service(),
            };
            // Make the request
            Service response = serviceManagerClient.CreateServiceConfig(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConfigAsync</summary>
        public async Task CreateServiceConfigRequestObjectAsync()
        {
            // Snippet: CreateServiceConfigAsync(CreateServiceConfigRequest, CallSettings)
            // Additional: CreateServiceConfigAsync(CreateServiceConfigRequest, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceConfigRequest request = new CreateServiceConfigRequest
            {
                ServiceName = "",
                ServiceConfig = new Service(),
            };
            // Make the request
            Service response = await serviceManagerClient.CreateServiceConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConfig</summary>
        public void CreateServiceConfig()
        {
            // Snippet: CreateServiceConfig(string, Service, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            string serviceName = "";
            Service serviceConfig = new Service();
            // Make the request
            Service response = serviceManagerClient.CreateServiceConfig(serviceName, serviceConfig);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceConfigAsync</summary>
        public async Task CreateServiceConfigAsync()
        {
            // Snippet: CreateServiceConfigAsync(string, Service, CallSettings)
            // Additional: CreateServiceConfigAsync(string, Service, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string serviceName = "";
            Service serviceConfig = new Service();
            // Make the request
            Service response = await serviceManagerClient.CreateServiceConfigAsync(serviceName, serviceConfig);
            // End snippet
        }

        /// <summary>Snippet for SubmitConfigSource</summary>
        public void SubmitConfigSourceRequestObject()
        {
            // Snippet: SubmitConfigSource(SubmitConfigSourceRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            SubmitConfigSourceRequest request = new SubmitConfigSourceRequest
            {
                ServiceName = "",
                ConfigSource = new ConfigSource(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<SubmitConfigSourceResponse, OperationMetadata> response = serviceManagerClient.SubmitConfigSource(request);

            // Poll until the returned long-running operation is complete
            Operation<SubmitConfigSourceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SubmitConfigSourceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SubmitConfigSourceResponse, OperationMetadata> retrievedResponse = serviceManagerClient.PollOnceSubmitConfigSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SubmitConfigSourceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SubmitConfigSourceAsync</summary>
        public async Task SubmitConfigSourceRequestObjectAsync()
        {
            // Snippet: SubmitConfigSourceAsync(SubmitConfigSourceRequest, CallSettings)
            // Additional: SubmitConfigSourceAsync(SubmitConfigSourceRequest, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            SubmitConfigSourceRequest request = new SubmitConfigSourceRequest
            {
                ServiceName = "",
                ConfigSource = new ConfigSource(),
                ValidateOnly = false,
            };
            // Make the request
            Operation<SubmitConfigSourceResponse, OperationMetadata> response = await serviceManagerClient.SubmitConfigSourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<SubmitConfigSourceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SubmitConfigSourceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SubmitConfigSourceResponse, OperationMetadata> retrievedResponse = await serviceManagerClient.PollOnceSubmitConfigSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SubmitConfigSourceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SubmitConfigSource</summary>
        public void SubmitConfigSource()
        {
            // Snippet: SubmitConfigSource(string, ConfigSource, bool, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            string serviceName = "";
            ConfigSource configSource = new ConfigSource();
            bool validateOnly = false;
            // Make the request
            Operation<SubmitConfigSourceResponse, OperationMetadata> response = serviceManagerClient.SubmitConfigSource(serviceName, configSource, validateOnly);

            // Poll until the returned long-running operation is complete
            Operation<SubmitConfigSourceResponse, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            SubmitConfigSourceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SubmitConfigSourceResponse, OperationMetadata> retrievedResponse = serviceManagerClient.PollOnceSubmitConfigSource(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SubmitConfigSourceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SubmitConfigSourceAsync</summary>
        public async Task SubmitConfigSourceAsync()
        {
            // Snippet: SubmitConfigSourceAsync(string, ConfigSource, bool, CallSettings)
            // Additional: SubmitConfigSourceAsync(string, ConfigSource, bool, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string serviceName = "";
            ConfigSource configSource = new ConfigSource();
            bool validateOnly = false;
            // Make the request
            Operation<SubmitConfigSourceResponse, OperationMetadata> response = await serviceManagerClient.SubmitConfigSourceAsync(serviceName, configSource, validateOnly);

            // Poll until the returned long-running operation is complete
            Operation<SubmitConfigSourceResponse, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            SubmitConfigSourceResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<SubmitConfigSourceResponse, OperationMetadata> retrievedResponse = await serviceManagerClient.PollOnceSubmitConfigSourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                SubmitConfigSourceResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListServiceRollouts</summary>
        public void ListServiceRolloutsRequestObject()
        {
            // Snippet: ListServiceRollouts(ListServiceRolloutsRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            ListServiceRolloutsRequest request = new ListServiceRolloutsRequest
            {
                ServiceName = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListServiceRolloutsResponse, Rollout> response = serviceManagerClient.ListServiceRollouts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceRolloutsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceRolloutsAsync</summary>
        public async Task ListServiceRolloutsRequestObjectAsync()
        {
            // Snippet: ListServiceRolloutsAsync(ListServiceRolloutsRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceRolloutsRequest request = new ListServiceRolloutsRequest
            {
                ServiceName = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListServiceRolloutsResponse, Rollout> response = serviceManagerClient.ListServiceRolloutsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rollout item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceRolloutsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceRollouts</summary>
        public void ListServiceRollouts()
        {
            // Snippet: ListServiceRollouts(string, string, string, int?, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            string serviceName = "";
            string filter = "";
            // Make the request
            PagedEnumerable<ListServiceRolloutsResponse, Rollout> response = serviceManagerClient.ListServiceRollouts(serviceName, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Rollout item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceRolloutsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceRolloutsAsync</summary>
        public async Task ListServiceRolloutsAsync()
        {
            // Snippet: ListServiceRolloutsAsync(string, string, string, int?, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string serviceName = "";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListServiceRolloutsResponse, Rollout> response = serviceManagerClient.ListServiceRolloutsAsync(serviceName, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Rollout item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceRolloutsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Rollout item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Rollout> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Rollout item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetServiceRollout</summary>
        public void GetServiceRolloutRequestObject()
        {
            // Snippet: GetServiceRollout(GetServiceRolloutRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            GetServiceRolloutRequest request = new GetServiceRolloutRequest
            {
                ServiceName = "",
                RolloutId = "",
            };
            // Make the request
            Rollout response = serviceManagerClient.GetServiceRollout(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceRolloutAsync</summary>
        public async Task GetServiceRolloutRequestObjectAsync()
        {
            // Snippet: GetServiceRolloutAsync(GetServiceRolloutRequest, CallSettings)
            // Additional: GetServiceRolloutAsync(GetServiceRolloutRequest, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceRolloutRequest request = new GetServiceRolloutRequest
            {
                ServiceName = "",
                RolloutId = "",
            };
            // Make the request
            Rollout response = await serviceManagerClient.GetServiceRolloutAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceRollout</summary>
        public void GetServiceRollout()
        {
            // Snippet: GetServiceRollout(string, string, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            string serviceName = "";
            string rolloutId = "";
            // Make the request
            Rollout response = serviceManagerClient.GetServiceRollout(serviceName, rolloutId);
            // End snippet
        }

        /// <summary>Snippet for GetServiceRolloutAsync</summary>
        public async Task GetServiceRolloutAsync()
        {
            // Snippet: GetServiceRolloutAsync(string, string, CallSettings)
            // Additional: GetServiceRolloutAsync(string, string, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string serviceName = "";
            string rolloutId = "";
            // Make the request
            Rollout response = await serviceManagerClient.GetServiceRolloutAsync(serviceName, rolloutId);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceRollout</summary>
        public void CreateServiceRolloutRequestObject()
        {
            // Snippet: CreateServiceRollout(CreateServiceRolloutRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            CreateServiceRolloutRequest request = new CreateServiceRolloutRequest
            {
                ServiceName = "",
                Rollout = new Rollout(),
            };
            // Make the request
            Operation<Rollout, OperationMetadata> response = serviceManagerClient.CreateServiceRollout(request);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = serviceManagerClient.PollOnceCreateServiceRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceRolloutAsync</summary>
        public async Task CreateServiceRolloutRequestObjectAsync()
        {
            // Snippet: CreateServiceRolloutAsync(CreateServiceRolloutRequest, CallSettings)
            // Additional: CreateServiceRolloutAsync(CreateServiceRolloutRequest, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceRolloutRequest request = new CreateServiceRolloutRequest
            {
                ServiceName = "",
                Rollout = new Rollout(),
            };
            // Make the request
            Operation<Rollout, OperationMetadata> response = await serviceManagerClient.CreateServiceRolloutAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await serviceManagerClient.PollOnceCreateServiceRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceRollout</summary>
        public void CreateServiceRollout()
        {
            // Snippet: CreateServiceRollout(string, Rollout, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            string serviceName = "";
            Rollout rollout = new Rollout();
            // Make the request
            Operation<Rollout, OperationMetadata> response = serviceManagerClient.CreateServiceRollout(serviceName, rollout);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = serviceManagerClient.PollOnceCreateServiceRollout(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceRolloutAsync</summary>
        public async Task CreateServiceRolloutAsync()
        {
            // Snippet: CreateServiceRolloutAsync(string, Rollout, CallSettings)
            // Additional: CreateServiceRolloutAsync(string, Rollout, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            string serviceName = "";
            Rollout rollout = new Rollout();
            // Make the request
            Operation<Rollout, OperationMetadata> response = await serviceManagerClient.CreateServiceRolloutAsync(serviceName, rollout);

            // Poll until the returned long-running operation is complete
            Operation<Rollout, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Rollout result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Rollout, OperationMetadata> retrievedResponse = await serviceManagerClient.PollOnceCreateServiceRolloutAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Rollout retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GenerateConfigReport</summary>
        public void GenerateConfigReportRequestObject()
        {
            // Snippet: GenerateConfigReport(GenerateConfigReportRequest, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            GenerateConfigReportRequest request = new GenerateConfigReportRequest
            {
                NewConfig = new Any(),
                OldConfig = new Any(),
            };
            // Make the request
            GenerateConfigReportResponse response = serviceManagerClient.GenerateConfigReport(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateConfigReportAsync</summary>
        public async Task GenerateConfigReportRequestObjectAsync()
        {
            // Snippet: GenerateConfigReportAsync(GenerateConfigReportRequest, CallSettings)
            // Additional: GenerateConfigReportAsync(GenerateConfigReportRequest, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            GenerateConfigReportRequest request = new GenerateConfigReportRequest
            {
                NewConfig = new Any(),
                OldConfig = new Any(),
            };
            // Make the request
            GenerateConfigReportResponse response = await serviceManagerClient.GenerateConfigReportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateConfigReport</summary>
        public void GenerateConfigReport()
        {
            // Snippet: GenerateConfigReport(Any, Any, CallSettings)
            // Create client
            ServiceManagerClient serviceManagerClient = ServiceManagerClient.Create();
            // Initialize request argument(s)
            Any newConfig = new Any();
            Any oldConfig = new Any();
            // Make the request
            GenerateConfigReportResponse response = serviceManagerClient.GenerateConfigReport(newConfig, oldConfig);
            // End snippet
        }

        /// <summary>Snippet for GenerateConfigReportAsync</summary>
        public async Task GenerateConfigReportAsync()
        {
            // Snippet: GenerateConfigReportAsync(Any, Any, CallSettings)
            // Additional: GenerateConfigReportAsync(Any, Any, CancellationToken)
            // Create client
            ServiceManagerClient serviceManagerClient = await ServiceManagerClient.CreateAsync();
            // Initialize request argument(s)
            Any newConfig = new Any();
            Any oldConfig = new Any();
            // Make the request
            GenerateConfigReportResponse response = await serviceManagerClient.GenerateConfigReportAsync(newConfig, oldConfig);
            // End snippet
        }
    }
}
