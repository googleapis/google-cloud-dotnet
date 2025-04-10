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
    public sealed class AllGeneratedEntityServiceClientSnippets
    {
        /// <summary>Snippet for GetWatchlist</summary>
        public void GetWatchlistRequestObject()
        {
            // Snippet: GetWatchlist(GetWatchlistRequest, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            GetWatchlistRequest request = new GetWatchlistRequest
            {
                WatchlistName = WatchlistName.FromProjectLocationInstanceWatchlist("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[WATCHLIST]"),
            };
            // Make the request
            Watchlist response = entityServiceClient.GetWatchlist(request);
            // End snippet
        }

        /// <summary>Snippet for GetWatchlistAsync</summary>
        public async Task GetWatchlistRequestObjectAsync()
        {
            // Snippet: GetWatchlistAsync(GetWatchlistRequest, CallSettings)
            // Additional: GetWatchlistAsync(GetWatchlistRequest, CancellationToken)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetWatchlistRequest request = new GetWatchlistRequest
            {
                WatchlistName = WatchlistName.FromProjectLocationInstanceWatchlist("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[WATCHLIST]"),
            };
            // Make the request
            Watchlist response = await entityServiceClient.GetWatchlistAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWatchlist</summary>
        public void GetWatchlist()
        {
            // Snippet: GetWatchlist(string, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/watchlists/[WATCHLIST]";
            // Make the request
            Watchlist response = entityServiceClient.GetWatchlist(name);
            // End snippet
        }

        /// <summary>Snippet for GetWatchlistAsync</summary>
        public async Task GetWatchlistAsync()
        {
            // Snippet: GetWatchlistAsync(string, CallSettings)
            // Additional: GetWatchlistAsync(string, CancellationToken)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/watchlists/[WATCHLIST]";
            // Make the request
            Watchlist response = await entityServiceClient.GetWatchlistAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWatchlist</summary>
        public void GetWatchlistResourceNames()
        {
            // Snippet: GetWatchlist(WatchlistName, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            WatchlistName name = WatchlistName.FromProjectLocationInstanceWatchlist("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[WATCHLIST]");
            // Make the request
            Watchlist response = entityServiceClient.GetWatchlist(name);
            // End snippet
        }

        /// <summary>Snippet for GetWatchlistAsync</summary>
        public async Task GetWatchlistResourceNamesAsync()
        {
            // Snippet: GetWatchlistAsync(WatchlistName, CallSettings)
            // Additional: GetWatchlistAsync(WatchlistName, CancellationToken)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            WatchlistName name = WatchlistName.FromProjectLocationInstanceWatchlist("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[WATCHLIST]");
            // Make the request
            Watchlist response = await entityServiceClient.GetWatchlistAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListWatchlists</summary>
        public void ListWatchlistsRequestObject()
        {
            // Snippet: ListWatchlists(ListWatchlistsRequest, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            ListWatchlistsRequest request = new ListWatchlistsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListWatchlistsResponse, Watchlist> response = entityServiceClient.ListWatchlists(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Watchlist item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWatchlistsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Watchlist item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Watchlist> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Watchlist item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWatchlistsAsync</summary>
        public async Task ListWatchlistsRequestObjectAsync()
        {
            // Snippet: ListWatchlistsAsync(ListWatchlistsRequest, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListWatchlistsRequest request = new ListWatchlistsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListWatchlistsResponse, Watchlist> response = entityServiceClient.ListWatchlistsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Watchlist item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWatchlistsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Watchlist item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Watchlist> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Watchlist item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWatchlists</summary>
        public void ListWatchlists()
        {
            // Snippet: ListWatchlists(string, string, int?, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListWatchlistsResponse, Watchlist> response = entityServiceClient.ListWatchlists(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Watchlist item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWatchlistsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Watchlist item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Watchlist> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Watchlist item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWatchlistsAsync</summary>
        public async Task ListWatchlistsAsync()
        {
            // Snippet: ListWatchlistsAsync(string, string, int?, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListWatchlistsResponse, Watchlist> response = entityServiceClient.ListWatchlistsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Watchlist item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWatchlistsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Watchlist item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Watchlist> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Watchlist item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWatchlists</summary>
        public void ListWatchlistsResourceNames()
        {
            // Snippet: ListWatchlists(InstanceName, string, int?, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListWatchlistsResponse, Watchlist> response = entityServiceClient.ListWatchlists(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Watchlist item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWatchlistsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Watchlist item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Watchlist> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Watchlist item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWatchlistsAsync</summary>
        public async Task ListWatchlistsResourceNamesAsync()
        {
            // Snippet: ListWatchlistsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListWatchlistsResponse, Watchlist> response = entityServiceClient.ListWatchlistsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Watchlist item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWatchlistsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Watchlist item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Watchlist> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Watchlist item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateWatchlist</summary>
        public void CreateWatchlistRequestObject()
        {
            // Snippet: CreateWatchlist(CreateWatchlistRequest, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            CreateWatchlistRequest request = new CreateWatchlistRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                WatchlistId = "",
                Watchlist = new Watchlist(),
            };
            // Make the request
            Watchlist response = entityServiceClient.CreateWatchlist(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWatchlistAsync</summary>
        public async Task CreateWatchlistRequestObjectAsync()
        {
            // Snippet: CreateWatchlistAsync(CreateWatchlistRequest, CallSettings)
            // Additional: CreateWatchlistAsync(CreateWatchlistRequest, CancellationToken)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateWatchlistRequest request = new CreateWatchlistRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                WatchlistId = "",
                Watchlist = new Watchlist(),
            };
            // Make the request
            Watchlist response = await entityServiceClient.CreateWatchlistAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateWatchlist</summary>
        public void CreateWatchlist()
        {
            // Snippet: CreateWatchlist(string, Watchlist, string, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            Watchlist watchlist = new Watchlist();
            string watchlistId = "";
            // Make the request
            Watchlist response = entityServiceClient.CreateWatchlist(parent, watchlist, watchlistId);
            // End snippet
        }

        /// <summary>Snippet for CreateWatchlistAsync</summary>
        public async Task CreateWatchlistAsync()
        {
            // Snippet: CreateWatchlistAsync(string, Watchlist, string, CallSettings)
            // Additional: CreateWatchlistAsync(string, Watchlist, string, CancellationToken)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            Watchlist watchlist = new Watchlist();
            string watchlistId = "";
            // Make the request
            Watchlist response = await entityServiceClient.CreateWatchlistAsync(parent, watchlist, watchlistId);
            // End snippet
        }

        /// <summary>Snippet for CreateWatchlist</summary>
        public void CreateWatchlistResourceNames()
        {
            // Snippet: CreateWatchlist(InstanceName, Watchlist, string, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Watchlist watchlist = new Watchlist();
            string watchlistId = "";
            // Make the request
            Watchlist response = entityServiceClient.CreateWatchlist(parent, watchlist, watchlistId);
            // End snippet
        }

        /// <summary>Snippet for CreateWatchlistAsync</summary>
        public async Task CreateWatchlistResourceNamesAsync()
        {
            // Snippet: CreateWatchlistAsync(InstanceName, Watchlist, string, CallSettings)
            // Additional: CreateWatchlistAsync(InstanceName, Watchlist, string, CancellationToken)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            Watchlist watchlist = new Watchlist();
            string watchlistId = "";
            // Make the request
            Watchlist response = await entityServiceClient.CreateWatchlistAsync(parent, watchlist, watchlistId);
            // End snippet
        }

        /// <summary>Snippet for UpdateWatchlist</summary>
        public void UpdateWatchlistRequestObject()
        {
            // Snippet: UpdateWatchlist(UpdateWatchlistRequest, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            UpdateWatchlistRequest request = new UpdateWatchlistRequest
            {
                Watchlist = new Watchlist(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Watchlist response = entityServiceClient.UpdateWatchlist(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWatchlistAsync</summary>
        public async Task UpdateWatchlistRequestObjectAsync()
        {
            // Snippet: UpdateWatchlistAsync(UpdateWatchlistRequest, CallSettings)
            // Additional: UpdateWatchlistAsync(UpdateWatchlistRequest, CancellationToken)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateWatchlistRequest request = new UpdateWatchlistRequest
            {
                Watchlist = new Watchlist(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Watchlist response = await entityServiceClient.UpdateWatchlistAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateWatchlist</summary>
        public void UpdateWatchlist()
        {
            // Snippet: UpdateWatchlist(Watchlist, FieldMask, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            Watchlist watchlist = new Watchlist();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Watchlist response = entityServiceClient.UpdateWatchlist(watchlist, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateWatchlistAsync</summary>
        public async Task UpdateWatchlistAsync()
        {
            // Snippet: UpdateWatchlistAsync(Watchlist, FieldMask, CallSettings)
            // Additional: UpdateWatchlistAsync(Watchlist, FieldMask, CancellationToken)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            Watchlist watchlist = new Watchlist();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Watchlist response = await entityServiceClient.UpdateWatchlistAsync(watchlist, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteWatchlist</summary>
        public void DeleteWatchlistRequestObject()
        {
            // Snippet: DeleteWatchlist(DeleteWatchlistRequest, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            DeleteWatchlistRequest request = new DeleteWatchlistRequest
            {
                WatchlistName = WatchlistName.FromProjectLocationInstanceWatchlist("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[WATCHLIST]"),
                Force = false,
            };
            // Make the request
            entityServiceClient.DeleteWatchlist(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWatchlistAsync</summary>
        public async Task DeleteWatchlistRequestObjectAsync()
        {
            // Snippet: DeleteWatchlistAsync(DeleteWatchlistRequest, CallSettings)
            // Additional: DeleteWatchlistAsync(DeleteWatchlistRequest, CancellationToken)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteWatchlistRequest request = new DeleteWatchlistRequest
            {
                WatchlistName = WatchlistName.FromProjectLocationInstanceWatchlist("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[WATCHLIST]"),
                Force = false,
            };
            // Make the request
            await entityServiceClient.DeleteWatchlistAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteWatchlist</summary>
        public void DeleteWatchlist()
        {
            // Snippet: DeleteWatchlist(string, bool, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/watchlists/[WATCHLIST]";
            bool force = false;
            // Make the request
            entityServiceClient.DeleteWatchlist(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteWatchlistAsync</summary>
        public async Task DeleteWatchlistAsync()
        {
            // Snippet: DeleteWatchlistAsync(string, bool, CallSettings)
            // Additional: DeleteWatchlistAsync(string, bool, CancellationToken)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/watchlists/[WATCHLIST]";
            bool force = false;
            // Make the request
            await entityServiceClient.DeleteWatchlistAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteWatchlist</summary>
        public void DeleteWatchlistResourceNames()
        {
            // Snippet: DeleteWatchlist(WatchlistName, bool, CallSettings)
            // Create client
            EntityServiceClient entityServiceClient = EntityServiceClient.Create();
            // Initialize request argument(s)
            WatchlistName name = WatchlistName.FromProjectLocationInstanceWatchlist("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[WATCHLIST]");
            bool force = false;
            // Make the request
            entityServiceClient.DeleteWatchlist(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteWatchlistAsync</summary>
        public async Task DeleteWatchlistResourceNamesAsync()
        {
            // Snippet: DeleteWatchlistAsync(WatchlistName, bool, CallSettings)
            // Additional: DeleteWatchlistAsync(WatchlistName, bool, CancellationToken)
            // Create client
            EntityServiceClient entityServiceClient = await EntityServiceClient.CreateAsync();
            // Initialize request argument(s)
            WatchlistName name = WatchlistName.FromProjectLocationInstanceWatchlist("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[WATCHLIST]");
            bool force = false;
            // Make the request
            await entityServiceClient.DeleteWatchlistAsync(name, force);
            // End snippet
        }
    }
}
