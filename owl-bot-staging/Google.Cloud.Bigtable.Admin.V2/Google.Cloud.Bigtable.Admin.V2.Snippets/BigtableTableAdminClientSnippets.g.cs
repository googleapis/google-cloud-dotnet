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
    using Google.Cloud.Bigtable.Admin.V2;
    using Google.Cloud.Iam.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedBigtableTableAdminClientSnippets
    {
        /// <summary>Snippet for CreateTable</summary>
        public void CreateTableRequestObject()
        {
            // Snippet: CreateTable(CreateTableRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            CreateTableRequest request = new CreateTableRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TableId = "",
                Table = new Table(),
                InitialSplits =
                {
                    new CreateTableRequest.Types.Split(),
                },
            };
            // Make the request
            Table response = bigtableTableAdminClient.CreateTable(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTableAsync</summary>
        public async Task CreateTableRequestObjectAsync()
        {
            // Snippet: CreateTableAsync(CreateTableRequest, CallSettings)
            // Additional: CreateTableAsync(CreateTableRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateTableRequest request = new CreateTableRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TableId = "",
                Table = new Table(),
                InitialSplits =
                {
                    new CreateTableRequest.Types.Split(),
                },
            };
            // Make the request
            Table response = await bigtableTableAdminClient.CreateTableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTable</summary>
        public void CreateTable()
        {
            // Snippet: CreateTable(string, string, Table, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string tableId = "";
            Table table = new Table();
            // Make the request
            Table response = bigtableTableAdminClient.CreateTable(parent, tableId, table);
            // End snippet
        }

        /// <summary>Snippet for CreateTableAsync</summary>
        public async Task CreateTableAsync()
        {
            // Snippet: CreateTableAsync(string, string, Table, CallSettings)
            // Additional: CreateTableAsync(string, string, Table, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string tableId = "";
            Table table = new Table();
            // Make the request
            Table response = await bigtableTableAdminClient.CreateTableAsync(parent, tableId, table);
            // End snippet
        }

        /// <summary>Snippet for CreateTable</summary>
        public void CreateTableResourceNames()
        {
            // Snippet: CreateTable(InstanceName, string, Table, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string tableId = "";
            Table table = new Table();
            // Make the request
            Table response = bigtableTableAdminClient.CreateTable(parent, tableId, table);
            // End snippet
        }

        /// <summary>Snippet for CreateTableAsync</summary>
        public async Task CreateTableResourceNamesAsync()
        {
            // Snippet: CreateTableAsync(InstanceName, string, Table, CallSettings)
            // Additional: CreateTableAsync(InstanceName, string, Table, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string tableId = "";
            Table table = new Table();
            // Make the request
            Table response = await bigtableTableAdminClient.CreateTableAsync(parent, tableId, table);
            // End snippet
        }

        /// <summary>Snippet for CreateTableFromSnapshot</summary>
        public void CreateTableFromSnapshotRequestObject()
        {
            // Snippet: CreateTableFromSnapshot(CreateTableFromSnapshotRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            CreateTableFromSnapshotRequest request = new CreateTableFromSnapshotRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TableId = "",
                SourceSnapshotAsSnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            // Make the request
            Operation<Table, CreateTableFromSnapshotMetadata> response = bigtableTableAdminClient.CreateTableFromSnapshot(request);

            // Poll until the returned long-running operation is complete
            Operation<Table, CreateTableFromSnapshotMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, CreateTableFromSnapshotMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceCreateTableFromSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTableFromSnapshotAsync</summary>
        public async Task CreateTableFromSnapshotRequestObjectAsync()
        {
            // Snippet: CreateTableFromSnapshotAsync(CreateTableFromSnapshotRequest, CallSettings)
            // Additional: CreateTableFromSnapshotAsync(CreateTableFromSnapshotRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateTableFromSnapshotRequest request = new CreateTableFromSnapshotRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TableId = "",
                SourceSnapshotAsSnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            // Make the request
            Operation<Table, CreateTableFromSnapshotMetadata> response = await bigtableTableAdminClient.CreateTableFromSnapshotAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Table, CreateTableFromSnapshotMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, CreateTableFromSnapshotMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceCreateTableFromSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTableFromSnapshot</summary>
        public void CreateTableFromSnapshot()
        {
            // Snippet: CreateTableFromSnapshot(string, string, string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string tableId = "";
            string sourceSnapshot = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]/snapshots/[SNAPSHOT]";
            // Make the request
            Operation<Table, CreateTableFromSnapshotMetadata> response = bigtableTableAdminClient.CreateTableFromSnapshot(parent, tableId, sourceSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<Table, CreateTableFromSnapshotMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, CreateTableFromSnapshotMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceCreateTableFromSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTableFromSnapshotAsync</summary>
        public async Task CreateTableFromSnapshotAsync()
        {
            // Snippet: CreateTableFromSnapshotAsync(string, string, string, CallSettings)
            // Additional: CreateTableFromSnapshotAsync(string, string, string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            string tableId = "";
            string sourceSnapshot = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]/snapshots/[SNAPSHOT]";
            // Make the request
            Operation<Table, CreateTableFromSnapshotMetadata> response = await bigtableTableAdminClient.CreateTableFromSnapshotAsync(parent, tableId, sourceSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<Table, CreateTableFromSnapshotMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, CreateTableFromSnapshotMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceCreateTableFromSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTableFromSnapshot</summary>
        public void CreateTableFromSnapshotResourceNames()
        {
            // Snippet: CreateTableFromSnapshot(InstanceName, string, SnapshotName, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string tableId = "";
            SnapshotName sourceSnapshot = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            // Make the request
            Operation<Table, CreateTableFromSnapshotMetadata> response = bigtableTableAdminClient.CreateTableFromSnapshot(parent, tableId, sourceSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<Table, CreateTableFromSnapshotMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, CreateTableFromSnapshotMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceCreateTableFromSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTableFromSnapshotAsync</summary>
        public async Task CreateTableFromSnapshotResourceNamesAsync()
        {
            // Snippet: CreateTableFromSnapshotAsync(InstanceName, string, SnapshotName, CallSettings)
            // Additional: CreateTableFromSnapshotAsync(InstanceName, string, SnapshotName, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            string tableId = "";
            SnapshotName sourceSnapshot = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            // Make the request
            Operation<Table, CreateTableFromSnapshotMetadata> response = await bigtableTableAdminClient.CreateTableFromSnapshotAsync(parent, tableId, sourceSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<Table, CreateTableFromSnapshotMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, CreateTableFromSnapshotMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceCreateTableFromSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTables</summary>
        public void ListTablesRequestObject()
        {
            // Snippet: ListTables(ListTablesRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ListTablesRequest request = new ListTablesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                View = Table.Types.View.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListTablesResponse, Table> response = bigtableTableAdminClient.ListTables(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Table item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTablesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Table item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Table> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Table item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTablesAsync</summary>
        public async Task ListTablesRequestObjectAsync()
        {
            // Snippet: ListTablesAsync(ListTablesRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListTablesRequest request = new ListTablesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                View = Table.Types.View.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListTablesResponse, Table> response = bigtableTableAdminClient.ListTablesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Table item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTablesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Table item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Table> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Table item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTables</summary>
        public void ListTables()
        {
            // Snippet: ListTables(string, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListTablesResponse, Table> response = bigtableTableAdminClient.ListTables(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Table item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTablesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Table item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Table> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Table item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTablesAsync</summary>
        public async Task ListTablesAsync()
        {
            // Snippet: ListTablesAsync(string, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListTablesResponse, Table> response = bigtableTableAdminClient.ListTablesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Table item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTablesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Table item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Table> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Table item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTables</summary>
        public void ListTablesResourceNames()
        {
            // Snippet: ListTables(InstanceName, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListTablesResponse, Table> response = bigtableTableAdminClient.ListTables(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Table item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListTablesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Table item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Table> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Table item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTablesAsync</summary>
        public async Task ListTablesResourceNamesAsync()
        {
            // Snippet: ListTablesAsync(InstanceName, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListTablesResponse, Table> response = bigtableTableAdminClient.ListTablesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Table item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListTablesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Table item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Table> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Table item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTable</summary>
        public void GetTableRequestObject()
        {
            // Snippet: GetTable(GetTableRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            GetTableRequest request = new GetTableRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                View = Table.Types.View.Unspecified,
            };
            // Make the request
            Table response = bigtableTableAdminClient.GetTable(request);
            // End snippet
        }

        /// <summary>Snippet for GetTableAsync</summary>
        public async Task GetTableRequestObjectAsync()
        {
            // Snippet: GetTableAsync(GetTableRequest, CallSettings)
            // Additional: GetTableAsync(GetTableRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetTableRequest request = new GetTableRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                View = Table.Types.View.Unspecified,
            };
            // Make the request
            Table response = await bigtableTableAdminClient.GetTableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTable</summary>
        public void GetTable()
        {
            // Snippet: GetTable(string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request
            Table response = bigtableTableAdminClient.GetTable(name);
            // End snippet
        }

        /// <summary>Snippet for GetTableAsync</summary>
        public async Task GetTableAsync()
        {
            // Snippet: GetTableAsync(string, CallSettings)
            // Additional: GetTableAsync(string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request
            Table response = await bigtableTableAdminClient.GetTableAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTable</summary>
        public void GetTableResourceNames()
        {
            // Snippet: GetTable(TableName, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            Table response = bigtableTableAdminClient.GetTable(name);
            // End snippet
        }

        /// <summary>Snippet for GetTableAsync</summary>
        public async Task GetTableResourceNamesAsync()
        {
            // Snippet: GetTableAsync(TableName, CallSettings)
            // Additional: GetTableAsync(TableName, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            Table response = await bigtableTableAdminClient.GetTableAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateTable</summary>
        public void UpdateTableRequestObject()
        {
            // Snippet: UpdateTable(UpdateTableRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            UpdateTableRequest request = new UpdateTableRequest
            {
                Table = new Table(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Table, UpdateTableMetadata> response = bigtableTableAdminClient.UpdateTable(request);

            // Poll until the returned long-running operation is complete
            Operation<Table, UpdateTableMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, UpdateTableMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceUpdateTable(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTableAsync</summary>
        public async Task UpdateTableRequestObjectAsync()
        {
            // Snippet: UpdateTableAsync(UpdateTableRequest, CallSettings)
            // Additional: UpdateTableAsync(UpdateTableRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateTableRequest request = new UpdateTableRequest
            {
                Table = new Table(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<Table, UpdateTableMetadata> response = await bigtableTableAdminClient.UpdateTableAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Table, UpdateTableMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, UpdateTableMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceUpdateTableAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTable</summary>
        public void UpdateTable()
        {
            // Snippet: UpdateTable(Table, FieldMask, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            Table table = new Table();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Table, UpdateTableMetadata> response = bigtableTableAdminClient.UpdateTable(table, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Table, UpdateTableMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, UpdateTableMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceUpdateTable(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateTableAsync</summary>
        public async Task UpdateTableAsync()
        {
            // Snippet: UpdateTableAsync(Table, FieldMask, CallSettings)
            // Additional: UpdateTableAsync(Table, FieldMask, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            Table table = new Table();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<Table, UpdateTableMetadata> response = await bigtableTableAdminClient.UpdateTableAsync(table, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<Table, UpdateTableMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, UpdateTableMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceUpdateTableAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteTable</summary>
        public void DeleteTableRequestObject()
        {
            // Snippet: DeleteTable(DeleteTableRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            DeleteTableRequest request = new DeleteTableRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            bigtableTableAdminClient.DeleteTable(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTableAsync</summary>
        public async Task DeleteTableRequestObjectAsync()
        {
            // Snippet: DeleteTableAsync(DeleteTableRequest, CallSettings)
            // Additional: DeleteTableAsync(DeleteTableRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTableRequest request = new DeleteTableRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            await bigtableTableAdminClient.DeleteTableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTable</summary>
        public void DeleteTable()
        {
            // Snippet: DeleteTable(string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request
            bigtableTableAdminClient.DeleteTable(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTableAsync</summary>
        public async Task DeleteTableAsync()
        {
            // Snippet: DeleteTableAsync(string, CallSettings)
            // Additional: DeleteTableAsync(string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request
            await bigtableTableAdminClient.DeleteTableAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTable</summary>
        public void DeleteTableResourceNames()
        {
            // Snippet: DeleteTable(TableName, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            bigtableTableAdminClient.DeleteTable(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTableAsync</summary>
        public async Task DeleteTableResourceNamesAsync()
        {
            // Snippet: DeleteTableAsync(TableName, CallSettings)
            // Additional: DeleteTableAsync(TableName, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            await bigtableTableAdminClient.DeleteTableAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UndeleteTable</summary>
        public void UndeleteTableRequestObject()
        {
            // Snippet: UndeleteTable(UndeleteTableRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            UndeleteTableRequest request = new UndeleteTableRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            Operation<Table, UndeleteTableMetadata> response = bigtableTableAdminClient.UndeleteTable(request);

            // Poll until the returned long-running operation is complete
            Operation<Table, UndeleteTableMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, UndeleteTableMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceUndeleteTable(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteTableAsync</summary>
        public async Task UndeleteTableRequestObjectAsync()
        {
            // Snippet: UndeleteTableAsync(UndeleteTableRequest, CallSettings)
            // Additional: UndeleteTableAsync(UndeleteTableRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            UndeleteTableRequest request = new UndeleteTableRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            Operation<Table, UndeleteTableMetadata> response = await bigtableTableAdminClient.UndeleteTableAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Table, UndeleteTableMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, UndeleteTableMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceUndeleteTableAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteTable</summary>
        public void UndeleteTable()
        {
            // Snippet: UndeleteTable(string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request
            Operation<Table, UndeleteTableMetadata> response = bigtableTableAdminClient.UndeleteTable(name);

            // Poll until the returned long-running operation is complete
            Operation<Table, UndeleteTableMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, UndeleteTableMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceUndeleteTable(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteTableAsync</summary>
        public async Task UndeleteTableAsync()
        {
            // Snippet: UndeleteTableAsync(string, CallSettings)
            // Additional: UndeleteTableAsync(string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request
            Operation<Table, UndeleteTableMetadata> response = await bigtableTableAdminClient.UndeleteTableAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Table, UndeleteTableMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, UndeleteTableMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceUndeleteTableAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteTable</summary>
        public void UndeleteTableResourceNames()
        {
            // Snippet: UndeleteTable(TableName, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            Operation<Table, UndeleteTableMetadata> response = bigtableTableAdminClient.UndeleteTable(name);

            // Poll until the returned long-running operation is complete
            Operation<Table, UndeleteTableMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, UndeleteTableMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceUndeleteTable(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UndeleteTableAsync</summary>
        public async Task UndeleteTableResourceNamesAsync()
        {
            // Snippet: UndeleteTableAsync(TableName, CallSettings)
            // Additional: UndeleteTableAsync(TableName, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            Operation<Table, UndeleteTableMetadata> response = await bigtableTableAdminClient.UndeleteTableAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Table, UndeleteTableMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, UndeleteTableMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceUndeleteTableAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizedView</summary>
        public void CreateAuthorizedViewRequestObject()
        {
            // Snippet: CreateAuthorizedView(CreateAuthorizedViewRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            CreateAuthorizedViewRequest request = new CreateAuthorizedViewRequest
            {
                ParentAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                AuthorizedViewId = "",
                AuthorizedView = new AuthorizedView(),
            };
            // Make the request
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> response = bigtableTableAdminClient.CreateAuthorizedView(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthorizedView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceCreateAuthorizedView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizedView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizedViewAsync</summary>
        public async Task CreateAuthorizedViewRequestObjectAsync()
        {
            // Snippet: CreateAuthorizedViewAsync(CreateAuthorizedViewRequest, CallSettings)
            // Additional: CreateAuthorizedViewAsync(CreateAuthorizedViewRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateAuthorizedViewRequest request = new CreateAuthorizedViewRequest
            {
                ParentAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                AuthorizedViewId = "",
                AuthorizedView = new AuthorizedView(),
            };
            // Make the request
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> response = await bigtableTableAdminClient.CreateAuthorizedViewAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthorizedView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceCreateAuthorizedViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizedView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizedView</summary>
        public void CreateAuthorizedView()
        {
            // Snippet: CreateAuthorizedView(string, AuthorizedView, string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            AuthorizedView authorizedView = new AuthorizedView();
            string authorizedViewId = "";
            // Make the request
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> response = bigtableTableAdminClient.CreateAuthorizedView(parent, authorizedView, authorizedViewId);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthorizedView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceCreateAuthorizedView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizedView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizedViewAsync</summary>
        public async Task CreateAuthorizedViewAsync()
        {
            // Snippet: CreateAuthorizedViewAsync(string, AuthorizedView, string, CallSettings)
            // Additional: CreateAuthorizedViewAsync(string, AuthorizedView, string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            AuthorizedView authorizedView = new AuthorizedView();
            string authorizedViewId = "";
            // Make the request
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> response = await bigtableTableAdminClient.CreateAuthorizedViewAsync(parent, authorizedView, authorizedViewId);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthorizedView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceCreateAuthorizedViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizedView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizedView</summary>
        public void CreateAuthorizedViewResourceNames()
        {
            // Snippet: CreateAuthorizedView(TableName, AuthorizedView, string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName parent = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            AuthorizedView authorizedView = new AuthorizedView();
            string authorizedViewId = "";
            // Make the request
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> response = bigtableTableAdminClient.CreateAuthorizedView(parent, authorizedView, authorizedViewId);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthorizedView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceCreateAuthorizedView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizedView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAuthorizedViewAsync</summary>
        public async Task CreateAuthorizedViewResourceNamesAsync()
        {
            // Snippet: CreateAuthorizedViewAsync(TableName, AuthorizedView, string, CallSettings)
            // Additional: CreateAuthorizedViewAsync(TableName, AuthorizedView, string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName parent = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            AuthorizedView authorizedView = new AuthorizedView();
            string authorizedViewId = "";
            // Make the request
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> response = await bigtableTableAdminClient.CreateAuthorizedViewAsync(parent, authorizedView, authorizedViewId);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthorizedView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizedView, CreateAuthorizedViewMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceCreateAuthorizedViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizedView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizedViews</summary>
        public void ListAuthorizedViewsRequestObject()
        {
            // Snippet: ListAuthorizedViews(ListAuthorizedViewsRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ListAuthorizedViewsRequest request = new ListAuthorizedViewsRequest
            {
                ParentAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                View = AuthorizedView.Types.ResponseView.Unspecified,
            };
            // Make the request
            PagedEnumerable<ListAuthorizedViewsResponse, AuthorizedView> response = bigtableTableAdminClient.ListAuthorizedViews(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuthorizedView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuthorizedViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizedView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizedView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizedView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizedViewsAsync</summary>
        public async Task ListAuthorizedViewsRequestObjectAsync()
        {
            // Snippet: ListAuthorizedViewsAsync(ListAuthorizedViewsRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListAuthorizedViewsRequest request = new ListAuthorizedViewsRequest
            {
                ParentAsTableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                View = AuthorizedView.Types.ResponseView.Unspecified,
            };
            // Make the request
            PagedAsyncEnumerable<ListAuthorizedViewsResponse, AuthorizedView> response = bigtableTableAdminClient.ListAuthorizedViewsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AuthorizedView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAuthorizedViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizedView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizedView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizedView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizedViews</summary>
        public void ListAuthorizedViews()
        {
            // Snippet: ListAuthorizedViews(string, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request
            PagedEnumerable<ListAuthorizedViewsResponse, AuthorizedView> response = bigtableTableAdminClient.ListAuthorizedViews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuthorizedView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuthorizedViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizedView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizedView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizedView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizedViewsAsync</summary>
        public async Task ListAuthorizedViewsAsync()
        {
            // Snippet: ListAuthorizedViewsAsync(string, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request
            PagedAsyncEnumerable<ListAuthorizedViewsResponse, AuthorizedView> response = bigtableTableAdminClient.ListAuthorizedViewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AuthorizedView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAuthorizedViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizedView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizedView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizedView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizedViews</summary>
        public void ListAuthorizedViewsResourceNames()
        {
            // Snippet: ListAuthorizedViews(TableName, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName parent = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            PagedEnumerable<ListAuthorizedViewsResponse, AuthorizedView> response = bigtableTableAdminClient.ListAuthorizedViews(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AuthorizedView item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAuthorizedViewsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizedView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizedView> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizedView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAuthorizedViewsAsync</summary>
        public async Task ListAuthorizedViewsResourceNamesAsync()
        {
            // Snippet: ListAuthorizedViewsAsync(TableName, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName parent = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            PagedAsyncEnumerable<ListAuthorizedViewsResponse, AuthorizedView> response = bigtableTableAdminClient.ListAuthorizedViewsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AuthorizedView item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAuthorizedViewsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AuthorizedView item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AuthorizedView> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AuthorizedView item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizedView</summary>
        public void GetAuthorizedViewRequestObject()
        {
            // Snippet: GetAuthorizedView(GetAuthorizedViewRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            GetAuthorizedViewRequest request = new GetAuthorizedViewRequest
            {
                AuthorizedViewName = AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
                View = AuthorizedView.Types.ResponseView.Unspecified,
            };
            // Make the request
            AuthorizedView response = bigtableTableAdminClient.GetAuthorizedView(request);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizedViewAsync</summary>
        public async Task GetAuthorizedViewRequestObjectAsync()
        {
            // Snippet: GetAuthorizedViewAsync(GetAuthorizedViewRequest, CallSettings)
            // Additional: GetAuthorizedViewAsync(GetAuthorizedViewRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetAuthorizedViewRequest request = new GetAuthorizedViewRequest
            {
                AuthorizedViewName = AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
                View = AuthorizedView.Types.ResponseView.Unspecified,
            };
            // Make the request
            AuthorizedView response = await bigtableTableAdminClient.GetAuthorizedViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizedView</summary>
        public void GetAuthorizedView()
        {
            // Snippet: GetAuthorizedView(string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]/authorizedViews/[AUTHORIZED_VIEW]";
            // Make the request
            AuthorizedView response = bigtableTableAdminClient.GetAuthorizedView(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizedViewAsync</summary>
        public async Task GetAuthorizedViewAsync()
        {
            // Snippet: GetAuthorizedViewAsync(string, CallSettings)
            // Additional: GetAuthorizedViewAsync(string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]/authorizedViews/[AUTHORIZED_VIEW]";
            // Make the request
            AuthorizedView response = await bigtableTableAdminClient.GetAuthorizedViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizedView</summary>
        public void GetAuthorizedViewResourceNames()
        {
            // Snippet: GetAuthorizedView(AuthorizedViewName, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            AuthorizedViewName name = AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]");
            // Make the request
            AuthorizedView response = bigtableTableAdminClient.GetAuthorizedView(name);
            // End snippet
        }

        /// <summary>Snippet for GetAuthorizedViewAsync</summary>
        public async Task GetAuthorizedViewResourceNamesAsync()
        {
            // Snippet: GetAuthorizedViewAsync(AuthorizedViewName, CallSettings)
            // Additional: GetAuthorizedViewAsync(AuthorizedViewName, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            AuthorizedViewName name = AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]");
            // Make the request
            AuthorizedView response = await bigtableTableAdminClient.GetAuthorizedViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthorizedView</summary>
        public void UpdateAuthorizedViewRequestObject()
        {
            // Snippet: UpdateAuthorizedView(UpdateAuthorizedViewRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            UpdateAuthorizedViewRequest request = new UpdateAuthorizedViewRequest
            {
                AuthorizedView = new AuthorizedView(),
                UpdateMask = new FieldMask(),
                IgnoreWarnings = false,
            };
            // Make the request
            Operation<AuthorizedView, UpdateAuthorizedViewMetadata> response = bigtableTableAdminClient.UpdateAuthorizedView(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizedView, UpdateAuthorizedViewMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthorizedView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizedView, UpdateAuthorizedViewMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceUpdateAuthorizedView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizedView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthorizedViewAsync</summary>
        public async Task UpdateAuthorizedViewRequestObjectAsync()
        {
            // Snippet: UpdateAuthorizedViewAsync(UpdateAuthorizedViewRequest, CallSettings)
            // Additional: UpdateAuthorizedViewAsync(UpdateAuthorizedViewRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAuthorizedViewRequest request = new UpdateAuthorizedViewRequest
            {
                AuthorizedView = new AuthorizedView(),
                UpdateMask = new FieldMask(),
                IgnoreWarnings = false,
            };
            // Make the request
            Operation<AuthorizedView, UpdateAuthorizedViewMetadata> response = await bigtableTableAdminClient.UpdateAuthorizedViewAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizedView, UpdateAuthorizedViewMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthorizedView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizedView, UpdateAuthorizedViewMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceUpdateAuthorizedViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizedView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthorizedView</summary>
        public void UpdateAuthorizedView()
        {
            // Snippet: UpdateAuthorizedView(AuthorizedView, FieldMask, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            AuthorizedView authorizedView = new AuthorizedView();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AuthorizedView, UpdateAuthorizedViewMetadata> response = bigtableTableAdminClient.UpdateAuthorizedView(authorizedView, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizedView, UpdateAuthorizedViewMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AuthorizedView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizedView, UpdateAuthorizedViewMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceUpdateAuthorizedView(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizedView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAuthorizedViewAsync</summary>
        public async Task UpdateAuthorizedViewAsync()
        {
            // Snippet: UpdateAuthorizedViewAsync(AuthorizedView, FieldMask, CallSettings)
            // Additional: UpdateAuthorizedViewAsync(AuthorizedView, FieldMask, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            AuthorizedView authorizedView = new AuthorizedView();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AuthorizedView, UpdateAuthorizedViewMetadata> response = await bigtableTableAdminClient.UpdateAuthorizedViewAsync(authorizedView, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AuthorizedView, UpdateAuthorizedViewMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AuthorizedView result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AuthorizedView, UpdateAuthorizedViewMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceUpdateAuthorizedViewAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AuthorizedView retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizedView</summary>
        public void DeleteAuthorizedViewRequestObject()
        {
            // Snippet: DeleteAuthorizedView(DeleteAuthorizedViewRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            DeleteAuthorizedViewRequest request = new DeleteAuthorizedViewRequest
            {
                AuthorizedViewName = AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
                Etag = "",
            };
            // Make the request
            bigtableTableAdminClient.DeleteAuthorizedView(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizedViewAsync</summary>
        public async Task DeleteAuthorizedViewRequestObjectAsync()
        {
            // Snippet: DeleteAuthorizedViewAsync(DeleteAuthorizedViewRequest, CallSettings)
            // Additional: DeleteAuthorizedViewAsync(DeleteAuthorizedViewRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAuthorizedViewRequest request = new DeleteAuthorizedViewRequest
            {
                AuthorizedViewName = AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]"),
                Etag = "",
            };
            // Make the request
            await bigtableTableAdminClient.DeleteAuthorizedViewAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizedView</summary>
        public void DeleteAuthorizedView()
        {
            // Snippet: DeleteAuthorizedView(string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]/authorizedViews/[AUTHORIZED_VIEW]";
            // Make the request
            bigtableTableAdminClient.DeleteAuthorizedView(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizedViewAsync</summary>
        public async Task DeleteAuthorizedViewAsync()
        {
            // Snippet: DeleteAuthorizedViewAsync(string, CallSettings)
            // Additional: DeleteAuthorizedViewAsync(string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]/authorizedViews/[AUTHORIZED_VIEW]";
            // Make the request
            await bigtableTableAdminClient.DeleteAuthorizedViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizedView</summary>
        public void DeleteAuthorizedViewResourceNames()
        {
            // Snippet: DeleteAuthorizedView(AuthorizedViewName, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            AuthorizedViewName name = AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]");
            // Make the request
            bigtableTableAdminClient.DeleteAuthorizedView(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteAuthorizedViewAsync</summary>
        public async Task DeleteAuthorizedViewResourceNamesAsync()
        {
            // Snippet: DeleteAuthorizedViewAsync(AuthorizedViewName, CallSettings)
            // Additional: DeleteAuthorizedViewAsync(AuthorizedViewName, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            AuthorizedViewName name = AuthorizedViewName.FromProjectInstanceTableAuthorizedView("[PROJECT]", "[INSTANCE]", "[TABLE]", "[AUTHORIZED_VIEW]");
            // Make the request
            await bigtableTableAdminClient.DeleteAuthorizedViewAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ModifyColumnFamilies</summary>
        public void ModifyColumnFamiliesRequestObject()
        {
            // Snippet: ModifyColumnFamilies(ModifyColumnFamiliesRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ModifyColumnFamiliesRequest request = new ModifyColumnFamiliesRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications =
                {
                    new ModifyColumnFamiliesRequest.Types.Modification(),
                },
                IgnoreWarnings = false,
            };
            // Make the request
            Table response = bigtableTableAdminClient.ModifyColumnFamilies(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyColumnFamiliesAsync</summary>
        public async Task ModifyColumnFamiliesRequestObjectAsync()
        {
            // Snippet: ModifyColumnFamiliesAsync(ModifyColumnFamiliesRequest, CallSettings)
            // Additional: ModifyColumnFamiliesAsync(ModifyColumnFamiliesRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ModifyColumnFamiliesRequest request = new ModifyColumnFamiliesRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications =
                {
                    new ModifyColumnFamiliesRequest.Types.Modification(),
                },
                IgnoreWarnings = false,
            };
            // Make the request
            Table response = await bigtableTableAdminClient.ModifyColumnFamiliesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyColumnFamilies</summary>
        public void ModifyColumnFamilies()
        {
            // Snippet: ModifyColumnFamilies(string, IEnumerable<ModifyColumnFamiliesRequest.Types.Modification>, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications = new ModifyColumnFamiliesRequest.Types.Modification[]
            {
                new ModifyColumnFamiliesRequest.Types.Modification(),
            };
            // Make the request
            Table response = bigtableTableAdminClient.ModifyColumnFamilies(name, modifications);
            // End snippet
        }

        /// <summary>Snippet for ModifyColumnFamiliesAsync</summary>
        public async Task ModifyColumnFamiliesAsync()
        {
            // Snippet: ModifyColumnFamiliesAsync(string, IEnumerable<ModifyColumnFamiliesRequest.Types.Modification>, CallSettings)
            // Additional: ModifyColumnFamiliesAsync(string, IEnumerable<ModifyColumnFamiliesRequest.Types.Modification>, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications = new ModifyColumnFamiliesRequest.Types.Modification[]
            {
                new ModifyColumnFamiliesRequest.Types.Modification(),
            };
            // Make the request
            Table response = await bigtableTableAdminClient.ModifyColumnFamiliesAsync(name, modifications);
            // End snippet
        }

        /// <summary>Snippet for ModifyColumnFamilies</summary>
        public void ModifyColumnFamiliesResourceNames()
        {
            // Snippet: ModifyColumnFamilies(TableName, IEnumerable<ModifyColumnFamiliesRequest.Types.Modification>, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications = new ModifyColumnFamiliesRequest.Types.Modification[]
            {
                new ModifyColumnFamiliesRequest.Types.Modification(),
            };
            // Make the request
            Table response = bigtableTableAdminClient.ModifyColumnFamilies(name, modifications);
            // End snippet
        }

        /// <summary>Snippet for ModifyColumnFamiliesAsync</summary>
        public async Task ModifyColumnFamiliesResourceNamesAsync()
        {
            // Snippet: ModifyColumnFamiliesAsync(TableName, IEnumerable<ModifyColumnFamiliesRequest.Types.Modification>, CallSettings)
            // Additional: ModifyColumnFamiliesAsync(TableName, IEnumerable<ModifyColumnFamiliesRequest.Types.Modification>, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications = new ModifyColumnFamiliesRequest.Types.Modification[]
            {
                new ModifyColumnFamiliesRequest.Types.Modification(),
            };
            // Make the request
            Table response = await bigtableTableAdminClient.ModifyColumnFamiliesAsync(name, modifications);
            // End snippet
        }

        /// <summary>Snippet for DropRowRange</summary>
        public void DropRowRangeRequestObject()
        {
            // Snippet: DropRowRange(DropRowRangeRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            DropRowRangeRequest request = new DropRowRangeRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKeyPrefix = ByteString.Empty,
            };
            // Make the request
            bigtableTableAdminClient.DropRowRange(request);
            // End snippet
        }

        /// <summary>Snippet for DropRowRangeAsync</summary>
        public async Task DropRowRangeRequestObjectAsync()
        {
            // Snippet: DropRowRangeAsync(DropRowRangeRequest, CallSettings)
            // Additional: DropRowRangeAsync(DropRowRangeRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            DropRowRangeRequest request = new DropRowRangeRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                RowKeyPrefix = ByteString.Empty,
            };
            // Make the request
            await bigtableTableAdminClient.DropRowRangeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateConsistencyToken</summary>
        public void GenerateConsistencyTokenRequestObject()
        {
            // Snippet: GenerateConsistencyToken(GenerateConsistencyTokenRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            GenerateConsistencyTokenRequest request = new GenerateConsistencyTokenRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            GenerateConsistencyTokenResponse response = bigtableTableAdminClient.GenerateConsistencyToken(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateConsistencyTokenAsync</summary>
        public async Task GenerateConsistencyTokenRequestObjectAsync()
        {
            // Snippet: GenerateConsistencyTokenAsync(GenerateConsistencyTokenRequest, CallSettings)
            // Additional: GenerateConsistencyTokenAsync(GenerateConsistencyTokenRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            GenerateConsistencyTokenRequest request = new GenerateConsistencyTokenRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            GenerateConsistencyTokenResponse response = await bigtableTableAdminClient.GenerateConsistencyTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateConsistencyToken</summary>
        public void GenerateConsistencyToken()
        {
            // Snippet: GenerateConsistencyToken(string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request
            GenerateConsistencyTokenResponse response = bigtableTableAdminClient.GenerateConsistencyToken(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateConsistencyTokenAsync</summary>
        public async Task GenerateConsistencyTokenAsync()
        {
            // Snippet: GenerateConsistencyTokenAsync(string, CallSettings)
            // Additional: GenerateConsistencyTokenAsync(string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            // Make the request
            GenerateConsistencyTokenResponse response = await bigtableTableAdminClient.GenerateConsistencyTokenAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateConsistencyToken</summary>
        public void GenerateConsistencyTokenResourceNames()
        {
            // Snippet: GenerateConsistencyToken(TableName, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            GenerateConsistencyTokenResponse response = bigtableTableAdminClient.GenerateConsistencyToken(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateConsistencyTokenAsync</summary>
        public async Task GenerateConsistencyTokenResourceNamesAsync()
        {
            // Snippet: GenerateConsistencyTokenAsync(TableName, CallSettings)
            // Additional: GenerateConsistencyTokenAsync(TableName, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            GenerateConsistencyTokenResponse response = await bigtableTableAdminClient.GenerateConsistencyTokenAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CheckConsistency</summary>
        public void CheckConsistencyRequestObject()
        {
            // Snippet: CheckConsistency(CheckConsistencyRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            CheckConsistencyRequest request = new CheckConsistencyRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "",
                StandardReadRemoteWrites = new StandardReadRemoteWrites(),
            };
            // Make the request
            CheckConsistencyResponse response = bigtableTableAdminClient.CheckConsistency(request);
            // End snippet
        }

        /// <summary>Snippet for CheckConsistencyAsync</summary>
        public async Task CheckConsistencyRequestObjectAsync()
        {
            // Snippet: CheckConsistencyAsync(CheckConsistencyRequest, CallSettings)
            // Additional: CheckConsistencyAsync(CheckConsistencyRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            CheckConsistencyRequest request = new CheckConsistencyRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "",
                StandardReadRemoteWrites = new StandardReadRemoteWrites(),
            };
            // Make the request
            CheckConsistencyResponse response = await bigtableTableAdminClient.CheckConsistencyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CheckConsistency</summary>
        public void CheckConsistency()
        {
            // Snippet: CheckConsistency(string, string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            string consistencyToken = "";
            // Make the request
            CheckConsistencyResponse response = bigtableTableAdminClient.CheckConsistency(name, consistencyToken);
            // End snippet
        }

        /// <summary>Snippet for CheckConsistencyAsync</summary>
        public async Task CheckConsistencyAsync()
        {
            // Snippet: CheckConsistencyAsync(string, string, CallSettings)
            // Additional: CheckConsistencyAsync(string, string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            string consistencyToken = "";
            // Make the request
            CheckConsistencyResponse response = await bigtableTableAdminClient.CheckConsistencyAsync(name, consistencyToken);
            // End snippet
        }

        /// <summary>Snippet for CheckConsistency</summary>
        public void CheckConsistencyResourceNames()
        {
            // Snippet: CheckConsistency(TableName, string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string consistencyToken = "";
            // Make the request
            CheckConsistencyResponse response = bigtableTableAdminClient.CheckConsistency(name, consistencyToken);
            // End snippet
        }

        /// <summary>Snippet for CheckConsistencyAsync</summary>
        public async Task CheckConsistencyResourceNamesAsync()
        {
            // Snippet: CheckConsistencyAsync(TableName, string, CallSettings)
            // Additional: CheckConsistencyAsync(TableName, string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string consistencyToken = "";
            // Make the request
            CheckConsistencyResponse response = await bigtableTableAdminClient.CheckConsistencyAsync(name, consistencyToken);
            // End snippet
        }

        /// <summary>Snippet for SnapshotTable</summary>
        public void SnapshotTableRequestObject()
        {
            // Snippet: SnapshotTable(SnapshotTableRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            SnapshotTableRequest request = new SnapshotTableRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterAsClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                SnapshotId = "",
                Ttl = new Duration(),
                Description = "",
            };
            // Make the request
            Operation<Snapshot, SnapshotTableMetadata> response = bigtableTableAdminClient.SnapshotTable(request);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, SnapshotTableMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, SnapshotTableMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceSnapshotTable(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SnapshotTableAsync</summary>
        public async Task SnapshotTableRequestObjectAsync()
        {
            // Snippet: SnapshotTableAsync(SnapshotTableRequest, CallSettings)
            // Additional: SnapshotTableAsync(SnapshotTableRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotTableRequest request = new SnapshotTableRequest
            {
                TableName = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterAsClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                SnapshotId = "",
                Ttl = new Duration(),
                Description = "",
            };
            // Make the request
            Operation<Snapshot, SnapshotTableMetadata> response = await bigtableTableAdminClient.SnapshotTableAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, SnapshotTableMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, SnapshotTableMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceSnapshotTableAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SnapshotTable</summary>
        public void SnapshotTable()
        {
            // Snippet: SnapshotTable(string, string, string, string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            string cluster = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            string snapshotId = "";
            string description = "";
            // Make the request
            Operation<Snapshot, SnapshotTableMetadata> response = bigtableTableAdminClient.SnapshotTable(name, cluster, snapshotId, description);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, SnapshotTableMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, SnapshotTableMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceSnapshotTable(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SnapshotTableAsync</summary>
        public async Task SnapshotTableAsync()
        {
            // Snippet: SnapshotTableAsync(string, string, string, string, CallSettings)
            // Additional: SnapshotTableAsync(string, string, string, string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/tables/[TABLE]";
            string cluster = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            string snapshotId = "";
            string description = "";
            // Make the request
            Operation<Snapshot, SnapshotTableMetadata> response = await bigtableTableAdminClient.SnapshotTableAsync(name, cluster, snapshotId, description);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, SnapshotTableMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, SnapshotTableMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceSnapshotTableAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SnapshotTable</summary>
        public void SnapshotTableResourceNames()
        {
            // Snippet: SnapshotTable(TableName, ClusterName, string, string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ClusterName cluster = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            string snapshotId = "";
            string description = "";
            // Make the request
            Operation<Snapshot, SnapshotTableMetadata> response = bigtableTableAdminClient.SnapshotTable(name, cluster, snapshotId, description);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, SnapshotTableMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, SnapshotTableMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceSnapshotTable(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SnapshotTableAsync</summary>
        public async Task SnapshotTableResourceNamesAsync()
        {
            // Snippet: SnapshotTableAsync(TableName, ClusterName, string, string, CallSettings)
            // Additional: SnapshotTableAsync(TableName, ClusterName, string, string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = TableName.FromProjectInstanceTable("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ClusterName cluster = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            string snapshotId = "";
            string description = "";
            // Make the request
            Operation<Snapshot, SnapshotTableMetadata> response = await bigtableTableAdminClient.SnapshotTableAsync(name, cluster, snapshotId, description);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, SnapshotTableMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, SnapshotTableMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceSnapshotTableAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetSnapshot</summary>
        public void GetSnapshotRequestObject()
        {
            // Snippet: GetSnapshot(GetSnapshotRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            // Make the request
            Snapshot response = bigtableTableAdminClient.GetSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotAsync</summary>
        public async Task GetSnapshotRequestObjectAsync()
        {
            // Snippet: GetSnapshotAsync(GetSnapshotRequest, CallSettings)
            // Additional: GetSnapshotAsync(GetSnapshotRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            // Make the request
            Snapshot response = await bigtableTableAdminClient.GetSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshot</summary>
        public void GetSnapshot()
        {
            // Snippet: GetSnapshot(string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]/snapshots/[SNAPSHOT]";
            // Make the request
            Snapshot response = bigtableTableAdminClient.GetSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotAsync</summary>
        public async Task GetSnapshotAsync()
        {
            // Snippet: GetSnapshotAsync(string, CallSettings)
            // Additional: GetSnapshotAsync(string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]/snapshots/[SNAPSHOT]";
            // Make the request
            Snapshot response = await bigtableTableAdminClient.GetSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshot</summary>
        public void GetSnapshotResourceNames()
        {
            // Snippet: GetSnapshot(SnapshotName, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            SnapshotName name = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            // Make the request
            Snapshot response = bigtableTableAdminClient.GetSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotAsync</summary>
        public async Task GetSnapshotResourceNamesAsync()
        {
            // Snippet: GetSnapshotAsync(SnapshotName, CallSettings)
            // Additional: GetSnapshotAsync(SnapshotName, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName name = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            // Make the request
            Snapshot response = await bigtableTableAdminClient.GetSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshotsRequestObject()
        {
            // Snippet: ListSnapshots(ListSnapshotsRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response = bigtableTableAdminClient.ListSnapshots(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsRequestObjectAsync()
        {
            // Snippet: ListSnapshotsAsync(ListSnapshotsRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response = bigtableTableAdminClient.ListSnapshotsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Snapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshots()
        {
            // Snippet: ListSnapshots(string, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response = bigtableTableAdminClient.ListSnapshots(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsAsync()
        {
            // Snippet: ListSnapshotsAsync(string, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response = bigtableTableAdminClient.ListSnapshotsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Snapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshotsResourceNames()
        {
            // Snippet: ListSnapshots(ClusterName, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response = bigtableTableAdminClient.ListSnapshots(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Snapshot item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListSnapshotsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsResourceNamesAsync()
        {
            // Snippet: ListSnapshotsAsync(ClusterName, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response = bigtableTableAdminClient.ListSnapshotsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Snapshot item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListSnapshotsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Snapshot item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Snapshot> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Snapshot item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshotRequestObject()
        {
            // Snippet: DeleteSnapshot(DeleteSnapshotRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            // Make the request
            bigtableTableAdminClient.DeleteSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotRequestObjectAsync()
        {
            // Snippet: DeleteSnapshotAsync(DeleteSnapshotRequest, CallSettings)
            // Additional: DeleteSnapshotAsync(DeleteSnapshotRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            // Make the request
            await bigtableTableAdminClient.DeleteSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshot()
        {
            // Snippet: DeleteSnapshot(string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]/snapshots/[SNAPSHOT]";
            // Make the request
            bigtableTableAdminClient.DeleteSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotAsync()
        {
            // Snippet: DeleteSnapshotAsync(string, CallSettings)
            // Additional: DeleteSnapshotAsync(string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]/snapshots/[SNAPSHOT]";
            // Make the request
            await bigtableTableAdminClient.DeleteSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshotResourceNames()
        {
            // Snippet: DeleteSnapshot(SnapshotName, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            SnapshotName name = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            // Make the request
            bigtableTableAdminClient.DeleteSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotResourceNamesAsync()
        {
            // Snippet: DeleteSnapshotAsync(SnapshotName, CallSettings)
            // Additional: DeleteSnapshotAsync(SnapshotName, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName name = SnapshotName.FromProjectInstanceClusterSnapshot("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            // Make the request
            await bigtableTableAdminClient.DeleteSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for CreateBackup</summary>
        public void CreateBackupRequestObject()
        {
            // Snippet: CreateBackup(CreateBackupRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            CreateBackupRequest request = new CreateBackupRequest
            {
                ParentAsClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                BackupId = "",
                Backup = new Backup(),
            };
            // Make the request
            Operation<Backup, CreateBackupMetadata> response = bigtableTableAdminClient.CreateBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CreateBackupMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CreateBackupMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceCreateBackup(operationName);
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
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateBackupRequest request = new CreateBackupRequest
            {
                ParentAsClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                BackupId = "",
                Backup = new Backup(),
            };
            // Make the request
            Operation<Backup, CreateBackupMetadata> response = await bigtableTableAdminClient.CreateBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CreateBackupMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CreateBackupMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceCreateBackupAsync(operationName);
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
            // Snippet: CreateBackup(string, string, Backup, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            string backupId = "";
            Backup backup = new Backup();
            // Make the request
            Operation<Backup, CreateBackupMetadata> response = bigtableTableAdminClient.CreateBackup(parent, backupId, backup);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CreateBackupMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CreateBackupMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceCreateBackup(operationName);
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
            // Snippet: CreateBackupAsync(string, string, Backup, CallSettings)
            // Additional: CreateBackupAsync(string, string, Backup, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            string backupId = "";
            Backup backup = new Backup();
            // Make the request
            Operation<Backup, CreateBackupMetadata> response = await bigtableTableAdminClient.CreateBackupAsync(parent, backupId, backup);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CreateBackupMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CreateBackupMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceCreateBackupAsync(operationName);
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
            // Snippet: CreateBackup(ClusterName, string, Backup, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            string backupId = "";
            Backup backup = new Backup();
            // Make the request
            Operation<Backup, CreateBackupMetadata> response = bigtableTableAdminClient.CreateBackup(parent, backupId, backup);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CreateBackupMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CreateBackupMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceCreateBackup(operationName);
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
            // Snippet: CreateBackupAsync(ClusterName, string, Backup, CallSettings)
            // Additional: CreateBackupAsync(ClusterName, string, Backup, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            string backupId = "";
            Backup backup = new Backup();
            // Make the request
            Operation<Backup, CreateBackupMetadata> response = await bigtableTableAdminClient.CreateBackupAsync(parent, backupId, backup);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CreateBackupMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CreateBackupMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceCreateBackupAsync(operationName);
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
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            // Make the request
            Backup response = bigtableTableAdminClient.GetBackup(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupRequestObjectAsync()
        {
            // Snippet: GetBackupAsync(GetBackupRequest, CallSettings)
            // Additional: GetBackupAsync(GetBackupRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetBackupRequest request = new GetBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            // Make the request
            Backup response = await bigtableTableAdminClient.GetBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackup()
        {
            // Snippet: GetBackup(string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]/backups/[BACKUP]";
            // Make the request
            Backup response = bigtableTableAdminClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupAsync()
        {
            // Snippet: GetBackupAsync(string, CallSettings)
            // Additional: GetBackupAsync(string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]/backups/[BACKUP]";
            // Make the request
            Backup response = await bigtableTableAdminClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackup</summary>
        public void GetBackupResourceNames()
        {
            // Snippet: GetBackup(BackupName, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]");
            // Make the request
            Backup response = bigtableTableAdminClient.GetBackup(name);
            // End snippet
        }

        /// <summary>Snippet for GetBackupAsync</summary>
        public async Task GetBackupResourceNamesAsync()
        {
            // Snippet: GetBackupAsync(BackupName, CallSettings)
            // Additional: GetBackupAsync(BackupName, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]");
            // Make the request
            Backup response = await bigtableTableAdminClient.GetBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateBackup</summary>
        public void UpdateBackupRequestObject()
        {
            // Snippet: UpdateBackup(UpdateBackupRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Backup response = bigtableTableAdminClient.UpdateBackup(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupAsync</summary>
        public async Task UpdateBackupRequestObjectAsync()
        {
            // Snippet: UpdateBackupAsync(UpdateBackupRequest, CallSettings)
            // Additional: UpdateBackupAsync(UpdateBackupRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            UpdateBackupRequest request = new UpdateBackupRequest
            {
                Backup = new Backup(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Backup response = await bigtableTableAdminClient.UpdateBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateBackup</summary>
        public void UpdateBackup()
        {
            // Snippet: UpdateBackup(Backup, FieldMask, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Backup response = bigtableTableAdminClient.UpdateBackup(backup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateBackupAsync</summary>
        public async Task UpdateBackupAsync()
        {
            // Snippet: UpdateBackupAsync(Backup, FieldMask, CallSettings)
            // Additional: UpdateBackupAsync(Backup, FieldMask, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            Backup backup = new Backup();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Backup response = await bigtableTableAdminClient.UpdateBackupAsync(backup, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackupRequestObject()
        {
            // Snippet: DeleteBackup(DeleteBackupRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            // Make the request
            bigtableTableAdminClient.DeleteBackup(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupRequestObjectAsync()
        {
            // Snippet: DeleteBackupAsync(DeleteBackupRequest, CallSettings)
            // Additional: DeleteBackupAsync(DeleteBackupRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteBackupRequest request = new DeleteBackupRequest
            {
                BackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            // Make the request
            await bigtableTableAdminClient.DeleteBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackup()
        {
            // Snippet: DeleteBackup(string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]/backups/[BACKUP]";
            // Make the request
            bigtableTableAdminClient.DeleteBackup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupAsync()
        {
            // Snippet: DeleteBackupAsync(string, CallSettings)
            // Additional: DeleteBackupAsync(string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]/backups/[BACKUP]";
            // Make the request
            await bigtableTableAdminClient.DeleteBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackup</summary>
        public void DeleteBackupResourceNames()
        {
            // Snippet: DeleteBackup(BackupName, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]");
            // Make the request
            bigtableTableAdminClient.DeleteBackup(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteBackupAsync</summary>
        public async Task DeleteBackupResourceNamesAsync()
        {
            // Snippet: DeleteBackupAsync(BackupName, CallSettings)
            // Additional: DeleteBackupAsync(BackupName, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            BackupName name = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]");
            // Make the request
            await bigtableTableAdminClient.DeleteBackupAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListBackups</summary>
        public void ListBackupsRequestObject()
        {
            // Snippet: ListBackups(ListBackupsRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = bigtableTableAdminClient.ListBackups(request);

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
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListBackupsRequest request = new ListBackupsRequest
            {
                ParentAsClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = bigtableTableAdminClient.ListBackupsAsync(request);

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
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = bigtableTableAdminClient.ListBackups(parent);

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
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = bigtableTableAdminClient.ListBackupsAsync(parent);

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
            // Snippet: ListBackups(ClusterName, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListBackupsResponse, Backup> response = bigtableTableAdminClient.ListBackups(parent);

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
            // Snippet: ListBackupsAsync(ClusterName, string, int?, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListBackupsResponse, Backup> response = bigtableTableAdminClient.ListBackupsAsync(parent);

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

        /// <summary>Snippet for RestoreTable</summary>
        public void RestoreTableRequestObject()
        {
            // Snippet: RestoreTable(RestoreTableRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            RestoreTableRequest request = new RestoreTableRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TableId = "",
                BackupAsBackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            // Make the request
            Operation<Table, RestoreTableMetadata> response = bigtableTableAdminClient.RestoreTable(request);

            // Poll until the returned long-running operation is complete
            Operation<Table, RestoreTableMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, RestoreTableMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceRestoreTable(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreTableAsync</summary>
        public async Task RestoreTableRequestObjectAsync()
        {
            // Snippet: RestoreTableAsync(RestoreTableRequest, CallSettings)
            // Additional: RestoreTableAsync(RestoreTableRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            RestoreTableRequest request = new RestoreTableRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                TableId = "",
                BackupAsBackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
            };
            // Make the request
            Operation<Table, RestoreTableMetadata> response = await bigtableTableAdminClient.RestoreTableAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Table, RestoreTableMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, RestoreTableMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceRestoreTableAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CopyBackup</summary>
        public void CopyBackupRequestObject()
        {
            // Snippet: CopyBackup(CopyBackupRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            CopyBackupRequest request = new CopyBackupRequest
            {
                ParentAsClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                BackupId = "",
                SourceBackupAsBackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
                ExpireTime = new Timestamp(),
            };
            // Make the request
            Operation<Backup, CopyBackupMetadata> response = bigtableTableAdminClient.CopyBackup(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CopyBackupMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CopyBackupMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceCopyBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CopyBackupAsync</summary>
        public async Task CopyBackupRequestObjectAsync()
        {
            // Snippet: CopyBackupAsync(CopyBackupRequest, CallSettings)
            // Additional: CopyBackupAsync(CopyBackupRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            CopyBackupRequest request = new CopyBackupRequest
            {
                ParentAsClusterName = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                BackupId = "",
                SourceBackupAsBackupName = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]"),
                ExpireTime = new Timestamp(),
            };
            // Make the request
            Operation<Backup, CopyBackupMetadata> response = await bigtableTableAdminClient.CopyBackupAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CopyBackupMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CopyBackupMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceCopyBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CopyBackup</summary>
        public void CopyBackup()
        {
            // Snippet: CopyBackup(string, string, string, Timestamp, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            string backupId = "";
            string sourceBackup = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]/backups/[BACKUP]";
            Timestamp expireTime = new Timestamp();
            // Make the request
            Operation<Backup, CopyBackupMetadata> response = bigtableTableAdminClient.CopyBackup(parent, backupId, sourceBackup, expireTime);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CopyBackupMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CopyBackupMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceCopyBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CopyBackupAsync</summary>
        public async Task CopyBackupAsync()
        {
            // Snippet: CopyBackupAsync(string, string, string, Timestamp, CallSettings)
            // Additional: CopyBackupAsync(string, string, string, Timestamp, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]";
            string backupId = "";
            string sourceBackup = "projects/[PROJECT]/instances/[INSTANCE]/clusters/[CLUSTER]/backups/[BACKUP]";
            Timestamp expireTime = new Timestamp();
            // Make the request
            Operation<Backup, CopyBackupMetadata> response = await bigtableTableAdminClient.CopyBackupAsync(parent, backupId, sourceBackup, expireTime);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CopyBackupMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CopyBackupMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceCopyBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CopyBackup</summary>
        public void CopyBackupResourceNames()
        {
            // Snippet: CopyBackup(ClusterName, string, BackupName, Timestamp, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            string backupId = "";
            BackupName sourceBackup = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]");
            Timestamp expireTime = new Timestamp();
            // Make the request
            Operation<Backup, CopyBackupMetadata> response = bigtableTableAdminClient.CopyBackup(parent, backupId, sourceBackup, expireTime);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CopyBackupMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CopyBackupMetadata> retrievedResponse = bigtableTableAdminClient.PollOnceCopyBackup(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CopyBackupAsync</summary>
        public async Task CopyBackupResourceNamesAsync()
        {
            // Snippet: CopyBackupAsync(ClusterName, string, BackupName, Timestamp, CallSettings)
            // Additional: CopyBackupAsync(ClusterName, string, BackupName, Timestamp, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = ClusterName.FromProjectInstanceCluster("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            string backupId = "";
            BackupName sourceBackup = BackupName.FromProjectInstanceClusterBackup("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[BACKUP]");
            Timestamp expireTime = new Timestamp();
            // Make the request
            Operation<Backup, CopyBackupMetadata> response = await bigtableTableAdminClient.CopyBackupAsync(parent, backupId, sourceBackup, expireTime);

            // Poll until the returned long-running operation is complete
            Operation<Backup, CopyBackupMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Backup result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Backup, CopyBackupMetadata> retrievedResponse = await bigtableTableAdminClient.PollOnceCopyBackupAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Backup retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyRequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = bigtableTableAdminClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyRequestObjectAsync()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest, CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Options = new GetPolicyOptions(),
            };
            // Make the request
            Policy response = await bigtableTableAdminClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = bigtableTableAdminClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string, CallSettings)
            // Additional: GetIamPolicyAsync(string, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            // Make the request
            Policy response = await bigtableTableAdminClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicyResourceNames()
        {
            // Snippet: GetIamPolicy(IResourceName, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = bigtableTableAdminClient.GetIamPolicy(resource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyResourceNamesAsync()
        {
            // Snippet: GetIamPolicyAsync(IResourceName, CallSettings)
            // Additional: GetIamPolicyAsync(IResourceName, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            // Make the request
            Policy response = await bigtableTableAdminClient.GetIamPolicyAsync(resource);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyRequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = bigtableTableAdminClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyRequestObjectAsync()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest, CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Policy = new Policy(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Policy response = await bigtableTableAdminClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string, Policy, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = bigtableTableAdminClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(string, Policy, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            Policy policy = new Policy();
            // Make the request
            Policy response = await bigtableTableAdminClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicyResourceNames()
        {
            // Snippet: SetIamPolicy(IResourceName, Policy, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = bigtableTableAdminClient.SetIamPolicy(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyResourceNamesAsync()
        {
            // Snippet: SetIamPolicyAsync(IResourceName, Policy, CallSettings)
            // Additional: SetIamPolicyAsync(IResourceName, Policy, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            Policy policy = new Policy();
            // Make the request
            Policy response = await bigtableTableAdminClient.SetIamPolicyAsync(resource, policy);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsRequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = bigtableTableAdminClient.TestIamPermissions(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsRequestObjectAsync()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest, CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                ResourceAsResourceName = new UnparsedResourceName("a/wildcard/resource"),
                Permissions = { "", },
            };
            // Make the request
            TestIamPermissionsResponse response = await bigtableTableAdminClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string, IEnumerable<string>, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = bigtableTableAdminClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(string, IEnumerable<string>, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string resource = "a/wildcard/resource";
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await bigtableTableAdminClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissionsResourceNames()
        {
            // Snippet: TestIamPermissions(IResourceName, IEnumerable<string>, CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = bigtableTableAdminClient.TestIamPermissions(resource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsResourceNamesAsync()
        {
            // Snippet: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CallSettings)
            // Additional: TestIamPermissionsAsync(IResourceName, IEnumerable<string>, CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            IResourceName resource = new UnparsedResourceName("a/wildcard/resource");
            IEnumerable<string> permissions = new string[] { "", };
            // Make the request
            TestIamPermissionsResponse response = await bigtableTableAdminClient.TestIamPermissionsAsync(resource, permissions);
            // End snippet
        }
    }
}
