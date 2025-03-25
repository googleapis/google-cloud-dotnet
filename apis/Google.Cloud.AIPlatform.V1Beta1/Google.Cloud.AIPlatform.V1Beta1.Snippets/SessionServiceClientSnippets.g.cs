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
    using Google.Cloud.AIPlatform.V1Beta1;
    using Google.LongRunning;
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Session = new Session(),
            };
            // Make the request
            Operation<Session, CreateSessionOperationMetadata> response = sessionServiceClient.CreateSession(request);

            // Poll until the returned long-running operation is complete
            Operation<Session, CreateSessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, CreateSessionOperationMetadata> retrievedResponse = sessionServiceClient.PollOnceCreateSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Session = new Session(),
            };
            // Make the request
            Operation<Session, CreateSessionOperationMetadata> response = await sessionServiceClient.CreateSessionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Session, CreateSessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, CreateSessionOperationMetadata> retrievedResponse = await sessionServiceClient.PollOnceCreateSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSession()
        {
            // Snippet: CreateSession(string, Session, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Session session = new Session();
            // Make the request
            Operation<Session, CreateSessionOperationMetadata> response = sessionServiceClient.CreateSession(parent, session);

            // Poll until the returned long-running operation is complete
            Operation<Session, CreateSessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, CreateSessionOperationMetadata> retrievedResponse = sessionServiceClient.PollOnceCreateSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Session session = new Session();
            // Make the request
            Operation<Session, CreateSessionOperationMetadata> response = await sessionServiceClient.CreateSessionAsync(parent, session);

            // Poll until the returned long-running operation is complete
            Operation<Session, CreateSessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, CreateSessionOperationMetadata> retrievedResponse = await sessionServiceClient.PollOnceCreateSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSessionResourceNames1()
        {
            // Snippet: CreateSession(LocationName, Session, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Session session = new Session();
            // Make the request
            Operation<Session, CreateSessionOperationMetadata> response = sessionServiceClient.CreateSession(parent, session);

            // Poll until the returned long-running operation is complete
            Operation<Session, CreateSessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, CreateSessionOperationMetadata> retrievedResponse = sessionServiceClient.PollOnceCreateSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionResourceNames1Async()
        {
            // Snippet: CreateSessionAsync(LocationName, Session, CallSettings)
            // Additional: CreateSessionAsync(LocationName, Session, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Session session = new Session();
            // Make the request
            Operation<Session, CreateSessionOperationMetadata> response = await sessionServiceClient.CreateSessionAsync(parent, session);

            // Poll until the returned long-running operation is complete
            Operation<Session, CreateSessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, CreateSessionOperationMetadata> retrievedResponse = await sessionServiceClient.PollOnceCreateSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSessionResourceNames2()
        {
            // Snippet: CreateSession(ReasoningEngineName, Session, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            ReasoningEngineName parent = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            Session session = new Session();
            // Make the request
            Operation<Session, CreateSessionOperationMetadata> response = sessionServiceClient.CreateSession(parent, session);

            // Poll until the returned long-running operation is complete
            Operation<Session, CreateSessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, CreateSessionOperationMetadata> retrievedResponse = sessionServiceClient.PollOnceCreateSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionResourceNames2Async()
        {
            // Snippet: CreateSessionAsync(ReasoningEngineName, Session, CallSettings)
            // Additional: CreateSessionAsync(ReasoningEngineName, Session, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReasoningEngineName parent = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
            Session session = new Session();
            // Make the request
            Operation<Session, CreateSessionOperationMetadata> response = await sessionServiceClient.CreateSessionAsync(parent, session);

            // Poll until the returned long-running operation is complete
            Operation<Session, CreateSessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, CreateSessionOperationMetadata> retrievedResponse = await sessionServiceClient.PollOnceCreateSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
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
                SessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
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
                SessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
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
            SessionName name = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
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
            SessionName name = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
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
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
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
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
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
        public void ListSessionsResourceNames1()
        {
            // Snippet: ListSessions(LocationName, string, int?, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
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
        public async Task ListSessionsResourceNames1Async()
        {
            // Snippet: ListSessionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
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
        public void ListSessionsResourceNames2()
        {
            // Snippet: ListSessions(ReasoningEngineName, string, int?, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            ReasoningEngineName parent = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
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
        public async Task ListSessionsResourceNames2Async()
        {
            // Snippet: ListSessionsAsync(ReasoningEngineName, string, int?, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ReasoningEngineName parent = ReasoningEngineName.FromProjectLocationReasoningEngine("[PROJECT]", "[LOCATION]", "[REASONING_ENGINE]");
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

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSessionRequestObject()
        {
            // Snippet: DeleteSession(DeleteSessionRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = sessionServiceClient.DeleteSession(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = sessionServiceClient.PollOnceDeleteSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
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
                SessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
            };
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await sessionServiceClient.DeleteSessionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await sessionServiceClient.PollOnceDeleteSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSession()
        {
            // Snippet: DeleteSession(string, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = sessionServiceClient.DeleteSession(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = sessionServiceClient.PollOnceDeleteSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
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
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await sessionServiceClient.DeleteSessionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await sessionServiceClient.PollOnceDeleteSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSessionResourceNames()
        {
            // Snippet: DeleteSession(SessionName, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = sessionServiceClient.DeleteSession(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = sessionServiceClient.PollOnceDeleteSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
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
            SessionName name = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
            // Make the request
            Operation<Empty, DeleteOperationMetadata> response = await sessionServiceClient.DeleteSessionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, DeleteOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, DeleteOperationMetadata> retrievedResponse = await sessionServiceClient.PollOnceDeleteSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEventsRequestObject()
        {
            // Snippet: ListEvents(ListEventsRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            ListEventsRequest request = new ListEventsRequest
            {
                ParentAsSessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
            };
            // Make the request
            PagedEnumerable<ListEventsResponse, SessionEvent> response = sessionServiceClient.ListEvents(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SessionEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsRequestObjectAsync()
        {
            // Snippet: ListEventsAsync(ListEventsRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEventsRequest request = new ListEventsRequest
            {
                ParentAsSessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, SessionEvent> response = sessionServiceClient.ListEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SessionEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEvents()
        {
            // Snippet: ListEvents(string, string, int?, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
            // Make the request
            PagedEnumerable<ListEventsResponse, SessionEvent> response = sessionServiceClient.ListEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SessionEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsAsync()
        {
            // Snippet: ListEventsAsync(string, string, int?, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, SessionEvent> response = sessionServiceClient.ListEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SessionEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEvents</summary>
        public void ListEventsResourceNames()
        {
            // Snippet: ListEvents(SessionName, string, int?, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
            // Make the request
            PagedEnumerable<ListEventsResponse, SessionEvent> response = sessionServiceClient.ListEvents(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (SessionEvent item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListEventsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionEvent> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListEventsAsync</summary>
        public async Task ListEventsResourceNamesAsync()
        {
            // Snippet: ListEventsAsync(SessionName, string, int?, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SessionName parent = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, SessionEvent> response = sessionServiceClient.ListEventsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((SessionEvent item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (SessionEvent item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<SessionEvent> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (SessionEvent item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for AppendEvent</summary>
        public void AppendEventRequestObject()
        {
            // Snippet: AppendEvent(AppendEventRequest, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            AppendEventRequest request = new AppendEventRequest
            {
                SessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                Event = new SessionEvent(),
            };
            // Make the request
            AppendEventResponse response = sessionServiceClient.AppendEvent(request);
            // End snippet
        }

        /// <summary>Snippet for AppendEventAsync</summary>
        public async Task AppendEventRequestObjectAsync()
        {
            // Snippet: AppendEventAsync(AppendEventRequest, CallSettings)
            // Additional: AppendEventAsync(AppendEventRequest, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            AppendEventRequest request = new AppendEventRequest
            {
                SessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                Event = new SessionEvent(),
            };
            // Make the request
            AppendEventResponse response = await sessionServiceClient.AppendEventAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AppendEvent</summary>
        public void AppendEvent()
        {
            // Snippet: AppendEvent(string, SessionEvent, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
            SessionEvent @event = new SessionEvent();
            // Make the request
            AppendEventResponse response = sessionServiceClient.AppendEvent(name, @event);
            // End snippet
        }

        /// <summary>Snippet for AppendEventAsync</summary>
        public async Task AppendEventAsync()
        {
            // Snippet: AppendEventAsync(string, SessionEvent, CallSettings)
            // Additional: AppendEventAsync(string, SessionEvent, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
            SessionEvent @event = new SessionEvent();
            // Make the request
            AppendEventResponse response = await sessionServiceClient.AppendEventAsync(name, @event);
            // End snippet
        }

        /// <summary>Snippet for AppendEvent</summary>
        public void AppendEventResourceNames()
        {
            // Snippet: AppendEvent(SessionName, SessionEvent, CallSettings)
            // Create client
            SessionServiceClient sessionServiceClient = SessionServiceClient.Create();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
            SessionEvent @event = new SessionEvent();
            // Make the request
            AppendEventResponse response = sessionServiceClient.AppendEvent(name, @event);
            // End snippet
        }

        /// <summary>Snippet for AppendEventAsync</summary>
        public async Task AppendEventResourceNamesAsync()
        {
            // Snippet: AppendEventAsync(SessionName, SessionEvent, CallSettings)
            // Additional: AppendEventAsync(SessionName, SessionEvent, CancellationToken)
            // Create client
            SessionServiceClient sessionServiceClient = await SessionServiceClient.CreateAsync();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
            SessionEvent @event = new SessionEvent();
            // Make the request
            AppendEventResponse response = await sessionServiceClient.AppendEventAsync(name, @event);
            // End snippet
        }
    }
}
