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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using gcrv = Google.Cloud.Run.V2;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedServicesClientSnippets
    {
        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceRequestObject()
        {
            // Snippet: CreateService(CreateServiceRequest, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            gcrv::CreateServiceRequest request = new gcrv::CreateServiceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Service = new gcrv::Service(),
                ServiceId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = servicesClient.CreateService(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = servicesClient.PollOnceCreateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceRequestObjectAsync()
        {
            // Snippet: CreateServiceAsync(CreateServiceRequest, CallSettings)
            // Additional: CreateServiceAsync(CreateServiceRequest, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::CreateServiceRequest request = new gcrv::CreateServiceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Service = new gcrv::Service(),
                ServiceId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = await servicesClient.CreateServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = await servicesClient.PollOnceCreateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateService()
        {
            // Snippet: CreateService(string, Service, string, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcrv::Service service = new gcrv::Service();
            string serviceId = "";
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = servicesClient.CreateService(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = servicesClient.PollOnceCreateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceAsync()
        {
            // Snippet: CreateServiceAsync(string, Service, string, CallSettings)
            // Additional: CreateServiceAsync(string, Service, string, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            gcrv::Service service = new gcrv::Service();
            string serviceId = "";
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = await servicesClient.CreateServiceAsync(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = await servicesClient.PollOnceCreateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceResourceNames()
        {
            // Snippet: CreateService(LocationName, Service, string, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcrv::Service service = new gcrv::Service();
            string serviceId = "";
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = servicesClient.CreateService(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = servicesClient.PollOnceCreateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceResourceNamesAsync()
        {
            // Snippet: CreateServiceAsync(LocationName, Service, string, CallSettings)
            // Additional: CreateServiceAsync(LocationName, Service, string, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            gcrv::Service service = new gcrv::Service();
            string serviceId = "";
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = await servicesClient.CreateServiceAsync(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = await servicesClient.PollOnceCreateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceRequestObject()
        {
            // Snippet: GetService(GetServiceRequest, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            gcrv::GetServiceRequest request = new gcrv::GetServiceRequest
            {
                ServiceName = gcrv::ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            // Make the request
            gcrv::Service response = servicesClient.GetService(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceRequestObjectAsync()
        {
            // Snippet: GetServiceAsync(GetServiceRequest, CallSettings)
            // Additional: GetServiceAsync(GetServiceRequest, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::GetServiceRequest request = new gcrv::GetServiceRequest
            {
                ServiceName = gcrv::ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
            };
            // Make the request
            gcrv::Service response = await servicesClient.GetServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetService()
        {
            // Snippet: GetService(string, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            gcrv::Service response = servicesClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceAsync()
        {
            // Snippet: GetServiceAsync(string, CallSettings)
            // Additional: GetServiceAsync(string, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            gcrv::Service response = await servicesClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceResourceNames()
        {
            // Snippet: GetService(ServiceName, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            gcrv::ServiceName name = gcrv::ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            gcrv::Service response = servicesClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceResourceNamesAsync()
        {
            // Snippet: GetServiceAsync(ServiceName, CallSettings)
            // Additional: GetServiceAsync(ServiceName, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::ServiceName name = gcrv::ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            gcrv::Service response = await servicesClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesRequestObject()
        {
            // Snippet: ListServices(ListServicesRequest, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            gcrv::ListServicesRequest request = new gcrv::ListServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<gcrv::ListServicesResponse, gcrv::Service> response = servicesClient.ListServices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Service item in singlePage)
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
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::ListServicesRequest request = new gcrv::ListServicesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<gcrv::ListServicesResponse, gcrv::Service> response = servicesClient.ListServicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcrv::Service item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcrv::ListServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Service item in singlePage)
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
            // Snippet: ListServices(string, string, int?, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<gcrv::ListServicesResponse, gcrv::Service> response = servicesClient.ListServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Service item in singlePage)
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
            // Snippet: ListServicesAsync(string, string, int?, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<gcrv::ListServicesResponse, gcrv::Service> response = servicesClient.ListServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcrv::Service item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcrv::ListServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesResourceNames()
        {
            // Snippet: ListServices(LocationName, string, int?, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<gcrv::ListServicesResponse, gcrv::Service> response = servicesClient.ListServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcrv::Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcrv::ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Service> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesResourceNamesAsync()
        {
            // Snippet: ListServicesAsync(LocationName, string, int?, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<gcrv::ListServicesResponse, gcrv::Service> response = servicesClient.ListServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcrv::Service item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcrv::ListServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcrv::Service item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcrv::Service> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcrv::Service item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateServiceRequestObject()
        {
            // Snippet: UpdateService(UpdateServiceRequest, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            gcrv::UpdateServiceRequest request = new gcrv::UpdateServiceRequest
            {
                Service = new gcrv::Service(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = servicesClient.UpdateService(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = servicesClient.PollOnceUpdateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateServiceRequestObjectAsync()
        {
            // Snippet: UpdateServiceAsync(UpdateServiceRequest, CallSettings)
            // Additional: UpdateServiceAsync(UpdateServiceRequest, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::UpdateServiceRequest request = new gcrv::UpdateServiceRequest
            {
                Service = new gcrv::Service(),
                UpdateMask = new FieldMask(),
                ValidateOnly = false,
                AllowMissing = false,
            };
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = await servicesClient.UpdateServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = await servicesClient.PollOnceUpdateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateService1()
        {
            // Snippet: UpdateService(Service, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            gcrv::Service service = new gcrv::Service();
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = servicesClient.UpdateService(service);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = servicesClient.PollOnceUpdateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateService1Async()
        {
            // Snippet: UpdateServiceAsync(Service, CallSettings)
            // Additional: UpdateServiceAsync(Service, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::Service service = new gcrv::Service();
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = await servicesClient.UpdateServiceAsync(service);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = await servicesClient.PollOnceUpdateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateService2()
        {
            // Snippet: UpdateService(Service, FieldMask, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            gcrv::Service service = new gcrv::Service();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = servicesClient.UpdateService(service, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = servicesClient.PollOnceUpdateService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateService2Async()
        {
            // Snippet: UpdateServiceAsync(Service, FieldMask, CallSettings)
            // Additional: UpdateServiceAsync(Service, FieldMask, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::Service service = new gcrv::Service();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = await servicesClient.UpdateServiceAsync(service, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = await servicesClient.PollOnceUpdateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteServiceRequestObject()
        {
            // Snippet: DeleteService(DeleteServiceRequest, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            gcrv::DeleteServiceRequest request = new gcrv::DeleteServiceRequest
            {
                ServiceName = gcrv::ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = servicesClient.DeleteService(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = servicesClient.PollOnceDeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceRequestObjectAsync()
        {
            // Snippet: DeleteServiceAsync(DeleteServiceRequest, CallSettings)
            // Additional: DeleteServiceAsync(DeleteServiceRequest, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::DeleteServiceRequest request = new gcrv::DeleteServiceRequest
            {
                ServiceName = gcrv::ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                ValidateOnly = false,
                Etag = "",
            };
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = await servicesClient.DeleteServiceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = await servicesClient.PollOnceDeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteService()
        {
            // Snippet: DeleteService(string, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = servicesClient.DeleteService(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = servicesClient.PollOnceDeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceAsync()
        {
            // Snippet: DeleteServiceAsync(string, CallSettings)
            // Additional: DeleteServiceAsync(string, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/services/[SERVICE]";
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = await servicesClient.DeleteServiceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = await servicesClient.PollOnceDeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteServiceResourceNames()
        {
            // Snippet: DeleteService(ServiceName, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            gcrv::ServiceName name = gcrv::ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = servicesClient.DeleteService(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = servicesClient.PollOnceDeleteService(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceResourceNamesAsync()
        {
            // Snippet: DeleteServiceAsync(ServiceName, CallSettings)
            // Additional: DeleteServiceAsync(ServiceName, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            gcrv::ServiceName name = gcrv::ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]");
            // Make the request
            Operation<gcrv::Service, gcrv::Service> response = await servicesClient.DeleteServiceAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<gcrv::Service, gcrv::Service> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            gcrv::Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<gcrv::Service, gcrv::Service> retrievedResponse = await servicesClient.PollOnceDeleteServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                gcrv::Service retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = servicesClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await servicesClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = servicesClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await servicesClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            gcrv::ServicesClient servicesClient = gcrv::ServicesClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = servicesClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            gcrv::ServicesClient servicesClient = await gcrv::ServicesClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await servicesClient.TestIamPermissionsAsync(request);
            // End snippet
        }
    }
}
