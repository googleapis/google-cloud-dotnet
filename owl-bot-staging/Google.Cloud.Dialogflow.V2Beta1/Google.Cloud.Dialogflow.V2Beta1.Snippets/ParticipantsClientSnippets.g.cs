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
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Dialogflow.V2Beta1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedParticipantsClientSnippets
    {
        /// <summary>Snippet for CreateParticipant</summary>
        public void CreateParticipantRequestObject()
        {
            // Snippet: CreateParticipant(CreateParticipantRequest, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            CreateParticipantRequest request = new CreateParticipantRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                Participant = new Participant(),
            };
            // Make the request
            Participant response = participantsClient.CreateParticipant(request);
            // End snippet
        }

        /// <summary>Snippet for CreateParticipantAsync</summary>
        public async Task CreateParticipantRequestObjectAsync()
        {
            // Snippet: CreateParticipantAsync(CreateParticipantRequest, CallSettings)
            // Additional: CreateParticipantAsync(CreateParticipantRequest, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            CreateParticipantRequest request = new CreateParticipantRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
                Participant = new Participant(),
            };
            // Make the request
            Participant response = await participantsClient.CreateParticipantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateParticipant</summary>
        public void CreateParticipant()
        {
            // Snippet: CreateParticipant(string, Participant, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]";
            Participant participant = new Participant();
            // Make the request
            Participant response = participantsClient.CreateParticipant(parent, participant);
            // End snippet
        }

        /// <summary>Snippet for CreateParticipantAsync</summary>
        public async Task CreateParticipantAsync()
        {
            // Snippet: CreateParticipantAsync(string, Participant, CallSettings)
            // Additional: CreateParticipantAsync(string, Participant, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]";
            Participant participant = new Participant();
            // Make the request
            Participant response = await participantsClient.CreateParticipantAsync(parent, participant);
            // End snippet
        }

        /// <summary>Snippet for CreateParticipant</summary>
        public void CreateParticipantResourceNames()
        {
            // Snippet: CreateParticipant(ConversationName, Participant, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            ConversationName parent = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            Participant participant = new Participant();
            // Make the request
            Participant response = participantsClient.CreateParticipant(parent, participant);
            // End snippet
        }

        /// <summary>Snippet for CreateParticipantAsync</summary>
        public async Task CreateParticipantResourceNamesAsync()
        {
            // Snippet: CreateParticipantAsync(ConversationName, Participant, CallSettings)
            // Additional: CreateParticipantAsync(ConversationName, Participant, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName parent = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            Participant participant = new Participant();
            // Make the request
            Participant response = await participantsClient.CreateParticipantAsync(parent, participant);
            // End snippet
        }

        /// <summary>Snippet for GetParticipant</summary>
        public void GetParticipantRequestObject()
        {
            // Snippet: GetParticipant(GetParticipantRequest, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            GetParticipantRequest request = new GetParticipantRequest
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            // Make the request
            Participant response = participantsClient.GetParticipant(request);
            // End snippet
        }

        /// <summary>Snippet for GetParticipantAsync</summary>
        public async Task GetParticipantRequestObjectAsync()
        {
            // Snippet: GetParticipantAsync(GetParticipantRequest, CallSettings)
            // Additional: GetParticipantAsync(GetParticipantRequest, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            GetParticipantRequest request = new GetParticipantRequest
            {
                ParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
            };
            // Make the request
            Participant response = await participantsClient.GetParticipantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetParticipant</summary>
        public void GetParticipant()
        {
            // Snippet: GetParticipant(string, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            // Make the request
            Participant response = participantsClient.GetParticipant(name);
            // End snippet
        }

        /// <summary>Snippet for GetParticipantAsync</summary>
        public async Task GetParticipantAsync()
        {
            // Snippet: GetParticipantAsync(string, CallSettings)
            // Additional: GetParticipantAsync(string, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            // Make the request
            Participant response = await participantsClient.GetParticipantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetParticipant</summary>
        public void GetParticipantResourceNames()
        {
            // Snippet: GetParticipant(ParticipantName, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            ParticipantName name = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            // Make the request
            Participant response = participantsClient.GetParticipant(name);
            // End snippet
        }

        /// <summary>Snippet for GetParticipantAsync</summary>
        public async Task GetParticipantResourceNamesAsync()
        {
            // Snippet: GetParticipantAsync(ParticipantName, CallSettings)
            // Additional: GetParticipantAsync(ParticipantName, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            ParticipantName name = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            // Make the request
            Participant response = await participantsClient.GetParticipantAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListParticipants</summary>
        public void ListParticipantsRequestObject()
        {
            // Snippet: ListParticipants(ListParticipantsRequest, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            ListParticipantsRequest request = new ListParticipantsRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            // Make the request
            PagedEnumerable<ListParticipantsResponse, Participant> response = participantsClient.ListParticipants(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Participant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParticipantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Participant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Participant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Participant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipantsAsync</summary>
        public async Task ListParticipantsRequestObjectAsync()
        {
            // Snippet: ListParticipantsAsync(ListParticipantsRequest, CallSettings)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            ListParticipantsRequest request = new ListParticipantsRequest
            {
                ParentAsConversationName = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListParticipantsResponse, Participant> response = participantsClient.ListParticipantsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Participant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParticipantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Participant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Participant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Participant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipants</summary>
        public void ListParticipants()
        {
            // Snippet: ListParticipants(string, string, int?, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]";
            // Make the request
            PagedEnumerable<ListParticipantsResponse, Participant> response = participantsClient.ListParticipants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Participant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParticipantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Participant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Participant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Participant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipantsAsync</summary>
        public async Task ListParticipantsAsync()
        {
            // Snippet: ListParticipantsAsync(string, string, int?, CallSettings)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]";
            // Make the request
            PagedAsyncEnumerable<ListParticipantsResponse, Participant> response = participantsClient.ListParticipantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Participant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParticipantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Participant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Participant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Participant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipants</summary>
        public void ListParticipantsResourceNames()
        {
            // Snippet: ListParticipants(ConversationName, string, int?, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            ConversationName parent = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            // Make the request
            PagedEnumerable<ListParticipantsResponse, Participant> response = participantsClient.ListParticipants(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Participant item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListParticipantsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Participant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Participant> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Participant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListParticipantsAsync</summary>
        public async Task ListParticipantsResourceNamesAsync()
        {
            // Snippet: ListParticipantsAsync(ConversationName, string, int?, CallSettings)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            ConversationName parent = ConversationName.FromProjectConversation("[PROJECT]", "[CONVERSATION]");
            // Make the request
            PagedAsyncEnumerable<ListParticipantsResponse, Participant> response = participantsClient.ListParticipantsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Participant item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListParticipantsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Participant item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Participant> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Participant item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for UpdateParticipant</summary>
        public void UpdateParticipantRequestObject()
        {
            // Snippet: UpdateParticipant(UpdateParticipantRequest, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            UpdateParticipantRequest request = new UpdateParticipantRequest
            {
                Participant = new Participant(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Participant response = participantsClient.UpdateParticipant(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateParticipantAsync</summary>
        public async Task UpdateParticipantRequestObjectAsync()
        {
            // Snippet: UpdateParticipantAsync(UpdateParticipantRequest, CallSettings)
            // Additional: UpdateParticipantAsync(UpdateParticipantRequest, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            UpdateParticipantRequest request = new UpdateParticipantRequest
            {
                Participant = new Participant(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Participant response = await participantsClient.UpdateParticipantAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateParticipant</summary>
        public void UpdateParticipant()
        {
            // Snippet: UpdateParticipant(Participant, FieldMask, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            Participant participant = new Participant();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Participant response = participantsClient.UpdateParticipant(participant, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateParticipantAsync</summary>
        public async Task UpdateParticipantAsync()
        {
            // Snippet: UpdateParticipantAsync(Participant, FieldMask, CallSettings)
            // Additional: UpdateParticipantAsync(Participant, FieldMask, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            Participant participant = new Participant();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Participant response = await participantsClient.UpdateParticipantAsync(participant, updateMask);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContent</summary>
        public void AnalyzeContentRequestObject()
        {
            // Snippet: AnalyzeContent(AnalyzeContentRequest, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                ReplyAudioConfig = new OutputAudioConfig(),
                TextInput = new TextInput(),
                QueryParams = new QueryParameters(),
                MessageSendTime = new Timestamp(),
                RequestId = "",
                AssistQueryParams = new AssistQueryParameters(),
                CxParameters = new Struct(),
                CxCurrentPage = "",
            };
            // Make the request
            AnalyzeContentResponse response = participantsClient.AnalyzeContent(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContentAsync</summary>
        public async Task AnalyzeContentRequestObjectAsync()
        {
            // Snippet: AnalyzeContentAsync(AnalyzeContentRequest, CallSettings)
            // Additional: AnalyzeContentAsync(AnalyzeContentRequest, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            AnalyzeContentRequest request = new AnalyzeContentRequest
            {
                ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                ReplyAudioConfig = new OutputAudioConfig(),
                TextInput = new TextInput(),
                QueryParams = new QueryParameters(),
                MessageSendTime = new Timestamp(),
                RequestId = "",
                AssistQueryParams = new AssistQueryParameters(),
                CxParameters = new Struct(),
                CxCurrentPage = "",
            };
            // Make the request
            AnalyzeContentResponse response = await participantsClient.AnalyzeContentAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContent</summary>
        public void AnalyzeContent1()
        {
            // Snippet: AnalyzeContent(string, TextInput, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            string participant = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            TextInput textInput = new TextInput();
            // Make the request
            AnalyzeContentResponse response = participantsClient.AnalyzeContent(participant, textInput);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContentAsync</summary>
        public async Task AnalyzeContent1Async()
        {
            // Snippet: AnalyzeContentAsync(string, TextInput, CallSettings)
            // Additional: AnalyzeContentAsync(string, TextInput, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            string participant = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            TextInput textInput = new TextInput();
            // Make the request
            AnalyzeContentResponse response = await participantsClient.AnalyzeContentAsync(participant, textInput);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContent</summary>
        public void AnalyzeContent1ResourceNames()
        {
            // Snippet: AnalyzeContent(ParticipantName, TextInput, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            ParticipantName participant = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            TextInput textInput = new TextInput();
            // Make the request
            AnalyzeContentResponse response = participantsClient.AnalyzeContent(participant, textInput);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContentAsync</summary>
        public async Task AnalyzeContent1ResourceNamesAsync()
        {
            // Snippet: AnalyzeContentAsync(ParticipantName, TextInput, CallSettings)
            // Additional: AnalyzeContentAsync(ParticipantName, TextInput, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            ParticipantName participant = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            TextInput textInput = new TextInput();
            // Make the request
            AnalyzeContentResponse response = await participantsClient.AnalyzeContentAsync(participant, textInput);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContent</summary>
        public void AnalyzeContent2()
        {
            // Snippet: AnalyzeContent(string, AudioInput, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            string participant = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            AudioInput audioInput = new AudioInput();
            // Make the request
            AnalyzeContentResponse response = participantsClient.AnalyzeContent(participant, audioInput);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContentAsync</summary>
        public async Task AnalyzeContent2Async()
        {
            // Snippet: AnalyzeContentAsync(string, AudioInput, CallSettings)
            // Additional: AnalyzeContentAsync(string, AudioInput, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            string participant = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            AudioInput audioInput = new AudioInput();
            // Make the request
            AnalyzeContentResponse response = await participantsClient.AnalyzeContentAsync(participant, audioInput);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContent</summary>
        public void AnalyzeContent2ResourceNames()
        {
            // Snippet: AnalyzeContent(ParticipantName, AudioInput, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            ParticipantName participant = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            AudioInput audioInput = new AudioInput();
            // Make the request
            AnalyzeContentResponse response = participantsClient.AnalyzeContent(participant, audioInput);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContentAsync</summary>
        public async Task AnalyzeContent2ResourceNamesAsync()
        {
            // Snippet: AnalyzeContentAsync(ParticipantName, AudioInput, CallSettings)
            // Additional: AnalyzeContentAsync(ParticipantName, AudioInput, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            ParticipantName participant = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            AudioInput audioInput = new AudioInput();
            // Make the request
            AnalyzeContentResponse response = await participantsClient.AnalyzeContentAsync(participant, audioInput);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContent</summary>
        public void AnalyzeContent3()
        {
            // Snippet: AnalyzeContent(string, EventInput, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            string participant = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            EventInput eventInput = new EventInput();
            // Make the request
            AnalyzeContentResponse response = participantsClient.AnalyzeContent(participant, eventInput);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContentAsync</summary>
        public async Task AnalyzeContent3Async()
        {
            // Snippet: AnalyzeContentAsync(string, EventInput, CallSettings)
            // Additional: AnalyzeContentAsync(string, EventInput, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            string participant = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            EventInput eventInput = new EventInput();
            // Make the request
            AnalyzeContentResponse response = await participantsClient.AnalyzeContentAsync(participant, eventInput);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContent</summary>
        public void AnalyzeContent3ResourceNames()
        {
            // Snippet: AnalyzeContent(ParticipantName, EventInput, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            ParticipantName participant = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            EventInput eventInput = new EventInput();
            // Make the request
            AnalyzeContentResponse response = participantsClient.AnalyzeContent(participant, eventInput);
            // End snippet
        }

        /// <summary>Snippet for AnalyzeContentAsync</summary>
        public async Task AnalyzeContent3ResourceNamesAsync()
        {
            // Snippet: AnalyzeContentAsync(ParticipantName, EventInput, CallSettings)
            // Additional: AnalyzeContentAsync(ParticipantName, EventInput, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            ParticipantName participant = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            EventInput eventInput = new EventInput();
            // Make the request
            AnalyzeContentResponse response = await participantsClient.AnalyzeContentAsync(participant, eventInput);
            // End snippet
        }

        /// <summary>Snippet for StreamingAnalyzeContent</summary>
        public async Task StreamingAnalyzeContent()
        {
            // Snippet: StreamingAnalyzeContent(CallSettings, BidirectionalStreamingSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize streaming call, retrieving the stream object
            using ParticipantsClient.StreamingAnalyzeContentStream response = participantsClient.StreamingAnalyzeContent();

            // Sending requests and retrieving responses can be arbitrarily interleaved
            // Exact sequence will depend on client/server behavior

            // Create task to do something with responses from server
            Task responseHandlerTask = Task.Run(async () =>
            {
                // Note that C# 8 code can use await foreach
                AsyncResponseStream<StreamingAnalyzeContentResponse> responseStream = response.GetResponseStream();
                while (await responseStream.MoveNextAsync())
                {
                    StreamingAnalyzeContentResponse responseItem = responseStream.Current;
                    // Do something with streamed response
                }
                // The response stream has completed
            });

            // Send requests to the server
            bool done = false;
            while (!done)
            {
                // Initialize a request
                StreamingAnalyzeContentRequest request = new StreamingAnalyzeContentRequest
                {
                    ParticipantAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                    AudioConfig = new InputAudioConfig(),
                    ReplyAudioConfig = new OutputAudioConfig(),
                    InputAudio = ByteString.Empty,
                    QueryParams = new QueryParameters(),
                    AssistQueryParams = new AssistQueryParameters(),
                    EnableExtendedStreaming = false,
                    EnablePartialAutomatedAgentReply = false,
                    CxParameters = new Struct(),
                    CxCurrentPage = "",
                    EnableDebuggingInfo = false,
                };
                // Stream a request to the server
                await response.WriteAsync(request);
                // Set "done" to true when sending requests is complete
            }

            // Complete writing requests to the stream
            await response.WriteCompleteAsync();
            // Await the response handler
            // This will complete once all server responses have been processed
            await responseHandlerTask;
            // End snippet
        }

        /// <summary>Snippet for SuggestArticles</summary>
        public void SuggestArticlesRequestObject()
        {
            // Snippet: SuggestArticles(SuggestArticlesRequest, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            SuggestArticlesRequest request = new SuggestArticlesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 0,
                AssistQueryParams = new AssistQueryParameters(),
            };
            // Make the request
            SuggestArticlesResponse response = participantsClient.SuggestArticles(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestArticlesAsync</summary>
        public async Task SuggestArticlesRequestObjectAsync()
        {
            // Snippet: SuggestArticlesAsync(SuggestArticlesRequest, CallSettings)
            // Additional: SuggestArticlesAsync(SuggestArticlesRequest, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            SuggestArticlesRequest request = new SuggestArticlesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 0,
                AssistQueryParams = new AssistQueryParameters(),
            };
            // Make the request
            SuggestArticlesResponse response = await participantsClient.SuggestArticlesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestArticles</summary>
        public void SuggestArticles()
        {
            // Snippet: SuggestArticles(string, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            // Make the request
            SuggestArticlesResponse response = participantsClient.SuggestArticles(parent);
            // End snippet
        }

        /// <summary>Snippet for SuggestArticlesAsync</summary>
        public async Task SuggestArticlesAsync()
        {
            // Snippet: SuggestArticlesAsync(string, CallSettings)
            // Additional: SuggestArticlesAsync(string, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            // Make the request
            SuggestArticlesResponse response = await participantsClient.SuggestArticlesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for SuggestArticles</summary>
        public void SuggestArticlesResourceNames()
        {
            // Snippet: SuggestArticles(ParticipantName, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            ParticipantName parent = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            // Make the request
            SuggestArticlesResponse response = participantsClient.SuggestArticles(parent);
            // End snippet
        }

        /// <summary>Snippet for SuggestArticlesAsync</summary>
        public async Task SuggestArticlesResourceNamesAsync()
        {
            // Snippet: SuggestArticlesAsync(ParticipantName, CallSettings)
            // Additional: SuggestArticlesAsync(ParticipantName, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            ParticipantName parent = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            // Make the request
            SuggestArticlesResponse response = await participantsClient.SuggestArticlesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for SuggestFaqAnswers</summary>
        public void SuggestFaqAnswersRequestObject()
        {
            // Snippet: SuggestFaqAnswers(SuggestFaqAnswersRequest, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            SuggestFaqAnswersRequest request = new SuggestFaqAnswersRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 0,
                AssistQueryParams = new AssistQueryParameters(),
            };
            // Make the request
            SuggestFaqAnswersResponse response = participantsClient.SuggestFaqAnswers(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestFaqAnswersAsync</summary>
        public async Task SuggestFaqAnswersRequestObjectAsync()
        {
            // Snippet: SuggestFaqAnswersAsync(SuggestFaqAnswersRequest, CallSettings)
            // Additional: SuggestFaqAnswersAsync(SuggestFaqAnswersRequest, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            SuggestFaqAnswersRequest request = new SuggestFaqAnswersRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 0,
                AssistQueryParams = new AssistQueryParameters(),
            };
            // Make the request
            SuggestFaqAnswersResponse response = await participantsClient.SuggestFaqAnswersAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestFaqAnswers</summary>
        public void SuggestFaqAnswers()
        {
            // Snippet: SuggestFaqAnswers(string, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            // Make the request
            SuggestFaqAnswersResponse response = participantsClient.SuggestFaqAnswers(parent);
            // End snippet
        }

        /// <summary>Snippet for SuggestFaqAnswersAsync</summary>
        public async Task SuggestFaqAnswersAsync()
        {
            // Snippet: SuggestFaqAnswersAsync(string, CallSettings)
            // Additional: SuggestFaqAnswersAsync(string, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            // Make the request
            SuggestFaqAnswersResponse response = await participantsClient.SuggestFaqAnswersAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for SuggestFaqAnswers</summary>
        public void SuggestFaqAnswersResourceNames()
        {
            // Snippet: SuggestFaqAnswers(ParticipantName, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            ParticipantName parent = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            // Make the request
            SuggestFaqAnswersResponse response = participantsClient.SuggestFaqAnswers(parent);
            // End snippet
        }

        /// <summary>Snippet for SuggestFaqAnswersAsync</summary>
        public async Task SuggestFaqAnswersResourceNamesAsync()
        {
            // Snippet: SuggestFaqAnswersAsync(ParticipantName, CallSettings)
            // Additional: SuggestFaqAnswersAsync(ParticipantName, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            ParticipantName parent = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            // Make the request
            SuggestFaqAnswersResponse response = await participantsClient.SuggestFaqAnswersAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for SuggestSmartReplies</summary>
        public void SuggestSmartRepliesRequestObject()
        {
            // Snippet: SuggestSmartReplies(SuggestSmartRepliesRequest, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            SuggestSmartRepliesRequest request = new SuggestSmartRepliesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 0,
                CurrentTextInput = new TextInput(),
            };
            // Make the request
            SuggestSmartRepliesResponse response = participantsClient.SuggestSmartReplies(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestSmartRepliesAsync</summary>
        public async Task SuggestSmartRepliesRequestObjectAsync()
        {
            // Snippet: SuggestSmartRepliesAsync(SuggestSmartRepliesRequest, CallSettings)
            // Additional: SuggestSmartRepliesAsync(SuggestSmartRepliesRequest, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            SuggestSmartRepliesRequest request = new SuggestSmartRepliesRequest
            {
                ParentAsParticipantName = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]"),
                LatestMessageAsMessageName = MessageName.FromProjectConversationMessage("[PROJECT]", "[CONVERSATION]", "[MESSAGE]"),
                ContextSize = 0,
                CurrentTextInput = new TextInput(),
            };
            // Make the request
            SuggestSmartRepliesResponse response = await participantsClient.SuggestSmartRepliesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SuggestSmartReplies</summary>
        public void SuggestSmartReplies()
        {
            // Snippet: SuggestSmartReplies(string, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            // Make the request
            SuggestSmartRepliesResponse response = participantsClient.SuggestSmartReplies(parent);
            // End snippet
        }

        /// <summary>Snippet for SuggestSmartRepliesAsync</summary>
        public async Task SuggestSmartRepliesAsync()
        {
            // Snippet: SuggestSmartRepliesAsync(string, CallSettings)
            // Additional: SuggestSmartRepliesAsync(string, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/conversations/[CONVERSATION]/participants/[PARTICIPANT]";
            // Make the request
            SuggestSmartRepliesResponse response = await participantsClient.SuggestSmartRepliesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for SuggestSmartReplies</summary>
        public void SuggestSmartRepliesResourceNames()
        {
            // Snippet: SuggestSmartReplies(ParticipantName, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
            ParticipantName parent = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            // Make the request
            SuggestSmartRepliesResponse response = participantsClient.SuggestSmartReplies(parent);
            // End snippet
        }

        /// <summary>Snippet for SuggestSmartRepliesAsync</summary>
        public async Task SuggestSmartRepliesResourceNamesAsync()
        {
            // Snippet: SuggestSmartRepliesAsync(ParticipantName, CallSettings)
            // Additional: SuggestSmartRepliesAsync(ParticipantName, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
            ParticipantName parent = ParticipantName.FromProjectConversationParticipant("[PROJECT]", "[CONVERSATION]", "[PARTICIPANT]");
            // Make the request
            SuggestSmartRepliesResponse response = await participantsClient.SuggestSmartRepliesAsync(parent);
            // End snippet
        }

        /// <summary>Snippet for ListSuggestions</summary>
        public void ListSuggestionsRequestObject()
        {
            // Snippet: ListSuggestions(ListSuggestionsRequest, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListSuggestionsRequest request = new ListSuggestionsRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedEnumerable<ListSuggestionsResponse, Suggestion> response = participantsClient.ListSuggestions(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            foreach (Suggestion item in response)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            foreach (ListSuggestionsResponse page in response.AsRawResponses())
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (Suggestion item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<Suggestion> singlePage = response.ReadPage(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (Suggestion item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSuggestionsAsync</summary>
        public async Task ListSuggestionsRequestObjectAsync()
        {
            // Snippet: ListSuggestionsAsync(ListSuggestionsRequest, CallSettings)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
#pragma warning disable CS0612
            ListSuggestionsRequest request = new ListSuggestionsRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            PagedAsyncEnumerable<ListSuggestionsResponse, Suggestion> response = participantsClient.ListSuggestionsAsync(request);
#pragma warning restore CS0612

            // Iterate over all response items, lazily performing RPCs as required
#pragma warning disable CS0612
            await response.ForEachAsync((Suggestion item) =>
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
#pragma warning disable CS0612
            await response.AsRawResponses().ForEachAsync((ListSuggestionsResponse page) =>
#pragma warning restore CS0612
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
#pragma warning disable CS0612
                foreach (Suggestion item in page)
#pragma warning restore CS0612
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
#pragma warning disable CS0612
            Page<Suggestion> singlePage = await response.ReadPageAsync(pageSize);
#pragma warning restore CS0612
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
#pragma warning disable CS0612
            foreach (Suggestion item in singlePage)
#pragma warning restore CS0612
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CompileSuggestion</summary>
        public void CompileSuggestionRequestObject()
        {
            // Snippet: CompileSuggestion(CompileSuggestionRequest, CallSettings)
            // Create client
            ParticipantsClient participantsClient = ParticipantsClient.Create();
            // Initialize request argument(s)
#pragma warning disable CS0612
            CompileSuggestionRequest request = new CompileSuggestionRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            CompileSuggestionResponse response = participantsClient.CompileSuggestion(request);
#pragma warning restore CS0612
            // End snippet
        }

        /// <summary>Snippet for CompileSuggestionAsync</summary>
        public async Task CompileSuggestionRequestObjectAsync()
        {
            // Snippet: CompileSuggestionAsync(CompileSuggestionRequest, CallSettings)
            // Additional: CompileSuggestionAsync(CompileSuggestionRequest, CancellationToken)
            // Create client
            ParticipantsClient participantsClient = await ParticipantsClient.CreateAsync();
            // Initialize request argument(s)
#pragma warning disable CS0612
            CompileSuggestionRequest request = new CompileSuggestionRequest { };
#pragma warning restore CS0612
            // Make the request
#pragma warning disable CS0612
            CompileSuggestionResponse response = await participantsClient.CompileSuggestionAsync(request);
#pragma warning restore CS0612
            // End snippet
        }
    }
}
