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
    public sealed class AllGeneratedSessionServiceClientSnippets
    {
        /// <summary>Snippet for CreateSession</summary>
        public void CreateSessionRequestObject()
        {
            // Snippet: CreateSession(CreateSessionRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            CreateSessionRequest request = new CreateSessionRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Session = new Session(),
            };
            // Make the request
            Session response = sessionServiceClient.CreateSession(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionRequestObjectAsync()
        {
            // Snippet: CreateSessionAsync(CreateSessionRequest, CallSettings)
            // Additional: CreateSessionAsync(CreateSessionRequest, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateSessionRequest request = new CreateSessionRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Session = new Session(),
            };
            // Make the request
            Session response = await sessionServiceClient.CreateSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSession()
        {
            // Snippet: CreateSession(string, Session, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            Session session = new Session();
            // Make the request
            Session response = sessionServiceClient.CreateSession(parent, session);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionAsync()
        {
            // Snippet: CreateSessionAsync(string, Session, CallSettings)
            // Additional: CreateSessionAsync(string, Session, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            Session session = new Session();
            // Make the request
            Session response = await sessionServiceClient.CreateSessionAsync(parent, session);
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSessionResourceNames()
        {
            // Snippet: CreateSession(DataStoreName, Session, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            Session session = new Session();
            // Make the request
            Session response = sessionServiceClient.CreateSession(parent, session);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionResourceNamesAsync()
        {
            // Snippet: CreateSessionAsync(DataStoreName, Session, CallSettings)
            // Additional: CreateSessionAsync(DataStoreName, Session, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            Session session = new Session();
            // Make the request
            Session response = await sessionServiceClient.CreateSessionAsync(parent, session);
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSessionRequestObject()
        {
            // Snippet: DeleteSession(DeleteSessionRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
            };
            // Make the request
            sessionServiceClient.DeleteSession(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionRequestObjectAsync()
        {
            // Snippet: DeleteSessionAsync(DeleteSessionRequest, CallSettings)
            // Additional: DeleteSessionAsync(DeleteSessionRequest, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
            };
            // Make the request
            await sessionServiceClient.DeleteSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSession()
        {
            // Snippet: DeleteSession(string, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/sessions/[SESSION]";
            // Make the request
            sessionServiceClient.DeleteSession(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionAsync()
        {
            // Snippet: DeleteSessionAsync(string, CallSettings)
            // Additional: DeleteSessionAsync(string, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/sessions/[SESSION]";
            // Make the request
            await sessionServiceClient.DeleteSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSessionResourceNames()
        {
            // Snippet: DeleteSession(SessionName, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]");
            // Make the request
            sessionServiceClient.DeleteSession(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionResourceNamesAsync()
        {
            // Snippet: DeleteSessionAsync(SessionName, CallSettings)
            // Additional: DeleteSessionAsync(SessionName, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]");
            // Make the request
            await sessionServiceClient.DeleteSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateSession</summary>
        public void UpdateSessionRequestObject()
        {
            // Snippet: UpdateSession(UpdateSessionRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            UpdateSessionRequest request = new UpdateSessionRequest
            {
                Session = new Session(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Session response = sessionServiceClient.UpdateSession(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionAsync</summary>
        public async Task UpdateSessionRequestObjectAsync()
        {
            // Snippet: UpdateSessionAsync(UpdateSessionRequest, CallSettings)
            // Additional: UpdateSessionAsync(UpdateSessionRequest, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateSessionRequest request = new UpdateSessionRequest
            {
                Session = new Session(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Session response = await sessionServiceClient.UpdateSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateSession</summary>
        public void UpdateSession()
        {
            // Snippet: UpdateSession(Session, FieldMask, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            Session session = new Session();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Session response = sessionServiceClient.UpdateSession(session, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateSessionAsync</summary>
        public async Task UpdateSessionAsync()
        {
            // Snippet: UpdateSessionAsync(Session, FieldMask, CallSettings)
            // Additional: UpdateSessionAsync(Session, FieldMask, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            Session session = new Session();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Session response = await sessionServiceClient.UpdateSessionAsync(session, updateMask);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSessionRequestObject()
        {
            // Snippet: GetSession(GetSessionRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
                IncludeAnswerDetails = false,
            };
            // Make the request
            Session response = sessionServiceClient.GetSession(request);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionRequestObjectAsync()
        {
            // Snippet: GetSessionAsync(GetSessionRequest, CallSettings)
            // Additional: GetSessionAsync(GetSessionRequest, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]"),
                IncludeAnswerDetails = false,
            };
            // Make the request
            Session response = await sessionServiceClient.GetSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSession()
        {
            // Snippet: GetSession(string, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/sessions/[SESSION]";
            // Make the request
            Session response = sessionServiceClient.GetSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionAsync()
        {
            // Snippet: GetSessionAsync(string, CallSettings)
            // Additional: GetSessionAsync(string, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]/sessions/[SESSION]";
            // Make the request
            Session response = await sessionServiceClient.GetSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSessionResourceNames()
        {
            // Snippet: GetSession(SessionName, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]");
            // Make the request
            Session response = sessionServiceClient.GetSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionResourceNamesAsync()
        {
            // Snippet: GetSessionAsync(SessionName, CallSettings)
            // Additional: GetSessionAsync(SessionName, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationDataStoreSession("[PROJECT]", "[LOCATION]", "[DATA_STORE]", "[SESSION]");
            // Make the request
            Session response = await sessionServiceClient.GetSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSessions</summary>
        public void ListSessionsRequestObject()
        {
            // Snippet: ListSessions(ListSessionsRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListSessionsResponse, Session> response = sessionServiceClient.ListSessions(request);

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
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSessionsResponse, Session> response = sessionServiceClient.ListSessionsAsync(request);

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
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            // Make the request
            PagedEnumerable<ListSessionsResponse, Session> response = sessionServiceClient.ListSessions(parent);

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
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/dataStores/[DATA_STORE]";
            // Make the request
            PagedAsyncEnumerable<ListSessionsResponse, Session> response = sessionServiceClient.ListSessionsAsync(parent);

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
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            PagedEnumerable<ListSessionsResponse, Session> response = sessionServiceClient.ListSessions(parent);

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
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataStoreName parent = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]");
            // Make the request
            PagedAsyncEnumerable<ListSessionsResponse, Session> response = sessionServiceClient.ListSessionsAsync(parent);

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
