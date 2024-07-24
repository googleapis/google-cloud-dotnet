// Copyright 2024 Google LLC
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
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedContextsClientSnippets
    {
        /// <summary>Snippet for ListContexts</summary>
        public void ListContextsRequestObject()
        {
            // Snippet: ListContexts(ListContextsRequest, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            ListContextsRequest request = new ListContextsRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
            };
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

        /// <summary>Snippet for ListContextsAsync</summary>
        public async Task ListContextsRequestObjectAsync()
        {
            // Snippet: ListContextsAsync(ListContextsRequest, CallSettings)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            ListContextsRequest request = new ListContextsRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
            };
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
            string parent = "projects/[PROJECT]/agent/sessions/[SESSION]";
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

        /// <summary>Snippet for ListContextsAsync</summary>
        public async Task ListContextsAsync()
        {
            // Snippet: ListContextsAsync(string, string, int?, CallSettings)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/sessions/[SESSION]";
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

        /// <summary>Snippet for ListContexts</summary>
        public void ListContextsResourceNames()
        {
            // Snippet: ListContexts(SessionName, string, int?, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
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

        /// <summary>Snippet for ListContextsAsync</summary>
        public async Task ListContextsResourceNamesAsync()
        {
            // Snippet: ListContextsAsync(SessionName, string, int?, CallSettings)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
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
        public void GetContextRequestObject()
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
        public async Task GetContextRequestObjectAsync()
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

        /// <summary>Snippet for GetContext</summary>
        public void GetContext()
        {
            // Snippet: GetContext(string, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/sessions/[SESSION]/contexts/[CONTEXT]";
            // Make the request
            Context response = contextsClient.GetContext(name);
            // End snippet
        }

        /// <summary>Snippet for GetContextAsync</summary>
        public async Task GetContextAsync()
        {
            // Snippet: GetContextAsync(string, CallSettings)
            // Additional: GetContextAsync(string, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/sessions/[SESSION]/contexts/[CONTEXT]";
            // Make the request
            Context response = await contextsClient.GetContextAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetContext</summary>
        public void GetContextResourceNames()
        {
            // Snippet: GetContext(ContextName, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            ContextName name = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]");
            // Make the request
            Context response = contextsClient.GetContext(name);
            // End snippet
        }

        /// <summary>Snippet for GetContextAsync</summary>
        public async Task GetContextResourceNamesAsync()
        {
            // Snippet: GetContextAsync(ContextName, CallSettings)
            // Additional: GetContextAsync(ContextName, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            ContextName name = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]");
            // Make the request
            Context response = await contextsClient.GetContextAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateContext</summary>
        public void CreateContextRequestObject()
        {
            // Snippet: CreateContext(CreateContextRequest, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                Context = new Context(),
            };
            // Make the request
            Context response = contextsClient.CreateContext(request);
            // End snippet
        }

        /// <summary>Snippet for CreateContextAsync</summary>
        public async Task CreateContextRequestObjectAsync()
        {
            // Snippet: CreateContextAsync(CreateContextRequest, CallSettings)
            // Additional: CreateContextAsync(CreateContextRequest, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            CreateContextRequest request = new CreateContextRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                Context = new Context(),
            };
            // Make the request
            Context response = await contextsClient.CreateContextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateContext</summary>
        public void CreateContext()
        {
            // Snippet: CreateContext(string, Context, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/sessions/[SESSION]";
            Context context = new Context();
            // Make the request
            Context response = contextsClient.CreateContext(parent, context);
            // End snippet
        }

        /// <summary>Snippet for CreateContextAsync</summary>
        public async Task CreateContextAsync()
        {
            // Snippet: CreateContextAsync(string, Context, CallSettings)
            // Additional: CreateContextAsync(string, Context, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/sessions/[SESSION]";
            Context context = new Context();
            // Make the request
            Context response = await contextsClient.CreateContextAsync(parent, context);
            // End snippet
        }

        /// <summary>Snippet for CreateContext</summary>
        public void CreateContextResourceNames()
        {
            // Snippet: CreateContext(SessionName, Context, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
            Context context = new Context();
            // Make the request
            Context response = contextsClient.CreateContext(parent, context);
            // End snippet
        }

        /// <summary>Snippet for CreateContextAsync</summary>
        public async Task CreateContextResourceNamesAsync()
        {
            // Snippet: CreateContextAsync(SessionName, Context, CallSettings)
            // Additional: CreateContextAsync(SessionName, Context, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
            Context context = new Context();
            // Make the request
            Context response = await contextsClient.CreateContextAsync(parent, context);
            // End snippet
        }

        /// <summary>Snippet for UpdateContext</summary>
        public void UpdateContextRequestObject()
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
        public async Task UpdateContextRequestObjectAsync()
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

        /// <summary>Snippet for UpdateContext</summary>
        public void UpdateContext1()
        {
            // Snippet: UpdateContext(Context, FieldMask, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            Context context = new Context();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Context response = contextsClient.UpdateContext(context, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateContextAsync</summary>
        public async Task UpdateContext1Async()
        {
            // Snippet: UpdateContextAsync(Context, FieldMask, CallSettings)
            // Additional: UpdateContextAsync(Context, FieldMask, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            Context context = new Context();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Context response = await contextsClient.UpdateContextAsync(context, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateContext</summary>
        public void UpdateContext2()
        {
            // Snippet: UpdateContext(Context, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            Context context = new Context();
            // Make the request
            Context response = contextsClient.UpdateContext(context);
            // End snippet
        }

        /// <summary>Snippet for UpdateContextAsync</summary>
        public async Task UpdateContext2Async()
        {
            // Snippet: UpdateContextAsync(Context, CallSettings)
            // Additional: UpdateContextAsync(Context, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            Context context = new Context();
            // Make the request
            Context response = await contextsClient.UpdateContextAsync(context);
            // End snippet
        }

        /// <summary>Snippet for DeleteContext</summary>
        public void DeleteContextRequestObject()
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
        public async Task DeleteContextRequestObjectAsync()
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

        /// <summary>Snippet for DeleteContext</summary>
        public void DeleteContext()
        {
            // Snippet: DeleteContext(string, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/sessions/[SESSION]/contexts/[CONTEXT]";
            // Make the request
            contextsClient.DeleteContext(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteContextAsync</summary>
        public async Task DeleteContextAsync()
        {
            // Snippet: DeleteContextAsync(string, CallSettings)
            // Additional: DeleteContextAsync(string, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/sessions/[SESSION]/contexts/[CONTEXT]";
            // Make the request
            await contextsClient.DeleteContextAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteContext</summary>
        public void DeleteContextResourceNames()
        {
            // Snippet: DeleteContext(ContextName, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            ContextName name = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]");
            // Make the request
            contextsClient.DeleteContext(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteContextAsync</summary>
        public async Task DeleteContextResourceNamesAsync()
        {
            // Snippet: DeleteContextAsync(ContextName, CallSettings)
            // Additional: DeleteContextAsync(ContextName, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            ContextName name = ContextName.FromProjectSessionContext("[PROJECT]", "[SESSION]", "[CONTEXT]");
            // Make the request
            await contextsClient.DeleteContextAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAllContexts</summary>
        public void DeleteAllContextsRequestObject()
        {
            // Snippet: DeleteAllContexts(DeleteAllContextsRequest, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            DeleteAllContextsRequest request = new DeleteAllContextsRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
            };
            // Make the request
            contextsClient.DeleteAllContexts(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAllContextsAsync</summary>
        public async Task DeleteAllContextsRequestObjectAsync()
        {
            // Snippet: DeleteAllContextsAsync(DeleteAllContextsRequest, CallSettings)
            // Additional: DeleteAllContextsAsync(DeleteAllContextsRequest, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAllContextsRequest request = new DeleteAllContextsRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
            };
            // Make the request
            await contextsClient.DeleteAllContextsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAllContexts</summary>
        public void DeleteAllContexts()
        {
            // Snippet: DeleteAllContexts(string, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/sessions/[SESSION]";
            // Make the request
            contextsClient.DeleteAllContexts(parent);
            // End snippet
        }

        /// <summary>Snippet for DeleteAllContextsAsync</summary>
        public async Task DeleteAllContextsAsync()
        {
            // Snippet: DeleteAllContextsAsync(string, CallSettings)
            // Additional: DeleteAllContextsAsync(string, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/sessions/[SESSION]";
            // Make the request
            await contextsClient.DeleteAllContextsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for DeleteAllContexts</summary>
        public void DeleteAllContextsResourceNames()
        {
            // Snippet: DeleteAllContexts(SessionName, CallSettings)
            // Create client
            ContextsClient contextsClient = ContextsClient.Create();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
            // Make the request
            contextsClient.DeleteAllContexts(parent);
            // End snippet
        }

        /// <summary>Snippet for DeleteAllContextsAsync</summary>
        public async Task DeleteAllContextsResourceNamesAsync()
        {
            // Snippet: DeleteAllContextsAsync(SessionName, CallSettings)
            // Additional: DeleteAllContextsAsync(SessionName, CancellationToken)
            // Create client
            ContextsClient contextsClient = await ContextsClient.CreateAsync();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
            // Make the request
            await contextsClient.DeleteAllContextsAsync(parent);
            // End snippet
        }
    }
}
