// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
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
    public class GeneratedBigtableTableAdminClientSnippets
    {
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

        public async Task CreateTableAsync_RequestObject()
        {
            // Snippet: CreateTableAsync(CreateTableRequest,CallSettings)
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

        public async Task GetTableAsync_RequestObject()
        {
            // Snippet: GetTableAsync(GetTableRequest,CallSettings)
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

        public async Task DeleteTableAsync_RequestObject()
        {
            // Snippet: DeleteTableAsync(DeleteTableRequest,CallSettings)
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

        public async Task ModifyColumnFamiliesAsync_RequestObject()
        {
            // Snippet: ModifyColumnFamiliesAsync(ModifyColumnFamiliesRequest,CallSettings)
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

        public async Task DropRowRangeAsync()
        {
            // Snippet: DropRowRangeAsync(string,ByteString,CallSettings)
            // Additional: DropRowRangeAsync(string,ByteString,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            ByteString rowKeyPrefix = ByteString.CopyFromUtf8("");
            // Make the request
            await bigtableTableAdminClient.DropRowRangeAsync(formattedName, rowKeyPrefix);
            // End snippet
        }

        public void DropRowRange()
        {
            // Snippet: DropRowRange(string,ByteString,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string formattedName = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            ByteString rowKeyPrefix = ByteString.CopyFromUtf8("");
            // Make the request
            bigtableTableAdminClient.DropRowRange(formattedName, rowKeyPrefix);
            // End snippet
        }

        public async Task DropRowRangeAsync_RequestObject()
        {
            // Snippet: DropRowRangeAsync(DropRowRangeRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            DropRowRangeRequest request = new DropRowRangeRequest
            {
                Name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
            };
            // Make the request
            await bigtableTableAdminClient.DropRowRangeAsync(request);
            // End snippet
        }

        public void DropRowRange_RequestObject()
        {
            // Snippet: DropRowRange(DropRowRangeRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            DropRowRangeRequest request = new DropRowRangeRequest
            {
                Name = new TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
            };
            // Make the request
            bigtableTableAdminClient.DropRowRange(request);
            // End snippet
        }

    }
}
