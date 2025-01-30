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
    using Google.Cloud.Dialogflow.Cx.V3;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedChangelogsClientSnippets
    {
        /// <summary>Snippet for ListChangelogs</summary>
        public void ListChangelogsRequestObject()
        {
            // Snippet: ListChangelogs(ListChangelogsRequest, CallSettings)
            // Create client
            ChangelogsClient changelogsClient = ChangelogsClient.Create();
            // Initialize request argument(s)
            ListChangelogsRequest request = new ListChangelogsRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListChangelogsResponse, Changelog> response = changelogsClient.ListChangelogs(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Changelog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChangelogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Changelog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Changelog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Changelog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangelogsAsync</summary>
        public async Task ListChangelogsRequestObjectAsync()
        {
            // Snippet: ListChangelogsAsync(ListChangelogsRequest, CallSettings)
            // Create client
            ChangelogsClient changelogsClient = await ChangelogsClient.CreateAsync();
            // Initialize request argument(s)
            ListChangelogsRequest request = new ListChangelogsRequest
            {
                ParentAsAgentName = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListChangelogsResponse, Changelog> response = changelogsClient.ListChangelogsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Changelog item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChangelogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Changelog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Changelog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Changelog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangelogs</summary>
        public void ListChangelogs()
        {
            // Snippet: ListChangelogs(string, string, int?, CallSettings)
            // Create client
            ChangelogsClient changelogsClient = ChangelogsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedEnumerable<ListChangelogsResponse, Changelog> response = changelogsClient.ListChangelogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Changelog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChangelogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Changelog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Changelog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Changelog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangelogsAsync</summary>
        public async Task ListChangelogsAsync()
        {
            // Snippet: ListChangelogsAsync(string, string, int?, CallSettings)
            // Create client
            ChangelogsClient changelogsClient = await ChangelogsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]";
            // Make the request
            PagedAsyncEnumerable<ListChangelogsResponse, Changelog> response = changelogsClient.ListChangelogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Changelog item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChangelogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Changelog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Changelog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Changelog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangelogs</summary>
        public void ListChangelogsResourceNames()
        {
            // Snippet: ListChangelogs(AgentName, string, int?, CallSettings)
            // Create client
            ChangelogsClient changelogsClient = ChangelogsClient.Create();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedEnumerable<ListChangelogsResponse, Changelog> response = changelogsClient.ListChangelogs(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Changelog item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListChangelogsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Changelog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Changelog> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Changelog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListChangelogsAsync</summary>
        public async Task ListChangelogsResourceNamesAsync()
        {
            // Snippet: ListChangelogsAsync(AgentName, string, int?, CallSettings)
            // Create client
            ChangelogsClient changelogsClient = await ChangelogsClient.CreateAsync();
            // Initialize request argument(s)
            AgentName parent = AgentName.FromProjectLocationAgent("[PROJECT]", "[LOCATION]", "[AGENT]");
            // Make the request
            PagedAsyncEnumerable<ListChangelogsResponse, Changelog> response = changelogsClient.ListChangelogsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Changelog item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListChangelogsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Changelog item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Changelog> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Changelog item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetChangelog</summary>
        public void GetChangelogRequestObject()
        {
            // Snippet: GetChangelog(GetChangelogRequest, CallSettings)
            // Create client
            ChangelogsClient changelogsClient = ChangelogsClient.Create();
            // Initialize request argument(s)
            GetChangelogRequest request = new GetChangelogRequest
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
            };
            // Make the request
            Changelog response = changelogsClient.GetChangelog(request);
            // End snippet
        }

        /// <summary>Snippet for GetChangelogAsync</summary>
        public async Task GetChangelogRequestObjectAsync()
        {
            // Snippet: GetChangelogAsync(GetChangelogRequest, CallSettings)
            // Additional: GetChangelogAsync(GetChangelogRequest, CancellationToken)
            // Create client
            ChangelogsClient changelogsClient = await ChangelogsClient.CreateAsync();
            // Initialize request argument(s)
            GetChangelogRequest request = new GetChangelogRequest
            {
                ChangelogName = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]"),
            };
            // Make the request
            Changelog response = await changelogsClient.GetChangelogAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetChangelog</summary>
        public void GetChangelog()
        {
            // Snippet: GetChangelog(string, CallSettings)
            // Create client
            ChangelogsClient changelogsClient = ChangelogsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/changelogs/[CHANGELOG]";
            // Make the request
            Changelog response = changelogsClient.GetChangelog(name);
            // End snippet
        }

        /// <summary>Snippet for GetChangelogAsync</summary>
        public async Task GetChangelogAsync()
        {
            // Snippet: GetChangelogAsync(string, CallSettings)
            // Additional: GetChangelogAsync(string, CancellationToken)
            // Create client
            ChangelogsClient changelogsClient = await ChangelogsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/changelogs/[CHANGELOG]";
            // Make the request
            Changelog response = await changelogsClient.GetChangelogAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetChangelog</summary>
        public void GetChangelogResourceNames()
        {
            // Snippet: GetChangelog(ChangelogName, CallSettings)
            // Create client
            ChangelogsClient changelogsClient = ChangelogsClient.Create();
            // Initialize request argument(s)
            ChangelogName name = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]");
            // Make the request
            Changelog response = changelogsClient.GetChangelog(name);
            // End snippet
        }

        /// <summary>Snippet for GetChangelogAsync</summary>
        public async Task GetChangelogResourceNamesAsync()
        {
            // Snippet: GetChangelogAsync(ChangelogName, CallSettings)
            // Additional: GetChangelogAsync(ChangelogName, CancellationToken)
            // Create client
            ChangelogsClient changelogsClient = await ChangelogsClient.CreateAsync();
            // Initialize request argument(s)
            ChangelogName name = ChangelogName.FromProjectLocationAgentChangelog("[PROJECT]", "[LOCATION]", "[AGENT]", "[CHANGELOG]");
            // Make the request
            Changelog response = await changelogsClient.GetChangelogAsync(name);
            // End snippet
        }
    }
}
