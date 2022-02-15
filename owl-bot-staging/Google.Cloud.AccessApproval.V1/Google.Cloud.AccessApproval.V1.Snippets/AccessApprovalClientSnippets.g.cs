// Copyright 2022 Google LLC
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

namespace Google.Cloud.AccessApproval.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAccessApprovalClientSnippets
    {
        /// <summary>Snippet for ListApprovalRequests</summary>
        public void ListApprovalRequestsRequestObject()
        {
            // Snippet: ListApprovalRequests(ListApprovalRequestsMessage, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            ListApprovalRequestsMessage request = new ListApprovalRequestsMessage
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalClient.ListApprovalRequests(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApprovalRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApprovalRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApprovalRequestsAsync</summary>
        public async Task ListApprovalRequestsRequestObjectAsync()
        {
            // Snippet: ListApprovalRequestsAsync(ListApprovalRequestsMessage, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            ListApprovalRequestsMessage request = new ListApprovalRequestsMessage
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalClient.ListApprovalRequestsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApprovalRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApprovalRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApprovalRequests</summary>
        public void ListApprovalRequests()
        {
            // Snippet: ListApprovalRequests(string, string, int?, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalClient.ListApprovalRequests(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApprovalRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApprovalRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApprovalRequestsAsync</summary>
        public async Task ListApprovalRequestsAsync()
        {
            // Snippet: ListApprovalRequestsAsync(string, string, int?, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalClient.ListApprovalRequestsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApprovalRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApprovalRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApprovalRequests</summary>
        public void ListApprovalRequestsResourceNames1()
        {
            // Snippet: ListApprovalRequests(ProjectName, string, int?, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalClient.ListApprovalRequests(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApprovalRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApprovalRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApprovalRequestsAsync</summary>
        public async Task ListApprovalRequestsResourceNames1Async()
        {
            // Snippet: ListApprovalRequestsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalClient.ListApprovalRequestsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApprovalRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApprovalRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApprovalRequests</summary>
        public void ListApprovalRequestsResourceNames2()
        {
            // Snippet: ListApprovalRequests(FolderName, string, int?, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalClient.ListApprovalRequests(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApprovalRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApprovalRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApprovalRequestsAsync</summary>
        public async Task ListApprovalRequestsResourceNames2Async()
        {
            // Snippet: ListApprovalRequestsAsync(FolderName, string, int?, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalClient.ListApprovalRequestsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApprovalRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApprovalRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApprovalRequests</summary>
        public void ListApprovalRequestsResourceNames3()
        {
            // Snippet: ListApprovalRequests(OrganizationName, string, int?, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalClient.ListApprovalRequests(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApprovalRequest item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListApprovalRequestsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListApprovalRequestsAsync</summary>
        public async Task ListApprovalRequestsResourceNames3Async()
        {
            // Snippet: ListApprovalRequestsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListApprovalRequestsResponse, ApprovalRequest> response = accessApprovalClient.ListApprovalRequestsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ApprovalRequest item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListApprovalRequestsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApprovalRequest item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApprovalRequest> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApprovalRequest item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetApprovalRequest</summary>
        public void GetApprovalRequestRequestObject()
        {
            // Snippet: GetApprovalRequest(GetApprovalRequestMessage, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            GetApprovalRequestMessage request = new GetApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
            };
            // Make the request
            ApprovalRequest response = accessApprovalClient.GetApprovalRequest(request);
            // End snippet
        }

        /// <summary>Snippet for GetApprovalRequestAsync</summary>
        public async Task GetApprovalRequestRequestObjectAsync()
        {
            // Snippet: GetApprovalRequestAsync(GetApprovalRequestMessage, CallSettings)
            // Additional: GetApprovalRequestAsync(GetApprovalRequestMessage, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            GetApprovalRequestMessage request = new GetApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
            };
            // Make the request
            ApprovalRequest response = await accessApprovalClient.GetApprovalRequestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetApprovalRequest</summary>
        public void GetApprovalRequest()
        {
            // Snippet: GetApprovalRequest(string, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/approvalRequests/[APPROVAL_REQUEST]";
            // Make the request
            ApprovalRequest response = accessApprovalClient.GetApprovalRequest(name);
            // End snippet
        }

        /// <summary>Snippet for GetApprovalRequestAsync</summary>
        public async Task GetApprovalRequestAsync()
        {
            // Snippet: GetApprovalRequestAsync(string, CallSettings)
            // Additional: GetApprovalRequestAsync(string, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/approvalRequests/[APPROVAL_REQUEST]";
            // Make the request
            ApprovalRequest response = await accessApprovalClient.GetApprovalRequestAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetApprovalRequest</summary>
        public void GetApprovalRequestResourceNames()
        {
            // Snippet: GetApprovalRequest(ApprovalRequestName, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            ApprovalRequestName name = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]");
            // Make the request
            ApprovalRequest response = accessApprovalClient.GetApprovalRequest(name);
            // End snippet
        }

        /// <summary>Snippet for GetApprovalRequestAsync</summary>
        public async Task GetApprovalRequestResourceNamesAsync()
        {
            // Snippet: GetApprovalRequestAsync(ApprovalRequestName, CallSettings)
            // Additional: GetApprovalRequestAsync(ApprovalRequestName, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            ApprovalRequestName name = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]");
            // Make the request
            ApprovalRequest response = await accessApprovalClient.GetApprovalRequestAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ApproveApprovalRequest</summary>
        public void ApproveApprovalRequestRequestObject()
        {
            // Snippet: ApproveApprovalRequest(ApproveApprovalRequestMessage, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            ApproveApprovalRequestMessage request = new ApproveApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                ExpireTime = new Timestamp(),
            };
            // Make the request
            ApprovalRequest response = accessApprovalClient.ApproveApprovalRequest(request);
            // End snippet
        }

        /// <summary>Snippet for ApproveApprovalRequestAsync</summary>
        public async Task ApproveApprovalRequestRequestObjectAsync()
        {
            // Snippet: ApproveApprovalRequestAsync(ApproveApprovalRequestMessage, CallSettings)
            // Additional: ApproveApprovalRequestAsync(ApproveApprovalRequestMessage, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            ApproveApprovalRequestMessage request = new ApproveApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
                ExpireTime = new Timestamp(),
            };
            // Make the request
            ApprovalRequest response = await accessApprovalClient.ApproveApprovalRequestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DismissApprovalRequest</summary>
        public void DismissApprovalRequestRequestObject()
        {
            // Snippet: DismissApprovalRequest(DismissApprovalRequestMessage, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            DismissApprovalRequestMessage request = new DismissApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
            };
            // Make the request
            ApprovalRequest response = accessApprovalClient.DismissApprovalRequest(request);
            // End snippet
        }

        /// <summary>Snippet for DismissApprovalRequestAsync</summary>
        public async Task DismissApprovalRequestRequestObjectAsync()
        {
            // Snippet: DismissApprovalRequestAsync(DismissApprovalRequestMessage, CallSettings)
            // Additional: DismissApprovalRequestAsync(DismissApprovalRequestMessage, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            DismissApprovalRequestMessage request = new DismissApprovalRequestMessage
            {
                ApprovalRequestName = ApprovalRequestName.FromProjectApprovalRequest("[PROJECT]", "[APPROVAL_REQUEST]"),
            };
            // Make the request
            ApprovalRequest response = await accessApprovalClient.DismissApprovalRequestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessApprovalSettings</summary>
        public void GetAccessApprovalSettingsRequestObject()
        {
            // Snippet: GetAccessApprovalSettings(GetAccessApprovalSettingsMessage, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            GetAccessApprovalSettingsMessage request = new GetAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            // Make the request
            AccessApprovalSettings response = accessApprovalClient.GetAccessApprovalSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessApprovalSettingsAsync</summary>
        public async Task GetAccessApprovalSettingsRequestObjectAsync()
        {
            // Snippet: GetAccessApprovalSettingsAsync(GetAccessApprovalSettingsMessage, CallSettings)
            // Additional: GetAccessApprovalSettingsAsync(GetAccessApprovalSettingsMessage, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            GetAccessApprovalSettingsMessage request = new GetAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            // Make the request
            AccessApprovalSettings response = await accessApprovalClient.GetAccessApprovalSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAccessApprovalSettings</summary>
        public void GetAccessApprovalSettings()
        {
            // Snippet: GetAccessApprovalSettings(string, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/accessApprovalSettings";
            // Make the request
            AccessApprovalSettings response = accessApprovalClient.GetAccessApprovalSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessApprovalSettingsAsync</summary>
        public async Task GetAccessApprovalSettingsAsync()
        {
            // Snippet: GetAccessApprovalSettingsAsync(string, CallSettings)
            // Additional: GetAccessApprovalSettingsAsync(string, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/accessApprovalSettings";
            // Make the request
            AccessApprovalSettings response = await accessApprovalClient.GetAccessApprovalSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessApprovalSettings</summary>
        public void GetAccessApprovalSettingsResourceNames()
        {
            // Snippet: GetAccessApprovalSettings(AccessApprovalSettingsName, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            AccessApprovalSettingsName name = AccessApprovalSettingsName.FromProject("[PROJECT]");
            // Make the request
            AccessApprovalSettings response = accessApprovalClient.GetAccessApprovalSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetAccessApprovalSettingsAsync</summary>
        public async Task GetAccessApprovalSettingsResourceNamesAsync()
        {
            // Snippet: GetAccessApprovalSettingsAsync(AccessApprovalSettingsName, CallSettings)
            // Additional: GetAccessApprovalSettingsAsync(AccessApprovalSettingsName, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            AccessApprovalSettingsName name = AccessApprovalSettingsName.FromProject("[PROJECT]");
            // Make the request
            AccessApprovalSettings response = await accessApprovalClient.GetAccessApprovalSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessApprovalSettings</summary>
        public void UpdateAccessApprovalSettingsRequestObject()
        {
            // Snippet: UpdateAccessApprovalSettings(UpdateAccessApprovalSettingsMessage, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            UpdateAccessApprovalSettingsMessage request = new UpdateAccessApprovalSettingsMessage
            {
                Settings = new AccessApprovalSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AccessApprovalSettings response = accessApprovalClient.UpdateAccessApprovalSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessApprovalSettingsAsync</summary>
        public async Task UpdateAccessApprovalSettingsRequestObjectAsync()
        {
            // Snippet: UpdateAccessApprovalSettingsAsync(UpdateAccessApprovalSettingsMessage, CallSettings)
            // Additional: UpdateAccessApprovalSettingsAsync(UpdateAccessApprovalSettingsMessage, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAccessApprovalSettingsMessage request = new UpdateAccessApprovalSettingsMessage
            {
                Settings = new AccessApprovalSettings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            AccessApprovalSettings response = await accessApprovalClient.UpdateAccessApprovalSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessApprovalSettings</summary>
        public void UpdateAccessApprovalSettings()
        {
            // Snippet: UpdateAccessApprovalSettings(AccessApprovalSettings, FieldMask, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            AccessApprovalSettings settings = new AccessApprovalSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AccessApprovalSettings response = accessApprovalClient.UpdateAccessApprovalSettings(settings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateAccessApprovalSettingsAsync</summary>
        public async Task UpdateAccessApprovalSettingsAsync()
        {
            // Snippet: UpdateAccessApprovalSettingsAsync(AccessApprovalSettings, FieldMask, CallSettings)
            // Additional: UpdateAccessApprovalSettingsAsync(AccessApprovalSettings, FieldMask, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            AccessApprovalSettings settings = new AccessApprovalSettings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            AccessApprovalSettings response = await accessApprovalClient.UpdateAccessApprovalSettingsAsync(settings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessApprovalSettings</summary>
        public void DeleteAccessApprovalSettingsRequestObject()
        {
            // Snippet: DeleteAccessApprovalSettings(DeleteAccessApprovalSettingsMessage, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            DeleteAccessApprovalSettingsMessage request = new DeleteAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            // Make the request
            accessApprovalClient.DeleteAccessApprovalSettings(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessApprovalSettingsAsync</summary>
        public async Task DeleteAccessApprovalSettingsRequestObjectAsync()
        {
            // Snippet: DeleteAccessApprovalSettingsAsync(DeleteAccessApprovalSettingsMessage, CallSettings)
            // Additional: DeleteAccessApprovalSettingsAsync(DeleteAccessApprovalSettingsMessage, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAccessApprovalSettingsMessage request = new DeleteAccessApprovalSettingsMessage
            {
                AccessApprovalSettingsName = AccessApprovalSettingsName.FromProject("[PROJECT]"),
            };
            // Make the request
            await accessApprovalClient.DeleteAccessApprovalSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessApprovalSettings</summary>
        public void DeleteAccessApprovalSettings()
        {
            // Snippet: DeleteAccessApprovalSettings(string, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/accessApprovalSettings";
            // Make the request
            accessApprovalClient.DeleteAccessApprovalSettings(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessApprovalSettingsAsync</summary>
        public async Task DeleteAccessApprovalSettingsAsync()
        {
            // Snippet: DeleteAccessApprovalSettingsAsync(string, CallSettings)
            // Additional: DeleteAccessApprovalSettingsAsync(string, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/accessApprovalSettings";
            // Make the request
            await accessApprovalClient.DeleteAccessApprovalSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessApprovalSettings</summary>
        public void DeleteAccessApprovalSettingsResourceNames()
        {
            // Snippet: DeleteAccessApprovalSettings(AccessApprovalSettingsName, CallSettings)
            // Create client
            AccessApprovalClient accessApprovalClient = AccessApprovalClient.Create();
            // Initialize request argument(s)
            AccessApprovalSettingsName name = AccessApprovalSettingsName.FromProject("[PROJECT]");
            // Make the request
            accessApprovalClient.DeleteAccessApprovalSettings(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAccessApprovalSettingsAsync</summary>
        public async Task DeleteAccessApprovalSettingsResourceNamesAsync()
        {
            // Snippet: DeleteAccessApprovalSettingsAsync(AccessApprovalSettingsName, CallSettings)
            // Additional: DeleteAccessApprovalSettingsAsync(AccessApprovalSettingsName, CancellationToken)
            // Create client
            AccessApprovalClient accessApprovalClient = await AccessApprovalClient.CreateAsync();
            // Initialize request argument(s)
            AccessApprovalSettingsName name = AccessApprovalSettingsName.FromProject("[PROJECT]");
            // Make the request
            await accessApprovalClient.DeleteAccessApprovalSettingsAsync(name);
            // End snippet
        }
    }
}
