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
    using Google.Cloud.PrivilegedAccessManager.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPrivilegedAccessManagerClientSnippets
    {
        /// <summary>Snippet for CheckOnboardingStatus</summary>
        public void CheckOnboardingStatusRequestObject()
        {
            // Snippet: CheckOnboardingStatus(CheckOnboardingStatusRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            CheckOnboardingStatusRequest request = new CheckOnboardingStatusRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            CheckOnboardingStatusResponse response = privilegedAccessManagerClient.CheckOnboardingStatus(request);
            // End snippet
        }

        /// <summary>Snippet for CheckOnboardingStatusAsync</summary>
        public async Task CheckOnboardingStatusRequestObjectAsync()
        {
            // Snippet: CheckOnboardingStatusAsync(CheckOnboardingStatusRequest, CallSettings)
            // Additional: CheckOnboardingStatusAsync(CheckOnboardingStatusRequest, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            CheckOnboardingStatusRequest request = new CheckOnboardingStatusRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            CheckOnboardingStatusResponse response = await privilegedAccessManagerClient.CheckOnboardingStatusAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListEntitlements</summary>
        public void ListEntitlementsRequestObject()
        {
            // Snippet: ListEntitlements(ListEntitlementsRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            ListEntitlementsRequest request = new ListEntitlementsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListEntitlementsResponse, Entitlement> response = privilegedAccessManagerClient.ListEntitlements(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entitlement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitlementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlementsAsync</summary>
        public async Task ListEntitlementsRequestObjectAsync()
        {
            // Snippet: ListEntitlementsAsync(ListEntitlementsRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListEntitlementsRequest request = new ListEntitlementsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> response = privilegedAccessManagerClient.ListEntitlementsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entitlement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitlementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlements</summary>
        public void ListEntitlements()
        {
            // Snippet: ListEntitlements(string, string, int?, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListEntitlementsResponse, Entitlement> response = privilegedAccessManagerClient.ListEntitlements(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entitlement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitlementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlementsAsync</summary>
        public async Task ListEntitlementsAsync()
        {
            // Snippet: ListEntitlementsAsync(string, string, int?, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> response = privilegedAccessManagerClient.ListEntitlementsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entitlement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitlementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlements</summary>
        public void ListEntitlementsResourceNames1()
        {
            // Snippet: ListEntitlements(LocationName, string, int?, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEntitlementsResponse, Entitlement> response = privilegedAccessManagerClient.ListEntitlements(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entitlement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitlementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlementsAsync</summary>
        public async Task ListEntitlementsResourceNames1Async()
        {
            // Snippet: ListEntitlementsAsync(LocationName, string, int?, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> response = privilegedAccessManagerClient.ListEntitlementsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entitlement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitlementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlements</summary>
        public void ListEntitlementsResourceNames2()
        {
            // Snippet: ListEntitlements(FolderLocationName, string, int?, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEntitlementsResponse, Entitlement> response = privilegedAccessManagerClient.ListEntitlements(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entitlement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitlementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlementsAsync</summary>
        public async Task ListEntitlementsResourceNames2Async()
        {
            // Snippet: ListEntitlementsAsync(FolderLocationName, string, int?, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> response = privilegedAccessManagerClient.ListEntitlementsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entitlement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitlementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlements</summary>
        public void ListEntitlementsResourceNames3()
        {
            // Snippet: ListEntitlements(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListEntitlementsResponse, Entitlement> response = privilegedAccessManagerClient.ListEntitlements(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entitlement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEntitlementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEntitlementsAsync</summary>
        public async Task ListEntitlementsResourceNames3Async()
        {
            // Snippet: ListEntitlementsAsync(OrganizationLocationName, string, int?, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> response = privilegedAccessManagerClient.ListEntitlementsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entitlement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEntitlementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchEntitlements</summary>
        public void SearchEntitlementsRequestObject()
        {
            // Snippet: SearchEntitlements(SearchEntitlementsRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            SearchEntitlementsRequest request = new SearchEntitlementsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CallerAccessType = SearchEntitlementsRequest.Types.CallerAccessType.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedEnumerable<SearchEntitlementsResponse, Entitlement> response = privilegedAccessManagerClient.SearchEntitlements(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Entitlement item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchEntitlementsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchEntitlementsAsync</summary>
        public async Task SearchEntitlementsRequestObjectAsync()
        {
            // Snippet: SearchEntitlementsAsync(SearchEntitlementsRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            SearchEntitlementsRequest request = new SearchEntitlementsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CallerAccessType = SearchEntitlementsRequest.Types.CallerAccessType.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchEntitlementsResponse, Entitlement> response = privilegedAccessManagerClient.SearchEntitlementsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Entitlement item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchEntitlementsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Entitlement item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Entitlement> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Entitlement item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetEntitlement</summary>
        public void GetEntitlementRequestObject()
        {
            // Snippet: GetEntitlement(GetEntitlementRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            GetEntitlementRequest request = new GetEntitlementRequest
            {
                EntitlementName = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]"),
            };
            // Make the request
            Entitlement response = privilegedAccessManagerClient.GetEntitlement(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntitlementAsync</summary>
        public async Task GetEntitlementRequestObjectAsync()
        {
            // Snippet: GetEntitlementAsync(GetEntitlementRequest, CallSettings)
            // Additional: GetEntitlementAsync(GetEntitlementRequest, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetEntitlementRequest request = new GetEntitlementRequest
            {
                EntitlementName = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]"),
            };
            // Make the request
            Entitlement response = await privilegedAccessManagerClient.GetEntitlementAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEntitlement</summary>
        public void GetEntitlement()
        {
            // Snippet: GetEntitlement(string, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entitlements/[ENTITLEMENT]";
            // Make the request
            Entitlement response = privilegedAccessManagerClient.GetEntitlement(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntitlementAsync</summary>
        public async Task GetEntitlementAsync()
        {
            // Snippet: GetEntitlementAsync(string, CallSettings)
            // Additional: GetEntitlementAsync(string, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entitlements/[ENTITLEMENT]";
            // Make the request
            Entitlement response = await privilegedAccessManagerClient.GetEntitlementAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntitlement</summary>
        public void GetEntitlementResourceNames()
        {
            // Snippet: GetEntitlement(EntitlementName, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            EntitlementName name = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]");
            // Make the request
            Entitlement response = privilegedAccessManagerClient.GetEntitlement(name);
            // End snippet
        }

        /// <summary>Snippet for GetEntitlementAsync</summary>
        public async Task GetEntitlementResourceNamesAsync()
        {
            // Snippet: GetEntitlementAsync(EntitlementName, CallSettings)
            // Additional: GetEntitlementAsync(EntitlementName, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            EntitlementName name = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]");
            // Make the request
            Entitlement response = await privilegedAccessManagerClient.GetEntitlementAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateEntitlement</summary>
        public void CreateEntitlementRequestObject()
        {
            // Snippet: CreateEntitlement(CreateEntitlementRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            CreateEntitlementRequest request = new CreateEntitlementRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntitlementId = "",
                Entitlement = new Entitlement(),
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = privilegedAccessManagerClient.CreateEntitlement(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = privilegedAccessManagerClient.PollOnceCreateEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntitlementAsync</summary>
        public async Task CreateEntitlementRequestObjectAsync()
        {
            // Snippet: CreateEntitlementAsync(CreateEntitlementRequest, CallSettings)
            // Additional: CreateEntitlementAsync(CreateEntitlementRequest, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateEntitlementRequest request = new CreateEntitlementRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EntitlementId = "",
                Entitlement = new Entitlement(),
                RequestId = "",
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await privilegedAccessManagerClient.CreateEntitlementAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await privilegedAccessManagerClient.PollOnceCreateEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntitlement</summary>
        public void CreateEntitlement()
        {
            // Snippet: CreateEntitlement(string, Entitlement, string, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Entitlement entitlement = new Entitlement();
            string entitlementId = "";
            // Make the request
            Operation<Entitlement, OperationMetadata> response = privilegedAccessManagerClient.CreateEntitlement(parent, entitlement, entitlementId);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = privilegedAccessManagerClient.PollOnceCreateEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntitlementAsync</summary>
        public async Task CreateEntitlementAsync()
        {
            // Snippet: CreateEntitlementAsync(string, Entitlement, string, CallSettings)
            // Additional: CreateEntitlementAsync(string, Entitlement, string, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Entitlement entitlement = new Entitlement();
            string entitlementId = "";
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await privilegedAccessManagerClient.CreateEntitlementAsync(parent, entitlement, entitlementId);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await privilegedAccessManagerClient.PollOnceCreateEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntitlement</summary>
        public void CreateEntitlementResourceNames1()
        {
            // Snippet: CreateEntitlement(LocationName, Entitlement, string, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Entitlement entitlement = new Entitlement();
            string entitlementId = "";
            // Make the request
            Operation<Entitlement, OperationMetadata> response = privilegedAccessManagerClient.CreateEntitlement(parent, entitlement, entitlementId);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = privilegedAccessManagerClient.PollOnceCreateEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntitlementAsync</summary>
        public async Task CreateEntitlementResourceNames1Async()
        {
            // Snippet: CreateEntitlementAsync(LocationName, Entitlement, string, CallSettings)
            // Additional: CreateEntitlementAsync(LocationName, Entitlement, string, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Entitlement entitlement = new Entitlement();
            string entitlementId = "";
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await privilegedAccessManagerClient.CreateEntitlementAsync(parent, entitlement, entitlementId);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await privilegedAccessManagerClient.PollOnceCreateEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntitlement</summary>
        public void CreateEntitlementResourceNames2()
        {
            // Snippet: CreateEntitlement(FolderLocationName, Entitlement, string, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            Entitlement entitlement = new Entitlement();
            string entitlementId = "";
            // Make the request
            Operation<Entitlement, OperationMetadata> response = privilegedAccessManagerClient.CreateEntitlement(parent, entitlement, entitlementId);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = privilegedAccessManagerClient.PollOnceCreateEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntitlementAsync</summary>
        public async Task CreateEntitlementResourceNames2Async()
        {
            // Snippet: CreateEntitlementAsync(FolderLocationName, Entitlement, string, CallSettings)
            // Additional: CreateEntitlementAsync(FolderLocationName, Entitlement, string, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            FolderLocationName parent = FolderLocationName.FromFolderLocation("[FOLDER]", "[LOCATION]");
            Entitlement entitlement = new Entitlement();
            string entitlementId = "";
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await privilegedAccessManagerClient.CreateEntitlementAsync(parent, entitlement, entitlementId);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await privilegedAccessManagerClient.PollOnceCreateEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntitlement</summary>
        public void CreateEntitlementResourceNames3()
        {
            // Snippet: CreateEntitlement(OrganizationLocationName, Entitlement, string, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            Entitlement entitlement = new Entitlement();
            string entitlementId = "";
            // Make the request
            Operation<Entitlement, OperationMetadata> response = privilegedAccessManagerClient.CreateEntitlement(parent, entitlement, entitlementId);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = privilegedAccessManagerClient.PollOnceCreateEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateEntitlementAsync</summary>
        public async Task CreateEntitlementResourceNames3Async()
        {
            // Snippet: CreateEntitlementAsync(OrganizationLocationName, Entitlement, string, CallSettings)
            // Additional: CreateEntitlementAsync(OrganizationLocationName, Entitlement, string, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationLocationName parent = OrganizationLocationName.FromOrganizationLocation("[ORGANIZATION]", "[LOCATION]");
            Entitlement entitlement = new Entitlement();
            string entitlementId = "";
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await privilegedAccessManagerClient.CreateEntitlementAsync(parent, entitlement, entitlementId);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await privilegedAccessManagerClient.PollOnceCreateEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntitlement</summary>
        public void DeleteEntitlementRequestObject()
        {
            // Snippet: DeleteEntitlement(DeleteEntitlementRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            DeleteEntitlementRequest request = new DeleteEntitlementRequest
            {
                EntitlementName = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = privilegedAccessManagerClient.DeleteEntitlement(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = privilegedAccessManagerClient.PollOnceDeleteEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntitlementAsync</summary>
        public async Task DeleteEntitlementRequestObjectAsync()
        {
            // Snippet: DeleteEntitlementAsync(DeleteEntitlementRequest, CallSettings)
            // Additional: DeleteEntitlementAsync(DeleteEntitlementRequest, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteEntitlementRequest request = new DeleteEntitlementRequest
            {
                EntitlementName = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]"),
                RequestId = "",
                Force = false,
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await privilegedAccessManagerClient.DeleteEntitlementAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await privilegedAccessManagerClient.PollOnceDeleteEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntitlement</summary>
        public void DeleteEntitlement()
        {
            // Snippet: DeleteEntitlement(string, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entitlements/[ENTITLEMENT]";
            // Make the request
            Operation<Entitlement, OperationMetadata> response = privilegedAccessManagerClient.DeleteEntitlement(name);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = privilegedAccessManagerClient.PollOnceDeleteEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntitlementAsync</summary>
        public async Task DeleteEntitlementAsync()
        {
            // Snippet: DeleteEntitlementAsync(string, CallSettings)
            // Additional: DeleteEntitlementAsync(string, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entitlements/[ENTITLEMENT]";
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await privilegedAccessManagerClient.DeleteEntitlementAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await privilegedAccessManagerClient.PollOnceDeleteEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntitlement</summary>
        public void DeleteEntitlementResourceNames()
        {
            // Snippet: DeleteEntitlement(EntitlementName, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            EntitlementName name = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]");
            // Make the request
            Operation<Entitlement, OperationMetadata> response = privilegedAccessManagerClient.DeleteEntitlement(name);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = privilegedAccessManagerClient.PollOnceDeleteEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteEntitlementAsync</summary>
        public async Task DeleteEntitlementResourceNamesAsync()
        {
            // Snippet: DeleteEntitlementAsync(EntitlementName, CallSettings)
            // Additional: DeleteEntitlementAsync(EntitlementName, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            EntitlementName name = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]");
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await privilegedAccessManagerClient.DeleteEntitlementAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await privilegedAccessManagerClient.PollOnceDeleteEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEntitlement</summary>
        public void UpdateEntitlementRequestObject()
        {
            // Snippet: UpdateEntitlement(UpdateEntitlementRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            UpdateEntitlementRequest request = new UpdateEntitlementRequest
            {
                Entitlement = new Entitlement(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = privilegedAccessManagerClient.UpdateEntitlement(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = privilegedAccessManagerClient.PollOnceUpdateEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEntitlementAsync</summary>
        public async Task UpdateEntitlementRequestObjectAsync()
        {
            // Snippet: UpdateEntitlementAsync(UpdateEntitlementRequest, CallSettings)
            // Additional: UpdateEntitlementAsync(UpdateEntitlementRequest, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            UpdateEntitlementRequest request = new UpdateEntitlementRequest
            {
                Entitlement = new Entitlement(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await privilegedAccessManagerClient.UpdateEntitlementAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await privilegedAccessManagerClient.PollOnceUpdateEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEntitlement</summary>
        public void UpdateEntitlement()
        {
            // Snippet: UpdateEntitlement(Entitlement, FieldMask, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            Entitlement entitlement = new Entitlement();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Entitlement, OperationMetadata> response = privilegedAccessManagerClient.UpdateEntitlement(entitlement, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = privilegedAccessManagerClient.PollOnceUpdateEntitlement(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateEntitlementAsync</summary>
        public async Task UpdateEntitlementAsync()
        {
            // Snippet: UpdateEntitlementAsync(Entitlement, FieldMask, CallSettings)
            // Additional: UpdateEntitlementAsync(Entitlement, FieldMask, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            Entitlement entitlement = new Entitlement();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Entitlement, OperationMetadata> response = await privilegedAccessManagerClient.UpdateEntitlementAsync(entitlement, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Entitlement, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Entitlement result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Entitlement, OperationMetadata> retrievedResponse = await privilegedAccessManagerClient.PollOnceUpdateEntitlementAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Entitlement retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListGrants</summary>
        public void ListGrantsRequestObject()
        {
            // Snippet: ListGrants(ListGrantsRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            ListGrantsRequest request = new ListGrantsRequest
            {
                ParentAsEntitlementName = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListGrantsResponse, Grant> response = privilegedAccessManagerClient.ListGrants(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Grant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGrantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Grant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Grant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Grant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGrantsAsync</summary>
        public async Task ListGrantsRequestObjectAsync()
        {
            // Snippet: ListGrantsAsync(ListGrantsRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            ListGrantsRequest request = new ListGrantsRequest
            {
                ParentAsEntitlementName = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListGrantsResponse, Grant> response = privilegedAccessManagerClient.ListGrantsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Grant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGrantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Grant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Grant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Grant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGrants</summary>
        public void ListGrants()
        {
            // Snippet: ListGrants(string, string, int?, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entitlements/[ENTITLEMENT]";
            // Make the request
            PagedEnumerable<ListGrantsResponse, Grant> response = privilegedAccessManagerClient.ListGrants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Grant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGrantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Grant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Grant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Grant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGrantsAsync</summary>
        public async Task ListGrantsAsync()
        {
            // Snippet: ListGrantsAsync(string, string, int?, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entitlements/[ENTITLEMENT]";
            // Make the request
            PagedAsyncEnumerable<ListGrantsResponse, Grant> response = privilegedAccessManagerClient.ListGrantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Grant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGrantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Grant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Grant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Grant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGrants</summary>
        public void ListGrantsResourceNames()
        {
            // Snippet: ListGrants(EntitlementName, string, int?, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            EntitlementName parent = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]");
            // Make the request
            PagedEnumerable<ListGrantsResponse, Grant> response = privilegedAccessManagerClient.ListGrants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Grant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListGrantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Grant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Grant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Grant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListGrantsAsync</summary>
        public async Task ListGrantsResourceNamesAsync()
        {
            // Snippet: ListGrantsAsync(EntitlementName, string, int?, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            EntitlementName parent = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]");
            // Make the request
            PagedAsyncEnumerable<ListGrantsResponse, Grant> response = privilegedAccessManagerClient.ListGrantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Grant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListGrantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Grant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Grant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Grant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchGrants</summary>
        public void SearchGrantsRequestObject()
        {
            // Snippet: SearchGrants(SearchGrantsRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            SearchGrantsRequest request = new SearchGrantsRequest
            {
                ParentAsEntitlementName = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]"),
                CallerRelationship = SearchGrantsRequest.Types.CallerRelationshipType.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedEnumerable<SearchGrantsResponse, Grant> response = privilegedAccessManagerClient.SearchGrants(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Grant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchGrantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Grant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Grant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Grant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchGrantsAsync</summary>
        public async Task SearchGrantsRequestObjectAsync()
        {
            // Snippet: SearchGrantsAsync(SearchGrantsRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            SearchGrantsRequest request = new SearchGrantsRequest
            {
                ParentAsEntitlementName = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]"),
                CallerRelationship = SearchGrantsRequest.Types.CallerRelationshipType.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchGrantsResponse, Grant> response = privilegedAccessManagerClient.SearchGrantsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Grant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((SearchGrantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Grant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Grant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Grant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetGrant</summary>
        public void GetGrantRequestObject()
        {
            // Snippet: GetGrant(GetGrantRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            GetGrantRequest request = new GetGrantRequest
            {
                GrantName = GrantName.FromProjectLocationEntitlementGrant("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]", "[GRANT]"),
            };
            // Make the request
            Grant response = privilegedAccessManagerClient.GetGrant(request);
            // End snippet
        }

        /// <summary>Snippet for GetGrantAsync</summary>
        public async Task GetGrantRequestObjectAsync()
        {
            // Snippet: GetGrantAsync(GetGrantRequest, CallSettings)
            // Additional: GetGrantAsync(GetGrantRequest, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            GetGrantRequest request = new GetGrantRequest
            {
                GrantName = GrantName.FromProjectLocationEntitlementGrant("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]", "[GRANT]"),
            };
            // Make the request
            Grant response = await privilegedAccessManagerClient.GetGrantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetGrant</summary>
        public void GetGrant()
        {
            // Snippet: GetGrant(string, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entitlements/[ENTITLEMENT]/grants/[GRANT]";
            // Make the request
            Grant response = privilegedAccessManagerClient.GetGrant(name);
            // End snippet
        }

        /// <summary>Snippet for GetGrantAsync</summary>
        public async Task GetGrantAsync()
        {
            // Snippet: GetGrantAsync(string, CallSettings)
            // Additional: GetGrantAsync(string, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/entitlements/[ENTITLEMENT]/grants/[GRANT]";
            // Make the request
            Grant response = await privilegedAccessManagerClient.GetGrantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetGrant</summary>
        public void GetGrantResourceNames()
        {
            // Snippet: GetGrant(GrantName, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            GrantName name = GrantName.FromProjectLocationEntitlementGrant("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]", "[GRANT]");
            // Make the request
            Grant response = privilegedAccessManagerClient.GetGrant(name);
            // End snippet
        }

        /// <summary>Snippet for GetGrantAsync</summary>
        public async Task GetGrantResourceNamesAsync()
        {
            // Snippet: GetGrantAsync(GrantName, CallSettings)
            // Additional: GetGrantAsync(GrantName, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            GrantName name = GrantName.FromProjectLocationEntitlementGrant("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]", "[GRANT]");
            // Make the request
            Grant response = await privilegedAccessManagerClient.GetGrantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateGrant</summary>
        public void CreateGrantRequestObject()
        {
            // Snippet: CreateGrant(CreateGrantRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            CreateGrantRequest request = new CreateGrantRequest
            {
                ParentAsEntitlementName = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]"),
                Grant = new Grant(),
                RequestId = "",
            };
            // Make the request
            Grant response = privilegedAccessManagerClient.CreateGrant(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGrantAsync</summary>
        public async Task CreateGrantRequestObjectAsync()
        {
            // Snippet: CreateGrantAsync(CreateGrantRequest, CallSettings)
            // Additional: CreateGrantAsync(CreateGrantRequest, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            CreateGrantRequest request = new CreateGrantRequest
            {
                ParentAsEntitlementName = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]"),
                Grant = new Grant(),
                RequestId = "",
            };
            // Make the request
            Grant response = await privilegedAccessManagerClient.CreateGrantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateGrant</summary>
        public void CreateGrant()
        {
            // Snippet: CreateGrant(string, Grant, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entitlements/[ENTITLEMENT]";
            Grant grant = new Grant();
            // Make the request
            Grant response = privilegedAccessManagerClient.CreateGrant(parent, grant);
            // End snippet
        }

        /// <summary>Snippet for CreateGrantAsync</summary>
        public async Task CreateGrantAsync()
        {
            // Snippet: CreateGrantAsync(string, Grant, CallSettings)
            // Additional: CreateGrantAsync(string, Grant, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/entitlements/[ENTITLEMENT]";
            Grant grant = new Grant();
            // Make the request
            Grant response = await privilegedAccessManagerClient.CreateGrantAsync(parent, grant);
            // End snippet
        }

        /// <summary>Snippet for CreateGrant</summary>
        public void CreateGrantResourceNames()
        {
            // Snippet: CreateGrant(EntitlementName, Grant, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            EntitlementName parent = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]");
            Grant grant = new Grant();
            // Make the request
            Grant response = privilegedAccessManagerClient.CreateGrant(parent, grant);
            // End snippet
        }

        /// <summary>Snippet for CreateGrantAsync</summary>
        public async Task CreateGrantResourceNamesAsync()
        {
            // Snippet: CreateGrantAsync(EntitlementName, Grant, CallSettings)
            // Additional: CreateGrantAsync(EntitlementName, Grant, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            EntitlementName parent = EntitlementName.FromProjectLocationEntitlement("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]");
            Grant grant = new Grant();
            // Make the request
            Grant response = await privilegedAccessManagerClient.CreateGrantAsync(parent, grant);
            // End snippet
        }

        /// <summary>Snippet for ApproveGrant</summary>
        public void ApproveGrantRequestObject()
        {
            // Snippet: ApproveGrant(ApproveGrantRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            ApproveGrantRequest request = new ApproveGrantRequest
            {
                GrantName = GrantName.FromProjectLocationEntitlementGrant("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]", "[GRANT]"),
                Reason = "",
            };
            // Make the request
            Grant response = privilegedAccessManagerClient.ApproveGrant(request);
            // End snippet
        }

        /// <summary>Snippet for ApproveGrantAsync</summary>
        public async Task ApproveGrantRequestObjectAsync()
        {
            // Snippet: ApproveGrantAsync(ApproveGrantRequest, CallSettings)
            // Additional: ApproveGrantAsync(ApproveGrantRequest, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            ApproveGrantRequest request = new ApproveGrantRequest
            {
                GrantName = GrantName.FromProjectLocationEntitlementGrant("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]", "[GRANT]"),
                Reason = "",
            };
            // Make the request
            Grant response = await privilegedAccessManagerClient.ApproveGrantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DenyGrant</summary>
        public void DenyGrantRequestObject()
        {
            // Snippet: DenyGrant(DenyGrantRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            DenyGrantRequest request = new DenyGrantRequest
            {
                GrantName = GrantName.FromProjectLocationEntitlementGrant("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]", "[GRANT]"),
                Reason = "",
            };
            // Make the request
            Grant response = privilegedAccessManagerClient.DenyGrant(request);
            // End snippet
        }

        /// <summary>Snippet for DenyGrantAsync</summary>
        public async Task DenyGrantRequestObjectAsync()
        {
            // Snippet: DenyGrantAsync(DenyGrantRequest, CallSettings)
            // Additional: DenyGrantAsync(DenyGrantRequest, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            DenyGrantRequest request = new DenyGrantRequest
            {
                GrantName = GrantName.FromProjectLocationEntitlementGrant("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]", "[GRANT]"),
                Reason = "",
            };
            // Make the request
            Grant response = await privilegedAccessManagerClient.DenyGrantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RevokeGrant</summary>
        public void RevokeGrantRequestObject()
        {
            // Snippet: RevokeGrant(RevokeGrantRequest, CallSettings)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = PrivilegedAccessManagerClient.Create();
            // Initialize request argument(s)
            RevokeGrantRequest request = new RevokeGrantRequest
            {
                GrantName = GrantName.FromProjectLocationEntitlementGrant("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]", "[GRANT]"),
                Reason = "",
            };
            // Make the request
            Operation<Grant, OperationMetadata> response = privilegedAccessManagerClient.RevokeGrant(request);

            // Poll until the returned long-running operation is complete
            Operation<Grant, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Grant result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Grant, OperationMetadata> retrievedResponse = privilegedAccessManagerClient.PollOnceRevokeGrant(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Grant retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RevokeGrantAsync</summary>
        public async Task RevokeGrantRequestObjectAsync()
        {
            // Snippet: RevokeGrantAsync(RevokeGrantRequest, CallSettings)
            // Additional: RevokeGrantAsync(RevokeGrantRequest, CancellationToken)
            // Create client
            PrivilegedAccessManagerClient privilegedAccessManagerClient = await PrivilegedAccessManagerClient.CreateAsync();
            // Initialize request argument(s)
            RevokeGrantRequest request = new RevokeGrantRequest
            {
                GrantName = GrantName.FromProjectLocationEntitlementGrant("[PROJECT]", "[LOCATION]", "[ENTITLEMENT]", "[GRANT]"),
                Reason = "",
            };
            // Make the request
            Operation<Grant, OperationMetadata> response = await privilegedAccessManagerClient.RevokeGrantAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Grant, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Grant result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Grant, OperationMetadata> retrievedResponse = await privilegedAccessManagerClient.PollOnceRevokeGrantAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Grant retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
