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
    using Google.Area120.Tables.V1Alpha1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedTablesServiceClientSnippets
    {
        /// <summary>Snippet for GetTable</summary>
        public void GetTableRequestObject()
        {
            // Snippet: GetTable(GetTableRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            GetTableRequest request = new GetTableRequest
            {
                TableName = TableName.FromTable("[TABLE]"),
            };
            // Make the request
            Table response = tablesServiceClient.GetTable(request);
            // End snippet
        }

        /// <summary>Snippet for GetTableAsync</summary>
        public async Task GetTableRequestObjectAsync()
        {
            // Snippet: GetTableAsync(GetTableRequest, CallSettings)
            // Additional: GetTableAsync(GetTableRequest, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetTableRequest request = new GetTableRequest
            {
                TableName = TableName.FromTable("[TABLE]"),
            };
            // Make the request
            Table response = await tablesServiceClient.GetTableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetTable</summary>
        public void GetTable()
        {
            // Snippet: GetTable(string, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            string name = "tables/[TABLE]";
            // Make the request
            Table response = tablesServiceClient.GetTable(name);
            // End snippet
        }

        /// <summary>Snippet for GetTableAsync</summary>
        public async Task GetTableAsync()
        {
            // Snippet: GetTableAsync(string, CallSettings)
            // Additional: GetTableAsync(string, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "tables/[TABLE]";
            // Make the request
            Table response = await tablesServiceClient.GetTableAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetTable</summary>
        public void GetTableResourceNames()
        {
            // Snippet: GetTable(TableName, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            TableName name = TableName.FromTable("[TABLE]");
            // Make the request
            Table response = tablesServiceClient.GetTable(name);
            // End snippet
        }

        /// <summary>Snippet for GetTableAsync</summary>
        public async Task GetTableResourceNamesAsync()
        {
            // Snippet: GetTableAsync(TableName, CallSettings)
            // Additional: GetTableAsync(TableName, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            TableName name = TableName.FromTable("[TABLE]");
            // Make the request
            Table response = await tablesServiceClient.GetTableAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListTables</summary>
        public void ListTablesRequestObject()
        {
            // Snippet: ListTables(ListTablesRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            ListTablesRequest request = new ListTablesRequest { };
            // Make the request
            PagedEnumerable<ListTablesResponse, Table> response = tablesServiceClient.ListTables(request);

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
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListTablesRequest request = new ListTablesRequest { };
            // Make the request
            PagedAsyncEnumerable<ListTablesResponse, Table> response = tablesServiceClient.ListTablesAsync(request);

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

        /// <summary>Snippet for GetWorkspace</summary>
        public void GetWorkspaceRequestObject()
        {
            // Snippet: GetWorkspace(GetWorkspaceRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
            };
            // Make the request
            Workspace response = tablesServiceClient.GetWorkspace(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspaceAsync</summary>
        public async Task GetWorkspaceRequestObjectAsync()
        {
            // Snippet: GetWorkspaceAsync(GetWorkspaceRequest, CallSettings)
            // Additional: GetWorkspaceAsync(GetWorkspaceRequest, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetWorkspaceRequest request = new GetWorkspaceRequest
            {
                WorkspaceName = WorkspaceName.FromWorkspace("[WORKSPACE]"),
            };
            // Make the request
            Workspace response = await tablesServiceClient.GetWorkspaceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspace</summary>
        public void GetWorkspace()
        {
            // Snippet: GetWorkspace(string, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            string name = "workspaces/[WORKSPACE]";
            // Make the request
            Workspace response = tablesServiceClient.GetWorkspace(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspaceAsync</summary>
        public async Task GetWorkspaceAsync()
        {
            // Snippet: GetWorkspaceAsync(string, CallSettings)
            // Additional: GetWorkspaceAsync(string, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "workspaces/[WORKSPACE]";
            // Make the request
            Workspace response = await tablesServiceClient.GetWorkspaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspace</summary>
        public void GetWorkspaceResourceNames()
        {
            // Snippet: GetWorkspace(WorkspaceName, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            WorkspaceName name = WorkspaceName.FromWorkspace("[WORKSPACE]");
            // Make the request
            Workspace response = tablesServiceClient.GetWorkspace(name);
            // End snippet
        }

        /// <summary>Snippet for GetWorkspaceAsync</summary>
        public async Task GetWorkspaceResourceNamesAsync()
        {
            // Snippet: GetWorkspaceAsync(WorkspaceName, CallSettings)
            // Additional: GetWorkspaceAsync(WorkspaceName, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            WorkspaceName name = WorkspaceName.FromWorkspace("[WORKSPACE]");
            // Make the request
            Workspace response = await tablesServiceClient.GetWorkspaceAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListWorkspaces</summary>
        public void ListWorkspacesRequestObject()
        {
            // Snippet: ListWorkspaces(ListWorkspacesRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            ListWorkspacesRequest request = new ListWorkspacesRequest { };
            // Make the request
            PagedEnumerable<ListWorkspacesResponse, Workspace> response = tablesServiceClient.ListWorkspaces(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Workspace item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListWorkspacesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workspace> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListWorkspacesAsync</summary>
        public async Task ListWorkspacesRequestObjectAsync()
        {
            // Snippet: ListWorkspacesAsync(ListWorkspacesRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListWorkspacesRequest request = new ListWorkspacesRequest { };
            // Make the request
            PagedAsyncEnumerable<ListWorkspacesResponse, Workspace> response = tablesServiceClient.ListWorkspacesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Workspace item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListWorkspacesResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Workspace item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Workspace> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Workspace item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetRow</summary>
        public void GetRowRequestObject()
        {
            // Snippet: GetRow(GetRowRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            GetRowRequest request = new GetRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                View = View.Unspecified,
            };
            // Make the request
            Row response = tablesServiceClient.GetRow(request);
            // End snippet
        }

        /// <summary>Snippet for GetRowAsync</summary>
        public async Task GetRowRequestObjectAsync()
        {
            // Snippet: GetRowAsync(GetRowRequest, CallSettings)
            // Additional: GetRowAsync(GetRowRequest, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetRowRequest request = new GetRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
                View = View.Unspecified,
            };
            // Make the request
            Row response = await tablesServiceClient.GetRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetRow</summary>
        public void GetRow()
        {
            // Snippet: GetRow(string, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            string name = "tables/[TABLE]/rows/[ROW]";
            // Make the request
            Row response = tablesServiceClient.GetRow(name);
            // End snippet
        }

        /// <summary>Snippet for GetRowAsync</summary>
        public async Task GetRowAsync()
        {
            // Snippet: GetRowAsync(string, CallSettings)
            // Additional: GetRowAsync(string, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "tables/[TABLE]/rows/[ROW]";
            // Make the request
            Row response = await tablesServiceClient.GetRowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetRow</summary>
        public void GetRowResourceNames()
        {
            // Snippet: GetRow(RowName, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            RowName name = RowName.FromTableRow("[TABLE]", "[ROW]");
            // Make the request
            Row response = tablesServiceClient.GetRow(name);
            // End snippet
        }

        /// <summary>Snippet for GetRowAsync</summary>
        public async Task GetRowResourceNamesAsync()
        {
            // Snippet: GetRowAsync(RowName, CallSettings)
            // Additional: GetRowAsync(RowName, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            RowName name = RowName.FromTableRow("[TABLE]", "[ROW]");
            // Make the request
            Row response = await tablesServiceClient.GetRowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListRows</summary>
        public void ListRowsRequestObject()
        {
            // Snippet: ListRows(ListRowsRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            ListRowsRequest request = new ListRowsRequest
            {
                Parent = "",
                View = View.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListRowsResponse, Row> response = tablesServiceClient.ListRows(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Row item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Row item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Row> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Row item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRowsAsync</summary>
        public async Task ListRowsRequestObjectAsync()
        {
            // Snippet: ListRowsAsync(ListRowsRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListRowsRequest request = new ListRowsRequest
            {
                Parent = "",
                View = View.Unspecified,
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListRowsResponse, Row> response = tablesServiceClient.ListRowsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Row item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Row item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Row> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Row item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRows</summary>
        public void ListRows()
        {
            // Snippet: ListRows(string, string, int?, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedEnumerable<ListRowsResponse, Row> response = tablesServiceClient.ListRows(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Row item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListRowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Row item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Row> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Row item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListRowsAsync</summary>
        public async Task ListRowsAsync()
        {
            // Snippet: ListRowsAsync(string, string, int?, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            // Make the request
            PagedAsyncEnumerable<ListRowsResponse, Row> response = tablesServiceClient.ListRowsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Row item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListRowsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Row item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Row> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Row item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for CreateRow</summary>
        public void CreateRowRequestObject()
        {
            // Snippet: CreateRow(CreateRowRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            CreateRowRequest request = new CreateRowRequest
            {
                Parent = "",
                Row = new Row(),
                View = View.Unspecified,
            };
            // Make the request
            Row response = tablesServiceClient.CreateRow(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRowAsync</summary>
        public async Task CreateRowRequestObjectAsync()
        {
            // Snippet: CreateRowAsync(CreateRowRequest, CallSettings)
            // Additional: CreateRowAsync(CreateRowRequest, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateRowRequest request = new CreateRowRequest
            {
                Parent = "",
                Row = new Row(),
                View = View.Unspecified,
            };
            // Make the request
            Row response = await tablesServiceClient.CreateRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateRow</summary>
        public void CreateRow()
        {
            // Snippet: CreateRow(string, Row, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            string parent = "";
            Row row = new Row();
            // Make the request
            Row response = tablesServiceClient.CreateRow(parent, row);
            // End snippet
        }

        /// <summary>Snippet for CreateRowAsync</summary>
        public async Task CreateRowAsync()
        {
            // Snippet: CreateRowAsync(string, Row, CallSettings)
            // Additional: CreateRowAsync(string, Row, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "";
            Row row = new Row();
            // Make the request
            Row response = await tablesServiceClient.CreateRowAsync(parent, row);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRows</summary>
        public void BatchCreateRowsRequestObject()
        {
            // Snippet: BatchCreateRows(BatchCreateRowsRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            BatchCreateRowsRequest request = new BatchCreateRowsRequest
            {
                Parent = "",
                Requests =
                {
                    new CreateRowRequest(),
                },
            };
            // Make the request
            BatchCreateRowsResponse response = tablesServiceClient.BatchCreateRows(request);
            // End snippet
        }

        /// <summary>Snippet for BatchCreateRowsAsync</summary>
        public async Task BatchCreateRowsRequestObjectAsync()
        {
            // Snippet: BatchCreateRowsAsync(BatchCreateRowsRequest, CallSettings)
            // Additional: BatchCreateRowsAsync(BatchCreateRowsRequest, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchCreateRowsRequest request = new BatchCreateRowsRequest
            {
                Parent = "",
                Requests =
                {
                    new CreateRowRequest(),
                },
            };
            // Make the request
            BatchCreateRowsResponse response = await tablesServiceClient.BatchCreateRowsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRow</summary>
        public void UpdateRowRequestObject()
        {
            // Snippet: UpdateRow(UpdateRowRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            UpdateRowRequest request = new UpdateRowRequest
            {
                Row = new Row(),
                UpdateMask = new FieldMask(),
                View = View.Unspecified,
            };
            // Make the request
            Row response = tablesServiceClient.UpdateRow(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRowAsync</summary>
        public async Task UpdateRowRequestObjectAsync()
        {
            // Snippet: UpdateRowAsync(UpdateRowRequest, CallSettings)
            // Additional: UpdateRowAsync(UpdateRowRequest, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateRowRequest request = new UpdateRowRequest
            {
                Row = new Row(),
                UpdateMask = new FieldMask(),
                View = View.Unspecified,
            };
            // Make the request
            Row response = await tablesServiceClient.UpdateRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateRow</summary>
        public void UpdateRow()
        {
            // Snippet: UpdateRow(Row, FieldMask, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            Row row = new Row();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Row response = tablesServiceClient.UpdateRow(row, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateRowAsync</summary>
        public async Task UpdateRowAsync()
        {
            // Snippet: UpdateRowAsync(Row, FieldMask, CallSettings)
            // Additional: UpdateRowAsync(Row, FieldMask, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            Row row = new Row();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Row response = await tablesServiceClient.UpdateRowAsync(row, updateMask);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateRows</summary>
        public void BatchUpdateRowsRequestObject()
        {
            // Snippet: BatchUpdateRows(BatchUpdateRowsRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            BatchUpdateRowsRequest request = new BatchUpdateRowsRequest
            {
                Parent = "",
                Requests =
                {
                    new UpdateRowRequest(),
                },
            };
            // Make the request
            BatchUpdateRowsResponse response = tablesServiceClient.BatchUpdateRows(request);
            // End snippet
        }

        /// <summary>Snippet for BatchUpdateRowsAsync</summary>
        public async Task BatchUpdateRowsRequestObjectAsync()
        {
            // Snippet: BatchUpdateRowsAsync(BatchUpdateRowsRequest, CallSettings)
            // Additional: BatchUpdateRowsAsync(BatchUpdateRowsRequest, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchUpdateRowsRequest request = new BatchUpdateRowsRequest
            {
                Parent = "",
                Requests =
                {
                    new UpdateRowRequest(),
                },
            };
            // Make the request
            BatchUpdateRowsResponse response = await tablesServiceClient.BatchUpdateRowsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRow</summary>
        public void DeleteRowRequestObject()
        {
            // Snippet: DeleteRow(DeleteRowRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            DeleteRowRequest request = new DeleteRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            // Make the request
            tablesServiceClient.DeleteRow(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRowAsync</summary>
        public async Task DeleteRowRequestObjectAsync()
        {
            // Snippet: DeleteRowAsync(DeleteRowRequest, CallSettings)
            // Additional: DeleteRowAsync(DeleteRowRequest, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteRowRequest request = new DeleteRowRequest
            {
                RowName = RowName.FromTableRow("[TABLE]", "[ROW]"),
            };
            // Make the request
            await tablesServiceClient.DeleteRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteRow</summary>
        public void DeleteRow()
        {
            // Snippet: DeleteRow(string, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            string name = "tables/[TABLE]/rows/[ROW]";
            // Make the request
            tablesServiceClient.DeleteRow(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRowAsync</summary>
        public async Task DeleteRowAsync()
        {
            // Snippet: DeleteRowAsync(string, CallSettings)
            // Additional: DeleteRowAsync(string, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "tables/[TABLE]/rows/[ROW]";
            // Make the request
            await tablesServiceClient.DeleteRowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRow</summary>
        public void DeleteRowResourceNames()
        {
            // Snippet: DeleteRow(RowName, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            RowName name = RowName.FromTableRow("[TABLE]", "[ROW]");
            // Make the request
            tablesServiceClient.DeleteRow(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteRowAsync</summary>
        public async Task DeleteRowResourceNamesAsync()
        {
            // Snippet: DeleteRowAsync(RowName, CallSettings)
            // Additional: DeleteRowAsync(RowName, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            RowName name = RowName.FromTableRow("[TABLE]", "[ROW]");
            // Make the request
            await tablesServiceClient.DeleteRowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteRows</summary>
        public void BatchDeleteRowsRequestObject()
        {
            // Snippet: BatchDeleteRows(BatchDeleteRowsRequest, CallSettings)
            // Create client
            TablesServiceClient tablesServiceClient = TablesServiceClient.Create();
            // Initialize request argument(s)
            BatchDeleteRowsRequest request = new BatchDeleteRowsRequest
            {
                ParentAsTableName = TableName.FromTable("[TABLE]"),
                RowNames =
                {
                    RowName.FromTableRow("[TABLE]", "[ROW]"),
                },
            };
            // Make the request
            tablesServiceClient.BatchDeleteRows(request);
            // End snippet
        }

        /// <summary>Snippet for BatchDeleteRowsAsync</summary>
        public async Task BatchDeleteRowsRequestObjectAsync()
        {
            // Snippet: BatchDeleteRowsAsync(BatchDeleteRowsRequest, CallSettings)
            // Additional: BatchDeleteRowsAsync(BatchDeleteRowsRequest, CancellationToken)
            // Create client
            TablesServiceClient tablesServiceClient = await TablesServiceClient.CreateAsync();
            // Initialize request argument(s)
            BatchDeleteRowsRequest request = new BatchDeleteRowsRequest
            {
                ParentAsTableName = TableName.FromTable("[TABLE]"),
                RowNames =
                {
                    RowName.FromTableRow("[TABLE]", "[ROW]"),
                },
            };
            // Make the request
            await tablesServiceClient.BatchDeleteRowsAsync(request);
            // End snippet
        }
    }
}
