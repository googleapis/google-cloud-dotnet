// Copyright 2026 Google LLC
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
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedRuleExecutionErrorServiceClientSnippets
    {
        /// <summary>Snippet for ListRuleExecutionErrors</summary>
        public void ListRuleExecutionErrorsRequestObject()
        {
            // Snippet: ListRuleExecutionErrors(ListRuleExecutionErrorsRequest, CallSettings)
            // Create client
            RuleExecutionErrorServiceClient ruleExecutionErrorServiceClient = RuleExecutionErrorServiceClient.Create();
            // Initialize request argument(s)
            ListRuleExecutionErrorsRequest request = new ListRuleExecutionErrorsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> response = ruleExecutionErrorServiceClient.ListRuleExecutionErrors(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuleExecutionError item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuleExecutionErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuleExecutionError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuleExecutionError> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuleExecutionError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleExecutionErrorsAsync</summary>
        public async Task ListRuleExecutionErrorsRequestObjectAsync()
        {
            // Snippet: ListRuleExecutionErrorsAsync(ListRuleExecutionErrorsRequest, CallSettings)
            // Create client
            RuleExecutionErrorServiceClient ruleExecutionErrorServiceClient = await RuleExecutionErrorServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRuleExecutionErrorsRequest request = new ListRuleExecutionErrorsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> response = ruleExecutionErrorServiceClient.ListRuleExecutionErrorsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RuleExecutionError item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRuleExecutionErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuleExecutionError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuleExecutionError> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuleExecutionError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleExecutionErrors</summary>
        public void ListRuleExecutionErrors()
        {
            // Snippet: ListRuleExecutionErrors(string, string, int?, CallSettings)
            // Create client
            RuleExecutionErrorServiceClient ruleExecutionErrorServiceClient = RuleExecutionErrorServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> response = ruleExecutionErrorServiceClient.ListRuleExecutionErrors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuleExecutionError item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuleExecutionErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuleExecutionError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuleExecutionError> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuleExecutionError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleExecutionErrorsAsync</summary>
        public async Task ListRuleExecutionErrorsAsync()
        {
            // Snippet: ListRuleExecutionErrorsAsync(string, string, int?, CallSettings)
            // Create client
            RuleExecutionErrorServiceClient ruleExecutionErrorServiceClient = await RuleExecutionErrorServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> response = ruleExecutionErrorServiceClient.ListRuleExecutionErrorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RuleExecutionError item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRuleExecutionErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuleExecutionError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuleExecutionError> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuleExecutionError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleExecutionErrors</summary>
        public void ListRuleExecutionErrorsResourceNames()
        {
            // Snippet: ListRuleExecutionErrors(InstanceName, string, int?, CallSettings)
            // Create client
            RuleExecutionErrorServiceClient ruleExecutionErrorServiceClient = RuleExecutionErrorServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> response = ruleExecutionErrorServiceClient.ListRuleExecutionErrors(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (RuleExecutionError item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRuleExecutionErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuleExecutionError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuleExecutionError> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuleExecutionError item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRuleExecutionErrorsAsync</summary>
        public async Task ListRuleExecutionErrorsResourceNamesAsync()
        {
            // Snippet: ListRuleExecutionErrorsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            RuleExecutionErrorServiceClient ruleExecutionErrorServiceClient = await RuleExecutionErrorServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListRuleExecutionErrorsResponse, RuleExecutionError> response = ruleExecutionErrorServiceClient.ListRuleExecutionErrorsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (RuleExecutionError item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListRuleExecutionErrorsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (RuleExecutionError item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<RuleExecutionError> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (RuleExecutionError item in singlePage)
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
