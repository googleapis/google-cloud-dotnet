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
    using Google.Ads.AdManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Linq;
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
            await response.ForEachAsync((Application item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            await response.ForEachAsync((Application item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
            await response.ForEachAsync((Application item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApplicationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Application item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

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
    }
}
