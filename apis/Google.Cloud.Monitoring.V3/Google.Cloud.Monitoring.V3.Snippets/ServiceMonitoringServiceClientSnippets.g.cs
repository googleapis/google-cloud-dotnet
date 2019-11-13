// Copyright 2019 Google LLC
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

namespace Google.Cloud.Monitoring.V3.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Monitoring.V3;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>Generated snippets</summary>
    public class GeneratedServiceMonitoringServiceClientSnippets
    {
        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceAsync()
        {
            // Snippet: CreateServiceAsync(ProjectName,Service,CallSettings)
            // Additional: CreateServiceAsync(ProjectName,Service,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            Service service = new Service();
            // Make the request
            Service response = await serviceMonitoringServiceClient.CreateServiceAsync(parent, service);
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateService()
        {
            // Snippet: CreateService(ProjectName,Service,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            Service service = new Service();
            // Make the request
            Service response = serviceMonitoringServiceClient.CreateService(parent, service);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceAsync_RequestObject()
        {
            // Snippet: CreateServiceAsync(CreateServiceRequest,CallSettings)
            // Additional: CreateServiceAsync(CreateServiceRequest,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Service = new Service(),
            };
            // Make the request
            Service response = await serviceMonitoringServiceClient.CreateServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateService_RequestObject()
        {
            // Snippet: CreateService(CreateServiceRequest,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Service = new Service(),
            };
            // Make the request
            Service response = serviceMonitoringServiceClient.CreateService(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceAsync()
        {
            // Snippet: GetServiceAsync(ServiceName,CallSettings)
            // Additional: GetServiceAsync(ServiceName,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName name = new ServiceName("[PROJECT]", "[SERVICE]");
            // Make the request
            Service response = await serviceMonitoringServiceClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetService()
        {
            // Snippet: GetService(ServiceName,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceName name = new ServiceName("[PROJECT]", "[SERVICE]");
            // Make the request
            Service response = serviceMonitoringServiceClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceAsync_RequestObject()
        {
            // Snippet: GetServiceAsync(GetServiceRequest,CallSettings)
            // Additional: GetServiceAsync(GetServiceRequest,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            // Make the request
            Service response = await serviceMonitoringServiceClient.GetServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetService_RequestObject()
        {
            // Snippet: GetService(GetServiceRequest,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            // Make the request
            Service response = serviceMonitoringServiceClient.GetService(request);
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesAsync()
        {
            // Snippet: ListServicesAsync(ProjectName,string,int?,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response =
                serviceMonitoringServiceClient.ListServicesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Service item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServices()
        {
            // Snippet: ListServices(ProjectName,string,int?,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = new ProjectName("[PROJECT]");
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response =
                serviceMonitoringServiceClient.ListServices(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesAsync_RequestObject()
        {
            // Snippet: ListServicesAsync(ListServicesRequest,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response =
                serviceMonitoringServiceClient.ListServicesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Service item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServicesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServices_RequestObject()
        {
            // Snippet: ListServices(ListServicesRequest,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response =
                serviceMonitoringServiceClient.ListServices(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Service item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServicesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Service item in page)
                {
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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateServiceAsync()
        {
            // Snippet: UpdateServiceAsync(Service,CallSettings)
            // Additional: UpdateServiceAsync(Service,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            Service service = new Service();
            // Make the request
            Service response = await serviceMonitoringServiceClient.UpdateServiceAsync(service);
            // End snippet
        }

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateService()
        {
            // Snippet: UpdateService(Service,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            Service service = new Service();
            // Make the request
            Service response = serviceMonitoringServiceClient.UpdateService(service);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateServiceAsync_RequestObject()
        {
            // Snippet: UpdateServiceAsync(UpdateServiceRequest,CallSettings)
            // Additional: UpdateServiceAsync(UpdateServiceRequest,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
            };
            // Make the request
            Service response = await serviceMonitoringServiceClient.UpdateServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateService_RequestObject()
        {
            // Snippet: UpdateService(UpdateServiceRequest,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
            };
            // Make the request
            Service response = serviceMonitoringServiceClient.UpdateService(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceAsync()
        {
            // Snippet: DeleteServiceAsync(ServiceName,CallSettings)
            // Additional: DeleteServiceAsync(ServiceName,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName name = new ServiceName("[PROJECT]", "[SERVICE]");
            // Make the request
            await serviceMonitoringServiceClient.DeleteServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteService()
        {
            // Snippet: DeleteService(ServiceName,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceName name = new ServiceName("[PROJECT]", "[SERVICE]");
            // Make the request
            serviceMonitoringServiceClient.DeleteService(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceAsync_RequestObject()
        {
            // Snippet: DeleteServiceAsync(DeleteServiceRequest,CallSettings)
            // Additional: DeleteServiceAsync(DeleteServiceRequest,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            // Make the request
            await serviceMonitoringServiceClient.DeleteServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteService_RequestObject()
        {
            // Snippet: DeleteService(DeleteServiceRequest,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            // Make the request
            serviceMonitoringServiceClient.DeleteService(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLevelObjectiveAsync</summary>
        public async Task CreateServiceLevelObjectiveAsync()
        {
            // Snippet: CreateServiceLevelObjectiveAsync(ServiceName,ServiceLevelObjective,CallSettings)
            // Additional: CreateServiceLevelObjectiveAsync(ServiceName,ServiceLevelObjective,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName parent = new ServiceName("[PROJECT]", "[SERVICE]");
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.CreateServiceLevelObjectiveAsync(parent, serviceLevelObjective);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLevelObjective</summary>
        public void CreateServiceLevelObjective()
        {
            // Snippet: CreateServiceLevelObjective(ServiceName,ServiceLevelObjective,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceName parent = new ServiceName("[PROJECT]", "[SERVICE]");
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.CreateServiceLevelObjective(parent, serviceLevelObjective);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLevelObjectiveAsync</summary>
        public async Task CreateServiceLevelObjectiveAsync_RequestObject()
        {
            // Snippet: CreateServiceLevelObjectiveAsync(CreateServiceLevelObjectiveRequest,CallSettings)
            // Additional: CreateServiceLevelObjectiveAsync(CreateServiceLevelObjectiveRequest,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.CreateServiceLevelObjectiveAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLevelObjective</summary>
        public void CreateServiceLevelObjective_RequestObject()
        {
            // Snippet: CreateServiceLevelObjective(CreateServiceLevelObjectiveRequest,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.CreateServiceLevelObjective(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLevelObjectiveAsync</summary>
        public async Task GetServiceLevelObjectiveAsync()
        {
            // Snippet: GetServiceLevelObjectiveAsync(ServiceLevelObjectiveName,CallSettings)
            // Additional: GetServiceLevelObjectiveAsync(ServiceLevelObjectiveName,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceLevelObjectiveName name = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]");
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.GetServiceLevelObjectiveAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLevelObjective</summary>
        public void GetServiceLevelObjective()
        {
            // Snippet: GetServiceLevelObjective(ServiceLevelObjectiveName,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceLevelObjectiveName name = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]");
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.GetServiceLevelObjective(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLevelObjectiveAsync</summary>
        public async Task GetServiceLevelObjectiveAsync_RequestObject()
        {
            // Snippet: GetServiceLevelObjectiveAsync(GetServiceLevelObjectiveRequest,CallSettings)
            // Additional: GetServiceLevelObjectiveAsync(GetServiceLevelObjectiveRequest,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.GetServiceLevelObjectiveAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLevelObjective</summary>
        public void GetServiceLevelObjective_RequestObject()
        {
            // Snippet: GetServiceLevelObjective(GetServiceLevelObjectiveRequest,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.GetServiceLevelObjective(request);
            // End snippet
        }

        /// <summary>Snippet for ListServiceLevelObjectivesAsync</summary>
        public async Task ListServiceLevelObjectivesAsync()
        {
            // Snippet: ListServiceLevelObjectivesAsync(ServiceName,string,int?,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName parent = new ServiceName("[PROJECT]", "[SERVICE]");
            // Make the request
            PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> response =
                serviceMonitoringServiceClient.ListServiceLevelObjectivesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceLevelObjective item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceLevelObjectivesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceLevelObjective item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceLevelObjective> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceLevelObjective item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLevelObjectives</summary>
        public void ListServiceLevelObjectives()
        {
            // Snippet: ListServiceLevelObjectives(ServiceName,string,int?,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceName parent = new ServiceName("[PROJECT]", "[SERVICE]");
            // Make the request
            PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> response =
                serviceMonitoringServiceClient.ListServiceLevelObjectives(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceLevelObjective item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceLevelObjectivesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceLevelObjective item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceLevelObjective> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceLevelObjective item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLevelObjectivesAsync</summary>
        public async Task ListServiceLevelObjectivesAsync_RequestObject()
        {
            // Snippet: ListServiceLevelObjectivesAsync(ListServiceLevelObjectivesRequest,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceLevelObjectivesRequest request = new ListServiceLevelObjectivesRequest
            {
                ParentAsServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> response =
                serviceMonitoringServiceClient.ListServiceLevelObjectivesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ServiceLevelObjective item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListServiceLevelObjectivesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceLevelObjective item in page)
                {
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceLevelObjective> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceLevelObjective item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLevelObjectives</summary>
        public void ListServiceLevelObjectives_RequestObject()
        {
            // Snippet: ListServiceLevelObjectives(ListServiceLevelObjectivesRequest,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ListServiceLevelObjectivesRequest request = new ListServiceLevelObjectivesRequest
            {
                ParentAsServiceName = new ServiceName("[PROJECT]", "[SERVICE]"),
            };
            // Make the request
            PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> response =
                serviceMonitoringServiceClient.ListServiceLevelObjectives(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ServiceLevelObjective item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListServiceLevelObjectivesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ServiceLevelObjective item in page)
                {
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ServiceLevelObjective> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ServiceLevelObjective item in singlePage)
            {
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceLevelObjectiveAsync</summary>
        public async Task UpdateServiceLevelObjectiveAsync()
        {
            // Snippet: UpdateServiceLevelObjectiveAsync(ServiceLevelObjective,CallSettings)
            // Additional: UpdateServiceLevelObjectiveAsync(ServiceLevelObjective,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.UpdateServiceLevelObjectiveAsync(serviceLevelObjective);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceLevelObjective</summary>
        public void UpdateServiceLevelObjective()
        {
            // Snippet: UpdateServiceLevelObjective(ServiceLevelObjective,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.UpdateServiceLevelObjective(serviceLevelObjective);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceLevelObjectiveAsync</summary>
        public async Task UpdateServiceLevelObjectiveAsync_RequestObject()
        {
            // Snippet: UpdateServiceLevelObjectiveAsync(UpdateServiceLevelObjectiveRequest,CallSettings)
            // Additional: UpdateServiceLevelObjectiveAsync(UpdateServiceLevelObjectiveRequest,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServiceLevelObjectiveRequest request = new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.UpdateServiceLevelObjectiveAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceLevelObjective</summary>
        public void UpdateServiceLevelObjective_RequestObject()
        {
            // Snippet: UpdateServiceLevelObjective(UpdateServiceLevelObjectiveRequest,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            UpdateServiceLevelObjectiveRequest request = new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = new ServiceLevelObjective(),
            };
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.UpdateServiceLevelObjective(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLevelObjectiveAsync</summary>
        public async Task DeleteServiceLevelObjectiveAsync()
        {
            // Snippet: DeleteServiceLevelObjectiveAsync(ServiceLevelObjectiveName,CallSettings)
            // Additional: DeleteServiceLevelObjectiveAsync(ServiceLevelObjectiveName,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceLevelObjectiveName name = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]");
            // Make the request
            await serviceMonitoringServiceClient.DeleteServiceLevelObjectiveAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLevelObjective</summary>
        public void DeleteServiceLevelObjective()
        {
            // Snippet: DeleteServiceLevelObjective(ServiceLevelObjectiveName,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceLevelObjectiveName name = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]");
            // Make the request
            serviceMonitoringServiceClient.DeleteServiceLevelObjective(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLevelObjectiveAsync</summary>
        public async Task DeleteServiceLevelObjectiveAsync_RequestObject()
        {
            // Snippet: DeleteServiceLevelObjectiveAsync(DeleteServiceLevelObjectiveRequest,CallSettings)
            // Additional: DeleteServiceLevelObjectiveAsync(DeleteServiceLevelObjectiveRequest,CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            // Make the request
            await serviceMonitoringServiceClient.DeleteServiceLevelObjectiveAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLevelObjective</summary>
        public void DeleteServiceLevelObjective_RequestObject()
        {
            // Snippet: DeleteServiceLevelObjective(DeleteServiceLevelObjectiveRequest,CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = new ServiceLevelObjectiveName("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            // Make the request
            serviceMonitoringServiceClient.DeleteServiceLevelObjective(request);
            // End snippet
        }

    }
}
