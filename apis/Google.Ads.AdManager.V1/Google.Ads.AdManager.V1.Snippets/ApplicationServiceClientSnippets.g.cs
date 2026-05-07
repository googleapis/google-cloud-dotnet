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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedApplicationServiceClientSnippets
    {
        /// <summary>Snippet for GetApplication</summary>
        public void GetApplicationRequestObject()
        {
            // Snippet: GetApplication(GetApplicationRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromNetworkCodeApplication("[NETWORK_CODE]", "[APPLICATION]"),
            };
            // Make the request
            Application response = applicationServiceClient.GetApplication(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationRequestObjectAsync()
        {
            // Snippet: GetApplicationAsync(GetApplicationRequest, CallSettings)
            // Additional: GetApplicationAsync(GetApplicationRequest, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetApplicationRequest request = new GetApplicationRequest
            {
                ApplicationName = ApplicationName.FromNetworkCodeApplication("[NETWORK_CODE]", "[APPLICATION]"),
            };
            // Make the request
            Application response = await applicationServiceClient.GetApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplication()
        {
            // Snippet: GetApplication(string, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/applications/[APPLICATION]";
            // Make the request
            Application response = applicationServiceClient.GetApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationAsync()
        {
            // Snippet: GetApplicationAsync(string, CallSettings)
            // Additional: GetApplicationAsync(string, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/applications/[APPLICATION]";
            // Make the request
            Application response = await applicationServiceClient.GetApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplication</summary>
        public void GetApplicationResourceNames()
        {
            // Snippet: GetApplication(ApplicationName, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromNetworkCodeApplication("[NETWORK_CODE]", "[APPLICATION]");
            // Make the request
            Application response = applicationServiceClient.GetApplication(name);
            // End snippet
        }

        /// <summary>Snippet for GetApplicationAsync</summary>
        public async Task GetApplicationResourceNamesAsync()
        {
            // Snippet: GetApplicationAsync(ApplicationName, CallSettings)
            // Additional: GetApplicationAsync(ApplicationName, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ApplicationName name = ApplicationName.FromNetworkCodeApplication("[NETWORK_CODE]", "[APPLICATION]");
            // Make the request
            Application response = await applicationServiceClient.GetApplicationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplicationsRequestObject()
        {
            // Snippet: ListApplications(ListApplicationsRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            ListApplicationsRequest request = new ListApplicationsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = applicationServiceClient.ListApplications(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsRequestObjectAsync()
        {
            // Snippet: ListApplicationsAsync(ListApplicationsRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListApplicationsRequest request = new ListApplicationsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = applicationServiceClient.ListApplicationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplications()
        {
            // Snippet: ListApplications(string, string, int?, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = applicationServiceClient.ListApplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsAsync()
        {
            // Snippet: ListApplicationsAsync(string, string, int?, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = applicationServiceClient.ListApplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplications</summary>
        public void ListApplicationsResourceNames()
        {
            // Snippet: ListApplications(NetworkName, string, int?, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListApplicationsResponse, Application> response = applicationServiceClient.ListApplications(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApplicationsAsync</summary>
        public async Task ListApplicationsResourceNamesAsync()
        {
            // Snippet: ListApplicationsAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListApplicationsResponse, Application> response = applicationServiceClient.ListApplicationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (Application item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListApplicationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Application> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Application item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplicationRequestObject()
        {
            // Snippet: CreateApplication(CreateApplicationRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Application = new Application(),
            };
            // Make the request
            Application response = applicationServiceClient.CreateApplication(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationRequestObjectAsync()
        {
            // Snippet: CreateApplicationAsync(CreateApplicationRequest, CallSettings)
            // Additional: CreateApplicationAsync(CreateApplicationRequest, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateApplicationRequest request = new CreateApplicationRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Application = new Application(),
            };
            // Make the request
            Application response = await applicationServiceClient.CreateApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplication()
        {
            // Snippet: CreateApplication(string, Application, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Application application = new Application();
            // Make the request
            Application response = applicationServiceClient.CreateApplication(parent, application);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationAsync()
        {
            // Snippet: CreateApplicationAsync(string, Application, CallSettings)
            // Additional: CreateApplicationAsync(string, Application, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            Application application = new Application();
            // Make the request
            Application response = await applicationServiceClient.CreateApplicationAsync(parent, application);
            // End snippet
        }

        /// <summary>Snippet for CreateApplication</summary>
        public void CreateApplicationResourceNames()
        {
            // Snippet: CreateApplication(NetworkName, Application, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Application application = new Application();
            // Make the request
            Application response = applicationServiceClient.CreateApplication(parent, application);
            // End snippet
        }

        /// <summary>Snippet for CreateApplicationAsync</summary>
        public async Task CreateApplicationResourceNamesAsync()
        {
            // Snippet: CreateApplicationAsync(NetworkName, Application, CallSettings)
            // Additional: CreateApplicationAsync(NetworkName, Application, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            Application application = new Application();
            // Make the request
            Application response = await applicationServiceClient.CreateApplicationAsync(parent, application);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateApplications</summary>
        public void BatchCreateApplicationsRequestObject()
        {
            // Snippet: BatchCreateApplications(BatchCreateApplicationsRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateApplicationsRequest request = new BatchCreateApplicationsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateApplicationRequest(),
                },
            };
            // Make the request
            BatchCreateApplicationsResponse response = applicationServiceClient.BatchCreateApplications(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateApplicationsAsync</summary>
        public async Task BatchCreateApplicationsRequestObjectAsync()
        {
            // Snippet: BatchCreateApplicationsAsync(BatchCreateApplicationsRequest, CallSettings)
            // Additional: BatchCreateApplicationsAsync(BatchCreateApplicationsRequest, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateApplicationsRequest request = new BatchCreateApplicationsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateApplicationRequest(),
                },
            };
            // Make the request
            BatchCreateApplicationsResponse response = await applicationServiceClient.BatchCreateApplicationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateApplications</summary>
        public void BatchCreateApplications()
        {
            // Snippet: BatchCreateApplications(string, IEnumerable<CreateApplicationRequest>, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateApplicationRequest> requests = new CreateApplicationRequest[]
            {
                new CreateApplicationRequest(),
            };
            // Make the request
            BatchCreateApplicationsResponse response = applicationServiceClient.BatchCreateApplications(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateApplicationsAsync</summary>
        public async Task BatchCreateApplicationsAsync()
        {
            // Snippet: BatchCreateApplicationsAsync(string, IEnumerable<CreateApplicationRequest>, CallSettings)
            // Additional: BatchCreateApplicationsAsync(string, IEnumerable<CreateApplicationRequest>, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateApplicationRequest> requests = new CreateApplicationRequest[]
            {
                new CreateApplicationRequest(),
            };
            // Make the request
            BatchCreateApplicationsResponse response = await applicationServiceClient.BatchCreateApplicationsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateApplications</summary>
        public void BatchCreateApplicationsResourceNames()
        {
            // Snippet: BatchCreateApplications(NetworkName, IEnumerable<CreateApplicationRequest>, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateApplicationRequest> requests = new CreateApplicationRequest[]
            {
                new CreateApplicationRequest(),
            };
            // Make the request
            BatchCreateApplicationsResponse response = applicationServiceClient.BatchCreateApplications(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateApplicationsAsync</summary>
        public async Task BatchCreateApplicationsResourceNamesAsync()
        {
            // Snippet: BatchCreateApplicationsAsync(NetworkName, IEnumerable<CreateApplicationRequest>, CallSettings)
            // Additional: BatchCreateApplicationsAsync(NetworkName, IEnumerable<CreateApplicationRequest>, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateApplicationRequest> requests = new CreateApplicationRequest[]
            {
                new CreateApplicationRequest(),
            };
            // Make the request
            BatchCreateApplicationsResponse response = await applicationServiceClient.BatchCreateApplicationsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplication</summary>
        public void UpdateApplicationRequestObject()
        {
            // Snippet: UpdateApplication(UpdateApplicationRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                Application = new Application(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Application response = applicationServiceClient.UpdateApplication(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationAsync</summary>
        public async Task UpdateApplicationRequestObjectAsync()
        {
            // Snippet: UpdateApplicationAsync(UpdateApplicationRequest, CallSettings)
            // Additional: UpdateApplicationAsync(UpdateApplicationRequest, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateApplicationRequest request = new UpdateApplicationRequest
            {
                Application = new Application(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Application response = await applicationServiceClient.UpdateApplicationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplication</summary>
        public void UpdateApplication()
        {
            // Snippet: UpdateApplication(Application, FieldMask, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            Application application = new Application();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Application response = applicationServiceClient.UpdateApplication(application, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateApplicationAsync</summary>
        public async Task UpdateApplicationAsync()
        {
            // Snippet: UpdateApplicationAsync(Application, FieldMask, CallSettings)
            // Additional: UpdateApplicationAsync(Application, FieldMask, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            Application application = new Application();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Application response = await applicationServiceClient.UpdateApplicationAsync(application, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateApplications</summary>
        public void BatchUpdateApplicationsRequestObject()
        {
            // Snippet: BatchUpdateApplications(BatchUpdateApplicationsRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateApplicationsRequest request = new BatchUpdateApplicationsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateApplicationRequest(),
                },
            };
            // Make the request
            BatchUpdateApplicationsResponse response = applicationServiceClient.BatchUpdateApplications(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateApplicationsAsync</summary>
        public async Task BatchUpdateApplicationsRequestObjectAsync()
        {
            // Snippet: BatchUpdateApplicationsAsync(BatchUpdateApplicationsRequest, CallSettings)
            // Additional: BatchUpdateApplicationsAsync(BatchUpdateApplicationsRequest, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateApplicationsRequest request = new BatchUpdateApplicationsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateApplicationRequest(),
                },
            };
            // Make the request
            BatchUpdateApplicationsResponse response = await applicationServiceClient.BatchUpdateApplicationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateApplications</summary>
        public void BatchUpdateApplications()
        {
            // Snippet: BatchUpdateApplications(string, IEnumerable<UpdateApplicationRequest>, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateApplicationRequest> requests = new UpdateApplicationRequest[]
            {
                new UpdateApplicationRequest(),
            };
            // Make the request
            BatchUpdateApplicationsResponse response = applicationServiceClient.BatchUpdateApplications(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateApplicationsAsync</summary>
        public async Task BatchUpdateApplicationsAsync()
        {
            // Snippet: BatchUpdateApplicationsAsync(string, IEnumerable<UpdateApplicationRequest>, CallSettings)
            // Additional: BatchUpdateApplicationsAsync(string, IEnumerable<UpdateApplicationRequest>, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateApplicationRequest> requests = new UpdateApplicationRequest[]
            {
                new UpdateApplicationRequest(),
            };
            // Make the request
            BatchUpdateApplicationsResponse response = await applicationServiceClient.BatchUpdateApplicationsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateApplications</summary>
        public void BatchUpdateApplicationsResourceNames()
        {
            // Snippet: BatchUpdateApplications(NetworkName, IEnumerable<UpdateApplicationRequest>, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateApplicationRequest> requests = new UpdateApplicationRequest[]
            {
                new UpdateApplicationRequest(),
            };
            // Make the request
            BatchUpdateApplicationsResponse response = applicationServiceClient.BatchUpdateApplications(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateApplicationsAsync</summary>
        public async Task BatchUpdateApplicationsResourceNamesAsync()
        {
            // Snippet: BatchUpdateApplicationsAsync(NetworkName, IEnumerable<UpdateApplicationRequest>, CallSettings)
            // Additional: BatchUpdateApplicationsAsync(NetworkName, IEnumerable<UpdateApplicationRequest>, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateApplicationRequest> requests = new UpdateApplicationRequest[]
            {
                new UpdateApplicationRequest(),
            };
            // Make the request
            BatchUpdateApplicationsResponse response = await applicationServiceClient.BatchUpdateApplicationsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveApplications</summary>
        public void BatchArchiveApplicationsRequestObject()
        {
            // Snippet: BatchArchiveApplications(BatchArchiveApplicationsRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            BatchArchiveApplicationsRequest request = new BatchArchiveApplicationsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ApplicationNames =
                {
                    ApplicationName.FromNetworkCodeApplication("[NETWORK_CODE]", "[APPLICATION]"),
                },
            };
            // Make the request
            BatchArchiveApplicationsResponse response = applicationServiceClient.BatchArchiveApplications(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveApplicationsAsync</summary>
        public async Task BatchArchiveApplicationsRequestObjectAsync()
        {
            // Snippet: BatchArchiveApplicationsAsync(BatchArchiveApplicationsRequest, CallSettings)
            // Additional: BatchArchiveApplicationsAsync(BatchArchiveApplicationsRequest, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchArchiveApplicationsRequest request = new BatchArchiveApplicationsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ApplicationNames =
                {
                    ApplicationName.FromNetworkCodeApplication("[NETWORK_CODE]", "[APPLICATION]"),
                },
            };
            // Make the request
            BatchArchiveApplicationsResponse response = await applicationServiceClient.BatchArchiveApplicationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveApplications</summary>
        public void BatchArchiveApplications()
        {
            // Snippet: BatchArchiveApplications(string, IEnumerable<string>, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/applications/[APPLICATION]",
            };
            // Make the request
            BatchArchiveApplicationsResponse response = applicationServiceClient.BatchArchiveApplications(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveApplicationsAsync</summary>
        public async Task BatchArchiveApplicationsAsync()
        {
            // Snippet: BatchArchiveApplicationsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchArchiveApplicationsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/applications/[APPLICATION]",
            };
            // Make the request
            BatchArchiveApplicationsResponse response = await applicationServiceClient.BatchArchiveApplicationsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveApplications</summary>
        public void BatchArchiveApplicationsResourceNames()
        {
            // Snippet: BatchArchiveApplications(NetworkName, IEnumerable<ApplicationName>, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ApplicationName> names = new ApplicationName[]
            {
                ApplicationName.FromNetworkCodeApplication("[NETWORK_CODE]", "[APPLICATION]"),
            };
            // Make the request
            BatchArchiveApplicationsResponse response = applicationServiceClient.BatchArchiveApplications(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchArchiveApplicationsAsync</summary>
        public async Task BatchArchiveApplicationsResourceNamesAsync()
        {
            // Snippet: BatchArchiveApplicationsAsync(NetworkName, IEnumerable<ApplicationName>, CallSettings)
            // Additional: BatchArchiveApplicationsAsync(NetworkName, IEnumerable<ApplicationName>, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ApplicationName> names = new ApplicationName[]
            {
                ApplicationName.FromNetworkCodeApplication("[NETWORK_CODE]", "[APPLICATION]"),
            };
            // Make the request
            BatchArchiveApplicationsResponse response = await applicationServiceClient.BatchArchiveApplicationsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveApplications</summary>
        public void BatchUnarchiveApplicationsRequestObject()
        {
            // Snippet: BatchUnarchiveApplications(BatchUnarchiveApplicationsRequest, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            BatchUnarchiveApplicationsRequest request = new BatchUnarchiveApplicationsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ApplicationNames =
                {
                    ApplicationName.FromNetworkCodeApplication("[NETWORK_CODE]", "[APPLICATION]"),
                },
            };
            // Make the request
            BatchUnarchiveApplicationsResponse response = applicationServiceClient.BatchUnarchiveApplications(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveApplicationsAsync</summary>
        public async Task BatchUnarchiveApplicationsRequestObjectAsync()
        {
            // Snippet: BatchUnarchiveApplicationsAsync(BatchUnarchiveApplicationsRequest, CallSettings)
            // Additional: BatchUnarchiveApplicationsAsync(BatchUnarchiveApplicationsRequest, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUnarchiveApplicationsRequest request = new BatchUnarchiveApplicationsRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ApplicationNames =
                {
                    ApplicationName.FromNetworkCodeApplication("[NETWORK_CODE]", "[APPLICATION]"),
                },
            };
            // Make the request
            BatchUnarchiveApplicationsResponse response = await applicationServiceClient.BatchUnarchiveApplicationsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveApplications</summary>
        public void BatchUnarchiveApplications()
        {
            // Snippet: BatchUnarchiveApplications(string, IEnumerable<string>, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/applications/[APPLICATION]",
            };
            // Make the request
            BatchUnarchiveApplicationsResponse response = applicationServiceClient.BatchUnarchiveApplications(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveApplicationsAsync</summary>
        public async Task BatchUnarchiveApplicationsAsync()
        {
            // Snippet: BatchUnarchiveApplicationsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: BatchUnarchiveApplicationsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<string> names = new string[]
            {
                "networks/[NETWORK_CODE]/applications/[APPLICATION]",
            };
            // Make the request
            BatchUnarchiveApplicationsResponse response = await applicationServiceClient.BatchUnarchiveApplicationsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveApplications</summary>
        public void BatchUnarchiveApplicationsResourceNames()
        {
            // Snippet: BatchUnarchiveApplications(NetworkName, IEnumerable<ApplicationName>, CallSettings)
            // Create client
            ApplicationServiceClient applicationServiceClient = ApplicationServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ApplicationName> names = new ApplicationName[]
            {
                ApplicationName.FromNetworkCodeApplication("[NETWORK_CODE]", "[APPLICATION]"),
            };
            // Make the request
            BatchUnarchiveApplicationsResponse response = applicationServiceClient.BatchUnarchiveApplications(parent, names);
            // End snippet
        }

        /// <summary>Snippet for BatchUnarchiveApplicationsAsync</summary>
        public async Task BatchUnarchiveApplicationsResourceNamesAsync()
        {
            // Snippet: BatchUnarchiveApplicationsAsync(NetworkName, IEnumerable<ApplicationName>, CallSettings)
            // Additional: BatchUnarchiveApplicationsAsync(NetworkName, IEnumerable<ApplicationName>, CancellationToken)
            // Create client
            ApplicationServiceClient applicationServiceClient = await ApplicationServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<ApplicationName> names = new ApplicationName[]
            {
                ApplicationName.FromNetworkCodeApplication("[NETWORK_CODE]", "[APPLICATION]"),
            };
            // Make the request
            BatchUnarchiveApplicationsResponse response = await applicationServiceClient.BatchUnarchiveApplicationsAsync(parent, names);
            // End snippet
        }
    }
}
