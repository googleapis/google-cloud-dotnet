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
    using Google.Cloud.ApiHub.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedHostProjectRegistrationServiceClientSnippets
    {
        /// <summary>Snippet for CreateHostProjectRegistration</summary>
        public void CreateHostProjectRegistrationRequestObject()
        {
            // Snippet: CreateHostProjectRegistration(CreateHostProjectRegistrationRequest, CallSettings)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = HostProjectRegistrationServiceClient.Create();
            // Initialize request argument(s)
            CreateHostProjectRegistrationRequest request = new CreateHostProjectRegistrationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HostProjectRegistrationId = "",
                HostProjectRegistration = new HostProjectRegistration(),
            };
            // Make the request
            HostProjectRegistration response = hostProjectRegistrationServiceClient.CreateHostProjectRegistration(request);
            // End snippet
        }

        /// <summary>Snippet for CreateHostProjectRegistrationAsync</summary>
        public async Task CreateHostProjectRegistrationRequestObjectAsync()
        {
            // Snippet: CreateHostProjectRegistrationAsync(CreateHostProjectRegistrationRequest, CallSettings)
            // Additional: CreateHostProjectRegistrationAsync(CreateHostProjectRegistrationRequest, CancellationToken)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = await HostProjectRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateHostProjectRegistrationRequest request = new CreateHostProjectRegistrationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HostProjectRegistrationId = "",
                HostProjectRegistration = new HostProjectRegistration(),
            };
            // Make the request
            HostProjectRegistration response = await hostProjectRegistrationServiceClient.CreateHostProjectRegistrationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateHostProjectRegistration</summary>
        public void CreateHostProjectRegistration()
        {
            // Snippet: CreateHostProjectRegistration(string, HostProjectRegistration, string, CallSettings)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = HostProjectRegistrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            HostProjectRegistration hostProjectRegistration = new HostProjectRegistration();
            string hostProjectRegistrationId = "";
            // Make the request
            HostProjectRegistration response = hostProjectRegistrationServiceClient.CreateHostProjectRegistration(parent, hostProjectRegistration, hostProjectRegistrationId);
            // End snippet
        }

        /// <summary>Snippet for CreateHostProjectRegistrationAsync</summary>
        public async Task CreateHostProjectRegistrationAsync()
        {
            // Snippet: CreateHostProjectRegistrationAsync(string, HostProjectRegistration, string, CallSettings)
            // Additional: CreateHostProjectRegistrationAsync(string, HostProjectRegistration, string, CancellationToken)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = await HostProjectRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            HostProjectRegistration hostProjectRegistration = new HostProjectRegistration();
            string hostProjectRegistrationId = "";
            // Make the request
            HostProjectRegistration response = await hostProjectRegistrationServiceClient.CreateHostProjectRegistrationAsync(parent, hostProjectRegistration, hostProjectRegistrationId);
            // End snippet
        }

        /// <summary>Snippet for CreateHostProjectRegistration</summary>
        public void CreateHostProjectRegistrationResourceNames()
        {
            // Snippet: CreateHostProjectRegistration(LocationName, HostProjectRegistration, string, CallSettings)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = HostProjectRegistrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            HostProjectRegistration hostProjectRegistration = new HostProjectRegistration();
            string hostProjectRegistrationId = "";
            // Make the request
            HostProjectRegistration response = hostProjectRegistrationServiceClient.CreateHostProjectRegistration(parent, hostProjectRegistration, hostProjectRegistrationId);
            // End snippet
        }

        /// <summary>Snippet for CreateHostProjectRegistrationAsync</summary>
        public async Task CreateHostProjectRegistrationResourceNamesAsync()
        {
            // Snippet: CreateHostProjectRegistrationAsync(LocationName, HostProjectRegistration, string, CallSettings)
            // Additional: CreateHostProjectRegistrationAsync(LocationName, HostProjectRegistration, string, CancellationToken)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = await HostProjectRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            HostProjectRegistration hostProjectRegistration = new HostProjectRegistration();
            string hostProjectRegistrationId = "";
            // Make the request
            HostProjectRegistration response = await hostProjectRegistrationServiceClient.CreateHostProjectRegistrationAsync(parent, hostProjectRegistration, hostProjectRegistrationId);
            // End snippet
        }

        /// <summary>Snippet for GetHostProjectRegistration</summary>
        public void GetHostProjectRegistrationRequestObject()
        {
            // Snippet: GetHostProjectRegistration(GetHostProjectRegistrationRequest, CallSettings)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = HostProjectRegistrationServiceClient.Create();
            // Initialize request argument(s)
            GetHostProjectRegistrationRequest request = new GetHostProjectRegistrationRequest
            {
                HostProjectRegistrationName = HostProjectRegistrationName.FromProjectLocationHostProjectRegistration("[PROJECT]", "[LOCATION]", "[HOST_PROJECT_REGISTRATION]"),
            };
            // Make the request
            HostProjectRegistration response = hostProjectRegistrationServiceClient.GetHostProjectRegistration(request);
            // End snippet
        }

        /// <summary>Snippet for GetHostProjectRegistrationAsync</summary>
        public async Task GetHostProjectRegistrationRequestObjectAsync()
        {
            // Snippet: GetHostProjectRegistrationAsync(GetHostProjectRegistrationRequest, CallSettings)
            // Additional: GetHostProjectRegistrationAsync(GetHostProjectRegistrationRequest, CancellationToken)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = await HostProjectRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetHostProjectRegistrationRequest request = new GetHostProjectRegistrationRequest
            {
                HostProjectRegistrationName = HostProjectRegistrationName.FromProjectLocationHostProjectRegistration("[PROJECT]", "[LOCATION]", "[HOST_PROJECT_REGISTRATION]"),
            };
            // Make the request
            HostProjectRegistration response = await hostProjectRegistrationServiceClient.GetHostProjectRegistrationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetHostProjectRegistration</summary>
        public void GetHostProjectRegistration()
        {
            // Snippet: GetHostProjectRegistration(string, CallSettings)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = HostProjectRegistrationServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/hostProjectRegistrations/[HOST_PROJECT_REGISTRATION]";
            // Make the request
            HostProjectRegistration response = hostProjectRegistrationServiceClient.GetHostProjectRegistration(name);
            // End snippet
        }

        /// <summary>Snippet for GetHostProjectRegistrationAsync</summary>
        public async Task GetHostProjectRegistrationAsync()
        {
            // Snippet: GetHostProjectRegistrationAsync(string, CallSettings)
            // Additional: GetHostProjectRegistrationAsync(string, CancellationToken)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = await HostProjectRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/hostProjectRegistrations/[HOST_PROJECT_REGISTRATION]";
            // Make the request
            HostProjectRegistration response = await hostProjectRegistrationServiceClient.GetHostProjectRegistrationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetHostProjectRegistration</summary>
        public void GetHostProjectRegistrationResourceNames()
        {
            // Snippet: GetHostProjectRegistration(HostProjectRegistrationName, CallSettings)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = HostProjectRegistrationServiceClient.Create();
            // Initialize request argument(s)
            HostProjectRegistrationName name = HostProjectRegistrationName.FromProjectLocationHostProjectRegistration("[PROJECT]", "[LOCATION]", "[HOST_PROJECT_REGISTRATION]");
            // Make the request
            HostProjectRegistration response = hostProjectRegistrationServiceClient.GetHostProjectRegistration(name);
            // End snippet
        }

        /// <summary>Snippet for GetHostProjectRegistrationAsync</summary>
        public async Task GetHostProjectRegistrationResourceNamesAsync()
        {
            // Snippet: GetHostProjectRegistrationAsync(HostProjectRegistrationName, CallSettings)
            // Additional: GetHostProjectRegistrationAsync(HostProjectRegistrationName, CancellationToken)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = await HostProjectRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            HostProjectRegistrationName name = HostProjectRegistrationName.FromProjectLocationHostProjectRegistration("[PROJECT]", "[LOCATION]", "[HOST_PROJECT_REGISTRATION]");
            // Make the request
            HostProjectRegistration response = await hostProjectRegistrationServiceClient.GetHostProjectRegistrationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListHostProjectRegistrations</summary>
        public void ListHostProjectRegistrationsRequestObject()
        {
            // Snippet: ListHostProjectRegistrations(ListHostProjectRegistrationsRequest, CallSettings)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = HostProjectRegistrationServiceClient.Create();
            // Initialize request argument(s)
            ListHostProjectRegistrationsRequest request = new ListHostProjectRegistrationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> response = hostProjectRegistrationServiceClient.ListHostProjectRegistrations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HostProjectRegistration item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHostProjectRegistrationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HostProjectRegistration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HostProjectRegistration> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HostProjectRegistration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHostProjectRegistrationsAsync</summary>
        public async Task ListHostProjectRegistrationsRequestObjectAsync()
        {
            // Snippet: ListHostProjectRegistrationsAsync(ListHostProjectRegistrationsRequest, CallSettings)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = await HostProjectRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListHostProjectRegistrationsRequest request = new ListHostProjectRegistrationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> response = hostProjectRegistrationServiceClient.ListHostProjectRegistrationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HostProjectRegistration item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHostProjectRegistrationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HostProjectRegistration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HostProjectRegistration> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HostProjectRegistration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHostProjectRegistrations</summary>
        public void ListHostProjectRegistrations()
        {
            // Snippet: ListHostProjectRegistrations(string, string, int?, CallSettings)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = HostProjectRegistrationServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> response = hostProjectRegistrationServiceClient.ListHostProjectRegistrations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HostProjectRegistration item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHostProjectRegistrationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HostProjectRegistration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HostProjectRegistration> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HostProjectRegistration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHostProjectRegistrationsAsync</summary>
        public async Task ListHostProjectRegistrationsAsync()
        {
            // Snippet: ListHostProjectRegistrationsAsync(string, string, int?, CallSettings)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = await HostProjectRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> response = hostProjectRegistrationServiceClient.ListHostProjectRegistrationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HostProjectRegistration item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHostProjectRegistrationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HostProjectRegistration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HostProjectRegistration> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HostProjectRegistration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHostProjectRegistrations</summary>
        public void ListHostProjectRegistrationsResourceNames()
        {
            // Snippet: ListHostProjectRegistrations(LocationName, string, int?, CallSettings)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = HostProjectRegistrationServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> response = hostProjectRegistrationServiceClient.ListHostProjectRegistrations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (HostProjectRegistration item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListHostProjectRegistrationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HostProjectRegistration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HostProjectRegistration> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HostProjectRegistration item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListHostProjectRegistrationsAsync</summary>
        public async Task ListHostProjectRegistrationsResourceNamesAsync()
        {
            // Snippet: ListHostProjectRegistrationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            HostProjectRegistrationServiceClient hostProjectRegistrationServiceClient = await HostProjectRegistrationServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListHostProjectRegistrationsResponse, HostProjectRegistration> response = hostProjectRegistrationServiceClient.ListHostProjectRegistrationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((HostProjectRegistration item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListHostProjectRegistrationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (HostProjectRegistration item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<HostProjectRegistration> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (HostProjectRegistration item in singlePage)
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
