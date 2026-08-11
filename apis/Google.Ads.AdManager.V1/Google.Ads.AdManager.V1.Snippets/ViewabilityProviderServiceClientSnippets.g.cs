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
    public sealed class AllGeneratedViewabilityProviderServiceClientSnippets
    {
        /// <summary>Snippet for GetViewabilityProvider</summary>
        public void GetViewabilityProviderRequestObject()
        {
            // Snippet: GetViewabilityProvider(GetViewabilityProviderRequest, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            GetViewabilityProviderRequest request = new GetViewabilityProviderRequest
            {
                ViewabilityProviderName = ViewabilityProviderName.FromNetworkCodeViewabilityProvider("[NETWORK_CODE]", "[VIEWABILITY_PROVIDER]"),
            };
            // Make the request
            ViewabilityProvider response = viewabilityProviderServiceClient.GetViewabilityProvider(request);
            // End snippet
        }

        /// <summary>Snippet for GetViewabilityProviderAsync</summary>
        public async Task GetViewabilityProviderRequestObjectAsync()
        {
            // Snippet: GetViewabilityProviderAsync(GetViewabilityProviderRequest, CallSettings)
            // Additional: GetViewabilityProviderAsync(GetViewabilityProviderRequest, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetViewabilityProviderRequest request = new GetViewabilityProviderRequest
            {
                ViewabilityProviderName = ViewabilityProviderName.FromNetworkCodeViewabilityProvider("[NETWORK_CODE]", "[VIEWABILITY_PROVIDER]"),
            };
            // Make the request
            ViewabilityProvider response = await viewabilityProviderServiceClient.GetViewabilityProviderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetViewabilityProvider</summary>
        public void GetViewabilityProvider()
        {
            // Snippet: GetViewabilityProvider(string, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/viewabilityProviders/[VIEWABILITY_PROVIDER]";
            // Make the request
            ViewabilityProvider response = viewabilityProviderServiceClient.GetViewabilityProvider(name);
            // End snippet
        }

        /// <summary>Snippet for GetViewabilityProviderAsync</summary>
        public async Task GetViewabilityProviderAsync()
        {
            // Snippet: GetViewabilityProviderAsync(string, CallSettings)
            // Additional: GetViewabilityProviderAsync(string, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "networks/[NETWORK_CODE]/viewabilityProviders/[VIEWABILITY_PROVIDER]";
            // Make the request
            ViewabilityProvider response = await viewabilityProviderServiceClient.GetViewabilityProviderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetViewabilityProvider</summary>
        public void GetViewabilityProviderResourceNames()
        {
            // Snippet: GetViewabilityProvider(ViewabilityProviderName, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            ViewabilityProviderName name = ViewabilityProviderName.FromNetworkCodeViewabilityProvider("[NETWORK_CODE]", "[VIEWABILITY_PROVIDER]");
            // Make the request
            ViewabilityProvider response = viewabilityProviderServiceClient.GetViewabilityProvider(name);
            // End snippet
        }

        /// <summary>Snippet for GetViewabilityProviderAsync</summary>
        public async Task GetViewabilityProviderResourceNamesAsync()
        {
            // Snippet: GetViewabilityProviderAsync(ViewabilityProviderName, CallSettings)
            // Additional: GetViewabilityProviderAsync(ViewabilityProviderName, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            ViewabilityProviderName name = ViewabilityProviderName.FromNetworkCodeViewabilityProvider("[NETWORK_CODE]", "[VIEWABILITY_PROVIDER]");
            // Make the request
            ViewabilityProvider response = await viewabilityProviderServiceClient.GetViewabilityProviderAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListViewabilityProviders</summary>
        public void ListViewabilityProvidersRequestObject()
        {
            // Snippet: ListViewabilityProviders(ListViewabilityProvidersRequest, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            ListViewabilityProvidersRequest request = new ListViewabilityProvidersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> response = viewabilityProviderServiceClient.ListViewabilityProviders(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ViewabilityProvider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViewabilityProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ViewabilityProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ViewabilityProvider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ViewabilityProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViewabilityProvidersAsync</summary>
        public async Task ListViewabilityProvidersRequestObjectAsync()
        {
            // Snippet: ListViewabilityProvidersAsync(ListViewabilityProvidersRequest, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListViewabilityProvidersRequest request = new ListViewabilityProvidersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Filter = "",
                OrderBy = "",
                Skip = 0,
            };
            // Make the request
            PagedAsyncEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> response = viewabilityProviderServiceClient.ListViewabilityProvidersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ViewabilityProvider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListViewabilityProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ViewabilityProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ViewabilityProvider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ViewabilityProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViewabilityProviders</summary>
        public void ListViewabilityProviders()
        {
            // Snippet: ListViewabilityProviders(string, string, int?, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> response = viewabilityProviderServiceClient.ListViewabilityProviders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ViewabilityProvider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViewabilityProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ViewabilityProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ViewabilityProvider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ViewabilityProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViewabilityProvidersAsync</summary>
        public async Task ListViewabilityProvidersAsync()
        {
            // Snippet: ListViewabilityProvidersAsync(string, string, int?, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            // Make the request
            PagedAsyncEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> response = viewabilityProviderServiceClient.ListViewabilityProvidersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ViewabilityProvider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListViewabilityProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ViewabilityProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ViewabilityProvider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ViewabilityProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViewabilityProviders</summary>
        public void ListViewabilityProvidersResourceNames()
        {
            // Snippet: ListViewabilityProviders(NetworkName, string, int?, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> response = viewabilityProviderServiceClient.ListViewabilityProviders(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ViewabilityProvider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViewabilityProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ViewabilityProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ViewabilityProvider> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ViewabilityProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViewabilityProvidersAsync</summary>
        public async Task ListViewabilityProvidersResourceNamesAsync()
        {
            // Snippet: ListViewabilityProvidersAsync(NetworkName, string, int?, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            // Make the request
            PagedAsyncEnumerable<ListViewabilityProvidersResponse, ViewabilityProvider> response = viewabilityProviderServiceClient.ListViewabilityProvidersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ViewabilityProvider item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListViewabilityProvidersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ViewabilityProvider item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ViewabilityProvider> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ViewabilityProvider item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateViewabilityProvider</summary>
        public void CreateViewabilityProviderRequestObject()
        {
            // Snippet: CreateViewabilityProvider(CreateViewabilityProviderRequest, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            CreateViewabilityProviderRequest request = new CreateViewabilityProviderRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ViewabilityProvider = new ViewabilityProvider(),
            };
            // Make the request
            ViewabilityProvider response = viewabilityProviderServiceClient.CreateViewabilityProvider(request);
            // End snippet
        }

        /// <summary>Snippet for CreateViewabilityProviderAsync</summary>
        public async Task CreateViewabilityProviderRequestObjectAsync()
        {
            // Snippet: CreateViewabilityProviderAsync(CreateViewabilityProviderRequest, CallSettings)
            // Additional: CreateViewabilityProviderAsync(CreateViewabilityProviderRequest, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateViewabilityProviderRequest request = new CreateViewabilityProviderRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                ViewabilityProvider = new ViewabilityProvider(),
            };
            // Make the request
            ViewabilityProvider response = await viewabilityProviderServiceClient.CreateViewabilityProviderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateViewabilityProvider</summary>
        public void CreateViewabilityProvider()
        {
            // Snippet: CreateViewabilityProvider(string, ViewabilityProvider, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            ViewabilityProvider viewabilityProvider = new ViewabilityProvider();
            // Make the request
            ViewabilityProvider response = viewabilityProviderServiceClient.CreateViewabilityProvider(parent, viewabilityProvider);
            // End snippet
        }

        /// <summary>Snippet for CreateViewabilityProviderAsync</summary>
        public async Task CreateViewabilityProviderAsync()
        {
            // Snippet: CreateViewabilityProviderAsync(string, ViewabilityProvider, CallSettings)
            // Additional: CreateViewabilityProviderAsync(string, ViewabilityProvider, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            ViewabilityProvider viewabilityProvider = new ViewabilityProvider();
            // Make the request
            ViewabilityProvider response = await viewabilityProviderServiceClient.CreateViewabilityProviderAsync(parent, viewabilityProvider);
            // End snippet
        }

        /// <summary>Snippet for CreateViewabilityProvider</summary>
        public void CreateViewabilityProviderResourceNames()
        {
            // Snippet: CreateViewabilityProvider(NetworkName, ViewabilityProvider, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            ViewabilityProvider viewabilityProvider = new ViewabilityProvider();
            // Make the request
            ViewabilityProvider response = viewabilityProviderServiceClient.CreateViewabilityProvider(parent, viewabilityProvider);
            // End snippet
        }

        /// <summary>Snippet for CreateViewabilityProviderAsync</summary>
        public async Task CreateViewabilityProviderResourceNamesAsync()
        {
            // Snippet: CreateViewabilityProviderAsync(NetworkName, ViewabilityProvider, CallSettings)
            // Additional: CreateViewabilityProviderAsync(NetworkName, ViewabilityProvider, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            ViewabilityProvider viewabilityProvider = new ViewabilityProvider();
            // Make the request
            ViewabilityProvider response = await viewabilityProviderServiceClient.CreateViewabilityProviderAsync(parent, viewabilityProvider);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateViewabilityProviders</summary>
        public void BatchCreateViewabilityProvidersRequestObject()
        {
            // Snippet: BatchCreateViewabilityProviders(BatchCreateViewabilityProvidersRequest, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateViewabilityProvidersRequest request = new BatchCreateViewabilityProvidersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateViewabilityProviderRequest(),
                },
            };
            // Make the request
            BatchCreateViewabilityProvidersResponse response = viewabilityProviderServiceClient.BatchCreateViewabilityProviders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateViewabilityProvidersAsync</summary>
        public async Task BatchCreateViewabilityProvidersRequestObjectAsync()
        {
            // Snippet: BatchCreateViewabilityProvidersAsync(BatchCreateViewabilityProvidersRequest, CallSettings)
            // Additional: BatchCreateViewabilityProvidersAsync(BatchCreateViewabilityProvidersRequest, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateViewabilityProvidersRequest request = new BatchCreateViewabilityProvidersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new CreateViewabilityProviderRequest(),
                },
            };
            // Make the request
            BatchCreateViewabilityProvidersResponse response = await viewabilityProviderServiceClient.BatchCreateViewabilityProvidersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateViewabilityProviders</summary>
        public void BatchCreateViewabilityProviders()
        {
            // Snippet: BatchCreateViewabilityProviders(string, IEnumerable<CreateViewabilityProviderRequest>, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateViewabilityProviderRequest> requests = new CreateViewabilityProviderRequest[]
            {
                new CreateViewabilityProviderRequest(),
            };
            // Make the request
            BatchCreateViewabilityProvidersResponse response = viewabilityProviderServiceClient.BatchCreateViewabilityProviders(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateViewabilityProvidersAsync</summary>
        public async Task BatchCreateViewabilityProvidersAsync()
        {
            // Snippet: BatchCreateViewabilityProvidersAsync(string, IEnumerable<CreateViewabilityProviderRequest>, CallSettings)
            // Additional: BatchCreateViewabilityProvidersAsync(string, IEnumerable<CreateViewabilityProviderRequest>, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<CreateViewabilityProviderRequest> requests = new CreateViewabilityProviderRequest[]
            {
                new CreateViewabilityProviderRequest(),
            };
            // Make the request
            BatchCreateViewabilityProvidersResponse response = await viewabilityProviderServiceClient.BatchCreateViewabilityProvidersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateViewabilityProviders</summary>
        public void BatchCreateViewabilityProvidersResourceNames()
        {
            // Snippet: BatchCreateViewabilityProviders(NetworkName, IEnumerable<CreateViewabilityProviderRequest>, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateViewabilityProviderRequest> requests = new CreateViewabilityProviderRequest[]
            {
                new CreateViewabilityProviderRequest(),
            };
            // Make the request
            BatchCreateViewabilityProvidersResponse response = viewabilityProviderServiceClient.BatchCreateViewabilityProviders(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateViewabilityProvidersAsync</summary>
        public async Task BatchCreateViewabilityProvidersResourceNamesAsync()
        {
            // Snippet: BatchCreateViewabilityProvidersAsync(NetworkName, IEnumerable<CreateViewabilityProviderRequest>, CallSettings)
            // Additional: BatchCreateViewabilityProvidersAsync(NetworkName, IEnumerable<CreateViewabilityProviderRequest>, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<CreateViewabilityProviderRequest> requests = new CreateViewabilityProviderRequest[]
            {
                new CreateViewabilityProviderRequest(),
            };
            // Make the request
            BatchCreateViewabilityProvidersResponse response = await viewabilityProviderServiceClient.BatchCreateViewabilityProvidersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for UpdateViewabilityProvider</summary>
        public void UpdateViewabilityProviderRequestObject()
        {
            // Snippet: UpdateViewabilityProvider(UpdateViewabilityProviderRequest, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            UpdateViewabilityProviderRequest request = new UpdateViewabilityProviderRequest
            {
                ViewabilityProvider = new ViewabilityProvider(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ViewabilityProvider response = viewabilityProviderServiceClient.UpdateViewabilityProvider(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateViewabilityProviderAsync</summary>
        public async Task UpdateViewabilityProviderRequestObjectAsync()
        {
            // Snippet: UpdateViewabilityProviderAsync(UpdateViewabilityProviderRequest, CallSettings)
            // Additional: UpdateViewabilityProviderAsync(UpdateViewabilityProviderRequest, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateViewabilityProviderRequest request = new UpdateViewabilityProviderRequest
            {
                ViewabilityProvider = new ViewabilityProvider(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ViewabilityProvider response = await viewabilityProviderServiceClient.UpdateViewabilityProviderAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateViewabilityProvider</summary>
        public void UpdateViewabilityProvider()
        {
            // Snippet: UpdateViewabilityProvider(ViewabilityProvider, FieldMask, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            ViewabilityProvider viewabilityProvider = new ViewabilityProvider();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ViewabilityProvider response = viewabilityProviderServiceClient.UpdateViewabilityProvider(viewabilityProvider, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateViewabilityProviderAsync</summary>
        public async Task UpdateViewabilityProviderAsync()
        {
            // Snippet: UpdateViewabilityProviderAsync(ViewabilityProvider, FieldMask, CallSettings)
            // Additional: UpdateViewabilityProviderAsync(ViewabilityProvider, FieldMask, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            ViewabilityProvider viewabilityProvider = new ViewabilityProvider();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ViewabilityProvider response = await viewabilityProviderServiceClient.UpdateViewabilityProviderAsync(viewabilityProvider, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateViewabilityProviders</summary>
        public void BatchUpdateViewabilityProvidersRequestObject()
        {
            // Snippet: BatchUpdateViewabilityProviders(BatchUpdateViewabilityProvidersRequest, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateViewabilityProvidersRequest request = new BatchUpdateViewabilityProvidersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateViewabilityProviderRequest(),
                },
            };
            // Make the request
            BatchUpdateViewabilityProvidersResponse response = viewabilityProviderServiceClient.BatchUpdateViewabilityProviders(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateViewabilityProvidersAsync</summary>
        public async Task BatchUpdateViewabilityProvidersRequestObjectAsync()
        {
            // Snippet: BatchUpdateViewabilityProvidersAsync(BatchUpdateViewabilityProvidersRequest, CallSettings)
            // Additional: BatchUpdateViewabilityProvidersAsync(BatchUpdateViewabilityProvidersRequest, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateViewabilityProvidersRequest request = new BatchUpdateViewabilityProvidersRequest
            {
                ParentAsNetworkName = NetworkName.FromNetworkCode("[NETWORK_CODE]"),
                Requests =
                {
                    new UpdateViewabilityProviderRequest(),
                },
            };
            // Make the request
            BatchUpdateViewabilityProvidersResponse response = await viewabilityProviderServiceClient.BatchUpdateViewabilityProvidersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateViewabilityProviders</summary>
        public void BatchUpdateViewabilityProviders()
        {
            // Snippet: BatchUpdateViewabilityProviders(string, IEnumerable<UpdateViewabilityProviderRequest>, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateViewabilityProviderRequest> requests = new UpdateViewabilityProviderRequest[]
            {
                new UpdateViewabilityProviderRequest(),
            };
            // Make the request
            BatchUpdateViewabilityProvidersResponse response = viewabilityProviderServiceClient.BatchUpdateViewabilityProviders(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateViewabilityProvidersAsync</summary>
        public async Task BatchUpdateViewabilityProvidersAsync()
        {
            // Snippet: BatchUpdateViewabilityProvidersAsync(string, IEnumerable<UpdateViewabilityProviderRequest>, CallSettings)
            // Additional: BatchUpdateViewabilityProvidersAsync(string, IEnumerable<UpdateViewabilityProviderRequest>, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "networks/[NETWORK_CODE]";
            IEnumerable<UpdateViewabilityProviderRequest> requests = new UpdateViewabilityProviderRequest[]
            {
                new UpdateViewabilityProviderRequest(),
            };
            // Make the request
            BatchUpdateViewabilityProvidersResponse response = await viewabilityProviderServiceClient.BatchUpdateViewabilityProvidersAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateViewabilityProviders</summary>
        public void BatchUpdateViewabilityProvidersResourceNames()
        {
            // Snippet: BatchUpdateViewabilityProviders(NetworkName, IEnumerable<UpdateViewabilityProviderRequest>, CallSettings)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = ViewabilityProviderServiceClient.Create();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateViewabilityProviderRequest> requests = new UpdateViewabilityProviderRequest[]
            {
                new UpdateViewabilityProviderRequest(),
            };
            // Make the request
            BatchUpdateViewabilityProvidersResponse response = viewabilityProviderServiceClient.BatchUpdateViewabilityProviders(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateViewabilityProvidersAsync</summary>
        public async Task BatchUpdateViewabilityProvidersResourceNamesAsync()
        {
            // Snippet: BatchUpdateViewabilityProvidersAsync(NetworkName, IEnumerable<UpdateViewabilityProviderRequest>, CallSettings)
            // Additional: BatchUpdateViewabilityProvidersAsync(NetworkName, IEnumerable<UpdateViewabilityProviderRequest>, CancellationToken)
            // Create client
            ViewabilityProviderServiceClient viewabilityProviderServiceClient = await ViewabilityProviderServiceClient.CreateAsync();
            // Initialize request argument(s)
            NetworkName parent = NetworkName.FromNetworkCode("[NETWORK_CODE]");
            IEnumerable<UpdateViewabilityProviderRequest> requests = new UpdateViewabilityProviderRequest[]
            {
                new UpdateViewabilityProviderRequest(),
            };
            // Make the request
            BatchUpdateViewabilityProvidersResponse response = await viewabilityProviderServiceClient.BatchUpdateViewabilityProvidersAsync(parent, requests);
            // End snippet
        }
    }
}
