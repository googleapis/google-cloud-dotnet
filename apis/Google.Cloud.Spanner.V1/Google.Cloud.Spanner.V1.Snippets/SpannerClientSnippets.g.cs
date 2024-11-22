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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Spanner.Common.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using gcsv = Google.Cloud.Spanner.V1;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSpannerClientSnippets
    {
        /// <summary>Snippet for CreateSession</summary>
        public void CreateSessionRequestObject()
        {
            // Snippet: CreateSession(CreateSessionRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::CreateSessionRequest request = new gcsv::CreateSessionRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Session = new gcsv::Session(),
            };
            // Make the request
            gcsv::Session response = spannerClient.CreateSession(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionRequestObjectAsync()
        {
            // Snippet: CreateSessionAsync(CreateSessionRequest, CallSettings)
            // Additional: CreateSessionAsync(CreateSessionRequest, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::CreateSessionRequest request = new gcsv::CreateSessionRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Session = new gcsv::Session(),
            };
            // Make the request
            gcsv::Session response = await spannerClient.CreateSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSession()
        {
            // Snippet: CreateSession(string, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            gcsv::Session response = spannerClient.CreateSession(database);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionAsync()
        {
            // Snippet: CreateSessionAsync(string, CallSettings)
            // Additional: CreateSessionAsync(string, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            gcsv::Session response = await spannerClient.CreateSessionAsync(database);
            // End snippet
        }

        /// <summary>Snippet for CreateSession</summary>
        public void CreateSessionResourceNames()
        {
            // Snippet: CreateSession(DatabaseName, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            gcsv::Session response = spannerClient.CreateSession(database);
            // End snippet
        }

        /// <summary>Snippet for CreateSessionAsync</summary>
        public async Task CreateSessionResourceNamesAsync()
        {
            // Snippet: CreateSessionAsync(DatabaseName, CallSettings)
            // Additional: CreateSessionAsync(DatabaseName, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            gcsv::Session response = await spannerClient.CreateSessionAsync(database);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSessions</summary>
        public void BatchCreateSessionsRequestObject()
        {
            // Snippet: BatchCreateSessions(BatchCreateSessionsRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::BatchCreateSessionsRequest request = new gcsv::BatchCreateSessionsRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                SessionTemplate = new gcsv::Session(),
                SessionCount = 0,
            };
            // Make the request
            gcsv::BatchCreateSessionsResponse response = spannerClient.BatchCreateSessions(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSessionsAsync</summary>
        public async Task BatchCreateSessionsRequestObjectAsync()
        {
            // Snippet: BatchCreateSessionsAsync(BatchCreateSessionsRequest, CallSettings)
            // Additional: BatchCreateSessionsAsync(BatchCreateSessionsRequest, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::BatchCreateSessionsRequest request = new gcsv::BatchCreateSessionsRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                SessionTemplate = new gcsv::Session(),
                SessionCount = 0,
            };
            // Make the request
            gcsv::BatchCreateSessionsResponse response = await spannerClient.BatchCreateSessionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSessions</summary>
        public void BatchCreateSessions()
        {
            // Snippet: BatchCreateSessions(string, int, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            int sessionCount = 0;
            // Make the request
            gcsv::BatchCreateSessionsResponse response = spannerClient.BatchCreateSessions(database, sessionCount);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSessionsAsync</summary>
        public async Task BatchCreateSessionsAsync()
        {
            // Snippet: BatchCreateSessionsAsync(string, int, CallSettings)
            // Additional: BatchCreateSessionsAsync(string, int, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            int sessionCount = 0;
            // Make the request
            gcsv::BatchCreateSessionsResponse response = await spannerClient.BatchCreateSessionsAsync(database, sessionCount);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSessions</summary>
        public void BatchCreateSessionsResourceNames()
        {
            // Snippet: BatchCreateSessions(DatabaseName, int, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            int sessionCount = 0;
            // Make the request
            gcsv::BatchCreateSessionsResponse response = spannerClient.BatchCreateSessions(database, sessionCount);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateSessionsAsync</summary>
        public async Task BatchCreateSessionsResourceNamesAsync()
        {
            // Snippet: BatchCreateSessionsAsync(DatabaseName, int, CallSettings)
            // Additional: BatchCreateSessionsAsync(DatabaseName, int, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            int sessionCount = 0;
            // Make the request
            gcsv::BatchCreateSessionsResponse response = await spannerClient.BatchCreateSessionsAsync(database, sessionCount);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSessionRequestObject()
        {
            // Snippet: GetSession(GetSessionRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::GetSessionRequest request = new gcsv::GetSessionRequest
            {
                SessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // Make the request
            gcsv::Session response = spannerClient.GetSession(request);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionRequestObjectAsync()
        {
            // Snippet: GetSessionAsync(GetSessionRequest, CallSettings)
            // Additional: GetSessionAsync(GetSessionRequest, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::GetSessionRequest request = new gcsv::GetSessionRequest
            {
                SessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // Make the request
            gcsv::Session response = await spannerClient.GetSessionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSession()
        {
            // Snippet: GetSession(string, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            // Make the request
            gcsv::Session response = spannerClient.GetSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionAsync()
        {
            // Snippet: GetSessionAsync(string, CallSettings)
            // Additional: GetSessionAsync(string, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            // Make the request
            gcsv::Session response = await spannerClient.GetSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSession</summary>
        public void GetSessionResourceNames()
        {
            // Snippet: GetSession(SessionName, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::SessionName name = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            // Make the request
            gcsv::Session response = spannerClient.GetSession(name);
            // End snippet
        }

        /// <summary>Snippet for GetSessionAsync</summary>
        public async Task GetSessionResourceNamesAsync()
        {
            // Snippet: GetSessionAsync(SessionName, CallSettings)
            // Additional: GetSessionAsync(SessionName, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::SessionName name = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            // Make the request
            gcsv::Session response = await spannerClient.GetSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSessions</summary>
        public void ListSessionsRequestObject()
        {
            // Snippet: ListSessions(ListSessionsRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::ListSessionsRequest request = new gcsv::ListSessionsRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<gcsv::ListSessionsResponse, gcsv::Session> response = spannerClient.ListSessions(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcsv::Session item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcsv::ListSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Session> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Session item in singlePage)
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
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::ListSessionsRequest request = new gcsv::ListSessionsRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<gcsv::ListSessionsResponse, gcsv::Session> response = spannerClient.ListSessionsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcsv::Session item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcsv::ListSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Session> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Session item in singlePage)
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
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            PagedEnumerable<gcsv::ListSessionsResponse, gcsv::Session> response = spannerClient.ListSessions(database);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcsv::Session item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcsv::ListSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Session> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Session item in singlePage)
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
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            PagedAsyncEnumerable<gcsv::ListSessionsResponse, gcsv::Session> response = spannerClient.ListSessionsAsync(database);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcsv::Session item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcsv::ListSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Session> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Session item in singlePage)
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
            // Snippet: ListSessions(DatabaseName, string, int?, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            PagedEnumerable<gcsv::ListSessionsResponse, gcsv::Session> response = spannerClient.ListSessions(database);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (gcsv::Session item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (gcsv::ListSessionsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Session> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Session item in singlePage)
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
            // Snippet: ListSessionsAsync(DatabaseName, string, int?, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            PagedAsyncEnumerable<gcsv::ListSessionsResponse, gcsv::Session> response = spannerClient.ListSessionsAsync(database);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((gcsv::Session item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((gcsv::ListSessionsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (gcsv::Session item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<gcsv::Session> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (gcsv::Session item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSessionRequestObject()
        {
            // Snippet: DeleteSession(DeleteSessionRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::DeleteSessionRequest request = new gcsv::DeleteSessionRequest
            {
                SessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
            };
            // Make the request
            spannerClient.DeleteSession(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionRequestObjectAsync()
        {
            // Snippet: DeleteSessionAsync(DeleteSessionRequest, CallSettings)
            // Additional: DeleteSessionAsync(DeleteSessionRequest, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::DeleteSessionRequest request = new gcsv::DeleteSessionRequest
            {
                SessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
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
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
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
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            // Make the request
            await spannerClient.DeleteSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSession</summary>
        public void DeleteSessionResourceNames()
        {
            // Snippet: DeleteSession(SessionName, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::SessionName name = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            // Make the request
            spannerClient.DeleteSession(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSessionAsync</summary>
        public async Task DeleteSessionResourceNamesAsync()
        {
            // Snippet: DeleteSessionAsync(SessionName, CallSettings)
            // Additional: DeleteSessionAsync(SessionName, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::SessionName name = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            // Make the request
            await spannerClient.DeleteSessionAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ExecuteSql</summary>
        public void ExecuteSqlRequestObject()
        {
            // Snippet: ExecuteSql(ExecuteSqlRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::ExecuteSqlRequest request = new gcsv::ExecuteSqlRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Sql = "",
                Params = new Struct(),
                ParamTypes =
                {
                    {
                        "",
                        new gcsv::Type()
                    },
                },
                ResumeToken = ByteString.Empty,
                QueryMode = gcsv::ExecuteSqlRequest.Types.QueryMode.Normal,
                PartitionToken = ByteString.Empty,
                Seqno = 0L,
                QueryOptions = new gcsv::ExecuteSqlRequest.Types.QueryOptions(),
                RequestOptions = new gcsv::RequestOptions(),
                DirectedReadOptions = new gcsv::DirectedReadOptions(),
                DataBoostEnabled = false,
                LastStatement = false,
            };
            // Make the request
            gcsv::ResultSet response = spannerClient.ExecuteSql(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteSqlAsync</summary>
        public async Task ExecuteSqlRequestObjectAsync()
        {
            // Snippet: ExecuteSqlAsync(ExecuteSqlRequest, CallSettings)
            // Additional: ExecuteSqlAsync(ExecuteSqlRequest, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::ExecuteSqlRequest request = new gcsv::ExecuteSqlRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Sql = "",
                Params = new Struct(),
                ParamTypes =
                {
                    {
                        "",
                        new gcsv::Type()
                    },
                },
                ResumeToken = ByteString.Empty,
                QueryMode = gcsv::ExecuteSqlRequest.Types.QueryMode.Normal,
                PartitionToken = ByteString.Empty,
                Seqno = 0L,
                QueryOptions = new gcsv::ExecuteSqlRequest.Types.QueryOptions(),
                RequestOptions = new gcsv::RequestOptions(),
                DirectedReadOptions = new gcsv::DirectedReadOptions(),
                DataBoostEnabled = false,
                LastStatement = false,
            };
            // Make the request
            gcsv::ResultSet response = await spannerClient.ExecuteSqlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteStreamingSql</summary>
        public async Task ExecuteStreamingSqlRequestObject()
        {
            // Snippet: ExecuteStreamingSql(ExecuteSqlRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::ExecuteSqlRequest request = new gcsv::ExecuteSqlRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Sql = "",
                Params = new Struct(),
                ParamTypes =
                {
                    {
                        "",
                        new gcsv::Type()
                    },
                },
                ResumeToken = ByteString.Empty,
                QueryMode = gcsv::ExecuteSqlRequest.Types.QueryMode.Normal,
                PartitionToken = ByteString.Empty,
                Seqno = 0L,
                QueryOptions = new gcsv::ExecuteSqlRequest.Types.QueryOptions(),
                RequestOptions = new gcsv::RequestOptions(),
                DirectedReadOptions = new gcsv::DirectedReadOptions(),
                DataBoostEnabled = false,
                LastStatement = false,
            };
            // Make the request, returning a streaming response
            using gcsv::SpannerClient.ExecuteStreamingSqlStream response = spannerClient.ExecuteStreamingSql(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcsv::PartialResultSet> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcsv::PartialResultSet responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for ExecuteBatchDml</summary>
        public void ExecuteBatchDmlRequestObject()
        {
            // Snippet: ExecuteBatchDml(ExecuteBatchDmlRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::ExecuteBatchDmlRequest request = new gcsv::ExecuteBatchDmlRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Statements =
                {
                    new gcsv::ExecuteBatchDmlRequest.Types.Statement(),
                },
                Seqno = 0L,
                RequestOptions = new gcsv::RequestOptions(),
                LastStatements = false,
            };
            // Make the request
            gcsv::ExecuteBatchDmlResponse response = spannerClient.ExecuteBatchDml(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteBatchDmlAsync</summary>
        public async Task ExecuteBatchDmlRequestObjectAsync()
        {
            // Snippet: ExecuteBatchDmlAsync(ExecuteBatchDmlRequest, CallSettings)
            // Additional: ExecuteBatchDmlAsync(ExecuteBatchDmlRequest, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::ExecuteBatchDmlRequest request = new gcsv::ExecuteBatchDmlRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Statements =
                {
                    new gcsv::ExecuteBatchDmlRequest.Types.Statement(),
                },
                Seqno = 0L,
                RequestOptions = new gcsv::RequestOptions(),
                LastStatements = false,
            };
            // Make the request
            gcsv::ExecuteBatchDmlResponse response = await spannerClient.ExecuteBatchDmlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Read</summary>
        public void ReadRequestObject()
        {
            // Snippet: Read(ReadRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::ReadRequest request = new gcsv::ReadRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Table = "",
                Index = "",
                Columns = { "", },
                KeySet = new gcsv::KeySet(),
                Limit = 0L,
                ResumeToken = ByteString.Empty,
                PartitionToken = ByteString.Empty,
                RequestOptions = new gcsv::RequestOptions(),
                DirectedReadOptions = new gcsv::DirectedReadOptions(),
                DataBoostEnabled = false,
                OrderBy = gcsv::ReadRequest.Types.OrderBy.Unspecified,
                LockHint = gcsv::ReadRequest.Types.LockHint.Unspecified,
            };
            // Make the request
            gcsv::ResultSet response = spannerClient.Read(request);
            // End snippet
        }

        /// <summary>Snippet for ReadAsync</summary>
        public async Task ReadRequestObjectAsync()
        {
            // Snippet: ReadAsync(ReadRequest, CallSettings)
            // Additional: ReadAsync(ReadRequest, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::ReadRequest request = new gcsv::ReadRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Table = "",
                Index = "",
                Columns = { "", },
                KeySet = new gcsv::KeySet(),
                Limit = 0L,
                ResumeToken = ByteString.Empty,
                PartitionToken = ByteString.Empty,
                RequestOptions = new gcsv::RequestOptions(),
                DirectedReadOptions = new gcsv::DirectedReadOptions(),
                DataBoostEnabled = false,
                OrderBy = gcsv::ReadRequest.Types.OrderBy.Unspecified,
                LockHint = gcsv::ReadRequest.Types.LockHint.Unspecified,
            };
            // Make the request
            gcsv::ResultSet response = await spannerClient.ReadAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StreamingRead</summary>
        public async Task StreamingReadRequestObject()
        {
            // Snippet: StreamingRead(ReadRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::ReadRequest request = new gcsv::ReadRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Table = "",
                Index = "",
                Columns = { "", },
                KeySet = new gcsv::KeySet(),
                Limit = 0L,
                ResumeToken = ByteString.Empty,
                PartitionToken = ByteString.Empty,
                RequestOptions = new gcsv::RequestOptions(),
                DirectedReadOptions = new gcsv::DirectedReadOptions(),
                DataBoostEnabled = false,
                OrderBy = gcsv::ReadRequest.Types.OrderBy.Unspecified,
                LockHint = gcsv::ReadRequest.Types.LockHint.Unspecified,
            };
            // Make the request, returning a streaming response
            using gcsv::SpannerClient.StreamingReadStream response = spannerClient.StreamingRead(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcsv::PartialResultSet> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcsv::PartialResultSet responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for BeginTransaction</summary>
        public void BeginTransactionRequestObject()
        {
            // Snippet: BeginTransaction(BeginTransactionRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::BeginTransactionRequest request = new gcsv::BeginTransactionRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new gcsv::TransactionOptions(),
                RequestOptions = new gcsv::RequestOptions(),
                MutationKey = new gcsv::Mutation(),
            };
            // Make the request
            gcsv::Transaction response = spannerClient.BeginTransaction(request);
            // End snippet
        }

        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionRequestObjectAsync()
        {
            // Snippet: BeginTransactionAsync(BeginTransactionRequest, CallSettings)
            // Additional: BeginTransactionAsync(BeginTransactionRequest, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::BeginTransactionRequest request = new gcsv::BeginTransactionRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Options = new gcsv::TransactionOptions(),
                RequestOptions = new gcsv::RequestOptions(),
                MutationKey = new gcsv::Mutation(),
            };
            // Make the request
            gcsv::Transaction response = await spannerClient.BeginTransactionAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BeginTransaction</summary>
        public void BeginTransaction()
        {
            // Snippet: BeginTransaction(string, TransactionOptions, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            gcsv::TransactionOptions options = new gcsv::TransactionOptions();
            // Make the request
            gcsv::Transaction response = spannerClient.BeginTransaction(session, options);
            // End snippet
        }

        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionAsync()
        {
            // Snippet: BeginTransactionAsync(string, TransactionOptions, CallSettings)
            // Additional: BeginTransactionAsync(string, TransactionOptions, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            gcsv::TransactionOptions options = new gcsv::TransactionOptions();
            // Make the request
            gcsv::Transaction response = await spannerClient.BeginTransactionAsync(session, options);
            // End snippet
        }

        /// <summary>Snippet for BeginTransaction</summary>
        public void BeginTransactionResourceNames()
        {
            // Snippet: BeginTransaction(SessionName, TransactionOptions, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::SessionName session = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            gcsv::TransactionOptions options = new gcsv::TransactionOptions();
            // Make the request
            gcsv::Transaction response = spannerClient.BeginTransaction(session, options);
            // End snippet
        }

        /// <summary>Snippet for BeginTransactionAsync</summary>
        public async Task BeginTransactionResourceNamesAsync()
        {
            // Snippet: BeginTransactionAsync(SessionName, TransactionOptions, CallSettings)
            // Additional: BeginTransactionAsync(SessionName, TransactionOptions, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::SessionName session = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            gcsv::TransactionOptions options = new gcsv::TransactionOptions();
            // Make the request
            gcsv::Transaction response = await spannerClient.BeginTransactionAsync(session, options);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void CommitRequestObject()
        {
            // Snippet: Commit(CommitRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::CommitRequest request = new gcsv::CommitRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.Empty,
                Mutations =
                {
                    new gcsv::Mutation(),
                },
                ReturnCommitStats = false,
                RequestOptions = new gcsv::RequestOptions(),
                MaxCommitDelay = new Duration(),
                PrecommitToken = new gcsv::MultiplexedSessionPrecommitToken(),
            };
            // Make the request
            gcsv::CommitResponse response = spannerClient.Commit(request);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task CommitRequestObjectAsync()
        {
            // Snippet: CommitAsync(CommitRequest, CallSettings)
            // Additional: CommitAsync(CommitRequest, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::CommitRequest request = new gcsv::CommitRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.Empty,
                Mutations =
                {
                    new gcsv::Mutation(),
                },
                ReturnCommitStats = false,
                RequestOptions = new gcsv::RequestOptions(),
                MaxCommitDelay = new Duration(),
                PrecommitToken = new gcsv::MultiplexedSessionPrecommitToken(),
            };
            // Make the request
            gcsv::CommitResponse response = await spannerClient.CommitAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit1()
        {
            // Snippet: Commit(string, ByteString, IEnumerable<Mutation>, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            ByteString transactionId = ByteString.Empty;
            IEnumerable<gcsv::Mutation> mutations = new gcsv::Mutation[]
            {
                new gcsv::Mutation(),
            };
            // Make the request
            gcsv::CommitResponse response = spannerClient.Commit(session, transactionId, mutations);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task Commit1Async()
        {
            // Snippet: CommitAsync(string, ByteString, IEnumerable<Mutation>, CallSettings)
            // Additional: CommitAsync(string, ByteString, IEnumerable<Mutation>, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            ByteString transactionId = ByteString.Empty;
            IEnumerable<gcsv::Mutation> mutations = new gcsv::Mutation[]
            {
                new gcsv::Mutation(),
            };
            // Make the request
            gcsv::CommitResponse response = await spannerClient.CommitAsync(session, transactionId, mutations);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit1ResourceNames()
        {
            // Snippet: Commit(SessionName, ByteString, IEnumerable<Mutation>, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::SessionName session = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.Empty;
            IEnumerable<gcsv::Mutation> mutations = new gcsv::Mutation[]
            {
                new gcsv::Mutation(),
            };
            // Make the request
            gcsv::CommitResponse response = spannerClient.Commit(session, transactionId, mutations);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task Commit1ResourceNamesAsync()
        {
            // Snippet: CommitAsync(SessionName, ByteString, IEnumerable<Mutation>, CallSettings)
            // Additional: CommitAsync(SessionName, ByteString, IEnumerable<Mutation>, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::SessionName session = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.Empty;
            IEnumerable<gcsv::Mutation> mutations = new gcsv::Mutation[]
            {
                new gcsv::Mutation(),
            };
            // Make the request
            gcsv::CommitResponse response = await spannerClient.CommitAsync(session, transactionId, mutations);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit2()
        {
            // Snippet: Commit(string, TransactionOptions, IEnumerable<Mutation>, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            gcsv::TransactionOptions singleUseTransaction = new gcsv::TransactionOptions();
            IEnumerable<gcsv::Mutation> mutations = new gcsv::Mutation[]
            {
                new gcsv::Mutation(),
            };
            // Make the request
            gcsv::CommitResponse response = spannerClient.Commit(session, singleUseTransaction, mutations);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task Commit2Async()
        {
            // Snippet: CommitAsync(string, TransactionOptions, IEnumerable<Mutation>, CallSettings)
            // Additional: CommitAsync(string, TransactionOptions, IEnumerable<Mutation>, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            gcsv::TransactionOptions singleUseTransaction = new gcsv::TransactionOptions();
            IEnumerable<gcsv::Mutation> mutations = new gcsv::Mutation[]
            {
                new gcsv::Mutation(),
            };
            // Make the request
            gcsv::CommitResponse response = await spannerClient.CommitAsync(session, singleUseTransaction, mutations);
            // End snippet
        }

        /// <summary>Snippet for Commit</summary>
        public void Commit2ResourceNames()
        {
            // Snippet: Commit(SessionName, TransactionOptions, IEnumerable<Mutation>, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::SessionName session = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            gcsv::TransactionOptions singleUseTransaction = new gcsv::TransactionOptions();
            IEnumerable<gcsv::Mutation> mutations = new gcsv::Mutation[]
            {
                new gcsv::Mutation(),
            };
            // Make the request
            gcsv::CommitResponse response = spannerClient.Commit(session, singleUseTransaction, mutations);
            // End snippet
        }

        /// <summary>Snippet for CommitAsync</summary>
        public async Task Commit2ResourceNamesAsync()
        {
            // Snippet: CommitAsync(SessionName, TransactionOptions, IEnumerable<Mutation>, CallSettings)
            // Additional: CommitAsync(SessionName, TransactionOptions, IEnumerable<Mutation>, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::SessionName session = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            gcsv::TransactionOptions singleUseTransaction = new gcsv::TransactionOptions();
            IEnumerable<gcsv::Mutation> mutations = new gcsv::Mutation[]
            {
                new gcsv::Mutation(),
            };
            // Make the request
            gcsv::CommitResponse response = await spannerClient.CommitAsync(session, singleUseTransaction, mutations);
            // End snippet
        }

        /// <summary>Snippet for Rollback</summary>
        public void RollbackRequestObject()
        {
            // Snippet: Rollback(RollbackRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::RollbackRequest request = new gcsv::RollbackRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                TransactionId = ByteString.Empty,
            };
            // Make the request
            spannerClient.Rollback(request);
            // End snippet
        }

        /// <summary>Snippet for RollbackAsync</summary>
        public async Task RollbackRequestObjectAsync()
        {
            // Snippet: RollbackAsync(RollbackRequest, CallSettings)
            // Additional: RollbackAsync(RollbackRequest, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::RollbackRequest request = new gcsv::RollbackRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
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
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
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
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            ByteString transactionId = ByteString.Empty;
            // Make the request
            await spannerClient.RollbackAsync(session, transactionId);
            // End snippet
        }

        /// <summary>Snippet for Rollback</summary>
        public void RollbackResourceNames()
        {
            // Snippet: Rollback(SessionName, ByteString, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::SessionName session = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.Empty;
            // Make the request
            spannerClient.Rollback(session, transactionId);
            // End snippet
        }

        /// <summary>Snippet for RollbackAsync</summary>
        public async Task RollbackResourceNamesAsync()
        {
            // Snippet: RollbackAsync(SessionName, ByteString, CallSettings)
            // Additional: RollbackAsync(SessionName, ByteString, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::SessionName session = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            ByteString transactionId = ByteString.Empty;
            // Make the request
            await spannerClient.RollbackAsync(session, transactionId);
            // End snippet
        }

        /// <summary>Snippet for PartitionQuery</summary>
        public void PartitionQueryRequestObject()
        {
            // Snippet: PartitionQuery(PartitionQueryRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::PartitionQueryRequest request = new gcsv::PartitionQueryRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Sql = "",
                Params = new Struct(),
                ParamTypes =
                {
                    {
                        "",
                        new gcsv::Type()
                    },
                },
                PartitionOptions = new gcsv::PartitionOptions(),
            };
            // Make the request
            gcsv::PartitionResponse response = spannerClient.PartitionQuery(request);
            // End snippet
        }

        /// <summary>Snippet for PartitionQueryAsync</summary>
        public async Task PartitionQueryRequestObjectAsync()
        {
            // Snippet: PartitionQueryAsync(PartitionQueryRequest, CallSettings)
            // Additional: PartitionQueryAsync(PartitionQueryRequest, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::PartitionQueryRequest request = new gcsv::PartitionQueryRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Sql = "",
                Params = new Struct(),
                ParamTypes =
                {
                    {
                        "",
                        new gcsv::Type()
                    },
                },
                PartitionOptions = new gcsv::PartitionOptions(),
            };
            // Make the request
            gcsv::PartitionResponse response = await spannerClient.PartitionQueryAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PartitionRead</summary>
        public void PartitionReadRequestObject()
        {
            // Snippet: PartitionRead(PartitionReadRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::PartitionReadRequest request = new gcsv::PartitionReadRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Table = "",
                Index = "",
                Columns = { "", },
                KeySet = new gcsv::KeySet(),
                PartitionOptions = new gcsv::PartitionOptions(),
            };
            // Make the request
            gcsv::PartitionResponse response = spannerClient.PartitionRead(request);
            // End snippet
        }

        /// <summary>Snippet for PartitionReadAsync</summary>
        public async Task PartitionReadRequestObjectAsync()
        {
            // Snippet: PartitionReadAsync(PartitionReadRequest, CallSettings)
            // Additional: PartitionReadAsync(PartitionReadRequest, CancellationToken)
            // Create client
            gcsv::SpannerClient spannerClient = await gcsv::SpannerClient.CreateAsync();
            // Initialize request argument(s)
            gcsv::PartitionReadRequest request = new gcsv::PartitionReadRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                Transaction = new gcsv::TransactionSelector(),
                Table = "",
                Index = "",
                Columns = { "", },
                KeySet = new gcsv::KeySet(),
                PartitionOptions = new gcsv::PartitionOptions(),
            };
            // Make the request
            gcsv::PartitionResponse response = await spannerClient.PartitionReadAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BatchWrite</summary>
        public async Task BatchWriteRequestObject()
        {
            // Snippet: BatchWrite(BatchWriteRequest, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::BatchWriteRequest request = new gcsv::BatchWriteRequest
            {
                SessionAsSessionName = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]"),
                RequestOptions = new gcsv::RequestOptions(),
                MutationGroups =
                {
                    new gcsv::BatchWriteRequest.Types.MutationGroup(),
                },
                ExcludeTxnFromChangeStreams = false,
            };
            // Make the request, returning a streaming response
            using gcsv::SpannerClient.BatchWriteStream response = spannerClient.BatchWrite(request);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcsv::BatchWriteResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcsv::BatchWriteResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for BatchWrite</summary>
        public async Task BatchWrite()
        {
            // Snippet: BatchWrite(string, IEnumerable<BatchWriteRequest.Types.MutationGroup>, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            string session = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]/sessions/[SESSION]";
            IEnumerable<gcsv::BatchWriteRequest.Types.MutationGroup> mutationGroups = new gcsv::BatchWriteRequest.Types.MutationGroup[]
            {
                new gcsv::BatchWriteRequest.Types.MutationGroup(),
            };
            // Make the request, returning a streaming response
            using gcsv::SpannerClient.BatchWriteStream response = spannerClient.BatchWrite(session, mutationGroups);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcsv::BatchWriteResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcsv::BatchWriteResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }

        /// <summary>Snippet for BatchWrite</summary>
        public async Task BatchWriteResourceNames()
        {
            // Snippet: BatchWrite(SessionName, IEnumerable<BatchWriteRequest.Types.MutationGroup>, CallSettings)
            // Create client
            gcsv::SpannerClient spannerClient = gcsv::SpannerClient.Create();
            // Initialize request argument(s)
            gcsv::SessionName session = gcsv::SessionName.FromProjectInstanceDatabaseSession("[PROJECT]", "[INSTANCE]", "[DATABASE]", "[SESSION]");
            IEnumerable<gcsv::BatchWriteRequest.Types.MutationGroup> mutationGroups = new gcsv::BatchWriteRequest.Types.MutationGroup[]
            {
                new gcsv::BatchWriteRequest.Types.MutationGroup(),
            };
            // Make the request, returning a streaming response
            using gcsv::SpannerClient.BatchWriteStream response = spannerClient.BatchWrite(session, mutationGroups);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<gcsv::BatchWriteResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                gcsv::BatchWriteResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
            // End snippet
        }
    }
}
