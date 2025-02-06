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
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedPagesClientSnippets
    {
        /// <summary>Snippet for ListPages</summary>
        public void ListPagesRequestObject()
        {
            // Snippet: ListPages(ListPagesRequest, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            ListPagesRequest request = new ListPagesRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "",
            };
            // Make the request
            PagedEnumerable<ListPagesResponse, Page> response = pagesClient.ListPages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Page item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Page item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Page> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Page item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPagesAsync</summary>
        public async Task ListPagesRequestObjectAsync()
        {
            // Snippet: ListPagesAsync(ListPagesRequest, CallSettings)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            ListPagesRequest request = new ListPagesRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                LanguageCode = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPagesResponse, Page> response = pagesClient.ListPagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Page item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Page item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Page> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Page item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPages</summary>
        public void ListPages()
        {
            // Snippet: ListPages(string, string, int?, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            // Make the request
            PagedEnumerable<ListPagesResponse, Page> response = pagesClient.ListPages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Page item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Page item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Page> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Page item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPagesAsync</summary>
        public async Task ListPagesAsync()
        {
            // Snippet: ListPagesAsync(string, string, int?, CallSettings)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            // Make the request
            PagedAsyncEnumerable<ListPagesResponse, Page> response = pagesClient.ListPagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Page item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Page item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Page> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Page item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPages</summary>
        public void ListPagesResourceNames()
        {
            // Snippet: ListPages(FlowName, string, int?, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            FlowName parent = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            PagedEnumerable<ListPagesResponse, Page> response = pagesClient.ListPages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Page item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Page item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Page> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Page item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPagesAsync</summary>
        public async Task ListPagesResourceNamesAsync()
        {
            // Snippet: ListPagesAsync(FlowName, string, int?, CallSettings)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            FlowName parent = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            // Make the request
            PagedAsyncEnumerable<ListPagesResponse, Page> response = pagesClient.ListPagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Page item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Page item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Page> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Page item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetPage</summary>
        public void GetPageRequestObject()
        {
            // Snippet: GetPage(GetPageRequest, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            GetPageRequest request = new GetPageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                LanguageCode = "",
            };
            // Make the request
            Page response = pagesClient.GetPage(request);
            // End snippet
        }

        /// <summary>Snippet for GetPageAsync</summary>
        public async Task GetPageRequestObjectAsync()
        {
            // Snippet: GetPageAsync(GetPageRequest, CallSettings)
            // Additional: GetPageAsync(GetPageRequest, CancellationToken)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            GetPageRequest request = new GetPageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                LanguageCode = "",
            };
            // Make the request
            Page response = await pagesClient.GetPageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPage</summary>
        public void GetPage()
        {
            // Snippet: GetPage(string, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/pages/[PAGE]";
            // Make the request
            Page response = pagesClient.GetPage(name);
            // End snippet
        }

        /// <summary>Snippet for GetPageAsync</summary>
        public async Task GetPageAsync()
        {
            // Snippet: GetPageAsync(string, CallSettings)
            // Additional: GetPageAsync(string, CancellationToken)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/pages/[PAGE]";
            // Make the request
            Page response = await pagesClient.GetPageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPage</summary>
        public void GetPageResourceNames()
        {
            // Snippet: GetPage(PageName, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            PageName name = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]");
            // Make the request
            Page response = pagesClient.GetPage(name);
            // End snippet
        }

        /// <summary>Snippet for GetPageAsync</summary>
        public async Task GetPageResourceNamesAsync()
        {
            // Snippet: GetPageAsync(PageName, CallSettings)
            // Additional: GetPageAsync(PageName, CancellationToken)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            PageName name = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]");
            // Make the request
            Page response = await pagesClient.GetPageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreatePage</summary>
        public void CreatePageRequestObject()
        {
            // Snippet: CreatePage(CreatePageRequest, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            CreatePageRequest request = new CreatePageRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Page = new Page(),
                LanguageCode = "",
            };
            // Make the request
            Page response = pagesClient.CreatePage(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePageAsync</summary>
        public async Task CreatePageRequestObjectAsync()
        {
            // Snippet: CreatePageAsync(CreatePageRequest, CallSettings)
            // Additional: CreatePageAsync(CreatePageRequest, CancellationToken)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            CreatePageRequest request = new CreatePageRequest
            {
                ParentAsFlowName = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]"),
                Page = new Page(),
                LanguageCode = "",
            };
            // Make the request
            Page response = await pagesClient.CreatePageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePage</summary>
        public void CreatePage()
        {
            // Snippet: CreatePage(string, Page, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            Page page = new Page();
            // Make the request
            Page response = pagesClient.CreatePage(parent, page);
            // End snippet
        }

        /// <summary>Snippet for CreatePageAsync</summary>
        public async Task CreatePageAsync()
        {
            // Snippet: CreatePageAsync(string, Page, CallSettings)
            // Additional: CreatePageAsync(string, Page, CancellationToken)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]";
            Page page = new Page();
            // Make the request
            Page response = await pagesClient.CreatePageAsync(parent, page);
            // End snippet
        }

        /// <summary>Snippet for CreatePage</summary>
        public void CreatePageResourceNames()
        {
            // Snippet: CreatePage(FlowName, Page, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            FlowName parent = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            Page page = new Page();
            // Make the request
            Page response = pagesClient.CreatePage(parent, page);
            // End snippet
        }

        /// <summary>Snippet for CreatePageAsync</summary>
        public async Task CreatePageResourceNamesAsync()
        {
            // Snippet: CreatePageAsync(FlowName, Page, CallSettings)
            // Additional: CreatePageAsync(FlowName, Page, CancellationToken)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            FlowName parent = FlowName.FromProjectLocationAgentFlow("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]");
            Page page = new Page();
            // Make the request
            Page response = await pagesClient.CreatePageAsync(parent, page);
            // End snippet
        }

        /// <summary>Snippet for UpdatePage</summary>
        public void UpdatePageRequestObject()
        {
            // Snippet: UpdatePage(UpdatePageRequest, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            UpdatePageRequest request = new UpdatePageRequest
            {
                Page = new Page(),
                LanguageCode = "",
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Page response = pagesClient.UpdatePage(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePageAsync</summary>
        public async Task UpdatePageRequestObjectAsync()
        {
            // Snippet: UpdatePageAsync(UpdatePageRequest, CallSettings)
            // Additional: UpdatePageAsync(UpdatePageRequest, CancellationToken)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePageRequest request = new UpdatePageRequest
            {
                Page = new Page(),
                LanguageCode = "",
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Page response = await pagesClient.UpdatePageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePage</summary>
        public void UpdatePage()
        {
            // Snippet: UpdatePage(Page, FieldMask, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            Page page = new Page();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Page response = pagesClient.UpdatePage(page, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePageAsync</summary>
        public async Task UpdatePageAsync()
        {
            // Snippet: UpdatePageAsync(Page, FieldMask, CallSettings)
            // Additional: UpdatePageAsync(Page, FieldMask, CancellationToken)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            Page page = new Page();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Page response = await pagesClient.UpdatePageAsync(page, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeletePage</summary>
        public void DeletePageRequestObject()
        {
            // Snippet: DeletePage(DeletePageRequest, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            DeletePageRequest request = new DeletePageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                Force = false,
            };
            // Make the request
            pagesClient.DeletePage(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePageAsync</summary>
        public async Task DeletePageRequestObjectAsync()
        {
            // Snippet: DeletePageAsync(DeletePageRequest, CallSettings)
            // Additional: DeletePageAsync(DeletePageRequest, CancellationToken)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            DeletePageRequest request = new DeletePageRequest
            {
                PageName = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]"),
                Force = false,
            };
            // Make the request
            await pagesClient.DeletePageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePage</summary>
        public void DeletePage()
        {
            // Snippet: DeletePage(string, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/pages/[PAGE]";
            // Make the request
            pagesClient.DeletePage(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePageAsync</summary>
        public async Task DeletePageAsync()
        {
            // Snippet: DeletePageAsync(string, CallSettings)
            // Additional: DeletePageAsync(string, CancellationToken)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/agents/[AGENT]/flows/[FLOW]/pages/[PAGE]";
            // Make the request
            await pagesClient.DeletePageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePage</summary>
        public void DeletePageResourceNames()
        {
            // Snippet: DeletePage(PageName, CallSettings)
            // Create client
            PagesClient pagesClient = PagesClient.Create();
            // Initialize request argument(s)
            PageName name = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]");
            // Make the request
            pagesClient.DeletePage(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePageAsync</summary>
        public async Task DeletePageResourceNamesAsync()
        {
            // Snippet: DeletePageAsync(PageName, CallSettings)
            // Additional: DeletePageAsync(PageName, CancellationToken)
            // Create client
            PagesClient pagesClient = await PagesClient.CreateAsync();
            // Initialize request argument(s)
            PageName name = PageName.FromProjectLocationAgentFlowPage("[PROJECT]", "[LOCATION]", "[AGENT]", "[FLOW]", "[PAGE]");
            // Make the request
            await pagesClient.DeletePageAsync(name);
            // End snippet
        }
    }
}
