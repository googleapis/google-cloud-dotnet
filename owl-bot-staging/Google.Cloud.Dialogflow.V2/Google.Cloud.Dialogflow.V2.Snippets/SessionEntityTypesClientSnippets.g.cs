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
    using Google.Cloud.Dialogflow.V2;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSessionEntityTypesClientSnippets
    {
        /// <summary>Snippet for ListSessionEntityTypes</summary>
        public void ListSessionEntityTypesRequestObject()
        {
            // Snippet: ListSessionEntityTypes(ListSessionEntityTypesRequest, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            ListSessionEntityTypesRequest request = new ListSessionEntityTypesRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
            };
            // Make the request
            PagedEnumerable<ListSessionEntityTypesResponse, SessionEntityType> response = sessionEntityTypesClient.ListSessionEntityTypes(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SessionEntityType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSessionEntityTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionEntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionEntityType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionEntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionEntityTypesAsync</summary>
        public async Task ListSessionEntityTypesRequestObjectAsync()
        {
            // Snippet: ListSessionEntityTypesAsync(ListSessionEntityTypesRequest, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            ListSessionEntityTypesRequest request = new ListSessionEntityTypesRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSessionEntityTypesResponse, SessionEntityType> response = sessionEntityTypesClient.ListSessionEntityTypesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SessionEntityType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSessionEntityTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionEntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionEntityType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionEntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionEntityTypes</summary>
        public void ListSessionEntityTypes()
        {
            // Snippet: ListSessionEntityTypes(string, string, int?, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/sessions/[SESSION]";
            // Make the request
            PagedEnumerable<ListSessionEntityTypesResponse, SessionEntityType> response = sessionEntityTypesClient.ListSessionEntityTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SessionEntityType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSessionEntityTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionEntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionEntityType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionEntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionEntityTypesAsync</summary>
        public async Task ListSessionEntityTypesAsync()
        {
            // Snippet: ListSessionEntityTypesAsync(string, string, int?, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/sessions/[SESSION]";
            // Make the request
            PagedAsyncEnumerable<ListSessionEntityTypesResponse, SessionEntityType> response = sessionEntityTypesClient.ListSessionEntityTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SessionEntityType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSessionEntityTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionEntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionEntityType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionEntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionEntityTypes</summary>
        public void ListSessionEntityTypesResourceNames()
        {
            // Snippet: ListSessionEntityTypes(SessionName, string, int?, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
            // Make the request
            PagedEnumerable<ListSessionEntityTypesResponse, SessionEntityType> response = sessionEntityTypesClient.ListSessionEntityTypes(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SessionEntityType item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSessionEntityTypesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionEntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionEntityType> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionEntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSessionEntityTypesAsync</summary>
        public async Task ListSessionEntityTypesResourceNamesAsync()
        {
            // Snippet: ListSessionEntityTypesAsync(SessionName, string, int?, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
            // Make the request
            PagedAsyncEnumerable<ListSessionEntityTypesResponse, SessionEntityType> response = sessionEntityTypesClient.ListSessionEntityTypesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SessionEntityType item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSessionEntityTypesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionEntityType item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionEntityType> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionEntityType item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetSessionEntityType</summary>
        public void GetSessionEntityTypeRequestObject()
        {
            // Snippet: GetSessionEntityType(GetSessionEntityTypeRequest, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            GetSessionEntityTypeRequest request = new GetSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            // Make the request
            SessionEntityType response = sessionEntityTypesClient.GetSessionEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for GetSessionEntityTypeAsync</summary>
        public async Task GetSessionEntityTypeRequestObjectAsync()
        {
            // Snippet: GetSessionEntityTypeAsync(GetSessionEntityTypeRequest, CallSettings)
            // Additional: GetSessionEntityTypeAsync(GetSessionEntityTypeRequest, CancellationToken)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            GetSessionEntityTypeRequest request = new GetSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            // Make the request
            SessionEntityType response = await sessionEntityTypesClient.GetSessionEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSessionEntityType</summary>
        public void GetSessionEntityType()
        {
            // Snippet: GetSessionEntityType(string, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/sessions/[SESSION]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            SessionEntityType response = sessionEntityTypesClient.GetSessionEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionEntityTypeAsync</summary>
        public async Task GetSessionEntityTypeAsync()
        {
            // Snippet: GetSessionEntityTypeAsync(string, CallSettings)
            // Additional: GetSessionEntityTypeAsync(string, CancellationToken)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/sessions/[SESSION]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            SessionEntityType response = await sessionEntityTypesClient.GetSessionEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionEntityType</summary>
        public void GetSessionEntityTypeResourceNames()
        {
            // Snippet: GetSessionEntityType(SessionEntityTypeName, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            SessionEntityTypeName name = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]");
            // Make the request
            SessionEntityType response = sessionEntityTypesClient.GetSessionEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionEntityTypeAsync</summary>
        public async Task GetSessionEntityTypeResourceNamesAsync()
        {
            // Snippet: GetSessionEntityTypeAsync(SessionEntityTypeName, CallSettings)
            // Additional: GetSessionEntityTypeAsync(SessionEntityTypeName, CancellationToken)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            SessionEntityTypeName name = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]");
            // Make the request
            SessionEntityType response = await sessionEntityTypesClient.GetSessionEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionEntityType</summary>
        public void CreateSessionEntityTypeRequestObject()
        {
            // Snippet: CreateSessionEntityType(CreateSessionEntityTypeRequest, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            CreateSessionEntityTypeRequest request = new CreateSessionEntityTypeRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                SessionEntityType = new SessionEntityType(),
            };
            // Make the request
            SessionEntityType response = sessionEntityTypesClient.CreateSessionEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionEntityTypeAsync</summary>
        public async Task CreateSessionEntityTypeRequestObjectAsync()
        {
            // Snippet: CreateSessionEntityTypeAsync(CreateSessionEntityTypeRequest, CallSettings)
            // Additional: CreateSessionEntityTypeAsync(CreateSessionEntityTypeRequest, CancellationToken)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            CreateSessionEntityTypeRequest request = new CreateSessionEntityTypeRequest
            {
                ParentAsSessionName = SessionName.FromProjectSession("[PROJECT]", "[SESSION]"),
                SessionEntityType = new SessionEntityType(),
            };
            // Make the request
            SessionEntityType response = await sessionEntityTypesClient.CreateSessionEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionEntityType</summary>
        public void CreateSessionEntityType()
        {
            // Snippet: CreateSessionEntityType(string, SessionEntityType, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/sessions/[SESSION]";
            SessionEntityType sessionEntityType = new SessionEntityType();
            // Make the request
            SessionEntityType response = sessionEntityTypesClient.CreateSessionEntityType(parent, sessionEntityType);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionEntityTypeAsync</summary>
        public async Task CreateSessionEntityTypeAsync()
        {
            // Snippet: CreateSessionEntityTypeAsync(string, SessionEntityType, CallSettings)
            // Additional: CreateSessionEntityTypeAsync(string, SessionEntityType, CancellationToken)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/agent/sessions/[SESSION]";
            SessionEntityType sessionEntityType = new SessionEntityType();
            // Make the request
            SessionEntityType response = await sessionEntityTypesClient.CreateSessionEntityTypeAsync(parent, sessionEntityType);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionEntityType</summary>
        public void CreateSessionEntityTypeResourceNames()
        {
            // Snippet: CreateSessionEntityType(SessionName, SessionEntityType, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
            SessionEntityType sessionEntityType = new SessionEntityType();
            // Make the request
            SessionEntityType response = sessionEntityTypesClient.CreateSessionEntityType(parent, sessionEntityType);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionEntityTypeAsync</summary>
        public async Task CreateSessionEntityTypeResourceNamesAsync()
        {
            // Snippet: CreateSessionEntityTypeAsync(SessionName, SessionEntityType, CallSettings)
            // Additional: CreateSessionEntityTypeAsync(SessionName, SessionEntityType, CancellationToken)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectSession("[PROJECT]", "[SESSION]");
            SessionEntityType sessionEntityType = new SessionEntityType();
            // Make the request
            SessionEntityType response = await sessionEntityTypesClient.CreateSessionEntityTypeAsync(parent, sessionEntityType);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionEntityType</summary>
        public void UpdateSessionEntityTypeRequestObject()
        {
            // Snippet: UpdateSessionEntityType(UpdateSessionEntityTypeRequest, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            UpdateSessionEntityTypeRequest request = new UpdateSessionEntityTypeRequest
            {
                SessionEntityType = new SessionEntityType(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SessionEntityType response = sessionEntityTypesClient.UpdateSessionEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionEntityTypeAsync</summary>
        public async Task UpdateSessionEntityTypeRequestObjectAsync()
        {
            // Snippet: UpdateSessionEntityTypeAsync(UpdateSessionEntityTypeRequest, CallSettings)
            // Additional: UpdateSessionEntityTypeAsync(UpdateSessionEntityTypeRequest, CancellationToken)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSessionEntityTypeRequest request = new UpdateSessionEntityTypeRequest
            {
                SessionEntityType = new SessionEntityType(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            SessionEntityType response = await sessionEntityTypesClient.UpdateSessionEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionEntityType</summary>
        public void UpdateSessionEntityType1()
        {
            // Snippet: UpdateSessionEntityType(SessionEntityType, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            SessionEntityType sessionEntityType = new SessionEntityType();
            // Make the request
            SessionEntityType response = sessionEntityTypesClient.UpdateSessionEntityType(sessionEntityType);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionEntityTypeAsync</summary>
        public async Task UpdateSessionEntityType1Async()
        {
            // Snippet: UpdateSessionEntityTypeAsync(SessionEntityType, CallSettings)
            // Additional: UpdateSessionEntityTypeAsync(SessionEntityType, CancellationToken)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            SessionEntityType sessionEntityType = new SessionEntityType();
            // Make the request
            SessionEntityType response = await sessionEntityTypesClient.UpdateSessionEntityTypeAsync(sessionEntityType);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionEntityType</summary>
        public void UpdateSessionEntityType2()
        {
            // Snippet: UpdateSessionEntityType(SessionEntityType, FieldMask, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            SessionEntityType sessionEntityType = new SessionEntityType();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SessionEntityType response = sessionEntityTypesClient.UpdateSessionEntityType(sessionEntityType, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionEntityTypeAsync</summary>
        public async Task UpdateSessionEntityType2Async()
        {
            // Snippet: UpdateSessionEntityTypeAsync(SessionEntityType, FieldMask, CallSettings)
            // Additional: UpdateSessionEntityTypeAsync(SessionEntityType, FieldMask, CancellationToken)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            SessionEntityType sessionEntityType = new SessionEntityType();
            FieldMask updateMask = new FieldMask();
            // Make the request
            SessionEntityType response = await sessionEntityTypesClient.UpdateSessionEntityTypeAsync(sessionEntityType, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionEntityType</summary>
        public void DeleteSessionEntityTypeRequestObject()
        {
            // Snippet: DeleteSessionEntityType(DeleteSessionEntityTypeRequest, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            DeleteSessionEntityTypeRequest request = new DeleteSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            // Make the request
            sessionEntityTypesClient.DeleteSessionEntityType(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionEntityTypeAsync</summary>
        public async Task DeleteSessionEntityTypeRequestObjectAsync()
        {
            // Snippet: DeleteSessionEntityTypeAsync(DeleteSessionEntityTypeRequest, CallSettings)
            // Additional: DeleteSessionEntityTypeAsync(DeleteSessionEntityTypeRequest, CancellationToken)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSessionEntityTypeRequest request = new DeleteSessionEntityTypeRequest
            {
                SessionEntityTypeName = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]"),
            };
            // Make the request
            await sessionEntityTypesClient.DeleteSessionEntityTypeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionEntityType</summary>
        public void DeleteSessionEntityType()
        {
            // Snippet: DeleteSessionEntityType(string, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/sessions/[SESSION]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            sessionEntityTypesClient.DeleteSessionEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionEntityTypeAsync</summary>
        public async Task DeleteSessionEntityTypeAsync()
        {
            // Snippet: DeleteSessionEntityTypeAsync(string, CallSettings)
            // Additional: DeleteSessionEntityTypeAsync(string, CancellationToken)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/agent/sessions/[SESSION]/entityTypes/[ENTITY_TYPE]";
            // Make the request
            await sessionEntityTypesClient.DeleteSessionEntityTypeAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionEntityType</summary>
        public void DeleteSessionEntityTypeResourceNames()
        {
            // Snippet: DeleteSessionEntityType(SessionEntityTypeName, CallSettings)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = SessionEntityTypesClient.Create();
            // Initialize request argument(s)
            SessionEntityTypeName name = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]");
            // Make the request
            sessionEntityTypesClient.DeleteSessionEntityType(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionEntityTypeAsync</summary>
        public async Task DeleteSessionEntityTypeResourceNamesAsync()
        {
            // Snippet: DeleteSessionEntityTypeAsync(SessionEntityTypeName, CallSettings)
            // Additional: DeleteSessionEntityTypeAsync(SessionEntityTypeName, CancellationToken)
            // Create client
            SessionEntityTypesClient sessionEntityTypesClient = await SessionEntityTypesClient.CreateAsync();
            // Initialize request argument(s)
            SessionEntityTypeName name = SessionEntityTypeName.FromProjectSessionEntityType("[PROJECT]", "[SESSION]", "[ENTITY_TYPE]");
            // Make the request
            await sessionEntityTypesClient.DeleteSessionEntityTypeAsync(name);
            // End snippet
        }
    }
}
