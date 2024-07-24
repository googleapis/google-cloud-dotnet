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
    using Google.Apps.Chat.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedChatServiceClientSnippets
    {
        /// <summary>Snippet for CreateMessage</summary>
        public void CreateMessageRequestObject()
        {
            // Snippet: CreateMessage(CreateMessageRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            CreateMessageRequest request = new CreateMessageRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Message = new Message(),
                RequestId = "",
                MessageReplyOption = CreateMessageRequest.Types.MessageReplyOption.Unspecified,
                MessageId = "",
            };
            // Make the request
            Message response = chatServiceClient.CreateMessage(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMessageAsync</summary>
        public async Task CreateMessageRequestObjectAsync()
        {
            // Snippet: CreateMessageAsync(CreateMessageRequest, CallSettings)
            // Additional: CreateMessageAsync(CreateMessageRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMessageRequest request = new CreateMessageRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Message = new Message(),
                RequestId = "",
                MessageReplyOption = CreateMessageRequest.Types.MessageReplyOption.Unspecified,
                MessageId = "",
            };
            // Make the request
            Message response = await chatServiceClient.CreateMessageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMessage</summary>
        public void CreateMessage()
        {
            // Snippet: CreateMessage(string, Message, string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            Message message = new Message();
            string messageId = "";
            // Make the request
            Message response = chatServiceClient.CreateMessage(parent, message, messageId);
            // End snippet
        }

        /// <summary>Snippet for CreateMessageAsync</summary>
        public async Task CreateMessageAsync()
        {
            // Snippet: CreateMessageAsync(string, Message, string, CallSettings)
            // Additional: CreateMessageAsync(string, Message, string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            Message message = new Message();
            string messageId = "";
            // Make the request
            Message response = await chatServiceClient.CreateMessageAsync(parent, message, messageId);
            // End snippet
        }

        /// <summary>Snippet for CreateMessage</summary>
        public void CreateMessageResourceNames()
        {
            // Snippet: CreateMessage(SpaceName, Message, string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            Message message = new Message();
            string messageId = "";
            // Make the request
            Message response = chatServiceClient.CreateMessage(parent, message, messageId);
            // End snippet
        }

        /// <summary>Snippet for CreateMessageAsync</summary>
        public async Task CreateMessageResourceNamesAsync()
        {
            // Snippet: CreateMessageAsync(SpaceName, Message, string, CallSettings)
            // Additional: CreateMessageAsync(SpaceName, Message, string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            Message message = new Message();
            string messageId = "";
            // Make the request
            Message response = await chatServiceClient.CreateMessageAsync(parent, message, messageId);
            // End snippet
        }

        /// <summary>Snippet for ListMessages</summary>
        public void ListMessagesRequestObject()
        {
            // Snippet: ListMessages(ListMessagesRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            ListMessagesRequest request = new ListMessagesRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Filter = "",
                OrderBy = "",
                ShowDeleted = false,
            };
            // Make the request
            PagedEnumerable<ListMessagesResponse, Message> response = chatServiceClient.ListMessages(request);

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
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMessagesRequest request = new ListMessagesRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Filter = "",
                OrderBy = "",
                ShowDeleted = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListMessagesResponse, Message> response = chatServiceClient.ListMessagesAsync(request);

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
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            // Make the request
            PagedEnumerable<ListMessagesResponse, Message> response = chatServiceClient.ListMessages(parent);

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
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            // Make the request
            PagedAsyncEnumerable<ListMessagesResponse, Message> response = chatServiceClient.ListMessagesAsync(parent);

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
            // Snippet: ListMessages(SpaceName, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            // Make the request
            PagedEnumerable<ListMessagesResponse, Message> response = chatServiceClient.ListMessages(parent);

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
            // Snippet: ListMessagesAsync(SpaceName, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            // Make the request
            PagedAsyncEnumerable<ListMessagesResponse, Message> response = chatServiceClient.ListMessagesAsync(parent);

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

        /// <summary>Snippet for ListMemberships</summary>
        public void ListMembershipsRequestObject()
        {
            // Snippet: ListMemberships(ListMembershipsRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            ListMembershipsRequest request = new ListMembershipsRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Filter = "",
                ShowGroups = false,
                ShowInvited = false,
            };
            // Make the request
            PagedEnumerable<ListMembershipsResponse, Membership> response = chatServiceClient.ListMemberships(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipsAsync</summary>
        public async Task ListMembershipsRequestObjectAsync()
        {
            // Snippet: ListMembershipsAsync(ListMembershipsRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListMembershipsRequest request = new ListMembershipsRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Filter = "",
                ShowGroups = false,
                ShowInvited = false,
            };
            // Make the request
            PagedAsyncEnumerable<ListMembershipsResponse, Membership> response = chatServiceClient.ListMembershipsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Membership item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMembershipsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMemberships</summary>
        public void ListMemberships()
        {
            // Snippet: ListMemberships(string, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            // Make the request
            PagedEnumerable<ListMembershipsResponse, Membership> response = chatServiceClient.ListMemberships(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipsAsync</summary>
        public async Task ListMembershipsAsync()
        {
            // Snippet: ListMembershipsAsync(string, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            // Make the request
            PagedAsyncEnumerable<ListMembershipsResponse, Membership> response = chatServiceClient.ListMembershipsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Membership item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMembershipsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMemberships</summary>
        public void ListMembershipsResourceNames()
        {
            // Snippet: ListMemberships(SpaceName, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            // Make the request
            PagedEnumerable<ListMembershipsResponse, Membership> response = chatServiceClient.ListMemberships(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Membership item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListMembershipsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListMembershipsAsync</summary>
        public async Task ListMembershipsResourceNamesAsync()
        {
            // Snippet: ListMembershipsAsync(SpaceName, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            // Make the request
            PagedAsyncEnumerable<ListMembershipsResponse, Membership> response = chatServiceClient.ListMembershipsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Membership item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListMembershipsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Membership item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Membership> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Membership item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetMembership</summary>
        public void GetMembershipRequestObject()
        {
            // Snippet: GetMembership(GetMembershipRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromSpaceMember("[SPACE]", "[MEMBER]"),
            };
            // Make the request
            Membership response = chatServiceClient.GetMembership(request);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipAsync</summary>
        public async Task GetMembershipRequestObjectAsync()
        {
            // Snippet: GetMembershipAsync(GetMembershipRequest, CallSettings)
            // Additional: GetMembershipAsync(GetMembershipRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMembershipRequest request = new GetMembershipRequest
            {
                MembershipName = MembershipName.FromSpaceMember("[SPACE]", "[MEMBER]"),
            };
            // Make the request
            Membership response = await chatServiceClient.GetMembershipAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMembership</summary>
        public void GetMembership()
        {
            // Snippet: GetMembership(string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/members/[MEMBER]";
            // Make the request
            Membership response = chatServiceClient.GetMembership(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipAsync</summary>
        public async Task GetMembershipAsync()
        {
            // Snippet: GetMembershipAsync(string, CallSettings)
            // Additional: GetMembershipAsync(string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/members/[MEMBER]";
            // Make the request
            Membership response = await chatServiceClient.GetMembershipAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembership</summary>
        public void GetMembershipResourceNames()
        {
            // Snippet: GetMembership(MembershipName, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromSpaceMember("[SPACE]", "[MEMBER]");
            // Make the request
            Membership response = chatServiceClient.GetMembership(name);
            // End snippet
        }

        /// <summary>Snippet for GetMembershipAsync</summary>
        public async Task GetMembershipResourceNamesAsync()
        {
            // Snippet: GetMembershipAsync(MembershipName, CallSettings)
            // Additional: GetMembershipAsync(MembershipName, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromSpaceMember("[SPACE]", "[MEMBER]");
            // Make the request
            Membership response = await chatServiceClient.GetMembershipAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMessage</summary>
        public void GetMessageRequestObject()
        {
            // Snippet: GetMessage(GetMessageRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            GetMessageRequest request = new GetMessageRequest
            {
                MessageName = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]"),
            };
            // Make the request
            Message response = chatServiceClient.GetMessage(request);
            // End snippet
        }

        /// <summary>Snippet for GetMessageAsync</summary>
        public async Task GetMessageRequestObjectAsync()
        {
            // Snippet: GetMessageAsync(GetMessageRequest, CallSettings)
            // Additional: GetMessageAsync(GetMessageRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetMessageRequest request = new GetMessageRequest
            {
                MessageName = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]"),
            };
            // Make the request
            Message response = await chatServiceClient.GetMessageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetMessage</summary>
        public void GetMessage()
        {
            // Snippet: GetMessage(string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/messages/[MESSAGE]";
            // Make the request
            Message response = chatServiceClient.GetMessage(name);
            // End snippet
        }

        /// <summary>Snippet for GetMessageAsync</summary>
        public async Task GetMessageAsync()
        {
            // Snippet: GetMessageAsync(string, CallSettings)
            // Additional: GetMessageAsync(string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/messages/[MESSAGE]";
            // Make the request
            Message response = await chatServiceClient.GetMessageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetMessage</summary>
        public void GetMessageResourceNames()
        {
            // Snippet: GetMessage(MessageName, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            MessageName name = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]");
            // Make the request
            Message response = chatServiceClient.GetMessage(name);
            // End snippet
        }

        /// <summary>Snippet for GetMessageAsync</summary>
        public async Task GetMessageResourceNamesAsync()
        {
            // Snippet: GetMessageAsync(MessageName, CallSettings)
            // Additional: GetMessageAsync(MessageName, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            MessageName name = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]");
            // Make the request
            Message response = await chatServiceClient.GetMessageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateMessage</summary>
        public void UpdateMessageRequestObject()
        {
            // Snippet: UpdateMessage(UpdateMessageRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            UpdateMessageRequest request = new UpdateMessageRequest
            {
                Message = new Message(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Message response = chatServiceClient.UpdateMessage(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMessageAsync</summary>
        public async Task UpdateMessageRequestObjectAsync()
        {
            // Snippet: UpdateMessageAsync(UpdateMessageRequest, CallSettings)
            // Additional: UpdateMessageAsync(UpdateMessageRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMessageRequest request = new UpdateMessageRequest
            {
                Message = new Message(),
                UpdateMask = new FieldMask(),
                AllowMissing = false,
            };
            // Make the request
            Message response = await chatServiceClient.UpdateMessageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMessage</summary>
        public void UpdateMessage()
        {
            // Snippet: UpdateMessage(Message, FieldMask, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            Message message = new Message();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Message response = chatServiceClient.UpdateMessage(message, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateMessageAsync</summary>
        public async Task UpdateMessageAsync()
        {
            // Snippet: UpdateMessageAsync(Message, FieldMask, CallSettings)
            // Additional: UpdateMessageAsync(Message, FieldMask, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            Message message = new Message();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Message response = await chatServiceClient.UpdateMessageAsync(message, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteMessage</summary>
        public void DeleteMessageRequestObject()
        {
            // Snippet: DeleteMessage(DeleteMessageRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            DeleteMessageRequest request = new DeleteMessageRequest
            {
                MessageName = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]"),
                Force = false,
            };
            // Make the request
            chatServiceClient.DeleteMessage(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMessageAsync</summary>
        public async Task DeleteMessageRequestObjectAsync()
        {
            // Snippet: DeleteMessageAsync(DeleteMessageRequest, CallSettings)
            // Additional: DeleteMessageAsync(DeleteMessageRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMessageRequest request = new DeleteMessageRequest
            {
                MessageName = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]"),
                Force = false,
            };
            // Make the request
            await chatServiceClient.DeleteMessageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMessage</summary>
        public void DeleteMessage()
        {
            // Snippet: DeleteMessage(string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/messages/[MESSAGE]";
            // Make the request
            chatServiceClient.DeleteMessage(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMessageAsync</summary>
        public async Task DeleteMessageAsync()
        {
            // Snippet: DeleteMessageAsync(string, CallSettings)
            // Additional: DeleteMessageAsync(string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/messages/[MESSAGE]";
            // Make the request
            await chatServiceClient.DeleteMessageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMessage</summary>
        public void DeleteMessageResourceNames()
        {
            // Snippet: DeleteMessage(MessageName, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            MessageName name = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]");
            // Make the request
            chatServiceClient.DeleteMessage(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMessageAsync</summary>
        public async Task DeleteMessageResourceNamesAsync()
        {
            // Snippet: DeleteMessageAsync(MessageName, CallSettings)
            // Additional: DeleteMessageAsync(MessageName, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            MessageName name = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]");
            // Make the request
            await chatServiceClient.DeleteMessageAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttachment</summary>
        public void GetAttachmentRequestObject()
        {
            // Snippet: GetAttachment(GetAttachmentRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            GetAttachmentRequest request = new GetAttachmentRequest
            {
                AttachmentName = AttachmentName.FromSpaceMessageAttachment("[SPACE]", "[MESSAGE]", "[ATTACHMENT]"),
            };
            // Make the request
            Attachment response = chatServiceClient.GetAttachment(request);
            // End snippet
        }

        /// <summary>Snippet for GetAttachmentAsync</summary>
        public async Task GetAttachmentRequestObjectAsync()
        {
            // Snippet: GetAttachmentAsync(GetAttachmentRequest, CallSettings)
            // Additional: GetAttachmentAsync(GetAttachmentRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAttachmentRequest request = new GetAttachmentRequest
            {
                AttachmentName = AttachmentName.FromSpaceMessageAttachment("[SPACE]", "[MESSAGE]", "[ATTACHMENT]"),
            };
            // Make the request
            Attachment response = await chatServiceClient.GetAttachmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAttachment</summary>
        public void GetAttachment()
        {
            // Snippet: GetAttachment(string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/messages/[MESSAGE]/attachments/[ATTACHMENT]";
            // Make the request
            Attachment response = chatServiceClient.GetAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttachmentAsync</summary>
        public async Task GetAttachmentAsync()
        {
            // Snippet: GetAttachmentAsync(string, CallSettings)
            // Additional: GetAttachmentAsync(string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/messages/[MESSAGE]/attachments/[ATTACHMENT]";
            // Make the request
            Attachment response = await chatServiceClient.GetAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttachment</summary>
        public void GetAttachmentResourceNames()
        {
            // Snippet: GetAttachment(AttachmentName, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            AttachmentName name = AttachmentName.FromSpaceMessageAttachment("[SPACE]", "[MESSAGE]", "[ATTACHMENT]");
            // Make the request
            Attachment response = chatServiceClient.GetAttachment(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttachmentAsync</summary>
        public async Task GetAttachmentResourceNamesAsync()
        {
            // Snippet: GetAttachmentAsync(AttachmentName, CallSettings)
            // Additional: GetAttachmentAsync(AttachmentName, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            AttachmentName name = AttachmentName.FromSpaceMessageAttachment("[SPACE]", "[MESSAGE]", "[ATTACHMENT]");
            // Make the request
            Attachment response = await chatServiceClient.GetAttachmentAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UploadAttachment</summary>
        public void UploadAttachmentRequestObject()
        {
            // Snippet: UploadAttachment(UploadAttachmentRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            UploadAttachmentRequest request = new UploadAttachmentRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Filename = "",
            };
            // Make the request
            UploadAttachmentResponse response = chatServiceClient.UploadAttachment(request);
            // End snippet
        }

        /// <summary>Snippet for UploadAttachmentAsync</summary>
        public async Task UploadAttachmentRequestObjectAsync()
        {
            // Snippet: UploadAttachmentAsync(UploadAttachmentRequest, CallSettings)
            // Additional: UploadAttachmentAsync(UploadAttachmentRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            UploadAttachmentRequest request = new UploadAttachmentRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Filename = "",
            };
            // Make the request
            UploadAttachmentResponse response = await chatServiceClient.UploadAttachmentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListSpaces</summary>
        public void ListSpacesRequestObject()
        {
            // Snippet: ListSpaces(ListSpacesRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            ListSpacesRequest request = new ListSpacesRequest { Filter = "", };
            // Make the request
            PagedEnumerable<ListSpacesResponse, Space> response = chatServiceClient.ListSpaces(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Space item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Space item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Space> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Space item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpacesAsync</summary>
        public async Task ListSpacesRequestObjectAsync()
        {
            // Snippet: ListSpacesAsync(ListSpacesRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSpacesRequest request = new ListSpacesRequest { Filter = "", };
            // Make the request
            PagedAsyncEnumerable<ListSpacesResponse, Space> response = chatServiceClient.ListSpacesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Space item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSpacesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Space item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Space> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Space item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpaces</summary>
        public void ListSpaces()
        {
            // Snippet: ListSpaces(string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Make the request
            PagedEnumerable<ListSpacesResponse, Space> response = chatServiceClient.ListSpaces();

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Space item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Space item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Space> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Space item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpacesAsync</summary>
        public async Task ListSpacesAsync()
        {
            // Snippet: ListSpacesAsync(string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Make the request
            PagedAsyncEnumerable<ListSpacesResponse, Space> response = chatServiceClient.ListSpacesAsync();

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Space item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSpacesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Space item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Space> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Space item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSpace</summary>
        public void GetSpaceRequestObject()
        {
            // Snippet: GetSpace(GetSpaceRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            GetSpaceRequest request = new GetSpaceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            Space response = chatServiceClient.GetSpace(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceAsync</summary>
        public async Task GetSpaceRequestObjectAsync()
        {
            // Snippet: GetSpaceAsync(GetSpaceRequest, CallSettings)
            // Additional: GetSpaceAsync(GetSpaceRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSpaceRequest request = new GetSpaceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            Space response = await chatServiceClient.GetSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpace</summary>
        public void GetSpace()
        {
            // Snippet: GetSpace(string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]";
            // Make the request
            Space response = chatServiceClient.GetSpace(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceAsync</summary>
        public async Task GetSpaceAsync()
        {
            // Snippet: GetSpaceAsync(string, CallSettings)
            // Additional: GetSpaceAsync(string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]";
            // Make the request
            Space response = await chatServiceClient.GetSpaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpace</summary>
        public void GetSpaceResourceNames()
        {
            // Snippet: GetSpace(SpaceName, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromSpace("[SPACE]");
            // Make the request
            Space response = chatServiceClient.GetSpace(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceAsync</summary>
        public async Task GetSpaceResourceNamesAsync()
        {
            // Snippet: GetSpaceAsync(SpaceName, CallSettings)
            // Additional: GetSpaceAsync(SpaceName, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromSpace("[SPACE]");
            // Make the request
            Space response = await chatServiceClient.GetSpaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSpace</summary>
        public void CreateSpaceRequestObject()
        {
            // Snippet: CreateSpace(CreateSpaceRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            CreateSpaceRequest request = new CreateSpaceRequest
            {
                Space = new Space(),
                RequestId = "",
            };
            // Make the request
            Space response = chatServiceClient.CreateSpace(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpaceAsync</summary>
        public async Task CreateSpaceRequestObjectAsync()
        {
            // Snippet: CreateSpaceAsync(CreateSpaceRequest, CallSettings)
            // Additional: CreateSpaceAsync(CreateSpaceRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSpaceRequest request = new CreateSpaceRequest
            {
                Space = new Space(),
                RequestId = "",
            };
            // Make the request
            Space response = await chatServiceClient.CreateSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSpace</summary>
        public void CreateSpace()
        {
            // Snippet: CreateSpace(Space, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            Space space = new Space();
            // Make the request
            Space response = chatServiceClient.CreateSpace(space);
            // End snippet
        }

        /// <summary>Snippet for CreateSpaceAsync</summary>
        public async Task CreateSpaceAsync()
        {
            // Snippet: CreateSpaceAsync(Space, CallSettings)
            // Additional: CreateSpaceAsync(Space, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            Space space = new Space();
            // Make the request
            Space response = await chatServiceClient.CreateSpaceAsync(space);
            // End snippet
        }

        /// <summary>Snippet for SetUpSpace</summary>
        public void SetUpSpaceRequestObject()
        {
            // Snippet: SetUpSpace(SetUpSpaceRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            SetUpSpaceRequest request = new SetUpSpaceRequest
            {
                Space = new Space(),
                RequestId = "",
                Memberships = { new Membership(), },
            };
            // Make the request
            Space response = chatServiceClient.SetUpSpace(request);
            // End snippet
        }

        /// <summary>Snippet for SetUpSpaceAsync</summary>
        public async Task SetUpSpaceRequestObjectAsync()
        {
            // Snippet: SetUpSpaceAsync(SetUpSpaceRequest, CallSettings)
            // Additional: SetUpSpaceAsync(SetUpSpaceRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            SetUpSpaceRequest request = new SetUpSpaceRequest
            {
                Space = new Space(),
                RequestId = "",
                Memberships = { new Membership(), },
            };
            // Make the request
            Space response = await chatServiceClient.SetUpSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpace</summary>
        public void UpdateSpaceRequestObject()
        {
            // Snippet: UpdateSpace(UpdateSpaceRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            UpdateSpaceRequest request = new UpdateSpaceRequest
            {
                Space = new Space(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Space response = chatServiceClient.UpdateSpace(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpaceAsync</summary>
        public async Task UpdateSpaceRequestObjectAsync()
        {
            // Snippet: UpdateSpaceAsync(UpdateSpaceRequest, CallSettings)
            // Additional: UpdateSpaceAsync(UpdateSpaceRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSpaceRequest request = new UpdateSpaceRequest
            {
                Space = new Space(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Space response = await chatServiceClient.UpdateSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpace</summary>
        public void UpdateSpace()
        {
            // Snippet: UpdateSpace(Space, FieldMask, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            Space space = new Space();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Space response = chatServiceClient.UpdateSpace(space, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpaceAsync</summary>
        public async Task UpdateSpaceAsync()
        {
            // Snippet: UpdateSpaceAsync(Space, FieldMask, CallSettings)
            // Additional: UpdateSpaceAsync(Space, FieldMask, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            Space space = new Space();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Space response = await chatServiceClient.UpdateSpaceAsync(space, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpace</summary>
        public void DeleteSpaceRequestObject()
        {
            // Snippet: DeleteSpace(DeleteSpaceRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            DeleteSpaceRequest request = new DeleteSpaceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            chatServiceClient.DeleteSpace(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpaceAsync</summary>
        public async Task DeleteSpaceRequestObjectAsync()
        {
            // Snippet: DeleteSpaceAsync(DeleteSpaceRequest, CallSettings)
            // Additional: DeleteSpaceAsync(DeleteSpaceRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSpaceRequest request = new DeleteSpaceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            await chatServiceClient.DeleteSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpace</summary>
        public void DeleteSpace()
        {
            // Snippet: DeleteSpace(string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]";
            // Make the request
            chatServiceClient.DeleteSpace(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpaceAsync</summary>
        public async Task DeleteSpaceAsync()
        {
            // Snippet: DeleteSpaceAsync(string, CallSettings)
            // Additional: DeleteSpaceAsync(string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]";
            // Make the request
            await chatServiceClient.DeleteSpaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpace</summary>
        public void DeleteSpaceResourceNames()
        {
            // Snippet: DeleteSpace(SpaceName, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromSpace("[SPACE]");
            // Make the request
            chatServiceClient.DeleteSpace(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSpaceAsync</summary>
        public async Task DeleteSpaceResourceNamesAsync()
        {
            // Snippet: DeleteSpaceAsync(SpaceName, CallSettings)
            // Additional: DeleteSpaceAsync(SpaceName, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName name = SpaceName.FromSpace("[SPACE]");
            // Make the request
            await chatServiceClient.DeleteSpaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CompleteImportSpace</summary>
        public void CompleteImportSpaceRequestObject()
        {
            // Snippet: CompleteImportSpace(CompleteImportSpaceRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            CompleteImportSpaceRequest request = new CompleteImportSpaceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            CompleteImportSpaceResponse response = chatServiceClient.CompleteImportSpace(request);
            // End snippet
        }

        /// <summary>Snippet for CompleteImportSpaceAsync</summary>
        public async Task CompleteImportSpaceRequestObjectAsync()
        {
            // Snippet: CompleteImportSpaceAsync(CompleteImportSpaceRequest, CallSettings)
            // Additional: CompleteImportSpaceAsync(CompleteImportSpaceRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            CompleteImportSpaceRequest request = new CompleteImportSpaceRequest
            {
                SpaceName = SpaceName.FromSpace("[SPACE]"),
            };
            // Make the request
            CompleteImportSpaceResponse response = await chatServiceClient.CompleteImportSpaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for FindDirectMessage</summary>
        public void FindDirectMessageRequestObject()
        {
            // Snippet: FindDirectMessage(FindDirectMessageRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            FindDirectMessageRequest request = new FindDirectMessageRequest { Name = "", };
            // Make the request
            Space response = chatServiceClient.FindDirectMessage(request);
            // End snippet
        }

        /// <summary>Snippet for FindDirectMessageAsync</summary>
        public async Task FindDirectMessageRequestObjectAsync()
        {
            // Snippet: FindDirectMessageAsync(FindDirectMessageRequest, CallSettings)
            // Additional: FindDirectMessageAsync(FindDirectMessageRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            FindDirectMessageRequest request = new FindDirectMessageRequest { Name = "", };
            // Make the request
            Space response = await chatServiceClient.FindDirectMessageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMembership</summary>
        public void CreateMembershipRequestObject()
        {
            // Snippet: CreateMembership(CreateMembershipRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            CreateMembershipRequest request = new CreateMembershipRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Membership = new Membership(),
            };
            // Make the request
            Membership response = chatServiceClient.CreateMembership(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipAsync</summary>
        public async Task CreateMembershipRequestObjectAsync()
        {
            // Snippet: CreateMembershipAsync(CreateMembershipRequest, CallSettings)
            // Additional: CreateMembershipAsync(CreateMembershipRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateMembershipRequest request = new CreateMembershipRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Membership = new Membership(),
            };
            // Make the request
            Membership response = await chatServiceClient.CreateMembershipAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateMembership</summary>
        public void CreateMembership()
        {
            // Snippet: CreateMembership(string, Membership, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            Membership membership = new Membership();
            // Make the request
            Membership response = chatServiceClient.CreateMembership(parent, membership);
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipAsync</summary>
        public async Task CreateMembershipAsync()
        {
            // Snippet: CreateMembershipAsync(string, Membership, CallSettings)
            // Additional: CreateMembershipAsync(string, Membership, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            Membership membership = new Membership();
            // Make the request
            Membership response = await chatServiceClient.CreateMembershipAsync(parent, membership);
            // End snippet
        }

        /// <summary>Snippet for CreateMembership</summary>
        public void CreateMembershipResourceNames()
        {
            // Snippet: CreateMembership(SpaceName, Membership, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            Membership membership = new Membership();
            // Make the request
            Membership response = chatServiceClient.CreateMembership(parent, membership);
            // End snippet
        }

        /// <summary>Snippet for CreateMembershipAsync</summary>
        public async Task CreateMembershipResourceNamesAsync()
        {
            // Snippet: CreateMembershipAsync(SpaceName, Membership, CallSettings)
            // Additional: CreateMembershipAsync(SpaceName, Membership, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            Membership membership = new Membership();
            // Make the request
            Membership response = await chatServiceClient.CreateMembershipAsync(parent, membership);
            // End snippet
        }

        /// <summary>Snippet for UpdateMembership</summary>
        public void UpdateMembershipRequestObject()
        {
            // Snippet: UpdateMembership(UpdateMembershipRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            UpdateMembershipRequest request = new UpdateMembershipRequest
            {
                Membership = new Membership(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Membership response = chatServiceClient.UpdateMembership(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipAsync</summary>
        public async Task UpdateMembershipRequestObjectAsync()
        {
            // Snippet: UpdateMembershipAsync(UpdateMembershipRequest, CallSettings)
            // Additional: UpdateMembershipAsync(UpdateMembershipRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateMembershipRequest request = new UpdateMembershipRequest
            {
                Membership = new Membership(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Membership response = await chatServiceClient.UpdateMembershipAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateMembership</summary>
        public void UpdateMembership()
        {
            // Snippet: UpdateMembership(Membership, FieldMask, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            Membership membership = new Membership();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Membership response = chatServiceClient.UpdateMembership(membership, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateMembershipAsync</summary>
        public async Task UpdateMembershipAsync()
        {
            // Snippet: UpdateMembershipAsync(Membership, FieldMask, CallSettings)
            // Additional: UpdateMembershipAsync(Membership, FieldMask, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            Membership membership = new Membership();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Membership response = await chatServiceClient.UpdateMembershipAsync(membership, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteMembership</summary>
        public void DeleteMembershipRequestObject()
        {
            // Snippet: DeleteMembership(DeleteMembershipRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            DeleteMembershipRequest request = new DeleteMembershipRequest
            {
                MembershipName = MembershipName.FromSpaceMember("[SPACE]", "[MEMBER]"),
            };
            // Make the request
            Membership response = chatServiceClient.DeleteMembership(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipAsync</summary>
        public async Task DeleteMembershipRequestObjectAsync()
        {
            // Snippet: DeleteMembershipAsync(DeleteMembershipRequest, CallSettings)
            // Additional: DeleteMembershipAsync(DeleteMembershipRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteMembershipRequest request = new DeleteMembershipRequest
            {
                MembershipName = MembershipName.FromSpaceMember("[SPACE]", "[MEMBER]"),
            };
            // Make the request
            Membership response = await chatServiceClient.DeleteMembershipAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteMembership</summary>
        public void DeleteMembership()
        {
            // Snippet: DeleteMembership(string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/members/[MEMBER]";
            // Make the request
            Membership response = chatServiceClient.DeleteMembership(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipAsync</summary>
        public async Task DeleteMembershipAsync()
        {
            // Snippet: DeleteMembershipAsync(string, CallSettings)
            // Additional: DeleteMembershipAsync(string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/members/[MEMBER]";
            // Make the request
            Membership response = await chatServiceClient.DeleteMembershipAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMembership</summary>
        public void DeleteMembershipResourceNames()
        {
            // Snippet: DeleteMembership(MembershipName, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromSpaceMember("[SPACE]", "[MEMBER]");
            // Make the request
            Membership response = chatServiceClient.DeleteMembership(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteMembershipAsync</summary>
        public async Task DeleteMembershipResourceNamesAsync()
        {
            // Snippet: DeleteMembershipAsync(MembershipName, CallSettings)
            // Additional: DeleteMembershipAsync(MembershipName, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            MembershipName name = MembershipName.FromSpaceMember("[SPACE]", "[MEMBER]");
            // Make the request
            Membership response = await chatServiceClient.DeleteMembershipAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateReaction</summary>
        public void CreateReactionRequestObject()
        {
            // Snippet: CreateReaction(CreateReactionRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            CreateReactionRequest request = new CreateReactionRequest
            {
                ParentAsMessageName = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]"),
                Reaction = new Reaction(),
            };
            // Make the request
            Reaction response = chatServiceClient.CreateReaction(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReactionAsync</summary>
        public async Task CreateReactionRequestObjectAsync()
        {
            // Snippet: CreateReactionAsync(CreateReactionRequest, CallSettings)
            // Additional: CreateReactionAsync(CreateReactionRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateReactionRequest request = new CreateReactionRequest
            {
                ParentAsMessageName = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]"),
                Reaction = new Reaction(),
            };
            // Make the request
            Reaction response = await chatServiceClient.CreateReactionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateReaction</summary>
        public void CreateReaction()
        {
            // Snippet: CreateReaction(string, Reaction, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]/messages/[MESSAGE]";
            Reaction reaction = new Reaction();
            // Make the request
            Reaction response = chatServiceClient.CreateReaction(parent, reaction);
            // End snippet
        }

        /// <summary>Snippet for CreateReactionAsync</summary>
        public async Task CreateReactionAsync()
        {
            // Snippet: CreateReactionAsync(string, Reaction, CallSettings)
            // Additional: CreateReactionAsync(string, Reaction, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]/messages/[MESSAGE]";
            Reaction reaction = new Reaction();
            // Make the request
            Reaction response = await chatServiceClient.CreateReactionAsync(parent, reaction);
            // End snippet
        }

        /// <summary>Snippet for CreateReaction</summary>
        public void CreateReactionResourceNames()
        {
            // Snippet: CreateReaction(MessageName, Reaction, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            MessageName parent = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]");
            Reaction reaction = new Reaction();
            // Make the request
            Reaction response = chatServiceClient.CreateReaction(parent, reaction);
            // End snippet
        }

        /// <summary>Snippet for CreateReactionAsync</summary>
        public async Task CreateReactionResourceNamesAsync()
        {
            // Snippet: CreateReactionAsync(MessageName, Reaction, CallSettings)
            // Additional: CreateReactionAsync(MessageName, Reaction, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            MessageName parent = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]");
            Reaction reaction = new Reaction();
            // Make the request
            Reaction response = await chatServiceClient.CreateReactionAsync(parent, reaction);
            // End snippet
        }

        /// <summary>Snippet for ListReactions</summary>
        public void ListReactionsRequestObject()
        {
            // Snippet: ListReactions(ListReactionsRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            ListReactionsRequest request = new ListReactionsRequest
            {
                ParentAsMessageName = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListReactionsResponse, Reaction> response = chatServiceClient.ListReactions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Reaction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReactionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reaction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reaction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reaction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReactionsAsync</summary>
        public async Task ListReactionsRequestObjectAsync()
        {
            // Snippet: ListReactionsAsync(ListReactionsRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListReactionsRequest request = new ListReactionsRequest
            {
                ParentAsMessageName = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListReactionsResponse, Reaction> response = chatServiceClient.ListReactionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Reaction item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReactionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reaction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reaction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reaction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReactions</summary>
        public void ListReactions()
        {
            // Snippet: ListReactions(string, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]/messages/[MESSAGE]";
            // Make the request
            PagedEnumerable<ListReactionsResponse, Reaction> response = chatServiceClient.ListReactions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Reaction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReactionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reaction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reaction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reaction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReactionsAsync</summary>
        public async Task ListReactionsAsync()
        {
            // Snippet: ListReactionsAsync(string, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]/messages/[MESSAGE]";
            // Make the request
            PagedAsyncEnumerable<ListReactionsResponse, Reaction> response = chatServiceClient.ListReactionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Reaction item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReactionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reaction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reaction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reaction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReactions</summary>
        public void ListReactionsResourceNames()
        {
            // Snippet: ListReactions(MessageName, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            MessageName parent = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]");
            // Make the request
            PagedEnumerable<ListReactionsResponse, Reaction> response = chatServiceClient.ListReactions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Reaction item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListReactionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reaction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reaction> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reaction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListReactionsAsync</summary>
        public async Task ListReactionsResourceNamesAsync()
        {
            // Snippet: ListReactionsAsync(MessageName, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            MessageName parent = MessageName.FromSpaceMessage("[SPACE]", "[MESSAGE]");
            // Make the request
            PagedAsyncEnumerable<ListReactionsResponse, Reaction> response = chatServiceClient.ListReactionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Reaction item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListReactionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Reaction item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Reaction> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Reaction item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteReaction</summary>
        public void DeleteReactionRequestObject()
        {
            // Snippet: DeleteReaction(DeleteReactionRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            DeleteReactionRequest request = new DeleteReactionRequest
            {
                ReactionName = ReactionName.FromSpaceMessageReaction("[SPACE]", "[MESSAGE]", "[REACTION]"),
            };
            // Make the request
            chatServiceClient.DeleteReaction(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReactionAsync</summary>
        public async Task DeleteReactionRequestObjectAsync()
        {
            // Snippet: DeleteReactionAsync(DeleteReactionRequest, CallSettings)
            // Additional: DeleteReactionAsync(DeleteReactionRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteReactionRequest request = new DeleteReactionRequest
            {
                ReactionName = ReactionName.FromSpaceMessageReaction("[SPACE]", "[MESSAGE]", "[REACTION]"),
            };
            // Make the request
            await chatServiceClient.DeleteReactionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteReaction</summary>
        public void DeleteReaction()
        {
            // Snippet: DeleteReaction(string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/messages/[MESSAGE]/reactions/[REACTION]";
            // Make the request
            chatServiceClient.DeleteReaction(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReactionAsync</summary>
        public async Task DeleteReactionAsync()
        {
            // Snippet: DeleteReactionAsync(string, CallSettings)
            // Additional: DeleteReactionAsync(string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/messages/[MESSAGE]/reactions/[REACTION]";
            // Make the request
            await chatServiceClient.DeleteReactionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReaction</summary>
        public void DeleteReactionResourceNames()
        {
            // Snippet: DeleteReaction(ReactionName, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            ReactionName name = ReactionName.FromSpaceMessageReaction("[SPACE]", "[MESSAGE]", "[REACTION]");
            // Make the request
            chatServiceClient.DeleteReaction(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteReactionAsync</summary>
        public async Task DeleteReactionResourceNamesAsync()
        {
            // Snippet: DeleteReactionAsync(ReactionName, CallSettings)
            // Additional: DeleteReactionAsync(ReactionName, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReactionName name = ReactionName.FromSpaceMessageReaction("[SPACE]", "[MESSAGE]", "[REACTION]");
            // Make the request
            await chatServiceClient.DeleteReactionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceReadState</summary>
        public void GetSpaceReadStateRequestObject()
        {
            // Snippet: GetSpaceReadState(GetSpaceReadStateRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            GetSpaceReadStateRequest request = new GetSpaceReadStateRequest
            {
                SpaceReadStateName = SpaceReadStateName.FromUserSpace("[USER]", "[SPACE]"),
            };
            // Make the request
            SpaceReadState response = chatServiceClient.GetSpaceReadState(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceReadStateAsync</summary>
        public async Task GetSpaceReadStateRequestObjectAsync()
        {
            // Snippet: GetSpaceReadStateAsync(GetSpaceReadStateRequest, CallSettings)
            // Additional: GetSpaceReadStateAsync(GetSpaceReadStateRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSpaceReadStateRequest request = new GetSpaceReadStateRequest
            {
                SpaceReadStateName = SpaceReadStateName.FromUserSpace("[USER]", "[SPACE]"),
            };
            // Make the request
            SpaceReadState response = await chatServiceClient.GetSpaceReadStateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceReadState</summary>
        public void GetSpaceReadState()
        {
            // Snippet: GetSpaceReadState(string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/spaces/[SPACE]/spaceReadState";
            // Make the request
            SpaceReadState response = chatServiceClient.GetSpaceReadState(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceReadStateAsync</summary>
        public async Task GetSpaceReadStateAsync()
        {
            // Snippet: GetSpaceReadStateAsync(string, CallSettings)
            // Additional: GetSpaceReadStateAsync(string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/spaces/[SPACE]/spaceReadState";
            // Make the request
            SpaceReadState response = await chatServiceClient.GetSpaceReadStateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceReadState</summary>
        public void GetSpaceReadStateResourceNames()
        {
            // Snippet: GetSpaceReadState(SpaceReadStateName, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            SpaceReadStateName name = SpaceReadStateName.FromUserSpace("[USER]", "[SPACE]");
            // Make the request
            SpaceReadState response = chatServiceClient.GetSpaceReadState(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceReadStateAsync</summary>
        public async Task GetSpaceReadStateResourceNamesAsync()
        {
            // Snippet: GetSpaceReadStateAsync(SpaceReadStateName, CallSettings)
            // Additional: GetSpaceReadStateAsync(SpaceReadStateName, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceReadStateName name = SpaceReadStateName.FromUserSpace("[USER]", "[SPACE]");
            // Make the request
            SpaceReadState response = await chatServiceClient.GetSpaceReadStateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpaceReadState</summary>
        public void UpdateSpaceReadStateRequestObject()
        {
            // Snippet: UpdateSpaceReadState(UpdateSpaceReadStateRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            UpdateSpaceReadStateRequest request = new UpdateSpaceReadStateRequest
            {
                SpaceReadState = new SpaceReadState(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SpaceReadState response = chatServiceClient.UpdateSpaceReadState(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpaceReadStateAsync</summary>
        public async Task UpdateSpaceReadStateRequestObjectAsync()
        {
            // Snippet: UpdateSpaceReadStateAsync(UpdateSpaceReadStateRequest, CallSettings)
            // Additional: UpdateSpaceReadStateAsync(UpdateSpaceReadStateRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSpaceReadStateRequest request = new UpdateSpaceReadStateRequest
            {
                SpaceReadState = new SpaceReadState(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SpaceReadState response = await chatServiceClient.UpdateSpaceReadStateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpaceReadState</summary>
        public void UpdateSpaceReadState()
        {
            // Snippet: UpdateSpaceReadState(SpaceReadState, FieldMask, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            SpaceReadState spaceReadState = new SpaceReadState();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SpaceReadState response = chatServiceClient.UpdateSpaceReadState(spaceReadState, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSpaceReadStateAsync</summary>
        public async Task UpdateSpaceReadStateAsync()
        {
            // Snippet: UpdateSpaceReadStateAsync(SpaceReadState, FieldMask, CallSettings)
            // Additional: UpdateSpaceReadStateAsync(SpaceReadState, FieldMask, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceReadState spaceReadState = new SpaceReadState();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SpaceReadState response = await chatServiceClient.UpdateSpaceReadStateAsync(spaceReadState, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetThreadReadState</summary>
        public void GetThreadReadStateRequestObject()
        {
            // Snippet: GetThreadReadState(GetThreadReadStateRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            GetThreadReadStateRequest request = new GetThreadReadStateRequest
            {
                ThreadReadStateName = ThreadReadStateName.FromUserSpaceThread("[USER]", "[SPACE]", "[THREAD]"),
            };
            // Make the request
            ThreadReadState response = chatServiceClient.GetThreadReadState(request);
            // End snippet
        }

        /// <summary>Snippet for GetThreadReadStateAsync</summary>
        public async Task GetThreadReadStateRequestObjectAsync()
        {
            // Snippet: GetThreadReadStateAsync(GetThreadReadStateRequest, CallSettings)
            // Additional: GetThreadReadStateAsync(GetThreadReadStateRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetThreadReadStateRequest request = new GetThreadReadStateRequest
            {
                ThreadReadStateName = ThreadReadStateName.FromUserSpaceThread("[USER]", "[SPACE]", "[THREAD]"),
            };
            // Make the request
            ThreadReadState response = await chatServiceClient.GetThreadReadStateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetThreadReadState</summary>
        public void GetThreadReadState()
        {
            // Snippet: GetThreadReadState(string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string name = "users/[USER]/spaces/[SPACE]/threads/[THREAD]/threadReadState";
            // Make the request
            ThreadReadState response = chatServiceClient.GetThreadReadState(name);
            // End snippet
        }

        /// <summary>Snippet for GetThreadReadStateAsync</summary>
        public async Task GetThreadReadStateAsync()
        {
            // Snippet: GetThreadReadStateAsync(string, CallSettings)
            // Additional: GetThreadReadStateAsync(string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "users/[USER]/spaces/[SPACE]/threads/[THREAD]/threadReadState";
            // Make the request
            ThreadReadState response = await chatServiceClient.GetThreadReadStateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetThreadReadState</summary>
        public void GetThreadReadStateResourceNames()
        {
            // Snippet: GetThreadReadState(ThreadReadStateName, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            ThreadReadStateName name = ThreadReadStateName.FromUserSpaceThread("[USER]", "[SPACE]", "[THREAD]");
            // Make the request
            ThreadReadState response = chatServiceClient.GetThreadReadState(name);
            // End snippet
        }

        /// <summary>Snippet for GetThreadReadStateAsync</summary>
        public async Task GetThreadReadStateResourceNamesAsync()
        {
            // Snippet: GetThreadReadStateAsync(ThreadReadStateName, CallSettings)
            // Additional: GetThreadReadStateAsync(ThreadReadStateName, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            ThreadReadStateName name = ThreadReadStateName.FromUserSpaceThread("[USER]", "[SPACE]", "[THREAD]");
            // Make the request
            ThreadReadState response = await chatServiceClient.GetThreadReadStateAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceEvent</summary>
        public void GetSpaceEventRequestObject()
        {
            // Snippet: GetSpaceEvent(GetSpaceEventRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            GetSpaceEventRequest request = new GetSpaceEventRequest
            {
                SpaceEventName = SpaceEventName.FromSpaceSpaceEvent("[SPACE]", "[SPACE_EVENT]"),
            };
            // Make the request
            SpaceEvent response = chatServiceClient.GetSpaceEvent(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceEventAsync</summary>
        public async Task GetSpaceEventRequestObjectAsync()
        {
            // Snippet: GetSpaceEventAsync(GetSpaceEventRequest, CallSettings)
            // Additional: GetSpaceEventAsync(GetSpaceEventRequest, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSpaceEventRequest request = new GetSpaceEventRequest
            {
                SpaceEventName = SpaceEventName.FromSpaceSpaceEvent("[SPACE]", "[SPACE_EVENT]"),
            };
            // Make the request
            SpaceEvent response = await chatServiceClient.GetSpaceEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceEvent</summary>
        public void GetSpaceEvent()
        {
            // Snippet: GetSpaceEvent(string, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/spaceEvents/[SPACE_EVENT]";
            // Make the request
            SpaceEvent response = chatServiceClient.GetSpaceEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceEventAsync</summary>
        public async Task GetSpaceEventAsync()
        {
            // Snippet: GetSpaceEventAsync(string, CallSettings)
            // Additional: GetSpaceEventAsync(string, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "spaces/[SPACE]/spaceEvents/[SPACE_EVENT]";
            // Make the request
            SpaceEvent response = await chatServiceClient.GetSpaceEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceEvent</summary>
        public void GetSpaceEventResourceNames()
        {
            // Snippet: GetSpaceEvent(SpaceEventName, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            SpaceEventName name = SpaceEventName.FromSpaceSpaceEvent("[SPACE]", "[SPACE_EVENT]");
            // Make the request
            SpaceEvent response = chatServiceClient.GetSpaceEvent(name);
            // End snippet
        }

        /// <summary>Snippet for GetSpaceEventAsync</summary>
        public async Task GetSpaceEventResourceNamesAsync()
        {
            // Snippet: GetSpaceEventAsync(SpaceEventName, CallSettings)
            // Additional: GetSpaceEventAsync(SpaceEventName, CancellationToken)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceEventName name = SpaceEventName.FromSpaceSpaceEvent("[SPACE]", "[SPACE_EVENT]");
            // Make the request
            SpaceEvent response = await chatServiceClient.GetSpaceEventAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSpaceEvents</summary>
        public void ListSpaceEventsRequestObject()
        {
            // Snippet: ListSpaceEvents(ListSpaceEventsRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            ListSpaceEventsRequest request = new ListSpaceEventsRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListSpaceEventsResponse, SpaceEvent> response = chatServiceClient.ListSpaceEvents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SpaceEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpaceEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SpaceEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SpaceEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SpaceEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpaceEventsAsync</summary>
        public async Task ListSpaceEventsRequestObjectAsync()
        {
            // Snippet: ListSpaceEventsAsync(ListSpaceEventsRequest, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSpaceEventsRequest request = new ListSpaceEventsRequest
            {
                ParentAsSpaceName = SpaceName.FromSpace("[SPACE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSpaceEventsResponse, SpaceEvent> response = chatServiceClient.ListSpaceEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SpaceEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSpaceEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SpaceEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SpaceEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SpaceEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpaceEvents</summary>
        public void ListSpaceEvents()
        {
            // Snippet: ListSpaceEvents(string, string, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            string filter = "";
            // Make the request
            PagedEnumerable<ListSpaceEventsResponse, SpaceEvent> response = chatServiceClient.ListSpaceEvents(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SpaceEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpaceEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SpaceEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SpaceEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SpaceEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpaceEventsAsync</summary>
        public async Task ListSpaceEventsAsync()
        {
            // Snippet: ListSpaceEventsAsync(string, string, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "spaces/[SPACE]";
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListSpaceEventsResponse, SpaceEvent> response = chatServiceClient.ListSpaceEventsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SpaceEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSpaceEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SpaceEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SpaceEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SpaceEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpaceEvents</summary>
        public void ListSpaceEventsResourceNames()
        {
            // Snippet: ListSpaceEvents(SpaceName, string, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = ChatServiceClient.Create();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            string filter = "";
            // Make the request
            PagedEnumerable<ListSpaceEventsResponse, SpaceEvent> response = chatServiceClient.ListSpaceEvents(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SpaceEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSpaceEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SpaceEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SpaceEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SpaceEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSpaceEventsAsync</summary>
        public async Task ListSpaceEventsResourceNamesAsync()
        {
            // Snippet: ListSpaceEventsAsync(SpaceName, string, string, int?, CallSettings)
            // Create client
            ChatServiceClient chatServiceClient = await ChatServiceClient.CreateAsync();
            // Initialize request argument(s)
            SpaceName parent = SpaceName.FromSpace("[SPACE]");
            string filter = "";
            // Make the request
            PagedAsyncEnumerable<ListSpaceEventsResponse, SpaceEvent> response = chatServiceClient.ListSpaceEventsAsync(parent, filter);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SpaceEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSpaceEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SpaceEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SpaceEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SpaceEvent item in singlePage)
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
