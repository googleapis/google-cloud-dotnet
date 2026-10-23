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
    using Google.Cloud.Ces.V1Beta;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAssistantServiceClientSnippets
    {
        /// <summary>Snippet for ListAssistantSessions</summary>
        public void ListAssistantSessionsRequestObject()
        {
            // Snippet: ListAssistantSessions(ListAssistantSessionsRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            ListAssistantSessionsRequest request = new ListAssistantSessionsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAssistantSessionsResponse, AssistantSession> response = assistantServiceClient.ListAssistantSessions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AssistantSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssistantSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AssistantSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AssistantSession> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AssistantSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssistantSessionsAsync</summary>
        public async Task ListAssistantSessionsRequestObjectAsync()
        {
            // Snippet: ListAssistantSessionsAsync(ListAssistantSessionsRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListAssistantSessionsRequest request = new ListAssistantSessionsRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAssistantSessionsResponse, AssistantSession> response = assistantServiceClient.ListAssistantSessionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AssistantSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAssistantSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AssistantSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AssistantSession> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AssistantSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssistantSessions</summary>
        public void ListAssistantSessions()
        {
            // Snippet: ListAssistantSessions(string, string, int?, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedEnumerable<ListAssistantSessionsResponse, AssistantSession> response = assistantServiceClient.ListAssistantSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AssistantSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssistantSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AssistantSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AssistantSession> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AssistantSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssistantSessionsAsync</summary>
        public async Task ListAssistantSessionsAsync()
        {
            // Snippet: ListAssistantSessionsAsync(string, string, int?, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            // Make the request
            PagedAsyncEnumerable<ListAssistantSessionsResponse, AssistantSession> response = assistantServiceClient.ListAssistantSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AssistantSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAssistantSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AssistantSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AssistantSession> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AssistantSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssistantSessions</summary>
        public void ListAssistantSessionsResourceNames()
        {
            // Snippet: ListAssistantSessions(AppName, string, int?, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedEnumerable<ListAssistantSessionsResponse, AssistantSession> response = assistantServiceClient.ListAssistantSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AssistantSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAssistantSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AssistantSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AssistantSession> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AssistantSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAssistantSessionsAsync</summary>
        public async Task ListAssistantSessionsResourceNamesAsync()
        {
            // Snippet: ListAssistantSessionsAsync(AppName, string, int?, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            // Make the request
            PagedAsyncEnumerable<ListAssistantSessionsResponse, AssistantSession> response = assistantServiceClient.ListAssistantSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (AssistantSession item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListAssistantSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AssistantSession item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AssistantSession> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AssistantSession item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAssistantSession</summary>
        public void GetAssistantSessionRequestObject()
        {
            // Snippet: GetAssistantSession(GetAssistantSessionRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            GetAssistantSessionRequest request = new GetAssistantSessionRequest
            {
                AssistantSessionName = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]"),
            };
            // Make the request
            AssistantSession response = assistantServiceClient.GetAssistantSession(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssistantSessionAsync</summary>
        public async Task GetAssistantSessionRequestObjectAsync()
        {
            // Snippet: GetAssistantSessionAsync(GetAssistantSessionRequest, CallSettings)
            // Additional: GetAssistantSessionAsync(GetAssistantSessionRequest, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAssistantSessionRequest request = new GetAssistantSessionRequest
            {
                AssistantSessionName = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]"),
            };
            // Make the request
            AssistantSession response = await assistantServiceClient.GetAssistantSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAssistantSession</summary>
        public void GetAssistantSession()
        {
            // Snippet: GetAssistantSession(string, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/assistantSessions/[ASSISTANT_SESSION]";
            // Make the request
            AssistantSession response = assistantServiceClient.GetAssistantSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssistantSessionAsync</summary>
        public async Task GetAssistantSessionAsync()
        {
            // Snippet: GetAssistantSessionAsync(string, CallSettings)
            // Additional: GetAssistantSessionAsync(string, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/assistantSessions/[ASSISTANT_SESSION]";
            // Make the request
            AssistantSession response = await assistantServiceClient.GetAssistantSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssistantSession</summary>
        public void GetAssistantSessionResourceNames()
        {
            // Snippet: GetAssistantSession(AssistantSessionName, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            AssistantSessionName name = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]");
            // Make the request
            AssistantSession response = assistantServiceClient.GetAssistantSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetAssistantSessionAsync</summary>
        public async Task GetAssistantSessionResourceNamesAsync()
        {
            // Snippet: GetAssistantSessionAsync(AssistantSessionName, CallSettings)
            // Additional: GetAssistantSessionAsync(AssistantSessionName, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssistantSessionName name = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]");
            // Make the request
            AssistantSession response = await assistantServiceClient.GetAssistantSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAssistantSession</summary>
        public void CreateAssistantSessionRequestObject()
        {
            // Snippet: CreateAssistantSession(CreateAssistantSessionRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            CreateAssistantSessionRequest request = new CreateAssistantSessionRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                AssistantSessionId = "",
                AssistantSessionMessages =
                {
                    new AssistantMessage(),
                },
            };
            // Make the request
            AssistantSession response = assistantServiceClient.CreateAssistantSession(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssistantSessionAsync</summary>
        public async Task CreateAssistantSessionRequestObjectAsync()
        {
            // Snippet: CreateAssistantSessionAsync(CreateAssistantSessionRequest, CallSettings)
            // Additional: CreateAssistantSessionAsync(CreateAssistantSessionRequest, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateAssistantSessionRequest request = new CreateAssistantSessionRequest
            {
                ParentAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                AssistantSessionId = "",
                AssistantSessionMessages =
                {
                    new AssistantMessage(),
                },
            };
            // Make the request
            AssistantSession response = await assistantServiceClient.CreateAssistantSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateAssistantSession</summary>
        public void CreateAssistantSession()
        {
            // Snippet: CreateAssistantSession(string, string, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            string assistantSessionId = "";
            // Make the request
            AssistantSession response = assistantServiceClient.CreateAssistantSession(parent, assistantSessionId);
            // End snippet
        }

        /// <summary>Snippet for CreateAssistantSessionAsync</summary>
        public async Task CreateAssistantSessionAsync()
        {
            // Snippet: CreateAssistantSessionAsync(string, string, CallSettings)
            // Additional: CreateAssistantSessionAsync(string, string, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]";
            string assistantSessionId = "";
            // Make the request
            AssistantSession response = await assistantServiceClient.CreateAssistantSessionAsync(parent, assistantSessionId);
            // End snippet
        }

        /// <summary>Snippet for CreateAssistantSession</summary>
        public void CreateAssistantSessionResourceNames()
        {
            // Snippet: CreateAssistantSession(AppName, string, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            string assistantSessionId = "";
            // Make the request
            AssistantSession response = assistantServiceClient.CreateAssistantSession(parent, assistantSessionId);
            // End snippet
        }

        /// <summary>Snippet for CreateAssistantSessionAsync</summary>
        public async Task CreateAssistantSessionResourceNamesAsync()
        {
            // Snippet: CreateAssistantSessionAsync(AppName, string, CallSettings)
            // Additional: CreateAssistantSessionAsync(AppName, string, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppName parent = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]");
            string assistantSessionId = "";
            // Make the request
            AssistantSession response = await assistantServiceClient.CreateAssistantSessionAsync(parent, assistantSessionId);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssistantSession</summary>
        public void DeleteAssistantSessionRequestObject()
        {
            // Snippet: DeleteAssistantSession(DeleteAssistantSessionRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            DeleteAssistantSessionRequest request = new DeleteAssistantSessionRequest
            {
                AssistantSessionName = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]"),
            };
            // Make the request
            assistantServiceClient.DeleteAssistantSession(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssistantSessionAsync</summary>
        public async Task DeleteAssistantSessionRequestObjectAsync()
        {
            // Snippet: DeleteAssistantSessionAsync(DeleteAssistantSessionRequest, CallSettings)
            // Additional: DeleteAssistantSessionAsync(DeleteAssistantSessionRequest, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAssistantSessionRequest request = new DeleteAssistantSessionRequest
            {
                AssistantSessionName = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]"),
            };
            // Make the request
            await assistantServiceClient.DeleteAssistantSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssistantSession</summary>
        public void DeleteAssistantSession()
        {
            // Snippet: DeleteAssistantSession(string, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/assistantSessions/[ASSISTANT_SESSION]";
            // Make the request
            assistantServiceClient.DeleteAssistantSession(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssistantSessionAsync</summary>
        public async Task DeleteAssistantSessionAsync()
        {
            // Snippet: DeleteAssistantSessionAsync(string, CallSettings)
            // Additional: DeleteAssistantSessionAsync(string, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/apps/[APP]/assistantSessions/[ASSISTANT_SESSION]";
            // Make the request
            await assistantServiceClient.DeleteAssistantSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssistantSession</summary>
        public void DeleteAssistantSessionResourceNames()
        {
            // Snippet: DeleteAssistantSession(AssistantSessionName, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            AssistantSessionName name = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]");
            // Make the request
            assistantServiceClient.DeleteAssistantSession(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAssistantSessionAsync</summary>
        public async Task DeleteAssistantSessionResourceNamesAsync()
        {
            // Snippet: DeleteAssistantSessionAsync(AssistantSessionName, CallSettings)
            // Additional: DeleteAssistantSessionAsync(AssistantSessionName, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            AssistantSessionName name = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]");
            // Make the request
            await assistantServiceClient.DeleteAssistantSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for RunAssistant</summary>
        public void RunAssistantRequestObject()
        {
            // Snippet: RunAssistant(RunAssistantRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            RunAssistantRequest request = new RunAssistantRequest
            {
                AppAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                AssistantSessionAsAssistantSessionName = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]"),
                Message = new AssistantMessage(),
                InteractionType = RunAssistantRequest.Types.InteractionType.Unspecified,
            };
            // Make the request
            RunAssistantResponse response = assistantServiceClient.RunAssistant(request);
            // End snippet
        }

        /// <summary>Snippet for RunAssistantAsync</summary>
        public async Task RunAssistantRequestObjectAsync()
        {
            // Snippet: RunAssistantAsync(RunAssistantRequest, CallSettings)
            // Additional: RunAssistantAsync(RunAssistantRequest, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            RunAssistantRequest request = new RunAssistantRequest
            {
                AppAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                AssistantSessionAsAssistantSessionName = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]"),
                Message = new AssistantMessage(),
                InteractionType = RunAssistantRequest.Types.InteractionType.Unspecified,
            };
            // Make the request
            RunAssistantResponse response = await assistantServiceClient.RunAssistantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ChatAiAssistant</summary>
        public void ChatAiAssistantRequestObject()
        {
            // Snippet: ChatAiAssistant(ChatAiAssistantRequest, CallSettings)
            // Create client
            AssistantServiceClient assistantServiceClient = AssistantServiceClient.Create();
            // Initialize request argument(s)
            ChatAiAssistantRequest request = new ChatAiAssistantRequest
            {
                AppAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                AssistantSessionAsAssistantSessionName = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]"),
                Message = "",
                AttachedGcsUris = { "", },
                ContextToken = "",
            };
            // Make the request
            ChatAiAssistantResponse response = assistantServiceClient.ChatAiAssistant(request);
            // End snippet
        }

        /// <summary>Snippet for ChatAiAssistantAsync</summary>
        public async Task ChatAiAssistantRequestObjectAsync()
        {
            // Snippet: ChatAiAssistantAsync(ChatAiAssistantRequest, CallSettings)
            // Additional: ChatAiAssistantAsync(ChatAiAssistantRequest, CancellationToken)
            // Create client
            AssistantServiceClient assistantServiceClient = await AssistantServiceClient.CreateAsync();
            // Initialize request argument(s)
            ChatAiAssistantRequest request = new ChatAiAssistantRequest
            {
                AppAsAppName = AppName.FromProjectLocationApp("[PROJECT]", "[LOCATION]", "[APP]"),
                AssistantSessionAsAssistantSessionName = AssistantSessionName.FromProjectLocationAppAssistantSession("[PROJECT]", "[LOCATION]", "[APP]", "[ASSISTANT_SESSION]"),
                Message = "",
                AttachedGcsUris = { "", },
                ContextToken = "",
            };
            // Make the request
            ChatAiAssistantResponse response = await assistantServiceClient.ChatAiAssistantAsync(request);
            // End snippet
        }
    }
}
