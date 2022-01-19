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

namespace Google.Cloud.OrgPolicy.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.ResourceNames;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedOrgPolicyClientSnippets
    {
        /// <summary>Snippet for ListConstraints</summary>
        public void ListConstraintsRequestObject()
        {
            // Snippet: ListConstraints(ListConstraintsRequest, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            ListConstraintsRequest request = new ListConstraintsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListConstraintsResponse, Constraint> response = orgPolicyClient.ListConstraints(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Constraint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConstraintsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Constraint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Constraint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Constraint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConstraintsAsync</summary>
        public async Task ListConstraintsRequestObjectAsync()
        {
            // Snippet: ListConstraintsAsync(ListConstraintsRequest, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            ListConstraintsRequest request = new ListConstraintsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListConstraintsResponse, Constraint> response = orgPolicyClient.ListConstraintsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Constraint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConstraintsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Constraint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Constraint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Constraint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConstraints</summary>
        public void ListConstraints()
        {
            // Snippet: ListConstraints(string, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListConstraintsResponse, Constraint> response = orgPolicyClient.ListConstraints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Constraint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConstraintsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Constraint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Constraint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Constraint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConstraintsAsync</summary>
        public async Task ListConstraintsAsync()
        {
            // Snippet: ListConstraintsAsync(string, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListConstraintsResponse, Constraint> response = orgPolicyClient.ListConstraintsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Constraint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConstraintsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Constraint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Constraint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Constraint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConstraints</summary>
        public void ListConstraintsResourceNames1()
        {
            // Snippet: ListConstraints(ProjectName, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListConstraintsResponse, Constraint> response = orgPolicyClient.ListConstraints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Constraint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConstraintsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Constraint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Constraint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Constraint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConstraintsAsync</summary>
        public async Task ListConstraintsResourceNames1Async()
        {
            // Snippet: ListConstraintsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListConstraintsResponse, Constraint> response = orgPolicyClient.ListConstraintsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Constraint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConstraintsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Constraint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Constraint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Constraint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConstraints</summary>
        public void ListConstraintsResourceNames2()
        {
            // Snippet: ListConstraints(FolderName, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListConstraintsResponse, Constraint> response = orgPolicyClient.ListConstraints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Constraint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConstraintsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Constraint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Constraint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Constraint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConstraintsAsync</summary>
        public async Task ListConstraintsResourceNames2Async()
        {
            // Snippet: ListConstraintsAsync(FolderName, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListConstraintsResponse, Constraint> response = orgPolicyClient.ListConstraintsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Constraint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConstraintsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Constraint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Constraint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Constraint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConstraints</summary>
        public void ListConstraintsResourceNames3()
        {
            // Snippet: ListConstraints(OrganizationName, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListConstraintsResponse, Constraint> response = orgPolicyClient.ListConstraints(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Constraint item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConstraintsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Constraint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Constraint> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Constraint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConstraintsAsync</summary>
        public async Task ListConstraintsResourceNames3Async()
        {
            // Snippet: ListConstraintsAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListConstraintsResponse, Constraint> response = orgPolicyClient.ListConstraintsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Constraint item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConstraintsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Constraint item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Constraint> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Constraint item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicies</summary>
        public void ListPoliciesRequestObject()
        {
            // Snippet: ListPolicies(ListPoliciesRequest, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            ListPoliciesRequest request = new ListPoliciesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListPoliciesResponse, Policy> response = orgPolicyClient.ListPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPoliciesAsync</summary>
        public async Task ListPoliciesRequestObjectAsync()
        {
            // Snippet: ListPoliciesAsync(ListPoliciesRequest, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            ListPoliciesRequest request = new ListPoliciesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListPoliciesResponse, Policy> response = orgPolicyClient.ListPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Policy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicies</summary>
        public void ListPolicies()
        {
            // Snippet: ListPolicies(string, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListPoliciesResponse, Policy> response = orgPolicyClient.ListPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPoliciesAsync</summary>
        public async Task ListPoliciesAsync()
        {
            // Snippet: ListPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListPoliciesResponse, Policy> response = orgPolicyClient.ListPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Policy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicies</summary>
        public void ListPoliciesResourceNames1()
        {
            // Snippet: ListPolicies(ProjectName, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListPoliciesResponse, Policy> response = orgPolicyClient.ListPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPoliciesAsync</summary>
        public async Task ListPoliciesResourceNames1Async()
        {
            // Snippet: ListPoliciesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListPoliciesResponse, Policy> response = orgPolicyClient.ListPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Policy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicies</summary>
        public void ListPoliciesResourceNames2()
        {
            // Snippet: ListPolicies(FolderName, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListPoliciesResponse, Policy> response = orgPolicyClient.ListPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPoliciesAsync</summary>
        public async Task ListPoliciesResourceNames2Async()
        {
            // Snippet: ListPoliciesAsync(FolderName, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListPoliciesResponse, Policy> response = orgPolicyClient.ListPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Policy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPolicies</summary>
        public void ListPoliciesResourceNames3()
        {
            // Snippet: ListPolicies(OrganizationName, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListPoliciesResponse, Policy> response = orgPolicyClient.ListPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Policy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPoliciesAsync</summary>
        public async Task ListPoliciesResourceNames3Async()
        {
            // Snippet: ListPoliciesAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListPoliciesResponse, Policy> response = orgPolicyClient.ListPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Policy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Policy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Policy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Policy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPolicy</summary>
        public void GetPolicyRequestObject()
        {
            // Snippet: GetPolicy(GetPolicyRequest, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            // Make the request
            Policy response = orgPolicyClient.GetPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyAsync</summary>
        public async Task GetPolicyRequestObjectAsync()
        {
            // Snippet: GetPolicyAsync(GetPolicyRequest, CallSettings)
            // Additional: GetPolicyAsync(GetPolicyRequest, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            GetPolicyRequest request = new GetPolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            // Make the request
            Policy response = await orgPolicyClient.GetPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPolicy</summary>
        public void GetPolicy()
        {
            // Snippet: GetPolicy(string, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/policies/[POLICY]";
            // Make the request
            Policy response = orgPolicyClient.GetPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyAsync</summary>
        public async Task GetPolicyAsync()
        {
            // Snippet: GetPolicyAsync(string, CallSettings)
            // Additional: GetPolicyAsync(string, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/policies/[POLICY]";
            // Make the request
            Policy response = await orgPolicyClient.GetPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicy</summary>
        public void GetPolicyResourceNames()
        {
            // Snippet: GetPolicy(PolicyName, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]");
            // Make the request
            Policy response = orgPolicyClient.GetPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetPolicyAsync</summary>
        public async Task GetPolicyResourceNamesAsync()
        {
            // Snippet: GetPolicyAsync(PolicyName, CallSettings)
            // Additional: GetPolicyAsync(PolicyName, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]");
            // Make the request
            Policy response = await orgPolicyClient.GetPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEffectivePolicy</summary>
        public void GetEffectivePolicyRequestObject()
        {
            // Snippet: GetEffectivePolicy(GetEffectivePolicyRequest, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            GetEffectivePolicyRequest request = new GetEffectivePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            // Make the request
            Policy response = orgPolicyClient.GetEffectivePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetEffectivePolicyAsync</summary>
        public async Task GetEffectivePolicyRequestObjectAsync()
        {
            // Snippet: GetEffectivePolicyAsync(GetEffectivePolicyRequest, CallSettings)
            // Additional: GetEffectivePolicyAsync(GetEffectivePolicyRequest, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            GetEffectivePolicyRequest request = new GetEffectivePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            // Make the request
            Policy response = await orgPolicyClient.GetEffectivePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetEffectivePolicy</summary>
        public void GetEffectivePolicy()
        {
            // Snippet: GetEffectivePolicy(string, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/policies/[POLICY]";
            // Make the request
            Policy response = orgPolicyClient.GetEffectivePolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetEffectivePolicyAsync</summary>
        public async Task GetEffectivePolicyAsync()
        {
            // Snippet: GetEffectivePolicyAsync(string, CallSettings)
            // Additional: GetEffectivePolicyAsync(string, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/policies/[POLICY]";
            // Make the request
            Policy response = await orgPolicyClient.GetEffectivePolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetEffectivePolicy</summary>
        public void GetEffectivePolicyResourceNames()
        {
            // Snippet: GetEffectivePolicy(PolicyName, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]");
            // Make the request
            Policy response = orgPolicyClient.GetEffectivePolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetEffectivePolicyAsync</summary>
        public async Task GetEffectivePolicyResourceNamesAsync()
        {
            // Snippet: GetEffectivePolicyAsync(PolicyName, CallSettings)
            // Additional: GetEffectivePolicyAsync(PolicyName, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]");
            // Make the request
            Policy response = await orgPolicyClient.GetEffectivePolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicy</summary>
        public void CreatePolicyRequestObject()
        {
            // Snippet: CreatePolicy(CreatePolicyRequest, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = orgPolicyClient.CreatePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyAsync</summary>
        public async Task CreatePolicyRequestObjectAsync()
        {
            // Snippet: CreatePolicyAsync(CreatePolicyRequest, CallSettings)
            // Additional: CreatePolicyAsync(CreatePolicyRequest, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            CreatePolicyRequest request = new CreatePolicyRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await orgPolicyClient.CreatePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicy</summary>
        public void CreatePolicy()
        {
            // Snippet: CreatePolicy(string, Policy, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Policy policy = new Policy();
            // Make the request
            Policy response = orgPolicyClient.CreatePolicy(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyAsync</summary>
        public async Task CreatePolicyAsync()
        {
            // Snippet: CreatePolicyAsync(string, Policy, CallSettings)
            // Additional: CreatePolicyAsync(string, Policy, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Policy policy = new Policy();
            // Make the request
            Policy response = await orgPolicyClient.CreatePolicyAsync(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicy</summary>
        public void CreatePolicyResourceNames1()
        {
            // Snippet: CreatePolicy(ProjectName, Policy, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Policy policy = new Policy();
            // Make the request
            Policy response = orgPolicyClient.CreatePolicy(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyAsync</summary>
        public async Task CreatePolicyResourceNames1Async()
        {
            // Snippet: CreatePolicyAsync(ProjectName, Policy, CallSettings)
            // Additional: CreatePolicyAsync(ProjectName, Policy, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Policy policy = new Policy();
            // Make the request
            Policy response = await orgPolicyClient.CreatePolicyAsync(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicy</summary>
        public void CreatePolicyResourceNames2()
        {
            // Snippet: CreatePolicy(FolderName, Policy, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            Policy policy = new Policy();
            // Make the request
            Policy response = orgPolicyClient.CreatePolicy(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyAsync</summary>
        public async Task CreatePolicyResourceNames2Async()
        {
            // Snippet: CreatePolicyAsync(FolderName, Policy, CallSettings)
            // Additional: CreatePolicyAsync(FolderName, Policy, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            FolderName parent = FolderName.FromFolder("[FOLDER]");
            Policy policy = new Policy();
            // Make the request
            Policy response = await orgPolicyClient.CreatePolicyAsync(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicy</summary>
        public void CreatePolicyResourceNames3()
        {
            // Snippet: CreatePolicy(OrganizationName, Policy, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            Policy policy = new Policy();
            // Make the request
            Policy response = orgPolicyClient.CreatePolicy(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for CreatePolicyAsync</summary>
        public async Task CreatePolicyResourceNames3Async()
        {
            // Snippet: CreatePolicyAsync(OrganizationName, Policy, CallSettings)
            // Additional: CreatePolicyAsync(OrganizationName, Policy, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName parent = OrganizationName.FromOrganization("[ORGANIZATION]");
            Policy policy = new Policy();
            // Make the request
            Policy response = await orgPolicyClient.CreatePolicyAsync(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicy</summary>
        public void UpdatePolicyRequestObject()
        {
            // Snippet: UpdatePolicy(UpdatePolicyRequest, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
            };
            // Make the request
            Policy response = orgPolicyClient.UpdatePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyAsync</summary>
        public async Task UpdatePolicyRequestObjectAsync()
        {
            // Snippet: UpdatePolicyAsync(UpdatePolicyRequest, CallSettings)
            // Additional: UpdatePolicyAsync(UpdatePolicyRequest, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePolicyRequest request = new UpdatePolicyRequest
            {
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await orgPolicyClient.UpdatePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicy</summary>
        public void UpdatePolicy()
        {
            // Snippet: UpdatePolicy(Policy, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            Policy policy = new Policy();
            // Make the request
            Policy response = orgPolicyClient.UpdatePolicy(policy);
            // End snippet
        }

        /// <summary>Snippet for UpdatePolicyAsync</summary>
        public async Task UpdatePolicyAsync()
        {
            // Snippet: UpdatePolicyAsync(Policy, CallSettings)
            // Additional: UpdatePolicyAsync(Policy, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            Policy policy = new Policy();
            // Make the request
            Policy response = await orgPolicyClient.UpdatePolicyAsync(policy);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicy</summary>
        public void DeletePolicyRequestObject()
        {
            // Snippet: DeletePolicy(DeletePolicyRequest, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            DeletePolicyRequest request = new DeletePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            // Make the request
            orgPolicyClient.DeletePolicy(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyAsync</summary>
        public async Task DeletePolicyRequestObjectAsync()
        {
            // Snippet: DeletePolicyAsync(DeletePolicyRequest, CallSettings)
            // Additional: DeletePolicyAsync(DeletePolicyRequest, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            DeletePolicyRequest request = new DeletePolicyRequest
            {
                PolicyName = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]"),
            };
            // Make the request
            await orgPolicyClient.DeletePolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicy</summary>
        public void DeletePolicy()
        {
            // Snippet: DeletePolicy(string, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/policies/[POLICY]";
            // Make the request
            orgPolicyClient.DeletePolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyAsync</summary>
        public async Task DeletePolicyAsync()
        {
            // Snippet: DeletePolicyAsync(string, CallSettings)
            // Additional: DeletePolicyAsync(string, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/policies/[POLICY]";
            // Make the request
            await orgPolicyClient.DeletePolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicy</summary>
        public void DeletePolicyResourceNames()
        {
            // Snippet: DeletePolicy(PolicyName, CallSettings)
            // Create client
            OrgPolicyClient orgPolicyClient = OrgPolicyClient.Create();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]");
            // Make the request
            orgPolicyClient.DeletePolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePolicyAsync</summary>
        public async Task DeletePolicyResourceNamesAsync()
        {
            // Snippet: DeletePolicyAsync(PolicyName, CallSettings)
            // Additional: DeletePolicyAsync(PolicyName, CancellationToken)
            // Create client
            OrgPolicyClient orgPolicyClient = await OrgPolicyClient.CreateAsync();
            // Initialize request argument(s)
            PolicyName name = PolicyName.FromProjectPolicy("[PROJECT]", "[POLICY]");
            // Make the request
            await orgPolicyClient.DeletePolicyAsync(name);
            // End snippet
        }
    }
}
