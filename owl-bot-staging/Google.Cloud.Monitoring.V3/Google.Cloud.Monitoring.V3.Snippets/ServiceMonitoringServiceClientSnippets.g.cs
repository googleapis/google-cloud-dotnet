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
    using Google.Cloud.Monitoring.V3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedServiceMonitoringServiceClientSnippets
    {
        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceRequestObject()
        {
            // Snippet: CreateService(CreateServiceRequest, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
                ServiceId = "",
            };
            // Make the request
            Service response = serviceMonitoringServiceClient.CreateService(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceRequestObjectAsync()
        {
            // Snippet: CreateServiceAsync(CreateServiceRequest, CallSettings)
            // Additional: CreateServiceAsync(CreateServiceRequest, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Service = new Service(),
                ServiceId = "",
            };
            // Make the request
            Service response = await serviceMonitoringServiceClient.CreateServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateService()
        {
            // Snippet: CreateService(string, Service, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Service service = new Service();
            // Make the request
            Service response = serviceMonitoringServiceClient.CreateService(parent, service);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceAsync()
        {
            // Snippet: CreateServiceAsync(string, Service, CallSettings)
            // Additional: CreateServiceAsync(string, Service, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Service service = new Service();
            // Make the request
            Service response = await serviceMonitoringServiceClient.CreateServiceAsync(parent, service);
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceResourceNames1()
        {
            // Snippet: CreateService(ProjectName, Service, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Service service = new Service();
            // Make the request
            Service response = serviceMonitoringServiceClient.CreateService(parent, service);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceResourceNames1Async()
        {
            // Snippet: CreateServiceAsync(ProjectName, Service, CallSettings)
            // Additional: CreateServiceAsync(ProjectName, Service, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Service service = new Service();
            // Make the request
            Service response = await serviceMonitoringServiceClient.CreateServiceAsync(parent, service);
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceResourceNames2()
        {
            // Snippet: CreateService(OrganizationName, Service, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            Service service = new Service();
            // Make the request
            Service response = serviceMonitoringServiceClient.CreateService(parent, service);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceResourceNames2Async()
        {
            // Snippet: CreateServiceAsync(OrganizationName, Service, CallSettings)
            // Additional: CreateServiceAsync(OrganizationName, Service, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            Service service = new Service();
            // Make the request
            Service response = await serviceMonitoringServiceClient.CreateServiceAsync(parent, service);
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceResourceNames3()
        {
            // Snippet: CreateService(FolderName, Service, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            Service service = new Service();
            // Make the request
            Service response = serviceMonitoringServiceClient.CreateService(parent, service);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceResourceNames3Async()
        {
            // Snippet: CreateServiceAsync(FolderName, Service, CallSettings)
            // Additional: CreateServiceAsync(FolderName, Service, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            Service service = new Service();
            // Make the request
            Service response = await serviceMonitoringServiceClient.CreateServiceAsync(parent, service);
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceResourceNames4()
        {
            // Snippet: CreateService(IResourceName, Service, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            Service service = new Service();
            // Make the request
            Service response = serviceMonitoringServiceClient.CreateService(parent, service);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceResourceNames4Async()
        {
            // Snippet: CreateServiceAsync(IResourceName, Service, CallSettings)
            // Additional: CreateServiceAsync(IResourceName, Service, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            Service service = new Service();
            // Make the request
            Service response = await serviceMonitoringServiceClient.CreateServiceAsync(parent, service);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceRequestObject()
        {
            // Snippet: GetService(GetServiceRequest, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            // Make the request
            Service response = serviceMonitoringServiceClient.GetService(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceRequestObjectAsync()
        {
            // Snippet: GetServiceAsync(GetServiceRequest, CallSettings)
            // Additional: GetServiceAsync(GetServiceRequest, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            // Make the request
            Service response = await serviceMonitoringServiceClient.GetServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetService()
        {
            // Snippet: GetService(string, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/services/[SERVICE]";
            // Make the request
            Service response = serviceMonitoringServiceClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceAsync()
        {
            // Snippet: GetServiceAsync(string, CallSettings)
            // Additional: GetServiceAsync(string, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/services/[SERVICE]";
            // Make the request
            Service response = await serviceMonitoringServiceClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceResourceNames1()
        {
            // Snippet: GetService(ServiceName, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]");
            // Make the request
            Service response = serviceMonitoringServiceClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceResourceNames1Async()
        {
            // Snippet: GetServiceAsync(ServiceName, CallSettings)
            // Additional: GetServiceAsync(ServiceName, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]");
            // Make the request
            Service response = await serviceMonitoringServiceClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceResourceNames2()
        {
            // Snippet: GetService(IResourceName, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Service response = serviceMonitoringServiceClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceResourceNames2Async()
        {
            // Snippet: GetServiceAsync(IResourceName, CallSettings)
            // Additional: GetServiceAsync(IResourceName, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Service response = await serviceMonitoringServiceClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesRequestObject()
        {
            // Snippet: ListServices(ListServicesRequest, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = serviceMonitoringServiceClient.ListServices(request);

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

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesRequestObjectAsync()
        {
            // Snippet: ListServicesAsync(ListServicesRequest, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = serviceMonitoringServiceClient.ListServicesAsync(request);

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

        /// <summary>Snippet for ListServices</summary>
        public void ListServices()
        {
            // Snippet: ListServices(string, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = serviceMonitoringServiceClient.ListServices(parent);

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

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesAsync()
        {
            // Snippet: ListServicesAsync(string, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = serviceMonitoringServiceClient.ListServicesAsync(parent);

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

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesResourceNames1()
        {
            // Snippet: ListServices(ProjectName, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = serviceMonitoringServiceClient.ListServices(parent);

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

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesResourceNames1Async()
        {
            // Snippet: ListServicesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = serviceMonitoringServiceClient.ListServicesAsync(parent);

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

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesResourceNames2()
        {
            // Snippet: ListServices(OrganizationName, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = serviceMonitoringServiceClient.ListServices(parent);

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

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesResourceNames2Async()
        {
            // Snippet: ListServicesAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = serviceMonitoringServiceClient.ListServicesAsync(parent);

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

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesResourceNames3()
        {
            // Snippet: ListServices(FolderName, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = serviceMonitoringServiceClient.ListServices(parent);

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

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesResourceNames3Async()
        {
            // Snippet: ListServicesAsync(FolderName, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = serviceMonitoringServiceClient.ListServicesAsync(parent);

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

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesResourceNames4()
        {
            // Snippet: ListServices(IResourceName, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = serviceMonitoringServiceClient.ListServices(parent);

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

        /// <summary>Snippet for ListServicesAsync</summary>
        public async Task ListServicesResourceNames4Async()
        {
            // Snippet: ListServicesAsync(IResourceName, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = serviceMonitoringServiceClient.ListServicesAsync(parent);

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

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateServiceRequestObject()
        {
            // Snippet: UpdateService(UpdateServiceRequest, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Service response = serviceMonitoringServiceClient.UpdateService(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateServiceRequestObjectAsync()
        {
            // Snippet: UpdateServiceAsync(UpdateServiceRequest, CallSettings)
            // Additional: UpdateServiceAsync(UpdateServiceRequest, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Service response = await serviceMonitoringServiceClient.UpdateServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateService()
        {
            // Snippet: UpdateService(Service, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            Service service = new Service();
            // Make the request
            Service response = serviceMonitoringServiceClient.UpdateService(service);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateServiceAsync()
        {
            // Snippet: UpdateServiceAsync(Service, CallSettings)
            // Additional: UpdateServiceAsync(Service, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            Service service = new Service();
            // Make the request
            Service response = await serviceMonitoringServiceClient.UpdateServiceAsync(service);
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteServiceRequestObject()
        {
            // Snippet: DeleteService(DeleteServiceRequest, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            // Make the request
            serviceMonitoringServiceClient.DeleteService(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceRequestObjectAsync()
        {
            // Snippet: DeleteServiceAsync(DeleteServiceRequest, CallSettings)
            // Additional: DeleteServiceAsync(DeleteServiceRequest, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
            };
            // Make the request
            await serviceMonitoringServiceClient.DeleteServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteService()
        {
            // Snippet: DeleteService(string, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/services/[SERVICE]";
            // Make the request
            serviceMonitoringServiceClient.DeleteService(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceAsync()
        {
            // Snippet: DeleteServiceAsync(string, CallSettings)
            // Additional: DeleteServiceAsync(string, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/services/[SERVICE]";
            // Make the request
            await serviceMonitoringServiceClient.DeleteServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteServiceResourceNames1()
        {
            // Snippet: DeleteService(ServiceName, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]");
            // Make the request
            serviceMonitoringServiceClient.DeleteService(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceResourceNames1Async()
        {
            // Snippet: DeleteServiceAsync(ServiceName, CallSettings)
            // Additional: DeleteServiceAsync(ServiceName, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]");
            // Make the request
            await serviceMonitoringServiceClient.DeleteServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteServiceResourceNames2()
        {
            // Snippet: DeleteService(IResourceName, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            serviceMonitoringServiceClient.DeleteService(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceResourceNames2Async()
        {
            // Snippet: DeleteServiceAsync(IResourceName, CallSettings)
            // Additional: DeleteServiceAsync(IResourceName, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            await serviceMonitoringServiceClient.DeleteServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLevelObjective</summary>
        public void CreateServiceLevelObjectiveRequestObject()
        {
            // Snippet: CreateServiceLevelObjective(CreateServiceLevelObjectiveRequest, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
                ServiceLevelObjectiveId = "",
            };
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.CreateServiceLevelObjective(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLevelObjectiveAsync</summary>
        public async Task CreateServiceLevelObjectiveRequestObjectAsync()
        {
            // Snippet: CreateServiceLevelObjectiveAsync(CreateServiceLevelObjectiveRequest, CallSettings)
            // Additional: CreateServiceLevelObjectiveAsync(CreateServiceLevelObjectiveRequest, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceLevelObjectiveRequest request = new CreateServiceLevelObjectiveRequest
            {
                ParentAsServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                ServiceLevelObjective = new ServiceLevelObjective(),
                ServiceLevelObjectiveId = "",
            };
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.CreateServiceLevelObjectiveAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLevelObjective</summary>
        public void CreateServiceLevelObjective()
        {
            // Snippet: CreateServiceLevelObjective(string, ServiceLevelObjective, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/services/[SERVICE]";
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.CreateServiceLevelObjective(parent, serviceLevelObjective);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLevelObjectiveAsync</summary>
        public async Task CreateServiceLevelObjectiveAsync()
        {
            // Snippet: CreateServiceLevelObjectiveAsync(string, ServiceLevelObjective, CallSettings)
            // Additional: CreateServiceLevelObjectiveAsync(string, ServiceLevelObjective, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/services/[SERVICE]";
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.CreateServiceLevelObjectiveAsync(parent, serviceLevelObjective);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLevelObjective</summary>
        public void CreateServiceLevelObjectiveResourceNames1()
        {
            // Snippet: CreateServiceLevelObjective(ServiceName, ServiceLevelObjective, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]");
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.CreateServiceLevelObjective(parent, serviceLevelObjective);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLevelObjectiveAsync</summary>
        public async Task CreateServiceLevelObjectiveResourceNames1Async()
        {
            // Snippet: CreateServiceLevelObjectiveAsync(ServiceName, ServiceLevelObjective, CallSettings)
            // Additional: CreateServiceLevelObjectiveAsync(ServiceName, ServiceLevelObjective, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]");
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.CreateServiceLevelObjectiveAsync(parent, serviceLevelObjective);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLevelObjective</summary>
        public void CreateServiceLevelObjectiveResourceNames2()
        {
            // Snippet: CreateServiceLevelObjective(IResourceName, ServiceLevelObjective, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.CreateServiceLevelObjective(parent, serviceLevelObjective);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceLevelObjectiveAsync</summary>
        public async Task CreateServiceLevelObjectiveResourceNames2Async()
        {
            // Snippet: CreateServiceLevelObjectiveAsync(IResourceName, ServiceLevelObjective, CallSettings)
            // Additional: CreateServiceLevelObjectiveAsync(IResourceName, ServiceLevelObjective, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.CreateServiceLevelObjectiveAsync(parent, serviceLevelObjective);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLevelObjective</summary>
        public void GetServiceLevelObjectiveRequestObject()
        {
            // Snippet: GetServiceLevelObjective(GetServiceLevelObjectiveRequest, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                View = ServiceLevelObjective.Types.View.Unspecified,
            };
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.GetServiceLevelObjective(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLevelObjectiveAsync</summary>
        public async Task GetServiceLevelObjectiveRequestObjectAsync()
        {
            // Snippet: GetServiceLevelObjectiveAsync(GetServiceLevelObjectiveRequest, CallSettings)
            // Additional: GetServiceLevelObjectiveAsync(GetServiceLevelObjectiveRequest, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceLevelObjectiveRequest request = new GetServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
                View = ServiceLevelObjective.Types.View.Unspecified,
            };
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.GetServiceLevelObjectiveAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLevelObjective</summary>
        public void GetServiceLevelObjective()
        {
            // Snippet: GetServiceLevelObjective(string, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/services/[SERVICE]/serviceLevelObjectives/[SERVICE_LEVEL_OBJECTIVE]";
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.GetServiceLevelObjective(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLevelObjectiveAsync</summary>
        public async Task GetServiceLevelObjectiveAsync()
        {
            // Snippet: GetServiceLevelObjectiveAsync(string, CallSettings)
            // Additional: GetServiceLevelObjectiveAsync(string, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/services/[SERVICE]/serviceLevelObjectives/[SERVICE_LEVEL_OBJECTIVE]";
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.GetServiceLevelObjectiveAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLevelObjective</summary>
        public void GetServiceLevelObjectiveResourceNames1()
        {
            // Snippet: GetServiceLevelObjective(ServiceLevelObjectiveName, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceLevelObjectiveName name = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]");
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.GetServiceLevelObjective(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLevelObjectiveAsync</summary>
        public async Task GetServiceLevelObjectiveResourceNames1Async()
        {
            // Snippet: GetServiceLevelObjectiveAsync(ServiceLevelObjectiveName, CallSettings)
            // Additional: GetServiceLevelObjectiveAsync(ServiceLevelObjectiveName, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceLevelObjectiveName name = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]");
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.GetServiceLevelObjectiveAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLevelObjective</summary>
        public void GetServiceLevelObjectiveResourceNames2()
        {
            // Snippet: GetServiceLevelObjective(IResourceName, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.GetServiceLevelObjective(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceLevelObjectiveAsync</summary>
        public async Task GetServiceLevelObjectiveResourceNames2Async()
        {
            // Snippet: GetServiceLevelObjectiveAsync(IResourceName, CallSettings)
            // Additional: GetServiceLevelObjectiveAsync(IResourceName, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.GetServiceLevelObjectiveAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListServiceLevelObjectives</summary>
        public void ListServiceLevelObjectivesRequestObject()
        {
            // Snippet: ListServiceLevelObjectives(ListServiceLevelObjectivesRequest, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ListServiceLevelObjectivesRequest request = new ListServiceLevelObjectivesRequest
            {
                ParentAsServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                Filter = "",
                View = ServiceLevelObjective.Types.View.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> response = serviceMonitoringServiceClient.ListServiceLevelObjectives(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLevelObjectivesAsync</summary>
        public async Task ListServiceLevelObjectivesRequestObjectAsync()
        {
            // Snippet: ListServiceLevelObjectivesAsync(ListServiceLevelObjectivesRequest, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListServiceLevelObjectivesRequest request = new ListServiceLevelObjectivesRequest
            {
                ParentAsServiceName = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]"),
                Filter = "",
                View = ServiceLevelObjective.Types.View.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> response = serviceMonitoringServiceClient.ListServiceLevelObjectivesAsync(request);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLevelObjectives</summary>
        public void ListServiceLevelObjectives()
        {
            // Snippet: ListServiceLevelObjectives(string, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/services/[SERVICE]";
            // Make the request
            PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> response = serviceMonitoringServiceClient.ListServiceLevelObjectives(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLevelObjectivesAsync</summary>
        public async Task ListServiceLevelObjectivesAsync()
        {
            // Snippet: ListServiceLevelObjectivesAsync(string, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/services/[SERVICE]";
            // Make the request
            PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> response = serviceMonitoringServiceClient.ListServiceLevelObjectivesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLevelObjectives</summary>
        public void ListServiceLevelObjectivesResourceNames1()
        {
            // Snippet: ListServiceLevelObjectives(ServiceName, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]");
            // Make the request
            PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> response = serviceMonitoringServiceClient.ListServiceLevelObjectives(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLevelObjectivesAsync</summary>
        public async Task ListServiceLevelObjectivesResourceNames1Async()
        {
            // Snippet: ListServiceLevelObjectivesAsync(ServiceName, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectService("[PROJECT]", "[SERVICE]");
            // Make the request
            PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> response = serviceMonitoringServiceClient.ListServiceLevelObjectivesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLevelObjectives</summary>
        public void ListServiceLevelObjectivesResourceNames2()
        {
            // Snippet: ListServiceLevelObjectives(IResourceName, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> response = serviceMonitoringServiceClient.ListServiceLevelObjectives(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServiceLevelObjectivesAsync</summary>
        public async Task ListServiceLevelObjectivesResourceNames2Async()
        {
            // Snippet: ListServiceLevelObjectivesAsync(IResourceName, string, int?, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName parent = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListServiceLevelObjectivesResponse, ServiceLevelObjective> response = serviceMonitoringServiceClient.ListServiceLevelObjectivesAsync(parent);

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
                    // Do something with each item
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
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceLevelObjective</summary>
        public void UpdateServiceLevelObjectiveRequestObject()
        {
            // Snippet: UpdateServiceLevelObjective(UpdateServiceLevelObjectiveRequest, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            UpdateServiceLevelObjectiveRequest request = new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = new ServiceLevelObjective(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.UpdateServiceLevelObjective(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceLevelObjectiveAsync</summary>
        public async Task UpdateServiceLevelObjectiveRequestObjectAsync()
        {
            // Snippet: UpdateServiceLevelObjectiveAsync(UpdateServiceLevelObjectiveRequest, CallSettings)
            // Additional: UpdateServiceLevelObjectiveAsync(UpdateServiceLevelObjectiveRequest, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServiceLevelObjectiveRequest request = new UpdateServiceLevelObjectiveRequest
            {
                ServiceLevelObjective = new ServiceLevelObjective(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.UpdateServiceLevelObjectiveAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceLevelObjective</summary>
        public void UpdateServiceLevelObjective()
        {
            // Snippet: UpdateServiceLevelObjective(ServiceLevelObjective, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            // Make the request
            ServiceLevelObjective response = serviceMonitoringServiceClient.UpdateServiceLevelObjective(serviceLevelObjective);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceLevelObjectiveAsync</summary>
        public async Task UpdateServiceLevelObjectiveAsync()
        {
            // Snippet: UpdateServiceLevelObjectiveAsync(ServiceLevelObjective, CallSettings)
            // Additional: UpdateServiceLevelObjectiveAsync(ServiceLevelObjective, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceLevelObjective serviceLevelObjective = new ServiceLevelObjective();
            // Make the request
            ServiceLevelObjective response = await serviceMonitoringServiceClient.UpdateServiceLevelObjectiveAsync(serviceLevelObjective);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLevelObjective</summary>
        public void DeleteServiceLevelObjectiveRequestObject()
        {
            // Snippet: DeleteServiceLevelObjective(DeleteServiceLevelObjectiveRequest, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            // Make the request
            serviceMonitoringServiceClient.DeleteServiceLevelObjective(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLevelObjectiveAsync</summary>
        public async Task DeleteServiceLevelObjectiveRequestObjectAsync()
        {
            // Snippet: DeleteServiceLevelObjectiveAsync(DeleteServiceLevelObjectiveRequest, CallSettings)
            // Additional: DeleteServiceLevelObjectiveAsync(DeleteServiceLevelObjectiveRequest, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceLevelObjectiveRequest request = new DeleteServiceLevelObjectiveRequest
            {
                ServiceLevelObjectiveName = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]"),
            };
            // Make the request
            await serviceMonitoringServiceClient.DeleteServiceLevelObjectiveAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLevelObjective</summary>
        public void DeleteServiceLevelObjective()
        {
            // Snippet: DeleteServiceLevelObjective(string, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/services/[SERVICE]/serviceLevelObjectives/[SERVICE_LEVEL_OBJECTIVE]";
            // Make the request
            serviceMonitoringServiceClient.DeleteServiceLevelObjective(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLevelObjectiveAsync</summary>
        public async Task DeleteServiceLevelObjectiveAsync()
        {
            // Snippet: DeleteServiceLevelObjectiveAsync(string, CallSettings)
            // Additional: DeleteServiceLevelObjectiveAsync(string, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/services/[SERVICE]/serviceLevelObjectives/[SERVICE_LEVEL_OBJECTIVE]";
            // Make the request
            await serviceMonitoringServiceClient.DeleteServiceLevelObjectiveAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLevelObjective</summary>
        public void DeleteServiceLevelObjectiveResourceNames1()
        {
            // Snippet: DeleteServiceLevelObjective(ServiceLevelObjectiveName, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            ServiceLevelObjectiveName name = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]");
            // Make the request
            serviceMonitoringServiceClient.DeleteServiceLevelObjective(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLevelObjectiveAsync</summary>
        public async Task DeleteServiceLevelObjectiveResourceNames1Async()
        {
            // Snippet: DeleteServiceLevelObjectiveAsync(ServiceLevelObjectiveName, CallSettings)
            // Additional: DeleteServiceLevelObjectiveAsync(ServiceLevelObjectiveName, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceLevelObjectiveName name = ServiceLevelObjectiveName.FromProjectServiceServiceLevelObjective("[PROJECT]", "[SERVICE]", "[SERVICE_LEVEL_OBJECTIVE]");
            // Make the request
            await serviceMonitoringServiceClient.DeleteServiceLevelObjectiveAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLevelObjective</summary>
        public void DeleteServiceLevelObjectiveResourceNames2()
        {
            // Snippet: DeleteServiceLevelObjective(IResourceName, CallSettings)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = ServiceMonitoringServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            serviceMonitoringServiceClient.DeleteServiceLevelObjective(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceLevelObjectiveAsync</summary>
        public async Task DeleteServiceLevelObjectiveResourceNames2Async()
        {
            // Snippet: DeleteServiceLevelObjectiveAsync(IResourceName, CallSettings)
            // Additional: DeleteServiceLevelObjectiveAsync(IResourceName, CancellationToken)
            // Create client
            ServiceMonitoringServiceClient serviceMonitoringServiceClient = await ServiceMonitoringServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            await serviceMonitoringServiceClient.DeleteServiceLevelObjectiveAsync(name);
            // End snippet
        }
    }
}
