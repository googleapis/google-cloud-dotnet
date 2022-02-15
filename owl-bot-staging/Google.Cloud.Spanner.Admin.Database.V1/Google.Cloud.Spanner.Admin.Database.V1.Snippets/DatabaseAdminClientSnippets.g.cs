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

namespace Google.Cloud.Spanner.Admin.Database.V1.Snippets
{
    using Google.Api.Gax;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDatabaseAdminClientSnippets
    {
        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabasesRequestObject()
        {
            // Snippet: ListDatabases(ListDatabasesRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            PagedEnumerable<ListDatabasesResponse, Database> response = databaseAdminClient.ListDatabases(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Database item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabasesAsync</summary>
        public async Task ListDatabasesRequestObjectAsync()
        {
            // Snippet: ListDatabasesAsync(ListDatabasesRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListDatabasesRequest request = new ListDatabasesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse, Database> response = databaseAdminClient.ListDatabasesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Database item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabases()
        {
            // Snippet: ListDatabases(string, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListDatabasesResponse, Database> response = databaseAdminClient.ListDatabases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Database item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabasesAsync</summary>
        public async Task ListDatabasesAsync()
        {
            // Snippet: ListDatabasesAsync(string, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse, Database> response = databaseAdminClient.ListDatabasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Database item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabases</summary>
        public void ListDatabasesResourceNames()
        {
            // Snippet: ListDatabases(InstanceName, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListDatabasesResponse, Database> response = databaseAdminClient.ListDatabases(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Database item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabasesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabasesAsync</summary>
        public async Task ListDatabasesResourceNamesAsync()
        {
            // Snippet: ListDatabasesAsync(InstanceName, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListDatabasesResponse, Database> response = databaseAdminClient.ListDatabasesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Database item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabasesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Database item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Database> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Database item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateDatabase</summary>
        public void CreateDatabaseRequestObject()
        {
            // Snippet: CreateDatabase(CreateDatabaseRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            CreateDatabaseRequest request = new CreateDatabaseRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                CreateStatement = "",
                ExtraStatements = { "", },
                EncryptionConfig = new EncryptionConfig(),
                DatabaseDialect = DatabaseDialect.Unspecified,
            };
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = databaseAdminClient.CreateDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = databaseAdminClient.PollOnceCreateDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatabaseAsync</summary>
        public async Task CreateDatabaseRequestObjectAsync()
        {
            // Snippet: CreateDatabaseAsync(CreateDatabaseRequest, CallSettings)
            // Additional: CreateDatabaseAsync(CreateDatabaseRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateDatabaseRequest request = new CreateDatabaseRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                CreateStatement = "",
                ExtraStatements = { "", },
                EncryptionConfig = new EncryptionConfig(),
                DatabaseDialect = DatabaseDialect.Unspecified,
            };
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = await databaseAdminClient.CreateDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = await databaseAdminClient.PollOnceCreateDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatabase</summary>
        public void CreateDatabase()
        {
            // Snippet: CreateDatabase(string, string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string createStatement = "";
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = databaseAdminClient.CreateDatabase(parent, createStatement);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = databaseAdminClient.PollOnceCreateDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatabaseAsync</summary>
        public async Task CreateDatabaseAsync()
        {
            // Snippet: CreateDatabaseAsync(string, string, CallSettings)
            // Additional: CreateDatabaseAsync(string, string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string createStatement = "";
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = await databaseAdminClient.CreateDatabaseAsync(parent, createStatement);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = await databaseAdminClient.PollOnceCreateDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatabase</summary>
        public void CreateDatabaseResourceNames()
        {
            // Snippet: CreateDatabase(InstanceName, string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string createStatement = "";
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = databaseAdminClient.CreateDatabase(parent, createStatement);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = databaseAdminClient.PollOnceCreateDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateDatabaseAsync</summary>
        public async Task CreateDatabaseResourceNamesAsync()
        {
            // Snippet: CreateDatabaseAsync(InstanceName, string, CallSettings)
            // Additional: CreateDatabaseAsync(InstanceName, string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string createStatement = "";
            // Make the request
            Operation<Database, CreateDatabaseMetadata> response = await databaseAdminClient.CreateDatabaseAsync(parent, createStatement);

            // Poll until the returned long-running operation is complete
            Operation<Database, CreateDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, CreateDatabaseMetadata> retrievedResponse = await databaseAdminClient.PollOnceCreateDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetDatabase</summary>
        public void GetDatabaseRequestObject()
        {
            // Snippet: GetDatabase(GetDatabaseRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            Database response = databaseAdminClient.GetDatabase(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseAsync</summary>
        public async Task GetDatabaseRequestObjectAsync()
        {
            // Snippet: GetDatabaseAsync(GetDatabaseRequest, CallSettings)
            // Additional: GetDatabaseAsync(GetDatabaseRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetDatabaseRequest request = new GetDatabaseRequest
            {
                DatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            Database response = await databaseAdminClient.GetDatabaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatabase</summary>
        public void GetDatabase()
        {
            // Snippet: GetDatabase(string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            Database response = databaseAdminClient.GetDatabase(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseAsync</summary>
        public async Task GetDatabaseAsync()
        {
            // Snippet: GetDatabaseAsync(string, CallSettings)
            // Additional: GetDatabaseAsync(string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            Database response = await databaseAdminClient.GetDatabaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatabase</summary>
        public void GetDatabaseResourceNames()
        {
            // Snippet: GetDatabase(DatabaseName, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName name = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            Database response = databaseAdminClient.GetDatabase(name);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseAsync</summary>
        public async Task GetDatabaseResourceNamesAsync()
        {
            // Snippet: GetDatabaseAsync(DatabaseName, CallSettings)
            // Additional: GetDatabaseAsync(DatabaseName, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName name = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            Database response = await databaseAdminClient.GetDatabaseAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseDdl</summary>
        public void UpdateDatabaseDdlRequestObject()
        {
            // Snippet: UpdateDatabaseDdl(UpdateDatabaseDdlRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            UpdateDatabaseDdlRequest request = new UpdateDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Statements = { "", },
                OperationId = "",
            };
            // Make the request
            Operation<Empty, UpdateDatabaseDdlMetadata> response = databaseAdminClient.UpdateDatabaseDdl(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UpdateDatabaseDdlMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UpdateDatabaseDdlMetadata> retrievedResponse = databaseAdminClient.PollOnceUpdateDatabaseDdl(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseDdlAsync</summary>
        public async Task UpdateDatabaseDdlRequestObjectAsync()
        {
            // Snippet: UpdateDatabaseDdlAsync(UpdateDatabaseDdlRequest, CallSettings)
            // Additional: UpdateDatabaseDdlAsync(UpdateDatabaseDdlRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDatabaseDdlRequest request = new UpdateDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
                Statements = { "", },
                OperationId = "",
            };
            // Make the request
            Operation<Empty, UpdateDatabaseDdlMetadata> response = await databaseAdminClient.UpdateDatabaseDdlAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UpdateDatabaseDdlMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UpdateDatabaseDdlMetadata> retrievedResponse = await databaseAdminClient.PollOnceUpdateDatabaseDdlAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseDdl</summary>
        public void UpdateDatabaseDdl()
        {
            // Snippet: UpdateDatabaseDdl(string, IEnumerable<string>, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            IEnumerable<string> statements = new string[] { "", };
            // Make the request
            Operation<Empty, UpdateDatabaseDdlMetadata> response = databaseAdminClient.UpdateDatabaseDdl(database, statements);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UpdateDatabaseDdlMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UpdateDatabaseDdlMetadata> retrievedResponse = databaseAdminClient.PollOnceUpdateDatabaseDdl(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseDdlAsync</summary>
        public async Task UpdateDatabaseDdlAsync()
        {
            // Snippet: UpdateDatabaseDdlAsync(string, IEnumerable<string>, CallSettings)
            // Additional: UpdateDatabaseDdlAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            IEnumerable<string> statements = new string[] { "", };
            // Make the request
            Operation<Empty, UpdateDatabaseDdlMetadata> response = await databaseAdminClient.UpdateDatabaseDdlAsync(database, statements);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UpdateDatabaseDdlMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UpdateDatabaseDdlMetadata> retrievedResponse = await databaseAdminClient.PollOnceUpdateDatabaseDdlAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseDdl</summary>
        public void UpdateDatabaseDdlResourceNames()
        {
            // Snippet: UpdateDatabaseDdl(DatabaseName, IEnumerable<string>, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            IEnumerable<string> statements = new string[] { "", };
            // Make the request
            Operation<Empty, UpdateDatabaseDdlMetadata> response = databaseAdminClient.UpdateDatabaseDdl(database, statements);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UpdateDatabaseDdlMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UpdateDatabaseDdlMetadata> retrievedResponse = databaseAdminClient.PollOnceUpdateDatabaseDdl(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateDatabaseDdlAsync</summary>
        public async Task UpdateDatabaseDdlResourceNamesAsync()
        {
            // Snippet: UpdateDatabaseDdlAsync(DatabaseName, IEnumerable<string>, CallSettings)
            // Additional: UpdateDatabaseDdlAsync(DatabaseName, IEnumerable<string>, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            IEnumerable<string> statements = new string[] { "", };
            // Make the request
            Operation<Empty, UpdateDatabaseDdlMetadata> response = await databaseAdminClient.UpdateDatabaseDdlAsync(database, statements);

            // Poll until the returned long-running operation is complete
            Operation<Empty, UpdateDatabaseDdlMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, UpdateDatabaseDdlMetadata> retrievedResponse = await databaseAdminClient.PollOnceUpdateDatabaseDdlAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DropDatabase</summary>
        public void DropDatabaseRequestObject()
        {
            // Snippet: DropDatabase(DropDatabaseRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            databaseAdminClient.DropDatabase(request);
            // End snippet
        }

        /// <summary>Snippet for DropDatabaseAsync</summary>
        public async Task DropDatabaseRequestObjectAsync()
        {
            // Snippet: DropDatabaseAsync(DropDatabaseRequest, CallSettings)
            // Additional: DropDatabaseAsync(DropDatabaseRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            DropDatabaseRequest request = new DropDatabaseRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            await databaseAdminClient.DropDatabaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DropDatabase</summary>
        public void DropDatabase()
        {
            // Snippet: DropDatabase(string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            databaseAdminClient.DropDatabase(database);
            // End snippet
        }

        /// <summary>Snippet for DropDatabaseAsync</summary>
        public async Task DropDatabaseAsync()
        {
            // Snippet: DropDatabaseAsync(string, CallSettings)
            // Additional: DropDatabaseAsync(string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            await databaseAdminClient.DropDatabaseAsync(database);
            // End snippet
        }

        /// <summary>Snippet for DropDatabase</summary>
        public void DropDatabaseResourceNames()
        {
            // Snippet: DropDatabase(DatabaseName, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            databaseAdminClient.DropDatabase(database);
            // End snippet
        }

        /// <summary>Snippet for DropDatabaseAsync</summary>
        public async Task DropDatabaseResourceNamesAsync()
        {
            // Snippet: DropDatabaseAsync(DatabaseName, CallSettings)
            // Additional: DropDatabaseAsync(DatabaseName, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            await databaseAdminClient.DropDatabaseAsync(database);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseDdl</summary>
        public void GetDatabaseDdlRequestObject()
        {
            // Snippet: GetDatabaseDdl(GetDatabaseDdlRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            GetDatabaseDdlResponse response = databaseAdminClient.GetDatabaseDdl(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseDdlAsync</summary>
        public async Task GetDatabaseDdlRequestObjectAsync()
        {
            // Snippet: GetDatabaseDdlAsync(GetDatabaseDdlRequest, CallSettings)
            // Additional: GetDatabaseDdlAsync(GetDatabaseDdlRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetDatabaseDdlRequest request = new GetDatabaseDdlRequest
            {
                DatabaseAsDatabaseName = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]"),
            };
            // Make the request
            GetDatabaseDdlResponse response = await databaseAdminClient.GetDatabaseDdlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseDdl</summary>
        public void GetDatabaseDdl()
        {
            // Snippet: GetDatabaseDdl(string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            GetDatabaseDdlResponse response = databaseAdminClient.GetDatabaseDdl(database);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseDdlAsync</summary>
        public async Task GetDatabaseDdlAsync()
        {
            // Snippet: GetDatabaseDdlAsync(string, CallSettings)
            // Additional: GetDatabaseDdlAsync(string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string database = "projects/[PROJECT]/instances/[INSTANCE]/databases/[DATABASE]";
            // Make the request
            GetDatabaseDdlResponse response = await databaseAdminClient.GetDatabaseDdlAsync(database);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseDdl</summary>
        public void GetDatabaseDdlResourceNames()
        {
            // Snippet: GetDatabaseDdl(DatabaseName, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            GetDatabaseDdlResponse response = databaseAdminClient.GetDatabaseDdl(database);
            // End snippet
        }

        /// <summary>Snippet for GetDatabaseDdlAsync</summary>
        public async Task GetDatabaseDdlResourceNamesAsync()
        {
            // Snippet: GetDatabaseDdlAsync(DatabaseName, CallSettings)
            // Additional: GetDatabaseDdlAsync(DatabaseName, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            DatabaseName database = DatabaseName.FromProjectInstanceDatabase("[PROJECT]", "[INSTANCE]", "[DATABASE]");
            // Make the request
            GetDatabaseDdlResponse response = await databaseAdminClient.GetDatabaseDdlAsync(database);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = databaseAdminClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await databaseAdminClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = databaseAdminClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await databaseAdminClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = databaseAdminClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await databaseAdminClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = databaseAdminClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await databaseAdminClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = databaseAdminClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await databaseAdminClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = databaseAdminClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await databaseAdminClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = databaseAdminClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await databaseAdminClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = databaseAdminClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await databaseAdminClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = databaseAdminClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await databaseAdminClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackupRequestObject()
        {
            // Snippet: CreateBackup(CreateBackupRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            CreateBackupRequest request = new CreateBackupRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                BackupId = "",
                Backup = new Backup(),
                EncryptionConfig = new CreateBackupEncryptionConfig(),
            };
            // Make the request
            Operation<Backup, CreateBackupMetadata> response = databaseAdminClient.CreateBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CreateBackupMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CreateBackupMetadata> retrievedResponse = databaseAdminClient.PollOnceCreateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupAsync</summary>
        public async Task CreateBackupRequestObjectAsync()
        {
            // Snippet: CreateBackupAsync(CreateBackupRequest, CallSettings)
            // Additional: CreateBackupAsync(CreateBackupRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackupRequest request = new CreateBackupRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                BackupId = "",
                Backup = new Backup(),
                EncryptionConfig = new CreateBackupEncryptionConfig(),
            };
            // Make the request
            Operation<Backup, CreateBackupMetadata> response = await databaseAdminClient.CreateBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CreateBackupMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CreateBackupMetadata> retrievedResponse = await databaseAdminClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackup()
        {
            // Snippet: CreateBackup(string, Backup, string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, CreateBackupMetadata> response = databaseAdminClient.CreateBackup(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CreateBackupMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CreateBackupMetadata> retrievedResponse = databaseAdminClient.PollOnceCreateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupAsync</summary>
        public async Task CreateBackupAsync()
        {
            // Snippet: CreateBackupAsync(string, Backup, string, CallSettings)
            // Additional: CreateBackupAsync(string, Backup, string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, CreateBackupMetadata> response = await databaseAdminClient.CreateBackupAsync(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CreateBackupMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CreateBackupMetadata> retrievedResponse = await databaseAdminClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackupResourceNames()
        {
            // Snippet: CreateBackup(InstanceName, Backup, string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, CreateBackupMetadata> response = databaseAdminClient.CreateBackup(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CreateBackupMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CreateBackupMetadata> retrievedResponse = databaseAdminClient.PollOnceCreateBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateBackupAsync</summary>
        public async Task CreateBackupResourceNamesAsync()
        {
            // Snippet: CreateBackupAsync(InstanceName, Backup, string, CallSettings)
            // Additional: CreateBackupAsync(InstanceName, Backup, string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            Backup backup = new Backup();
            string backupId = "";
            // Make the request
            Operation<Backup, CreateBackupMetadata> response = await databaseAdminClient.CreateBackupAsync(parent, backup, backupId);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CreateBackupMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CreateBackupMetadata> retrievedResponse = await databaseAdminClient.PollOnceCreateBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupRequestObject()
        {
            // Snippet: GetBackup(GetBackupRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            // Make the request
            Backup response = databaseAdminClient.GetBackup(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupRequestObjectAsync()
        {
            // Snippet: GetBackupAsync(GetBackupRequest, CallSettings)
            // Additional: GetBackupAsync(GetBackupRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            // Make the request
            Backup response = await databaseAdminClient.GetBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackup()
        {
            // Snippet: GetBackup(string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/backups/[BACKUP]";
            // Make the request
            Backup response = databaseAdminClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupAsync()
        {
            // Snippet: GetBackupAsync(string, CallSettings)
            // Additional: GetBackupAsync(string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/backups/[BACKUP]";
            // Make the request
            Backup response = await databaseAdminClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupResourceNames()
        {
            // Snippet: GetBackup(BackupName, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]");
            // Make the request
            Backup response = databaseAdminClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupResourceNamesAsync()
        {
            // Snippet: GetBackupAsync(BackupName, CallSettings)
            // Additional: GetBackupAsync(BackupName, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]");
            // Make the request
            Backup response = await databaseAdminClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBackup</summary>
        public void UpdateBackupRequestObject()
        {
            // Snippet: UpdateBackup(UpdateBackupRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Backup response = databaseAdminClient.UpdateBackup(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupAsync</summary>
        public async Task UpdateBackupRequestObjectAsync()
        {
            // Snippet: UpdateBackupAsync(UpdateBackupRequest, CallSettings)
            // Additional: UpdateBackupAsync(UpdateBackupRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Backup response = await databaseAdminClient.UpdateBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBackup</summary>
        public void UpdateBackup()
        {
            // Snippet: UpdateBackup(Backup, FieldMask, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Backup response = databaseAdminClient.UpdateBackup(backup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupAsync</summary>
        public async Task UpdateBackupAsync()
        {
            // Snippet: UpdateBackupAsync(Backup, FieldMask, CallSettings)
            // Additional: UpdateBackupAsync(Backup, FieldMask, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Backup response = await databaseAdminClient.UpdateBackupAsync(backup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackupRequestObject()
        {
            // Snippet: DeleteBackup(DeleteBackupRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            // Make the request
            databaseAdminClient.DeleteBackup(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupRequestObjectAsync()
        {
            // Snippet: DeleteBackupAsync(DeleteBackupRequest, CallSettings)
            // Additional: DeleteBackupAsync(DeleteBackupRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
            };
            // Make the request
            await databaseAdminClient.DeleteBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackup()
        {
            // Snippet: DeleteBackup(string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/backups/[BACKUP]";
            // Make the request
            databaseAdminClient.DeleteBackup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupAsync()
        {
            // Snippet: DeleteBackupAsync(string, CallSettings)
            // Additional: DeleteBackupAsync(string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/backups/[BACKUP]";
            // Make the request
            await databaseAdminClient.DeleteBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackupResourceNames()
        {
            // Snippet: DeleteBackup(BackupName, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]");
            // Make the request
            databaseAdminClient.DeleteBackup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupResourceNamesAsync()
        {
            // Snippet: DeleteBackupAsync(BackupName, CallSettings)
            // Additional: DeleteBackupAsync(BackupName, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]");
            // Make the request
            await databaseAdminClient.DeleteBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackupsRequestObject()
        {
            // Snippet: ListBackups(ListBackupsRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = databaseAdminClient.ListBackups(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupsAsync</summary>
        public async Task ListBackupsRequestObjectAsync()
        {
            // Snippet: ListBackupsAsync(ListBackupsRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = databaseAdminClient.ListBackupsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Backup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackups()
        {
            // Snippet: ListBackups(string, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = databaseAdminClient.ListBackups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupsAsync</summary>
        public async Task ListBackupsAsync()
        {
            // Snippet: ListBackupsAsync(string, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = databaseAdminClient.ListBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Backup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackupsResourceNames()
        {
            // Snippet: ListBackups(InstanceName, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = databaseAdminClient.ListBackups(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Backup item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupsAsync</summary>
        public async Task ListBackupsResourceNamesAsync()
        {
            // Snippet: ListBackupsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = databaseAdminClient.ListBackupsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Backup item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Backup item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Backup> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Backup item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for RestoreDatabase</summary>
        public void RestoreDatabaseRequestObject()
        {
            // Snippet: RestoreDatabase(RestoreDatabaseRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            RestoreDatabaseRequest request = new RestoreDatabaseRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DatabaseId = "",
                BackupAsBackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                EncryptionConfig = new RestoreDatabaseEncryptionConfig(),
            };
            // Make the request
            Operation<Database, RestoreDatabaseMetadata> response = databaseAdminClient.RestoreDatabase(request);

            // Poll until the returned long-running operation is complete
            Operation<Database, RestoreDatabaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, RestoreDatabaseMetadata> retrievedResponse = databaseAdminClient.PollOnceRestoreDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreDatabaseAsync</summary>
        public async Task RestoreDatabaseRequestObjectAsync()
        {
            // Snippet: RestoreDatabaseAsync(RestoreDatabaseRequest, CallSettings)
            // Additional: RestoreDatabaseAsync(RestoreDatabaseRequest, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            RestoreDatabaseRequest request = new RestoreDatabaseRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                DatabaseId = "",
                BackupAsBackupName = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]"),
                EncryptionConfig = new RestoreDatabaseEncryptionConfig(),
            };
            // Make the request
            Operation<Database, RestoreDatabaseMetadata> response = await databaseAdminClient.RestoreDatabaseAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Database, RestoreDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, RestoreDatabaseMetadata> retrievedResponse = await databaseAdminClient.PollOnceRestoreDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreDatabase</summary>
        public void RestoreDatabase()
        {
            // Snippet: RestoreDatabase(string, string, string, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string databaseId = "";
            string backup = "projects/[PROJECT]/instances/[INSTANCE]/backups/[BACKUP]";
            // Make the request
            Operation<Database, RestoreDatabaseMetadata> response = databaseAdminClient.RestoreDatabase(parent, databaseId, backup);

            // Poll until the returned long-running operation is complete
            Operation<Database, RestoreDatabaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, RestoreDatabaseMetadata> retrievedResponse = databaseAdminClient.PollOnceRestoreDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreDatabaseAsync</summary>
        public async Task RestoreDatabaseAsync()
        {
            // Snippet: RestoreDatabaseAsync(string, string, string, CallSettings)
            // Additional: RestoreDatabaseAsync(string, string, string, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string databaseId = "";
            string backup = "projects/[PROJECT]/instances/[INSTANCE]/backups/[BACKUP]";
            // Make the request
            Operation<Database, RestoreDatabaseMetadata> response = await databaseAdminClient.RestoreDatabaseAsync(parent, databaseId, backup);

            // Poll until the returned long-running operation is complete
            Operation<Database, RestoreDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, RestoreDatabaseMetadata> retrievedResponse = await databaseAdminClient.PollOnceRestoreDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreDatabase</summary>
        public void RestoreDatabaseResourceNames()
        {
            // Snippet: RestoreDatabase(InstanceName, string, BackupName, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string databaseId = "";
            BackupName backup = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]");
            // Make the request
            Operation<Database, RestoreDatabaseMetadata> response = databaseAdminClient.RestoreDatabase(parent, databaseId, backup);

            // Poll until the returned long-running operation is complete
            Operation<Database, RestoreDatabaseMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, RestoreDatabaseMetadata> retrievedResponse = databaseAdminClient.PollOnceRestoreDatabase(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreDatabaseAsync</summary>
        public async Task RestoreDatabaseResourceNamesAsync()
        {
            // Snippet: RestoreDatabaseAsync(InstanceName, string, BackupName, CallSettings)
            // Additional: RestoreDatabaseAsync(InstanceName, string, BackupName, CancellationToken)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string databaseId = "";
            BackupName backup = BackupName.FromProjectInstanceBackup("[PROJECT]", "[INSTANCE]", "[BACKUP]");
            // Make the request
            Operation<Database, RestoreDatabaseMetadata> response = await databaseAdminClient.RestoreDatabaseAsync(parent, databaseId, backup);

            // Poll until the returned long-running operation is complete
            Operation<Database, RestoreDatabaseMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Database result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Database, RestoreDatabaseMetadata> retrievedResponse = await databaseAdminClient.PollOnceRestoreDatabaseAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Database retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListDatabaseOperations</summary>
        public void ListDatabaseOperationsRequestObject()
        {
            // Snippet: ListDatabaseOperations(ListDatabaseOperationsRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            ListDatabaseOperationsRequest request = new ListDatabaseOperationsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDatabaseOperationsResponse, Operation> response = databaseAdminClient.ListDatabaseOperations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabaseOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabaseOperationsAsync</summary>
        public async Task ListDatabaseOperationsRequestObjectAsync()
        {
            // Snippet: ListDatabaseOperationsAsync(ListDatabaseOperationsRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListDatabaseOperationsRequest request = new ListDatabaseOperationsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDatabaseOperationsResponse, Operation> response = databaseAdminClient.ListDatabaseOperationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabaseOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabaseOperations</summary>
        public void ListDatabaseOperations()
        {
            // Snippet: ListDatabaseOperations(string, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListDatabaseOperationsResponse, Operation> response = databaseAdminClient.ListDatabaseOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabaseOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabaseOperationsAsync</summary>
        public async Task ListDatabaseOperationsAsync()
        {
            // Snippet: ListDatabaseOperationsAsync(string, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListDatabaseOperationsResponse, Operation> response = databaseAdminClient.ListDatabaseOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabaseOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabaseOperations</summary>
        public void ListDatabaseOperationsResourceNames()
        {
            // Snippet: ListDatabaseOperations(InstanceName, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListDatabaseOperationsResponse, Operation> response = databaseAdminClient.ListDatabaseOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDatabaseOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDatabaseOperationsAsync</summary>
        public async Task ListDatabaseOperationsResourceNamesAsync()
        {
            // Snippet: ListDatabaseOperationsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListDatabaseOperationsResponse, Operation> response = databaseAdminClient.ListDatabaseOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListDatabaseOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupOperations</summary>
        public void ListBackupOperationsRequestObject()
        {
            // Snippet: ListBackupOperations(ListBackupOperationsRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            ListBackupOperationsRequest request = new ListBackupOperationsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListBackupOperationsResponse, Operation> response = databaseAdminClient.ListBackupOperations(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupOperationsAsync</summary>
        public async Task ListBackupOperationsRequestObjectAsync()
        {
            // Snippet: ListBackupOperationsAsync(ListBackupOperationsRequest, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupOperationsRequest request = new ListBackupOperationsRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupOperationsResponse, Operation> response = databaseAdminClient.ListBackupOperationsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupOperations</summary>
        public void ListBackupOperations()
        {
            // Snippet: ListBackupOperations(string, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListBackupOperationsResponse, Operation> response = databaseAdminClient.ListBackupOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupOperationsAsync</summary>
        public async Task ListBackupOperationsAsync()
        {
            // Snippet: ListBackupOperationsAsync(string, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListBackupOperationsResponse, Operation> response = databaseAdminClient.ListBackupOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupOperations</summary>
        public void ListBackupOperationsResourceNames()
        {
            // Snippet: ListBackupOperations(InstanceName, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = DatabaseAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListBackupOperationsResponse, Operation> response = databaseAdminClient.ListBackupOperations(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Operation item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListBackupOperationsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListBackupOperationsAsync</summary>
        public async Task ListBackupOperationsResourceNamesAsync()
        {
            // Snippet: ListBackupOperationsAsync(InstanceName, string, int?, CallSettings)
            // Create client
            DatabaseAdminClient databaseAdminClient = await DatabaseAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListBackupOperationsResponse, Operation> response = databaseAdminClient.ListBackupOperationsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Operation item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListBackupOperationsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Operation item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Operation> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Operation item in singlePage)
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
