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
    using Google.Cloud.DiscoveryEngine.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedUserLicenseServiceClientSnippets
    {
        /// <summary>Snippet for ListUserLicenses</summary>
        public void ListUserLicensesRequestObject()
        {
            // Snippet: ListUserLicenses(ListUserLicensesRequest, CallSettings)
            // Create client
            UserLicenseServiceClient userLicenseServiceClient = UserLicenseServiceClient.Create();
            // Initialize request argument(s)
            ListUserLicensesRequest request = new ListUserLicensesRequest
            {
                ParentAsUserStoreName = UserStoreName.FromProjectLocationUserStore("[PROJECT]", "[LOCATION]", "[USER_STORE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListUserLicensesResponse, UserLicense> response = userLicenseServiceClient.ListUserLicenses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLicense> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLicensesAsync</summary>
        public async Task ListUserLicensesRequestObjectAsync()
        {
            // Snippet: ListUserLicensesAsync(ListUserLicensesRequest, CallSettings)
            // Create client
            UserLicenseServiceClient userLicenseServiceClient = await UserLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListUserLicensesRequest request = new ListUserLicensesRequest
            {
                ParentAsUserStoreName = UserStoreName.FromProjectLocationUserStore("[PROJECT]", "[LOCATION]", "[USER_STORE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListUserLicensesResponse, UserLicense> response = userLicenseServiceClient.ListUserLicensesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UserLicense item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUserLicensesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLicense> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLicenses</summary>
        public void ListUserLicenses()
        {
            // Snippet: ListUserLicenses(string, string, int?, CallSettings)
            // Create client
            UserLicenseServiceClient userLicenseServiceClient = UserLicenseServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/userStores/[USER_STORE]";
            // Make the request
            PagedEnumerable<ListUserLicensesResponse, UserLicense> response = userLicenseServiceClient.ListUserLicenses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLicense> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLicensesAsync</summary>
        public async Task ListUserLicensesAsync()
        {
            // Snippet: ListUserLicensesAsync(string, string, int?, CallSettings)
            // Create client
            UserLicenseServiceClient userLicenseServiceClient = await UserLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/userStores/[USER_STORE]";
            // Make the request
            PagedAsyncEnumerable<ListUserLicensesResponse, UserLicense> response = userLicenseServiceClient.ListUserLicensesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UserLicense item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUserLicensesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLicense> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLicenses</summary>
        public void ListUserLicensesResourceNames()
        {
            // Snippet: ListUserLicenses(UserStoreName, string, int?, CallSettings)
            // Create client
            UserLicenseServiceClient userLicenseServiceClient = UserLicenseServiceClient.Create();
            // Initialize request argument(s)
            UserStoreName parent = UserStoreName.FromProjectLocationUserStore("[PROJECT]", "[LOCATION]", "[USER_STORE]");
            // Make the request
            PagedEnumerable<ListUserLicensesResponse, UserLicense> response = userLicenseServiceClient.ListUserLicenses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (UserLicense item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListUserLicensesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLicense> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListUserLicensesAsync</summary>
        public async Task ListUserLicensesResourceNamesAsync()
        {
            // Snippet: ListUserLicensesAsync(UserStoreName, string, int?, CallSettings)
            // Create client
            UserLicenseServiceClient userLicenseServiceClient = await UserLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            UserStoreName parent = UserStoreName.FromProjectLocationUserStore("[PROJECT]", "[LOCATION]", "[USER_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListUserLicensesResponse, UserLicense> response = userLicenseServiceClient.ListUserLicensesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((UserLicense item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListUserLicensesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (UserLicense item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<UserLicense> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (UserLicense item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateUserLicenses</summary>
        public void BatchUpdateUserLicensesRequestObject()
        {
            // Snippet: BatchUpdateUserLicenses(BatchUpdateUserLicensesRequest, CallSettings)
            // Create client
            UserLicenseServiceClient userLicenseServiceClient = UserLicenseServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateUserLicensesRequest request = new BatchUpdateUserLicensesRequest
            {
                ParentAsUserStoreName = UserStoreName.FromProjectLocationUserStore("[PROJECT]", "[LOCATION]", "[USER_STORE]"),
                InlineSource = new BatchUpdateUserLicensesRequest.Types.InlineSource(),
                DeleteUnassignedUserLicenses = false,
            };
            // Make the request
            Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata> response = userLicenseServiceClient.BatchUpdateUserLicenses(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BatchUpdateUserLicensesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata> retrievedResponse = userLicenseServiceClient.PollOnceBatchUpdateUserLicenses(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateUserLicensesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateUserLicensesAsync</summary>
        public async Task BatchUpdateUserLicensesRequestObjectAsync()
        {
            // Snippet: BatchUpdateUserLicensesAsync(BatchUpdateUserLicensesRequest, CallSettings)
            // Additional: BatchUpdateUserLicensesAsync(BatchUpdateUserLicensesRequest, CancellationToken)
            // Create client
            UserLicenseServiceClient userLicenseServiceClient = await UserLicenseServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateUserLicensesRequest request = new BatchUpdateUserLicensesRequest
            {
                ParentAsUserStoreName = UserStoreName.FromProjectLocationUserStore("[PROJECT]", "[LOCATION]", "[USER_STORE]"),
                InlineSource = new BatchUpdateUserLicensesRequest.Types.InlineSource(),
                DeleteUnassignedUserLicenses = false,
            };
            // Make the request
            Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata> response = await userLicenseServiceClient.BatchUpdateUserLicensesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BatchUpdateUserLicensesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BatchUpdateUserLicensesResponse, BatchUpdateUserLicensesMetadata> retrievedResponse = await userLicenseServiceClient.PollOnceBatchUpdateUserLicensesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BatchUpdateUserLicensesResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
