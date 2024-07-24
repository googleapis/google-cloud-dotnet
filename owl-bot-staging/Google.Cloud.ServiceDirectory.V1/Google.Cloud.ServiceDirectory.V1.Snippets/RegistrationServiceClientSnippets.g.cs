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
    using Google.Cloud.Iam.V1;
    using Google.Cloud.ServiceDirectory.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRegistrationServiceClientSnippets
    {
        /// <summary>Snippet for CreateNamespace</summary>
        public void CreateNamespaceRequestObject()
        {
            // Snippet: CreateNamespace(CreateNamespaceRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            CreateNamespaceRequest request = new CreateNamespaceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NamespaceId = "",
                Namespace = new Namespace(),
            };
            // Make the request
            Namespace response = registrationServiceClient.CreateNamespace(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNamespaceAsync</summary>
        public async Task CreateNamespaceRequestObjectAsync()
        {
            // Snippet: CreateNamespaceAsync(CreateNamespaceRequest, CallSettings)
            // Additional: CreateNamespaceAsync(CreateNamespaceRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateNamespaceRequest request = new CreateNamespaceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NamespaceId = "",
                Namespace = new Namespace(),
            };
            // Make the request
            Namespace response = await registrationServiceClient.CreateNamespaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNamespace</summary>
        public void CreateNamespace()
        {
            // Snippet: CreateNamespace(string, Namespace, string, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Namespace @namespace = new Namespace();
            string namespaceId = "";
            // Make the request
            Namespace response = registrationServiceClient.CreateNamespace(parent, @namespace, namespaceId);
            // End snippet
        }

        /// <summary>Snippet for CreateNamespaceAsync</summary>
        public async Task CreateNamespaceAsync()
        {
            // Snippet: CreateNamespaceAsync(string, Namespace, string, CallSettings)
            // Additional: CreateNamespaceAsync(string, Namespace, string, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Namespace @namespace = new Namespace();
            string namespaceId = "";
            // Make the request
            Namespace response = await registrationServiceClient.CreateNamespaceAsync(parent, @namespace, namespaceId);
            // End snippet
        }

        /// <summary>Snippet for CreateNamespace</summary>
        public void CreateNamespaceResourceNames()
        {
            // Snippet: CreateNamespace(LocationName, Namespace, string, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Namespace @namespace = new Namespace();
            string namespaceId = "";
            // Make the request
            Namespace response = registrationServiceClient.CreateNamespace(parent, @namespace, namespaceId);
            // End snippet
        }

        /// <summary>Snippet for CreateNamespaceAsync</summary>
        public async Task CreateNamespaceResourceNamesAsync()
        {
            // Snippet: CreateNamespaceAsync(LocationName, Namespace, string, CallSettings)
            // Additional: CreateNamespaceAsync(LocationName, Namespace, string, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Namespace @namespace = new Namespace();
            string namespaceId = "";
            // Make the request
            Namespace response = await registrationServiceClient.CreateNamespaceAsync(parent, @namespace, namespaceId);
            // End snippet
        }

        /// <summary>Snippet for ListNamespaces</summary>
        public void ListNamespacesRequestObject()
        {
            // Snippet: ListNamespaces(ListNamespacesRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            ListNamespacesRequest request = new ListNamespacesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListNamespacesResponse, Namespace> response = registrationServiceClient.ListNamespaces(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Namespace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNamespacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Namespace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Namespace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Namespace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNamespacesAsync</summary>
        public async Task ListNamespacesRequestObjectAsync()
        {
            // Snippet: ListNamespacesAsync(ListNamespacesRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNamespacesRequest request = new ListNamespacesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListNamespacesResponse, Namespace> response = registrationServiceClient.ListNamespacesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Namespace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNamespacesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Namespace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Namespace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Namespace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNamespaces</summary>
        public void ListNamespaces()
        {
            // Snippet: ListNamespaces(string, string, int?, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListNamespacesResponse, Namespace> response = registrationServiceClient.ListNamespaces(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Namespace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNamespacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Namespace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Namespace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Namespace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNamespacesAsync</summary>
        public async Task ListNamespacesAsync()
        {
            // Snippet: ListNamespacesAsync(string, string, int?, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListNamespacesResponse, Namespace> response = registrationServiceClient.ListNamespacesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Namespace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNamespacesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Namespace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Namespace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Namespace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNamespaces</summary>
        public void ListNamespacesResourceNames()
        {
            // Snippet: ListNamespaces(LocationName, string, int?, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListNamespacesResponse, Namespace> response = registrationServiceClient.ListNamespaces(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Namespace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNamespacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Namespace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Namespace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Namespace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNamespacesAsync</summary>
        public async Task ListNamespacesResourceNamesAsync()
        {
            // Snippet: ListNamespacesAsync(LocationName, string, int?, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListNamespacesResponse, Namespace> response = registrationServiceClient.ListNamespacesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Namespace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListNamespacesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Namespace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Namespace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Namespace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetNamespace</summary>
        public void GetNamespaceRequestObject()
        {
            // Snippet: GetNamespace(GetNamespaceRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            GetNamespaceRequest request = new GetNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            // Make the request
            Namespace response = registrationServiceClient.GetNamespace(request);
            // End snippet
        }

        /// <summary>Snippet for GetNamespaceAsync</summary>
        public async Task GetNamespaceRequestObjectAsync()
        {
            // Snippet: GetNamespaceAsync(GetNamespaceRequest, CallSettings)
            // Additional: GetNamespaceAsync(GetNamespaceRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNamespaceRequest request = new GetNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            // Make the request
            Namespace response = await registrationServiceClient.GetNamespaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNamespace</summary>
        public void GetNamespace()
        {
            // Snippet: GetNamespace(string, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]";
            // Make the request
            Namespace response = registrationServiceClient.GetNamespace(name);
            // End snippet
        }

        /// <summary>Snippet for GetNamespaceAsync</summary>
        public async Task GetNamespaceAsync()
        {
            // Snippet: GetNamespaceAsync(string, CallSettings)
            // Additional: GetNamespaceAsync(string, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]";
            // Make the request
            Namespace response = await registrationServiceClient.GetNamespaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNamespace</summary>
        public void GetNamespaceResourceNames()
        {
            // Snippet: GetNamespace(NamespaceName, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            NamespaceName name = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]");
            // Make the request
            Namespace response = registrationServiceClient.GetNamespace(name);
            // End snippet
        }

        /// <summary>Snippet for GetNamespaceAsync</summary>
        public async Task GetNamespaceResourceNamesAsync()
        {
            // Snippet: GetNamespaceAsync(NamespaceName, CallSettings)
            // Additional: GetNamespaceAsync(NamespaceName, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            NamespaceName name = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]");
            // Make the request
            Namespace response = await registrationServiceClient.GetNamespaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateNamespace</summary>
        public void UpdateNamespaceRequestObject()
        {
            // Snippet: UpdateNamespace(UpdateNamespaceRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            UpdateNamespaceRequest request = new UpdateNamespaceRequest
            {
                Namespace = new Namespace(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Namespace response = registrationServiceClient.UpdateNamespace(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNamespaceAsync</summary>
        public async Task UpdateNamespaceRequestObjectAsync()
        {
            // Snippet: UpdateNamespaceAsync(UpdateNamespaceRequest, CallSettings)
            // Additional: UpdateNamespaceAsync(UpdateNamespaceRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNamespaceRequest request = new UpdateNamespaceRequest
            {
                Namespace = new Namespace(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Namespace response = await registrationServiceClient.UpdateNamespaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNamespace</summary>
        public void UpdateNamespace()
        {
            // Snippet: UpdateNamespace(Namespace, FieldMask, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            Namespace @namespace = new Namespace();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Namespace response = registrationServiceClient.UpdateNamespace(@namespace, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNamespaceAsync</summary>
        public async Task UpdateNamespaceAsync()
        {
            // Snippet: UpdateNamespaceAsync(Namespace, FieldMask, CallSettings)
            // Additional: UpdateNamespaceAsync(Namespace, FieldMask, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            Namespace @namespace = new Namespace();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Namespace response = await registrationServiceClient.UpdateNamespaceAsync(@namespace, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteNamespace</summary>
        public void DeleteNamespaceRequestObject()
        {
            // Snippet: DeleteNamespace(DeleteNamespaceRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            DeleteNamespaceRequest request = new DeleteNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            // Make the request
            registrationServiceClient.DeleteNamespace(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNamespaceAsync</summary>
        public async Task DeleteNamespaceRequestObjectAsync()
        {
            // Snippet: DeleteNamespaceAsync(DeleteNamespaceRequest, CallSettings)
            // Additional: DeleteNamespaceAsync(DeleteNamespaceRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNamespaceRequest request = new DeleteNamespaceRequest
            {
                NamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
            };
            // Make the request
            await registrationServiceClient.DeleteNamespaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNamespace</summary>
        public void DeleteNamespace()
        {
            // Snippet: DeleteNamespace(string, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]";
            // Make the request
            registrationServiceClient.DeleteNamespace(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNamespaceAsync</summary>
        public async Task DeleteNamespaceAsync()
        {
            // Snippet: DeleteNamespaceAsync(string, CallSettings)
            // Additional: DeleteNamespaceAsync(string, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]";
            // Make the request
            await registrationServiceClient.DeleteNamespaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNamespace</summary>
        public void DeleteNamespaceResourceNames()
        {
            // Snippet: DeleteNamespace(NamespaceName, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            NamespaceName name = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]");
            // Make the request
            registrationServiceClient.DeleteNamespace(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNamespaceAsync</summary>
        public async Task DeleteNamespaceResourceNamesAsync()
        {
            // Snippet: DeleteNamespaceAsync(NamespaceName, CallSettings)
            // Additional: DeleteNamespaceAsync(NamespaceName, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            NamespaceName name = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]");
            // Make the request
            await registrationServiceClient.DeleteNamespaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceRequestObject()
        {
            // Snippet: CreateService(CreateServiceRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsNamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                ServiceId = "",
                Service = new Service(),
            };
            // Make the request
            Service response = registrationServiceClient.CreateService(request);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceRequestObjectAsync()
        {
            // Snippet: CreateServiceAsync(CreateServiceRequest, CallSettings)
            // Additional: CreateServiceAsync(CreateServiceRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateServiceRequest request = new CreateServiceRequest
            {
                ParentAsNamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                ServiceId = "",
                Service = new Service(),
            };
            // Make the request
            Service response = await registrationServiceClient.CreateServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateService()
        {
            // Snippet: CreateService(string, Service, string, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]";
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Service response = registrationServiceClient.CreateService(parent, service, serviceId);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceAsync()
        {
            // Snippet: CreateServiceAsync(string, Service, string, CallSettings)
            // Additional: CreateServiceAsync(string, Service, string, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]";
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Service response = await registrationServiceClient.CreateServiceAsync(parent, service, serviceId);
            // End snippet
        }

        /// <summary>Snippet for CreateService</summary>
        public void CreateServiceResourceNames()
        {
            // Snippet: CreateService(NamespaceName, Service, string, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            NamespaceName parent = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]");
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Service response = registrationServiceClient.CreateService(parent, service, serviceId);
            // End snippet
        }

        /// <summary>Snippet for CreateServiceAsync</summary>
        public async Task CreateServiceResourceNamesAsync()
        {
            // Snippet: CreateServiceAsync(NamespaceName, Service, string, CallSettings)
            // Additional: CreateServiceAsync(NamespaceName, Service, string, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            NamespaceName parent = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]");
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Service response = await registrationServiceClient.CreateServiceAsync(parent, service, serviceId);
            // End snippet
        }

        /// <summary>Snippet for ListServices</summary>
        public void ListServicesRequestObject()
        {
            // Snippet: ListServices(ListServicesRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsNamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = registrationServiceClient.ListServices(request);

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
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListServicesRequest request = new ListServicesRequest
            {
                ParentAsNamespaceName = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = registrationServiceClient.ListServicesAsync(request);

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
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]";
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = registrationServiceClient.ListServices(parent);

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
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]";
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = registrationServiceClient.ListServicesAsync(parent);

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
        public void ListServicesResourceNames()
        {
            // Snippet: ListServices(NamespaceName, string, int?, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            NamespaceName parent = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]");
            // Make the request
            PagedEnumerable<ListServicesResponse, Service> response = registrationServiceClient.ListServices(parent);

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
        public async Task ListServicesResourceNamesAsync()
        {
            // Snippet: ListServicesAsync(NamespaceName, string, int?, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            NamespaceName parent = NamespaceName.FromProjectLocationNamespace("[PROJECT]", "[LOCATION]", "[NAMESPACE]");
            // Make the request
            PagedAsyncEnumerable<ListServicesResponse, Service> response = registrationServiceClient.ListServicesAsync(parent);

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

        /// <summary>Snippet for GetService</summary>
        public void GetServiceRequestObject()
        {
            // Snippet: GetService(GetServiceRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            // Make the request
            Service response = registrationServiceClient.GetService(request);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceRequestObjectAsync()
        {
            // Snippet: GetServiceAsync(GetServiceRequest, CallSettings)
            // Additional: GetServiceAsync(GetServiceRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetServiceRequest request = new GetServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            // Make the request
            Service response = await registrationServiceClient.GetServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetService()
        {
            // Snippet: GetService(string, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]/services/[SERVICE]";
            // Make the request
            Service response = registrationServiceClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceAsync()
        {
            // Snippet: GetServiceAsync(string, CallSettings)
            // Additional: GetServiceAsync(string, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]/services/[SERVICE]";
            // Make the request
            Service response = await registrationServiceClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetService</summary>
        public void GetServiceResourceNames()
        {
            // Snippet: GetService(ServiceName, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]");
            // Make the request
            Service response = registrationServiceClient.GetService(name);
            // End snippet
        }

        /// <summary>Snippet for GetServiceAsync</summary>
        public async Task GetServiceResourceNamesAsync()
        {
            // Snippet: GetServiceAsync(ServiceName, CallSettings)
            // Additional: GetServiceAsync(ServiceName, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]");
            // Make the request
            Service response = await registrationServiceClient.GetServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateServiceRequestObject()
        {
            // Snippet: UpdateService(UpdateServiceRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Service response = registrationServiceClient.UpdateService(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateServiceRequestObjectAsync()
        {
            // Snippet: UpdateServiceAsync(UpdateServiceRequest, CallSettings)
            // Additional: UpdateServiceAsync(UpdateServiceRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateServiceRequest request = new UpdateServiceRequest
            {
                Service = new Service(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Service response = await registrationServiceClient.UpdateServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateService</summary>
        public void UpdateService()
        {
            // Snippet: UpdateService(Service, FieldMask, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            Service service = new Service();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Service response = registrationServiceClient.UpdateService(service, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateServiceAsync</summary>
        public async Task UpdateServiceAsync()
        {
            // Snippet: UpdateServiceAsync(Service, FieldMask, CallSettings)
            // Additional: UpdateServiceAsync(Service, FieldMask, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            Service service = new Service();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Service response = await registrationServiceClient.UpdateServiceAsync(service, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteServiceRequestObject()
        {
            // Snippet: DeleteService(DeleteServiceRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            // Make the request
            registrationServiceClient.DeleteService(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceRequestObjectAsync()
        {
            // Snippet: DeleteServiceAsync(DeleteServiceRequest, CallSettings)
            // Additional: DeleteServiceAsync(DeleteServiceRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteServiceRequest request = new DeleteServiceRequest
            {
                ServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
            };
            // Make the request
            await registrationServiceClient.DeleteServiceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteService()
        {
            // Snippet: DeleteService(string, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]/services/[SERVICE]";
            // Make the request
            registrationServiceClient.DeleteService(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceAsync()
        {
            // Snippet: DeleteServiceAsync(string, CallSettings)
            // Additional: DeleteServiceAsync(string, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]/services/[SERVICE]";
            // Make the request
            await registrationServiceClient.DeleteServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteService</summary>
        public void DeleteServiceResourceNames()
        {
            // Snippet: DeleteService(ServiceName, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]");
            // Make the request
            registrationServiceClient.DeleteService(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteServiceAsync</summary>
        public async Task DeleteServiceResourceNamesAsync()
        {
            // Snippet: DeleteServiceAsync(ServiceName, CallSettings)
            // Additional: DeleteServiceAsync(ServiceName, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName name = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]");
            // Make the request
            await registrationServiceClient.DeleteServiceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEndpoint</summary>
        public void CreateEndpointRequestObject()
        {
            // Snippet: CreateEndpoint(CreateEndpointRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            CreateEndpointRequest request = new CreateEndpointRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                EndpointId = "",
                Endpoint = new Endpoint(),
            };
            // Make the request
            Endpoint response = registrationServiceClient.CreateEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointAsync</summary>
        public async Task CreateEndpointRequestObjectAsync()
        {
            // Snippet: CreateEndpointAsync(CreateEndpointRequest, CallSettings)
            // Additional: CreateEndpointAsync(CreateEndpointRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateEndpointRequest request = new CreateEndpointRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                EndpointId = "",
                Endpoint = new Endpoint(),
            };
            // Make the request
            Endpoint response = await registrationServiceClient.CreateEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEndpoint</summary>
        public void CreateEndpoint()
        {
            // Snippet: CreateEndpoint(string, Endpoint, string, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]/services/[SERVICE]";
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Endpoint response = registrationServiceClient.CreateEndpoint(parent, endpoint, endpointId);
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointAsync</summary>
        public async Task CreateEndpointAsync()
        {
            // Snippet: CreateEndpointAsync(string, Endpoint, string, CallSettings)
            // Additional: CreateEndpointAsync(string, Endpoint, string, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]/services/[SERVICE]";
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Endpoint response = await registrationServiceClient.CreateEndpointAsync(parent, endpoint, endpointId);
            // End snippet
        }

        /// <summary>Snippet for CreateEndpoint</summary>
        public void CreateEndpointResourceNames()
        {
            // Snippet: CreateEndpoint(ServiceName, Endpoint, string, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]");
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Endpoint response = registrationServiceClient.CreateEndpoint(parent, endpoint, endpointId);
            // End snippet
        }

        /// <summary>Snippet for CreateEndpointAsync</summary>
        public async Task CreateEndpointResourceNamesAsync()
        {
            // Snippet: CreateEndpointAsync(ServiceName, Endpoint, string, CallSettings)
            // Additional: CreateEndpointAsync(ServiceName, Endpoint, string, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]");
            Endpoint endpoint = new Endpoint();
            string endpointId = "";
            // Make the request
            Endpoint response = await registrationServiceClient.CreateEndpointAsync(parent, endpoint, endpointId);
            // End snippet
        }

        /// <summary>Snippet for ListEndpoints</summary>
        public void ListEndpointsRequestObject()
        {
            // Snippet: ListEndpoints(ListEndpointsRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            ListEndpointsRequest request = new ListEndpointsRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEndpointsResponse, Endpoint> response = registrationServiceClient.ListEndpoints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointsAsync</summary>
        public async Task ListEndpointsRequestObjectAsync()
        {
            // Snippet: ListEndpointsAsync(ListEndpointsRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEndpointsRequest request = new ListEndpointsRequest
            {
                ParentAsServiceName = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> response = registrationServiceClient.ListEndpointsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Endpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEndpointsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpoints</summary>
        public void ListEndpoints()
        {
            // Snippet: ListEndpoints(string, string, int?, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]/services/[SERVICE]";
            // Make the request
            PagedEnumerable<ListEndpointsResponse, Endpoint> response = registrationServiceClient.ListEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointsAsync</summary>
        public async Task ListEndpointsAsync()
        {
            // Snippet: ListEndpointsAsync(string, string, int?, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]/services/[SERVICE]";
            // Make the request
            PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> response = registrationServiceClient.ListEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Endpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEndpointsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpoints</summary>
        public void ListEndpointsResourceNames()
        {
            // Snippet: ListEndpoints(ServiceName, string, int?, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]");
            // Make the request
            PagedEnumerable<ListEndpointsResponse, Endpoint> response = registrationServiceClient.ListEndpoints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Endpoint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEndpointsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEndpointsAsync</summary>
        public async Task ListEndpointsResourceNamesAsync()
        {
            // Snippet: ListEndpointsAsync(ServiceName, string, int?, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ServiceName parent = ServiceName.FromProjectLocationNamespaceService("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]");
            // Make the request
            PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> response = registrationServiceClient.ListEndpointsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Endpoint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEndpointsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Endpoint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Endpoint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Endpoint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEndpoint</summary>
        public void GetEndpointRequestObject()
        {
            // Snippet: GetEndpoint(GetEndpointRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            // Make the request
            Endpoint response = registrationServiceClient.GetEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointAsync</summary>
        public async Task GetEndpointRequestObjectAsync()
        {
            // Snippet: GetEndpointAsync(GetEndpointRequest, CallSettings)
            // Additional: GetEndpointAsync(GetEndpointRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            // Make the request
            Endpoint response = await registrationServiceClient.GetEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEndpoint</summary>
        public void GetEndpoint()
        {
            // Snippet: GetEndpoint(string, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]/services/[SERVICE]/endpoints/[ENDPOINT]";
            // Make the request
            Endpoint response = registrationServiceClient.GetEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointAsync</summary>
        public async Task GetEndpointAsync()
        {
            // Snippet: GetEndpointAsync(string, CallSettings)
            // Additional: GetEndpointAsync(string, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]/services/[SERVICE]/endpoints/[ENDPOINT]";
            // Make the request
            Endpoint response = await registrationServiceClient.GetEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpoint</summary>
        public void GetEndpointResourceNames()
        {
            // Snippet: GetEndpoint(EndpointName, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]");
            // Make the request
            Endpoint response = registrationServiceClient.GetEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for GetEndpointAsync</summary>
        public async Task GetEndpointResourceNamesAsync()
        {
            // Snippet: GetEndpointAsync(EndpointName, CallSettings)
            // Additional: GetEndpointAsync(EndpointName, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]");
            // Make the request
            Endpoint response = await registrationServiceClient.GetEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpoint</summary>
        public void UpdateEndpointRequestObject()
        {
            // Snippet: UpdateEndpoint(UpdateEndpointRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            UpdateEndpointRequest request = new UpdateEndpointRequest
            {
                Endpoint = new Endpoint(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Endpoint response = registrationServiceClient.UpdateEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpointAsync</summary>
        public async Task UpdateEndpointRequestObjectAsync()
        {
            // Snippet: UpdateEndpointAsync(UpdateEndpointRequest, CallSettings)
            // Additional: UpdateEndpointAsync(UpdateEndpointRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEndpointRequest request = new UpdateEndpointRequest
            {
                Endpoint = new Endpoint(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Endpoint response = await registrationServiceClient.UpdateEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpoint</summary>
        public void UpdateEndpoint()
        {
            // Snippet: UpdateEndpoint(Endpoint, FieldMask, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            Endpoint endpoint = new Endpoint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Endpoint response = registrationServiceClient.UpdateEndpoint(endpoint, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEndpointAsync</summary>
        public async Task UpdateEndpointAsync()
        {
            // Snippet: UpdateEndpointAsync(Endpoint, FieldMask, CallSettings)
            // Additional: UpdateEndpointAsync(Endpoint, FieldMask, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            Endpoint endpoint = new Endpoint();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Endpoint response = await registrationServiceClient.UpdateEndpointAsync(endpoint, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpoint</summary>
        public void DeleteEndpointRequestObject()
        {
            // Snippet: DeleteEndpoint(DeleteEndpointRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            DeleteEndpointRequest request = new DeleteEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            // Make the request
            registrationServiceClient.DeleteEndpoint(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointAsync</summary>
        public async Task DeleteEndpointRequestObjectAsync()
        {
            // Snippet: DeleteEndpointAsync(DeleteEndpointRequest, CallSettings)
            // Additional: DeleteEndpointAsync(DeleteEndpointRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEndpointRequest request = new DeleteEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]"),
            };
            // Make the request
            await registrationServiceClient.DeleteEndpointAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpoint</summary>
        public void DeleteEndpoint()
        {
            // Snippet: DeleteEndpoint(string, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]/services/[SERVICE]/endpoints/[ENDPOINT]";
            // Make the request
            registrationServiceClient.DeleteEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointAsync</summary>
        public async Task DeleteEndpointAsync()
        {
            // Snippet: DeleteEndpointAsync(string, CallSettings)
            // Additional: DeleteEndpointAsync(string, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/namespaces/[NAMESPACE]/services/[SERVICE]/endpoints/[ENDPOINT]";
            // Make the request
            await registrationServiceClient.DeleteEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpoint</summary>
        public void DeleteEndpointResourceNames()
        {
            // Snippet: DeleteEndpoint(EndpointName, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]");
            // Make the request
            registrationServiceClient.DeleteEndpoint(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEndpointAsync</summary>
        public async Task DeleteEndpointResourceNamesAsync()
        {
            // Snippet: DeleteEndpointAsync(EndpointName, CallSettings)
            // Additional: DeleteEndpointAsync(EndpointName, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            EndpointName name = EndpointName.FromProjectLocationNamespaceServiceEndpoint("[PROJECT]", "[LOCATION]", "[NAMESPACE]", "[SERVICE]", "[ENDPOINT]");
            // Make the request
            await registrationServiceClient.DeleteEndpointAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = registrationServiceClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await registrationServiceClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = registrationServiceClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await registrationServiceClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            RegistrationServiceClient registrationServiceClient = RegistrationServiceClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = registrationServiceClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            RegistrationServiceClient registrationServiceClient = await RegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await registrationServiceClient.TestIamPermissionsAsync(request);
            // End snippet
        }
    }
}
