// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Bigtable.Admin.V2;
using Google.LongRunning;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Bigtable.Admin.V2.Snippets
{
    /// <summary>Generated snippets</summary>
    public class GeneratedBigtableTableAdminClientSnippets
    {
        /// <summary>Snippet for CreateTableAsync</summary>
        public async Task CreateTableAsync()
        {
            // Snippet: CreateTableAsync(InstanceName,string,Table,CallSettings)
            // Additional: CreateTableAsync(InstanceName,string,Table,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string tableId = "";
            Table table = new Table();
            // Make the request
            Table response = await bigtableTableAdminClient.CreateTableAsync(parent, tableId, table);
            // End snippet
        }

        /// <summary>Snippet for CreateTable</summary>
        public void CreateTable()
        {
            // Snippet: CreateTable(InstanceName,string,Table,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string tableId = "";
            Table table = new Table();
            // Make the request
            Table response = bigtableTableAdminClient.CreateTable(parent, tableId, table);
            // End snippet
        }

        /// <summary>Snippet for CreateTableAsync</summary>
        public async Task CreateTableAsync_RequestObject()
        {
            // Snippet: CreateTableAsync(CreateTableRequest,CallSettings)
            // Additional: CreateTableAsync(CreateTableRequest,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateTableRequest request = new CreateTableRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                TableId = "",
                Table = new Table(),
            };
            // Make the request
            Table response = await bigtableTableAdminClient.CreateTableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTable</summary>
        public void CreateTable_RequestObject()
        {
            // Snippet: CreateTable(CreateTableRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            CreateTableRequest request = new CreateTableRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                TableId = "",
                Table = new Table(),
            };
            // Make the request
            Table response = bigtableTableAdminClient.CreateTable(request);
            // End snippet
        }

        /// <summary>Snippet for CreateTableFromSnapshotAsync</summary>
        public async Task CreateTableFromSnapshotAsync()
        {
            // Snippet: CreateTableFromSnapshotAsync(InstanceName,string,SnapshotName,CallSettings)
            // Additional: CreateTableFromSnapshotAsync(InstanceName,string,SnapshotName,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string tableId = "";
            SnapshotName sourceSnapshot = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            // Make the request
            Operation<Table, CreateTableFromSnapshotMetadata> response =
                await bigtableTableAdminClient.CreateTableFromSnapshotAsync(parent, tableId, sourceSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<Table, CreateTableFromSnapshotMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, CreateTableFromSnapshotMetadata> retrievedResponse =
                await bigtableTableAdminClient.PollOnceCreateTableFromSnapshotAsync(operationName);
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
            // Snippet: CreateTableFromSnapshot(InstanceName,string,SnapshotName,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            string tableId = "";
            SnapshotName sourceSnapshot = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            // Make the request
            Operation<Table, CreateTableFromSnapshotMetadata> response =
                bigtableTableAdminClient.CreateTableFromSnapshot(parent, tableId, sourceSnapshot);

            // Poll until the returned long-running operation is complete
            Operation<Table, CreateTableFromSnapshotMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, CreateTableFromSnapshotMetadata> retrievedResponse =
                bigtableTableAdminClient.PollOnceCreateTableFromSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTableFromSnapshotAsync</summary>
        public async Task CreateTableFromSnapshotAsync_RequestObject()
        {
            // Snippet: CreateTableFromSnapshotAsync(CreateTableFromSnapshotRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            CreateTableFromSnapshotRequest request = new CreateTableFromSnapshotRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                TableId = "",
                SourceSnapshotAsSnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            // Make the request
            Operation<Table, CreateTableFromSnapshotMetadata> response =
                await bigtableTableAdminClient.CreateTableFromSnapshotAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Table, CreateTableFromSnapshotMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, CreateTableFromSnapshotMetadata> retrievedResponse =
                await bigtableTableAdminClient.PollOnceCreateTableFromSnapshotAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateTableFromSnapshot</summary>
        public void CreateTableFromSnapshot_RequestObject()
        {
            // Snippet: CreateTableFromSnapshot(CreateTableFromSnapshotRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            CreateTableFromSnapshotRequest request = new CreateTableFromSnapshotRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
                TableId = "",
                SourceSnapshotAsSnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            // Make the request
            Operation<Table, CreateTableFromSnapshotMetadata> response =
                bigtableTableAdminClient.CreateTableFromSnapshot(request);

            // Poll until the returned long-running operation is complete
            Operation<Table, CreateTableFromSnapshotMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Table result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Table, CreateTableFromSnapshotMetadata> retrievedResponse =
                bigtableTableAdminClient.PollOnceCreateTableFromSnapshot(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Table retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ListTablesAsync</summary>
        public async Task ListTablesAsync()
        {
            // Snippet: ListTablesAsync(InstanceName,string,int?,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListTablesResponse, Table> response =
                bigtableTableAdminClient.ListTablesAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTables</summary>
        public void ListTables()
        {
            // Snippet: ListTables(InstanceName,string,int?,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            InstanceName parent = new InstanceName("[PROJECT]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListTablesResponse, Table> response =
                bigtableTableAdminClient.ListTables(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTablesAsync</summary>
        public async Task ListTablesAsync_RequestObject()
        {
            // Snippet: ListTablesAsync(ListTablesRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListTablesRequest request = new ListTablesRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListTablesResponse, Table> response =
                bigtableTableAdminClient.ListTablesAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListTables</summary>
        public void ListTables_RequestObject()
        {
            // Snippet: ListTables(ListTablesRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ListTablesRequest request = new ListTablesRequest
            {
                ParentAsInstanceName = new InstanceName("[PROJECT]", "[INSTANCE]"),
            };
            // Make the request
            PagedEnumerable<ListTablesResponse, Table> response =
                bigtableTableAdminClient.ListTables(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetTableAsync</summary>
        public async Task GetTableAsync()
        {
            // Snippet: GetTableAsync(TableName,CallSettings)
            // Additional: GetTableAsync(TableName,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            Table response = await bigtableTableAdminClient.GetTableAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTable</summary>
        public void GetTable()
        {
            // Snippet: GetTable(TableName,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            Table response = bigtableTableAdminClient.GetTable(name);
            // End snippet
        }

        /// <summary>Snippet for GetTableAsync</summary>
        public async Task GetTableAsync_RequestObject()
        {
            // Snippet: GetTableAsync(GetTableRequest,CallSettings)
            // Additional: GetTableAsync(GetTableRequest,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetTableRequest request = new GetTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            Table response = await bigtableTableAdminClient.GetTableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTable</summary>
        public void GetTable_RequestObject()
        {
            // Snippet: GetTable(GetTableRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            GetTableRequest request = new GetTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            Table response = bigtableTableAdminClient.GetTable(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTableAsync</summary>
        public async Task DeleteTableAsync()
        {
            // Snippet: DeleteTableAsync(TableName,CallSettings)
            // Additional: DeleteTableAsync(TableName,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            await bigtableTableAdminClient.DeleteTableAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTable</summary>
        public void DeleteTable()
        {
            // Snippet: DeleteTable(TableName,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            bigtableTableAdminClient.DeleteTable(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteTableAsync</summary>
        public async Task DeleteTableAsync_RequestObject()
        {
            // Snippet: DeleteTableAsync(DeleteTableRequest,CallSettings)
            // Additional: DeleteTableAsync(DeleteTableRequest,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteTableRequest request = new DeleteTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            await bigtableTableAdminClient.DeleteTableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteTable</summary>
        public void DeleteTable_RequestObject()
        {
            // Snippet: DeleteTable(DeleteTableRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            DeleteTableRequest request = new DeleteTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            bigtableTableAdminClient.DeleteTable(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyColumnFamiliesAsync</summary>
        public async Task ModifyColumnFamiliesAsync()
        {
            // Snippet: ModifyColumnFamiliesAsync(TableName,IEnumerable<ModifyColumnFamiliesRequest.Types.Modification>,CallSettings)
            // Additional: ModifyColumnFamiliesAsync(TableName,IEnumerable<ModifyColumnFamiliesRequest.Types.Modification>,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications = new List<ModifyColumnFamiliesRequest.Types.Modification>();
            // Make the request
            Table response = await bigtableTableAdminClient.ModifyColumnFamiliesAsync(name, modifications);
            // End snippet
        }

        /// <summary>Snippet for ModifyColumnFamilies</summary>
        public void ModifyColumnFamilies()
        {
            // Snippet: ModifyColumnFamilies(TableName,IEnumerable<ModifyColumnFamiliesRequest.Types.Modification>,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            IEnumerable<ModifyColumnFamiliesRequest.Types.Modification> modifications = new List<ModifyColumnFamiliesRequest.Types.Modification>();
            // Make the request
            Table response = bigtableTableAdminClient.ModifyColumnFamilies(name, modifications);
            // End snippet
        }

        /// <summary>Snippet for ModifyColumnFamiliesAsync</summary>
        public async Task ModifyColumnFamiliesAsync_RequestObject()
        {
            // Snippet: ModifyColumnFamiliesAsync(ModifyColumnFamiliesRequest,CallSettings)
            // Additional: ModifyColumnFamiliesAsync(ModifyColumnFamiliesRequest,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ModifyColumnFamiliesRequest request = new ModifyColumnFamiliesRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications = { },
            };
            // Make the request
            Table response = await bigtableTableAdminClient.ModifyColumnFamiliesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ModifyColumnFamilies</summary>
        public void ModifyColumnFamilies_RequestObject()
        {
            // Snippet: ModifyColumnFamilies(ModifyColumnFamiliesRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ModifyColumnFamiliesRequest request = new ModifyColumnFamiliesRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                Modifications = { },
            };
            // Make the request
            Table response = bigtableTableAdminClient.ModifyColumnFamilies(request);
            // End snippet
        }

        /// <summary>Snippet for DropRowRangeAsync</summary>
        public async Task DropRowRangeAsync_RequestObject()
        {
            // Snippet: DropRowRangeAsync(DropRowRangeRequest,CallSettings)
            // Additional: DropRowRangeAsync(DropRowRangeRequest,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            DropRowRangeRequest request = new DropRowRangeRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            await bigtableTableAdminClient.DropRowRangeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DropRowRange</summary>
        public void DropRowRange_RequestObject()
        {
            // Snippet: DropRowRange(DropRowRangeRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            DropRowRangeRequest request = new DropRowRangeRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            bigtableTableAdminClient.DropRowRange(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateConsistencyTokenAsync</summary>
        public async Task GenerateConsistencyTokenAsync()
        {
            // Snippet: GenerateConsistencyTokenAsync(TableName,CallSettings)
            // Additional: GenerateConsistencyTokenAsync(TableName,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            GenerateConsistencyTokenResponse response = await bigtableTableAdminClient.GenerateConsistencyTokenAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateConsistencyToken</summary>
        public void GenerateConsistencyToken()
        {
            // Snippet: GenerateConsistencyToken(TableName,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            // Make the request
            GenerateConsistencyTokenResponse response = bigtableTableAdminClient.GenerateConsistencyToken(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateConsistencyTokenAsync</summary>
        public async Task GenerateConsistencyTokenAsync_RequestObject()
        {
            // Snippet: GenerateConsistencyTokenAsync(GenerateConsistencyTokenRequest,CallSettings)
            // Additional: GenerateConsistencyTokenAsync(GenerateConsistencyTokenRequest,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            GenerateConsistencyTokenRequest request = new GenerateConsistencyTokenRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            GenerateConsistencyTokenResponse response = await bigtableTableAdminClient.GenerateConsistencyTokenAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateConsistencyToken</summary>
        public void GenerateConsistencyToken_RequestObject()
        {
            // Snippet: GenerateConsistencyToken(GenerateConsistencyTokenRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            GenerateConsistencyTokenRequest request = new GenerateConsistencyTokenRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
            };
            // Make the request
            GenerateConsistencyTokenResponse response = bigtableTableAdminClient.GenerateConsistencyToken(request);
            // End snippet
        }

        /// <summary>Snippet for CheckConsistencyAsync</summary>
        public async Task CheckConsistencyAsync()
        {
            // Snippet: CheckConsistencyAsync(TableName,string,CallSettings)
            // Additional: CheckConsistencyAsync(TableName,string,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string consistencyToken = "";
            // Make the request
            CheckConsistencyResponse response = await bigtableTableAdminClient.CheckConsistencyAsync(name, consistencyToken);
            // End snippet
        }

        /// <summary>Snippet for CheckConsistency</summary>
        public void CheckConsistency()
        {
            // Snippet: CheckConsistency(TableName,string,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            string consistencyToken = "";
            // Make the request
            CheckConsistencyResponse response = bigtableTableAdminClient.CheckConsistency(name, consistencyToken);
            // End snippet
        }

        /// <summary>Snippet for CheckConsistencyAsync</summary>
        public async Task CheckConsistencyAsync_RequestObject()
        {
            // Snippet: CheckConsistencyAsync(CheckConsistencyRequest,CallSettings)
            // Additional: CheckConsistencyAsync(CheckConsistencyRequest,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            CheckConsistencyRequest request = new CheckConsistencyRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "",
            };
            // Make the request
            CheckConsistencyResponse response = await bigtableTableAdminClient.CheckConsistencyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CheckConsistency</summary>
        public void CheckConsistency_RequestObject()
        {
            // Snippet: CheckConsistency(CheckConsistencyRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            CheckConsistencyRequest request = new CheckConsistencyRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ConsistencyToken = "",
            };
            // Make the request
            CheckConsistencyResponse response = bigtableTableAdminClient.CheckConsistency(request);
            // End snippet
        }

        /// <summary>Snippet for SnapshotTableAsync</summary>
        public async Task SnapshotTableAsync()
        {
            // Snippet: SnapshotTableAsync(TableName,ClusterName,SnapshotName,string,CallSettings)
            // Additional: SnapshotTableAsync(TableName,ClusterName,SnapshotName,string,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ClusterName cluster = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            SnapshotName snapshotId = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            string description = "";
            // Make the request
            Operation<Snapshot, SnapshotTableMetadata> response =
                await bigtableTableAdminClient.SnapshotTableAsync(name, cluster, snapshotId, description);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, SnapshotTableMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, SnapshotTableMetadata> retrievedResponse =
                await bigtableTableAdminClient.PollOnceSnapshotTableAsync(operationName);
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
            // Snippet: SnapshotTable(TableName,ClusterName,SnapshotName,string,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TableName name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]");
            ClusterName cluster = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            SnapshotName snapshotId = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            string description = "";
            // Make the request
            Operation<Snapshot, SnapshotTableMetadata> response =
                bigtableTableAdminClient.SnapshotTable(name, cluster, snapshotId, description);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, SnapshotTableMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, SnapshotTableMetadata> retrievedResponse =
                bigtableTableAdminClient.PollOnceSnapshotTable(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SnapshotTableAsync</summary>
        public async Task SnapshotTableAsync_RequestObject()
        {
            // Snippet: SnapshotTableAsync(SnapshotTableRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotTableRequest request = new SnapshotTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterAsClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                SnapshotIdAsSnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
                Description = "",
            };
            // Make the request
            Operation<Snapshot, SnapshotTableMetadata> response =
                await bigtableTableAdminClient.SnapshotTableAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, SnapshotTableMetadata> completedResponse =
                await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, SnapshotTableMetadata> retrievedResponse =
                await bigtableTableAdminClient.PollOnceSnapshotTableAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for SnapshotTable</summary>
        public void SnapshotTable_RequestObject()
        {
            // Snippet: SnapshotTable(SnapshotTableRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            SnapshotTableRequest request = new SnapshotTableRequest
            {
                TableName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]"),
                ClusterAsClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
                SnapshotIdAsSnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
                Description = "",
            };
            // Make the request
            Operation<Snapshot, SnapshotTableMetadata> response =
                bigtableTableAdminClient.SnapshotTable(request);

            // Poll until the returned long-running operation is complete
            Operation<Snapshot, SnapshotTableMetadata> completedResponse =
                response.PollUntilCompleted();
            // Retrieve the operation result
            Snapshot result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Snapshot, SnapshotTableMetadata> retrievedResponse =
                bigtableTableAdminClient.PollOnceSnapshotTable(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Snapshot retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotAsync</summary>
        public async Task GetSnapshotAsync()
        {
            // Snippet: GetSnapshotAsync(SnapshotName,CallSettings)
            // Additional: GetSnapshotAsync(SnapshotName,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName name = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            // Make the request
            Snapshot response = await bigtableTableAdminClient.GetSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshot</summary>
        public void GetSnapshot()
        {
            // Snippet: GetSnapshot(SnapshotName,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            SnapshotName name = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            // Make the request
            Snapshot response = bigtableTableAdminClient.GetSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshotAsync</summary>
        public async Task GetSnapshotAsync_RequestObject()
        {
            // Snippet: GetSnapshotAsync(GetSnapshotRequest,CallSettings)
            // Additional: GetSnapshotAsync(GetSnapshotRequest,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            // Make the request
            Snapshot response = await bigtableTableAdminClient.GetSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetSnapshot</summary>
        public void GetSnapshot_RequestObject()
        {
            // Snippet: GetSnapshot(GetSnapshotRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            // Make the request
            Snapshot response = bigtableTableAdminClient.GetSnapshot(request);
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsAsync()
        {
            // Snippet: ListSnapshotsAsync(ClusterName,string,int?,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ClusterName parent = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response =
                bigtableTableAdminClient.ListSnapshotsAsync(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshots()
        {
            // Snippet: ListSnapshots(ClusterName,string,int?,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ClusterName parent = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]");
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response =
                bigtableTableAdminClient.ListSnapshots(parent);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshotsAsync</summary>
        public async Task ListSnapshotsAsync_RequestObject()
        {
            // Snippet: ListSnapshotsAsync(ListSnapshotsRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ParentAsClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListSnapshotsResponse, Snapshot> response =
                bigtableTableAdminClient.ListSnapshotsAsync(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListSnapshots</summary>
        public void ListSnapshots_RequestObject()
        {
            // Snippet: ListSnapshots(ListSnapshotsRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            ListSnapshotsRequest request = new ListSnapshotsRequest
            {
                ParentAsClusterName = new ClusterName("[PROJECT]", "[INSTANCE]", "[CLUSTER]"),
            };
            // Make the request
            PagedEnumerable<ListSnapshotsResponse, Snapshot> response =
                bigtableTableAdminClient.ListSnapshots(request);

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
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotAsync()
        {
            // Snippet: DeleteSnapshotAsync(SnapshotName,CallSettings)
            // Additional: DeleteSnapshotAsync(SnapshotName,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            SnapshotName name = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            // Make the request
            await bigtableTableAdminClient.DeleteSnapshotAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshot()
        {
            // Snippet: DeleteSnapshot(SnapshotName,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            SnapshotName name = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]");
            // Make the request
            bigtableTableAdminClient.DeleteSnapshot(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshotAsync</summary>
        public async Task DeleteSnapshotAsync_RequestObject()
        {
            // Snippet: DeleteSnapshotAsync(DeleteSnapshotRequest,CallSettings)
            // Additional: DeleteSnapshotAsync(DeleteSnapshotRequest,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            // Make the request
            await bigtableTableAdminClient.DeleteSnapshotAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteSnapshot</summary>
        public void DeleteSnapshot_RequestObject()
        {
            // Snippet: DeleteSnapshot(DeleteSnapshotRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            DeleteSnapshotRequest request = new DeleteSnapshotRequest
            {
                SnapshotName = new SnapshotName("[PROJECT]", "[INSTANCE]", "[CLUSTER]", "[SNAPSHOT]"),
            };
            // Make the request
            bigtableTableAdminClient.DeleteSnapshot(request);
            // End snippet
        }

    }
}
