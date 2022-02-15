// Copyright 2022 Google LLC
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
    using Google.Api.Gax.ResourceNames;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedConversationProfilesClientSnippets
    {
        /// <summary>Snippet for ListConversationProfiles</summary>
        public void ListConversationProfilesRequestObject()
        {
            // Snippet: ListConversationProfiles(ListConversationProfilesRequest, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            ListConversationProfilesRequest request = new ListConversationProfilesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedEnumerable<ListConversationProfilesResponse, ConversationProfile> response = conversationProfilesClient.ListConversationProfiles(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversationProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationProfilesAsync</summary>
        public async Task ListConversationProfilesRequestObjectAsync()
        {
            // Snippet: ListConversationProfilesAsync(ListConversationProfilesRequest, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            ListConversationProfilesRequest request = new ListConversationProfilesRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListConversationProfilesResponse, ConversationProfile> response = conversationProfilesClient.ListConversationProfilesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversationProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationProfiles</summary>
        public void ListConversationProfiles()
        {
            // Snippet: ListConversationProfiles(string, string, int?, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedEnumerable<ListConversationProfilesResponse, ConversationProfile> response = conversationProfilesClient.ListConversationProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversationProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationProfilesAsync</summary>
        public async Task ListConversationProfilesAsync()
        {
            // Snippet: ListConversationProfilesAsync(string, string, int?, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            // Make the request
            PagedAsyncEnumerable<ListConversationProfilesResponse, ConversationProfile> response = conversationProfilesClient.ListConversationProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversationProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationProfiles</summary>
        public void ListConversationProfilesResourceNames1()
        {
            // Snippet: ListConversationProfiles(ProjectName, string, int?, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedEnumerable<ListConversationProfilesResponse, ConversationProfile> response = conversationProfilesClient.ListConversationProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversationProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationProfilesAsync</summary>
        public async Task ListConversationProfilesResourceNames1Async()
        {
            // Snippet: ListConversationProfilesAsync(ProjectName, string, int?, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            // Make the request
            PagedAsyncEnumerable<ListConversationProfilesResponse, ConversationProfile> response = conversationProfilesClient.ListConversationProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversationProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationProfiles</summary>
        public void ListConversationProfilesResourceNames2()
        {
            // Snippet: ListConversationProfiles(LocationName, string, int?, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListConversationProfilesResponse, ConversationProfile> response = conversationProfilesClient.ListConversationProfiles(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ConversationProfile item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListConversationProfilesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationProfile> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListConversationProfilesAsync</summary>
        public async Task ListConversationProfilesResourceNames2Async()
        {
            // Snippet: ListConversationProfilesAsync(LocationName, string, int?, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListConversationProfilesResponse, ConversationProfile> response = conversationProfilesClient.ListConversationProfilesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((ConversationProfile item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListConversationProfilesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ConversationProfile item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ConversationProfile> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ConversationProfile item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetConversationProfile</summary>
        public void GetConversationProfileRequestObject()
        {
            // Snippet: GetConversationProfile(GetConversationProfileRequest, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            GetConversationProfileRequest request = new GetConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            // Make the request
            ConversationProfile response = conversationProfilesClient.GetConversationProfile(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversationProfileAsync</summary>
        public async Task GetConversationProfileRequestObjectAsync()
        {
            // Snippet: GetConversationProfileAsync(GetConversationProfileRequest, CallSettings)
            // Additional: GetConversationProfileAsync(GetConversationProfileRequest, CancellationToken)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            GetConversationProfileRequest request = new GetConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            // Make the request
            ConversationProfile response = await conversationProfilesClient.GetConversationProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetConversationProfile</summary>
        public void GetConversationProfile()
        {
            // Snippet: GetConversationProfile(string, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/conversationProfiles/[CONVERSATION_PROFILE]";
            // Make the request
            ConversationProfile response = conversationProfilesClient.GetConversationProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationProfileAsync</summary>
        public async Task GetConversationProfileAsync()
        {
            // Snippet: GetConversationProfileAsync(string, CallSettings)
            // Additional: GetConversationProfileAsync(string, CancellationToken)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/conversationProfiles/[CONVERSATION_PROFILE]";
            // Make the request
            ConversationProfile response = await conversationProfilesClient.GetConversationProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationProfile</summary>
        public void GetConversationProfileResourceNames()
        {
            // Snippet: GetConversationProfile(ConversationProfileName, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            ConversationProfileName name = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]");
            // Make the request
            ConversationProfile response = conversationProfilesClient.GetConversationProfile(name);
            // End snippet
        }

        /// <summary>Snippet for GetConversationProfileAsync</summary>
        public async Task GetConversationProfileResourceNamesAsync()
        {
            // Snippet: GetConversationProfileAsync(ConversationProfileName, CallSettings)
            // Additional: GetConversationProfileAsync(ConversationProfileName, CancellationToken)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            ConversationProfileName name = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]");
            // Make the request
            ConversationProfile response = await conversationProfilesClient.GetConversationProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationProfile</summary>
        public void CreateConversationProfileRequestObject()
        {
            // Snippet: CreateConversationProfile(CreateConversationProfileRequest, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            CreateConversationProfileRequest request = new CreateConversationProfileRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ConversationProfile = new ConversationProfile(),
            };
            // Make the request
            ConversationProfile response = conversationProfilesClient.CreateConversationProfile(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationProfileAsync</summary>
        public async Task CreateConversationProfileRequestObjectAsync()
        {
            // Snippet: CreateConversationProfileAsync(CreateConversationProfileRequest, CallSettings)
            // Additional: CreateConversationProfileAsync(CreateConversationProfileRequest, CancellationToken)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            CreateConversationProfileRequest request = new CreateConversationProfileRequest
            {
                ParentAsProjectName = ProjectName.FromProject("[PROJECT]"),
                ConversationProfile = new ConversationProfile(),
            };
            // Make the request
            ConversationProfile response = await conversationProfilesClient.CreateConversationProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationProfile</summary>
        public void CreateConversationProfile()
        {
            // Snippet: CreateConversationProfile(string, ConversationProfile, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            ConversationProfile conversationProfile = new ConversationProfile();
            // Make the request
            ConversationProfile response = conversationProfilesClient.CreateConversationProfile(parent, conversationProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationProfileAsync</summary>
        public async Task CreateConversationProfileAsync()
        {
            // Snippet: CreateConversationProfileAsync(string, ConversationProfile, CallSettings)
            // Additional: CreateConversationProfileAsync(string, ConversationProfile, CancellationToken)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]";
            ConversationProfile conversationProfile = new ConversationProfile();
            // Make the request
            ConversationProfile response = await conversationProfilesClient.CreateConversationProfileAsync(parent, conversationProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationProfile</summary>
        public void CreateConversationProfileResourceNames1()
        {
            // Snippet: CreateConversationProfile(ProjectName, ConversationProfile, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            ConversationProfile conversationProfile = new ConversationProfile();
            // Make the request
            ConversationProfile response = conversationProfilesClient.CreateConversationProfile(parent, conversationProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationProfileAsync</summary>
        public async Task CreateConversationProfileResourceNames1Async()
        {
            // Snippet: CreateConversationProfileAsync(ProjectName, ConversationProfile, CallSettings)
            // Additional: CreateConversationProfileAsync(ProjectName, ConversationProfile, CancellationToken)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            ProjectName parent = ProjectName.FromProject("[PROJECT]");
            ConversationProfile conversationProfile = new ConversationProfile();
            // Make the request
            ConversationProfile response = await conversationProfilesClient.CreateConversationProfileAsync(parent, conversationProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationProfile</summary>
        public void CreateConversationProfileResourceNames2()
        {
            // Snippet: CreateConversationProfile(LocationName, ConversationProfile, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ConversationProfile conversationProfile = new ConversationProfile();
            // Make the request
            ConversationProfile response = conversationProfilesClient.CreateConversationProfile(parent, conversationProfile);
            // End snippet
        }

        /// <summary>Snippet for CreateConversationProfileAsync</summary>
        public async Task CreateConversationProfileResourceNames2Async()
        {
            // Snippet: CreateConversationProfileAsync(LocationName, ConversationProfile, CallSettings)
            // Additional: CreateConversationProfileAsync(LocationName, ConversationProfile, CancellationToken)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            ConversationProfile conversationProfile = new ConversationProfile();
            // Make the request
            ConversationProfile response = await conversationProfilesClient.CreateConversationProfileAsync(parent, conversationProfile);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversationProfile</summary>
        public void UpdateConversationProfileRequestObject()
        {
            // Snippet: UpdateConversationProfile(UpdateConversationProfileRequest, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            UpdateConversationProfileRequest request = new UpdateConversationProfileRequest
            {
                ConversationProfile = new ConversationProfile(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ConversationProfile response = conversationProfilesClient.UpdateConversationProfile(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversationProfileAsync</summary>
        public async Task UpdateConversationProfileRequestObjectAsync()
        {
            // Snippet: UpdateConversationProfileAsync(UpdateConversationProfileRequest, CallSettings)
            // Additional: UpdateConversationProfileAsync(UpdateConversationProfileRequest, CancellationToken)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateConversationProfileRequest request = new UpdateConversationProfileRequest
            {
                ConversationProfile = new ConversationProfile(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            ConversationProfile response = await conversationProfilesClient.UpdateConversationProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversationProfile</summary>
        public void UpdateConversationProfile()
        {
            // Snippet: UpdateConversationProfile(ConversationProfile, FieldMask, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            ConversationProfile conversationProfile = new ConversationProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ConversationProfile response = conversationProfilesClient.UpdateConversationProfile(conversationProfile, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateConversationProfileAsync</summary>
        public async Task UpdateConversationProfileAsync()
        {
            // Snippet: UpdateConversationProfileAsync(ConversationProfile, FieldMask, CallSettings)
            // Additional: UpdateConversationProfileAsync(ConversationProfile, FieldMask, CancellationToken)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            ConversationProfile conversationProfile = new ConversationProfile();
            FieldMask updateMask = new FieldMask();
            // Make the request
            ConversationProfile response = await conversationProfilesClient.UpdateConversationProfileAsync(conversationProfile, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationProfile</summary>
        public void DeleteConversationProfileRequestObject()
        {
            // Snippet: DeleteConversationProfile(DeleteConversationProfileRequest, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            DeleteConversationProfileRequest request = new DeleteConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            // Make the request
            conversationProfilesClient.DeleteConversationProfile(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationProfileAsync</summary>
        public async Task DeleteConversationProfileRequestObjectAsync()
        {
            // Snippet: DeleteConversationProfileAsync(DeleteConversationProfileRequest, CallSettings)
            // Additional: DeleteConversationProfileAsync(DeleteConversationProfileRequest, CancellationToken)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteConversationProfileRequest request = new DeleteConversationProfileRequest
            {
                ConversationProfileName = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]"),
            };
            // Make the request
            await conversationProfilesClient.DeleteConversationProfileAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationProfile</summary>
        public void DeleteConversationProfile()
        {
            // Snippet: DeleteConversationProfile(string, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/conversationProfiles/[CONVERSATION_PROFILE]";
            // Make the request
            conversationProfilesClient.DeleteConversationProfile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationProfileAsync</summary>
        public async Task DeleteConversationProfileAsync()
        {
            // Snippet: DeleteConversationProfileAsync(string, CallSettings)
            // Additional: DeleteConversationProfileAsync(string, CancellationToken)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/conversationProfiles/[CONVERSATION_PROFILE]";
            // Make the request
            await conversationProfilesClient.DeleteConversationProfileAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationProfile</summary>
        public void DeleteConversationProfileResourceNames()
        {
            // Snippet: DeleteConversationProfile(ConversationProfileName, CallSettings)
            // Create client
            ConversationProfilesClient conversationProfilesClient = ConversationProfilesClient.Create();
            // Initialize request argument(s)
            ConversationProfileName name = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]");
            // Make the request
            conversationProfilesClient.DeleteConversationProfile(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteConversationProfileAsync</summary>
        public async Task DeleteConversationProfileResourceNamesAsync()
        {
            // Snippet: DeleteConversationProfileAsync(ConversationProfileName, CallSettings)
            // Additional: DeleteConversationProfileAsync(ConversationProfileName, CancellationToken)
            // Create client
            ConversationProfilesClient conversationProfilesClient = await ConversationProfilesClient.CreateAsync();
            // Initialize request argument(s)
            ConversationProfileName name = ConversationProfileName.FromProjectConversationProfile("[PROJECT]", "[CONVERSATION_PROFILE]");
            // Make the request
            await conversationProfilesClient.DeleteConversationProfileAsync(name);
            // End snippet
        }
    }
}
