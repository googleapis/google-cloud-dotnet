// Copyright 2019 Google LLC
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

namespace Google.Cloud.Spanner.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Cloud.Spanner.Common.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class GeneratedSpannerClientSnippets
    {
        /// <summary>Snippet for CreateSession</summary>
        public void CreateSession_RequestObject()
        {
            // Snippet: CreateSession(CreateSessionRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            CreateSessionRequest request = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Session = new Session(),
            };
            // Make the request
            Session response = spannerClient.CreateSession(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionAsync_RequestObject()
        {
            // Snippet: CreateSessionAsync(CreateSessionRequest, CallSettings)
            // Additional: CreateSessionAsync(CreateSessionRequest, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            CreateSessionRequest request = new CreateSessionRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Session = new Session(),
            };
            // Make the request
            Session response = await spannerClient.CreateSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSession()
        {
            // Snippet: CreateSession(string, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            Session response = spannerClient.CreateSession(database);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionAsync()
        {
            // Snippet: CreateSessionAsync(string, CallSettings)
            // Additional: CreateSessionAsync(string, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            Session response = await spannerClient.CreateSessionAsync(database);
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSession_ResourceNames()
        {
            // Snippet: CreateSession(DatabaseName, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            Session response = spannerClient.CreateSession(database);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionAsync_ResourceNames()
        {
            // Snippet: CreateSessionAsync(DatabaseName, CallSettings)
            // Additional: CreateSessionAsync(DatabaseName, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            Session response = await spannerClient.CreateSessionAsync(database);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSessions</summary>
        public void BatchCreateSessions_RequestObject()
        {
            // Snippet: BatchCreateSessions(BatchCreateSessionsRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            BatchCreateSessionsRequest request = new BatchCreateSessionsRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                SessionTemplate = new Session(),
                SessionCount = 0,
            };
            // Make the request
            BatchCreateSessionsResponse response = spannerClient.BatchCreateSessions(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSessionsAsync</summary>
        public async Task BatchCreateSessionsAsync_RequestObject()
        {
            // Snippet: BatchCreateSessionsAsync(BatchCreateSessionsRequest, CallSettings)
            // Additional: BatchCreateSessionsAsync(BatchCreateSessionsRequest, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateSessionsRequest request = new BatchCreateSessionsRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                SessionTemplate = new Session(),
                SessionCount = 0,
            };
            // Make the request
            BatchCreateSessionsResponse response = await spannerClient.BatchCreateSessionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSessions</summary>
        public void BatchCreateSessions()
        {
            // Snippet: BatchCreateSessions(string, int, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            int sessionCount = 0;
            // Make the request
            BatchCreateSessionsResponse response = spannerClient.BatchCreateSessions(database, sessionCount);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSessionsAsync</summary>
        public async Task BatchCreateSessionsAsync()
        {
            // Snippet: BatchCreateSessionsAsync(string, int, CallSettings)
            // Additional: BatchCreateSessionsAsync(string, int, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            int sessionCount = 0;
            // Make the request
            BatchCreateSessionsResponse response = await spannerClient.BatchCreateSessionsAsync(database, sessionCount);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSessions</summary>
        public void BatchCreateSessions_ResourceNames()
        {
            // Snippet: BatchCreateSessions(DatabaseName, int, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            int sessionCount = 0;
            // Make the request
            BatchCreateSessionsResponse response = spannerClient.BatchCreateSessions(database, sessionCount);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSessionsAsync</summary>
        public async Task BatchCreateSessionsAsync_ResourceNames()
        {
            // Snippet: BatchCreateSessionsAsync(DatabaseName, int, CallSettings)
            // Additional: BatchCreateSessionsAsync(DatabaseName, int, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            int sessionCount = 0;
            // Make the request
            BatchCreateSessionsResponse response = await spannerClient.BatchCreateSessionsAsync(database, sessionCount);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSession_RequestObject()
        {
            // Snippet: GetSession(GetSessionRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // Make the request
            Session response = spannerClient.GetSession(request);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionAsync_RequestObject()
        {
            // Snippet: GetSessionAsync(GetSessionRequest, CallSettings)
            // Additional: GetSessionAsync(GetSessionRequest, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            GetSessionRequest request = new GetSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // Make the request
            Session response = await spannerClient.GetSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSession()
        {
            // Snippet: GetSession(string, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            // Make the request
            Session response = spannerClient.GetSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionAsync()
        {
            // Snippet: GetSessionAsync(string, CallSettings)
            // Additional: GetSessionAsync(string, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            // Make the request
            Session response = await spannerClient.GetSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSession_ResourceNames()
        {
            // Snippet: GetSession(SessionName, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            // Make the request
            Session response = spannerClient.GetSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionAsync_ResourceNames()
        {
            // Snippet: GetSessionAsync(SessionName, CallSettings)
            // Additional: GetSessionAsync(SessionName, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            // Make the request
            Session response = await spannerClient.GetSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSessions</summary>
        public void ListSessions_RequestObject()
        {
            // Snippet: ListSessions(ListSessionsRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            ListSessionsRequest request = new ListSessionsRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListSessionsResponse, Session> response = spannerClient.ListSessions(request);

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

        /// <summary>Snippet for ListSessions</summary>
        public async Task ListSessionsAsync_RequestObject()
        {
            // Snippet: ListSessionsAsync(ListSessionsRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            ListSessionsRequest request = new ListSessionsRequest
            {
                DatabaseAsDatabaseName = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListSessionsResponse, Session> response = spannerClient.ListSessionsAsync(request);

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
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            PagedEnumerable<ListSessionsResponse, Session> response = spannerClient.ListSessions(database);

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

        /// <summary>Snippet for ListSessions</summary>
        public async Task ListSessionsAsync()
        {
            // Snippet: ListSessionsAsync(string, string, int?, CallSettings)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            PagedAsyncEnumerable<ListSessionsResponse, Session> response = spannerClient.ListSessionsAsync(database);

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
        public void ListSessions_ResourceNames()
        {
            // Snippet: ListSessions(DatabaseName, string, int?, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            PagedEnumerable<ListSessionsResponse, Session> response = spannerClient.ListSessions(database);

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

        /// <summary>Snippet for ListSessions</summary>
        public async Task ListSessionsAsync_ResourceNames()
        {
            // Snippet: ListSessionsAsync(DatabaseName, string, int?, CallSettings)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = new DatabaseName("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            PagedAsyncEnumerable<ListSessionsResponse, Session> response = spannerClient.ListSessionsAsync(database);

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

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSession_RequestObject()
        {
            // Snippet: DeleteSession(DeleteSessionRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // Make the request
            spannerClient.DeleteSession(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionAsync_RequestObject()
        {
            // Snippet: DeleteSessionAsync(DeleteSessionRequest, CallSettings)
            // Additional: DeleteSessionAsync(DeleteSessionRequest, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSessionRequest request = new DeleteSessionRequest
            {
                SessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // Make the request
            await spannerClient.DeleteSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSession()
        {
            // Snippet: DeleteSession(string, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            // Make the request
            spannerClient.DeleteSession(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionAsync()
        {
            // Snippet: DeleteSessionAsync(string, CallSettings)
            // Additional: DeleteSessionAsync(string, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            // Make the request
            await spannerClient.DeleteSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSession_ResourceNames()
        {
            // Snippet: DeleteSession(SessionName, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            // Make the request
            spannerClient.DeleteSession(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionAsync_ResourceNames()
        {
            // Snippet: DeleteSessionAsync(SessionName, CallSettings)
            // Additional: DeleteSessionAsync(SessionName, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName name = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            // Make the request
            await spannerClient.DeleteSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ExecuteSql</summary>
        public void ExecuteSql_RequestObject()
        {
            // Snippet: ExecuteSql(ExecuteSqlRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Sql = "",
                Params = new Struct(),
                ParamTypes = { { "", new V1.Type() }, },
                ResumeToken = ByteString.Empty,
                QueryMode = ExecuteSqlRequest.Types.QueryMode.Normal,
                PartitionToken = ByteString.Empty,
                Seqno = 0L,
            };
            // Make the request
            ResultSet response = spannerClient.ExecuteSql(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteSqlAsync</summary>
        public async Task ExecuteSqlAsync_RequestObject()
        {
            // Snippet: ExecuteSqlAsync(ExecuteSqlRequest, CallSettings)
            // Additional: ExecuteSqlAsync(ExecuteSqlRequest, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Sql = "",
                Params = new Struct(),
                ParamTypes = { { "", new V1.Type() }, },
                ResumeToken = ByteString.Empty,
                QueryMode = ExecuteSqlRequest.Types.QueryMode.Normal,
                PartitionToken = ByteString.Empty,
                Seqno = 0L,
            };
            // Make the request
            ResultSet response = await spannerClient.ExecuteSqlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteStreamingSql</summary>
        public async Task ExecuteStreamingSql_RequestObject()
        {
            // Snippet: ExecuteStreamingSql(ExecuteSqlRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            ExecuteSqlRequest request = new ExecuteSqlRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Sql = "",
                Params = new Struct(),
                ParamTypes = { { "", new V1.Type() }, },
                ResumeToken = ByteString.Empty,
                QueryMode = ExecuteSqlRequest.Types.QueryMode.Normal,
                PartitionToken = ByteString.Empty,
                Seqno = 0L,
            };
            // Make the request, returning a streaming response
            SpannerClient.ExecuteStreamingSqlStream response = spannerClient.ExecuteStreamingSql(request);

            // Read streaming responses from server until complete
            var responseStream = response.GrpcCall.ResponseStream;
            while (await responseStream.MoveNext(default))
            {
                PartialResultSet responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ExecuteBatchDml</summary>
        public void ExecuteBatchDml_RequestObject()
        {
            // Snippet: ExecuteBatchDml(ExecuteBatchDmlRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            ExecuteBatchDmlRequest request = new ExecuteBatchDmlRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Statements =
                {
                    new ExecuteBatchDmlRequest.Types.Statement(),
                },
                Seqno = 0L,
            };
            // Make the request
            ExecuteBatchDmlResponse response = spannerClient.ExecuteBatchDml(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteBatchDmlAsync</summary>
        public async Task ExecuteBatchDmlAsync_RequestObject()
        {
            // Snippet: ExecuteBatchDmlAsync(ExecuteBatchDmlRequest, CallSettings)
            // Additional: ExecuteBatchDmlAsync(ExecuteBatchDmlRequest, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            ExecuteBatchDmlRequest request = new ExecuteBatchDmlRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Statements =
                {
                    new ExecuteBatchDmlRequest.Types.Statement(),
                },
                Seqno = 0L,
            };
            // Make the request
            ExecuteBatchDmlResponse response = await spannerClient.ExecuteBatchDmlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Read</summary>
        public void Read_RequestObject()
        {
            // Snippet: Read(ReadRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            ReadRequest request = new ReadRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Table = "",
                Index = "",
                Columns = { "", },
                KeySet = new KeySet(),
                Limit = 0L,
                ResumeToken = ByteString.Empty,
                PartitionToken = ByteString.Empty,
            };
            // Make the request
            ResultSet response = spannerClient.Read(request);
            // End snippet
        }

        /// <summary>Snippet for ReadAsync</summary>
        public async Task ReadAsync_RequestObject()
        {
            // Snippet: ReadAsync(ReadRequest, CallSettings)
            // Additional: ReadAsync(ReadRequest, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            ReadRequest request = new ReadRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Table = "",
                Index = "",
                Columns = { "", },
                KeySet = new KeySet(),
                Limit = 0L,
                ResumeToken = ByteString.Empty,
                PartitionToken = ByteString.Empty,
            };
            // Make the request
            ResultSet response = await spannerClient.ReadAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StreamingRead</summary>
        public async Task StreamingRead_RequestObject()
        {
            // Snippet: StreamingRead(ReadRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            ReadRequest request = new ReadRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Table = "",
                Index = "",
                Columns = { "", },
                KeySet = new KeySet(),
                Limit = 0L,
                ResumeToken = ByteString.Empty,
                PartitionToken = ByteString.Empty,
            };
            // Make the request, returning a streaming response
            SpannerClient.StreamingReadStream response = spannerClient.StreamingRead(request);

            // Read streaming responses from server until complete
            var responseStream = response.GrpcCall.ResponseStream;
            while (await responseStream.MoveNext(default))
            {
                PartialResultSet responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for BeginTransaction</summary>
        public void BeginTransaction_RequestObject()
        {
            // Snippet: BeginTransaction(BeginTransactionRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
            };
            // Make the request
            Transaction response = spannerClient.BeginTransaction(request);
            // End snippet
        }

        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionAsync_RequestObject()
        {
            // Snippet: BeginTransactionAsync(BeginTransactionRequest, CallSettings)
            // Additional: BeginTransactionAsync(BeginTransactionRequest, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            BeginTransactionRequest request = new BeginTransactionRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new TransactionOptions(),
            };
            // Make the request
            Transaction response = await spannerClient.BeginTransactionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BeginTransaction</summary>
        public void BeginTransaction()
        {
            // Snippet: BeginTransaction(string, TransactionOptions, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            TransactionOptions options = new TransactionOptions();
            // Make the request
            Transaction response = spannerClient.BeginTransaction(session, options);
            // End snippet
        }

        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionAsync()
        {
            // Snippet: BeginTransactionAsync(string, TransactionOptions, CallSettings)
            // Additional: BeginTransactionAsync(string, TransactionOptions, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            TransactionOptions options = new TransactionOptions();
            // Make the request
            Transaction response = await spannerClient.BeginTransactionAsync(session, options);
            // End snippet
        }

        /// <summary>Snippet for BeginTransaction</summary>
        public void BeginTransaction_ResourceNames()
        {
            // Snippet: BeginTransaction(SessionName, TransactionOptions, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions options = new TransactionOptions();
            // Make the request
            Transaction response = spannerClient.BeginTransaction(session, options);
            // End snippet
        }

        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionAsync_ResourceNames()
        {
            // Snippet: BeginTransactionAsync(SessionName, TransactionOptions, CallSettings)
            // Additional: BeginTransactionAsync(SessionName, TransactionOptions, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions options = new TransactionOptions();
            // Make the request
            Transaction response = await spannerClient.BeginTransactionAsync(session, options);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit_RequestObject()
        {
            // Snippet: Commit(CommitRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.Empty,
                SingleUseTransaction = new TransactionOptions(),
                Mutations = { new Mutation(), },
            };
            // Make the request
            CommitResponse response = spannerClient.Commit(request);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task CommitAsync_RequestObject()
        {
            // Snippet: CommitAsync(CommitRequest, CallSettings)
            // Additional: CommitAsync(CommitRequest, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            CommitRequest request = new CommitRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.Empty,
                SingleUseTransaction = new TransactionOptions(),
                Mutations = { new Mutation(), },
            };
            // Make the request
            CommitResponse response = await spannerClient.CommitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit1()
        {
            // Snippet: Commit(string, ByteString, IEnumerable<Mutation>, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            ByteString transactionId = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = spannerClient.Commit(session, transactionId, mutations);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task Commit1Async()
        {
            // Snippet: CommitAsync(string, ByteString, IEnumerable<Mutation>, CallSettings)
            // Additional: CommitAsync(string, ByteString, IEnumerable<Mutation>, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            ByteString transactionId = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = await spannerClient.CommitAsync(session, transactionId, mutations);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit1_ResourceNames()
        {
            // Snippet: Commit(SessionName, ByteString, IEnumerable<Mutation>, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = spannerClient.Commit(session, transactionId, mutations);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task Commit1Async_ResourceNames()
        {
            // Snippet: CommitAsync(SessionName, ByteString, IEnumerable<Mutation>, CallSettings)
            // Additional: CommitAsync(SessionName, ByteString, IEnumerable<Mutation>, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.Empty;
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = await spannerClient.CommitAsync(session, transactionId, mutations);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit2()
        {
            // Snippet: Commit(string, TransactionOptions, IEnumerable<Mutation>, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            TransactionOptions singleUseTransaction = new TransactionOptions();
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = spannerClient.Commit(session, singleUseTransaction, mutations);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task Commit2Async()
        {
            // Snippet: CommitAsync(string, TransactionOptions, IEnumerable<Mutation>, CallSettings)
            // Additional: CommitAsync(string, TransactionOptions, IEnumerable<Mutation>, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            TransactionOptions singleUseTransaction = new TransactionOptions();
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = await spannerClient.CommitAsync(session, singleUseTransaction, mutations);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit2_ResourceNames()
        {
            // Snippet: Commit(SessionName, TransactionOptions, IEnumerable<Mutation>, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions singleUseTransaction = new TransactionOptions();
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = spannerClient.Commit(session, singleUseTransaction, mutations);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task Commit2Async_ResourceNames()
        {
            // Snippet: CommitAsync(SessionName, TransactionOptions, IEnumerable<Mutation>, CallSettings)
            // Additional: CommitAsync(SessionName, TransactionOptions, IEnumerable<Mutation>, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            TransactionOptions singleUseTransaction = new TransactionOptions();
            IEnumerable<Mutation> mutations = new Mutation[] { new Mutation(), };
            // Make the request
            CommitResponse response = await spannerClient.CommitAsync(session, singleUseTransaction, mutations);
            // End snippet
        }

        /// <summary>Snippet for Rollback</summary>
        public void Rollback_RequestObject()
        {
            // Snippet: Rollback(RollbackRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            RollbackRequest request = new RollbackRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.Empty,
            };
            // Make the request
            spannerClient.Rollback(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackAsync</summary>
        public async Task RollbackAsync_RequestObject()
        {
            // Snippet: RollbackAsync(RollbackRequest, CallSettings)
            // Additional: RollbackAsync(RollbackRequest, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            RollbackRequest request = new RollbackRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.Empty,
            };
            // Make the request
            await spannerClient.RollbackAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Rollback</summary>
        public void Rollback()
        {
            // Snippet: Rollback(string, ByteString, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            ByteString transactionId = ByteString.Empty;
            // Make the request
            spannerClient.Rollback(session, transactionId);
            // End snippet
        }

        /// <summary>Snippet for RollbackAsync</summary>
        public async Task RollbackAsync()
        {
            // Snippet: RollbackAsync(string, ByteString, CallSettings)
            // Additional: RollbackAsync(string, ByteString, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            ByteString transactionId = ByteString.Empty;
            // Make the request
            await spannerClient.RollbackAsync(session, transactionId);
            // End snippet
        }

        /// <summary>Snippet for Rollback</summary>
        public void Rollback_ResourceNames()
        {
            // Snippet: Rollback(SessionName, ByteString, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.Empty;
            // Make the request
            spannerClient.Rollback(session, transactionId);
            // End snippet
        }

        /// <summary>Snippet for RollbackAsync</summary>
        public async Task RollbackAsync_ResourceNames()
        {
            // Snippet: RollbackAsync(SessionName, ByteString, CallSettings)
            // Additional: RollbackAsync(SessionName, ByteString, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            SessionName session = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.Empty;
            // Make the request
            await spannerClient.RollbackAsync(session, transactionId);
            // End snippet
        }

        /// <summary>Snippet for PartitionQuery</summary>
        public void PartitionQuery_RequestObject()
        {
            // Snippet: PartitionQuery(PartitionQueryRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            PartitionQueryRequest request = new PartitionQueryRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Sql = "",
                Params = new Struct(),
                ParamTypes = { { "", new V1.Type() }, },
                PartitionOptions = new PartitionOptions(),
            };
            // Make the request
            PartitionResponse response = spannerClient.PartitionQuery(request);
            // End snippet
        }

        /// <summary>Snippet for PartitionQueryAsync</summary>
        public async Task PartitionQueryAsync_RequestObject()
        {
            // Snippet: PartitionQueryAsync(PartitionQueryRequest, CallSettings)
            // Additional: PartitionQueryAsync(PartitionQueryRequest, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            PartitionQueryRequest request = new PartitionQueryRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Sql = "",
                Params = new Struct(),
                ParamTypes = { { "", new V1.Type() }, },
                PartitionOptions = new PartitionOptions(),
            };
            // Make the request
            PartitionResponse response = await spannerClient.PartitionQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PartitionRead</summary>
        public void PartitionRead_RequestObject()
        {
            // Snippet: PartitionRead(PartitionReadRequest, CallSettings)
            // Create client
            SpannerClient spannerClient = SpannerClient.Create();
            // Initialize request argument(s)
            PartitionReadRequest request = new PartitionReadRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Table = "",
                Index = "",
                Columns = { "", },
                KeySet = new KeySet(),
                PartitionOptions = new PartitionOptions(),
            };
            // Make the request
            PartitionResponse response = spannerClient.PartitionRead(request);
            // End snippet
        }

        /// <summary>Snippet for PartitionReadAsync</summary>
        public async Task PartitionReadAsync_RequestObject()
        {
            // Snippet: PartitionReadAsync(PartitionReadRequest, CallSettings)
            // Additional: PartitionReadAsync(PartitionReadRequest, CancellationToken)
            // Create client
            SpannerClient spannerClient = await SpannerClient.CreateAsync();
            // Initialize request argument(s)
            PartitionReadRequest request = new PartitionReadRequest
            {
                SessionAsSessionName = new SessionName("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new TransactionSelector(),
                Table = "",
                Index = "",
                Columns = { "", },
                KeySet = new KeySet(),
                PartitionOptions = new PartitionOptions(),
            };
            // Make the request
            PartitionResponse response = await spannerClient.PartitionReadAsync(request);
            // End snippet
        }
    }
}
