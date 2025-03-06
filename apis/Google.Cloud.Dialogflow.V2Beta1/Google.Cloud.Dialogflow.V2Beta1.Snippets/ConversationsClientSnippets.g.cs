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
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConversationsClientSnippets
    {
        /// <summary>Snippet for CreateConversation</summary>
        public void CreateConversationRequestObject()
        {
            // Snippet: CreateConversation(CreateConversationRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Conversation = new Conversation(),
                ConversationId = "",
            };
            // Make the request
            Conversation response = conversationsClient.CreateConversation(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationAsync</summary>
        public async Task CreateConversationRequestObjectAsync()
        {
            // Snippet: CreateConversationAsync(CreateConversationRequest, CallSettings)
            // Additional: CreateConversationAsync(CreateConversationRequest, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Conversation = new Conversation(),
                ConversationId = "",
            };
            // Make the request
            Conversation response = await conversationsClient.CreateConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConversation</summary>
        public void CreateConversation()
        {
            // Snippet: CreateConversation(string, Conversation, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Conversation conversation = new Conversation();
            // Make the request
            Conversation response = conversationsClient.CreateConversation(parent, conversation);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationAsync</summary>
        public async Task CreateConversationAsync()
        {
            // Snippet: CreateConversationAsync(string, Conversation, CallSettings)
            // Additional: CreateConversationAsync(string, Conversation, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            Conversation conversation = new Conversation();
            // Make the request
            Conversation response = await conversationsClient.CreateConversationAsync(parent, conversation);
            // End snippet
        }

        /// <summary>Snippet for CreateConversation</summary>
        public void CreateConversationResourceNames1()
        {
            // Snippet: CreateConversation(ProjectName, Conversation, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Conversation conversation = new Conversation();
            // Make the request
            Conversation response = conversationsClient.CreateConversation(parent, conversation);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationAsync</summary>
        public async Task CreateConversationResourceNames1Async()
        {
            // Snippet: CreateConversationAsync(ProjectName, Conversation, CallSettings)
            // Additional: CreateConversationAsync(ProjectName, Conversation, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            Conversation conversation = new Conversation();
            // Make the request
            Conversation response = await conversationsClient.CreateConversationAsync(parent, conversation);
            // End snippet
        }

        /// <summary>Snippet for CreateConversation</summary>
        public void CreateConversationResourceNames2()
        {
            // Snippet: CreateConversation(LocationName, Conversation, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Conversation conversation = new Conversation();
            // Make the request
            Conversation response = conversationsClient.CreateConversation(parent, conversation);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationAsync</summary>
        public async Task CreateConversationResourceNames2Async()
        {
            // Snippet: CreateConversationAsync(LocationName, Conversation, CallSettings)
            // Additional: CreateConversationAsync(LocationName, Conversation, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Conversation conversation = new Conversation();
            // Make the request
            Conversation response = await conversationsClient.CreateConversationAsync(parent, conversation);
            // End snippet
        }

        /// <summary>Snippet for ListConversations</summary>
        public void ListConversationsRequestObject()
        {
            // Snippet: ListConversations(ListConversationsRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = conversationsClient.ListConversations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Conversation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationsAsync</summary>
        public async Task ListConversationsRequestObjectAsync()
        {
            // Snippet: ListConversationsAsync(ListConversationsRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = conversationsClient.ListConversationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Conversation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversations</summary>
        public void ListConversations()
        {
            // Snippet: ListConversations(string, string, int?, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = conversationsClient.ListConversations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Conversation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationsAsync</summary>
        public async Task ListConversationsAsync()
        {
            // Snippet: ListConversationsAsync(string, string, int?, CallSettings)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = conversationsClient.ListConversationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Conversation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversations</summary>
        public void ListConversationsResourceNames1()
        {
            // Snippet: ListConversations(ProjectName, string, int?, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = conversationsClient.ListConversations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Conversation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationsAsync</summary>
        public async Task ListConversationsResourceNames1Async()
        {
            // Snippet: ListConversationsAsync(ProjectName, string, int?, CallSettings)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = conversationsClient.ListConversationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Conversation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversations</summary>
        public void ListConversationsResourceNames2()
        {
            // Snippet: ListConversations(LocationName, string, int?, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = conversationsClient.ListConversations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Conversation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationsAsync</summary>
        public async Task ListConversationsResourceNames2Async()
        {
            // Snippet: ListConversationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = conversationsClient.ListConversationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Conversation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Conversation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Conversation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Conversation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetConversation</summary>
        public void GetConversationRequestObject()
        {
            // Snippet: GetConversation(GetConversationRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            // Make the request
            Conversation response = conversationsClient.GetConversation(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversationAsync</summary>
        public async Task GetConversationRequestObjectAsync()
        {
            // Snippet: GetConversationAsync(GetConversationRequest, CallSettings)
            // Additional: GetConversationAsync(GetConversationRequest, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            // Make the request
            Conversation response = await conversationsClient.GetConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversation</summary>
        public void GetConversation()
        {
            // Snippet: GetConversation(string, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/conversations/[CONVERSATION]";
            // Make the request
            Conversation response = conversationsClient.GetConversation(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationAsync</summary>
        public async Task GetConversationAsync()
        {
            // Snippet: GetConversationAsync(string, CallSettings)
            // Additional: GetConversationAsync(string, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/conversations/[CONVERSATION]";
            // Make the request
            Conversation response = await conversationsClient.GetConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversation</summary>
        public void GetConversationResourceNames()
        {
            // Snippet: GetConversation(ConversationName, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            // Make the request
            Conversation response = conversationsClient.GetConversation(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationAsync</summary>
        public async Task GetConversationResourceNamesAsync()
        {
            // Snippet: GetConversationAsync(ConversationName, CallSettings)
            // Additional: GetConversationAsync(ConversationName, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            // Make the request
            Conversation response = await conversationsClient.GetConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CompleteConversation</summary>
        public void CompleteConversationRequestObject()
        {
            // Snippet: CompleteConversation(CompleteConversationRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            CompleteConversationRequest request = new CompleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            // Make the request
            Conversation response = conversationsClient.CompleteConversation(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteConversationAsync</summary>
        public async Task CompleteConversationRequestObjectAsync()
        {
            // Snippet: CompleteConversationAsync(CompleteConversationRequest, CallSettings)
            // Additional: CompleteConversationAsync(CompleteConversationRequest, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            CompleteConversationRequest request = new CompleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            // Make the request
            Conversation response = await conversationsClient.CompleteConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteConversation</summary>
        public void CompleteConversation()
        {
            // Snippet: CompleteConversation(string, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/conversations/[CONVERSATION]";
            // Make the request
            Conversation response = conversationsClient.CompleteConversation(name);
            // End snippet
        }

        /// <summary>Snippet for CompleteConversationAsync</summary>
        public async Task CompleteConversationAsync()
        {
            // Snippet: CompleteConversationAsync(string, CallSettings)
            // Additional: CompleteConversationAsync(string, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/conversations/[CONVERSATION]";
            // Make the request
            Conversation response = await conversationsClient.CompleteConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CompleteConversation</summary>
        public void CompleteConversationResourceNames()
        {
            // Snippet: CompleteConversation(ConversationName, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            // Make the request
            Conversation response = conversationsClient.CompleteConversation(name);
            // End snippet
        }

        /// <summary>Snippet for CompleteConversationAsync</summary>
        public async Task CompleteConversationResourceNamesAsync()
        {
            // Snippet: CompleteConversationAsync(ConversationName, CallSettings)
            // Additional: CompleteConversationAsync(ConversationName, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            // Make the request
            Conversation response = await conversationsClient.CompleteConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for IngestContextReferences</summary>
        public void IngestContextReferencesRequestObject()
        {
            // Snippet: IngestContextReferences(IngestContextReferencesRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            IngestContextReferencesRequest request = new IngestContextReferencesRequest
            {
                ConversationAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                ContextReferences =
                {
                    {
                        "",
                        new Conversation.Types.ContextReference()
                    },
                },
            };
            // Make the request
            IngestContextReferencesResponse response = conversationsClient.IngestContextReferences(request);
            // End snippet
        }

        /// <summary>Snippet for IngestContextReferencesAsync</summary>
        public async Task IngestContextReferencesRequestObjectAsync()
        {
            // Snippet: IngestContextReferencesAsync(IngestContextReferencesRequest, CallSettings)
            // Additional: IngestContextReferencesAsync(IngestContextReferencesRequest, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            IngestContextReferencesRequest request = new IngestContextReferencesRequest
            {
                ConversationAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                ContextReferences =
                {
                    {
                        "",
                        new Conversation.Types.ContextReference()
                    },
                },
            };
            // Make the request
            IngestContextReferencesResponse response = await conversationsClient.IngestContextReferencesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for IngestContextReferences</summary>
        public void IngestContextReferences()
        {
            // Snippet: IngestContextReferences(string, IDictionary<string,Conversation.Types.ContextReference>, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            string conversation = "projects/[PROJECT]/conversations/[CONVERSATION]";
            IDictionary<string, Conversation.Types.ContextReference> contextReferences = new Dictionary<string, Conversation.Types.ContextReference>
            {
                {
                    "",
                    new Conversation.Types.ContextReference()
                },
            };
            // Make the request
            IngestContextReferencesResponse response = conversationsClient.IngestContextReferences(conversation, contextReferences);
            // End snippet
        }

        /// <summary>Snippet for IngestContextReferencesAsync</summary>
        public async Task IngestContextReferencesAsync()
        {
            // Snippet: IngestContextReferencesAsync(string, IDictionary<string,Conversation.Types.ContextReference>, CallSettings)
            // Additional: IngestContextReferencesAsync(string, IDictionary<string,Conversation.Types.ContextReference>, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            string conversation = "projects/[PROJECT]/conversations/[CONVERSATION]";
            IDictionary<string, Conversation.Types.ContextReference> contextReferences = new Dictionary<string, Conversation.Types.ContextReference>
            {
                {
                    "",
                    new Conversation.Types.ContextReference()
                },
            };
            // Make the request
            IngestContextReferencesResponse response = await conversationsClient.IngestContextReferencesAsync(conversation, contextReferences);
            // End snippet
        }

        /// <summary>Snippet for IngestContextReferences</summary>
        public void IngestContextReferencesResourceNames()
        {
            // Snippet: IngestContextReferences(ConversationName, IDictionary<string,Conversation.Types.ContextReference>, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            ConversationName conversation = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            IDictionary<string, Conversation.Types.ContextReference> contextReferences = new Dictionary<string, Conversation.Types.ContextReference>
            {
                {
                    "",
                    new Conversation.Types.ContextReference()
                },
            };
            // Make the request
            IngestContextReferencesResponse response = conversationsClient.IngestContextReferences(conversation, contextReferences);
            // End snippet
        }

        /// <summary>Snippet for IngestContextReferencesAsync</summary>
        public async Task IngestContextReferencesResourceNamesAsync()
        {
            // Snippet: IngestContextReferencesAsync(ConversationName, IDictionary<string,Conversation.Types.ContextReference>, CallSettings)
            // Additional: IngestContextReferencesAsync(ConversationName, IDictionary<string,Conversation.Types.ContextReference>, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName conversation = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            IDictionary<string, Conversation.Types.ContextReference> contextReferences = new Dictionary<string, Conversation.Types.ContextReference>
            {
                {
                    "",
                    new Conversation.Types.ContextReference()
                },
            };
            // Make the request
            IngestContextReferencesResponse response = await conversationsClient.IngestContextReferencesAsync(conversation, contextReferences);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateMessages</summary>
        public void BatchCreateMessagesRequestObject()
        {
            // Snippet: BatchCreateMessages(BatchCreateMessagesRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            BatchCreateMessagesRequest request = new BatchCreateMessagesRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                Requests =
                {
                    new CreateMessageRequest(),
                },
            };
            // Make the request
            BatchCreateMessagesResponse response = conversationsClient.BatchCreateMessages(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateMessagesAsync</summary>
        public async Task BatchCreateMessagesRequestObjectAsync()
        {
            // Snippet: BatchCreateMessagesAsync(BatchCreateMessagesRequest, CallSettings)
            // Additional: BatchCreateMessagesAsync(BatchCreateMessagesRequest, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateMessagesRequest request = new BatchCreateMessagesRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                Requests =
                {
                    new CreateMessageRequest(),
                },
            };
            // Make the request
            BatchCreateMessagesResponse response = await conversationsClient.BatchCreateMessagesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateMessages</summary>
        public void BatchCreateMessages()
        {
            // Snippet: BatchCreateMessages(string, IEnumerable<CreateMessageRequest>, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]";
            IEnumerable<CreateMessageRequest> requests = new CreateMessageRequest[]
            {
                new CreateMessageRequest(),
            };
            // Make the request
            BatchCreateMessagesResponse response = conversationsClient.BatchCreateMessages(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateMessagesAsync</summary>
        public async Task BatchCreateMessagesAsync()
        {
            // Snippet: BatchCreateMessagesAsync(string, IEnumerable<CreateMessageRequest>, CallSettings)
            // Additional: BatchCreateMessagesAsync(string, IEnumerable<CreateMessageRequest>, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]";
            IEnumerable<CreateMessageRequest> requests = new CreateMessageRequest[]
            {
                new CreateMessageRequest(),
            };
            // Make the request
            BatchCreateMessagesResponse response = await conversationsClient.BatchCreateMessagesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateMessages</summary>
        public void BatchCreateMessagesResourceNames()
        {
            // Snippet: BatchCreateMessages(ConversationName, IEnumerable<CreateMessageRequest>, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            ConversationName parent = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            IEnumerable<CreateMessageRequest> requests = new CreateMessageRequest[]
            {
                new CreateMessageRequest(),
            };
            // Make the request
            BatchCreateMessagesResponse response = conversationsClient.BatchCreateMessages(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateMessagesAsync</summary>
        public async Task BatchCreateMessagesResourceNamesAsync()
        {
            // Snippet: BatchCreateMessagesAsync(ConversationName, IEnumerable<CreateMessageRequest>, CallSettings)
            // Additional: BatchCreateMessagesAsync(ConversationName, IEnumerable<CreateMessageRequest>, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName parent = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            IEnumerable<CreateMessageRequest> requests = new CreateMessageRequest[]
            {
                new CreateMessageRequest(),
            };
            // Make the request
            BatchCreateMessagesResponse response = await conversationsClient.BatchCreateMessagesAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for ListMessages</summary>
        public void ListMessagesRequestObject()
        {
            // Snippet: ListMessages(ListMessagesRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            ListMessagesRequest request = new ListMessagesRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListMessagesResponse, Message> response = conversationsClient.ListMessages(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Message item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMessagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Message item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Message> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Message item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessagesAsync</summary>
        public async Task ListMessagesRequestObjectAsync()
        {
            // Snippet: ListMessagesAsync(ListMessagesRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            ListMessagesRequest request = new ListMessagesRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListMessagesResponse, Message> response = conversationsClient.ListMessagesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Message item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMessagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Message item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Message> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Message item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessages</summary>
        public void ListMessages()
        {
            // Snippet: ListMessages(string, string, int?, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]";
            // Make the request
            PagedEnumerable<ListMessagesResponse, Message> response = conversationsClient.ListMessages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Message item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMessagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Message item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Message> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Message item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessagesAsync</summary>
        public async Task ListMessagesAsync()
        {
            // Snippet: ListMessagesAsync(string, string, int?, CallSettings)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]";
            // Make the request
            PagedAsyncEnumerable<ListMessagesResponse, Message> response = conversationsClient.ListMessagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Message item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMessagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Message item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Message> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Message item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessages</summary>
        public void ListMessagesResourceNames()
        {
            // Snippet: ListMessages(ConversationName, string, int?, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            ConversationName parent = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            // Make the request
            PagedEnumerable<ListMessagesResponse, Message> response = conversationsClient.ListMessages(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Message item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMessagesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Message item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Message> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Message item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMessagesAsync</summary>
        public async Task ListMessagesResourceNamesAsync()
        {
            // Snippet: ListMessagesAsync(ConversationName, string, int?, CallSettings)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName parent = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            // Make the request
            PagedAsyncEnumerable<ListMessagesResponse, Message> response = conversationsClient.ListMessagesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Message item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMessagesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Message item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Message> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Message item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for SuggestConversationSummary</summary>
        public void SuggestConversationSummaryRequestObject()
        {
            // Snippet: SuggestConversationSummary(SuggestConversationSummaryRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            SuggestConversationSummaryRequest request = new SuggestConversationSummaryRequest
            {
                ConversationAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 0,
                AssistQueryParams = new AssistQueryParameters(),
            };
            // Make the request
            SuggestConversationSummaryResponse response = conversationsClient.SuggestConversationSummary(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestConversationSummaryAsync</summary>
        public async Task SuggestConversationSummaryRequestObjectAsync()
        {
            // Snippet: SuggestConversationSummaryAsync(SuggestConversationSummaryRequest, CallSettings)
            // Additional: SuggestConversationSummaryAsync(SuggestConversationSummaryRequest, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            SuggestConversationSummaryRequest request = new SuggestConversationSummaryRequest
            {
                ConversationAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 0,
                AssistQueryParams = new AssistQueryParameters(),
            };
            // Make the request
            SuggestConversationSummaryResponse response = await conversationsClient.SuggestConversationSummaryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestConversationSummary</summary>
        public void SuggestConversationSummary()
        {
            // Snippet: SuggestConversationSummary(string, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            string conversation = "projects/[PROJECT]/conversations/[CONVERSATION]";
            // Make the request
            SuggestConversationSummaryResponse response = conversationsClient.SuggestConversationSummary(conversation);
            // End snippet
        }

        /// <summary>Snippet for SuggestConversationSummaryAsync</summary>
        public async Task SuggestConversationSummaryAsync()
        {
            // Snippet: SuggestConversationSummaryAsync(string, CallSettings)
            // Additional: SuggestConversationSummaryAsync(string, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            string conversation = "projects/[PROJECT]/conversations/[CONVERSATION]";
            // Make the request
            SuggestConversationSummaryResponse response = await conversationsClient.SuggestConversationSummaryAsync(conversation);
            // End snippet
        }

        /// <summary>Snippet for SuggestConversationSummary</summary>
        public void SuggestConversationSummaryResourceNames()
        {
            // Snippet: SuggestConversationSummary(ConversationName, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            ConversationName conversation = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            // Make the request
            SuggestConversationSummaryResponse response = conversationsClient.SuggestConversationSummary(conversation);
            // End snippet
        }

        /// <summary>Snippet for SuggestConversationSummaryAsync</summary>
        public async Task SuggestConversationSummaryResourceNamesAsync()
        {
            // Snippet: SuggestConversationSummaryAsync(ConversationName, CallSettings)
            // Additional: SuggestConversationSummaryAsync(ConversationName, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName conversation = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            // Make the request
            SuggestConversationSummaryResponse response = await conversationsClient.SuggestConversationSummaryAsync(conversation);
            // End snippet
        }

        /// <summary>Snippet for GenerateStatelessSummary</summary>
        public void GenerateStatelessSummaryRequestObject()
        {
            // Snippet: GenerateStatelessSummary(GenerateStatelessSummaryRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            GenerateStatelessSummaryRequest request = new GenerateStatelessSummaryRequest
            {
                StatelessConversation = new GenerateStatelessSummaryRequest.Types.MinimalConversation(),
                ConversationProfile = new ConversationProfile(),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                MaxContextSize = 0,
            };
            // Make the request
            GenerateStatelessSummaryResponse response = conversationsClient.GenerateStatelessSummary(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateStatelessSummaryAsync</summary>
        public async Task GenerateStatelessSummaryRequestObjectAsync()
        {
            // Snippet: GenerateStatelessSummaryAsync(GenerateStatelessSummaryRequest, CallSettings)
            // Additional: GenerateStatelessSummaryAsync(GenerateStatelessSummaryRequest, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            GenerateStatelessSummaryRequest request = new GenerateStatelessSummaryRequest
            {
                StatelessConversation = new GenerateStatelessSummaryRequest.Types.MinimalConversation(),
                ConversationProfile = new ConversationProfile(),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                MaxContextSize = 0,
            };
            // Make the request
            GenerateStatelessSummaryResponse response = await conversationsClient.GenerateStatelessSummaryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateStatelessSuggestion</summary>
        public void GenerateStatelessSuggestionRequestObject()
        {
            // Snippet: GenerateStatelessSuggestion(GenerateStatelessSuggestionRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            GenerateStatelessSuggestionRequest request = new GenerateStatelessSuggestionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Generator = new Generator(),
                ContextReferences =
                {
                    {
                        "",
                        new Conversation.Types.ContextReference()
                    },
                },
                ConversationContext = new ConversationContext(),
                TriggerEvents =
                {
                    TriggerEvent.Unspecified,
                },
            };
            // Make the request
            GenerateStatelessSuggestionResponse response = conversationsClient.GenerateStatelessSuggestion(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateStatelessSuggestionAsync</summary>
        public async Task GenerateStatelessSuggestionRequestObjectAsync()
        {
            // Snippet: GenerateStatelessSuggestionAsync(GenerateStatelessSuggestionRequest, CallSettings)
            // Additional: GenerateStatelessSuggestionAsync(GenerateStatelessSuggestionRequest, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            GenerateStatelessSuggestionRequest request = new GenerateStatelessSuggestionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Generator = new Generator(),
                ContextReferences =
                {
                    {
                        "",
                        new Conversation.Types.ContextReference()
                    },
                },
                ConversationContext = new ConversationContext(),
                TriggerEvents =
                {
                    TriggerEvent.Unspecified,
                },
            };
            // Make the request
            GenerateStatelessSuggestionResponse response = await conversationsClient.GenerateStatelessSuggestionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SearchKnowledge</summary>
        public void SearchKnowledgeRequestObject()
        {
            // Snippet: SearchKnowledge(SearchKnowledgeRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            SearchKnowledgeRequest request = new SearchKnowledgeRequest
            {
                Query = new TextInput(),
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                SessionId = "",
                ConversationAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                Parent = "",
                QuerySource = SearchKnowledgeRequest.Types.QuerySource.Unspecified,
                EndUserMetadata = new Struct(),
                SearchConfig = new SearchKnowledgeRequest.Types.SearchConfig(),
                ExactSearch = false,
            };
            // Make the request
            SearchKnowledgeResponse response = conversationsClient.SearchKnowledge(request);
            // End snippet
        }

        /// <summary>Snippet for SearchKnowledgeAsync</summary>
        public async Task SearchKnowledgeRequestObjectAsync()
        {
            // Snippet: SearchKnowledgeAsync(SearchKnowledgeRequest, CallSettings)
            // Additional: SearchKnowledgeAsync(SearchKnowledgeRequest, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            SearchKnowledgeRequest request = new SearchKnowledgeRequest
            {
                Query = new TextInput(),
                ConversationProfileAsConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
                SessionId = "",
                ConversationAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                Parent = "",
                QuerySource = SearchKnowledgeRequest.Types.QuerySource.Unspecified,
                EndUserMetadata = new Struct(),
                SearchConfig = new SearchKnowledgeRequest.Types.SearchConfig(),
                ExactSearch = false,
            };
            // Make the request
            SearchKnowledgeResponse response = await conversationsClient.SearchKnowledgeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateSuggestions</summary>
        public void GenerateSuggestionsRequestObject()
        {
            // Snippet: GenerateSuggestions(GenerateSuggestionsRequest, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            GenerateSuggestionsRequest request = new GenerateSuggestionsRequest
            {
                ConversationAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                TriggerEvents =
                {
                    TriggerEvent.Unspecified,
                },
            };
            // Make the request
            GenerateSuggestionsResponse response = conversationsClient.GenerateSuggestions(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateSuggestionsAsync</summary>
        public async Task GenerateSuggestionsRequestObjectAsync()
        {
            // Snippet: GenerateSuggestionsAsync(GenerateSuggestionsRequest, CallSettings)
            // Additional: GenerateSuggestionsAsync(GenerateSuggestionsRequest, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            GenerateSuggestionsRequest request = new GenerateSuggestionsRequest
            {
                ConversationAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                TriggerEvents =
                {
                    TriggerEvent.Unspecified,
                },
            };
            // Make the request
            GenerateSuggestionsResponse response = await conversationsClient.GenerateSuggestionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateSuggestions</summary>
        public void GenerateSuggestions()
        {
            // Snippet: GenerateSuggestions(string, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            string conversation = "projects/[PROJECT]/conversations/[CONVERSATION]";
            // Make the request
            GenerateSuggestionsResponse response = conversationsClient.GenerateSuggestions(conversation);
            // End snippet
        }

        /// <summary>Snippet for GenerateSuggestionsAsync</summary>
        public async Task GenerateSuggestionsAsync()
        {
            // Snippet: GenerateSuggestionsAsync(string, CallSettings)
            // Additional: GenerateSuggestionsAsync(string, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            string conversation = "projects/[PROJECT]/conversations/[CONVERSATION]";
            // Make the request
            GenerateSuggestionsResponse response = await conversationsClient.GenerateSuggestionsAsync(conversation);
            // End snippet
        }

        /// <summary>Snippet for GenerateSuggestions</summary>
        public void GenerateSuggestionsResourceNames()
        {
            // Snippet: GenerateSuggestions(ConversationName, CallSettings)
            // Create client
            ConversationsClient conversationsClient = ConversationsClient.Create();
            // Initialize request argument(s)
            ConversationName conversation = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            // Make the request
            GenerateSuggestionsResponse response = conversationsClient.GenerateSuggestions(conversation);
            // End snippet
        }

        /// <summary>Snippet for GenerateSuggestionsAsync</summary>
        public async Task GenerateSuggestionsResourceNamesAsync()
        {
            // Snippet: GenerateSuggestionsAsync(ConversationName, CallSettings)
            // Additional: GenerateSuggestionsAsync(ConversationName, CancellationToken)
            // Create client
            ConversationsClient conversationsClient = await ConversationsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName conversation = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            // Make the request
            GenerateSuggestionsResponse response = await conversationsClient.GenerateSuggestionsAsync(conversation);
            // End snippet
        }
    }
}
