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
    using Google.Cloud.Compute.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedInterconnectRemoteLocationsClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(GetInterconnectRemoteLocationRequest, CallSettings)
            // Create client
            InterconnectRemoteLocationsClient interconnectRemoteLocationsClient = InterconnectRemoteLocationsClient.Create();
            // Initialize request argument(s)
            GetInterconnectRemoteLocationRequest request = new GetInterconnectRemoteLocationRequest
            {
                Project = "",
                InterconnectRemoteLocation = "",
            };
            // Make the request
            InterconnectRemoteLocation response = interconnectRemoteLocationsClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(GetInterconnectRemoteLocationRequest, CallSettings)
            // Additional: GetAsync(GetInterconnectRemoteLocationRequest, CancellationToken)
            // Create client
            InterconnectRemoteLocationsClient interconnectRemoteLocationsClient = await InterconnectRemoteLocationsClient.CreateAsync();
            // Initialize request argument(s)
            GetInterconnectRemoteLocationRequest request = new GetInterconnectRemoteLocationRequest
            {
                Project = "",
                InterconnectRemoteLocation = "",
            };
            // Make the request
            InterconnectRemoteLocation response = await interconnectRemoteLocationsClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void Get()
        {
            // Snippet: Get(string, string, CallSettings)
            // Create client
            InterconnectRemoteLocationsClient interconnectRemoteLocationsClient = InterconnectRemoteLocationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            string interconnectRemoteLocation = "";
            // Make the request
            InterconnectRemoteLocation response = interconnectRemoteLocationsClient.Get(project, interconnectRemoteLocation);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetAsync()
        {
            // Snippet: GetAsync(string, string, CallSettings)
            // Additional: GetAsync(string, string, CancellationToken)
            // Create client
            InterconnectRemoteLocationsClient interconnectRemoteLocationsClient = await InterconnectRemoteLocationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            string interconnectRemoteLocation = "";
            // Make the request
            InterconnectRemoteLocation response = await interconnectRemoteLocationsClient.GetAsync(project, interconnectRemoteLocation);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(ListInterconnectRemoteLocationsRequest, CallSettings)
            // Create client
            InterconnectRemoteLocationsClient interconnectRemoteLocationsClient = InterconnectRemoteLocationsClient.Create();
            // Initialize request argument(s)
            ListInterconnectRemoteLocationsRequest request = new ListInterconnectRemoteLocationsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedEnumerable<InterconnectRemoteLocationList, InterconnectRemoteLocation> response = interconnectRemoteLocationsClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectRemoteLocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectRemoteLocationList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectRemoteLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectRemoteLocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectRemoteLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(ListInterconnectRemoteLocationsRequest, CallSettings)
            // Create client
            InterconnectRemoteLocationsClient interconnectRemoteLocationsClient = await InterconnectRemoteLocationsClient.CreateAsync();
            // Initialize request argument(s)
            ListInterconnectRemoteLocationsRequest request = new ListInterconnectRemoteLocationsRequest
            {
                OrderBy = "",
                Project = "",
                Filter = "",
                ReturnPartialSuccess = false,
            };
            // Make the request
            PagedAsyncEnumerable<InterconnectRemoteLocationList, InterconnectRemoteLocation> response = interconnectRemoteLocationsClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectRemoteLocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectRemoteLocationList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectRemoteLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectRemoteLocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectRemoteLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void List()
        {
            // Snippet: List(string, string, int?, CallSettings)
            // Create client
            InterconnectRemoteLocationsClient interconnectRemoteLocationsClient = InterconnectRemoteLocationsClient.Create();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedEnumerable<InterconnectRemoteLocationList, InterconnectRemoteLocation> response = interconnectRemoteLocationsClient.List(project);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (InterconnectRemoteLocation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InterconnectRemoteLocationList page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectRemoteLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectRemoteLocation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectRemoteLocation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListAsync()
        {
            // Snippet: ListAsync(string, string, int?, CallSettings)
            // Create client
            InterconnectRemoteLocationsClient interconnectRemoteLocationsClient = await InterconnectRemoteLocationsClient.CreateAsync();
            // Initialize request argument(s)
            string project = "";
            // Make the request
            PagedAsyncEnumerable<InterconnectRemoteLocationList, InterconnectRemoteLocation> response = interconnectRemoteLocationsClient.ListAsync(project);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((InterconnectRemoteLocation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((InterconnectRemoteLocationList page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (InterconnectRemoteLocation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<InterconnectRemoteLocation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (InterconnectRemoteLocation item in singlePage)
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
