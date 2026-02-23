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
    using Google.Ads.DataManager.V1;
    using Google.Api.Gax;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPartnerLinkServiceClientSnippets
    {
        /// <summary>Snippet for CreatePartnerLink</summary>
        public void CreatePartnerLinkRequestObject()
        {
            // Snippet: CreatePartnerLink(CreatePartnerLinkRequest, CallSettings)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = PartnerLinkServiceClient.Create();
            // Initialize request argument(s)
            CreatePartnerLinkRequest request = new CreatePartnerLinkRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                PartnerLink = new PartnerLink(),
            };
            // Make the request
            PartnerLink response = partnerLinkServiceClient.CreatePartnerLink(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePartnerLinkAsync</summary>
        public async Task CreatePartnerLinkRequestObjectAsync()
        {
            // Snippet: CreatePartnerLinkAsync(CreatePartnerLinkRequest, CallSettings)
            // Additional: CreatePartnerLinkAsync(CreatePartnerLinkRequest, CancellationToken)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = await PartnerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePartnerLinkRequest request = new CreatePartnerLinkRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                PartnerLink = new PartnerLink(),
            };
            // Make the request
            PartnerLink response = await partnerLinkServiceClient.CreatePartnerLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePartnerLink</summary>
        public void CreatePartnerLink()
        {
            // Snippet: CreatePartnerLink(string, PartnerLink, CallSettings)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = PartnerLinkServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            PartnerLink partnerLink = new PartnerLink();
            // Make the request
            PartnerLink response = partnerLinkServiceClient.CreatePartnerLink(parent, partnerLink);
            // End snippet
        }

        /// <summary>Snippet for CreatePartnerLinkAsync</summary>
        public async Task CreatePartnerLinkAsync()
        {
            // Snippet: CreatePartnerLinkAsync(string, PartnerLink, CallSettings)
            // Additional: CreatePartnerLinkAsync(string, PartnerLink, CancellationToken)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = await PartnerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            PartnerLink partnerLink = new PartnerLink();
            // Make the request
            PartnerLink response = await partnerLinkServiceClient.CreatePartnerLinkAsync(parent, partnerLink);
            // End snippet
        }

        /// <summary>Snippet for CreatePartnerLink</summary>
        public void CreatePartnerLinkResourceNames()
        {
            // Snippet: CreatePartnerLink(AccountName, PartnerLink, CallSettings)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = PartnerLinkServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            PartnerLink partnerLink = new PartnerLink();
            // Make the request
            PartnerLink response = partnerLinkServiceClient.CreatePartnerLink(parent, partnerLink);
            // End snippet
        }

        /// <summary>Snippet for CreatePartnerLinkAsync</summary>
        public async Task CreatePartnerLinkResourceNamesAsync()
        {
            // Snippet: CreatePartnerLinkAsync(AccountName, PartnerLink, CallSettings)
            // Additional: CreatePartnerLinkAsync(AccountName, PartnerLink, CancellationToken)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = await PartnerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            PartnerLink partnerLink = new PartnerLink();
            // Make the request
            PartnerLink response = await partnerLinkServiceClient.CreatePartnerLinkAsync(parent, partnerLink);
            // End snippet
        }

        /// <summary>Snippet for DeletePartnerLink</summary>
        public void DeletePartnerLinkRequestObject()
        {
            // Snippet: DeletePartnerLink(DeletePartnerLinkRequest, CallSettings)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = PartnerLinkServiceClient.Create();
            // Initialize request argument(s)
            DeletePartnerLinkRequest request = new DeletePartnerLinkRequest
            {
                PartnerLinkName = PartnerLinkName.FromAccountTypeAccountPartnerLink("[ACCOUNT_TYPE]", "[ACCOUNT]", "[PARTNER_LINK]"),
            };
            // Make the request
            partnerLinkServiceClient.DeletePartnerLink(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePartnerLinkAsync</summary>
        public async Task DeletePartnerLinkRequestObjectAsync()
        {
            // Snippet: DeletePartnerLinkAsync(DeletePartnerLinkRequest, CallSettings)
            // Additional: DeletePartnerLinkAsync(DeletePartnerLinkRequest, CancellationToken)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = await PartnerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeletePartnerLinkRequest request = new DeletePartnerLinkRequest
            {
                PartnerLinkName = PartnerLinkName.FromAccountTypeAccountPartnerLink("[ACCOUNT_TYPE]", "[ACCOUNT]", "[PARTNER_LINK]"),
            };
            // Make the request
            await partnerLinkServiceClient.DeletePartnerLinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePartnerLink</summary>
        public void DeletePartnerLink()
        {
            // Snippet: DeletePartnerLink(string, CallSettings)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = PartnerLinkServiceClient.Create();
            // Initialize request argument(s)
            string name = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]/partnerLinks/[PARTNER_LINK]";
            // Make the request
            partnerLinkServiceClient.DeletePartnerLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePartnerLinkAsync</summary>
        public async Task DeletePartnerLinkAsync()
        {
            // Snippet: DeletePartnerLinkAsync(string, CallSettings)
            // Additional: DeletePartnerLinkAsync(string, CancellationToken)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = await PartnerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]/partnerLinks/[PARTNER_LINK]";
            // Make the request
            await partnerLinkServiceClient.DeletePartnerLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePartnerLink</summary>
        public void DeletePartnerLinkResourceNames()
        {
            // Snippet: DeletePartnerLink(PartnerLinkName, CallSettings)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = PartnerLinkServiceClient.Create();
            // Initialize request argument(s)
            PartnerLinkName name = PartnerLinkName.FromAccountTypeAccountPartnerLink("[ACCOUNT_TYPE]", "[ACCOUNT]", "[PARTNER_LINK]");
            // Make the request
            partnerLinkServiceClient.DeletePartnerLink(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePartnerLinkAsync</summary>
        public async Task DeletePartnerLinkResourceNamesAsync()
        {
            // Snippet: DeletePartnerLinkAsync(PartnerLinkName, CallSettings)
            // Additional: DeletePartnerLinkAsync(PartnerLinkName, CancellationToken)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = await PartnerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            PartnerLinkName name = PartnerLinkName.FromAccountTypeAccountPartnerLink("[ACCOUNT_TYPE]", "[ACCOUNT]", "[PARTNER_LINK]");
            // Make the request
            await partnerLinkServiceClient.DeletePartnerLinkAsync(name);
            // End snippet
        }

        /// <summary>Snippet for SearchPartnerLinks</summary>
        public void SearchPartnerLinksRequestObject()
        {
            // Snippet: SearchPartnerLinks(SearchPartnerLinksRequest, CallSettings)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = PartnerLinkServiceClient.Create();
            // Initialize request argument(s)
            SearchPartnerLinksRequest request = new SearchPartnerLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<SearchPartnerLinksResponse, PartnerLink> response = partnerLinkServiceClient.SearchPartnerLinks(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PartnerLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchPartnerLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PartnerLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PartnerLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PartnerLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchPartnerLinksAsync</summary>
        public async Task SearchPartnerLinksRequestObjectAsync()
        {
            // Snippet: SearchPartnerLinksAsync(SearchPartnerLinksRequest, CallSettings)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = await PartnerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            SearchPartnerLinksRequest request = new SearchPartnerLinksRequest
            {
                ParentAsAccountName = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<SearchPartnerLinksResponse, PartnerLink> response = partnerLinkServiceClient.SearchPartnerLinksAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PartnerLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchPartnerLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PartnerLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PartnerLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PartnerLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchPartnerLinks</summary>
        public void SearchPartnerLinks()
        {
            // Snippet: SearchPartnerLinks(string, string, int?, CallSettings)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = PartnerLinkServiceClient.Create();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            // Make the request
            PagedEnumerable<SearchPartnerLinksResponse, PartnerLink> response = partnerLinkServiceClient.SearchPartnerLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PartnerLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchPartnerLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PartnerLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PartnerLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PartnerLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchPartnerLinksAsync</summary>
        public async Task SearchPartnerLinksAsync()
        {
            // Snippet: SearchPartnerLinksAsync(string, string, int?, CallSettings)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = await PartnerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "accountTypes/[ACCOUNT_TYPE]/accounts/[ACCOUNT]";
            // Make the request
            PagedAsyncEnumerable<SearchPartnerLinksResponse, PartnerLink> response = partnerLinkServiceClient.SearchPartnerLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PartnerLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchPartnerLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PartnerLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PartnerLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PartnerLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchPartnerLinks</summary>
        public void SearchPartnerLinksResourceNames()
        {
            // Snippet: SearchPartnerLinks(AccountName, string, int?, CallSettings)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = PartnerLinkServiceClient.Create();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            // Make the request
            PagedEnumerable<SearchPartnerLinksResponse, PartnerLink> response = partnerLinkServiceClient.SearchPartnerLinks(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PartnerLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (SearchPartnerLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PartnerLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PartnerLink> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PartnerLink item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SearchPartnerLinksAsync</summary>
        public async Task SearchPartnerLinksResourceNamesAsync()
        {
            // Snippet: SearchPartnerLinksAsync(AccountName, string, int?, CallSettings)
            // Create client
            PartnerLinkServiceClient partnerLinkServiceClient = await PartnerLinkServiceClient.CreateAsync();
            // Initialize request argument(s)
            AccountName parent = AccountName.FromAccountTypeAccount("[ACCOUNT_TYPE]", "[ACCOUNT]");
            // Make the request
            PagedAsyncEnumerable<SearchPartnerLinksResponse, PartnerLink> response = partnerLinkServiceClient.SearchPartnerLinksAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (PartnerLink item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (SearchPartnerLinksResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PartnerLink item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PartnerLink> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PartnerLink item in singlePage)
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
