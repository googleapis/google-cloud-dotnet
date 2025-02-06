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
    using Google.Cloud.Dataproc.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAutoscalingPolicyServiceClientSnippets
    {
        /// <summary>Snippet for CreateAutoscalingPolicy</summary>
        public void CreateAutoscalingPolicyRequestObject()
        {
            // Snippet: CreateAutoscalingPolicy(CreateAutoscalingPolicyRequest, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            CreateAutoscalingPolicyRequest request = new CreateAutoscalingPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Policy = new AutoscalingPolicy(),
            };
            // Make the request
            AutoscalingPolicy response = autoscalingPolicyServiceClient.CreateAutoscalingPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAutoscalingPolicyAsync</summary>
        public async Task CreateAutoscalingPolicyRequestObjectAsync()
        {
            // Snippet: CreateAutoscalingPolicyAsync(CreateAutoscalingPolicyRequest, CallSettings)
            // Additional: CreateAutoscalingPolicyAsync(CreateAutoscalingPolicyRequest, CancellationToken)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAutoscalingPolicyRequest request = new CreateAutoscalingPolicyRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Policy = new AutoscalingPolicy(),
            };
            // Make the request
            AutoscalingPolicy response = await autoscalingPolicyServiceClient.CreateAutoscalingPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAutoscalingPolicy</summary>
        public void CreateAutoscalingPolicy()
        {
            // Snippet: CreateAutoscalingPolicy(string, AutoscalingPolicy, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AutoscalingPolicy policy = new AutoscalingPolicy();
            // Make the request
            AutoscalingPolicy response = autoscalingPolicyServiceClient.CreateAutoscalingPolicy(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for CreateAutoscalingPolicyAsync</summary>
        public async Task CreateAutoscalingPolicyAsync()
        {
            // Snippet: CreateAutoscalingPolicyAsync(string, AutoscalingPolicy, CallSettings)
            // Additional: CreateAutoscalingPolicyAsync(string, AutoscalingPolicy, CancellationToken)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AutoscalingPolicy policy = new AutoscalingPolicy();
            // Make the request
            AutoscalingPolicy response = await autoscalingPolicyServiceClient.CreateAutoscalingPolicyAsync(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for CreateAutoscalingPolicy</summary>
        public void CreateAutoscalingPolicyResourceNames1()
        {
            // Snippet: CreateAutoscalingPolicy(LocationName, AutoscalingPolicy, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AutoscalingPolicy policy = new AutoscalingPolicy();
            // Make the request
            AutoscalingPolicy response = autoscalingPolicyServiceClient.CreateAutoscalingPolicy(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for CreateAutoscalingPolicyAsync</summary>
        public async Task CreateAutoscalingPolicyResourceNames1Async()
        {
            // Snippet: CreateAutoscalingPolicyAsync(LocationName, AutoscalingPolicy, CallSettings)
            // Additional: CreateAutoscalingPolicyAsync(LocationName, AutoscalingPolicy, CancellationToken)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AutoscalingPolicy policy = new AutoscalingPolicy();
            // Make the request
            AutoscalingPolicy response = await autoscalingPolicyServiceClient.CreateAutoscalingPolicyAsync(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for CreateAutoscalingPolicy</summary>
        public void CreateAutoscalingPolicyResourceNames2()
        {
            // Snippet: CreateAutoscalingPolicy(RegionName, AutoscalingPolicy, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            RegionName parent = RegionName.FromProjectRegion("[PROJECT]", "[REGION]");
            AutoscalingPolicy policy = new AutoscalingPolicy();
            // Make the request
            AutoscalingPolicy response = autoscalingPolicyServiceClient.CreateAutoscalingPolicy(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for CreateAutoscalingPolicyAsync</summary>
        public async Task CreateAutoscalingPolicyResourceNames2Async()
        {
            // Snippet: CreateAutoscalingPolicyAsync(RegionName, AutoscalingPolicy, CallSettings)
            // Additional: CreateAutoscalingPolicyAsync(RegionName, AutoscalingPolicy, CancellationToken)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            RegionName parent = RegionName.FromProjectRegion("[PROJECT]", "[REGION]");
            AutoscalingPolicy policy = new AutoscalingPolicy();
            // Make the request
            AutoscalingPolicy response = await autoscalingPolicyServiceClient.CreateAutoscalingPolicyAsync(parent, policy);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutoscalingPolicy</summary>
        public void UpdateAutoscalingPolicyRequestObject()
        {
            // Snippet: UpdateAutoscalingPolicy(UpdateAutoscalingPolicyRequest, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            UpdateAutoscalingPolicyRequest request = new UpdateAutoscalingPolicyRequest
            {
                Policy = new AutoscalingPolicy(),
            };
            // Make the request
            AutoscalingPolicy response = autoscalingPolicyServiceClient.UpdateAutoscalingPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutoscalingPolicyAsync</summary>
        public async Task UpdateAutoscalingPolicyRequestObjectAsync()
        {
            // Snippet: UpdateAutoscalingPolicyAsync(UpdateAutoscalingPolicyRequest, CallSettings)
            // Additional: UpdateAutoscalingPolicyAsync(UpdateAutoscalingPolicyRequest, CancellationToken)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAutoscalingPolicyRequest request = new UpdateAutoscalingPolicyRequest
            {
                Policy = new AutoscalingPolicy(),
            };
            // Make the request
            AutoscalingPolicy response = await autoscalingPolicyServiceClient.UpdateAutoscalingPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutoscalingPolicy</summary>
        public void UpdateAutoscalingPolicy()
        {
            // Snippet: UpdateAutoscalingPolicy(AutoscalingPolicy, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            AutoscalingPolicy policy = new AutoscalingPolicy();
            // Make the request
            AutoscalingPolicy response = autoscalingPolicyServiceClient.UpdateAutoscalingPolicy(policy);
            // End snippet
        }

        /// <summary>Snippet for UpdateAutoscalingPolicyAsync</summary>
        public async Task UpdateAutoscalingPolicyAsync()
        {
            // Snippet: UpdateAutoscalingPolicyAsync(AutoscalingPolicy, CallSettings)
            // Additional: UpdateAutoscalingPolicyAsync(AutoscalingPolicy, CancellationToken)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            AutoscalingPolicy policy = new AutoscalingPolicy();
            // Make the request
            AutoscalingPolicy response = await autoscalingPolicyServiceClient.UpdateAutoscalingPolicyAsync(policy);
            // End snippet
        }

        /// <summary>Snippet for GetAutoscalingPolicy</summary>
        public void GetAutoscalingPolicyRequestObject()
        {
            // Snippet: GetAutoscalingPolicy(GetAutoscalingPolicyRequest, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            GetAutoscalingPolicyRequest request = new GetAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            // Make the request
            AutoscalingPolicy response = autoscalingPolicyServiceClient.GetAutoscalingPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutoscalingPolicyAsync</summary>
        public async Task GetAutoscalingPolicyRequestObjectAsync()
        {
            // Snippet: GetAutoscalingPolicyAsync(GetAutoscalingPolicyRequest, CallSettings)
            // Additional: GetAutoscalingPolicyAsync(GetAutoscalingPolicyRequest, CancellationToken)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAutoscalingPolicyRequest request = new GetAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            // Make the request
            AutoscalingPolicy response = await autoscalingPolicyServiceClient.GetAutoscalingPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAutoscalingPolicy</summary>
        public void GetAutoscalingPolicy()
        {
            // Snippet: GetAutoscalingPolicy(string, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autoscalingPolicies/[AUTOSCALING_POLICY]";
            // Make the request
            AutoscalingPolicy response = autoscalingPolicyServiceClient.GetAutoscalingPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutoscalingPolicyAsync</summary>
        public async Task GetAutoscalingPolicyAsync()
        {
            // Snippet: GetAutoscalingPolicyAsync(string, CallSettings)
            // Additional: GetAutoscalingPolicyAsync(string, CancellationToken)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autoscalingPolicies/[AUTOSCALING_POLICY]";
            // Make the request
            AutoscalingPolicy response = await autoscalingPolicyServiceClient.GetAutoscalingPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutoscalingPolicy</summary>
        public void GetAutoscalingPolicyResourceNames()
        {
            // Snippet: GetAutoscalingPolicy(AutoscalingPolicyName, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            AutoscalingPolicyName name = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]");
            // Make the request
            AutoscalingPolicy response = autoscalingPolicyServiceClient.GetAutoscalingPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for GetAutoscalingPolicyAsync</summary>
        public async Task GetAutoscalingPolicyResourceNamesAsync()
        {
            // Snippet: GetAutoscalingPolicyAsync(AutoscalingPolicyName, CallSettings)
            // Additional: GetAutoscalingPolicyAsync(AutoscalingPolicyName, CancellationToken)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            AutoscalingPolicyName name = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]");
            // Make the request
            AutoscalingPolicy response = await autoscalingPolicyServiceClient.GetAutoscalingPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAutoscalingPolicies</summary>
        public void ListAutoscalingPoliciesRequestObject()
        {
            // Snippet: ListAutoscalingPolicies(ListAutoscalingPoliciesRequest, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            ListAutoscalingPoliciesRequest request = new ListAutoscalingPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> response = autoscalingPolicyServiceClient.ListAutoscalingPolicies(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutoscalingPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutoscalingPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutoscalingPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutoscalingPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutoscalingPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutoscalingPoliciesAsync</summary>
        public async Task ListAutoscalingPoliciesRequestObjectAsync()
        {
            // Snippet: ListAutoscalingPoliciesAsync(ListAutoscalingPoliciesRequest, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAutoscalingPoliciesRequest request = new ListAutoscalingPoliciesRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> response = autoscalingPolicyServiceClient.ListAutoscalingPoliciesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutoscalingPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutoscalingPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutoscalingPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutoscalingPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutoscalingPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutoscalingPolicies</summary>
        public void ListAutoscalingPolicies()
        {
            // Snippet: ListAutoscalingPolicies(string, string, int?, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> response = autoscalingPolicyServiceClient.ListAutoscalingPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutoscalingPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutoscalingPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutoscalingPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutoscalingPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutoscalingPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutoscalingPoliciesAsync</summary>
        public async Task ListAutoscalingPoliciesAsync()
        {
            // Snippet: ListAutoscalingPoliciesAsync(string, string, int?, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> response = autoscalingPolicyServiceClient.ListAutoscalingPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutoscalingPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutoscalingPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutoscalingPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutoscalingPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutoscalingPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutoscalingPolicies</summary>
        public void ListAutoscalingPoliciesResourceNames1()
        {
            // Snippet: ListAutoscalingPolicies(LocationName, string, int?, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> response = autoscalingPolicyServiceClient.ListAutoscalingPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutoscalingPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutoscalingPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutoscalingPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutoscalingPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutoscalingPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutoscalingPoliciesAsync</summary>
        public async Task ListAutoscalingPoliciesResourceNames1Async()
        {
            // Snippet: ListAutoscalingPoliciesAsync(LocationName, string, int?, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> response = autoscalingPolicyServiceClient.ListAutoscalingPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutoscalingPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutoscalingPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutoscalingPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutoscalingPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutoscalingPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutoscalingPolicies</summary>
        public void ListAutoscalingPoliciesResourceNames2()
        {
            // Snippet: ListAutoscalingPolicies(RegionName, string, int?, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            RegionName parent = RegionName.FromProjectRegion("[PROJECT]", "[REGION]");
            // Make the request
            PagedEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> response = autoscalingPolicyServiceClient.ListAutoscalingPolicies(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AutoscalingPolicy item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAutoscalingPoliciesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutoscalingPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutoscalingPolicy> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutoscalingPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAutoscalingPoliciesAsync</summary>
        public async Task ListAutoscalingPoliciesResourceNames2Async()
        {
            // Snippet: ListAutoscalingPoliciesAsync(RegionName, string, int?, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            RegionName parent = RegionName.FromProjectRegion("[PROJECT]", "[REGION]");
            // Make the request
            PagedAsyncEnumerable<ListAutoscalingPoliciesResponse, AutoscalingPolicy> response = autoscalingPolicyServiceClient.ListAutoscalingPoliciesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AutoscalingPolicy item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAutoscalingPoliciesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AutoscalingPolicy item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AutoscalingPolicy> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AutoscalingPolicy item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAutoscalingPolicy</summary>
        public void DeleteAutoscalingPolicyRequestObject()
        {
            // Snippet: DeleteAutoscalingPolicy(DeleteAutoscalingPolicyRequest, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            DeleteAutoscalingPolicyRequest request = new DeleteAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            // Make the request
            autoscalingPolicyServiceClient.DeleteAutoscalingPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAutoscalingPolicyAsync</summary>
        public async Task DeleteAutoscalingPolicyRequestObjectAsync()
        {
            // Snippet: DeleteAutoscalingPolicyAsync(DeleteAutoscalingPolicyRequest, CallSettings)
            // Additional: DeleteAutoscalingPolicyAsync(DeleteAutoscalingPolicyRequest, CancellationToken)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAutoscalingPolicyRequest request = new DeleteAutoscalingPolicyRequest
            {
                AutoscalingPolicyName = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]"),
            };
            // Make the request
            await autoscalingPolicyServiceClient.DeleteAutoscalingPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAutoscalingPolicy</summary>
        public void DeleteAutoscalingPolicy()
        {
            // Snippet: DeleteAutoscalingPolicy(string, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autoscalingPolicies/[AUTOSCALING_POLICY]";
            // Make the request
            autoscalingPolicyServiceClient.DeleteAutoscalingPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAutoscalingPolicyAsync</summary>
        public async Task DeleteAutoscalingPolicyAsync()
        {
            // Snippet: DeleteAutoscalingPolicyAsync(string, CallSettings)
            // Additional: DeleteAutoscalingPolicyAsync(string, CancellationToken)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/autoscalingPolicies/[AUTOSCALING_POLICY]";
            // Make the request
            await autoscalingPolicyServiceClient.DeleteAutoscalingPolicyAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAutoscalingPolicy</summary>
        public void DeleteAutoscalingPolicyResourceNames()
        {
            // Snippet: DeleteAutoscalingPolicy(AutoscalingPolicyName, CallSettings)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = AutoscalingPolicyServiceClient.Create();
            // Initialize request argument(s)
            AutoscalingPolicyName name = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]");
            // Make the request
            autoscalingPolicyServiceClient.DeleteAutoscalingPolicy(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAutoscalingPolicyAsync</summary>
        public async Task DeleteAutoscalingPolicyResourceNamesAsync()
        {
            // Snippet: DeleteAutoscalingPolicyAsync(AutoscalingPolicyName, CallSettings)
            // Additional: DeleteAutoscalingPolicyAsync(AutoscalingPolicyName, CancellationToken)
            // Create client
            AutoscalingPolicyServiceClient autoscalingPolicyServiceClient = await AutoscalingPolicyServiceClient.CreateAsync();
            // Initialize request argument(s)
            AutoscalingPolicyName name = AutoscalingPolicyName.FromProjectLocationAutoscalingPolicy("[PROJECT]", "[LOCATION]", "[AUTOSCALING_POLICY]");
            // Make the request
            await autoscalingPolicyServiceClient.DeleteAutoscalingPolicyAsync(name);
            // End snippet
        }
    }
}
