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
    using Google.Cloud.LocationFinder.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedCloudLocationFinderClientSnippets
    {
        /// <summary>Snippet for ListCloudLocations</summary>
        public void ListCloudLocationsRequestObject()
        {
            // Snippet: ListCloudLocations(ListCloudLocationsRequest, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = CloudLocationFinderClient.Create();
            // Initialize request argument(s)
            ListCloudLocationsRequest request = new ListCloudLocationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListCloudLocationsResponse, CloudLocation> response = cloudLocationFinderClient.ListCloudLocations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudLocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudLocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudLocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudLocationsAsync</summary>
        public async Task ListCloudLocationsRequestObjectAsync()
        {
            // Snippet: ListCloudLocationsAsync(ListCloudLocationsRequest, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = await CloudLocationFinderClient.CreateAsync();
            // Initialize request argument(s)
            ListCloudLocationsRequest request = new ListCloudLocationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListCloudLocationsResponse, CloudLocation> response = cloudLocationFinderClient.ListCloudLocationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudLocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudLocationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudLocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudLocations</summary>
        public void ListCloudLocations()
        {
            // Snippet: ListCloudLocations(string, string, int?, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = CloudLocationFinderClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListCloudLocationsResponse, CloudLocation> response = cloudLocationFinderClient.ListCloudLocations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudLocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudLocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudLocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudLocationsAsync</summary>
        public async Task ListCloudLocationsAsync()
        {
            // Snippet: ListCloudLocationsAsync(string, string, int?, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = await CloudLocationFinderClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListCloudLocationsResponse, CloudLocation> response = cloudLocationFinderClient.ListCloudLocationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudLocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudLocationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudLocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudLocations</summary>
        public void ListCloudLocationsResourceNames()
        {
            // Snippet: ListCloudLocations(LocationName, string, int?, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = CloudLocationFinderClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListCloudLocationsResponse, CloudLocation> response = cloudLocationFinderClient.ListCloudLocations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudLocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListCloudLocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudLocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListCloudLocationsAsync</summary>
        public async Task ListCloudLocationsResourceNamesAsync()
        {
            // Snippet: ListCloudLocationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = await CloudLocationFinderClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListCloudLocationsResponse, CloudLocation> response = cloudLocationFinderClient.ListCloudLocationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudLocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListCloudLocationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudLocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetCloudLocation</summary>
        public void GetCloudLocationRequestObject()
        {
            // Snippet: GetCloudLocation(GetCloudLocationRequest, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = CloudLocationFinderClient.Create();
            // Initialize request argument(s)
            GetCloudLocationRequest request = new GetCloudLocationRequest
            {
                CloudLocationName = CloudLocationName.FromProjectLocationCloudLocation("[PROJECT]", "[LOCATION]", "[CLOUD_LOCATION]"),
            };
            // Make the request
            CloudLocation response = cloudLocationFinderClient.GetCloudLocation(request);
            // End snippet
        }

        /// <summary>Snippet for GetCloudLocationAsync</summary>
        public async Task GetCloudLocationRequestObjectAsync()
        {
            // Snippet: GetCloudLocationAsync(GetCloudLocationRequest, CallSettings)
            // Additional: GetCloudLocationAsync(GetCloudLocationRequest, CancellationToken)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = await CloudLocationFinderClient.CreateAsync();
            // Initialize request argument(s)
            GetCloudLocationRequest request = new GetCloudLocationRequest
            {
                CloudLocationName = CloudLocationName.FromProjectLocationCloudLocation("[PROJECT]", "[LOCATION]", "[CLOUD_LOCATION]"),
            };
            // Make the request
            CloudLocation response = await cloudLocationFinderClient.GetCloudLocationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetCloudLocation</summary>
        public void GetCloudLocation()
        {
            // Snippet: GetCloudLocation(string, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = CloudLocationFinderClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cloudLocations/[CLOUD_LOCATION]";
            // Make the request
            CloudLocation response = cloudLocationFinderClient.GetCloudLocation(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudLocationAsync</summary>
        public async Task GetCloudLocationAsync()
        {
            // Snippet: GetCloudLocationAsync(string, CallSettings)
            // Additional: GetCloudLocationAsync(string, CancellationToken)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = await CloudLocationFinderClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/cloudLocations/[CLOUD_LOCATION]";
            // Make the request
            CloudLocation response = await cloudLocationFinderClient.GetCloudLocationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudLocation</summary>
        public void GetCloudLocationResourceNames()
        {
            // Snippet: GetCloudLocation(CloudLocationName, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = CloudLocationFinderClient.Create();
            // Initialize request argument(s)
            CloudLocationName name = CloudLocationName.FromProjectLocationCloudLocation("[PROJECT]", "[LOCATION]", "[CLOUD_LOCATION]");
            // Make the request
            CloudLocation response = cloudLocationFinderClient.GetCloudLocation(name);
            // End snippet
        }

        /// <summary>Snippet for GetCloudLocationAsync</summary>
        public async Task GetCloudLocationResourceNamesAsync()
        {
            // Snippet: GetCloudLocationAsync(CloudLocationName, CallSettings)
            // Additional: GetCloudLocationAsync(CloudLocationName, CancellationToken)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = await CloudLocationFinderClient.CreateAsync();
            // Initialize request argument(s)
            CloudLocationName name = CloudLocationName.FromProjectLocationCloudLocation("[PROJECT]", "[LOCATION]", "[CLOUD_LOCATION]");
            // Make the request
            CloudLocation response = await cloudLocationFinderClient.GetCloudLocationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SearchCloudLocations</summary>
        public void SearchCloudLocationsRequestObject()
        {
            // Snippet: SearchCloudLocations(SearchCloudLocationsRequest, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = CloudLocationFinderClient.Create();
            // Initialize request argument(s)
            SearchCloudLocationsRequest request = new SearchCloudLocationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SourceCloudLocationAsCloudLocationName = CloudLocationName.FromProjectLocationCloudLocation("[PROJECT]", "[LOCATION]", "[CLOUD_LOCATION]"),
                Query = "",
            };
            // Make the request
            PagedEnumerable<SearchCloudLocationsResponse, CloudLocation> response = cloudLocationFinderClient.SearchCloudLocations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudLocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchCloudLocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudLocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchCloudLocationsAsync</summary>
        public async Task SearchCloudLocationsRequestObjectAsync()
        {
            // Snippet: SearchCloudLocationsAsync(SearchCloudLocationsRequest, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = await CloudLocationFinderClient.CreateAsync();
            // Initialize request argument(s)
            SearchCloudLocationsRequest request = new SearchCloudLocationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SourceCloudLocationAsCloudLocationName = CloudLocationName.FromProjectLocationCloudLocation("[PROJECT]", "[LOCATION]", "[CLOUD_LOCATION]"),
                Query = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchCloudLocationsResponse, CloudLocation> response = cloudLocationFinderClient.SearchCloudLocationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudLocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchCloudLocationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudLocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchCloudLocations</summary>
        public void SearchCloudLocations()
        {
            // Snippet: SearchCloudLocations(string, string, string, string, int?, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = CloudLocationFinderClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string sourceCloudLocation = "projects/[PROJECT]/locations/[LOCATION]/cloudLocations/[CLOUD_LOCATION]";
            string query = "";
            // Make the request
            PagedEnumerable<SearchCloudLocationsResponse, CloudLocation> response = cloudLocationFinderClient.SearchCloudLocations(parent, sourceCloudLocation, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudLocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchCloudLocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudLocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchCloudLocationsAsync</summary>
        public async Task SearchCloudLocationsAsync()
        {
            // Snippet: SearchCloudLocationsAsync(string, string, string, string, int?, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = await CloudLocationFinderClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string sourceCloudLocation = "projects/[PROJECT]/locations/[LOCATION]/cloudLocations/[CLOUD_LOCATION]";
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchCloudLocationsResponse, CloudLocation> response = cloudLocationFinderClient.SearchCloudLocationsAsync(parent, sourceCloudLocation, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudLocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchCloudLocationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudLocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchCloudLocations</summary>
        public void SearchCloudLocationsResourceNames()
        {
            // Snippet: SearchCloudLocations(LocationName, CloudLocationName, string, string, int?, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = CloudLocationFinderClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CloudLocationName sourceCloudLocation = CloudLocationName.FromProjectLocationCloudLocation("[PROJECT]", "[LOCATION]", "[CLOUD_LOCATION]");
            string query = "";
            // Make the request
            PagedEnumerable<SearchCloudLocationsResponse, CloudLocation> response = cloudLocationFinderClient.SearchCloudLocations(parent, sourceCloudLocation, query);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (CloudLocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchCloudLocationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudLocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchCloudLocationsAsync</summary>
        public async Task SearchCloudLocationsResourceNamesAsync()
        {
            // Snippet: SearchCloudLocationsAsync(LocationName, CloudLocationName, string, string, int?, CallSettings)
            // Create client
            CloudLocationFinderClient cloudLocationFinderClient = await CloudLocationFinderClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            CloudLocationName sourceCloudLocation = CloudLocationName.FromProjectLocationCloudLocation("[PROJECT]", "[LOCATION]", "[CLOUD_LOCATION]");
            string query = "";
            // Make the request
            PagedAsyncEnumerable<SearchCloudLocationsResponse, CloudLocation> response = cloudLocationFinderClient.SearchCloudLocationsAsync(parent, sourceCloudLocation, query);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((CloudLocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchCloudLocationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (CloudLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<CloudLocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (CloudLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
