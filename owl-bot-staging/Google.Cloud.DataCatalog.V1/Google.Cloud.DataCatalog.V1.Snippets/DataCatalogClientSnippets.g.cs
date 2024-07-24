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
    using Google.Cloud.DataCatalog.V1;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataCatalogClientSnippets
    {
        /// <summary>Snippet for SearchCatalog</summary>
        public void SearchCatalogRequestObject()
        {
            // Snippet: SearchCatalog(SearchCatalogRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            SearchCatalogRequest request = new SearchCatalogRequest
            {
                Query = "",
                OrderBy = "",
                Scope = new SearchCatalogRequest.Types.Scope(),
                AdminSearch = false,
            };
            // Make the request
            PagedEnumerable<SearchCatalogResponse, SearchCatalogResult> response = dataCatalogClient.SearchCatalog(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchCatalogResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchCatalogResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchCatalogResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchCatalogResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchCatalogResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchCatalogAsync</summary>
        public async Task SearchCatalogRequestObjectAsync()
        {
            // Snippet: SearchCatalogAsync(SearchCatalogRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            SearchCatalogRequest request = new SearchCatalogRequest
            {
                Query = "",
                OrderBy = "",
                Scope = new SearchCatalogRequest.Types.Scope(),
                AdminSearch = false,
            };
            // Make the request
            PagedAsyncEnumerable<SearchCatalogResponse, SearchCatalogResult> response = dataCatalogClient.SearchCatalogAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchCatalogResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchCatalogResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchCatalogResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchCatalogResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchCatalogResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchCatalog</summary>
        public void SearchCatalog()
        {
            // Snippet: SearchCatalog(SearchCatalogRequest.Types.Scope, string, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            SearchCatalogRequest.Types.Scope scope = new SearchCatalogRequest.Types.Scope();
            string query = "";
            // Make the request
            PagedEnumerable<SearchCatalogResponse, SearchCatalogResult> response = dataCatalogClient.SearchCatalog(scope, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SearchCatalogResult item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchCatalogResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchCatalogResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchCatalogResult> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchCatalogResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchCatalogAsync</summary>
        public async Task SearchCatalogAsync()
        {
            // Snippet: SearchCatalogAsync(SearchCatalogRequest.Types.Scope, string, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            SearchCatalogRequest.Types.Scope scope = new SearchCatalogRequest.Types.Scope();
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchCatalogResponse, SearchCatalogResult> response = dataCatalogClient.SearchCatalogAsync(scope, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SearchCatalogResult item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchCatalogResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SearchCatalogResult item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SearchCatalogResult> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SearchCatalogResult item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateEntryGroup</summary>
        public void CreateEntryGroupRequestObject()
        {
            // Snippet: CreateEntryGroup(CreateEntryGroupRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            CreateEntryGroupRequest request = new CreateEntryGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntryGroup = new EntryGroup(),
                EntryGroupId = "",
            };
            // Make the request
            EntryGroup response = dataCatalogClient.CreateEntryGroup(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntryGroupAsync</summary>
        public async Task CreateEntryGroupRequestObjectAsync()
        {
            // Snippet: CreateEntryGroupAsync(CreateEntryGroupRequest, CallSettings)
            // Additional: CreateEntryGroupAsync(CreateEntryGroupRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            CreateEntryGroupRequest request = new CreateEntryGroupRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntryGroup = new EntryGroup(),
                EntryGroupId = "",
            };
            // Make the request
            EntryGroup response = await dataCatalogClient.CreateEntryGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntryGroup</summary>
        public void CreateEntryGroup()
        {
            // Snippet: CreateEntryGroup(string, string, EntryGroup, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string entryGroupId = "";
            EntryGroup entryGroup = new EntryGroup();
            // Make the request
            EntryGroup response = dataCatalogClient.CreateEntryGroup(parent, entryGroupId, entryGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateEntryGroupAsync</summary>
        public async Task CreateEntryGroupAsync()
        {
            // Snippet: CreateEntryGroupAsync(string, string, EntryGroup, CallSettings)
            // Additional: CreateEntryGroupAsync(string, string, EntryGroup, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string entryGroupId = "";
            EntryGroup entryGroup = new EntryGroup();
            // Make the request
            EntryGroup response = await dataCatalogClient.CreateEntryGroupAsync(parent, entryGroupId, entryGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateEntryGroup</summary>
        public void CreateEntryGroupResourceNames()
        {
            // Snippet: CreateEntryGroup(LocationName, string, EntryGroup, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string entryGroupId = "";
            EntryGroup entryGroup = new EntryGroup();
            // Make the request
            EntryGroup response = dataCatalogClient.CreateEntryGroup(parent, entryGroupId, entryGroup);
            // End snippet
        }

        /// <summary>Snippet for CreateEntryGroupAsync</summary>
        public async Task CreateEntryGroupResourceNamesAsync()
        {
            // Snippet: CreateEntryGroupAsync(LocationName, string, EntryGroup, CallSettings)
            // Additional: CreateEntryGroupAsync(LocationName, string, EntryGroup, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string entryGroupId = "";
            EntryGroup entryGroup = new EntryGroup();
            // Make the request
            EntryGroup response = await dataCatalogClient.CreateEntryGroupAsync(parent, entryGroupId, entryGroup);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroup</summary>
        public void GetEntryGroupRequestObject()
        {
            // Snippet: GetEntryGroup(GetEntryGroupRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            GetEntryGroupRequest request = new GetEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            EntryGroup response = dataCatalogClient.GetEntryGroup(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroupAsync</summary>
        public async Task GetEntryGroupRequestObjectAsync()
        {
            // Snippet: GetEntryGroupAsync(GetEntryGroupRequest, CallSettings)
            // Additional: GetEntryGroupAsync(GetEntryGroupRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            GetEntryGroupRequest request = new GetEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            EntryGroup response = await dataCatalogClient.GetEntryGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroup</summary>
        public void GetEntryGroup1()
        {
            // Snippet: GetEntryGroup(string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            // Make the request
            EntryGroup response = dataCatalogClient.GetEntryGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroupAsync</summary>
        public async Task GetEntryGroup1Async()
        {
            // Snippet: GetEntryGroupAsync(string, CallSettings)
            // Additional: GetEntryGroupAsync(string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            // Make the request
            EntryGroup response = await dataCatalogClient.GetEntryGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroup</summary>
        public void GetEntryGroup1ResourceNames()
        {
            // Snippet: GetEntryGroup(EntryGroupName, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryGroupName name = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            // Make the request
            EntryGroup response = dataCatalogClient.GetEntryGroup(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroupAsync</summary>
        public async Task GetEntryGroup1ResourceNamesAsync()
        {
            // Snippet: GetEntryGroupAsync(EntryGroupName, CallSettings)
            // Additional: GetEntryGroupAsync(EntryGroupName, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryGroupName name = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            // Make the request
            EntryGroup response = await dataCatalogClient.GetEntryGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroup</summary>
        public void GetEntryGroup2()
        {
            // Snippet: GetEntryGroup(string, FieldMask, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            FieldMask readMask = new FieldMask();
            // Make the request
            EntryGroup response = dataCatalogClient.GetEntryGroup(name, readMask);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroupAsync</summary>
        public async Task GetEntryGroup2Async()
        {
            // Snippet: GetEntryGroupAsync(string, FieldMask, CallSettings)
            // Additional: GetEntryGroupAsync(string, FieldMask, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            FieldMask readMask = new FieldMask();
            // Make the request
            EntryGroup response = await dataCatalogClient.GetEntryGroupAsync(name, readMask);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroup</summary>
        public void GetEntryGroup2ResourceNames()
        {
            // Snippet: GetEntryGroup(EntryGroupName, FieldMask, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryGroupName name = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            FieldMask readMask = new FieldMask();
            // Make the request
            EntryGroup response = dataCatalogClient.GetEntryGroup(name, readMask);
            // End snippet
        }

        /// <summary>Snippet for GetEntryGroupAsync</summary>
        public async Task GetEntryGroup2ResourceNamesAsync()
        {
            // Snippet: GetEntryGroupAsync(EntryGroupName, FieldMask, CallSettings)
            // Additional: GetEntryGroupAsync(EntryGroupName, FieldMask, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryGroupName name = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            FieldMask readMask = new FieldMask();
            // Make the request
            EntryGroup response = await dataCatalogClient.GetEntryGroupAsync(name, readMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryGroup</summary>
        public void UpdateEntryGroupRequestObject()
        {
            // Snippet: UpdateEntryGroup(UpdateEntryGroupRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            UpdateEntryGroupRequest request = new UpdateEntryGroupRequest
            {
                EntryGroup = new EntryGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EntryGroup response = dataCatalogClient.UpdateEntryGroup(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryGroupAsync</summary>
        public async Task UpdateEntryGroupRequestObjectAsync()
        {
            // Snippet: UpdateEntryGroupAsync(UpdateEntryGroupRequest, CallSettings)
            // Additional: UpdateEntryGroupAsync(UpdateEntryGroupRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEntryGroupRequest request = new UpdateEntryGroupRequest
            {
                EntryGroup = new EntryGroup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            EntryGroup response = await dataCatalogClient.UpdateEntryGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryGroup</summary>
        public void UpdateEntryGroup1()
        {
            // Snippet: UpdateEntryGroup(EntryGroup, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryGroup entryGroup = new EntryGroup();
            // Make the request
            EntryGroup response = dataCatalogClient.UpdateEntryGroup(entryGroup);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryGroupAsync</summary>
        public async Task UpdateEntryGroup1Async()
        {
            // Snippet: UpdateEntryGroupAsync(EntryGroup, CallSettings)
            // Additional: UpdateEntryGroupAsync(EntryGroup, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryGroup entryGroup = new EntryGroup();
            // Make the request
            EntryGroup response = await dataCatalogClient.UpdateEntryGroupAsync(entryGroup);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryGroup</summary>
        public void UpdateEntryGroup2()
        {
            // Snippet: UpdateEntryGroup(EntryGroup, FieldMask, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryGroup entryGroup = new EntryGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EntryGroup response = dataCatalogClient.UpdateEntryGroup(entryGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryGroupAsync</summary>
        public async Task UpdateEntryGroup2Async()
        {
            // Snippet: UpdateEntryGroupAsync(EntryGroup, FieldMask, CallSettings)
            // Additional: UpdateEntryGroupAsync(EntryGroup, FieldMask, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryGroup entryGroup = new EntryGroup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            EntryGroup response = await dataCatalogClient.UpdateEntryGroupAsync(entryGroup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryGroup</summary>
        public void DeleteEntryGroupRequestObject()
        {
            // Snippet: DeleteEntryGroup(DeleteEntryGroupRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            DeleteEntryGroupRequest request = new DeleteEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Force = false,
            };
            // Make the request
            dataCatalogClient.DeleteEntryGroup(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryGroupAsync</summary>
        public async Task DeleteEntryGroupRequestObjectAsync()
        {
            // Snippet: DeleteEntryGroupAsync(DeleteEntryGroupRequest, CallSettings)
            // Additional: DeleteEntryGroupAsync(DeleteEntryGroupRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEntryGroupRequest request = new DeleteEntryGroupRequest
            {
                EntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Force = false,
            };
            // Make the request
            await dataCatalogClient.DeleteEntryGroupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryGroup</summary>
        public void DeleteEntryGroup()
        {
            // Snippet: DeleteEntryGroup(string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            // Make the request
            dataCatalogClient.DeleteEntryGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryGroupAsync</summary>
        public async Task DeleteEntryGroupAsync()
        {
            // Snippet: DeleteEntryGroupAsync(string, CallSettings)
            // Additional: DeleteEntryGroupAsync(string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            // Make the request
            await dataCatalogClient.DeleteEntryGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryGroup</summary>
        public void DeleteEntryGroupResourceNames()
        {
            // Snippet: DeleteEntryGroup(EntryGroupName, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryGroupName name = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            // Make the request
            dataCatalogClient.DeleteEntryGroup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryGroupAsync</summary>
        public async Task DeleteEntryGroupResourceNamesAsync()
        {
            // Snippet: DeleteEntryGroupAsync(EntryGroupName, CallSettings)
            // Additional: DeleteEntryGroupAsync(EntryGroupName, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryGroupName name = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            // Make the request
            await dataCatalogClient.DeleteEntryGroupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListEntryGroups</summary>
        public void ListEntryGroupsRequestObject()
        {
            // Snippet: ListEntryGroups(ListEntryGroupsRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            ListEntryGroupsRequest request = new ListEntryGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListEntryGroupsResponse, EntryGroup> response = dataCatalogClient.ListEntryGroups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntryGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntryGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntryGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntryGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntryGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryGroupsAsync</summary>
        public async Task ListEntryGroupsRequestObjectAsync()
        {
            // Snippet: ListEntryGroupsAsync(ListEntryGroupsRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            ListEntryGroupsRequest request = new ListEntryGroupsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEntryGroupsResponse, EntryGroup> response = dataCatalogClient.ListEntryGroupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntryGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntryGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntryGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntryGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntryGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryGroups</summary>
        public void ListEntryGroups()
        {
            // Snippet: ListEntryGroups(string, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEntryGroupsResponse, EntryGroup> response = dataCatalogClient.ListEntryGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntryGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntryGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntryGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntryGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntryGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryGroupsAsync</summary>
        public async Task ListEntryGroupsAsync()
        {
            // Snippet: ListEntryGroupsAsync(string, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEntryGroupsResponse, EntryGroup> response = dataCatalogClient.ListEntryGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntryGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntryGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntryGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntryGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntryGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryGroups</summary>
        public void ListEntryGroupsResourceNames()
        {
            // Snippet: ListEntryGroups(LocationName, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEntryGroupsResponse, EntryGroup> response = dataCatalogClient.ListEntryGroups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (EntryGroup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntryGroupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntryGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntryGroup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntryGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntryGroupsAsync</summary>
        public async Task ListEntryGroupsResourceNamesAsync()
        {
            // Snippet: ListEntryGroupsAsync(LocationName, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEntryGroupsResponse, EntryGroup> response = dataCatalogClient.ListEntryGroupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((EntryGroup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntryGroupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (EntryGroup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<EntryGroup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (EntryGroup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateEntry</summary>
        public void CreateEntryRequestObject()
        {
            // Snippet: CreateEntry(CreateEntryRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            CreateEntryRequest request = new CreateEntryRequest
            {
                ParentAsEntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Entry = new Entry(),
                EntryId = "",
            };
            // Make the request
            Entry response = dataCatalogClient.CreateEntry(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntryAsync</summary>
        public async Task CreateEntryRequestObjectAsync()
        {
            // Snippet: CreateEntryAsync(CreateEntryRequest, CallSettings)
            // Additional: CreateEntryAsync(CreateEntryRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            CreateEntryRequest request = new CreateEntryRequest
            {
                ParentAsEntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                Entry = new Entry(),
                EntryId = "",
            };
            // Make the request
            Entry response = await dataCatalogClient.CreateEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEntry</summary>
        public void CreateEntry()
        {
            // Snippet: CreateEntry(string, string, Entry, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            string entryId = "";
            Entry entry = new Entry();
            // Make the request
            Entry response = dataCatalogClient.CreateEntry(parent, entryId, entry);
            // End snippet
        }

        /// <summary>Snippet for CreateEntryAsync</summary>
        public async Task CreateEntryAsync()
        {
            // Snippet: CreateEntryAsync(string, string, Entry, CallSettings)
            // Additional: CreateEntryAsync(string, string, Entry, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            string entryId = "";
            Entry entry = new Entry();
            // Make the request
            Entry response = await dataCatalogClient.CreateEntryAsync(parent, entryId, entry);
            // End snippet
        }

        /// <summary>Snippet for CreateEntry</summary>
        public void CreateEntryResourceNames()
        {
            // Snippet: CreateEntry(EntryGroupName, string, Entry, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryGroupName parent = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            string entryId = "";
            Entry entry = new Entry();
            // Make the request
            Entry response = dataCatalogClient.CreateEntry(parent, entryId, entry);
            // End snippet
        }

        /// <summary>Snippet for CreateEntryAsync</summary>
        public async Task CreateEntryResourceNamesAsync()
        {
            // Snippet: CreateEntryAsync(EntryGroupName, string, Entry, CallSettings)
            // Additional: CreateEntryAsync(EntryGroupName, string, Entry, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryGroupName parent = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            string entryId = "";
            Entry entry = new Entry();
            // Make the request
            Entry response = await dataCatalogClient.CreateEntryAsync(parent, entryId, entry);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntry</summary>
        public void UpdateEntryRequestObject()
        {
            // Snippet: UpdateEntry(UpdateEntryRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            UpdateEntryRequest request = new UpdateEntryRequest
            {
                Entry = new Entry(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Entry response = dataCatalogClient.UpdateEntry(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryAsync</summary>
        public async Task UpdateEntryRequestObjectAsync()
        {
            // Snippet: UpdateEntryAsync(UpdateEntryRequest, CallSettings)
            // Additional: UpdateEntryAsync(UpdateEntryRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEntryRequest request = new UpdateEntryRequest
            {
                Entry = new Entry(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Entry response = await dataCatalogClient.UpdateEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntry</summary>
        public void UpdateEntry1()
        {
            // Snippet: UpdateEntry(Entry, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            Entry entry = new Entry();
            // Make the request
            Entry response = dataCatalogClient.UpdateEntry(entry);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryAsync</summary>
        public async Task UpdateEntry1Async()
        {
            // Snippet: UpdateEntryAsync(Entry, CallSettings)
            // Additional: UpdateEntryAsync(Entry, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            Entry entry = new Entry();
            // Make the request
            Entry response = await dataCatalogClient.UpdateEntryAsync(entry);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntry</summary>
        public void UpdateEntry2()
        {
            // Snippet: UpdateEntry(Entry, FieldMask, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            Entry entry = new Entry();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Entry response = dataCatalogClient.UpdateEntry(entry, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateEntryAsync</summary>
        public async Task UpdateEntry2Async()
        {
            // Snippet: UpdateEntryAsync(Entry, FieldMask, CallSettings)
            // Additional: UpdateEntryAsync(Entry, FieldMask, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            Entry entry = new Entry();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Entry response = await dataCatalogClient.UpdateEntryAsync(entry, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntry</summary>
        public void DeleteEntryRequestObject()
        {
            // Snippet: DeleteEntry(DeleteEntryRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            DeleteEntryRequest request = new DeleteEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            dataCatalogClient.DeleteEntry(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryAsync</summary>
        public async Task DeleteEntryRequestObjectAsync()
        {
            // Snippet: DeleteEntryAsync(DeleteEntryRequest, CallSettings)
            // Additional: DeleteEntryAsync(DeleteEntryRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEntryRequest request = new DeleteEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            await dataCatalogClient.DeleteEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntry</summary>
        public void DeleteEntry()
        {
            // Snippet: DeleteEntry(string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            dataCatalogClient.DeleteEntry(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryAsync</summary>
        public async Task DeleteEntryAsync()
        {
            // Snippet: DeleteEntryAsync(string, CallSettings)
            // Additional: DeleteEntryAsync(string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            await dataCatalogClient.DeleteEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntry</summary>
        public void DeleteEntryResourceNames()
        {
            // Snippet: DeleteEntry(EntryName, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryName name = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            dataCatalogClient.DeleteEntry(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteEntryAsync</summary>
        public async Task DeleteEntryResourceNamesAsync()
        {
            // Snippet: DeleteEntryAsync(EntryName, CallSettings)
            // Additional: DeleteEntryAsync(EntryName, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryName name = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            await dataCatalogClient.DeleteEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntry</summary>
        public void GetEntryRequestObject()
        {
            // Snippet: GetEntry(GetEntryRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            GetEntryRequest request = new GetEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            Entry response = dataCatalogClient.GetEntry(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntryAsync</summary>
        public async Task GetEntryRequestObjectAsync()
        {
            // Snippet: GetEntryAsync(GetEntryRequest, CallSettings)
            // Additional: GetEntryAsync(GetEntryRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            GetEntryRequest request = new GetEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            Entry response = await dataCatalogClient.GetEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntry</summary>
        public void GetEntry()
        {
            // Snippet: GetEntry(string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            Entry response = dataCatalogClient.GetEntry(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryAsync</summary>
        public async Task GetEntryAsync()
        {
            // Snippet: GetEntryAsync(string, CallSettings)
            // Additional: GetEntryAsync(string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            Entry response = await dataCatalogClient.GetEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntry</summary>
        public void GetEntryResourceNames()
        {
            // Snippet: GetEntry(EntryName, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryName name = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            Entry response = dataCatalogClient.GetEntry(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntryAsync</summary>
        public async Task GetEntryResourceNamesAsync()
        {
            // Snippet: GetEntryAsync(EntryName, CallSettings)
            // Additional: GetEntryAsync(EntryName, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryName name = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            Entry response = await dataCatalogClient.GetEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for LookupEntry</summary>
        public void LookupEntryRequestObject()
        {
            // Snippet: LookupEntry(LookupEntryRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            LookupEntryRequest request = new LookupEntryRequest
            {
                LinkedResource = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Entry response = dataCatalogClient.LookupEntry(request);
            // End snippet
        }

        /// <summary>Snippet for LookupEntryAsync</summary>
        public async Task LookupEntryRequestObjectAsync()
        {
            // Snippet: LookupEntryAsync(LookupEntryRequest, CallSettings)
            // Additional: LookupEntryAsync(LookupEntryRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            LookupEntryRequest request = new LookupEntryRequest
            {
                LinkedResource = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Entry response = await dataCatalogClient.LookupEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListEntries</summary>
        public void ListEntriesRequestObject()
        {
            // Snippet: ListEntries(ListEntriesRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            ListEntriesRequest request = new ListEntriesRequest
            {
                ParentAsEntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedEnumerable<ListEntriesResponse, Entry> response = dataCatalogClient.ListEntries(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntriesAsync</summary>
        public async Task ListEntriesRequestObjectAsync()
        {
            // Snippet: ListEntriesAsync(ListEntriesRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            ListEntriesRequest request = new ListEntriesRequest
            {
                ParentAsEntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                ReadMask = new FieldMask(),
            };
            // Make the request
            PagedAsyncEnumerable<ListEntriesResponse, Entry> response = dataCatalogClient.ListEntriesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntries</summary>
        public void ListEntries()
        {
            // Snippet: ListEntries(string, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            // Make the request
            PagedEnumerable<ListEntriesResponse, Entry> response = dataCatalogClient.ListEntries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntriesAsync</summary>
        public async Task ListEntriesAsync()
        {
            // Snippet: ListEntriesAsync(string, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]";
            // Make the request
            PagedAsyncEnumerable<ListEntriesResponse, Entry> response = dataCatalogClient.ListEntriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntries</summary>
        public void ListEntriesResourceNames()
        {
            // Snippet: ListEntries(EntryGroupName, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryGroupName parent = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            // Make the request
            PagedEnumerable<ListEntriesResponse, Entry> response = dataCatalogClient.ListEntries(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entry item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntriesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entry> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntriesAsync</summary>
        public async Task ListEntriesResourceNamesAsync()
        {
            // Snippet: ListEntriesAsync(EntryGroupName, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryGroupName parent = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]");
            // Make the request
            PagedAsyncEnumerable<ListEntriesResponse, Entry> response = dataCatalogClient.ListEntriesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entry item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntriesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entry item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entry> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entry item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ModifyEntryOverview</summary>
        public void ModifyEntryOverviewRequestObject()
        {
            // Snippet: ModifyEntryOverview(ModifyEntryOverviewRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            ModifyEntryOverviewRequest request = new ModifyEntryOverviewRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                EntryOverview = new EntryOverview(),
            };
            // Make the request
            EntryOverview response = dataCatalogClient.ModifyEntryOverview(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyEntryOverviewAsync</summary>
        public async Task ModifyEntryOverviewRequestObjectAsync()
        {
            // Snippet: ModifyEntryOverviewAsync(ModifyEntryOverviewRequest, CallSettings)
            // Additional: ModifyEntryOverviewAsync(ModifyEntryOverviewRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            ModifyEntryOverviewRequest request = new ModifyEntryOverviewRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                EntryOverview = new EntryOverview(),
            };
            // Make the request
            EntryOverview response = await dataCatalogClient.ModifyEntryOverviewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyEntryContacts</summary>
        public void ModifyEntryContactsRequestObject()
        {
            // Snippet: ModifyEntryContacts(ModifyEntryContactsRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            ModifyEntryContactsRequest request = new ModifyEntryContactsRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Contacts = new Contacts(),
            };
            // Make the request
            Contacts response = dataCatalogClient.ModifyEntryContacts(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyEntryContactsAsync</summary>
        public async Task ModifyEntryContactsRequestObjectAsync()
        {
            // Snippet: ModifyEntryContactsAsync(ModifyEntryContactsRequest, CallSettings)
            // Additional: ModifyEntryContactsAsync(ModifyEntryContactsRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            ModifyEntryContactsRequest request = new ModifyEntryContactsRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Contacts = new Contacts(),
            };
            // Make the request
            Contacts response = await dataCatalogClient.ModifyEntryContactsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTagTemplate</summary>
        public void CreateTagTemplateRequestObject()
        {
            // Snippet: CreateTagTemplate(CreateTagTemplateRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            CreateTagTemplateRequest request = new CreateTagTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TagTemplate = new TagTemplate(),
                TagTemplateId = "",
            };
            // Make the request
            TagTemplate response = dataCatalogClient.CreateTagTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTagTemplateAsync</summary>
        public async Task CreateTagTemplateRequestObjectAsync()
        {
            // Snippet: CreateTagTemplateAsync(CreateTagTemplateRequest, CallSettings)
            // Additional: CreateTagTemplateAsync(CreateTagTemplateRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            CreateTagTemplateRequest request = new CreateTagTemplateRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                TagTemplate = new TagTemplate(),
                TagTemplateId = "",
            };
            // Make the request
            TagTemplate response = await dataCatalogClient.CreateTagTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTagTemplate</summary>
        public void CreateTagTemplate()
        {
            // Snippet: CreateTagTemplate(string, string, TagTemplate, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string tagTemplateId = "";
            TagTemplate tagTemplate = new TagTemplate();
            // Make the request
            TagTemplate response = dataCatalogClient.CreateTagTemplate(parent, tagTemplateId, tagTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateTagTemplateAsync</summary>
        public async Task CreateTagTemplateAsync()
        {
            // Snippet: CreateTagTemplateAsync(string, string, TagTemplate, CallSettings)
            // Additional: CreateTagTemplateAsync(string, string, TagTemplate, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string tagTemplateId = "";
            TagTemplate tagTemplate = new TagTemplate();
            // Make the request
            TagTemplate response = await dataCatalogClient.CreateTagTemplateAsync(parent, tagTemplateId, tagTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateTagTemplate</summary>
        public void CreateTagTemplateResourceNames()
        {
            // Snippet: CreateTagTemplate(LocationName, string, TagTemplate, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string tagTemplateId = "";
            TagTemplate tagTemplate = new TagTemplate();
            // Make the request
            TagTemplate response = dataCatalogClient.CreateTagTemplate(parent, tagTemplateId, tagTemplate);
            // End snippet
        }

        /// <summary>Snippet for CreateTagTemplateAsync</summary>
        public async Task CreateTagTemplateResourceNamesAsync()
        {
            // Snippet: CreateTagTemplateAsync(LocationName, string, TagTemplate, CallSettings)
            // Additional: CreateTagTemplateAsync(LocationName, string, TagTemplate, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string tagTemplateId = "";
            TagTemplate tagTemplate = new TagTemplate();
            // Make the request
            TagTemplate response = await dataCatalogClient.CreateTagTemplateAsync(parent, tagTemplateId, tagTemplate);
            // End snippet
        }

        /// <summary>Snippet for GetTagTemplate</summary>
        public void GetTagTemplateRequestObject()
        {
            // Snippet: GetTagTemplate(GetTagTemplateRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            GetTagTemplateRequest request = new GetTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
            };
            // Make the request
            TagTemplate response = dataCatalogClient.GetTagTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for GetTagTemplateAsync</summary>
        public async Task GetTagTemplateRequestObjectAsync()
        {
            // Snippet: GetTagTemplateAsync(GetTagTemplateRequest, CallSettings)
            // Additional: GetTagTemplateAsync(GetTagTemplateRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            GetTagTemplateRequest request = new GetTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
            };
            // Make the request
            TagTemplate response = await dataCatalogClient.GetTagTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTagTemplate</summary>
        public void GetTagTemplate()
        {
            // Snippet: GetTagTemplate(string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]";
            // Make the request
            TagTemplate response = dataCatalogClient.GetTagTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetTagTemplateAsync</summary>
        public async Task GetTagTemplateAsync()
        {
            // Snippet: GetTagTemplateAsync(string, CallSettings)
            // Additional: GetTagTemplateAsync(string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]";
            // Make the request
            TagTemplate response = await dataCatalogClient.GetTagTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTagTemplate</summary>
        public void GetTagTemplateResourceNames()
        {
            // Snippet: GetTagTemplate(TagTemplateName, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            TagTemplateName name = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]");
            // Make the request
            TagTemplate response = dataCatalogClient.GetTagTemplate(name);
            // End snippet
        }

        /// <summary>Snippet for GetTagTemplateAsync</summary>
        public async Task GetTagTemplateResourceNamesAsync()
        {
            // Snippet: GetTagTemplateAsync(TagTemplateName, CallSettings)
            // Additional: GetTagTemplateAsync(TagTemplateName, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            TagTemplateName name = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]");
            // Make the request
            TagTemplate response = await dataCatalogClient.GetTagTemplateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplate</summary>
        public void UpdateTagTemplateRequestObject()
        {
            // Snippet: UpdateTagTemplate(UpdateTagTemplateRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            UpdateTagTemplateRequest request = new UpdateTagTemplateRequest
            {
                TagTemplate = new TagTemplate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TagTemplate response = dataCatalogClient.UpdateTagTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateAsync</summary>
        public async Task UpdateTagTemplateRequestObjectAsync()
        {
            // Snippet: UpdateTagTemplateAsync(UpdateTagTemplateRequest, CallSettings)
            // Additional: UpdateTagTemplateAsync(UpdateTagTemplateRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTagTemplateRequest request = new UpdateTagTemplateRequest
            {
                TagTemplate = new TagTemplate(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TagTemplate response = await dataCatalogClient.UpdateTagTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplate</summary>
        public void UpdateTagTemplate1()
        {
            // Snippet: UpdateTagTemplate(TagTemplate, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            TagTemplate tagTemplate = new TagTemplate();
            // Make the request
            TagTemplate response = dataCatalogClient.UpdateTagTemplate(tagTemplate);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateAsync</summary>
        public async Task UpdateTagTemplate1Async()
        {
            // Snippet: UpdateTagTemplateAsync(TagTemplate, CallSettings)
            // Additional: UpdateTagTemplateAsync(TagTemplate, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            TagTemplate tagTemplate = new TagTemplate();
            // Make the request
            TagTemplate response = await dataCatalogClient.UpdateTagTemplateAsync(tagTemplate);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplate</summary>
        public void UpdateTagTemplate2()
        {
            // Snippet: UpdateTagTemplate(TagTemplate, FieldMask, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            TagTemplate tagTemplate = new TagTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TagTemplate response = dataCatalogClient.UpdateTagTemplate(tagTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateAsync</summary>
        public async Task UpdateTagTemplate2Async()
        {
            // Snippet: UpdateTagTemplateAsync(TagTemplate, FieldMask, CallSettings)
            // Additional: UpdateTagTemplateAsync(TagTemplate, FieldMask, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            TagTemplate tagTemplate = new TagTemplate();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TagTemplate response = await dataCatalogClient.UpdateTagTemplateAsync(tagTemplate, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagTemplate</summary>
        public void DeleteTagTemplateRequestObject()
        {
            // Snippet: DeleteTagTemplate(DeleteTagTemplateRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            DeleteTagTemplateRequest request = new DeleteTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                Force = false,
            };
            // Make the request
            dataCatalogClient.DeleteTagTemplate(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagTemplateAsync</summary>
        public async Task DeleteTagTemplateRequestObjectAsync()
        {
            // Snippet: DeleteTagTemplateAsync(DeleteTagTemplateRequest, CallSettings)
            // Additional: DeleteTagTemplateAsync(DeleteTagTemplateRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTagTemplateRequest request = new DeleteTagTemplateRequest
            {
                TagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                Force = false,
            };
            // Make the request
            await dataCatalogClient.DeleteTagTemplateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagTemplate</summary>
        public void DeleteTagTemplate()
        {
            // Snippet: DeleteTagTemplate(string, bool, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]";
            bool force = false;
            // Make the request
            dataCatalogClient.DeleteTagTemplate(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagTemplateAsync</summary>
        public async Task DeleteTagTemplateAsync()
        {
            // Snippet: DeleteTagTemplateAsync(string, bool, CallSettings)
            // Additional: DeleteTagTemplateAsync(string, bool, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]";
            bool force = false;
            // Make the request
            await dataCatalogClient.DeleteTagTemplateAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagTemplate</summary>
        public void DeleteTagTemplateResourceNames()
        {
            // Snippet: DeleteTagTemplate(TagTemplateName, bool, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            TagTemplateName name = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]");
            bool force = false;
            // Make the request
            dataCatalogClient.DeleteTagTemplate(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagTemplateAsync</summary>
        public async Task DeleteTagTemplateResourceNamesAsync()
        {
            // Snippet: DeleteTagTemplateAsync(TagTemplateName, bool, CallSettings)
            // Additional: DeleteTagTemplateAsync(TagTemplateName, bool, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            TagTemplateName name = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]");
            bool force = false;
            // Make the request
            await dataCatalogClient.DeleteTagTemplateAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for CreateTagTemplateField</summary>
        public void CreateTagTemplateFieldRequestObject()
        {
            // Snippet: CreateTagTemplateField(CreateTagTemplateFieldRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            CreateTagTemplateFieldRequest request = new CreateTagTemplateFieldRequest
            {
                ParentAsTagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                TagTemplateFieldId = "",
                TagTemplateField = new TagTemplateField(),
            };
            // Make the request
            TagTemplateField response = dataCatalogClient.CreateTagTemplateField(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTagTemplateFieldAsync</summary>
        public async Task CreateTagTemplateFieldRequestObjectAsync()
        {
            // Snippet: CreateTagTemplateFieldAsync(CreateTagTemplateFieldRequest, CallSettings)
            // Additional: CreateTagTemplateFieldAsync(CreateTagTemplateFieldRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            CreateTagTemplateFieldRequest request = new CreateTagTemplateFieldRequest
            {
                ParentAsTagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                TagTemplateFieldId = "",
                TagTemplateField = new TagTemplateField(),
            };
            // Make the request
            TagTemplateField response = await dataCatalogClient.CreateTagTemplateFieldAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTagTemplateField</summary>
        public void CreateTagTemplateField()
        {
            // Snippet: CreateTagTemplateField(string, string, TagTemplateField, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]";
            string tagTemplateFieldId = "";
            TagTemplateField tagTemplateField = new TagTemplateField();
            // Make the request
            TagTemplateField response = dataCatalogClient.CreateTagTemplateField(parent, tagTemplateFieldId, tagTemplateField);
            // End snippet
        }

        /// <summary>Snippet for CreateTagTemplateFieldAsync</summary>
        public async Task CreateTagTemplateFieldAsync()
        {
            // Snippet: CreateTagTemplateFieldAsync(string, string, TagTemplateField, CallSettings)
            // Additional: CreateTagTemplateFieldAsync(string, string, TagTemplateField, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]";
            string tagTemplateFieldId = "";
            TagTemplateField tagTemplateField = new TagTemplateField();
            // Make the request
            TagTemplateField response = await dataCatalogClient.CreateTagTemplateFieldAsync(parent, tagTemplateFieldId, tagTemplateField);
            // End snippet
        }

        /// <summary>Snippet for CreateTagTemplateField</summary>
        public void CreateTagTemplateFieldResourceNames()
        {
            // Snippet: CreateTagTemplateField(TagTemplateName, string, TagTemplateField, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            TagTemplateName parent = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]");
            string tagTemplateFieldId = "";
            TagTemplateField tagTemplateField = new TagTemplateField();
            // Make the request
            TagTemplateField response = dataCatalogClient.CreateTagTemplateField(parent, tagTemplateFieldId, tagTemplateField);
            // End snippet
        }

        /// <summary>Snippet for CreateTagTemplateFieldAsync</summary>
        public async Task CreateTagTemplateFieldResourceNamesAsync()
        {
            // Snippet: CreateTagTemplateFieldAsync(TagTemplateName, string, TagTemplateField, CallSettings)
            // Additional: CreateTagTemplateFieldAsync(TagTemplateName, string, TagTemplateField, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            TagTemplateName parent = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]");
            string tagTemplateFieldId = "";
            TagTemplateField tagTemplateField = new TagTemplateField();
            // Make the request
            TagTemplateField response = await dataCatalogClient.CreateTagTemplateFieldAsync(parent, tagTemplateFieldId, tagTemplateField);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateField</summary>
        public void UpdateTagTemplateFieldRequestObject()
        {
            // Snippet: UpdateTagTemplateField(UpdateTagTemplateFieldRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            UpdateTagTemplateFieldRequest request = new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                TagTemplateField = new TagTemplateField(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TagTemplateField response = dataCatalogClient.UpdateTagTemplateField(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateFieldAsync</summary>
        public async Task UpdateTagTemplateFieldRequestObjectAsync()
        {
            // Snippet: UpdateTagTemplateFieldAsync(UpdateTagTemplateFieldRequest, CallSettings)
            // Additional: UpdateTagTemplateFieldAsync(UpdateTagTemplateFieldRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTagTemplateFieldRequest request = new UpdateTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                TagTemplateField = new TagTemplateField(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            TagTemplateField response = await dataCatalogClient.UpdateTagTemplateFieldAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateField</summary>
        public void UpdateTagTemplateField1()
        {
            // Snippet: UpdateTagTemplateField(string, TagTemplateField, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]/fields/[FIELD]";
            TagTemplateField tagTemplateField = new TagTemplateField();
            // Make the request
            TagTemplateField response = dataCatalogClient.UpdateTagTemplateField(name, tagTemplateField);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateFieldAsync</summary>
        public async Task UpdateTagTemplateField1Async()
        {
            // Snippet: UpdateTagTemplateFieldAsync(string, TagTemplateField, CallSettings)
            // Additional: UpdateTagTemplateFieldAsync(string, TagTemplateField, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]/fields/[FIELD]";
            TagTemplateField tagTemplateField = new TagTemplateField();
            // Make the request
            TagTemplateField response = await dataCatalogClient.UpdateTagTemplateFieldAsync(name, tagTemplateField);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateField</summary>
        public void UpdateTagTemplateField1ResourceNames()
        {
            // Snippet: UpdateTagTemplateField(TagTemplateFieldName, TagTemplateField, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            TagTemplateFieldName name = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]");
            TagTemplateField tagTemplateField = new TagTemplateField();
            // Make the request
            TagTemplateField response = dataCatalogClient.UpdateTagTemplateField(name, tagTemplateField);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateFieldAsync</summary>
        public async Task UpdateTagTemplateField1ResourceNamesAsync()
        {
            // Snippet: UpdateTagTemplateFieldAsync(TagTemplateFieldName, TagTemplateField, CallSettings)
            // Additional: UpdateTagTemplateFieldAsync(TagTemplateFieldName, TagTemplateField, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            TagTemplateFieldName name = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]");
            TagTemplateField tagTemplateField = new TagTemplateField();
            // Make the request
            TagTemplateField response = await dataCatalogClient.UpdateTagTemplateFieldAsync(name, tagTemplateField);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateField</summary>
        public void UpdateTagTemplateField2()
        {
            // Snippet: UpdateTagTemplateField(string, TagTemplateField, FieldMask, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]/fields/[FIELD]";
            TagTemplateField tagTemplateField = new TagTemplateField();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TagTemplateField response = dataCatalogClient.UpdateTagTemplateField(name, tagTemplateField, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateFieldAsync</summary>
        public async Task UpdateTagTemplateField2Async()
        {
            // Snippet: UpdateTagTemplateFieldAsync(string, TagTemplateField, FieldMask, CallSettings)
            // Additional: UpdateTagTemplateFieldAsync(string, TagTemplateField, FieldMask, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]/fields/[FIELD]";
            TagTemplateField tagTemplateField = new TagTemplateField();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TagTemplateField response = await dataCatalogClient.UpdateTagTemplateFieldAsync(name, tagTemplateField, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateField</summary>
        public void UpdateTagTemplateField2ResourceNames()
        {
            // Snippet: UpdateTagTemplateField(TagTemplateFieldName, TagTemplateField, FieldMask, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            TagTemplateFieldName name = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]");
            TagTemplateField tagTemplateField = new TagTemplateField();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TagTemplateField response = dataCatalogClient.UpdateTagTemplateField(name, tagTemplateField, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagTemplateFieldAsync</summary>
        public async Task UpdateTagTemplateField2ResourceNamesAsync()
        {
            // Snippet: UpdateTagTemplateFieldAsync(TagTemplateFieldName, TagTemplateField, FieldMask, CallSettings)
            // Additional: UpdateTagTemplateFieldAsync(TagTemplateFieldName, TagTemplateField, FieldMask, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            TagTemplateFieldName name = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]");
            TagTemplateField tagTemplateField = new TagTemplateField();
            FieldMask updateMask = new FieldMask();
            // Make the request
            TagTemplateField response = await dataCatalogClient.UpdateTagTemplateFieldAsync(name, tagTemplateField, updateMask);
            // End snippet
        }

        /// <summary>Snippet for RenameTagTemplateField</summary>
        public void RenameTagTemplateFieldRequestObject()
        {
            // Snippet: RenameTagTemplateField(RenameTagTemplateFieldRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            RenameTagTemplateFieldRequest request = new RenameTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                NewTagTemplateFieldId = "",
            };
            // Make the request
            TagTemplateField response = dataCatalogClient.RenameTagTemplateField(request);
            // End snippet
        }

        /// <summary>Snippet for RenameTagTemplateFieldAsync</summary>
        public async Task RenameTagTemplateFieldRequestObjectAsync()
        {
            // Snippet: RenameTagTemplateFieldAsync(RenameTagTemplateFieldRequest, CallSettings)
            // Additional: RenameTagTemplateFieldAsync(RenameTagTemplateFieldRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            RenameTagTemplateFieldRequest request = new RenameTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                NewTagTemplateFieldId = "",
            };
            // Make the request
            TagTemplateField response = await dataCatalogClient.RenameTagTemplateFieldAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenameTagTemplateField</summary>
        public void RenameTagTemplateField()
        {
            // Snippet: RenameTagTemplateField(string, string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]/fields/[FIELD]";
            string newTagTemplateFieldId = "";
            // Make the request
            TagTemplateField response = dataCatalogClient.RenameTagTemplateField(name, newTagTemplateFieldId);
            // End snippet
        }

        /// <summary>Snippet for RenameTagTemplateFieldAsync</summary>
        public async Task RenameTagTemplateFieldAsync()
        {
            // Snippet: RenameTagTemplateFieldAsync(string, string, CallSettings)
            // Additional: RenameTagTemplateFieldAsync(string, string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]/fields/[FIELD]";
            string newTagTemplateFieldId = "";
            // Make the request
            TagTemplateField response = await dataCatalogClient.RenameTagTemplateFieldAsync(name, newTagTemplateFieldId);
            // End snippet
        }

        /// <summary>Snippet for RenameTagTemplateField</summary>
        public void RenameTagTemplateFieldResourceNames()
        {
            // Snippet: RenameTagTemplateField(TagTemplateFieldName, string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            TagTemplateFieldName name = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]");
            string newTagTemplateFieldId = "";
            // Make the request
            TagTemplateField response = dataCatalogClient.RenameTagTemplateField(name, newTagTemplateFieldId);
            // End snippet
        }

        /// <summary>Snippet for RenameTagTemplateFieldAsync</summary>
        public async Task RenameTagTemplateFieldResourceNamesAsync()
        {
            // Snippet: RenameTagTemplateFieldAsync(TagTemplateFieldName, string, CallSettings)
            // Additional: RenameTagTemplateFieldAsync(TagTemplateFieldName, string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            TagTemplateFieldName name = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]");
            string newTagTemplateFieldId = "";
            // Make the request
            TagTemplateField response = await dataCatalogClient.RenameTagTemplateFieldAsync(name, newTagTemplateFieldId);
            // End snippet
        }

        /// <summary>Snippet for RenameTagTemplateFieldEnumValue</summary>
        public void RenameTagTemplateFieldEnumValueRequestObject()
        {
            // Snippet: RenameTagTemplateFieldEnumValue(RenameTagTemplateFieldEnumValueRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            RenameTagTemplateFieldEnumValueRequest request = new RenameTagTemplateFieldEnumValueRequest
            {
                TagTemplateFieldEnumValueName = TagTemplateFieldEnumValueName.FromProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[TAG_TEMPLATE_FIELD_ID]", "[ENUM_VALUE_DISPLAY_NAME]"),
                NewEnumValueDisplayName = "",
            };
            // Make the request
            TagTemplateField response = dataCatalogClient.RenameTagTemplateFieldEnumValue(request);
            // End snippet
        }

        /// <summary>Snippet for RenameTagTemplateFieldEnumValueAsync</summary>
        public async Task RenameTagTemplateFieldEnumValueRequestObjectAsync()
        {
            // Snippet: RenameTagTemplateFieldEnumValueAsync(RenameTagTemplateFieldEnumValueRequest, CallSettings)
            // Additional: RenameTagTemplateFieldEnumValueAsync(RenameTagTemplateFieldEnumValueRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            RenameTagTemplateFieldEnumValueRequest request = new RenameTagTemplateFieldEnumValueRequest
            {
                TagTemplateFieldEnumValueName = TagTemplateFieldEnumValueName.FromProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[TAG_TEMPLATE_FIELD_ID]", "[ENUM_VALUE_DISPLAY_NAME]"),
                NewEnumValueDisplayName = "",
            };
            // Make the request
            TagTemplateField response = await dataCatalogClient.RenameTagTemplateFieldEnumValueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RenameTagTemplateFieldEnumValue</summary>
        public void RenameTagTemplateFieldEnumValue()
        {
            // Snippet: RenameTagTemplateFieldEnumValue(string, string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]/fields/[TAG_TEMPLATE_FIELD_ID]/enumValues/[ENUM_VALUE_DISPLAY_NAME]";
            string newEnumValueDisplayName = "";
            // Make the request
            TagTemplateField response = dataCatalogClient.RenameTagTemplateFieldEnumValue(name, newEnumValueDisplayName);
            // End snippet
        }

        /// <summary>Snippet for RenameTagTemplateFieldEnumValueAsync</summary>
        public async Task RenameTagTemplateFieldEnumValueAsync()
        {
            // Snippet: RenameTagTemplateFieldEnumValueAsync(string, string, CallSettings)
            // Additional: RenameTagTemplateFieldEnumValueAsync(string, string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]/fields/[TAG_TEMPLATE_FIELD_ID]/enumValues/[ENUM_VALUE_DISPLAY_NAME]";
            string newEnumValueDisplayName = "";
            // Make the request
            TagTemplateField response = await dataCatalogClient.RenameTagTemplateFieldEnumValueAsync(name, newEnumValueDisplayName);
            // End snippet
        }

        /// <summary>Snippet for RenameTagTemplateFieldEnumValue</summary>
        public void RenameTagTemplateFieldEnumValueResourceNames()
        {
            // Snippet: RenameTagTemplateFieldEnumValue(TagTemplateFieldEnumValueName, string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            TagTemplateFieldEnumValueName name = TagTemplateFieldEnumValueName.FromProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[TAG_TEMPLATE_FIELD_ID]", "[ENUM_VALUE_DISPLAY_NAME]");
            string newEnumValueDisplayName = "";
            // Make the request
            TagTemplateField response = dataCatalogClient.RenameTagTemplateFieldEnumValue(name, newEnumValueDisplayName);
            // End snippet
        }

        /// <summary>Snippet for RenameTagTemplateFieldEnumValueAsync</summary>
        public async Task RenameTagTemplateFieldEnumValueResourceNamesAsync()
        {
            // Snippet: RenameTagTemplateFieldEnumValueAsync(TagTemplateFieldEnumValueName, string, CallSettings)
            // Additional: RenameTagTemplateFieldEnumValueAsync(TagTemplateFieldEnumValueName, string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            TagTemplateFieldEnumValueName name = TagTemplateFieldEnumValueName.FromProjectLocationTagTemplateTagTemplateFieldEnumValueDisplayName("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[TAG_TEMPLATE_FIELD_ID]", "[ENUM_VALUE_DISPLAY_NAME]");
            string newEnumValueDisplayName = "";
            // Make the request
            TagTemplateField response = await dataCatalogClient.RenameTagTemplateFieldEnumValueAsync(name, newEnumValueDisplayName);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagTemplateField</summary>
        public void DeleteTagTemplateFieldRequestObject()
        {
            // Snippet: DeleteTagTemplateField(DeleteTagTemplateFieldRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            DeleteTagTemplateFieldRequest request = new DeleteTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                Force = false,
            };
            // Make the request
            dataCatalogClient.DeleteTagTemplateField(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagTemplateFieldAsync</summary>
        public async Task DeleteTagTemplateFieldRequestObjectAsync()
        {
            // Snippet: DeleteTagTemplateFieldAsync(DeleteTagTemplateFieldRequest, CallSettings)
            // Additional: DeleteTagTemplateFieldAsync(DeleteTagTemplateFieldRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTagTemplateFieldRequest request = new DeleteTagTemplateFieldRequest
            {
                TagTemplateFieldName = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]"),
                Force = false,
            };
            // Make the request
            await dataCatalogClient.DeleteTagTemplateFieldAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagTemplateField</summary>
        public void DeleteTagTemplateField()
        {
            // Snippet: DeleteTagTemplateField(string, bool, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]/fields/[FIELD]";
            bool force = false;
            // Make the request
            dataCatalogClient.DeleteTagTemplateField(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagTemplateFieldAsync</summary>
        public async Task DeleteTagTemplateFieldAsync()
        {
            // Snippet: DeleteTagTemplateFieldAsync(string, bool, CallSettings)
            // Additional: DeleteTagTemplateFieldAsync(string, bool, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/tagTemplates/[TAG_TEMPLATE]/fields/[FIELD]";
            bool force = false;
            // Make the request
            await dataCatalogClient.DeleteTagTemplateFieldAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagTemplateField</summary>
        public void DeleteTagTemplateFieldResourceNames()
        {
            // Snippet: DeleteTagTemplateField(TagTemplateFieldName, bool, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            TagTemplateFieldName name = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]");
            bool force = false;
            // Make the request
            dataCatalogClient.DeleteTagTemplateField(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagTemplateFieldAsync</summary>
        public async Task DeleteTagTemplateFieldResourceNamesAsync()
        {
            // Snippet: DeleteTagTemplateFieldAsync(TagTemplateFieldName, bool, CallSettings)
            // Additional: DeleteTagTemplateFieldAsync(TagTemplateFieldName, bool, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            TagTemplateFieldName name = TagTemplateFieldName.FromProjectLocationTagTemplateField("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]", "[FIELD]");
            bool force = false;
            // Make the request
            await dataCatalogClient.DeleteTagTemplateFieldAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for CreateTag</summary>
        public void CreateTagRequestObject()
        {
            // Snippet: CreateTag(CreateTagRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            CreateTagRequest request = new CreateTagRequest
            {
                ParentAsEntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Tag = new Tag(),
            };
            // Make the request
            Tag response = dataCatalogClient.CreateTag(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTagAsync</summary>
        public async Task CreateTagRequestObjectAsync()
        {
            // Snippet: CreateTagAsync(CreateTagRequest, CallSettings)
            // Additional: CreateTagAsync(CreateTagRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            CreateTagRequest request = new CreateTagRequest
            {
                ParentAsEntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                Tag = new Tag(),
            };
            // Make the request
            Tag response = await dataCatalogClient.CreateTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTag</summary>
        public void CreateTag()
        {
            // Snippet: CreateTag(string, Tag, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            Tag tag = new Tag();
            // Make the request
            Tag response = dataCatalogClient.CreateTag(parent, tag);
            // End snippet
        }

        /// <summary>Snippet for CreateTagAsync</summary>
        public async Task CreateTagAsync()
        {
            // Snippet: CreateTagAsync(string, Tag, CallSettings)
            // Additional: CreateTagAsync(string, Tag, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            Tag tag = new Tag();
            // Make the request
            Tag response = await dataCatalogClient.CreateTagAsync(parent, tag);
            // End snippet
        }

        /// <summary>Snippet for CreateTag</summary>
        public void CreateTagResourceNames()
        {
            // Snippet: CreateTag(EntryName, Tag, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryName parent = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            Tag tag = new Tag();
            // Make the request
            Tag response = dataCatalogClient.CreateTag(parent, tag);
            // End snippet
        }

        /// <summary>Snippet for CreateTagAsync</summary>
        public async Task CreateTagResourceNamesAsync()
        {
            // Snippet: CreateTagAsync(EntryName, Tag, CallSettings)
            // Additional: CreateTagAsync(EntryName, Tag, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryName parent = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            Tag tag = new Tag();
            // Make the request
            Tag response = await dataCatalogClient.CreateTagAsync(parent, tag);
            // End snippet
        }

        /// <summary>Snippet for UpdateTag</summary>
        public void UpdateTagRequestObject()
        {
            // Snippet: UpdateTag(UpdateTagRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            UpdateTagRequest request = new UpdateTagRequest
            {
                Tag = new Tag(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Tag response = dataCatalogClient.UpdateTag(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagAsync</summary>
        public async Task UpdateTagRequestObjectAsync()
        {
            // Snippet: UpdateTagAsync(UpdateTagRequest, CallSettings)
            // Additional: UpdateTagAsync(UpdateTagRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTagRequest request = new UpdateTagRequest
            {
                Tag = new Tag(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Tag response = await dataCatalogClient.UpdateTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateTag</summary>
        public void UpdateTag1()
        {
            // Snippet: UpdateTag(Tag, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            Tag tag = new Tag();
            // Make the request
            Tag response = dataCatalogClient.UpdateTag(tag);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagAsync</summary>
        public async Task UpdateTag1Async()
        {
            // Snippet: UpdateTagAsync(Tag, CallSettings)
            // Additional: UpdateTagAsync(Tag, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            Tag tag = new Tag();
            // Make the request
            Tag response = await dataCatalogClient.UpdateTagAsync(tag);
            // End snippet
        }

        /// <summary>Snippet for UpdateTag</summary>
        public void UpdateTag2()
        {
            // Snippet: UpdateTag(Tag, FieldMask, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            Tag tag = new Tag();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Tag response = dataCatalogClient.UpdateTag(tag, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateTagAsync</summary>
        public async Task UpdateTag2Async()
        {
            // Snippet: UpdateTagAsync(Tag, FieldMask, CallSettings)
            // Additional: UpdateTagAsync(Tag, FieldMask, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            Tag tag = new Tag();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Tag response = await dataCatalogClient.UpdateTagAsync(tag, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteTag</summary>
        public void DeleteTagRequestObject()
        {
            // Snippet: DeleteTag(DeleteTagRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            DeleteTagRequest request = new DeleteTagRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            dataCatalogClient.DeleteTag(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagAsync</summary>
        public async Task DeleteTagRequestObjectAsync()
        {
            // Snippet: DeleteTagAsync(DeleteTagRequest, CallSettings)
            // Additional: DeleteTagAsync(DeleteTagRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTagRequest request = new DeleteTagRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            await dataCatalogClient.DeleteTagAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTag</summary>
        public void DeleteTag()
        {
            // Snippet: DeleteTag(string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            dataCatalogClient.DeleteTag(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagAsync</summary>
        public async Task DeleteTagAsync()
        {
            // Snippet: DeleteTagAsync(string, CallSettings)
            // Additional: DeleteTagAsync(string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            await dataCatalogClient.DeleteTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTag</summary>
        public void DeleteTagResourceNames()
        {
            // Snippet: DeleteTag(EntryName, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryName name = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            dataCatalogClient.DeleteTag(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTagAsync</summary>
        public async Task DeleteTagResourceNamesAsync()
        {
            // Snippet: DeleteTagAsync(EntryName, CallSettings)
            // Additional: DeleteTagAsync(EntryName, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryName name = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            await dataCatalogClient.DeleteTagAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTags</summary>
        public void ListTagsRequestObject()
        {
            // Snippet: ListTags(ListTagsRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            ListTagsRequest request = new ListTagsRequest
            {
                ParentAsEntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            PagedEnumerable<ListTagsResponse, Tag> response = dataCatalogClient.ListTags(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagsAsync</summary>
        public async Task ListTagsRequestObjectAsync()
        {
            // Snippet: ListTagsAsync(ListTagsRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            ListTagsRequest request = new ListTagsRequest
            {
                ParentAsEntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTagsResponse, Tag> response = dataCatalogClient.ListTagsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTags</summary>
        public void ListTags()
        {
            // Snippet: ListTags(string, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            PagedEnumerable<ListTagsResponse, Tag> response = dataCatalogClient.ListTags(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagsAsync</summary>
        public async Task ListTagsAsync()
        {
            // Snippet: ListTagsAsync(string, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            PagedAsyncEnumerable<ListTagsResponse, Tag> response = dataCatalogClient.ListTagsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTags</summary>
        public void ListTagsResourceNames()
        {
            // Snippet: ListTags(EntryName, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryName parent = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            PagedEnumerable<ListTagsResponse, Tag> response = dataCatalogClient.ListTags(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Tag item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTagsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTagsAsync</summary>
        public async Task ListTagsResourceNamesAsync()
        {
            // Snippet: ListTagsAsync(EntryName, string, int?, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryName parent = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            PagedAsyncEnumerable<ListTagsResponse, Tag> response = dataCatalogClient.ListTagsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Tag item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTagsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Tag item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Tag> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Tag item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ReconcileTags</summary>
        public void ReconcileTagsRequestObject()
        {
            // Snippet: ReconcileTags(ReconcileTagsRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            ReconcileTagsRequest request = new ReconcileTagsRequest
            {
                ParentAsEntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                TagTemplateAsTagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                ForceDeleteMissing = false,
                Tags = { new Tag(), },
            };
            // Make the request
            Operation<ReconcileTagsResponse, ReconcileTagsMetadata> response = dataCatalogClient.ReconcileTags(request);

            // Poll until the returned long-running operation is complete
            Operation<ReconcileTagsResponse, ReconcileTagsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ReconcileTagsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReconcileTagsResponse, ReconcileTagsMetadata> retrievedResponse = dataCatalogClient.PollOnceReconcileTags(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReconcileTagsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ReconcileTagsAsync</summary>
        public async Task ReconcileTagsRequestObjectAsync()
        {
            // Snippet: ReconcileTagsAsync(ReconcileTagsRequest, CallSettings)
            // Additional: ReconcileTagsAsync(ReconcileTagsRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            ReconcileTagsRequest request = new ReconcileTagsRequest
            {
                ParentAsEntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
                TagTemplateAsTagTemplateName = TagTemplateName.FromProjectLocationTagTemplate("[PROJECT]", "[LOCATION]", "[TAG_TEMPLATE]"),
                ForceDeleteMissing = false,
                Tags = { new Tag(), },
            };
            // Make the request
            Operation<ReconcileTagsResponse, ReconcileTagsMetadata> response = await dataCatalogClient.ReconcileTagsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ReconcileTagsResponse, ReconcileTagsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ReconcileTagsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ReconcileTagsResponse, ReconcileTagsMetadata> retrievedResponse = await dataCatalogClient.PollOnceReconcileTagsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ReconcileTagsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for StarEntry</summary>
        public void StarEntryRequestObject()
        {
            // Snippet: StarEntry(StarEntryRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            StarEntryRequest request = new StarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            StarEntryResponse response = dataCatalogClient.StarEntry(request);
            // End snippet
        }

        /// <summary>Snippet for StarEntryAsync</summary>
        public async Task StarEntryRequestObjectAsync()
        {
            // Snippet: StarEntryAsync(StarEntryRequest, CallSettings)
            // Additional: StarEntryAsync(StarEntryRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            StarEntryRequest request = new StarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            StarEntryResponse response = await dataCatalogClient.StarEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StarEntry</summary>
        public void StarEntry()
        {
            // Snippet: StarEntry(string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            StarEntryResponse response = dataCatalogClient.StarEntry(name);
            // End snippet
        }

        /// <summary>Snippet for StarEntryAsync</summary>
        public async Task StarEntryAsync()
        {
            // Snippet: StarEntryAsync(string, CallSettings)
            // Additional: StarEntryAsync(string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            StarEntryResponse response = await dataCatalogClient.StarEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for StarEntry</summary>
        public void StarEntryResourceNames()
        {
            // Snippet: StarEntry(EntryName, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryName name = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            StarEntryResponse response = dataCatalogClient.StarEntry(name);
            // End snippet
        }

        /// <summary>Snippet for StarEntryAsync</summary>
        public async Task StarEntryResourceNamesAsync()
        {
            // Snippet: StarEntryAsync(EntryName, CallSettings)
            // Additional: StarEntryAsync(EntryName, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryName name = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            StarEntryResponse response = await dataCatalogClient.StarEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UnstarEntry</summary>
        public void UnstarEntryRequestObject()
        {
            // Snippet: UnstarEntry(UnstarEntryRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            UnstarEntryRequest request = new UnstarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            UnstarEntryResponse response = dataCatalogClient.UnstarEntry(request);
            // End snippet
        }

        /// <summary>Snippet for UnstarEntryAsync</summary>
        public async Task UnstarEntryRequestObjectAsync()
        {
            // Snippet: UnstarEntryAsync(UnstarEntryRequest, CallSettings)
            // Additional: UnstarEntryAsync(UnstarEntryRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            UnstarEntryRequest request = new UnstarEntryRequest
            {
                EntryName = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]"),
            };
            // Make the request
            UnstarEntryResponse response = await dataCatalogClient.UnstarEntryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UnstarEntry</summary>
        public void UnstarEntry()
        {
            // Snippet: UnstarEntry(string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            UnstarEntryResponse response = dataCatalogClient.UnstarEntry(name);
            // End snippet
        }

        /// <summary>Snippet for UnstarEntryAsync</summary>
        public async Task UnstarEntryAsync()
        {
            // Snippet: UnstarEntryAsync(string, CallSettings)
            // Additional: UnstarEntryAsync(string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entryGroups/[ENTRY_GROUP]/entries/[ENTRY]";
            // Make the request
            UnstarEntryResponse response = await dataCatalogClient.UnstarEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UnstarEntry</summary>
        public void UnstarEntryResourceNames()
        {
            // Snippet: UnstarEntry(EntryName, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            EntryName name = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            UnstarEntryResponse response = dataCatalogClient.UnstarEntry(name);
            // End snippet
        }

        /// <summary>Snippet for UnstarEntryAsync</summary>
        public async Task UnstarEntryResourceNamesAsync()
        {
            // Snippet: UnstarEntryAsync(EntryName, CallSettings)
            // Additional: UnstarEntryAsync(EntryName, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            EntryName name = EntryName.FromProjectLocationEntryGroupEntry("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]", "[ENTRY]");
            // Make the request
            UnstarEntryResponse response = await dataCatalogClient.UnstarEntryAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = dataCatalogClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await dataCatalogClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = dataCatalogClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await dataCatalogClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = dataCatalogClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await dataCatalogClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = dataCatalogClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await dataCatalogClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = dataCatalogClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await dataCatalogClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = dataCatalogClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await dataCatalogClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = dataCatalogClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await dataCatalogClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ImportEntries</summary>
        public void ImportEntriesRequestObject()
        {
            // Snippet: ImportEntries(ImportEntriesRequest, CallSettings)
            // Create client
            DataCatalogClient dataCatalogClient = DataCatalogClient.Create();
            // Initialize request argument(s)
            ImportEntriesRequest request = new ImportEntriesRequest
            {
                ParentAsEntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                GcsBucketPath = "",
                JobId = "",
            };
            // Make the request
            Operation<ImportEntriesResponse, ImportEntriesMetadata> response = dataCatalogClient.ImportEntries(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportEntriesResponse, ImportEntriesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ImportEntriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportEntriesResponse, ImportEntriesMetadata> retrievedResponse = dataCatalogClient.PollOnceImportEntries(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportEntriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportEntriesAsync</summary>
        public async Task ImportEntriesRequestObjectAsync()
        {
            // Snippet: ImportEntriesAsync(ImportEntriesRequest, CallSettings)
            // Additional: ImportEntriesAsync(ImportEntriesRequest, CancellationToken)
            // Create client
            DataCatalogClient dataCatalogClient = await DataCatalogClient.CreateAsync();
            // Initialize request argument(s)
            ImportEntriesRequest request = new ImportEntriesRequest
            {
                ParentAsEntryGroupName = EntryGroupName.FromProjectLocationEntryGroup("[PROJECT]", "[LOCATION]", "[ENTRY_GROUP]"),
                GcsBucketPath = "",
                JobId = "",
            };
            // Make the request
            Operation<ImportEntriesResponse, ImportEntriesMetadata> response = await dataCatalogClient.ImportEntriesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ImportEntriesResponse, ImportEntriesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ImportEntriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ImportEntriesResponse, ImportEntriesMetadata> retrievedResponse = await dataCatalogClient.PollOnceImportEntriesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ImportEntriesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
