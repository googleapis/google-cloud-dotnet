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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ContactCenterInsights.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedContactCenterInsightsClientSnippets
    {
        /// <summary>Snippet for CreateConversation</summary>
        public void CreateConversationRequestObject()
        {
            // Snippet: CreateConversation(CreateConversationRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Conversation = new Conversation(),
                ConversationId = "",
            };
            // Make the request
            Conversation response = contactCenterInsightsClient.CreateConversation(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationAsync</summary>
        public async Task CreateConversationRequestObjectAsync()
        {
            // Snippet: CreateConversationAsync(CreateConversationRequest, CallSettings)
            // Additional: CreateConversationAsync(CreateConversationRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Conversation = new Conversation(),
                ConversationId = "",
            };
            // Make the request
            Conversation response = await contactCenterInsightsClient.CreateConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConversation</summary>
        public void CreateConversation()
        {
            // Snippet: CreateConversation(string, Conversation, string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Conversation conversation = new Conversation();
            string conversationId = "";
            // Make the request
            Conversation response = contactCenterInsightsClient.CreateConversation(parent, conversation, conversationId);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationAsync</summary>
        public async Task CreateConversationAsync()
        {
            // Snippet: CreateConversationAsync(string, Conversation, string, CallSettings)
            // Additional: CreateConversationAsync(string, Conversation, string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Conversation conversation = new Conversation();
            string conversationId = "";
            // Make the request
            Conversation response = await contactCenterInsightsClient.CreateConversationAsync(parent, conversation, conversationId);
            // End snippet
        }

        /// <summary>Snippet for CreateConversation</summary>
        public void CreateConversationResourceNames()
        {
            // Snippet: CreateConversation(LocationName, Conversation, string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Conversation conversation = new Conversation();
            string conversationId = "";
            // Make the request
            Conversation response = contactCenterInsightsClient.CreateConversation(parent, conversation, conversationId);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationAsync</summary>
        public async Task CreateConversationResourceNamesAsync()
        {
            // Snippet: CreateConversationAsync(LocationName, Conversation, string, CallSettings)
            // Additional: CreateConversationAsync(LocationName, Conversation, string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Conversation conversation = new Conversation();
            string conversationId = "";
            // Make the request
            Conversation response = await contactCenterInsightsClient.CreateConversationAsync(parent, conversation, conversationId);
            // End snippet
        }

        /// <summary>Snippet for UploadConversation</summary>
        public void UploadConversationRequestObject()
        {
            // Snippet: UploadConversation(UploadConversationRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            UploadConversationRequest request = new UploadConversationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Conversation = new Conversation(),
                ConversationId = "",
                RedactionConfig = new RedactionConfig(),
                SpeechConfig = new SpeechConfig(),
            };
            // Make the request
            Operation<Conversation, UploadConversationMetadata> response = contactCenterInsightsClient.UploadConversation(request);

            // Poll until the returned long-running operation is complete
            Operation<Conversation, UploadConversationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Conversation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Conversation, UploadConversationMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceUploadConversation(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Conversation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UploadConversationAsync</summary>
        public async Task UploadConversationRequestObjectAsync()
        {
            // Snippet: UploadConversationAsync(UploadConversationRequest, CallSettings)
            // Additional: UploadConversationAsync(UploadConversationRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            UploadConversationRequest request = new UploadConversationRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Conversation = new Conversation(),
                ConversationId = "",
                RedactionConfig = new RedactionConfig(),
                SpeechConfig = new SpeechConfig(),
            };
            // Make the request
            Operation<Conversation, UploadConversationMetadata> response = await contactCenterInsightsClient.UploadConversationAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Conversation, UploadConversationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Conversation result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Conversation, UploadConversationMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceUploadConversationAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Conversation retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateConversation</summary>
        public void UpdateConversationRequestObject()
        {
            // Snippet: UpdateConversation(UpdateConversationRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            UpdateConversationRequest request = new UpdateConversationRequest
            {
                Conversation = new Conversation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Conversation response = contactCenterInsightsClient.UpdateConversation(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversationAsync</summary>
        public async Task UpdateConversationRequestObjectAsync()
        {
            // Snippet: UpdateConversationAsync(UpdateConversationRequest, CallSettings)
            // Additional: UpdateConversationAsync(UpdateConversationRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConversationRequest request = new UpdateConversationRequest
            {
                Conversation = new Conversation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Conversation response = await contactCenterInsightsClient.UpdateConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversation</summary>
        public void UpdateConversation()
        {
            // Snippet: UpdateConversation(Conversation, FieldMask, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            Conversation conversation = new Conversation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Conversation response = contactCenterInsightsClient.UpdateConversation(conversation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversationAsync</summary>
        public async Task UpdateConversationAsync()
        {
            // Snippet: UpdateConversationAsync(Conversation, FieldMask, CallSettings)
            // Additional: UpdateConversationAsync(Conversation, FieldMask, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            Conversation conversation = new Conversation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Conversation response = await contactCenterInsightsClient.UpdateConversationAsync(conversation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetConversation</summary>
        public void GetConversationRequestObject()
        {
            // Snippet: GetConversation(GetConversationRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                View = ConversationView.Unspecified,
            };
            // Make the request
            Conversation response = contactCenterInsightsClient.GetConversation(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversationAsync</summary>
        public async Task GetConversationRequestObjectAsync()
        {
            // Snippet: GetConversationAsync(GetConversationRequest, CallSettings)
            // Additional: GetConversationAsync(GetConversationRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                View = ConversationView.Unspecified,
            };
            // Make the request
            Conversation response = await contactCenterInsightsClient.GetConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversation</summary>
        public void GetConversation()
        {
            // Snippet: GetConversation(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversations/[CONVERSATION]";
            // Make the request
            Conversation response = contactCenterInsightsClient.GetConversation(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationAsync</summary>
        public async Task GetConversationAsync()
        {
            // Snippet: GetConversationAsync(string, CallSettings)
            // Additional: GetConversationAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversations/[CONVERSATION]";
            // Make the request
            Conversation response = await contactCenterInsightsClient.GetConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversation</summary>
        public void GetConversationResourceNames()
        {
            // Snippet: GetConversation(ConversationName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]");
            // Make the request
            Conversation response = contactCenterInsightsClient.GetConversation(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationAsync</summary>
        public async Task GetConversationResourceNamesAsync()
        {
            // Snippet: GetConversationAsync(ConversationName, CallSettings)
            // Additional: GetConversationAsync(ConversationName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]");
            // Make the request
            Conversation response = await contactCenterInsightsClient.GetConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConversations</summary>
        public void ListConversationsRequestObject()
        {
            // Snippet: ListConversations(ListConversationsRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                View = ConversationView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = contactCenterInsightsClient.ListConversations(request);

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
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                View = ConversationView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = contactCenterInsightsClient.ListConversationsAsync(request);

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
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = contactCenterInsightsClient.ListConversations(parent);

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
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = contactCenterInsightsClient.ListConversationsAsync(parent);

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
        public void ListConversationsResourceNames()
        {
            // Snippet: ListConversations(LocationName, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = contactCenterInsightsClient.ListConversations(parent);

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
        public async Task ListConversationsResourceNamesAsync()
        {
            // Snippet: ListConversationsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = contactCenterInsightsClient.ListConversationsAsync(parent);

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

        /// <summary>Snippet for DeleteConversation</summary>
        public void DeleteConversationRequestObject()
        {
            // Snippet: DeleteConversation(DeleteConversationRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            DeleteConversationRequest request = new DeleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                Force = false,
            };
            // Make the request
            contactCenterInsightsClient.DeleteConversation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationAsync</summary>
        public async Task DeleteConversationRequestObjectAsync()
        {
            // Snippet: DeleteConversationAsync(DeleteConversationRequest, CallSettings)
            // Additional: DeleteConversationAsync(DeleteConversationRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConversationRequest request = new DeleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                Force = false,
            };
            // Make the request
            await contactCenterInsightsClient.DeleteConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversation</summary>
        public void DeleteConversation()
        {
            // Snippet: DeleteConversation(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversations/[CONVERSATION]";
            // Make the request
            contactCenterInsightsClient.DeleteConversation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationAsync</summary>
        public async Task DeleteConversationAsync()
        {
            // Snippet: DeleteConversationAsync(string, CallSettings)
            // Additional: DeleteConversationAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversations/[CONVERSATION]";
            // Make the request
            await contactCenterInsightsClient.DeleteConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversation</summary>
        public void DeleteConversationResourceNames()
        {
            // Snippet: DeleteConversation(ConversationName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]");
            // Make the request
            contactCenterInsightsClient.DeleteConversation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationAsync</summary>
        public async Task DeleteConversationResourceNamesAsync()
        {
            // Snippet: DeleteConversationAsync(ConversationName, CallSettings)
            // Additional: DeleteConversationAsync(ConversationName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]");
            // Make the request
            await contactCenterInsightsClient.DeleteConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateAnalysis</summary>
        public void CreateAnalysisRequestObject()
        {
            // Snippet: CreateAnalysis(CreateAnalysisRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            CreateAnalysisRequest request = new CreateAnalysisRequest
            {
                ParentAsConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                Analysis = new Analysis(),
            };
            // Make the request
            Operation<Analysis, CreateAnalysisOperationMetadata> response = contactCenterInsightsClient.CreateAnalysis(request);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, CreateAnalysisOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, CreateAnalysisOperationMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceCreateAnalysis(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnalysisAsync</summary>
        public async Task CreateAnalysisRequestObjectAsync()
        {
            // Snippet: CreateAnalysisAsync(CreateAnalysisRequest, CallSettings)
            // Additional: CreateAnalysisAsync(CreateAnalysisRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            CreateAnalysisRequest request = new CreateAnalysisRequest
            {
                ParentAsConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                Analysis = new Analysis(),
            };
            // Make the request
            Operation<Analysis, CreateAnalysisOperationMetadata> response = await contactCenterInsightsClient.CreateAnalysisAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, CreateAnalysisOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, CreateAnalysisOperationMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceCreateAnalysisAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnalysis</summary>
        public void CreateAnalysis()
        {
            // Snippet: CreateAnalysis(string, Analysis, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/conversations/[CONVERSATION]";
            Analysis analysis = new Analysis();
            // Make the request
            Operation<Analysis, CreateAnalysisOperationMetadata> response = contactCenterInsightsClient.CreateAnalysis(parent, analysis);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, CreateAnalysisOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, CreateAnalysisOperationMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceCreateAnalysis(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnalysisAsync</summary>
        public async Task CreateAnalysisAsync()
        {
            // Snippet: CreateAnalysisAsync(string, Analysis, CallSettings)
            // Additional: CreateAnalysisAsync(string, Analysis, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/conversations/[CONVERSATION]";
            Analysis analysis = new Analysis();
            // Make the request
            Operation<Analysis, CreateAnalysisOperationMetadata> response = await contactCenterInsightsClient.CreateAnalysisAsync(parent, analysis);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, CreateAnalysisOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, CreateAnalysisOperationMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceCreateAnalysisAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnalysis</summary>
        public void CreateAnalysisResourceNames()
        {
            // Snippet: CreateAnalysis(ConversationName, Analysis, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ConversationName parent = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]");
            Analysis analysis = new Analysis();
            // Make the request
            Operation<Analysis, CreateAnalysisOperationMetadata> response = contactCenterInsightsClient.CreateAnalysis(parent, analysis);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, CreateAnalysisOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, CreateAnalysisOperationMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceCreateAnalysis(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAnalysisAsync</summary>
        public async Task CreateAnalysisResourceNamesAsync()
        {
            // Snippet: CreateAnalysisAsync(ConversationName, Analysis, CallSettings)
            // Additional: CreateAnalysisAsync(ConversationName, Analysis, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName parent = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]");
            Analysis analysis = new Analysis();
            // Make the request
            Operation<Analysis, CreateAnalysisOperationMetadata> response = await contactCenterInsightsClient.CreateAnalysisAsync(parent, analysis);

            // Poll until the returned long-running operation is complete
            Operation<Analysis, CreateAnalysisOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Analysis result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Analysis, CreateAnalysisOperationMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceCreateAnalysisAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Analysis retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAnalysis</summary>
        public void GetAnalysisRequestObject()
        {
            // Snippet: GetAnalysis(GetAnalysisRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            GetAnalysisRequest request = new GetAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            // Make the request
            Analysis response = contactCenterInsightsClient.GetAnalysis(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnalysisAsync</summary>
        public async Task GetAnalysisRequestObjectAsync()
        {
            // Snippet: GetAnalysisAsync(GetAnalysisRequest, CallSettings)
            // Additional: GetAnalysisAsync(GetAnalysisRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            GetAnalysisRequest request = new GetAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            // Make the request
            Analysis response = await contactCenterInsightsClient.GetAnalysisAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnalysis</summary>
        public void GetAnalysis()
        {
            // Snippet: GetAnalysis(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversations/[CONVERSATION]/analyses/[ANALYSIS]";
            // Make the request
            Analysis response = contactCenterInsightsClient.GetAnalysis(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnalysisAsync</summary>
        public async Task GetAnalysisAsync()
        {
            // Snippet: GetAnalysisAsync(string, CallSettings)
            // Additional: GetAnalysisAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversations/[CONVERSATION]/analyses/[ANALYSIS]";
            // Make the request
            Analysis response = await contactCenterInsightsClient.GetAnalysisAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnalysis</summary>
        public void GetAnalysisResourceNames()
        {
            // Snippet: GetAnalysis(AnalysisName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            AnalysisName name = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]");
            // Make the request
            Analysis response = contactCenterInsightsClient.GetAnalysis(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnalysisAsync</summary>
        public async Task GetAnalysisResourceNamesAsync()
        {
            // Snippet: GetAnalysisAsync(AnalysisName, CallSettings)
            // Additional: GetAnalysisAsync(AnalysisName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            AnalysisName name = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]");
            // Make the request
            Analysis response = await contactCenterInsightsClient.GetAnalysisAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAnalyses</summary>
        public void ListAnalysesRequestObject()
        {
            // Snippet: ListAnalyses(ListAnalysesRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ListAnalysesRequest request = new ListAnalysesRequest
            {
                ParentAsConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListAnalysesResponse, Analysis> response = contactCenterInsightsClient.ListAnalyses(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Analysis item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalysesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Analysis item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Analysis> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Analysis item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalysesAsync</summary>
        public async Task ListAnalysesRequestObjectAsync()
        {
            // Snippet: ListAnalysesAsync(ListAnalysesRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ListAnalysesRequest request = new ListAnalysesRequest
            {
                ParentAsConversationName = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListAnalysesResponse, Analysis> response = contactCenterInsightsClient.ListAnalysesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Analysis item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnalysesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Analysis item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Analysis> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Analysis item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyses</summary>
        public void ListAnalyses()
        {
            // Snippet: ListAnalyses(string, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/conversations/[CONVERSATION]";
            // Make the request
            PagedEnumerable<ListAnalysesResponse, Analysis> response = contactCenterInsightsClient.ListAnalyses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Analysis item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalysesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Analysis item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Analysis> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Analysis item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalysesAsync</summary>
        public async Task ListAnalysesAsync()
        {
            // Snippet: ListAnalysesAsync(string, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/conversations/[CONVERSATION]";
            // Make the request
            PagedAsyncEnumerable<ListAnalysesResponse, Analysis> response = contactCenterInsightsClient.ListAnalysesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Analysis item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnalysesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Analysis item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Analysis> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Analysis item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalyses</summary>
        public void ListAnalysesResourceNames()
        {
            // Snippet: ListAnalyses(ConversationName, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ConversationName parent = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]");
            // Make the request
            PagedEnumerable<ListAnalysesResponse, Analysis> response = contactCenterInsightsClient.ListAnalyses(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Analysis item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAnalysesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Analysis item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Analysis> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Analysis item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAnalysesAsync</summary>
        public async Task ListAnalysesResourceNamesAsync()
        {
            // Snippet: ListAnalysesAsync(ConversationName, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName parent = ConversationName.FromProjectLocationConversation("[PROJECT]", "[LOCATION]", "[CONVERSATION]");
            // Make the request
            PagedAsyncEnumerable<ListAnalysesResponse, Analysis> response = contactCenterInsightsClient.ListAnalysesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Analysis item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAnalysesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Analysis item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Analysis> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Analysis item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalysis</summary>
        public void DeleteAnalysisRequestObject()
        {
            // Snippet: DeleteAnalysis(DeleteAnalysisRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            DeleteAnalysisRequest request = new DeleteAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            // Make the request
            contactCenterInsightsClient.DeleteAnalysis(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalysisAsync</summary>
        public async Task DeleteAnalysisRequestObjectAsync()
        {
            // Snippet: DeleteAnalysisAsync(DeleteAnalysisRequest, CallSettings)
            // Additional: DeleteAnalysisAsync(DeleteAnalysisRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAnalysisRequest request = new DeleteAnalysisRequest
            {
                AnalysisName = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]"),
            };
            // Make the request
            await contactCenterInsightsClient.DeleteAnalysisAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalysis</summary>
        public void DeleteAnalysis()
        {
            // Snippet: DeleteAnalysis(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversations/[CONVERSATION]/analyses/[ANALYSIS]";
            // Make the request
            contactCenterInsightsClient.DeleteAnalysis(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalysisAsync</summary>
        public async Task DeleteAnalysisAsync()
        {
            // Snippet: DeleteAnalysisAsync(string, CallSettings)
            // Additional: DeleteAnalysisAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/conversations/[CONVERSATION]/analyses/[ANALYSIS]";
            // Make the request
            await contactCenterInsightsClient.DeleteAnalysisAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalysis</summary>
        public void DeleteAnalysisResourceNames()
        {
            // Snippet: DeleteAnalysis(AnalysisName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            AnalysisName name = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]");
            // Make the request
            contactCenterInsightsClient.DeleteAnalysis(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAnalysisAsync</summary>
        public async Task DeleteAnalysisResourceNamesAsync()
        {
            // Snippet: DeleteAnalysisAsync(AnalysisName, CallSettings)
            // Additional: DeleteAnalysisAsync(AnalysisName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            AnalysisName name = AnalysisName.FromProjectLocationConversationAnalysis("[PROJECT]", "[LOCATION]", "[CONVERSATION]", "[ANALYSIS]");
            // Make the request
            await contactCenterInsightsClient.DeleteAnalysisAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BulkAnalyzeConversations</summary>
        public void BulkAnalyzeConversationsRequestObject()
        {
            // Snippet: BulkAnalyzeConversations(BulkAnalyzeConversationsRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            BulkAnalyzeConversationsRequest request = new BulkAnalyzeConversationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                AnalysisPercentage = 0F,
                AnnotatorSelector = new AnnotatorSelector(),
            };
            // Make the request
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> response = contactCenterInsightsClient.BulkAnalyzeConversations(request);

            // Poll until the returned long-running operation is complete
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BulkAnalyzeConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceBulkAnalyzeConversations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkAnalyzeConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkAnalyzeConversationsAsync</summary>
        public async Task BulkAnalyzeConversationsRequestObjectAsync()
        {
            // Snippet: BulkAnalyzeConversationsAsync(BulkAnalyzeConversationsRequest, CallSettings)
            // Additional: BulkAnalyzeConversationsAsync(BulkAnalyzeConversationsRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            BulkAnalyzeConversationsRequest request = new BulkAnalyzeConversationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                AnalysisPercentage = 0F,
                AnnotatorSelector = new AnnotatorSelector(),
            };
            // Make the request
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> response = await contactCenterInsightsClient.BulkAnalyzeConversationsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BulkAnalyzeConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceBulkAnalyzeConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkAnalyzeConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkAnalyzeConversations</summary>
        public void BulkAnalyzeConversations()
        {
            // Snippet: BulkAnalyzeConversations(string, string, float, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string filter = "";
            float analysisPercentage = 0F;
            // Make the request
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> response = contactCenterInsightsClient.BulkAnalyzeConversations(parent, filter, analysisPercentage);

            // Poll until the returned long-running operation is complete
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BulkAnalyzeConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceBulkAnalyzeConversations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkAnalyzeConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkAnalyzeConversationsAsync</summary>
        public async Task BulkAnalyzeConversationsAsync()
        {
            // Snippet: BulkAnalyzeConversationsAsync(string, string, float, CallSettings)
            // Additional: BulkAnalyzeConversationsAsync(string, string, float, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string filter = "";
            float analysisPercentage = 0F;
            // Make the request
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> response = await contactCenterInsightsClient.BulkAnalyzeConversationsAsync(parent, filter, analysisPercentage);

            // Poll until the returned long-running operation is complete
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BulkAnalyzeConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceBulkAnalyzeConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkAnalyzeConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkAnalyzeConversations</summary>
        public void BulkAnalyzeConversationsResourceNames()
        {
            // Snippet: BulkAnalyzeConversations(LocationName, string, float, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string filter = "";
            float analysisPercentage = 0F;
            // Make the request
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> response = contactCenterInsightsClient.BulkAnalyzeConversations(parent, filter, analysisPercentage);

            // Poll until the returned long-running operation is complete
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BulkAnalyzeConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceBulkAnalyzeConversations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkAnalyzeConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkAnalyzeConversationsAsync</summary>
        public async Task BulkAnalyzeConversationsResourceNamesAsync()
        {
            // Snippet: BulkAnalyzeConversationsAsync(LocationName, string, float, CallSettings)
            // Additional: BulkAnalyzeConversationsAsync(LocationName, string, float, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string filter = "";
            float analysisPercentage = 0F;
            // Make the request
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> response = await contactCenterInsightsClient.BulkAnalyzeConversationsAsync(parent, filter, analysisPercentage);

            // Poll until the returned long-running operation is complete
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BulkAnalyzeConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkAnalyzeConversationsResponse, BulkAnalyzeConversationsMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceBulkAnalyzeConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkAnalyzeConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkDeleteConversations</summary>
        public void BulkDeleteConversationsRequestObject()
        {
            // Snippet: BulkDeleteConversations(BulkDeleteConversationsRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            BulkDeleteConversationsRequest request = new BulkDeleteConversationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                MaxDeleteCount = 0,
                Force = false,
            };
            // Make the request
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> response = contactCenterInsightsClient.BulkDeleteConversations(request);

            // Poll until the returned long-running operation is complete
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BulkDeleteConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceBulkDeleteConversations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkDeleteConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkDeleteConversationsAsync</summary>
        public async Task BulkDeleteConversationsRequestObjectAsync()
        {
            // Snippet: BulkDeleteConversationsAsync(BulkDeleteConversationsRequest, CallSettings)
            // Additional: BulkDeleteConversationsAsync(BulkDeleteConversationsRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            BulkDeleteConversationsRequest request = new BulkDeleteConversationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
                MaxDeleteCount = 0,
                Force = false,
            };
            // Make the request
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> response = await contactCenterInsightsClient.BulkDeleteConversationsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BulkDeleteConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceBulkDeleteConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkDeleteConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkDeleteConversations</summary>
        public void BulkDeleteConversations()
        {
            // Snippet: BulkDeleteConversations(string, string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string filter = "";
            // Make the request
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> response = contactCenterInsightsClient.BulkDeleteConversations(parent, filter);

            // Poll until the returned long-running operation is complete
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BulkDeleteConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceBulkDeleteConversations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkDeleteConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkDeleteConversationsAsync</summary>
        public async Task BulkDeleteConversationsAsync()
        {
            // Snippet: BulkDeleteConversationsAsync(string, string, CallSettings)
            // Additional: BulkDeleteConversationsAsync(string, string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string filter = "";
            // Make the request
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> response = await contactCenterInsightsClient.BulkDeleteConversationsAsync(parent, filter);

            // Poll until the returned long-running operation is complete
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BulkDeleteConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceBulkDeleteConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkDeleteConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkDeleteConversations</summary>
        public void BulkDeleteConversationsResourceNames()
        {
            // Snippet: BulkDeleteConversations(LocationName, string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string filter = "";
            // Make the request
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> response = contactCenterInsightsClient.BulkDeleteConversations(parent, filter);

            // Poll until the returned long-running operation is complete
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            BulkDeleteConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceBulkDeleteConversations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkDeleteConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for BulkDeleteConversationsAsync</summary>
        public async Task BulkDeleteConversationsResourceNamesAsync()
        {
            // Snippet: BulkDeleteConversationsAsync(LocationName, string, CallSettings)
            // Additional: BulkDeleteConversationsAsync(LocationName, string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string filter = "";
            // Make the request
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> response = await contactCenterInsightsClient.BulkDeleteConversationsAsync(parent, filter);

            // Poll until the returned long-running operation is complete
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            BulkDeleteConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<BulkDeleteConversationsResponse, BulkDeleteConversationsMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceBulkDeleteConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                BulkDeleteConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IngestConversations</summary>
        public void IngestConversationsRequestObject()
        {
            // Snippet: IngestConversations(IngestConversationsRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            IngestConversationsRequest request = new IngestConversationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GcsSource = new IngestConversationsRequest.Types.GcsSource(),
                TranscriptObjectConfig = new IngestConversationsRequest.Types.TranscriptObjectConfig(),
                ConversationConfig = new IngestConversationsRequest.Types.ConversationConfig(),
                RedactionConfig = new RedactionConfig(),
                SpeechConfig = new SpeechConfig(),
            };
            // Make the request
            Operation<IngestConversationsResponse, IngestConversationsMetadata> response = contactCenterInsightsClient.IngestConversations(request);

            // Poll until the returned long-running operation is complete
            Operation<IngestConversationsResponse, IngestConversationsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IngestConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestConversationsResponse, IngestConversationsMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceIngestConversations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IngestConversationsAsync</summary>
        public async Task IngestConversationsRequestObjectAsync()
        {
            // Snippet: IngestConversationsAsync(IngestConversationsRequest, CallSettings)
            // Additional: IngestConversationsAsync(IngestConversationsRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            IngestConversationsRequest request = new IngestConversationsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                GcsSource = new IngestConversationsRequest.Types.GcsSource(),
                TranscriptObjectConfig = new IngestConversationsRequest.Types.TranscriptObjectConfig(),
                ConversationConfig = new IngestConversationsRequest.Types.ConversationConfig(),
                RedactionConfig = new RedactionConfig(),
                SpeechConfig = new SpeechConfig(),
            };
            // Make the request
            Operation<IngestConversationsResponse, IngestConversationsMetadata> response = await contactCenterInsightsClient.IngestConversationsAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<IngestConversationsResponse, IngestConversationsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IngestConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestConversationsResponse, IngestConversationsMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceIngestConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IngestConversations</summary>
        public void IngestConversations()
        {
            // Snippet: IngestConversations(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            Operation<IngestConversationsResponse, IngestConversationsMetadata> response = contactCenterInsightsClient.IngestConversations(parent);

            // Poll until the returned long-running operation is complete
            Operation<IngestConversationsResponse, IngestConversationsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IngestConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestConversationsResponse, IngestConversationsMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceIngestConversations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IngestConversationsAsync</summary>
        public async Task IngestConversationsAsync()
        {
            // Snippet: IngestConversationsAsync(string, CallSettings)
            // Additional: IngestConversationsAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            Operation<IngestConversationsResponse, IngestConversationsMetadata> response = await contactCenterInsightsClient.IngestConversationsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<IngestConversationsResponse, IngestConversationsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IngestConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestConversationsResponse, IngestConversationsMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceIngestConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IngestConversations</summary>
        public void IngestConversationsResourceNames()
        {
            // Snippet: IngestConversations(LocationName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Operation<IngestConversationsResponse, IngestConversationsMetadata> response = contactCenterInsightsClient.IngestConversations(parent);

            // Poll until the returned long-running operation is complete
            Operation<IngestConversationsResponse, IngestConversationsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IngestConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestConversationsResponse, IngestConversationsMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceIngestConversations(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for IngestConversationsAsync</summary>
        public async Task IngestConversationsResourceNamesAsync()
        {
            // Snippet: IngestConversationsAsync(LocationName, CallSettings)
            // Additional: IngestConversationsAsync(LocationName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Operation<IngestConversationsResponse, IngestConversationsMetadata> response = await contactCenterInsightsClient.IngestConversationsAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<IngestConversationsResponse, IngestConversationsMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IngestConversationsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IngestConversationsResponse, IngestConversationsMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceIngestConversationsAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IngestConversationsResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportInsightsData</summary>
        public void ExportInsightsDataRequestObject()
        {
            // Snippet: ExportInsightsData(ExportInsightsDataRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ExportInsightsDataRequest request = new ExportInsightsDataRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BigQueryDestination = new ExportInsightsDataRequest.Types.BigQueryDestination(),
                Filter = "",
                KmsKey = "",
                WriteDisposition = ExportInsightsDataRequest.Types.WriteDisposition.Unspecified,
            };
            // Make the request
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> response = contactCenterInsightsClient.ExportInsightsData(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportInsightsDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceExportInsightsData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportInsightsDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportInsightsDataAsync</summary>
        public async Task ExportInsightsDataRequestObjectAsync()
        {
            // Snippet: ExportInsightsDataAsync(ExportInsightsDataRequest, CallSettings)
            // Additional: ExportInsightsDataAsync(ExportInsightsDataRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ExportInsightsDataRequest request = new ExportInsightsDataRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                BigQueryDestination = new ExportInsightsDataRequest.Types.BigQueryDestination(),
                Filter = "",
                KmsKey = "",
                WriteDisposition = ExportInsightsDataRequest.Types.WriteDisposition.Unspecified,
            };
            // Make the request
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> response = await contactCenterInsightsClient.ExportInsightsDataAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportInsightsDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceExportInsightsDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportInsightsDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportInsightsData</summary>
        public void ExportInsightsData()
        {
            // Snippet: ExportInsightsData(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> response = contactCenterInsightsClient.ExportInsightsData(parent);

            // Poll until the returned long-running operation is complete
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportInsightsDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceExportInsightsData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportInsightsDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportInsightsDataAsync</summary>
        public async Task ExportInsightsDataAsync()
        {
            // Snippet: ExportInsightsDataAsync(string, CallSettings)
            // Additional: ExportInsightsDataAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> response = await contactCenterInsightsClient.ExportInsightsDataAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportInsightsDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceExportInsightsDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportInsightsDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportInsightsData</summary>
        public void ExportInsightsDataResourceNames()
        {
            // Snippet: ExportInsightsData(LocationName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> response = contactCenterInsightsClient.ExportInsightsData(parent);

            // Poll until the returned long-running operation is complete
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            ExportInsightsDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceExportInsightsData(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportInsightsDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ExportInsightsDataAsync</summary>
        public async Task ExportInsightsDataResourceNamesAsync()
        {
            // Snippet: ExportInsightsDataAsync(LocationName, CallSettings)
            // Additional: ExportInsightsDataAsync(LocationName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> response = await contactCenterInsightsClient.ExportInsightsDataAsync(parent);

            // Poll until the returned long-running operation is complete
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ExportInsightsDataResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ExportInsightsDataResponse, ExportInsightsDataMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceExportInsightsDataAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ExportInsightsDataResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueModel</summary>
        public void CreateIssueModelRequestObject()
        {
            // Snippet: CreateIssueModel(CreateIssueModelRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            CreateIssueModelRequest request = new CreateIssueModelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                IssueModel = new IssueModel(),
            };
            // Make the request
            Operation<IssueModel, CreateIssueModelMetadata> response = contactCenterInsightsClient.CreateIssueModel(request);

            // Poll until the returned long-running operation is complete
            Operation<IssueModel, CreateIssueModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IssueModel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueModel, CreateIssueModelMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceCreateIssueModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueModel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueModelAsync</summary>
        public async Task CreateIssueModelRequestObjectAsync()
        {
            // Snippet: CreateIssueModelAsync(CreateIssueModelRequest, CallSettings)
            // Additional: CreateIssueModelAsync(CreateIssueModelRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            CreateIssueModelRequest request = new CreateIssueModelRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                IssueModel = new IssueModel(),
            };
            // Make the request
            Operation<IssueModel, CreateIssueModelMetadata> response = await contactCenterInsightsClient.CreateIssueModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<IssueModel, CreateIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IssueModel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueModel, CreateIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceCreateIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueModel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueModel</summary>
        public void CreateIssueModel()
        {
            // Snippet: CreateIssueModel(string, IssueModel, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IssueModel issueModel = new IssueModel();
            // Make the request
            Operation<IssueModel, CreateIssueModelMetadata> response = contactCenterInsightsClient.CreateIssueModel(parent, issueModel);

            // Poll until the returned long-running operation is complete
            Operation<IssueModel, CreateIssueModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IssueModel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueModel, CreateIssueModelMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceCreateIssueModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueModel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueModelAsync</summary>
        public async Task CreateIssueModelAsync()
        {
            // Snippet: CreateIssueModelAsync(string, IssueModel, CallSettings)
            // Additional: CreateIssueModelAsync(string, IssueModel, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            IssueModel issueModel = new IssueModel();
            // Make the request
            Operation<IssueModel, CreateIssueModelMetadata> response = await contactCenterInsightsClient.CreateIssueModelAsync(parent, issueModel);

            // Poll until the returned long-running operation is complete
            Operation<IssueModel, CreateIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IssueModel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueModel, CreateIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceCreateIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueModel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueModel</summary>
        public void CreateIssueModelResourceNames()
        {
            // Snippet: CreateIssueModel(LocationName, IssueModel, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IssueModel issueModel = new IssueModel();
            // Make the request
            Operation<IssueModel, CreateIssueModelMetadata> response = contactCenterInsightsClient.CreateIssueModel(parent, issueModel);

            // Poll until the returned long-running operation is complete
            Operation<IssueModel, CreateIssueModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IssueModel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueModel, CreateIssueModelMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceCreateIssueModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueModel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateIssueModelAsync</summary>
        public async Task CreateIssueModelResourceNamesAsync()
        {
            // Snippet: CreateIssueModelAsync(LocationName, IssueModel, CallSettings)
            // Additional: CreateIssueModelAsync(LocationName, IssueModel, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IssueModel issueModel = new IssueModel();
            // Make the request
            Operation<IssueModel, CreateIssueModelMetadata> response = await contactCenterInsightsClient.CreateIssueModelAsync(parent, issueModel);

            // Poll until the returned long-running operation is complete
            Operation<IssueModel, CreateIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            IssueModel result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IssueModel, CreateIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceCreateIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IssueModel retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateIssueModel</summary>
        public void UpdateIssueModelRequestObject()
        {
            // Snippet: UpdateIssueModel(UpdateIssueModelRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            UpdateIssueModelRequest request = new UpdateIssueModelRequest
            {
                IssueModel = new IssueModel(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            IssueModel response = contactCenterInsightsClient.UpdateIssueModel(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIssueModelAsync</summary>
        public async Task UpdateIssueModelRequestObjectAsync()
        {
            // Snippet: UpdateIssueModelAsync(UpdateIssueModelRequest, CallSettings)
            // Additional: UpdateIssueModelAsync(UpdateIssueModelRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateIssueModelRequest request = new UpdateIssueModelRequest
            {
                IssueModel = new IssueModel(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            IssueModel response = await contactCenterInsightsClient.UpdateIssueModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIssueModel</summary>
        public void UpdateIssueModel()
        {
            // Snippet: UpdateIssueModel(IssueModel, FieldMask, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            IssueModel issueModel = new IssueModel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            IssueModel response = contactCenterInsightsClient.UpdateIssueModel(issueModel, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateIssueModelAsync</summary>
        public async Task UpdateIssueModelAsync()
        {
            // Snippet: UpdateIssueModelAsync(IssueModel, FieldMask, CallSettings)
            // Additional: UpdateIssueModelAsync(IssueModel, FieldMask, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            IssueModel issueModel = new IssueModel();
            FieldMask updateMask = new FieldMask();
            // Make the request
            IssueModel response = await contactCenterInsightsClient.UpdateIssueModelAsync(issueModel, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetIssueModel</summary>
        public void GetIssueModelRequestObject()
        {
            // Snippet: GetIssueModel(GetIssueModelRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            GetIssueModelRequest request = new GetIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            IssueModel response = contactCenterInsightsClient.GetIssueModel(request);
            // End snippet
        }

        /// <summary>Snippet for GetIssueModelAsync</summary>
        public async Task GetIssueModelRequestObjectAsync()
        {
            // Snippet: GetIssueModelAsync(GetIssueModelRequest, CallSettings)
            // Additional: GetIssueModelAsync(GetIssueModelRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            GetIssueModelRequest request = new GetIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            IssueModel response = await contactCenterInsightsClient.GetIssueModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIssueModel</summary>
        public void GetIssueModel()
        {
            // Snippet: GetIssueModel(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]";
            // Make the request
            IssueModel response = contactCenterInsightsClient.GetIssueModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetIssueModelAsync</summary>
        public async Task GetIssueModelAsync()
        {
            // Snippet: GetIssueModelAsync(string, CallSettings)
            // Additional: GetIssueModelAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]";
            // Make the request
            IssueModel response = await contactCenterInsightsClient.GetIssueModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIssueModel</summary>
        public void GetIssueModelResourceNames()
        {
            // Snippet: GetIssueModel(IssueModelName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            IssueModelName name = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]");
            // Make the request
            IssueModel response = contactCenterInsightsClient.GetIssueModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetIssueModelAsync</summary>
        public async Task GetIssueModelResourceNamesAsync()
        {
            // Snippet: GetIssueModelAsync(IssueModelName, CallSettings)
            // Additional: GetIssueModelAsync(IssueModelName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            IssueModelName name = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]");
            // Make the request
            IssueModel response = await contactCenterInsightsClient.GetIssueModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListIssueModels</summary>
        public void ListIssueModelsRequestObject()
        {
            // Snippet: ListIssueModels(ListIssueModelsRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ListIssueModelsRequest request = new ListIssueModelsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            ListIssueModelsResponse response = contactCenterInsightsClient.ListIssueModels(request);
            // End snippet
        }

        /// <summary>Snippet for ListIssueModelsAsync</summary>
        public async Task ListIssueModelsRequestObjectAsync()
        {
            // Snippet: ListIssueModelsAsync(ListIssueModelsRequest, CallSettings)
            // Additional: ListIssueModelsAsync(ListIssueModelsRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ListIssueModelsRequest request = new ListIssueModelsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            ListIssueModelsResponse response = await contactCenterInsightsClient.ListIssueModelsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListIssueModels</summary>
        public void ListIssueModels()
        {
            // Snippet: ListIssueModels(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            ListIssueModelsResponse response = contactCenterInsightsClient.ListIssueModels(parent);
            // End snippet
        }

        /// <summary>Snippet for ListIssueModelsAsync</summary>
        public async Task ListIssueModelsAsync()
        {
            // Snippet: ListIssueModelsAsync(string, CallSettings)
            // Additional: ListIssueModelsAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            ListIssueModelsResponse response = await contactCenterInsightsClient.ListIssueModelsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListIssueModels</summary>
        public void ListIssueModelsResourceNames()
        {
            // Snippet: ListIssueModels(LocationName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            ListIssueModelsResponse response = contactCenterInsightsClient.ListIssueModels(parent);
            // End snippet
        }

        /// <summary>Snippet for ListIssueModelsAsync</summary>
        public async Task ListIssueModelsResourceNamesAsync()
        {
            // Snippet: ListIssueModelsAsync(LocationName, CallSettings)
            // Additional: ListIssueModelsAsync(LocationName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            ListIssueModelsResponse response = await contactCenterInsightsClient.ListIssueModelsAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueModel</summary>
        public void DeleteIssueModelRequestObject()
        {
            // Snippet: DeleteIssueModel(DeleteIssueModelRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            DeleteIssueModelRequest request = new DeleteIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            Operation<Empty, DeleteIssueModelMetadata> response = contactCenterInsightsClient.DeleteIssueModel(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteIssueModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteIssueModelMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceDeleteIssueModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueModelAsync</summary>
        public async Task DeleteIssueModelRequestObjectAsync()
        {
            // Snippet: DeleteIssueModelAsync(DeleteIssueModelRequest, CallSettings)
            // Additional: DeleteIssueModelAsync(DeleteIssueModelRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIssueModelRequest request = new DeleteIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            Operation<Empty, DeleteIssueModelMetadata> response = await contactCenterInsightsClient.DeleteIssueModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceDeleteIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueModel</summary>
        public void DeleteIssueModel()
        {
            // Snippet: DeleteIssueModel(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]";
            // Make the request
            Operation<Empty, DeleteIssueModelMetadata> response = contactCenterInsightsClient.DeleteIssueModel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteIssueModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteIssueModelMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceDeleteIssueModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueModelAsync</summary>
        public async Task DeleteIssueModelAsync()
        {
            // Snippet: DeleteIssueModelAsync(string, CallSettings)
            // Additional: DeleteIssueModelAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]";
            // Make the request
            Operation<Empty, DeleteIssueModelMetadata> response = await contactCenterInsightsClient.DeleteIssueModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceDeleteIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueModel</summary>
        public void DeleteIssueModelResourceNames()
        {
            // Snippet: DeleteIssueModel(IssueModelName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            IssueModelName name = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]");
            // Make the request
            Operation<Empty, DeleteIssueModelMetadata> response = contactCenterInsightsClient.DeleteIssueModel(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteIssueModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteIssueModelMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceDeleteIssueModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueModelAsync</summary>
        public async Task DeleteIssueModelResourceNamesAsync()
        {
            // Snippet: DeleteIssueModelAsync(IssueModelName, CallSettings)
            // Additional: DeleteIssueModelAsync(IssueModelName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            IssueModelName name = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]");
            // Make the request
            Operation<Empty, DeleteIssueModelMetadata> response = await contactCenterInsightsClient.DeleteIssueModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceDeleteIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIssueModel</summary>
        public void DeployIssueModelRequestObject()
        {
            // Snippet: DeployIssueModel(DeployIssueModelRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            DeployIssueModelRequest request = new DeployIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> response = contactCenterInsightsClient.DeployIssueModel(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceDeployIssueModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIssueModelAsync</summary>
        public async Task DeployIssueModelRequestObjectAsync()
        {
            // Snippet: DeployIssueModelAsync(DeployIssueModelRequest, CallSettings)
            // Additional: DeployIssueModelAsync(DeployIssueModelRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DeployIssueModelRequest request = new DeployIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> response = await contactCenterInsightsClient.DeployIssueModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceDeployIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIssueModel</summary>
        public void DeployIssueModel()
        {
            // Snippet: DeployIssueModel(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]";
            // Make the request
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> response = contactCenterInsightsClient.DeployIssueModel(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceDeployIssueModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIssueModelAsync</summary>
        public async Task DeployIssueModelAsync()
        {
            // Snippet: DeployIssueModelAsync(string, CallSettings)
            // Additional: DeployIssueModelAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]";
            // Make the request
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> response = await contactCenterInsightsClient.DeployIssueModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceDeployIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIssueModel</summary>
        public void DeployIssueModelResourceNames()
        {
            // Snippet: DeployIssueModel(IssueModelName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            IssueModelName name = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]");
            // Make the request
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> response = contactCenterInsightsClient.DeployIssueModel(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceDeployIssueModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeployIssueModelAsync</summary>
        public async Task DeployIssueModelResourceNamesAsync()
        {
            // Snippet: DeployIssueModelAsync(IssueModelName, CallSettings)
            // Additional: DeployIssueModelAsync(IssueModelName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            IssueModelName name = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]");
            // Make the request
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> response = await contactCenterInsightsClient.DeployIssueModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployIssueModelResponse, DeployIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceDeployIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIssueModel</summary>
        public void UndeployIssueModelRequestObject()
        {
            // Snippet: UndeployIssueModel(UndeployIssueModelRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            UndeployIssueModelRequest request = new UndeployIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> response = contactCenterInsightsClient.UndeployIssueModel(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceUndeployIssueModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIssueModelAsync</summary>
        public async Task UndeployIssueModelRequestObjectAsync()
        {
            // Snippet: UndeployIssueModelAsync(UndeployIssueModelRequest, CallSettings)
            // Additional: UndeployIssueModelAsync(UndeployIssueModelRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            UndeployIssueModelRequest request = new UndeployIssueModelRequest
            {
                IssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> response = await contactCenterInsightsClient.UndeployIssueModelAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceUndeployIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIssueModel</summary>
        public void UndeployIssueModel()
        {
            // Snippet: UndeployIssueModel(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]";
            // Make the request
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> response = contactCenterInsightsClient.UndeployIssueModel(name);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceUndeployIssueModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIssueModelAsync</summary>
        public async Task UndeployIssueModelAsync()
        {
            // Snippet: UndeployIssueModelAsync(string, CallSettings)
            // Additional: UndeployIssueModelAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]";
            // Make the request
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> response = await contactCenterInsightsClient.UndeployIssueModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceUndeployIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIssueModel</summary>
        public void UndeployIssueModelResourceNames()
        {
            // Snippet: UndeployIssueModel(IssueModelName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            IssueModelName name = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]");
            // Make the request
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> response = contactCenterInsightsClient.UndeployIssueModel(name);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            UndeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> retrievedResponse = contactCenterInsightsClient.PollOnceUndeployIssueModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeployIssueModelAsync</summary>
        public async Task UndeployIssueModelResourceNamesAsync()
        {
            // Snippet: UndeployIssueModelAsync(IssueModelName, CallSettings)
            // Additional: UndeployIssueModelAsync(IssueModelName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            IssueModelName name = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]");
            // Make the request
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> response = await contactCenterInsightsClient.UndeployIssueModelAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            UndeployIssueModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<UndeployIssueModelResponse, UndeployIssueModelMetadata> retrievedResponse = await contactCenterInsightsClient.PollOnceUndeployIssueModelAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                UndeployIssueModelResponse retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIssue</summary>
        public void GetIssueRequestObject()
        {
            // Snippet: GetIssue(GetIssueRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            GetIssueRequest request = new GetIssueRequest
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
            };
            // Make the request
            Issue response = contactCenterInsightsClient.GetIssue(request);
            // End snippet
        }

        /// <summary>Snippet for GetIssueAsync</summary>
        public async Task GetIssueRequestObjectAsync()
        {
            // Snippet: GetIssueAsync(GetIssueRequest, CallSettings)
            // Additional: GetIssueAsync(GetIssueRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            GetIssueRequest request = new GetIssueRequest
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
            };
            // Make the request
            Issue response = await contactCenterInsightsClient.GetIssueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIssue</summary>
        public void GetIssue()
        {
            // Snippet: GetIssue(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]/issues/[ISSUE]";
            // Make the request
            Issue response = contactCenterInsightsClient.GetIssue(name);
            // End snippet
        }

        /// <summary>Snippet for GetIssueAsync</summary>
        public async Task GetIssueAsync()
        {
            // Snippet: GetIssueAsync(string, CallSettings)
            // Additional: GetIssueAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]/issues/[ISSUE]";
            // Make the request
            Issue response = await contactCenterInsightsClient.GetIssueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetIssue</summary>
        public void GetIssueResourceNames()
        {
            // Snippet: GetIssue(IssueName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]");
            // Make the request
            Issue response = contactCenterInsightsClient.GetIssue(name);
            // End snippet
        }

        /// <summary>Snippet for GetIssueAsync</summary>
        public async Task GetIssueResourceNamesAsync()
        {
            // Snippet: GetIssueAsync(IssueName, CallSettings)
            // Additional: GetIssueAsync(IssueName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]");
            // Make the request
            Issue response = await contactCenterInsightsClient.GetIssueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListIssues</summary>
        public void ListIssuesRequestObject()
        {
            // Snippet: ListIssues(ListIssuesRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ListIssuesRequest request = new ListIssuesRequest
            {
                ParentAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            ListIssuesResponse response = contactCenterInsightsClient.ListIssues(request);
            // End snippet
        }

        /// <summary>Snippet for ListIssuesAsync</summary>
        public async Task ListIssuesRequestObjectAsync()
        {
            // Snippet: ListIssuesAsync(ListIssuesRequest, CallSettings)
            // Additional: ListIssuesAsync(ListIssuesRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ListIssuesRequest request = new ListIssuesRequest
            {
                ParentAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            ListIssuesResponse response = await contactCenterInsightsClient.ListIssuesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListIssues</summary>
        public void ListIssues()
        {
            // Snippet: ListIssues(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]";
            // Make the request
            ListIssuesResponse response = contactCenterInsightsClient.ListIssues(parent);
            // End snippet
        }

        /// <summary>Snippet for ListIssuesAsync</summary>
        public async Task ListIssuesAsync()
        {
            // Snippet: ListIssuesAsync(string, CallSettings)
            // Additional: ListIssuesAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]";
            // Make the request
            ListIssuesResponse response = await contactCenterInsightsClient.ListIssuesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListIssues</summary>
        public void ListIssuesResourceNames()
        {
            // Snippet: ListIssues(IssueModelName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            IssueModelName parent = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]");
            // Make the request
            ListIssuesResponse response = contactCenterInsightsClient.ListIssues(parent);
            // End snippet
        }

        /// <summary>Snippet for ListIssuesAsync</summary>
        public async Task ListIssuesResourceNamesAsync()
        {
            // Snippet: ListIssuesAsync(IssueModelName, CallSettings)
            // Additional: ListIssuesAsync(IssueModelName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            IssueModelName parent = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]");
            // Make the request
            ListIssuesResponse response = await contactCenterInsightsClient.ListIssuesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for UpdateIssue</summary>
        public void UpdateIssueRequestObject()
        {
            // Snippet: UpdateIssue(UpdateIssueRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            UpdateIssueRequest request = new UpdateIssueRequest
            {
                Issue = new Issue(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Issue response = contactCenterInsightsClient.UpdateIssue(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIssueAsync</summary>
        public async Task UpdateIssueRequestObjectAsync()
        {
            // Snippet: UpdateIssueAsync(UpdateIssueRequest, CallSettings)
            // Additional: UpdateIssueAsync(UpdateIssueRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateIssueRequest request = new UpdateIssueRequest
            {
                Issue = new Issue(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Issue response = await contactCenterInsightsClient.UpdateIssueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateIssue</summary>
        public void UpdateIssue()
        {
            // Snippet: UpdateIssue(Issue, FieldMask, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            Issue issue = new Issue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Issue response = contactCenterInsightsClient.UpdateIssue(issue, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateIssueAsync</summary>
        public async Task UpdateIssueAsync()
        {
            // Snippet: UpdateIssueAsync(Issue, FieldMask, CallSettings)
            // Additional: UpdateIssueAsync(Issue, FieldMask, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            Issue issue = new Issue();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Issue response = await contactCenterInsightsClient.UpdateIssueAsync(issue, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteIssue</summary>
        public void DeleteIssueRequestObject()
        {
            // Snippet: DeleteIssue(DeleteIssueRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            DeleteIssueRequest request = new DeleteIssueRequest
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
            };
            // Make the request
            contactCenterInsightsClient.DeleteIssue(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueAsync</summary>
        public async Task DeleteIssueRequestObjectAsync()
        {
            // Snippet: DeleteIssueAsync(DeleteIssueRequest, CallSettings)
            // Additional: DeleteIssueAsync(DeleteIssueRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteIssueRequest request = new DeleteIssueRequest
            {
                IssueName = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]"),
            };
            // Make the request
            await contactCenterInsightsClient.DeleteIssueAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteIssue</summary>
        public void DeleteIssue()
        {
            // Snippet: DeleteIssue(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]/issues/[ISSUE]";
            // Make the request
            contactCenterInsightsClient.DeleteIssue(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueAsync</summary>
        public async Task DeleteIssueAsync()
        {
            // Snippet: DeleteIssueAsync(string, CallSettings)
            // Additional: DeleteIssueAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]/issues/[ISSUE]";
            // Make the request
            await contactCenterInsightsClient.DeleteIssueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIssue</summary>
        public void DeleteIssueResourceNames()
        {
            // Snippet: DeleteIssue(IssueName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]");
            // Make the request
            contactCenterInsightsClient.DeleteIssue(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteIssueAsync</summary>
        public async Task DeleteIssueResourceNamesAsync()
        {
            // Snippet: DeleteIssueAsync(IssueName, CallSettings)
            // Additional: DeleteIssueAsync(IssueName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            IssueName name = IssueName.FromProjectLocationIssueModelIssue("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]", "[ISSUE]");
            // Make the request
            await contactCenterInsightsClient.DeleteIssueAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CalculateIssueModelStats</summary>
        public void CalculateIssueModelStatsRequestObject()
        {
            // Snippet: CalculateIssueModelStats(CalculateIssueModelStatsRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            CalculateIssueModelStatsRequest request = new CalculateIssueModelStatsRequest
            {
                IssueModelAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            CalculateIssueModelStatsResponse response = contactCenterInsightsClient.CalculateIssueModelStats(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateIssueModelStatsAsync</summary>
        public async Task CalculateIssueModelStatsRequestObjectAsync()
        {
            // Snippet: CalculateIssueModelStatsAsync(CalculateIssueModelStatsRequest, CallSettings)
            // Additional: CalculateIssueModelStatsAsync(CalculateIssueModelStatsRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            CalculateIssueModelStatsRequest request = new CalculateIssueModelStatsRequest
            {
                IssueModelAsIssueModelName = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]"),
            };
            // Make the request
            CalculateIssueModelStatsResponse response = await contactCenterInsightsClient.CalculateIssueModelStatsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateIssueModelStats</summary>
        public void CalculateIssueModelStats()
        {
            // Snippet: CalculateIssueModelStats(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string issueModel = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]";
            // Make the request
            CalculateIssueModelStatsResponse response = contactCenterInsightsClient.CalculateIssueModelStats(issueModel);
            // End snippet
        }

        /// <summary>Snippet for CalculateIssueModelStatsAsync</summary>
        public async Task CalculateIssueModelStatsAsync()
        {
            // Snippet: CalculateIssueModelStatsAsync(string, CallSettings)
            // Additional: CalculateIssueModelStatsAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string issueModel = "projects/[PROJECT]/locations/[LOCATION]/issueModels/[ISSUE_MODEL]";
            // Make the request
            CalculateIssueModelStatsResponse response = await contactCenterInsightsClient.CalculateIssueModelStatsAsync(issueModel);
            // End snippet
        }

        /// <summary>Snippet for CalculateIssueModelStats</summary>
        public void CalculateIssueModelStatsResourceNames()
        {
            // Snippet: CalculateIssueModelStats(IssueModelName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            IssueModelName issueModel = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]");
            // Make the request
            CalculateIssueModelStatsResponse response = contactCenterInsightsClient.CalculateIssueModelStats(issueModel);
            // End snippet
        }

        /// <summary>Snippet for CalculateIssueModelStatsAsync</summary>
        public async Task CalculateIssueModelStatsResourceNamesAsync()
        {
            // Snippet: CalculateIssueModelStatsAsync(IssueModelName, CallSettings)
            // Additional: CalculateIssueModelStatsAsync(IssueModelName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            IssueModelName issueModel = IssueModelName.FromProjectLocationIssueModel("[PROJECT]", "[LOCATION]", "[ISSUE_MODEL]");
            // Make the request
            CalculateIssueModelStatsResponse response = await contactCenterInsightsClient.CalculateIssueModelStatsAsync(issueModel);
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseMatcher</summary>
        public void CreatePhraseMatcherRequestObject()
        {
            // Snippet: CreatePhraseMatcher(CreatePhraseMatcherRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            CreatePhraseMatcherRequest request = new CreatePhraseMatcherRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseMatcher = new PhraseMatcher(),
            };
            // Make the request
            PhraseMatcher response = contactCenterInsightsClient.CreatePhraseMatcher(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseMatcherAsync</summary>
        public async Task CreatePhraseMatcherRequestObjectAsync()
        {
            // Snippet: CreatePhraseMatcherAsync(CreatePhraseMatcherRequest, CallSettings)
            // Additional: CreatePhraseMatcherAsync(CreatePhraseMatcherRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            CreatePhraseMatcherRequest request = new CreatePhraseMatcherRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseMatcher = new PhraseMatcher(),
            };
            // Make the request
            PhraseMatcher response = await contactCenterInsightsClient.CreatePhraseMatcherAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseMatcher</summary>
        public void CreatePhraseMatcher()
        {
            // Snippet: CreatePhraseMatcher(string, PhraseMatcher, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PhraseMatcher phraseMatcher = new PhraseMatcher();
            // Make the request
            PhraseMatcher response = contactCenterInsightsClient.CreatePhraseMatcher(parent, phraseMatcher);
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseMatcherAsync</summary>
        public async Task CreatePhraseMatcherAsync()
        {
            // Snippet: CreatePhraseMatcherAsync(string, PhraseMatcher, CallSettings)
            // Additional: CreatePhraseMatcherAsync(string, PhraseMatcher, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            PhraseMatcher phraseMatcher = new PhraseMatcher();
            // Make the request
            PhraseMatcher response = await contactCenterInsightsClient.CreatePhraseMatcherAsync(parent, phraseMatcher);
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseMatcher</summary>
        public void CreatePhraseMatcherResourceNames()
        {
            // Snippet: CreatePhraseMatcher(LocationName, PhraseMatcher, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PhraseMatcher phraseMatcher = new PhraseMatcher();
            // Make the request
            PhraseMatcher response = contactCenterInsightsClient.CreatePhraseMatcher(parent, phraseMatcher);
            // End snippet
        }

        /// <summary>Snippet for CreatePhraseMatcherAsync</summary>
        public async Task CreatePhraseMatcherResourceNamesAsync()
        {
            // Snippet: CreatePhraseMatcherAsync(LocationName, PhraseMatcher, CallSettings)
            // Additional: CreatePhraseMatcherAsync(LocationName, PhraseMatcher, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            PhraseMatcher phraseMatcher = new PhraseMatcher();
            // Make the request
            PhraseMatcher response = await contactCenterInsightsClient.CreatePhraseMatcherAsync(parent, phraseMatcher);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseMatcher</summary>
        public void GetPhraseMatcherRequestObject()
        {
            // Snippet: GetPhraseMatcher(GetPhraseMatcherRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            GetPhraseMatcherRequest request = new GetPhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            // Make the request
            PhraseMatcher response = contactCenterInsightsClient.GetPhraseMatcher(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseMatcherAsync</summary>
        public async Task GetPhraseMatcherRequestObjectAsync()
        {
            // Snippet: GetPhraseMatcherAsync(GetPhraseMatcherRequest, CallSettings)
            // Additional: GetPhraseMatcherAsync(GetPhraseMatcherRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            GetPhraseMatcherRequest request = new GetPhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            // Make the request
            PhraseMatcher response = await contactCenterInsightsClient.GetPhraseMatcherAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseMatcher</summary>
        public void GetPhraseMatcher()
        {
            // Snippet: GetPhraseMatcher(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseMatchers/[PHRASE_MATCHER]";
            // Make the request
            PhraseMatcher response = contactCenterInsightsClient.GetPhraseMatcher(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseMatcherAsync</summary>
        public async Task GetPhraseMatcherAsync()
        {
            // Snippet: GetPhraseMatcherAsync(string, CallSettings)
            // Additional: GetPhraseMatcherAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseMatchers/[PHRASE_MATCHER]";
            // Make the request
            PhraseMatcher response = await contactCenterInsightsClient.GetPhraseMatcherAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseMatcher</summary>
        public void GetPhraseMatcherResourceNames()
        {
            // Snippet: GetPhraseMatcher(PhraseMatcherName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            PhraseMatcherName name = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]");
            // Make the request
            PhraseMatcher response = contactCenterInsightsClient.GetPhraseMatcher(name);
            // End snippet
        }

        /// <summary>Snippet for GetPhraseMatcherAsync</summary>
        public async Task GetPhraseMatcherResourceNamesAsync()
        {
            // Snippet: GetPhraseMatcherAsync(PhraseMatcherName, CallSettings)
            // Additional: GetPhraseMatcherAsync(PhraseMatcherName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            PhraseMatcherName name = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]");
            // Make the request
            PhraseMatcher response = await contactCenterInsightsClient.GetPhraseMatcherAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListPhraseMatchers</summary>
        public void ListPhraseMatchersRequestObject()
        {
            // Snippet: ListPhraseMatchers(ListPhraseMatchersRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ListPhraseMatchersRequest request = new ListPhraseMatchersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListPhraseMatchersResponse, PhraseMatcher> response = contactCenterInsightsClient.ListPhraseMatchers(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhraseMatcher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhraseMatchersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhraseMatcher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhraseMatcher> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhraseMatcher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhraseMatchersAsync</summary>
        public async Task ListPhraseMatchersRequestObjectAsync()
        {
            // Snippet: ListPhraseMatchersAsync(ListPhraseMatchersRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ListPhraseMatchersRequest request = new ListPhraseMatchersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListPhraseMatchersResponse, PhraseMatcher> response = contactCenterInsightsClient.ListPhraseMatchersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhraseMatcher item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhraseMatchersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhraseMatcher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhraseMatcher> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhraseMatcher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhraseMatchers</summary>
        public void ListPhraseMatchers()
        {
            // Snippet: ListPhraseMatchers(string, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListPhraseMatchersResponse, PhraseMatcher> response = contactCenterInsightsClient.ListPhraseMatchers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhraseMatcher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhraseMatchersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhraseMatcher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhraseMatcher> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhraseMatcher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhraseMatchersAsync</summary>
        public async Task ListPhraseMatchersAsync()
        {
            // Snippet: ListPhraseMatchersAsync(string, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListPhraseMatchersResponse, PhraseMatcher> response = contactCenterInsightsClient.ListPhraseMatchersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhraseMatcher item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhraseMatchersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhraseMatcher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhraseMatcher> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhraseMatcher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhraseMatchers</summary>
        public void ListPhraseMatchersResourceNames()
        {
            // Snippet: ListPhraseMatchers(LocationName, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListPhraseMatchersResponse, PhraseMatcher> response = contactCenterInsightsClient.ListPhraseMatchers(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (PhraseMatcher item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListPhraseMatchersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhraseMatcher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhraseMatcher> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhraseMatcher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListPhraseMatchersAsync</summary>
        public async Task ListPhraseMatchersResourceNamesAsync()
        {
            // Snippet: ListPhraseMatchersAsync(LocationName, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListPhraseMatchersResponse, PhraseMatcher> response = contactCenterInsightsClient.ListPhraseMatchersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((PhraseMatcher item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListPhraseMatchersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (PhraseMatcher item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<PhraseMatcher> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (PhraseMatcher item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseMatcher</summary>
        public void DeletePhraseMatcherRequestObject()
        {
            // Snippet: DeletePhraseMatcher(DeletePhraseMatcherRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            DeletePhraseMatcherRequest request = new DeletePhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            // Make the request
            contactCenterInsightsClient.DeletePhraseMatcher(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseMatcherAsync</summary>
        public async Task DeletePhraseMatcherRequestObjectAsync()
        {
            // Snippet: DeletePhraseMatcherAsync(DeletePhraseMatcherRequest, CallSettings)
            // Additional: DeletePhraseMatcherAsync(DeletePhraseMatcherRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DeletePhraseMatcherRequest request = new DeletePhraseMatcherRequest
            {
                PhraseMatcherName = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]"),
            };
            // Make the request
            await contactCenterInsightsClient.DeletePhraseMatcherAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseMatcher</summary>
        public void DeletePhraseMatcher()
        {
            // Snippet: DeletePhraseMatcher(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseMatchers/[PHRASE_MATCHER]";
            // Make the request
            contactCenterInsightsClient.DeletePhraseMatcher(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseMatcherAsync</summary>
        public async Task DeletePhraseMatcherAsync()
        {
            // Snippet: DeletePhraseMatcherAsync(string, CallSettings)
            // Additional: DeletePhraseMatcherAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/phraseMatchers/[PHRASE_MATCHER]";
            // Make the request
            await contactCenterInsightsClient.DeletePhraseMatcherAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseMatcher</summary>
        public void DeletePhraseMatcherResourceNames()
        {
            // Snippet: DeletePhraseMatcher(PhraseMatcherName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            PhraseMatcherName name = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]");
            // Make the request
            contactCenterInsightsClient.DeletePhraseMatcher(name);
            // End snippet
        }

        /// <summary>Snippet for DeletePhraseMatcherAsync</summary>
        public async Task DeletePhraseMatcherResourceNamesAsync()
        {
            // Snippet: DeletePhraseMatcherAsync(PhraseMatcherName, CallSettings)
            // Additional: DeletePhraseMatcherAsync(PhraseMatcherName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            PhraseMatcherName name = PhraseMatcherName.FromProjectLocationPhraseMatcher("[PROJECT]", "[LOCATION]", "[PHRASE_MATCHER]");
            // Make the request
            await contactCenterInsightsClient.DeletePhraseMatcherAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhraseMatcher</summary>
        public void UpdatePhraseMatcherRequestObject()
        {
            // Snippet: UpdatePhraseMatcher(UpdatePhraseMatcherRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            UpdatePhraseMatcherRequest request = new UpdatePhraseMatcherRequest
            {
                PhraseMatcher = new PhraseMatcher(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PhraseMatcher response = contactCenterInsightsClient.UpdatePhraseMatcher(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhraseMatcherAsync</summary>
        public async Task UpdatePhraseMatcherRequestObjectAsync()
        {
            // Snippet: UpdatePhraseMatcherAsync(UpdatePhraseMatcherRequest, CallSettings)
            // Additional: UpdatePhraseMatcherAsync(UpdatePhraseMatcherRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            UpdatePhraseMatcherRequest request = new UpdatePhraseMatcherRequest
            {
                PhraseMatcher = new PhraseMatcher(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            PhraseMatcher response = await contactCenterInsightsClient.UpdatePhraseMatcherAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhraseMatcher</summary>
        public void UpdatePhraseMatcher()
        {
            // Snippet: UpdatePhraseMatcher(PhraseMatcher, FieldMask, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            PhraseMatcher phraseMatcher = new PhraseMatcher();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PhraseMatcher response = contactCenterInsightsClient.UpdatePhraseMatcher(phraseMatcher, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdatePhraseMatcherAsync</summary>
        public async Task UpdatePhraseMatcherAsync()
        {
            // Snippet: UpdatePhraseMatcherAsync(PhraseMatcher, FieldMask, CallSettings)
            // Additional: UpdatePhraseMatcherAsync(PhraseMatcher, FieldMask, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            PhraseMatcher phraseMatcher = new PhraseMatcher();
            FieldMask updateMask = new FieldMask();
            // Make the request
            PhraseMatcher response = await contactCenterInsightsClient.UpdatePhraseMatcherAsync(phraseMatcher, updateMask);
            // End snippet
        }

        /// <summary>Snippet for CalculateStats</summary>
        public void CalculateStatsRequestObject()
        {
            // Snippet: CalculateStats(CalculateStatsRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            CalculateStatsRequest request = new CalculateStatsRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            CalculateStatsResponse response = contactCenterInsightsClient.CalculateStats(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateStatsAsync</summary>
        public async Task CalculateStatsRequestObjectAsync()
        {
            // Snippet: CalculateStatsAsync(CalculateStatsRequest, CallSettings)
            // Additional: CalculateStatsAsync(CalculateStatsRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            CalculateStatsRequest request = new CalculateStatsRequest
            {
                LocationAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            CalculateStatsResponse response = await contactCenterInsightsClient.CalculateStatsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CalculateStats</summary>
        public void CalculateStats()
        {
            // Snippet: CalculateStats(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            CalculateStatsResponse response = contactCenterInsightsClient.CalculateStats(location);
            // End snippet
        }

        /// <summary>Snippet for CalculateStatsAsync</summary>
        public async Task CalculateStatsAsync()
        {
            // Snippet: CalculateStatsAsync(string, CallSettings)
            // Additional: CalculateStatsAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string location = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            CalculateStatsResponse response = await contactCenterInsightsClient.CalculateStatsAsync(location);
            // End snippet
        }

        /// <summary>Snippet for CalculateStats</summary>
        public void CalculateStatsResourceNames()
        {
            // Snippet: CalculateStats(LocationName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            CalculateStatsResponse response = contactCenterInsightsClient.CalculateStats(location);
            // End snippet
        }

        /// <summary>Snippet for CalculateStatsAsync</summary>
        public async Task CalculateStatsResourceNamesAsync()
        {
            // Snippet: CalculateStatsAsync(LocationName, CallSettings)
            // Additional: CalculateStatsAsync(LocationName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName location = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            CalculateStatsResponse response = await contactCenterInsightsClient.CalculateStatsAsync(location);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettingsRequestObject()
        {
            // Snippet: GetSettings(GetSettingsRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Settings response = contactCenterInsightsClient.GetSettings(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsRequestObjectAsync()
        {
            // Snippet: GetSettingsAsync(GetSettingsRequest, CallSettings)
            // Additional: GetSettingsAsync(GetSettingsRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            GetSettingsRequest request = new GetSettingsRequest
            {
                SettingsName = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            Settings response = await contactCenterInsightsClient.GetSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettings()
        {
            // Snippet: GetSettings(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/settings";
            // Make the request
            Settings response = contactCenterInsightsClient.GetSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsAsync()
        {
            // Snippet: GetSettingsAsync(string, CallSettings)
            // Additional: GetSettingsAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/settings";
            // Make the request
            Settings response = await contactCenterInsightsClient.GetSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettings</summary>
        public void GetSettingsResourceNames()
        {
            // Snippet: GetSettings(SettingsName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Settings response = contactCenterInsightsClient.GetSettings(name);
            // End snippet
        }

        /// <summary>Snippet for GetSettingsAsync</summary>
        public async Task GetSettingsResourceNamesAsync()
        {
            // Snippet: GetSettingsAsync(SettingsName, CallSettings)
            // Additional: GetSettingsAsync(SettingsName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            SettingsName name = SettingsName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            Settings response = await contactCenterInsightsClient.GetSettingsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettings</summary>
        public void UpdateSettingsRequestObject()
        {
            // Snippet: UpdateSettings(UpdateSettingsRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Settings response = contactCenterInsightsClient.UpdateSettings(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingsAsync</summary>
        public async Task UpdateSettingsRequestObjectAsync()
        {
            // Snippet: UpdateSettingsAsync(UpdateSettingsRequest, CallSettings)
            // Additional: UpdateSettingsAsync(UpdateSettingsRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSettingsRequest request = new UpdateSettingsRequest
            {
                Settings = new Settings(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Settings response = await contactCenterInsightsClient.UpdateSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettings</summary>
        public void UpdateSettings()
        {
            // Snippet: UpdateSettings(Settings, FieldMask, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            Settings settings = new Settings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Settings response = contactCenterInsightsClient.UpdateSettings(settings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSettingsAsync</summary>
        public async Task UpdateSettingsAsync()
        {
            // Snippet: UpdateSettingsAsync(Settings, FieldMask, CallSettings)
            // Additional: UpdateSettingsAsync(Settings, FieldMask, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            Settings settings = new Settings();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Settings response = await contactCenterInsightsClient.UpdateSettingsAsync(settings, updateMask);
            // End snippet
        }

        /// <summary>Snippet for CreateView</summary>
        public void CreateViewRequestObject()
        {
            // Snippet: CreateView(CreateViewRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            CreateViewRequest request = new CreateViewRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                View = new View(),
            };
            // Make the request
            View response = contactCenterInsightsClient.CreateView(request);
            // End snippet
        }

        /// <summary>Snippet for CreateViewAsync</summary>
        public async Task CreateViewRequestObjectAsync()
        {
            // Snippet: CreateViewAsync(CreateViewRequest, CallSettings)
            // Additional: CreateViewAsync(CreateViewRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            CreateViewRequest request = new CreateViewRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                View = new View(),
            };
            // Make the request
            View response = await contactCenterInsightsClient.CreateViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateView</summary>
        public void CreateView()
        {
            // Snippet: CreateView(string, View, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            View view = new View();
            // Make the request
            View response = contactCenterInsightsClient.CreateView(parent, view);
            // End snippet
        }

        /// <summary>Snippet for CreateViewAsync</summary>
        public async Task CreateViewAsync()
        {
            // Snippet: CreateViewAsync(string, View, CallSettings)
            // Additional: CreateViewAsync(string, View, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            View view = new View();
            // Make the request
            View response = await contactCenterInsightsClient.CreateViewAsync(parent, view);
            // End snippet
        }

        /// <summary>Snippet for CreateView</summary>
        public void CreateViewResourceNames()
        {
            // Snippet: CreateView(LocationName, View, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            View view = new View();
            // Make the request
            View response = contactCenterInsightsClient.CreateView(parent, view);
            // End snippet
        }

        /// <summary>Snippet for CreateViewAsync</summary>
        public async Task CreateViewResourceNamesAsync()
        {
            // Snippet: CreateViewAsync(LocationName, View, CallSettings)
            // Additional: CreateViewAsync(LocationName, View, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            View view = new View();
            // Make the request
            View response = await contactCenterInsightsClient.CreateViewAsync(parent, view);
            // End snippet
        }

        /// <summary>Snippet for GetView</summary>
        public void GetViewRequestObject()
        {
            // Snippet: GetView(GetViewRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            GetViewRequest request = new GetViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            // Make the request
            View response = contactCenterInsightsClient.GetView(request);
            // End snippet
        }

        /// <summary>Snippet for GetViewAsync</summary>
        public async Task GetViewRequestObjectAsync()
        {
            // Snippet: GetViewAsync(GetViewRequest, CallSettings)
            // Additional: GetViewAsync(GetViewRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            GetViewRequest request = new GetViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            // Make the request
            View response = await contactCenterInsightsClient.GetViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetView</summary>
        public void GetView()
        {
            // Snippet: GetView(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/views/[VIEW]";
            // Make the request
            View response = contactCenterInsightsClient.GetView(name);
            // End snippet
        }

        /// <summary>Snippet for GetViewAsync</summary>
        public async Task GetViewAsync()
        {
            // Snippet: GetViewAsync(string, CallSettings)
            // Additional: GetViewAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/views/[VIEW]";
            // Make the request
            View response = await contactCenterInsightsClient.GetViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetView</summary>
        public void GetViewResourceNames()
        {
            // Snippet: GetView(ViewName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ViewName name = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]");
            // Make the request
            View response = contactCenterInsightsClient.GetView(name);
            // End snippet
        }

        /// <summary>Snippet for GetViewAsync</summary>
        public async Task GetViewResourceNamesAsync()
        {
            // Snippet: GetViewAsync(ViewName, CallSettings)
            // Additional: GetViewAsync(ViewName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ViewName name = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]");
            // Make the request
            View response = await contactCenterInsightsClient.GetViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListViews</summary>
        public void ListViewsRequestObject()
        {
            // Snippet: ListViews(ListViewsRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ListViewsRequest request = new ListViewsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListViewsResponse, View> response = contactCenterInsightsClient.ListViews(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (View item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (View item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<View> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (View item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViewsAsync</summary>
        public async Task ListViewsRequestObjectAsync()
        {
            // Snippet: ListViewsAsync(ListViewsRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ListViewsRequest request = new ListViewsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListViewsResponse, View> response = contactCenterInsightsClient.ListViewsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((View item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (View item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<View> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (View item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViews</summary>
        public void ListViews()
        {
            // Snippet: ListViews(string, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListViewsResponse, View> response = contactCenterInsightsClient.ListViews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (View item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (View item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<View> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (View item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViewsAsync</summary>
        public async Task ListViewsAsync()
        {
            // Snippet: ListViewsAsync(string, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListViewsResponse, View> response = contactCenterInsightsClient.ListViewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((View item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (View item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<View> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (View item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViews</summary>
        public void ListViewsResourceNames()
        {
            // Snippet: ListViews(LocationName, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListViewsResponse, View> response = contactCenterInsightsClient.ListViews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (View item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (View item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<View> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (View item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListViewsAsync</summary>
        public async Task ListViewsResourceNamesAsync()
        {
            // Snippet: ListViewsAsync(LocationName, string, int?, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListViewsResponse, View> response = contactCenterInsightsClient.ListViewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((View item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (View item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<View> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (View item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateView</summary>
        public void UpdateViewRequestObject()
        {
            // Snippet: UpdateView(UpdateViewRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            UpdateViewRequest request = new UpdateViewRequest
            {
                View = new View(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            View response = contactCenterInsightsClient.UpdateView(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateViewAsync</summary>
        public async Task UpdateViewRequestObjectAsync()
        {
            // Snippet: UpdateViewAsync(UpdateViewRequest, CallSettings)
            // Additional: UpdateViewAsync(UpdateViewRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateViewRequest request = new UpdateViewRequest
            {
                View = new View(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            View response = await contactCenterInsightsClient.UpdateViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateView</summary>
        public void UpdateView()
        {
            // Snippet: UpdateView(View, FieldMask, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            View view = new View();
            FieldMask updateMask = new FieldMask();
            // Make the request
            View response = contactCenterInsightsClient.UpdateView(view, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateViewAsync</summary>
        public async Task UpdateViewAsync()
        {
            // Snippet: UpdateViewAsync(View, FieldMask, CallSettings)
            // Additional: UpdateViewAsync(View, FieldMask, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            View view = new View();
            FieldMask updateMask = new FieldMask();
            // Make the request
            View response = await contactCenterInsightsClient.UpdateViewAsync(view, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteView</summary>
        public void DeleteViewRequestObject()
        {
            // Snippet: DeleteView(DeleteViewRequest, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            DeleteViewRequest request = new DeleteViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            // Make the request
            contactCenterInsightsClient.DeleteView(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteViewAsync</summary>
        public async Task DeleteViewRequestObjectAsync()
        {
            // Snippet: DeleteViewAsync(DeleteViewRequest, CallSettings)
            // Additional: DeleteViewAsync(DeleteViewRequest, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            DeleteViewRequest request = new DeleteViewRequest
            {
                ViewName = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]"),
            };
            // Make the request
            await contactCenterInsightsClient.DeleteViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteView</summary>
        public void DeleteView()
        {
            // Snippet: DeleteView(string, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/views/[VIEW]";
            // Make the request
            contactCenterInsightsClient.DeleteView(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteViewAsync</summary>
        public async Task DeleteViewAsync()
        {
            // Snippet: DeleteViewAsync(string, CallSettings)
            // Additional: DeleteViewAsync(string, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/views/[VIEW]";
            // Make the request
            await contactCenterInsightsClient.DeleteViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteView</summary>
        public void DeleteViewResourceNames()
        {
            // Snippet: DeleteView(ViewName, CallSettings)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = ContactCenterInsightsClient.Create();
            // Initialize request argument(s)
            ViewName name = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]");
            // Make the request
            contactCenterInsightsClient.DeleteView(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteViewAsync</summary>
        public async Task DeleteViewResourceNamesAsync()
        {
            // Snippet: DeleteViewAsync(ViewName, CallSettings)
            // Additional: DeleteViewAsync(ViewName, CancellationToken)
            // Create client
            ContactCenterInsightsClient contactCenterInsightsClient = await ContactCenterInsightsClient.CreateAsync();
            // Initialize request argument(s)
            ViewName name = ViewName.FromProjectLocationView("[PROJECT]", "[LOCATION]", "[VIEW]");
            // Make the request
            await contactCenterInsightsClient.DeleteViewAsync(name);
            // End snippet
        }
    }
}
