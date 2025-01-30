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
    using Google.Cloud.Dataproc.V1;
    using Google.LongRunning;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSessionControllerClientSnippets
    {
        /// <summary>Snippet for CreateSession</summary>
        public void CreateSessionRequestObject()
        {
            // Snippet: CreateSession(CreateSessionRequest, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            CreateSessionRequest request = new CreateSessionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Session = new Session(),
                SessionId = "",
                RequestId = "",
            };
            // Make the request
            Operation<Session, SessionOperationMetadata> response = sessionControllerClient.CreateSession(request);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = sessionControllerClient.PollOnceCreateSession(operationName);
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
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            CreateSessionRequest request = new CreateSessionRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Session = new Session(),
                SessionId = "",
                RequestId = "",
            };
            // Make the request
            Operation<Session, SessionOperationMetadata> response = await sessionControllerClient.CreateSessionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = await sessionControllerClient.PollOnceCreateSessionAsync(operationName);
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
            // Snippet: CreateSession(string, Session, string, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Session session = new Session();
            string sessionId = "";
            // Make the request
            Operation<Session, SessionOperationMetadata> response = sessionControllerClient.CreateSession(parent, session, sessionId);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = sessionControllerClient.PollOnceCreateSession(operationName);
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
            // Snippet: CreateSessionAsync(string, Session, string, CallSettings)
            // Additional: CreateSessionAsync(string, Session, string, CancellationToken)
            // Create client
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Session session = new Session();
            string sessionId = "";
            // Make the request
            Operation<Session, SessionOperationMetadata> response = await sessionControllerClient.CreateSessionAsync(parent, session, sessionId);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = await sessionControllerClient.PollOnceCreateSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSessionResourceNames()
        {
            // Snippet: CreateSession(LocationName, Session, string, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Session session = new Session();
            string sessionId = "";
            // Make the request
            Operation<Session, SessionOperationMetadata> response = sessionControllerClient.CreateSession(parent, session, sessionId);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = sessionControllerClient.PollOnceCreateSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionResourceNamesAsync()
        {
            // Snippet: CreateSessionAsync(LocationName, Session, string, CallSettings)
            // Additional: CreateSessionAsync(LocationName, Session, string, CancellationToken)
            // Create client
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            Session session = new Session();
            string sessionId = "";
            // Make the request
            Operation<Session, SessionOperationMetadata> response = await sessionControllerClient.CreateSessionAsync(parent, session, sessionId);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = await sessionControllerClient.PollOnceCreateSessionAsync(operationName);
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
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
            };
            // Make the request
            Session response = sessionControllerClient.GetSession(request);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionRequestObjectAsync()
        {
            // Snippet: GetSessionAsync(GetSessionRequest, CallSettings)
            // Additional: GetSessionAsync(GetSessionRequest, CancellationToken)
            // Create client
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
            };
            // Make the request
            Session response = await sessionControllerClient.GetSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSession()
        {
            // Snippet: GetSession(string, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
            // Make the request
            Session response = sessionControllerClient.GetSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionAsync()
        {
            // Snippet: GetSessionAsync(string, CallSettings)
            // Additional: GetSessionAsync(string, CancellationToken)
            // Create client
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
            // Make the request
            Session response = await sessionControllerClient.GetSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSessionResourceNames()
        {
            // Snippet: GetSession(SessionName, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
            // Make the request
            Session response = sessionControllerClient.GetSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionResourceNamesAsync()
        {
            // Snippet: GetSessionAsync(SessionName, CallSettings)
            // Additional: GetSessionAsync(SessionName, CancellationToken)
            // Create client
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
            // Make the request
            Session response = await sessionControllerClient.GetSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSessions</summary>
        public void ListSessionsRequestObject()
        {
            // Snippet: ListSessions(ListSessionsRequest, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListSessionsResponse, Session> response = sessionControllerClient.ListSessions(request);

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
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            ListSessionsRequest request = new ListSessionsRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSessionsResponse, Session> response = sessionControllerClient.ListSessionsAsync(request);

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
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListSessionsResponse, Session> response = sessionControllerClient.ListSessions(parent);

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
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListSessionsResponse, Session> response = sessionControllerClient.ListSessionsAsync(parent);

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
            // Snippet: ListSessions(LocationName, string, int?, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListSessionsResponse, Session> response = sessionControllerClient.ListSessions(parent);

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
            // Snippet: ListSessionsAsync(LocationName, string, int?, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListSessionsResponse, Session> response = sessionControllerClient.ListSessionsAsync(parent);

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

        /// <summary>Snippet for TerminateSession</summary>
        public void TerminateSessionRequestObject()
        {
            // Snippet: TerminateSession(TerminateSessionRequest, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            TerminateSessionRequest request = new TerminateSessionRequest
            {
                SessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Session, SessionOperationMetadata> response = sessionControllerClient.TerminateSession(request);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = sessionControllerClient.PollOnceTerminateSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TerminateSessionAsync</summary>
        public async Task TerminateSessionRequestObjectAsync()
        {
            // Snippet: TerminateSessionAsync(TerminateSessionRequest, CallSettings)
            // Additional: TerminateSessionAsync(TerminateSessionRequest, CancellationToken)
            // Create client
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            TerminateSessionRequest request = new TerminateSessionRequest
            {
                SessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Session, SessionOperationMetadata> response = await sessionControllerClient.TerminateSessionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = await sessionControllerClient.PollOnceTerminateSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TerminateSession</summary>
        public void TerminateSession()
        {
            // Snippet: TerminateSession(string, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
            // Make the request
            Operation<Session, SessionOperationMetadata> response = sessionControllerClient.TerminateSession(name);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = sessionControllerClient.PollOnceTerminateSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TerminateSessionAsync</summary>
        public async Task TerminateSessionAsync()
        {
            // Snippet: TerminateSessionAsync(string, CallSettings)
            // Additional: TerminateSessionAsync(string, CancellationToken)
            // Create client
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
            // Make the request
            Operation<Session, SessionOperationMetadata> response = await sessionControllerClient.TerminateSessionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = await sessionControllerClient.PollOnceTerminateSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TerminateSession</summary>
        public void TerminateSessionResourceNames()
        {
            // Snippet: TerminateSession(SessionName, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
            // Make the request
            Operation<Session, SessionOperationMetadata> response = sessionControllerClient.TerminateSession(name);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = sessionControllerClient.PollOnceTerminateSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for TerminateSessionAsync</summary>
        public async Task TerminateSessionResourceNamesAsync()
        {
            // Snippet: TerminateSessionAsync(SessionName, CallSettings)
            // Additional: TerminateSessionAsync(SessionName, CancellationToken)
            // Create client
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
            // Make the request
            Operation<Session, SessionOperationMetadata> response = await sessionControllerClient.TerminateSessionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = await sessionControllerClient.PollOnceTerminateSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSessionRequestObject()
        {
            // Snippet: DeleteSession(DeleteSessionRequest, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Session, SessionOperationMetadata> response = sessionControllerClient.DeleteSession(request);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = sessionControllerClient.PollOnceDeleteSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionRequestObjectAsync()
        {
            // Snippet: DeleteSessionAsync(DeleteSessionRequest, CallSettings)
            // Additional: DeleteSessionAsync(DeleteSessionRequest, CancellationToken)
            // Create client
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]"),
                RequestId = "",
            };
            // Make the request
            Operation<Session, SessionOperationMetadata> response = await sessionControllerClient.DeleteSessionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = await sessionControllerClient.PollOnceDeleteSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSession()
        {
            // Snippet: DeleteSession(string, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
            // Make the request
            Operation<Session, SessionOperationMetadata> response = sessionControllerClient.DeleteSession(name);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = sessionControllerClient.PollOnceDeleteSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionAsync()
        {
            // Snippet: DeleteSessionAsync(string, CallSettings)
            // Additional: DeleteSessionAsync(string, CancellationToken)
            // Create client
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/sessions/[SESSION]";
            // Make the request
            Operation<Session, SessionOperationMetadata> response = await sessionControllerClient.DeleteSessionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = await sessionControllerClient.PollOnceDeleteSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSessionResourceNames()
        {
            // Snippet: DeleteSession(SessionName, CallSettings)
            // Create client
            SessionControllerClient sessionControllerClient = SessionControllerClient.Create();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
            // Make the request
            Operation<Session, SessionOperationMetadata> response = sessionControllerClient.DeleteSession(name);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = sessionControllerClient.PollOnceDeleteSession(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionResourceNamesAsync()
        {
            // Snippet: DeleteSessionAsync(SessionName, CallSettings)
            // Additional: DeleteSessionAsync(SessionName, CancellationToken)
            // Create client
            SessionControllerClient sessionControllerClient = await SessionControllerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName name = SessionName.FromProjectLocationSession("[PROJECT]", "[LOCATION]", "[SESSION]");
            // Make the request
            Operation<Session, SessionOperationMetadata> response = await sessionControllerClient.DeleteSessionAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Session, SessionOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Session result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Session, SessionOperationMetadata> retrievedResponse = await sessionControllerClient.PollOnceDeleteSessionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Session retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
