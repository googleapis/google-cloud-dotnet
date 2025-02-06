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
    using Google.Cloud.Monitoring.V3;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAlertPolicyServiceClientSnippets
    {
        /// <summary>Snippet for ListAlertPolicies</summary>
        public void ListAlertPoliciesRequestObject()
        {
            // Snippet: ListAlertPolicies(ListAlertPoliciesRequest, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> response = alertPolicyServiceClient.ListAlertPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AlertPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAlertPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPoliciesAsync</summary>
        public async Task ListAlertPoliciesRequestObjectAsync()
        {
            // Snippet: ListAlertPoliciesAsync(ListAlertPoliciesRequest, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAlertPoliciesRequest request = new ListAlertPoliciesRequest
            {
                ProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> response = alertPolicyServiceClient.ListAlertPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AlertPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAlertPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPolicies</summary>
        public void ListAlertPolicies()
        {
            // Snippet: ListAlertPolicies(string, string, int?, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> response = alertPolicyServiceClient.ListAlertPolicies(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AlertPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAlertPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPoliciesAsync</summary>
        public async Task ListAlertPoliciesAsync()
        {
            // Snippet: ListAlertPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> response = alertPolicyServiceClient.ListAlertPoliciesAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AlertPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAlertPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPolicies</summary>
        public void ListAlertPoliciesResourceNames1()
        {
            // Snippet: ListAlertPolicies(ProjectName, string, int?, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> response = alertPolicyServiceClient.ListAlertPolicies(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AlertPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAlertPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPoliciesAsync</summary>
        public async Task ListAlertPoliciesResourceNames1Async()
        {
            // Snippet: ListAlertPoliciesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> response = alertPolicyServiceClient.ListAlertPoliciesAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AlertPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAlertPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPolicies</summary>
        public void ListAlertPoliciesResourceNames2()
        {
            // Snippet: ListAlertPolicies(OrganizationName, string, int?, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> response = alertPolicyServiceClient.ListAlertPolicies(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AlertPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAlertPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPoliciesAsync</summary>
        public async Task ListAlertPoliciesResourceNames2Async()
        {
            // Snippet: ListAlertPoliciesAsync(OrganizationName, string, int?, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            // Make the request
            PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> response = alertPolicyServiceClient.ListAlertPoliciesAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AlertPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAlertPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPolicies</summary>
        public void ListAlertPoliciesResourceNames3()
        {
            // Snippet: ListAlertPolicies(FolderName, string, int?, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> response = alertPolicyServiceClient.ListAlertPolicies(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AlertPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAlertPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPoliciesAsync</summary>
        public async Task ListAlertPoliciesResourceNames3Async()
        {
            // Snippet: ListAlertPoliciesAsync(FolderName, string, int?, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            // Make the request
            PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> response = alertPolicyServiceClient.ListAlertPoliciesAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AlertPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAlertPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPolicies</summary>
        public void ListAlertPoliciesResourceNames4()
        {
            // Snippet: ListAlertPolicies(IResourceName, string, int?, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> response = alertPolicyServiceClient.ListAlertPolicies(name);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AlertPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAlertPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAlertPoliciesAsync</summary>
        public async Task ListAlertPoliciesResourceNames4Async()
        {
            // Snippet: ListAlertPoliciesAsync(IResourceName, string, int?, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> response = alertPolicyServiceClient.ListAlertPoliciesAsync(name);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AlertPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAlertPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AlertPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AlertPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AlertPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAlertPolicy</summary>
        public void GetAlertPolicyRequestObject()
        {
            // Snippet: GetAlertPolicy(GetAlertPolicyRequest, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.GetAlertPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetAlertPolicyAsync</summary>
        public async Task GetAlertPolicyRequestObjectAsync()
        {
            // Snippet: GetAlertPolicyAsync(GetAlertPolicyRequest, CallSettings)
            // Additional: GetAlertPolicyAsync(GetAlertPolicyRequest, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAlertPolicyRequest request = new GetAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.GetAlertPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAlertPolicy</summary>
        public void GetAlertPolicy()
        {
            // Snippet: GetAlertPolicy(string, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/alertPolicies/[ALERT_POLICY]";
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.GetAlertPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAlertPolicyAsync</summary>
        public async Task GetAlertPolicyAsync()
        {
            // Snippet: GetAlertPolicyAsync(string, CallSettings)
            // Additional: GetAlertPolicyAsync(string, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/alertPolicies/[ALERT_POLICY]";
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.GetAlertPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAlertPolicy</summary>
        public void GetAlertPolicyResourceNames1()
        {
            // Snippet: GetAlertPolicy(AlertPolicyName, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            AlertPolicyName name = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]");
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.GetAlertPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAlertPolicyAsync</summary>
        public async Task GetAlertPolicyResourceNames1Async()
        {
            // Snippet: GetAlertPolicyAsync(AlertPolicyName, CallSettings)
            // Additional: GetAlertPolicyAsync(AlertPolicyName, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            AlertPolicyName name = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]");
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.GetAlertPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAlertPolicy</summary>
        public void GetAlertPolicyResourceNames2()
        {
            // Snippet: GetAlertPolicy(IResourceName, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.GetAlertPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAlertPolicyAsync</summary>
        public async Task GetAlertPolicyResourceNames2Async()
        {
            // Snippet: GetAlertPolicyAsync(IResourceName, CallSettings)
            // Additional: GetAlertPolicyAsync(IResourceName, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.GetAlertPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicy</summary>
        public void CreateAlertPolicyRequestObject()
        {
            // Snippet: CreateAlertPolicy(CreateAlertPolicyRequest, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.CreateAlertPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicyAsync</summary>
        public async Task CreateAlertPolicyRequestObjectAsync()
        {
            // Snippet: CreateAlertPolicyAsync(CreateAlertPolicyRequest, CallSettings)
            // Additional: CreateAlertPolicyAsync(CreateAlertPolicyRequest, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAlertPolicyRequest request = new CreateAlertPolicyRequest
            {
                AlertPolicy = new AlertPolicy(),
                ProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.CreateAlertPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicy</summary>
        public void CreateAlertPolicy()
        {
            // Snippet: CreateAlertPolicy(string, AlertPolicy, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.CreateAlertPolicy(name, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicyAsync</summary>
        public async Task CreateAlertPolicyAsync()
        {
            // Snippet: CreateAlertPolicyAsync(string, AlertPolicy, CallSettings)
            // Additional: CreateAlertPolicyAsync(string, AlertPolicy, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]";
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.CreateAlertPolicyAsync(name, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicy</summary>
        public void CreateAlertPolicyResourceNames1()
        {
            // Snippet: CreateAlertPolicy(ProjectName, AlertPolicy, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.CreateAlertPolicy(name, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicyAsync</summary>
        public async Task CreateAlertPolicyResourceNames1Async()
        {
            // Snippet: CreateAlertPolicyAsync(ProjectName, AlertPolicy, CallSettings)
            // Additional: CreateAlertPolicyAsync(ProjectName, AlertPolicy, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName name = ProjectName.FromProject("[PROJECT]");
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.CreateAlertPolicyAsync(name, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicy</summary>
        public void CreateAlertPolicyResourceNames2()
        {
            // Snippet: CreateAlertPolicy(OrganizationName, AlertPolicy, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.CreateAlertPolicy(name, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicyAsync</summary>
        public async Task CreateAlertPolicyResourceNames2Async()
        {
            // Snippet: CreateAlertPolicyAsync(OrganizationName, AlertPolicy, CallSettings)
            // Additional: CreateAlertPolicyAsync(OrganizationName, AlertPolicy, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            OrganizationName name = OrganizationName.FromOrganization("[ORGANIZATION]");
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.CreateAlertPolicyAsync(name, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicy</summary>
        public void CreateAlertPolicyResourceNames3()
        {
            // Snippet: CreateAlertPolicy(FolderName, AlertPolicy, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.CreateAlertPolicy(name, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicyAsync</summary>
        public async Task CreateAlertPolicyResourceNames3Async()
        {
            // Snippet: CreateAlertPolicyAsync(FolderName, AlertPolicy, CallSettings)
            // Additional: CreateAlertPolicyAsync(FolderName, AlertPolicy, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            FolderName name = FolderName.FromFolder("[FOLDER]");
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.CreateAlertPolicyAsync(name, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicy</summary>
        public void CreateAlertPolicyResourceNames4()
        {
            // Snippet: CreateAlertPolicy(IResourceName, AlertPolicy, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.CreateAlertPolicy(name, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for CreateAlertPolicyAsync</summary>
        public async Task CreateAlertPolicyResourceNames4Async()
        {
            // Snippet: CreateAlertPolicyAsync(IResourceName, AlertPolicy, CallSettings)
            // Additional: CreateAlertPolicyAsync(IResourceName, AlertPolicy, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.CreateAlertPolicyAsync(name, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlertPolicy</summary>
        public void DeleteAlertPolicyRequestObject()
        {
            // Snippet: DeleteAlertPolicy(DeleteAlertPolicyRequest, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            // Make the request
            alertPolicyServiceClient.DeleteAlertPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlertPolicyAsync</summary>
        public async Task DeleteAlertPolicyRequestObjectAsync()
        {
            // Snippet: DeleteAlertPolicyAsync(DeleteAlertPolicyRequest, CallSettings)
            // Additional: DeleteAlertPolicyAsync(DeleteAlertPolicyRequest, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAlertPolicyRequest request = new DeleteAlertPolicyRequest
            {
                AlertPolicyName = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]"),
            };
            // Make the request
            await alertPolicyServiceClient.DeleteAlertPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlertPolicy</summary>
        public void DeleteAlertPolicy()
        {
            // Snippet: DeleteAlertPolicy(string, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/alertPolicies/[ALERT_POLICY]";
            // Make the request
            alertPolicyServiceClient.DeleteAlertPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlertPolicyAsync</summary>
        public async Task DeleteAlertPolicyAsync()
        {
            // Snippet: DeleteAlertPolicyAsync(string, CallSettings)
            // Additional: DeleteAlertPolicyAsync(string, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/alertPolicies/[ALERT_POLICY]";
            // Make the request
            await alertPolicyServiceClient.DeleteAlertPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlertPolicy</summary>
        public void DeleteAlertPolicyResourceNames1()
        {
            // Snippet: DeleteAlertPolicy(AlertPolicyName, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            AlertPolicyName name = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]");
            // Make the request
            alertPolicyServiceClient.DeleteAlertPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlertPolicyAsync</summary>
        public async Task DeleteAlertPolicyResourceNames1Async()
        {
            // Snippet: DeleteAlertPolicyAsync(AlertPolicyName, CallSettings)
            // Additional: DeleteAlertPolicyAsync(AlertPolicyName, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            AlertPolicyName name = AlertPolicyName.FromProjectAlertPolicy("[PROJECT]", "[ALERT_POLICY]");
            // Make the request
            await alertPolicyServiceClient.DeleteAlertPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlertPolicy</summary>
        public void DeleteAlertPolicyResourceNames2()
        {
            // Snippet: DeleteAlertPolicy(IResourceName, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            alertPolicyServiceClient.DeleteAlertPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAlertPolicyAsync</summary>
        public async Task DeleteAlertPolicyResourceNames2Async()
        {
            // Snippet: DeleteAlertPolicyAsync(IResourceName, CallSettings)
            // Additional: DeleteAlertPolicyAsync(IResourceName, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName name = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            await alertPolicyServiceClient.DeleteAlertPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAlertPolicy</summary>
        public void UpdateAlertPolicyRequestObject()
        {
            // Snippet: UpdateAlertPolicy(UpdateAlertPolicyRequest, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            UpdateAlertPolicyRequest request = new UpdateAlertPolicyRequest
            {
                UpdateMask = new FieldMask(),
                AlertPolicy = new AlertPolicy(),
            };
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.UpdateAlertPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAlertPolicyAsync</summary>
        public async Task UpdateAlertPolicyRequestObjectAsync()
        {
            // Snippet: UpdateAlertPolicyAsync(UpdateAlertPolicyRequest, CallSettings)
            // Additional: UpdateAlertPolicyAsync(UpdateAlertPolicyRequest, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAlertPolicyRequest request = new UpdateAlertPolicyRequest
            {
                UpdateMask = new FieldMask(),
                AlertPolicy = new AlertPolicy(),
            };
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.UpdateAlertPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAlertPolicy</summary>
        public void UpdateAlertPolicy()
        {
            // Snippet: UpdateAlertPolicy(FieldMask, AlertPolicy, CallSettings)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = AlertPolicyServiceClient.Create();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask();
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = alertPolicyServiceClient.UpdateAlertPolicy(updateMask, alertPolicy);
            // End snippet
        }

        /// <summary>Snippet for UpdateAlertPolicyAsync</summary>
        public async Task UpdateAlertPolicyAsync()
        {
            // Snippet: UpdateAlertPolicyAsync(FieldMask, AlertPolicy, CallSettings)
            // Additional: UpdateAlertPolicyAsync(FieldMask, AlertPolicy, CancellationToken)
            // Create client
            AlertPolicyServiceClient alertPolicyServiceClient = await AlertPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            FieldMask updateMask = new FieldMask();
            AlertPolicy alertPolicy = new AlertPolicy();
            // Make the request
            AlertPolicy response = await alertPolicyServiceClient.UpdateAlertPolicyAsync(updateMask, alertPolicy);
            // End snippet
        }
    }
}
