// Copyright 2020 Google LLC
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

namespace Google.Cloud.Dialogflow.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedContextsClientSnippets
    {
        /// <summary>Snippet for ListContexts</summary>
        public void ListContexts_RequestObject()
        {
            // Snippet: ListContexts(ListContextsRequest, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            ListContextsRequest request = new ListContextsRequest { Parent = "", };
            // Make the request
            PagedEnumerable<ListContextsResponse, Context> response = contextsClient.ListContexts(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Context item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContextsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Context item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Context> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Context item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContexts</summary>
        public async Task ListContextsAsync_RequestObject()
        {
            // Snippet: ListContextsAsync(ListContextsRequest, CallSettings)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            ListContextsRequest request = new ListContextsRequest { Parent = "", };
            // Make the request
            PagedAsyncEnumerable<ListContextsResponse, Context> response = contextsClient.ListContextsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Context item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContextsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Context item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Context> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Context item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContexts</summary>
        public void ListContexts()
        {
            // Snippet: ListContexts(string, string, int?, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListContextsResponse, Context> response = contextsClient.ListContexts(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Context item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListContextsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Context item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Context> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Context item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListContexts</summary>
        public async Task ListContextsAsync()
        {
            // Snippet: ListContextsAsync(string, string, int?, CallSettings)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListContextsResponse, Context> response = contextsClient.ListContextsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Context item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListContextsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Context item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Context> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Context item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetContext</summary>
        public void GetContext_RequestObject()
        {
            // Snippet: GetContext(GetContextRequest, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            // Make the request
            Context response = contextsClient.GetContext(request);
            // End snippet
        }

        /// <summary>Snippet for GetContextAsync</summary>
        public async Task GetContextAsync_RequestObject()
        {
            // Snippet: GetContextAsync(GetContextRequest, CallSettings)
            // Additional: GetContextAsync(GetContextRequest, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            GetContextRequest request = new GetContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            // Make the request
            Context response = await contextsClient.GetContextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateContext</summary>
        public void CreateContext_RequestObject()
        {
            // Snippet: CreateContext(CreateContextRequest, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            CreateContextRequest request = new CreateContextRequest
            {
                Parent = "",
                Context = new Context(),
            };
            // Make the request
            Context response = contextsClient.CreateContext(request);
            // End snippet
        }

        /// <summary>Snippet for CreateContextAsync</summary>
        public async Task CreateContextAsync_RequestObject()
        {
            // Snippet: CreateContextAsync(CreateContextRequest, CallSettings)
            // Additional: CreateContextAsync(CreateContextRequest, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            CreateContextRequest request = new CreateContextRequest
            {
                Parent = "",
                Context = new Context(),
            };
            // Make the request
            Context response = await contextsClient.CreateContextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateContext</summary>
        public void UpdateContext_RequestObject()
        {
            // Snippet: UpdateContext(UpdateContextRequest, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Context response = contextsClient.UpdateContext(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateContextAsync</summary>
        public async Task UpdateContextAsync_RequestObject()
        {
            // Snippet: UpdateContextAsync(UpdateContextRequest, CallSettings)
            // Additional: UpdateContextAsync(UpdateContextRequest, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateContextRequest request = new UpdateContextRequest
            {
                Context = new Context(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Context response = await contextsClient.UpdateContextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteContext</summary>
        public void DeleteContext_RequestObject()
        {
            // Snippet: DeleteContext(DeleteContextRequest, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            DeleteContextRequest request = new DeleteContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            // Make the request
            contextsClient.DeleteContext(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteContextAsync</summary>
        public async Task DeleteContextAsync_RequestObject()
        {
            // Snippet: DeleteContextAsync(DeleteContextRequest, CallSettings)
            // Additional: DeleteContextAsync(DeleteContextRequest, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteContextRequest request = new DeleteContextRequest
            {
                ContextName = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]"),
            };
            // Make the request
            await contextsClient.DeleteContextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAllContexts</summary>
        public void DeleteAllContexts_RequestObject()
        {
            // Snippet: DeleteAllContexts(DeleteAllContextsRequest, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            DeleteAllContextsRequest request = new DeleteAllContextsRequest { Parent = "", };
            // Make the request
            contextsClient.DeleteAllContexts(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAllContextsAsync</summary>
        public async Task DeleteAllContextsAsync_RequestObject()
        {
            // Snippet: DeleteAllContextsAsync(DeleteAllContextsRequest, CallSettings)
            // Additional: DeleteAllContextsAsync(DeleteAllContextsRequest, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAllContextsRequest request = new DeleteAllContextsRequest { Parent = "", };
            // Make the request
            await contextsClient.DeleteAllContextsAsync(request);
            // End snippet
        }
    }
}
