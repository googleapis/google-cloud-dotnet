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
    using Google.Cloud.AppEngine.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAuthorizedDomainsClientSnippets
    {
        /// <summary>Snippet for ListAuthorizedDomains</summary>
        public void ListAuthorizedDomainsRequestObject()
        {
            // Snippet: ListAuthorizedDomains(ListAuthorizedDomainsRequest, CallSettings)
            // Create client
            AuthorizedDomainsClient authorizedDomainsClient = AuthorizedDomainsClient.Create();
            // Initialize request argument(s)
            ListAuthorizedDomainsRequest request = new ListAuthorizedDomainsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListAuthorizedDomainsResponse, AuthorizedDomain> response = authorizedDomainsClient.ListAuthorizedDomains(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuthorizedDomain item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuthorizedDomainsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizedDomain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizedDomain> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizedDomain item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizedDomainsAsync</summary>
        public async Task ListAuthorizedDomainsRequestObjectAsync()
        {
            // Snippet: ListAuthorizedDomainsAsync(ListAuthorizedDomainsRequest, CallSettings)
            // Create client
            AuthorizedDomainsClient authorizedDomainsClient = await AuthorizedDomainsClient.CreateAsync();
            // Initialize request argument(s)
            ListAuthorizedDomainsRequest request = new ListAuthorizedDomainsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListAuthorizedDomainsResponse, AuthorizedDomain> response = authorizedDomainsClient.ListAuthorizedDomainsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AuthorizedDomain item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAuthorizedDomainsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizedDomain item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizedDomain> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizedDomain item in singlePage)
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
