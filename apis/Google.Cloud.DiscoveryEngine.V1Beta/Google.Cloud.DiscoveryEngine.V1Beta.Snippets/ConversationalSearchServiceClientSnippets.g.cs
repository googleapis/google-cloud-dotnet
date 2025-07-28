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
    using Google.Cloud.DiscoveryEngine.V1Beta;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConversationalSearchServiceClientSnippets
    {
        /// <summary>Snippet for ConverseConversation</summary>
        public void ConverseConversationRequestObject()
        {
            // Snippet: ConverseConversation(ConverseConversationRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            ConverseConversationRequest request = new ConverseConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationDataStoreConversation("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONVERSATION]"),
                Query = new TextInput(),
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]"),
                Conversation = new Conversation(),
                SafeSearch = false,
                UserLabels = { { "", "" }, },
                SummarySpec = new SearchRequest.Types.ContentSearchSpec.Types.SummarySpec(),
                Filter = "",
                BoostSpec = new SearchRequest.Types.BoostSpec(),
            };
            // Make the request
            ConverseConversationResponse response = conversationalSearchServiceClient.ConverseConversation(request);
            // End snippet
        }

        /// <summary>Snippet for ConverseConversationAsync</summary>
        public async Task ConverseConversationRequestObjectAsync()
        {
            // Snippet: ConverseConversationAsync(ConverseConversationRequest, CallSettings)
            // Additional: ConverseConversationAsync(ConverseConversationRequest, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConverseConversationRequest request = new ConverseConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationDataStoreConversation("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONVERSATION]"),
                Query = new TextInput(),
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]"),
                Conversation = new Conversation(),
                SafeSearch = false,
                UserLabels = { { "", "" }, },
                SummarySpec = new SearchRequest.Types.ContentSearchSpec.Types.SummarySpec(),
                Filter = "",
                BoostSpec = new SearchRequest.Types.BoostSpec(),
            };
            // Make the request
            ConverseConversationResponse response = await conversationalSearchServiceClient.ConverseConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ConverseConversation</summary>
        public void ConverseConversation()
        {
            // Snippet: ConverseConversation(string, TextInput, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/conversations/[CONVERSATION]";
            TextInput query = new TextInput();
            // Make the request
            ConverseConversationResponse response = conversationalSearchServiceClient.ConverseConversation(name, query);
            // End snippet
        }

        /// <summary>Snippet for ConverseConversationAsync</summary>
        public async Task ConverseConversationAsync()
        {
            // Snippet: ConverseConversationAsync(string, TextInput, CallSettings)
            // Additional: ConverseConversationAsync(string, TextInput, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/conversations/[CONVERSATION]";
            TextInput query = new TextInput();
            // Make the request
            ConverseConversationResponse response = await conversationalSearchServiceClient.ConverseConversationAsync(name, query);
            // End snippet
        }

        /// <summary>Snippet for ConverseConversation</summary>
        public void ConverseConversationResourceNames()
        {
            // Snippet: ConverseConversation(ConversationName, TextInput, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationDataStoreConversation("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONVERSATION]");
            TextInput query = new TextInput();
            // Make the request
            ConverseConversationResponse response = conversationalSearchServiceClient.ConverseConversation(name, query);
            // End snippet
        }

        /// <summary>Snippet for ConverseConversationAsync</summary>
        public async Task ConverseConversationResourceNamesAsync()
        {
            // Snippet: ConverseConversationAsync(ConversationName, TextInput, CallSettings)
            // Additional: ConverseConversationAsync(ConversationName, TextInput, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationDataStoreConversation("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONVERSATION]");
            TextInput query = new TextInput();
            // Make the request
            ConverseConversationResponse response = await conversationalSearchServiceClient.ConverseConversationAsync(name, query);
            // End snippet
        }

        /// <summary>Snippet for CreateConversation</summary>
        public void CreateConversationRequestObject()
        {
            // Snippet: CreateConversation(CreateConversationRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Conversation = new Conversation(),
            };
            // Make the request
            Conversation response = conversationalSearchServiceClient.CreateConversation(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationAsync</summary>
        public async Task CreateConversationRequestObjectAsync()
        {
            // Snippet: CreateConversationAsync(CreateConversationRequest, CallSettings)
            // Additional: CreateConversationAsync(CreateConversationRequest, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateConversationRequest request = new CreateConversationRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Conversation = new Conversation(),
            };
            // Make the request
            Conversation response = await conversationalSearchServiceClient.CreateConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConversation</summary>
        public void CreateConversation()
        {
            // Snippet: CreateConversation(string, Conversation, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            Conversation conversation = new Conversation();
            // Make the request
            Conversation response = conversationalSearchServiceClient.CreateConversation(parent, conversation);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationAsync</summary>
        public async Task CreateConversationAsync()
        {
            // Snippet: CreateConversationAsync(string, Conversation, CallSettings)
            // Additional: CreateConversationAsync(string, Conversation, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            Conversation conversation = new Conversation();
            // Make the request
            Conversation response = await conversationalSearchServiceClient.CreateConversationAsync(parent, conversation);
            // End snippet
        }

        /// <summary>Snippet for CreateConversation</summary>
        public void CreateConversationResourceNames()
        {
            // Snippet: CreateConversation(DataStoreName, Conversation, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            Conversation conversation = new Conversation();
            // Make the request
            Conversation response = conversationalSearchServiceClient.CreateConversation(parent, conversation);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationAsync</summary>
        public async Task CreateConversationResourceNamesAsync()
        {
            // Snippet: CreateConversationAsync(DataStoreName, Conversation, CallSettings)
            // Additional: CreateConversationAsync(DataStoreName, Conversation, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            Conversation conversation = new Conversation();
            // Make the request
            Conversation response = await conversationalSearchServiceClient.CreateConversationAsync(parent, conversation);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversation</summary>
        public void DeleteConversationRequestObject()
        {
            // Snippet: DeleteConversation(DeleteConversationRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            DeleteConversationRequest request = new DeleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationDataStoreConversation("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONVERSATION]"),
            };
            // Make the request
            conversationalSearchServiceClient.DeleteConversation(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationAsync</summary>
        public async Task DeleteConversationRequestObjectAsync()
        {
            // Snippet: DeleteConversationAsync(DeleteConversationRequest, CallSettings)
            // Additional: DeleteConversationAsync(DeleteConversationRequest, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConversationRequest request = new DeleteConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationDataStoreConversation("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONVERSATION]"),
            };
            // Make the request
            await conversationalSearchServiceClient.DeleteConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversation</summary>
        public void DeleteConversation()
        {
            // Snippet: DeleteConversation(string, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/conversations/[CONVERSATION]";
            // Make the request
            conversationalSearchServiceClient.DeleteConversation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationAsync</summary>
        public async Task DeleteConversationAsync()
        {
            // Snippet: DeleteConversationAsync(string, CallSettings)
            // Additional: DeleteConversationAsync(string, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/conversations/[CONVERSATION]";
            // Make the request
            await conversationalSearchServiceClient.DeleteConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversation</summary>
        public void DeleteConversationResourceNames()
        {
            // Snippet: DeleteConversation(ConversationName, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationDataStoreConversation("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONVERSATION]");
            // Make the request
            conversationalSearchServiceClient.DeleteConversation(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationAsync</summary>
        public async Task DeleteConversationResourceNamesAsync()
        {
            // Snippet: DeleteConversationAsync(ConversationName, CallSettings)
            // Additional: DeleteConversationAsync(ConversationName, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationDataStoreConversation("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONVERSATION]");
            // Make the request
            await conversationalSearchServiceClient.DeleteConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversation</summary>
        public void UpdateConversationRequestObject()
        {
            // Snippet: UpdateConversation(UpdateConversationRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            UpdateConversationRequest request = new UpdateConversationRequest
            {
                Conversation = new Conversation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Conversation response = conversationalSearchServiceClient.UpdateConversation(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversationAsync</summary>
        public async Task UpdateConversationRequestObjectAsync()
        {
            // Snippet: UpdateConversationAsync(UpdateConversationRequest, CallSettings)
            // Additional: UpdateConversationAsync(UpdateConversationRequest, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConversationRequest request = new UpdateConversationRequest
            {
                Conversation = new Conversation(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Conversation response = await conversationalSearchServiceClient.UpdateConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversation</summary>
        public void UpdateConversation()
        {
            // Snippet: UpdateConversation(Conversation, FieldMask, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            Conversation conversation = new Conversation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Conversation response = conversationalSearchServiceClient.UpdateConversation(conversation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversationAsync</summary>
        public async Task UpdateConversationAsync()
        {
            // Snippet: UpdateConversationAsync(Conversation, FieldMask, CallSettings)
            // Additional: UpdateConversationAsync(Conversation, FieldMask, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            Conversation conversation = new Conversation();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Conversation response = await conversationalSearchServiceClient.UpdateConversationAsync(conversation, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetConversation</summary>
        public void GetConversationRequestObject()
        {
            // Snippet: GetConversation(GetConversationRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationDataStoreConversation("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONVERSATION]"),
            };
            // Make the request
            Conversation response = conversationalSearchServiceClient.GetConversation(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversationAsync</summary>
        public async Task GetConversationRequestObjectAsync()
        {
            // Snippet: GetConversationAsync(GetConversationRequest, CallSettings)
            // Additional: GetConversationAsync(GetConversationRequest, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetConversationRequest request = new GetConversationRequest
            {
                ConversationName = ConversationName.FromProjectLocationDataStoreConversation("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONVERSATION]"),
            };
            // Make the request
            Conversation response = await conversationalSearchServiceClient.GetConversationAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversation</summary>
        public void GetConversation()
        {
            // Snippet: GetConversation(string, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/conversations/[CONVERSATION]";
            // Make the request
            Conversation response = conversationalSearchServiceClient.GetConversation(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationAsync</summary>
        public async Task GetConversationAsync()
        {
            // Snippet: GetConversationAsync(string, CallSettings)
            // Additional: GetConversationAsync(string, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/conversations/[CONVERSATION]";
            // Make the request
            Conversation response = await conversationalSearchServiceClient.GetConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversation</summary>
        public void GetConversationResourceNames()
        {
            // Snippet: GetConversation(ConversationName, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationDataStoreConversation("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONVERSATION]");
            // Make the request
            Conversation response = conversationalSearchServiceClient.GetConversation(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationAsync</summary>
        public async Task GetConversationResourceNamesAsync()
        {
            // Snippet: GetConversationAsync(ConversationName, CallSettings)
            // Additional: GetConversationAsync(ConversationName, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName name = ConversationName.FromProjectLocationDataStoreConversation("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[CONVERSATION]");
            // Make the request
            Conversation response = await conversationalSearchServiceClient.GetConversationAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListConversations</summary>
        public void ListConversationsRequestObject()
        {
            // Snippet: ListConversations(ListConversationsRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = conversationalSearchServiceClient.ListConversations(request);

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
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListConversationsRequest request = new ListConversationsRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = conversationalSearchServiceClient.ListConversationsAsync(request);

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
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = conversationalSearchServiceClient.ListConversations(parent);

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
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = conversationalSearchServiceClient.ListConversationsAsync(parent);

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
            // Snippet: ListConversations(DataStoreName, string, int?, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            PagedEnumerable<ListConversationsResponse, Conversation> response = conversationalSearchServiceClient.ListConversations(parent);

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
            // Snippet: ListConversationsAsync(DataStoreName, string, int?, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListConversationsResponse, Conversation> response = conversationalSearchServiceClient.ListConversationsAsync(parent);

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

        /// <summary>Snippet for AnswerQuery</summary>
        public void AnswerQueryRequestObject()
        {
            // Snippet: AnswerQuery(AnswerQueryRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            AnswerQueryRequest request = new AnswerQueryRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]"),
                Query = new Query(),
                SessionAsSessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
                SafetySpec = new AnswerQueryRequest.Types.SafetySpec(),
                RelatedQuestionsSpec = new AnswerQueryRequest.Types.RelatedQuestionsSpec(),
                GroundingSpec = new AnswerQueryRequest.Types.GroundingSpec(),
                AnswerGenerationSpec = new AnswerQueryRequest.Types.AnswerGenerationSpec(),
                SearchSpec = new AnswerQueryRequest.Types.SearchSpec(),
                QueryUnderstandingSpec = new AnswerQueryRequest.Types.QueryUnderstandingSpec(),
                UserPseudoId = "",
                UserLabels = { { "", "" }, },
            };
            // Make the request
            AnswerQueryResponse response = conversationalSearchServiceClient.AnswerQuery(request);
            // End snippet
        }

        /// <summary>Snippet for AnswerQueryAsync</summary>
        public async Task AnswerQueryRequestObjectAsync()
        {
            // Snippet: AnswerQueryAsync(AnswerQueryRequest, CallSettings)
            // Additional: AnswerQueryAsync(AnswerQueryRequest, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnswerQueryRequest request = new AnswerQueryRequest
            {
                ServingConfigAsServingConfigName = ServingConfigName.FromProjectLocationDataStoreServingConfig("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SERVING_CONFIG]"),
                Query = new Query(),
                SessionAsSessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
                SafetySpec = new AnswerQueryRequest.Types.SafetySpec(),
                RelatedQuestionsSpec = new AnswerQueryRequest.Types.RelatedQuestionsSpec(),
                GroundingSpec = new AnswerQueryRequest.Types.GroundingSpec(),
                AnswerGenerationSpec = new AnswerQueryRequest.Types.AnswerGenerationSpec(),
                SearchSpec = new AnswerQueryRequest.Types.SearchSpec(),
                QueryUnderstandingSpec = new AnswerQueryRequest.Types.QueryUnderstandingSpec(),
                UserPseudoId = "",
                UserLabels = { { "", "" }, },
            };
            // Make the request
            AnswerQueryResponse response = await conversationalSearchServiceClient.AnswerQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnswer</summary>
        public void GetAnswerRequestObject()
        {
            // Snippet: GetAnswer(GetAnswerRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            GetAnswerRequest request = new GetAnswerRequest
            {
                AnswerName = AnswerName.FromProjectLocationDataStoreSessionAnswer("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]", "[ANSWER]"),
            };
            // Make the request
            Answer response = conversationalSearchServiceClient.GetAnswer(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnswerAsync</summary>
        public async Task GetAnswerRequestObjectAsync()
        {
            // Snippet: GetAnswerAsync(GetAnswerRequest, CallSettings)
            // Additional: GetAnswerAsync(GetAnswerRequest, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetAnswerRequest request = new GetAnswerRequest
            {
                AnswerName = AnswerName.FromProjectLocationDataStoreSessionAnswer("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]", "[ANSWER]"),
            };
            // Make the request
            Answer response = await conversationalSearchServiceClient.GetAnswerAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAnswer</summary>
        public void GetAnswer()
        {
            // Snippet: GetAnswer(string, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/sessions/[SESSION]/answers/[ANSWER]";
            // Make the request
            Answer response = conversationalSearchServiceClient.GetAnswer(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnswerAsync</summary>
        public async Task GetAnswerAsync()
        {
            // Snippet: GetAnswerAsync(string, CallSettings)
            // Additional: GetAnswerAsync(string, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/sessions/[SESSION]/answers/[ANSWER]";
            // Make the request
            Answer response = await conversationalSearchServiceClient.GetAnswerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnswer</summary>
        public void GetAnswerResourceNames()
        {
            // Snippet: GetAnswer(AnswerName, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            AnswerName name = AnswerName.FromProjectLocationDataStoreSessionAnswer("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]", "[ANSWER]");
            // Make the request
            Answer response = conversationalSearchServiceClient.GetAnswer(name);
            // End snippet
        }

        /// <summary>Snippet for GetAnswerAsync</summary>
        public async Task GetAnswerResourceNamesAsync()
        {
            // Snippet: GetAnswerAsync(AnswerName, CallSettings)
            // Additional: GetAnswerAsync(AnswerName, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            AnswerName name = AnswerName.FromProjectLocationDataStoreSessionAnswer("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]", "[ANSWER]");
            // Make the request
            Answer response = await conversationalSearchServiceClient.GetAnswerAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSessionRequestObject()
        {
            // Snippet: CreateSession(CreateSessionRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            CreateSessionRequest request = new CreateSessionRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Session = new Session(),
            };
            // Make the request
            Session response = conversationalSearchServiceClient.CreateSession(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionRequestObjectAsync()
        {
            // Snippet: CreateSessionAsync(CreateSessionRequest, CallSettings)
            // Additional: CreateSessionAsync(CreateSessionRequest, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSessionRequest request = new CreateSessionRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Session = new Session(),
            };
            // Make the request
            Session response = await conversationalSearchServiceClient.CreateSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSession()
        {
            // Snippet: CreateSession(string, Session, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            Session session = new Session();
            // Make the request
            Session response = conversationalSearchServiceClient.CreateSession(parent, session);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionAsync()
        {
            // Snippet: CreateSessionAsync(string, Session, CallSettings)
            // Additional: CreateSessionAsync(string, Session, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            Session session = new Session();
            // Make the request
            Session response = await conversationalSearchServiceClient.CreateSessionAsync(parent, session);
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSessionResourceNames()
        {
            // Snippet: CreateSession(DataStoreName, Session, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            Session session = new Session();
            // Make the request
            Session response = conversationalSearchServiceClient.CreateSession(parent, session);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionResourceNamesAsync()
        {
            // Snippet: CreateSessionAsync(DataStoreName, Session, CallSettings)
            // Additional: CreateSessionAsync(DataStoreName, Session, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            Session session = new Session();
            // Make the request
            Session response = await conversationalSearchServiceClient.CreateSessionAsync(parent, session);
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSessionRequestObject()
        {
            // Snippet: DeleteSession(DeleteSessionRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
            };
            // Make the request
            conversationalSearchServiceClient.DeleteSession(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionRequestObjectAsync()
        {
            // Snippet: DeleteSessionAsync(DeleteSessionRequest, CallSettings)
            // Additional: DeleteSessionAsync(DeleteSessionRequest, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
            };
            // Make the request
            await conversationalSearchServiceClient.DeleteSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSession()
        {
            // Snippet: DeleteSession(string, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/sessions/[SESSION]";
            // Make the request
            conversationalSearchServiceClient.DeleteSession(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionAsync()
        {
            // Snippet: DeleteSessionAsync(string, CallSettings)
            // Additional: DeleteSessionAsync(string, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/sessions/[SESSION]";
            // Make the request
            await conversationalSearchServiceClient.DeleteSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSessionResourceNames()
        {
            // Snippet: DeleteSession(SessionName, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]");
            // Make the request
            conversationalSearchServiceClient.DeleteSession(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionResourceNamesAsync()
        {
            // Snippet: DeleteSessionAsync(SessionName, CallSettings)
            // Additional: DeleteSessionAsync(SessionName, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]");
            // Make the request
            await conversationalSearchServiceClient.DeleteSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSession</summary>
        public void UpdateSessionRequestObject()
        {
            // Snippet: UpdateSession(UpdateSessionRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            UpdateSessionRequest request = new UpdateSessionRequest
            {
                Session = new Session(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Session response = conversationalSearchServiceClient.UpdateSession(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionAsync</summary>
        public async Task UpdateSessionRequestObjectAsync()
        {
            // Snippet: UpdateSessionAsync(UpdateSessionRequest, CallSettings)
            // Additional: UpdateSessionAsync(UpdateSessionRequest, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSessionRequest request = new UpdateSessionRequest
            {
                Session = new Session(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Session response = await conversationalSearchServiceClient.UpdateSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSession</summary>
        public void UpdateSession()
        {
            // Snippet: UpdateSession(Session, FieldMask, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            Session session = new Session();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Session response = conversationalSearchServiceClient.UpdateSession(session, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionAsync</summary>
        public async Task UpdateSessionAsync()
        {
            // Snippet: UpdateSessionAsync(Session, FieldMask, CallSettings)
            // Additional: UpdateSessionAsync(Session, FieldMask, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            Session session = new Session();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Session response = await conversationalSearchServiceClient.UpdateSessionAsync(session, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSessionRequestObject()
        {
            // Snippet: GetSession(GetSessionRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
                IncludeAnswerDetails = false,
            };
            // Make the request
            Session response = conversationalSearchServiceClient.GetSession(request);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionRequestObjectAsync()
        {
            // Snippet: GetSessionAsync(GetSessionRequest, CallSettings)
            // Additional: GetSessionAsync(GetSessionRequest, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
                IncludeAnswerDetails = false,
            };
            // Make the request
            Session response = await conversationalSearchServiceClient.GetSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSession()
        {
            // Snippet: GetSession(string, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/sessions/[SESSION]";
            // Make the request
            Session response = conversationalSearchServiceClient.GetSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionAsync()
        {
            // Snippet: GetSessionAsync(string, CallSettings)
            // Additional: GetSessionAsync(string, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/sessions/[SESSION]";
            // Make the request
            Session response = await conversationalSearchServiceClient.GetSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSessionResourceNames()
        {
            // Snippet: GetSession(SessionName, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]");
            // Make the request
            Session response = conversationalSearchServiceClient.GetSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionResourceNamesAsync()
        {
            // Snippet: GetSessionAsync(SessionName, CallSettings)
            // Additional: GetSessionAsync(SessionName, CancellationToken)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]");
            // Make the request
            Session response = await conversationalSearchServiceClient.GetSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSessions</summary>
        public void ListSessionsRequestObject()
        {
            // Snippet: ListSessions(ListSessionsRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSessionsResponse, Session> response = conversationalSearchServiceClient.ListSessions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Session item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Session> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Session item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionsAsync</summary>
        public async Task ListSessionsRequestObjectAsync()
        {
            // Snippet: ListSessionsAsync(ListSessionsRequest, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSessionsResponse, Session> response = conversationalSearchServiceClient.ListSessionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Session item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Session> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Session item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessions</summary>
        public void ListSessions()
        {
            // Snippet: ListSessions(string, string, int?, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            // Make the request
            PagedEnumerable<ListSessionsResponse, Session> response = conversationalSearchServiceClient.ListSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Session item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Session> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Session item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionsAsync</summary>
        public async Task ListSessionsAsync()
        {
            // Snippet: ListSessionsAsync(string, string, int?, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            // Make the request
            PagedAsyncEnumerable<ListSessionsResponse, Session> response = conversationalSearchServiceClient.ListSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Session item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Session> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Session item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessions</summary>
        public void ListSessionsResourceNames()
        {
            // Snippet: ListSessions(DataStoreName, string, int?, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = ConversationalSearchServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            PagedEnumerable<ListSessionsResponse, Session> response = conversationalSearchServiceClient.ListSessions(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Session item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Session> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Session item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionsAsync</summary>
        public async Task ListSessionsResourceNamesAsync()
        {
            // Snippet: ListSessionsAsync(DataStoreName, string, int?, CallSettings)
            // Create client
            ConversationalSearchServiceClient conversationalSearchServiceClient = await ConversationalSearchServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListSessionsResponse, Session> response = conversationalSearchServiceClient.ListSessionsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Session item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Session> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Session item in singlePage)
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
