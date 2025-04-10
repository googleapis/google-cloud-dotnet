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
    using Google.Cloud.Chronicle.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedReferenceListServiceClientSnippets
    {
        /// <summary>Snippet for GetReferenceList</summary>
        public void GetReferenceListRequestObject()
        {
            // Snippet: GetReferenceList(GetReferenceListRequest, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = ReferenceListServiceClient.Create();
            // Initialize request argument(s)
            GetReferenceListRequest request = new GetReferenceListRequest
            {
                ReferenceListName = ReferenceListName.FromProjectLocationInstanceReferenceList("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[REFERENCE_LIST]"),
                View = ReferenceListView.Unspecified,
            };
            // Make the request
            ReferenceList response = referenceListServiceClient.GetReferenceList(request);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceListAsync</summary>
        public async Task GetReferenceListRequestObjectAsync()
        {
            // Snippet: GetReferenceListAsync(GetReferenceListRequest, CallSettings)
            // Additional: GetReferenceListAsync(GetReferenceListRequest, CancellationToken)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = await ReferenceListServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetReferenceListRequest request = new GetReferenceListRequest
            {
                ReferenceListName = ReferenceListName.FromProjectLocationInstanceReferenceList("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[REFERENCE_LIST]"),
                View = ReferenceListView.Unspecified,
            };
            // Make the request
            ReferenceList response = await referenceListServiceClient.GetReferenceListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceList</summary>
        public void GetReferenceList()
        {
            // Snippet: GetReferenceList(string, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = ReferenceListServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/referenceLists/[REFERENCE_LIST]";
            // Make the request
            ReferenceList response = referenceListServiceClient.GetReferenceList(name);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceListAsync</summary>
        public async Task GetReferenceListAsync()
        {
            // Snippet: GetReferenceListAsync(string, CallSettings)
            // Additional: GetReferenceListAsync(string, CancellationToken)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = await ReferenceListServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/referenceLists/[REFERENCE_LIST]";
            // Make the request
            ReferenceList response = await referenceListServiceClient.GetReferenceListAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceList</summary>
        public void GetReferenceListResourceNames()
        {
            // Snippet: GetReferenceList(ReferenceListName, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = ReferenceListServiceClient.Create();
            // Initialize request argument(s)
            ReferenceListName name = ReferenceListName.FromProjectLocationInstanceReferenceList("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[REFERENCE_LIST]");
            // Make the request
            ReferenceList response = referenceListServiceClient.GetReferenceList(name);
            // End snippet
        }

        /// <summary>Snippet for GetReferenceListAsync</summary>
        public async Task GetReferenceListResourceNamesAsync()
        {
            // Snippet: GetReferenceListAsync(ReferenceListName, CallSettings)
            // Additional: GetReferenceListAsync(ReferenceListName, CancellationToken)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = await ReferenceListServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReferenceListName name = ReferenceListName.FromProjectLocationInstanceReferenceList("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[REFERENCE_LIST]");
            // Make the request
            ReferenceList response = await referenceListServiceClient.GetReferenceListAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListReferenceLists</summary>
        public void ListReferenceListsRequestObject()
        {
            // Snippet: ListReferenceLists(ListReferenceListsRequest, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = ReferenceListServiceClient.Create();
            // Initialize request argument(s)
            ListReferenceListsRequest request = new ListReferenceListsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = ReferenceListView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListReferenceListsResponse, ReferenceList> response = referenceListServiceClient.ListReferenceLists(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReferenceList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReferenceListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceList> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceListsAsync</summary>
        public async Task ListReferenceListsRequestObjectAsync()
        {
            // Snippet: ListReferenceListsAsync(ListReferenceListsRequest, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = await ReferenceListServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListReferenceListsRequest request = new ListReferenceListsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                View = ReferenceListView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListReferenceListsResponse, ReferenceList> response = referenceListServiceClient.ListReferenceListsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReferenceList item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReferenceListsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceList> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceLists</summary>
        public void ListReferenceLists()
        {
            // Snippet: ListReferenceLists(string, string, int?, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = ReferenceListServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListReferenceListsResponse, ReferenceList> response = referenceListServiceClient.ListReferenceLists(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReferenceList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReferenceListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceList> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceListsAsync</summary>
        public async Task ListReferenceListsAsync()
        {
            // Snippet: ListReferenceListsAsync(string, string, int?, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = await ReferenceListServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListReferenceListsResponse, ReferenceList> response = referenceListServiceClient.ListReferenceListsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReferenceList item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReferenceListsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceList> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceLists</summary>
        public void ListReferenceListsResourceNames()
        {
            // Snippet: ListReferenceLists(InstanceName, string, int?, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = ReferenceListServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListReferenceListsResponse, ReferenceList> response = referenceListServiceClient.ListReferenceLists(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ReferenceList item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReferenceListsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceList> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReferenceListsAsync</summary>
        public async Task ListReferenceListsResourceNamesAsync()
        {
            // Snippet: ListReferenceListsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = await ReferenceListServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListReferenceListsResponse, ReferenceList> response = referenceListServiceClient.ListReferenceListsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ReferenceList item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReferenceListsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ReferenceList item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ReferenceList> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ReferenceList item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceList</summary>
        public void CreateReferenceListRequestObject()
        {
            // Snippet: CreateReferenceList(CreateReferenceListRequest, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = ReferenceListServiceClient.Create();
            // Initialize request argument(s)
            CreateReferenceListRequest request = new CreateReferenceListRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                ReferenceList = new ReferenceList(),
                ReferenceListId = "",
            };
            // Make the request
            ReferenceList response = referenceListServiceClient.CreateReferenceList(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceListAsync</summary>
        public async Task CreateReferenceListRequestObjectAsync()
        {
            // Snippet: CreateReferenceListAsync(CreateReferenceListRequest, CallSettings)
            // Additional: CreateReferenceListAsync(CreateReferenceListRequest, CancellationToken)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = await ReferenceListServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateReferenceListRequest request = new CreateReferenceListRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                ReferenceList = new ReferenceList(),
                ReferenceListId = "",
            };
            // Make the request
            ReferenceList response = await referenceListServiceClient.CreateReferenceListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceList</summary>
        public void CreateReferenceList()
        {
            // Snippet: CreateReferenceList(string, ReferenceList, string, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = ReferenceListServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            ReferenceList referenceList = new ReferenceList();
            string referenceListId = "";
            // Make the request
            ReferenceList response = referenceListServiceClient.CreateReferenceList(parent, referenceList, referenceListId);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceListAsync</summary>
        public async Task CreateReferenceListAsync()
        {
            // Snippet: CreateReferenceListAsync(string, ReferenceList, string, CallSettings)
            // Additional: CreateReferenceListAsync(string, ReferenceList, string, CancellationToken)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = await ReferenceListServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            ReferenceList referenceList = new ReferenceList();
            string referenceListId = "";
            // Make the request
            ReferenceList response = await referenceListServiceClient.CreateReferenceListAsync(parent, referenceList, referenceListId);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceList</summary>
        public void CreateReferenceListResourceNames()
        {
            // Snippet: CreateReferenceList(InstanceName, ReferenceList, string, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = ReferenceListServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            ReferenceList referenceList = new ReferenceList();
            string referenceListId = "";
            // Make the request
            ReferenceList response = referenceListServiceClient.CreateReferenceList(parent, referenceList, referenceListId);
            // End snippet
        }

        /// <summary>Snippet for CreateReferenceListAsync</summary>
        public async Task CreateReferenceListResourceNamesAsync()
        {
            // Snippet: CreateReferenceListAsync(InstanceName, ReferenceList, string, CallSettings)
            // Additional: CreateReferenceListAsync(InstanceName, ReferenceList, string, CancellationToken)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = await ReferenceListServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            ReferenceList referenceList = new ReferenceList();
            string referenceListId = "";
            // Make the request
            ReferenceList response = await referenceListServiceClient.CreateReferenceListAsync(parent, referenceList, referenceListId);
            // End snippet
        }

        /// <summary>Snippet for UpdateReferenceList</summary>
        public void UpdateReferenceListRequestObject()
        {
            // Snippet: UpdateReferenceList(UpdateReferenceListRequest, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = ReferenceListServiceClient.Create();
            // Initialize request argument(s)
            UpdateReferenceListRequest request = new UpdateReferenceListRequest
            {
                ReferenceList = new ReferenceList(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ReferenceList response = referenceListServiceClient.UpdateReferenceList(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReferenceListAsync</summary>
        public async Task UpdateReferenceListRequestObjectAsync()
        {
            // Snippet: UpdateReferenceListAsync(UpdateReferenceListRequest, CallSettings)
            // Additional: UpdateReferenceListAsync(UpdateReferenceListRequest, CancellationToken)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = await ReferenceListServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateReferenceListRequest request = new UpdateReferenceListRequest
            {
                ReferenceList = new ReferenceList(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ReferenceList response = await referenceListServiceClient.UpdateReferenceListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateReferenceList</summary>
        public void UpdateReferenceList()
        {
            // Snippet: UpdateReferenceList(ReferenceList, FieldMask, CallSettings)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = ReferenceListServiceClient.Create();
            // Initialize request argument(s)
            ReferenceList referenceList = new ReferenceList();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ReferenceList response = referenceListServiceClient.UpdateReferenceList(referenceList, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateReferenceListAsync</summary>
        public async Task UpdateReferenceListAsync()
        {
            // Snippet: UpdateReferenceListAsync(ReferenceList, FieldMask, CallSettings)
            // Additional: UpdateReferenceListAsync(ReferenceList, FieldMask, CancellationToken)
            // Create client
            ReferenceListServiceClient referenceListServiceClient = await ReferenceListServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReferenceList referenceList = new ReferenceList();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ReferenceList response = await referenceListServiceClient.UpdateReferenceListAsync(referenceList, updateMask);
            // End snippet
        }
    }
}
