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
    using Google.Api.Gax;
    using Google.Cloud.Chronicle.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedNativeDashboardServiceClientSnippets
    {
        /// <summary>Snippet for CreateNativeDashboard</summary>
        public void CreateNativeDashboardRequestObject()
        {
            // Snippet: CreateNativeDashboard(CreateNativeDashboardRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            CreateNativeDashboardRequest request = new CreateNativeDashboardRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                NativeDashboard = new NativeDashboard(),
            };
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.CreateNativeDashboard(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNativeDashboardAsync</summary>
        public async Task CreateNativeDashboardRequestObjectAsync()
        {
            // Snippet: CreateNativeDashboardAsync(CreateNativeDashboardRequest, CallSettings)
            // Additional: CreateNativeDashboardAsync(CreateNativeDashboardRequest, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateNativeDashboardRequest request = new CreateNativeDashboardRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                NativeDashboard = new NativeDashboard(),
            };
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.CreateNativeDashboardAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateNativeDashboard</summary>
        public void CreateNativeDashboard()
        {
            // Snippet: CreateNativeDashboard(string, NativeDashboard, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            NativeDashboard nativeDashboard = new NativeDashboard();
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.CreateNativeDashboard(parent, nativeDashboard);
            // End snippet
        }

        /// <summary>Snippet for CreateNativeDashboardAsync</summary>
        public async Task CreateNativeDashboardAsync()
        {
            // Snippet: CreateNativeDashboardAsync(string, NativeDashboard, CallSettings)
            // Additional: CreateNativeDashboardAsync(string, NativeDashboard, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            NativeDashboard nativeDashboard = new NativeDashboard();
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.CreateNativeDashboardAsync(parent, nativeDashboard);
            // End snippet
        }

        /// <summary>Snippet for CreateNativeDashboard</summary>
        public void CreateNativeDashboardResourceNames()
        {
            // Snippet: CreateNativeDashboard(InstanceName, NativeDashboard, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            NativeDashboard nativeDashboard = new NativeDashboard();
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.CreateNativeDashboard(parent, nativeDashboard);
            // End snippet
        }

        /// <summary>Snippet for CreateNativeDashboardAsync</summary>
        public async Task CreateNativeDashboardResourceNamesAsync()
        {
            // Snippet: CreateNativeDashboardAsync(InstanceName, NativeDashboard, CallSettings)
            // Additional: CreateNativeDashboardAsync(InstanceName, NativeDashboard, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            NativeDashboard nativeDashboard = new NativeDashboard();
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.CreateNativeDashboardAsync(parent, nativeDashboard);
            // End snippet
        }

        /// <summary>Snippet for GetNativeDashboard</summary>
        public void GetNativeDashboardRequestObject()
        {
            // Snippet: GetNativeDashboard(GetNativeDashboardRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            GetNativeDashboardRequest request = new GetNativeDashboardRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
                View = NativeDashboardView.Unspecified,
            };
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.GetNativeDashboard(request);
            // End snippet
        }

        /// <summary>Snippet for GetNativeDashboardAsync</summary>
        public async Task GetNativeDashboardRequestObjectAsync()
        {
            // Snippet: GetNativeDashboardAsync(GetNativeDashboardRequest, CallSettings)
            // Additional: GetNativeDashboardAsync(GetNativeDashboardRequest, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetNativeDashboardRequest request = new GetNativeDashboardRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
                View = NativeDashboardView.Unspecified,
            };
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.GetNativeDashboardAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetNativeDashboard</summary>
        public void GetNativeDashboard()
        {
            // Snippet: GetNativeDashboard(string, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.GetNativeDashboard(name);
            // End snippet
        }

        /// <summary>Snippet for GetNativeDashboardAsync</summary>
        public async Task GetNativeDashboardAsync()
        {
            // Snippet: GetNativeDashboardAsync(string, CallSettings)
            // Additional: GetNativeDashboardAsync(string, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.GetNativeDashboardAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetNativeDashboard</summary>
        public void GetNativeDashboardResourceNames()
        {
            // Snippet: GetNativeDashboard(NativeDashboardName, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.GetNativeDashboard(name);
            // End snippet
        }

        /// <summary>Snippet for GetNativeDashboardAsync</summary>
        public async Task GetNativeDashboardResourceNamesAsync()
        {
            // Snippet: GetNativeDashboardAsync(NativeDashboardName, CallSettings)
            // Additional: GetNativeDashboardAsync(NativeDashboardName, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.GetNativeDashboardAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListNativeDashboards</summary>
        public void ListNativeDashboardsRequestObject()
        {
            // Snippet: ListNativeDashboards(ListNativeDashboardsRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            ListNativeDashboardsRequest request = new ListNativeDashboardsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = NativeDashboardView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListNativeDashboardsResponse, NativeDashboard> response = nativeDashboardServiceClient.ListNativeDashboards(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NativeDashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNativeDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NativeDashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NativeDashboard> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NativeDashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNativeDashboardsAsync</summary>
        public async Task ListNativeDashboardsRequestObjectAsync()
        {
            // Snippet: ListNativeDashboardsAsync(ListNativeDashboardsRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListNativeDashboardsRequest request = new ListNativeDashboardsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = NativeDashboardView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListNativeDashboardsResponse, NativeDashboard> response = nativeDashboardServiceClient.ListNativeDashboardsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (NativeDashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListNativeDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NativeDashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NativeDashboard> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NativeDashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNativeDashboards</summary>
        public void ListNativeDashboards()
        {
            // Snippet: ListNativeDashboards(string, string, int?, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListNativeDashboardsResponse, NativeDashboard> response = nativeDashboardServiceClient.ListNativeDashboards(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NativeDashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNativeDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NativeDashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NativeDashboard> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NativeDashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNativeDashboardsAsync</summary>
        public async Task ListNativeDashboardsAsync()
        {
            // Snippet: ListNativeDashboardsAsync(string, string, int?, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListNativeDashboardsResponse, NativeDashboard> response = nativeDashboardServiceClient.ListNativeDashboardsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (NativeDashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListNativeDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NativeDashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NativeDashboard> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NativeDashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNativeDashboards</summary>
        public void ListNativeDashboardsResourceNames()
        {
            // Snippet: ListNativeDashboards(InstanceName, string, int?, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListNativeDashboardsResponse, NativeDashboard> response = nativeDashboardServiceClient.ListNativeDashboards(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (NativeDashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListNativeDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NativeDashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NativeDashboard> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NativeDashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListNativeDashboardsAsync</summary>
        public async Task ListNativeDashboardsResourceNamesAsync()
        {
            // Snippet: ListNativeDashboardsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListNativeDashboardsResponse, NativeDashboard> response = nativeDashboardServiceClient.ListNativeDashboardsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (NativeDashboard item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListNativeDashboardsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (NativeDashboard item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<NativeDashboard> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (NativeDashboard item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateNativeDashboard</summary>
        public void UpdateNativeDashboardRequestObject()
        {
            // Snippet: UpdateNativeDashboard(UpdateNativeDashboardRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            UpdateNativeDashboardRequest request = new UpdateNativeDashboardRequest
            {
                NativeDashboard = new NativeDashboard(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.UpdateNativeDashboard(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNativeDashboardAsync</summary>
        public async Task UpdateNativeDashboardRequestObjectAsync()
        {
            // Snippet: UpdateNativeDashboardAsync(UpdateNativeDashboardRequest, CallSettings)
            // Additional: UpdateNativeDashboardAsync(UpdateNativeDashboardRequest, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateNativeDashboardRequest request = new UpdateNativeDashboardRequest
            {
                NativeDashboard = new NativeDashboard(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.UpdateNativeDashboardAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateNativeDashboard</summary>
        public void UpdateNativeDashboard()
        {
            // Snippet: UpdateNativeDashboard(NativeDashboard, FieldMask, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            NativeDashboard nativeDashboard = new NativeDashboard();
            FieldMask updateMask = new FieldMask();
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.UpdateNativeDashboard(nativeDashboard, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateNativeDashboardAsync</summary>
        public async Task UpdateNativeDashboardAsync()
        {
            // Snippet: UpdateNativeDashboardAsync(NativeDashboard, FieldMask, CallSettings)
            // Additional: UpdateNativeDashboardAsync(NativeDashboard, FieldMask, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            NativeDashboard nativeDashboard = new NativeDashboard();
            FieldMask updateMask = new FieldMask();
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.UpdateNativeDashboardAsync(nativeDashboard, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DuplicateNativeDashboard</summary>
        public void DuplicateNativeDashboardRequestObject()
        {
            // Snippet: DuplicateNativeDashboard(DuplicateNativeDashboardRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            DuplicateNativeDashboardRequest request = new DuplicateNativeDashboardRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
                NativeDashboard = new NativeDashboard(),
            };
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.DuplicateNativeDashboard(request);
            // End snippet
        }

        /// <summary>Snippet for DuplicateNativeDashboardAsync</summary>
        public async Task DuplicateNativeDashboardRequestObjectAsync()
        {
            // Snippet: DuplicateNativeDashboardAsync(DuplicateNativeDashboardRequest, CallSettings)
            // Additional: DuplicateNativeDashboardAsync(DuplicateNativeDashboardRequest, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            DuplicateNativeDashboardRequest request = new DuplicateNativeDashboardRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
                NativeDashboard = new NativeDashboard(),
            };
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.DuplicateNativeDashboardAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DuplicateNativeDashboard</summary>
        public void DuplicateNativeDashboard()
        {
            // Snippet: DuplicateNativeDashboard(string, NativeDashboard, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            NativeDashboard nativeDashboard = new NativeDashboard();
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.DuplicateNativeDashboard(name, nativeDashboard);
            // End snippet
        }

        /// <summary>Snippet for DuplicateNativeDashboardAsync</summary>
        public async Task DuplicateNativeDashboardAsync()
        {
            // Snippet: DuplicateNativeDashboardAsync(string, NativeDashboard, CallSettings)
            // Additional: DuplicateNativeDashboardAsync(string, NativeDashboard, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            NativeDashboard nativeDashboard = new NativeDashboard();
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.DuplicateNativeDashboardAsync(name, nativeDashboard);
            // End snippet
        }

        /// <summary>Snippet for DuplicateNativeDashboard</summary>
        public void DuplicateNativeDashboardResourceNames()
        {
            // Snippet: DuplicateNativeDashboard(NativeDashboardName, NativeDashboard, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            NativeDashboard nativeDashboard = new NativeDashboard();
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.DuplicateNativeDashboard(name, nativeDashboard);
            // End snippet
        }

        /// <summary>Snippet for DuplicateNativeDashboardAsync</summary>
        public async Task DuplicateNativeDashboardResourceNamesAsync()
        {
            // Snippet: DuplicateNativeDashboardAsync(NativeDashboardName, NativeDashboard, CallSettings)
            // Additional: DuplicateNativeDashboardAsync(NativeDashboardName, NativeDashboard, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            NativeDashboard nativeDashboard = new NativeDashboard();
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.DuplicateNativeDashboardAsync(name, nativeDashboard);
            // End snippet
        }

        /// <summary>Snippet for DeleteNativeDashboard</summary>
        public void DeleteNativeDashboardRequestObject()
        {
            // Snippet: DeleteNativeDashboard(DeleteNativeDashboardRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            DeleteNativeDashboardRequest request = new DeleteNativeDashboardRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
            };
            // Make the request
            nativeDashboardServiceClient.DeleteNativeDashboard(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNativeDashboardAsync</summary>
        public async Task DeleteNativeDashboardRequestObjectAsync()
        {
            // Snippet: DeleteNativeDashboardAsync(DeleteNativeDashboardRequest, CallSettings)
            // Additional: DeleteNativeDashboardAsync(DeleteNativeDashboardRequest, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteNativeDashboardRequest request = new DeleteNativeDashboardRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
            };
            // Make the request
            await nativeDashboardServiceClient.DeleteNativeDashboardAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteNativeDashboard</summary>
        public void DeleteNativeDashboard()
        {
            // Snippet: DeleteNativeDashboard(string, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            // Make the request
            nativeDashboardServiceClient.DeleteNativeDashboard(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNativeDashboardAsync</summary>
        public async Task DeleteNativeDashboardAsync()
        {
            // Snippet: DeleteNativeDashboardAsync(string, CallSettings)
            // Additional: DeleteNativeDashboardAsync(string, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            // Make the request
            await nativeDashboardServiceClient.DeleteNativeDashboardAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNativeDashboard</summary>
        public void DeleteNativeDashboardResourceNames()
        {
            // Snippet: DeleteNativeDashboard(NativeDashboardName, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            // Make the request
            nativeDashboardServiceClient.DeleteNativeDashboard(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteNativeDashboardAsync</summary>
        public async Task DeleteNativeDashboardResourceNamesAsync()
        {
            // Snippet: DeleteNativeDashboardAsync(NativeDashboardName, CallSettings)
            // Additional: DeleteNativeDashboardAsync(NativeDashboardName, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            // Make the request
            await nativeDashboardServiceClient.DeleteNativeDashboardAsync(name);
            // End snippet
        }

        /// <summary>Snippet for AddChart</summary>
        public void AddChartRequestObject()
        {
            // Snippet: AddChart(AddChartRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            AddChartRequest request = new AddChartRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
                DashboardQuery = new DashboardQuery(),
                DashboardChart = new DashboardChart(),
                ChartLayout = new DashboardDefinition.Types.ChartConfig.Types.ChartLayout(),
            };
            // Make the request
            AddChartResponse response = nativeDashboardServiceClient.AddChart(request);
            // End snippet
        }

        /// <summary>Snippet for AddChartAsync</summary>
        public async Task AddChartRequestObjectAsync()
        {
            // Snippet: AddChartAsync(AddChartRequest, CallSettings)
            // Additional: AddChartAsync(AddChartRequest, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            AddChartRequest request = new AddChartRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
                DashboardQuery = new DashboardQuery(),
                DashboardChart = new DashboardChart(),
                ChartLayout = new DashboardDefinition.Types.ChartConfig.Types.ChartLayout(),
            };
            // Make the request
            AddChartResponse response = await nativeDashboardServiceClient.AddChartAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddChart</summary>
        public void AddChart()
        {
            // Snippet: AddChart(string, DashboardQuery, DashboardChart, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            DashboardQuery dashboardQuery = new DashboardQuery();
            DashboardChart dashboardChart = new DashboardChart();
            // Make the request
            AddChartResponse response = nativeDashboardServiceClient.AddChart(name, dashboardQuery, dashboardChart);
            // End snippet
        }

        /// <summary>Snippet for AddChartAsync</summary>
        public async Task AddChartAsync()
        {
            // Snippet: AddChartAsync(string, DashboardQuery, DashboardChart, CallSettings)
            // Additional: AddChartAsync(string, DashboardQuery, DashboardChart, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            DashboardQuery dashboardQuery = new DashboardQuery();
            DashboardChart dashboardChart = new DashboardChart();
            // Make the request
            AddChartResponse response = await nativeDashboardServiceClient.AddChartAsync(name, dashboardQuery, dashboardChart);
            // End snippet
        }

        /// <summary>Snippet for AddChart</summary>
        public void AddChartResourceNames()
        {
            // Snippet: AddChart(NativeDashboardName, DashboardQuery, DashboardChart, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            DashboardQuery dashboardQuery = new DashboardQuery();
            DashboardChart dashboardChart = new DashboardChart();
            // Make the request
            AddChartResponse response = nativeDashboardServiceClient.AddChart(name, dashboardQuery, dashboardChart);
            // End snippet
        }

        /// <summary>Snippet for AddChartAsync</summary>
        public async Task AddChartResourceNamesAsync()
        {
            // Snippet: AddChartAsync(NativeDashboardName, DashboardQuery, DashboardChart, CallSettings)
            // Additional: AddChartAsync(NativeDashboardName, DashboardQuery, DashboardChart, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            DashboardQuery dashboardQuery = new DashboardQuery();
            DashboardChart dashboardChart = new DashboardChart();
            // Make the request
            AddChartResponse response = await nativeDashboardServiceClient.AddChartAsync(name, dashboardQuery, dashboardChart);
            // End snippet
        }

        /// <summary>Snippet for RemoveChart</summary>
        public void RemoveChartRequestObject()
        {
            // Snippet: RemoveChart(RemoveChartRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            RemoveChartRequest request = new RemoveChartRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
                DashboardChartAsDashboardChartName = DashboardChartName.FromProjectLocationInstanceChart("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[CHART]"),
            };
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.RemoveChart(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveChartAsync</summary>
        public async Task RemoveChartRequestObjectAsync()
        {
            // Snippet: RemoveChartAsync(RemoveChartRequest, CallSettings)
            // Additional: RemoveChartAsync(RemoveChartRequest, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            RemoveChartRequest request = new RemoveChartRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
                DashboardChartAsDashboardChartName = DashboardChartName.FromProjectLocationInstanceChart("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[CHART]"),
            };
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.RemoveChartAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RemoveChart</summary>
        public void RemoveChart()
        {
            // Snippet: RemoveChart(string, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.RemoveChart(name);
            // End snippet
        }

        /// <summary>Snippet for RemoveChartAsync</summary>
        public async Task RemoveChartAsync()
        {
            // Snippet: RemoveChartAsync(string, CallSettings)
            // Additional: RemoveChartAsync(string, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.RemoveChartAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RemoveChart</summary>
        public void RemoveChartResourceNames()
        {
            // Snippet: RemoveChart(NativeDashboardName, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            // Make the request
            NativeDashboard response = nativeDashboardServiceClient.RemoveChart(name);
            // End snippet
        }

        /// <summary>Snippet for RemoveChartAsync</summary>
        public async Task RemoveChartResourceNamesAsync()
        {
            // Snippet: RemoveChartAsync(NativeDashboardName, CallSettings)
            // Additional: RemoveChartAsync(NativeDashboardName, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            // Make the request
            NativeDashboard response = await nativeDashboardServiceClient.RemoveChartAsync(name);
            // End snippet
        }

        /// <summary>Snippet for EditChart</summary>
        public void EditChartRequestObject()
        {
            // Snippet: EditChart(EditChartRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            EditChartRequest request = new EditChartRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
                DashboardQuery = new DashboardQuery(),
                DashboardChart = new DashboardChart(),
                EditMask = new FieldMask(),
                LanguageFeatures =
                {
                    LanguageFeature.Unspecified,
                },
            };
            // Make the request
            EditChartResponse response = nativeDashboardServiceClient.EditChart(request);
            // End snippet
        }

        /// <summary>Snippet for EditChartAsync</summary>
        public async Task EditChartRequestObjectAsync()
        {
            // Snippet: EditChartAsync(EditChartRequest, CallSettings)
            // Additional: EditChartAsync(EditChartRequest, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            EditChartRequest request = new EditChartRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
                DashboardQuery = new DashboardQuery(),
                DashboardChart = new DashboardChart(),
                EditMask = new FieldMask(),
                LanguageFeatures =
                {
                    LanguageFeature.Unspecified,
                },
            };
            // Make the request
            EditChartResponse response = await nativeDashboardServiceClient.EditChartAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EditChart</summary>
        public void EditChart()
        {
            // Snippet: EditChart(string, DashboardQuery, DashboardChart, FieldMask, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            DashboardQuery dashboardQuery = new DashboardQuery();
            DashboardChart dashboardChart = new DashboardChart();
            FieldMask editMask = new FieldMask();
            // Make the request
            EditChartResponse response = nativeDashboardServiceClient.EditChart(name, dashboardQuery, dashboardChart, editMask);
            // End snippet
        }

        /// <summary>Snippet for EditChartAsync</summary>
        public async Task EditChartAsync()
        {
            // Snippet: EditChartAsync(string, DashboardQuery, DashboardChart, FieldMask, CallSettings)
            // Additional: EditChartAsync(string, DashboardQuery, DashboardChart, FieldMask, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            DashboardQuery dashboardQuery = new DashboardQuery();
            DashboardChart dashboardChart = new DashboardChart();
            FieldMask editMask = new FieldMask();
            // Make the request
            EditChartResponse response = await nativeDashboardServiceClient.EditChartAsync(name, dashboardQuery, dashboardChart, editMask);
            // End snippet
        }

        /// <summary>Snippet for EditChart</summary>
        public void EditChartResourceNames()
        {
            // Snippet: EditChart(NativeDashboardName, DashboardQuery, DashboardChart, FieldMask, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            DashboardQuery dashboardQuery = new DashboardQuery();
            DashboardChart dashboardChart = new DashboardChart();
            FieldMask editMask = new FieldMask();
            // Make the request
            EditChartResponse response = nativeDashboardServiceClient.EditChart(name, dashboardQuery, dashboardChart, editMask);
            // End snippet
        }

        /// <summary>Snippet for EditChartAsync</summary>
        public async Task EditChartResourceNamesAsync()
        {
            // Snippet: EditChartAsync(NativeDashboardName, DashboardQuery, DashboardChart, FieldMask, CallSettings)
            // Additional: EditChartAsync(NativeDashboardName, DashboardQuery, DashboardChart, FieldMask, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            DashboardQuery dashboardQuery = new DashboardQuery();
            DashboardChart dashboardChart = new DashboardChart();
            FieldMask editMask = new FieldMask();
            // Make the request
            EditChartResponse response = await nativeDashboardServiceClient.EditChartAsync(name, dashboardQuery, dashboardChart, editMask);
            // End snippet
        }

        /// <summary>Snippet for DuplicateChart</summary>
        public void DuplicateChartRequestObject()
        {
            // Snippet: DuplicateChart(DuplicateChartRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            DuplicateChartRequest request = new DuplicateChartRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
                DashboardChartAsDashboardChartName = DashboardChartName.FromProjectLocationInstanceChart("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[CHART]"),
            };
            // Make the request
            DuplicateChartResponse response = nativeDashboardServiceClient.DuplicateChart(request);
            // End snippet
        }

        /// <summary>Snippet for DuplicateChartAsync</summary>
        public async Task DuplicateChartRequestObjectAsync()
        {
            // Snippet: DuplicateChartAsync(DuplicateChartRequest, CallSettings)
            // Additional: DuplicateChartAsync(DuplicateChartRequest, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            DuplicateChartRequest request = new DuplicateChartRequest
            {
                NativeDashboardName = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]"),
                DashboardChartAsDashboardChartName = DashboardChartName.FromProjectLocationInstanceChart("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[CHART]"),
            };
            // Make the request
            DuplicateChartResponse response = await nativeDashboardServiceClient.DuplicateChartAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DuplicateChart</summary>
        public void DuplicateChart()
        {
            // Snippet: DuplicateChart(string, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            // Make the request
            DuplicateChartResponse response = nativeDashboardServiceClient.DuplicateChart(name);
            // End snippet
        }

        /// <summary>Snippet for DuplicateChartAsync</summary>
        public async Task DuplicateChartAsync()
        {
            // Snippet: DuplicateChartAsync(string, CallSettings)
            // Additional: DuplicateChartAsync(string, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/nativeDashboards/[DASHBOARD]";
            // Make the request
            DuplicateChartResponse response = await nativeDashboardServiceClient.DuplicateChartAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DuplicateChart</summary>
        public void DuplicateChartResourceNames()
        {
            // Snippet: DuplicateChart(NativeDashboardName, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            // Make the request
            DuplicateChartResponse response = nativeDashboardServiceClient.DuplicateChart(name);
            // End snippet
        }

        /// <summary>Snippet for DuplicateChartAsync</summary>
        public async Task DuplicateChartResourceNamesAsync()
        {
            // Snippet: DuplicateChartAsync(NativeDashboardName, CallSettings)
            // Additional: DuplicateChartAsync(NativeDashboardName, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            NativeDashboardName name = NativeDashboardName.FromProjectLocationInstanceDashboard("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DASHBOARD]");
            // Make the request
            DuplicateChartResponse response = await nativeDashboardServiceClient.DuplicateChartAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ExportNativeDashboards</summary>
        public void ExportNativeDashboardsRequestObject()
        {
            // Snippet: ExportNativeDashboards(ExportNativeDashboardsRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            ExportNativeDashboardsRequest request = new ExportNativeDashboardsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Names = { "", },
            };
            // Make the request
            ExportNativeDashboardsResponse response = nativeDashboardServiceClient.ExportNativeDashboards(request);
            // End snippet
        }

        /// <summary>Snippet for ExportNativeDashboardsAsync</summary>
        public async Task ExportNativeDashboardsRequestObjectAsync()
        {
            // Snippet: ExportNativeDashboardsAsync(ExportNativeDashboardsRequest, CallSettings)
            // Additional: ExportNativeDashboardsAsync(ExportNativeDashboardsRequest, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExportNativeDashboardsRequest request = new ExportNativeDashboardsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Names = { "", },
            };
            // Make the request
            ExportNativeDashboardsResponse response = await nativeDashboardServiceClient.ExportNativeDashboardsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExportNativeDashboards</summary>
        public void ExportNativeDashboards()
        {
            // Snippet: ExportNativeDashboards(string, IEnumerable<string>, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            ExportNativeDashboardsResponse response = nativeDashboardServiceClient.ExportNativeDashboards(parent, names);
            // End snippet
        }

        /// <summary>Snippet for ExportNativeDashboardsAsync</summary>
        public async Task ExportNativeDashboardsAsync()
        {
            // Snippet: ExportNativeDashboardsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: ExportNativeDashboardsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            ExportNativeDashboardsResponse response = await nativeDashboardServiceClient.ExportNativeDashboardsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for ExportNativeDashboards</summary>
        public void ExportNativeDashboardsResourceNames()
        {
            // Snippet: ExportNativeDashboards(InstanceName, IEnumerable<string>, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            ExportNativeDashboardsResponse response = nativeDashboardServiceClient.ExportNativeDashboards(parent, names);
            // End snippet
        }

        /// <summary>Snippet for ExportNativeDashboardsAsync</summary>
        public async Task ExportNativeDashboardsResourceNamesAsync()
        {
            // Snippet: ExportNativeDashboardsAsync(InstanceName, IEnumerable<string>, CallSettings)
            // Additional: ExportNativeDashboardsAsync(InstanceName, IEnumerable<string>, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            IEnumerable<string> names = new string[] { "", };
            // Make the request
            ExportNativeDashboardsResponse response = await nativeDashboardServiceClient.ExportNativeDashboardsAsync(parent, names);
            // End snippet
        }

        /// <summary>Snippet for ImportNativeDashboards</summary>
        public void ImportNativeDashboardsRequestObject()
        {
            // Snippet: ImportNativeDashboards(ImportNativeDashboardsRequest, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            ImportNativeDashboardsRequest request = new ImportNativeDashboardsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Source = new ImportNativeDashboardsInlineSource(),
            };
            // Make the request
            ImportNativeDashboardsResponse response = nativeDashboardServiceClient.ImportNativeDashboards(request);
            // End snippet
        }

        /// <summary>Snippet for ImportNativeDashboardsAsync</summary>
        public async Task ImportNativeDashboardsRequestObjectAsync()
        {
            // Snippet: ImportNativeDashboardsAsync(ImportNativeDashboardsRequest, CallSettings)
            // Additional: ImportNativeDashboardsAsync(ImportNativeDashboardsRequest, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            ImportNativeDashboardsRequest request = new ImportNativeDashboardsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Source = new ImportNativeDashboardsInlineSource(),
            };
            // Make the request
            ImportNativeDashboardsResponse response = await nativeDashboardServiceClient.ImportNativeDashboardsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportNativeDashboards</summary>
        public void ImportNativeDashboards()
        {
            // Snippet: ImportNativeDashboards(string, ImportNativeDashboardsInlineSource, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            ImportNativeDashboardsInlineSource source = new ImportNativeDashboardsInlineSource();
            // Make the request
            ImportNativeDashboardsResponse response = nativeDashboardServiceClient.ImportNativeDashboards(parent, source);
            // End snippet
        }

        /// <summary>Snippet for ImportNativeDashboardsAsync</summary>
        public async Task ImportNativeDashboardsAsync()
        {
            // Snippet: ImportNativeDashboardsAsync(string, ImportNativeDashboardsInlineSource, CallSettings)
            // Additional: ImportNativeDashboardsAsync(string, ImportNativeDashboardsInlineSource, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            ImportNativeDashboardsInlineSource source = new ImportNativeDashboardsInlineSource();
            // Make the request
            ImportNativeDashboardsResponse response = await nativeDashboardServiceClient.ImportNativeDashboardsAsync(parent, source);
            // End snippet
        }

        /// <summary>Snippet for ImportNativeDashboards</summary>
        public void ImportNativeDashboardsResourceNames()
        {
            // Snippet: ImportNativeDashboards(InstanceName, ImportNativeDashboardsInlineSource, CallSettings)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = NativeDashboardServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            ImportNativeDashboardsInlineSource source = new ImportNativeDashboardsInlineSource();
            // Make the request
            ImportNativeDashboardsResponse response = nativeDashboardServiceClient.ImportNativeDashboards(parent, source);
            // End snippet
        }

        /// <summary>Snippet for ImportNativeDashboardsAsync</summary>
        public async Task ImportNativeDashboardsResourceNamesAsync()
        {
            // Snippet: ImportNativeDashboardsAsync(InstanceName, ImportNativeDashboardsInlineSource, CallSettings)
            // Additional: ImportNativeDashboardsAsync(InstanceName, ImportNativeDashboardsInlineSource, CancellationToken)
            // Create client
            NativeDashboardServiceClient nativeDashboardServiceClient = await NativeDashboardServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            ImportNativeDashboardsInlineSource source = new ImportNativeDashboardsInlineSource();
            // Make the request
            ImportNativeDashboardsResponse response = await nativeDashboardServiceClient.ImportNativeDashboardsAsync(parent, source);
            // End snippet
        }
    }
}
