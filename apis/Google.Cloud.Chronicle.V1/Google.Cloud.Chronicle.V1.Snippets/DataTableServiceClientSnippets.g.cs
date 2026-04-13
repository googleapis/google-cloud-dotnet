// Copyright 2026 Google LLC
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
    using Google.Cloud.Chronicle.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDataTableServiceClientSnippets
    {
        /// <summary>Snippet for CreateDataTable</summary>
        public void CreateDataTableRequestObject()
        {
            // Snippet: CreateDataTable(CreateDataTableRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            CreateDataTableRequest request = new CreateDataTableRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DataTable = new DataTable(),
                DataTableId = "",
            };
            // Make the request
            DataTable response = dataTableServiceClient.CreateDataTable(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataTableAsync</summary>
        public async Task CreateDataTableRequestObjectAsync()
        {
            // Snippet: CreateDataTableAsync(CreateDataTableRequest, CallSettings)
            // Additional: CreateDataTableAsync(CreateDataTableRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataTableRequest request = new CreateDataTableRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                DataTable = new DataTable(),
                DataTableId = "",
            };
            // Make the request
            DataTable response = await dataTableServiceClient.CreateDataTableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataTable</summary>
        public void CreateDataTable()
        {
            // Snippet: CreateDataTable(string, DataTable, string, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            DataTable dataTable = new DataTable();
            string dataTableId = "";
            // Make the request
            DataTable response = dataTableServiceClient.CreateDataTable(parent, dataTable, dataTableId);
            // End snippet
        }

        /// <summary>Snippet for CreateDataTableAsync</summary>
        public async Task CreateDataTableAsync()
        {
            // Snippet: CreateDataTableAsync(string, DataTable, string, CallSettings)
            // Additional: CreateDataTableAsync(string, DataTable, string, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            DataTable dataTable = new DataTable();
            string dataTableId = "";
            // Make the request
            DataTable response = await dataTableServiceClient.CreateDataTableAsync(parent, dataTable, dataTableId);
            // End snippet
        }

        /// <summary>Snippet for CreateDataTable</summary>
        public void CreateDataTableResourceNames()
        {
            // Snippet: CreateDataTable(InstanceName, DataTable, string, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            DataTable dataTable = new DataTable();
            string dataTableId = "";
            // Make the request
            DataTable response = dataTableServiceClient.CreateDataTable(parent, dataTable, dataTableId);
            // End snippet
        }

        /// <summary>Snippet for CreateDataTableAsync</summary>
        public async Task CreateDataTableResourceNamesAsync()
        {
            // Snippet: CreateDataTableAsync(InstanceName, DataTable, string, CallSettings)
            // Additional: CreateDataTableAsync(InstanceName, DataTable, string, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            DataTable dataTable = new DataTable();
            string dataTableId = "";
            // Make the request
            DataTable response = await dataTableServiceClient.CreateDataTableAsync(parent, dataTable, dataTableId);
            // End snippet
        }

        /// <summary>Snippet for ListDataTables</summary>
        public void ListDataTablesRequestObject()
        {
            // Snippet: ListDataTables(ListDataTablesRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            ListDataTablesRequest request = new ListDataTablesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                OrderBy = "",
            };
            // Make the request
            PagedEnumerable<ListDataTablesResponse, DataTable> response = dataTableServiceClient.ListDataTables(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataTable item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataTablesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataTable item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataTable> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataTable item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTablesAsync</summary>
        public async Task ListDataTablesRequestObjectAsync()
        {
            // Snippet: ListDataTablesAsync(ListDataTablesRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataTablesRequest request = new ListDataTablesRequest
            {
                ParentAsInstanceName = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]"),
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDataTablesResponse, DataTable> response = dataTableServiceClient.ListDataTablesAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DataTable item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDataTablesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataTable item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataTable> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataTable item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTables</summary>
        public void ListDataTables()
        {
            // Snippet: ListDataTables(string, string, int?, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedEnumerable<ListDataTablesResponse, DataTable> response = dataTableServiceClient.ListDataTables(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataTable item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataTablesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataTable item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataTable> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataTable item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTablesAsync</summary>
        public async Task ListDataTablesAsync()
        {
            // Snippet: ListDataTablesAsync(string, string, int?, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]";
            // Make the request
            PagedAsyncEnumerable<ListDataTablesResponse, DataTable> response = dataTableServiceClient.ListDataTablesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DataTable item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDataTablesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataTable item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataTable> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataTable item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTables</summary>
        public void ListDataTablesResourceNames()
        {
            // Snippet: ListDataTables(InstanceName, string, int?, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedEnumerable<ListDataTablesResponse, DataTable> response = dataTableServiceClient.ListDataTables(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataTable item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataTablesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataTable item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataTable> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataTable item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTablesAsync</summary>
        public async Task ListDataTablesResourceNamesAsync()
        {
            // Snippet: ListDataTablesAsync(InstanceName, string, int?, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            InstanceName parent = InstanceName.FromProjectLocationInstance("[PROJECT]", "[LOCATION]", "[INSTANCE]");
            // Make the request
            PagedAsyncEnumerable<ListDataTablesResponse, DataTable> response = dataTableServiceClient.ListDataTablesAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DataTable item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDataTablesResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataTable item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataTable> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataTable item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDataTable</summary>
        public void GetDataTableRequestObject()
        {
            // Snippet: GetDataTable(GetDataTableRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            GetDataTableRequest request = new GetDataTableRequest
            {
                DataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
            };
            // Make the request
            DataTable response = dataTableServiceClient.GetDataTable(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableAsync</summary>
        public async Task GetDataTableRequestObjectAsync()
        {
            // Snippet: GetDataTableAsync(GetDataTableRequest, CallSettings)
            // Additional: GetDataTableAsync(GetDataTableRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataTableRequest request = new GetDataTableRequest
            {
                DataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
            };
            // Make the request
            DataTable response = await dataTableServiceClient.GetDataTableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataTable</summary>
        public void GetDataTable()
        {
            // Snippet: GetDataTable(string, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            // Make the request
            DataTable response = dataTableServiceClient.GetDataTable(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableAsync</summary>
        public async Task GetDataTableAsync()
        {
            // Snippet: GetDataTableAsync(string, CallSettings)
            // Additional: GetDataTableAsync(string, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            // Make the request
            DataTable response = await dataTableServiceClient.GetDataTableAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataTable</summary>
        public void GetDataTableResourceNames()
        {
            // Snippet: GetDataTable(DataTableName, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTableName name = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            // Make the request
            DataTable response = dataTableServiceClient.GetDataTable(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableAsync</summary>
        public async Task GetDataTableResourceNamesAsync()
        {
            // Snippet: GetDataTableAsync(DataTableName, CallSettings)
            // Additional: GetDataTableAsync(DataTableName, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTableName name = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            // Make the request
            DataTable response = await dataTableServiceClient.GetDataTableAsync(name);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataTable</summary>
        public void UpdateDataTableRequestObject()
        {
            // Snippet: UpdateDataTable(UpdateDataTableRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataTableRequest request = new UpdateDataTableRequest
            {
                DataTable = new DataTable(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataTable response = dataTableServiceClient.UpdateDataTable(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataTableAsync</summary>
        public async Task UpdateDataTableRequestObjectAsync()
        {
            // Snippet: UpdateDataTableAsync(UpdateDataTableRequest, CallSettings)
            // Additional: UpdateDataTableAsync(UpdateDataTableRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataTableRequest request = new UpdateDataTableRequest
            {
                DataTable = new DataTable(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataTable response = await dataTableServiceClient.UpdateDataTableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataTable</summary>
        public void UpdateDataTable()
        {
            // Snippet: UpdateDataTable(DataTable, FieldMask, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTable dataTable = new DataTable();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataTable response = dataTableServiceClient.UpdateDataTable(dataTable, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataTableAsync</summary>
        public async Task UpdateDataTableAsync()
        {
            // Snippet: UpdateDataTableAsync(DataTable, FieldMask, CallSettings)
            // Additional: UpdateDataTableAsync(DataTable, FieldMask, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTable dataTable = new DataTable();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataTable response = await dataTableServiceClient.UpdateDataTableAsync(dataTable, updateMask);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTable</summary>
        public void DeleteDataTableRequestObject()
        {
            // Snippet: DeleteDataTable(DeleteDataTableRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataTableRequest request = new DeleteDataTableRequest
            {
                DataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                Force = false,
            };
            // Make the request
            dataTableServiceClient.DeleteDataTable(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTableAsync</summary>
        public async Task DeleteDataTableRequestObjectAsync()
        {
            // Snippet: DeleteDataTableAsync(DeleteDataTableRequest, CallSettings)
            // Additional: DeleteDataTableAsync(DeleteDataTableRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataTableRequest request = new DeleteDataTableRequest
            {
                DataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                Force = false,
            };
            // Make the request
            await dataTableServiceClient.DeleteDataTableAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTable</summary>
        public void DeleteDataTable()
        {
            // Snippet: DeleteDataTable(string, bool, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            bool force = false;
            // Make the request
            dataTableServiceClient.DeleteDataTable(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTableAsync</summary>
        public async Task DeleteDataTableAsync()
        {
            // Snippet: DeleteDataTableAsync(string, bool, CallSettings)
            // Additional: DeleteDataTableAsync(string, bool, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            bool force = false;
            // Make the request
            await dataTableServiceClient.DeleteDataTableAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTable</summary>
        public void DeleteDataTableResourceNames()
        {
            // Snippet: DeleteDataTable(DataTableName, bool, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTableName name = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            bool force = false;
            // Make the request
            dataTableServiceClient.DeleteDataTable(name, force);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTableAsync</summary>
        public async Task DeleteDataTableResourceNamesAsync()
        {
            // Snippet: DeleteDataTableAsync(DataTableName, bool, CallSettings)
            // Additional: DeleteDataTableAsync(DataTableName, bool, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTableName name = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            bool force = false;
            // Make the request
            await dataTableServiceClient.DeleteDataTableAsync(name, force);
            // End snippet
        }

        /// <summary>Snippet for CreateDataTableRow</summary>
        public void CreateDataTableRowRequestObject()
        {
            // Snippet: CreateDataTableRow(CreateDataTableRowRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            CreateDataTableRowRequest request = new CreateDataTableRowRequest
            {
                ParentAsDataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                DataTableRow = new DataTableRow(),
            };
            // Make the request
            DataTableRow response = dataTableServiceClient.CreateDataTableRow(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataTableRowAsync</summary>
        public async Task CreateDataTableRowRequestObjectAsync()
        {
            // Snippet: CreateDataTableRowAsync(CreateDataTableRowRequest, CallSettings)
            // Additional: CreateDataTableRowAsync(CreateDataTableRowRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateDataTableRowRequest request = new CreateDataTableRowRequest
            {
                ParentAsDataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                DataTableRow = new DataTableRow(),
            };
            // Make the request
            DataTableRow response = await dataTableServiceClient.CreateDataTableRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateDataTableRow</summary>
        public void CreateDataTableRow()
        {
            // Snippet: CreateDataTableRow(string, DataTableRow, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            DataTableRow dataTableRow = new DataTableRow();
            // Make the request
            DataTableRow response = dataTableServiceClient.CreateDataTableRow(parent, dataTableRow);
            // End snippet
        }

        /// <summary>Snippet for CreateDataTableRowAsync</summary>
        public async Task CreateDataTableRowAsync()
        {
            // Snippet: CreateDataTableRowAsync(string, DataTableRow, CallSettings)
            // Additional: CreateDataTableRowAsync(string, DataTableRow, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            DataTableRow dataTableRow = new DataTableRow();
            // Make the request
            DataTableRow response = await dataTableServiceClient.CreateDataTableRowAsync(parent, dataTableRow);
            // End snippet
        }

        /// <summary>Snippet for CreateDataTableRow</summary>
        public void CreateDataTableRowResourceNames()
        {
            // Snippet: CreateDataTableRow(DataTableName, DataTableRow, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTableName parent = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            DataTableRow dataTableRow = new DataTableRow();
            // Make the request
            DataTableRow response = dataTableServiceClient.CreateDataTableRow(parent, dataTableRow);
            // End snippet
        }

        /// <summary>Snippet for CreateDataTableRowAsync</summary>
        public async Task CreateDataTableRowResourceNamesAsync()
        {
            // Snippet: CreateDataTableRowAsync(DataTableName, DataTableRow, CallSettings)
            // Additional: CreateDataTableRowAsync(DataTableName, DataTableRow, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTableName parent = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            DataTableRow dataTableRow = new DataTableRow();
            // Make the request
            DataTableRow response = await dataTableServiceClient.CreateDataTableRowAsync(parent, dataTableRow);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataTableRow</summary>
        public void UpdateDataTableRowRequestObject()
        {
            // Snippet: UpdateDataTableRow(UpdateDataTableRowRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            UpdateDataTableRowRequest request = new UpdateDataTableRowRequest
            {
                DataTableRow = new DataTableRow(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataTableRow response = dataTableServiceClient.UpdateDataTableRow(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataTableRowAsync</summary>
        public async Task UpdateDataTableRowRequestObjectAsync()
        {
            // Snippet: UpdateDataTableRowAsync(UpdateDataTableRowRequest, CallSettings)
            // Additional: UpdateDataTableRowAsync(UpdateDataTableRowRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            UpdateDataTableRowRequest request = new UpdateDataTableRowRequest
            {
                DataTableRow = new DataTableRow(),
                UpdateMask = new FieldMask(),
            };
            // Make the request
            DataTableRow response = await dataTableServiceClient.UpdateDataTableRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataTableRow</summary>
        public void UpdateDataTableRow()
        {
            // Snippet: UpdateDataTableRow(DataTableRow, FieldMask, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTableRow dataTableRow = new DataTableRow();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataTableRow response = dataTableServiceClient.UpdateDataTableRow(dataTableRow, updateMask);
            // End snippet
        }

        /// <summary>Snippet for UpdateDataTableRowAsync</summary>
        public async Task UpdateDataTableRowAsync()
        {
            // Snippet: UpdateDataTableRowAsync(DataTableRow, FieldMask, CallSettings)
            // Additional: UpdateDataTableRowAsync(DataTableRow, FieldMask, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTableRow dataTableRow = new DataTableRow();
            FieldMask updateMask = new FieldMask();
            // Make the request
            DataTableRow response = await dataTableServiceClient.UpdateDataTableRowAsync(dataTableRow, updateMask);
            // End snippet
        }

        /// <summary>Snippet for ListDataTableRows</summary>
        public void ListDataTableRowsRequestObject()
        {
            // Snippet: ListDataTableRows(ListDataTableRowsRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            ListDataTableRowsRequest request = new ListDataTableRowsRequest
            {
                ParentAsDataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedEnumerable<ListDataTableRowsResponse, DataTableRow> response = dataTableServiceClient.ListDataTableRows(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataTableRow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataTableRowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataTableRow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataTableRow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataTableRow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTableRowsAsync</summary>
        public async Task ListDataTableRowsRequestObjectAsync()
        {
            // Snippet: ListDataTableRowsAsync(ListDataTableRowsRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListDataTableRowsRequest request = new ListDataTableRowsRequest
            {
                ParentAsDataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                OrderBy = "",
                Filter = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListDataTableRowsResponse, DataTableRow> response = dataTableServiceClient.ListDataTableRowsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DataTableRow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDataTableRowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataTableRow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataTableRow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataTableRow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTableRows</summary>
        public void ListDataTableRows()
        {
            // Snippet: ListDataTableRows(string, string, int?, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            // Make the request
            PagedEnumerable<ListDataTableRowsResponse, DataTableRow> response = dataTableServiceClient.ListDataTableRows(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataTableRow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataTableRowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataTableRow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataTableRow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataTableRow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTableRowsAsync</summary>
        public async Task ListDataTableRowsAsync()
        {
            // Snippet: ListDataTableRowsAsync(string, string, int?, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            // Make the request
            PagedAsyncEnumerable<ListDataTableRowsResponse, DataTableRow> response = dataTableServiceClient.ListDataTableRowsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DataTableRow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDataTableRowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataTableRow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataTableRow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataTableRow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTableRows</summary>
        public void ListDataTableRowsResourceNames()
        {
            // Snippet: ListDataTableRows(DataTableName, string, int?, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTableName parent = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            // Make the request
            PagedEnumerable<ListDataTableRowsResponse, DataTableRow> response = dataTableServiceClient.ListDataTableRows(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (DataTableRow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListDataTableRowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataTableRow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataTableRow> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataTableRow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListDataTableRowsAsync</summary>
        public async Task ListDataTableRowsResourceNamesAsync()
        {
            // Snippet: ListDataTableRowsAsync(DataTableName, string, int?, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTableName parent = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            // Make the request
            PagedAsyncEnumerable<ListDataTableRowsResponse, DataTableRow> response = dataTableServiceClient.ListDataTableRowsAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (DataTableRow item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (ListDataTableRowsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (DataTableRow item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<DataTableRow> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (DataTableRow item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for GetDataTableRow</summary>
        public void GetDataTableRowRequestObject()
        {
            // Snippet: GetDataTableRow(GetDataTableRowRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            GetDataTableRowRequest request = new GetDataTableRowRequest
            {
                DataTableRowName = DataTableRowName.FromProjectLocationInstanceDataTableDataTableRow("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]", "[DATA_TABLE_ROW]"),
            };
            // Make the request
            DataTableRow response = dataTableServiceClient.GetDataTableRow(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableRowAsync</summary>
        public async Task GetDataTableRowRequestObjectAsync()
        {
            // Snippet: GetDataTableRowAsync(GetDataTableRowRequest, CallSettings)
            // Additional: GetDataTableRowAsync(GetDataTableRowRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataTableRowRequest request = new GetDataTableRowRequest
            {
                DataTableRowName = DataTableRowName.FromProjectLocationInstanceDataTableDataTableRow("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]", "[DATA_TABLE_ROW]"),
            };
            // Make the request
            DataTableRow response = await dataTableServiceClient.GetDataTableRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableRow</summary>
        public void GetDataTableRow()
        {
            // Snippet: GetDataTableRow(string, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]/dataTableRows/[DATA_TABLE_ROW]";
            // Make the request
            DataTableRow response = dataTableServiceClient.GetDataTableRow(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableRowAsync</summary>
        public async Task GetDataTableRowAsync()
        {
            // Snippet: GetDataTableRowAsync(string, CallSettings)
            // Additional: GetDataTableRowAsync(string, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]/dataTableRows/[DATA_TABLE_ROW]";
            // Make the request
            DataTableRow response = await dataTableServiceClient.GetDataTableRowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableRow</summary>
        public void GetDataTableRowResourceNames()
        {
            // Snippet: GetDataTableRow(DataTableRowName, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTableRowName name = DataTableRowName.FromProjectLocationInstanceDataTableDataTableRow("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]", "[DATA_TABLE_ROW]");
            // Make the request
            DataTableRow response = dataTableServiceClient.GetDataTableRow(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableRowAsync</summary>
        public async Task GetDataTableRowResourceNamesAsync()
        {
            // Snippet: GetDataTableRowAsync(DataTableRowName, CallSettings)
            // Additional: GetDataTableRowAsync(DataTableRowName, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTableRowName name = DataTableRowName.FromProjectLocationInstanceDataTableDataTableRow("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]", "[DATA_TABLE_ROW]");
            // Make the request
            DataTableRow response = await dataTableServiceClient.GetDataTableRowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTableRow</summary>
        public void DeleteDataTableRowRequestObject()
        {
            // Snippet: DeleteDataTableRow(DeleteDataTableRowRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DeleteDataTableRowRequest request = new DeleteDataTableRowRequest
            {
                DataTableRowName = DataTableRowName.FromProjectLocationInstanceDataTableDataTableRow("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]", "[DATA_TABLE_ROW]"),
            };
            // Make the request
            dataTableServiceClient.DeleteDataTableRow(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTableRowAsync</summary>
        public async Task DeleteDataTableRowRequestObjectAsync()
        {
            // Snippet: DeleteDataTableRowAsync(DeleteDataTableRowRequest, CallSettings)
            // Additional: DeleteDataTableRowAsync(DeleteDataTableRowRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeleteDataTableRowRequest request = new DeleteDataTableRowRequest
            {
                DataTableRowName = DataTableRowName.FromProjectLocationInstanceDataTableDataTableRow("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]", "[DATA_TABLE_ROW]"),
            };
            // Make the request
            await dataTableServiceClient.DeleteDataTableRowAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTableRow</summary>
        public void DeleteDataTableRow()
        {
            // Snippet: DeleteDataTableRow(string, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]/dataTableRows/[DATA_TABLE_ROW]";
            // Make the request
            dataTableServiceClient.DeleteDataTableRow(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTableRowAsync</summary>
        public async Task DeleteDataTableRowAsync()
        {
            // Snippet: DeleteDataTableRowAsync(string, CallSettings)
            // Additional: DeleteDataTableRowAsync(string, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]/dataTableRows/[DATA_TABLE_ROW]";
            // Make the request
            await dataTableServiceClient.DeleteDataTableRowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTableRow</summary>
        public void DeleteDataTableRowResourceNames()
        {
            // Snippet: DeleteDataTableRow(DataTableRowName, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTableRowName name = DataTableRowName.FromProjectLocationInstanceDataTableDataTableRow("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]", "[DATA_TABLE_ROW]");
            // Make the request
            dataTableServiceClient.DeleteDataTableRow(name);
            // End snippet
        }

        /// <summary>Snippet for DeleteDataTableRowAsync</summary>
        public async Task DeleteDataTableRowResourceNamesAsync()
        {
            // Snippet: DeleteDataTableRowAsync(DataTableRowName, CallSettings)
            // Additional: DeleteDataTableRowAsync(DataTableRowName, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTableRowName name = DataTableRowName.FromProjectLocationInstanceDataTableDataTableRow("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]", "[DATA_TABLE_ROW]");
            // Make the request
            await dataTableServiceClient.DeleteDataTableRowAsync(name);
            // End snippet
        }

        /// <summary>Snippet for BulkCreateDataTableRows</summary>
        public void BulkCreateDataTableRowsRequestObject()
        {
            // Snippet: BulkCreateDataTableRows(BulkCreateDataTableRowsRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            BulkCreateDataTableRowsRequest request = new BulkCreateDataTableRowsRequest
            {
                ParentAsDataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                Requests =
                {
                    new CreateDataTableRowRequest(),
                },
            };
            // Make the request
            BulkCreateDataTableRowsResponse response = dataTableServiceClient.BulkCreateDataTableRows(request);
            // End snippet
        }

        /// <summary>Snippet for BulkCreateDataTableRowsAsync</summary>
        public async Task BulkCreateDataTableRowsRequestObjectAsync()
        {
            // Snippet: BulkCreateDataTableRowsAsync(BulkCreateDataTableRowsRequest, CallSettings)
            // Additional: BulkCreateDataTableRowsAsync(BulkCreateDataTableRowsRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            BulkCreateDataTableRowsRequest request = new BulkCreateDataTableRowsRequest
            {
                ParentAsDataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                Requests =
                {
                    new CreateDataTableRowRequest(),
                },
            };
            // Make the request
            BulkCreateDataTableRowsResponse response = await dataTableServiceClient.BulkCreateDataTableRowsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BulkCreateDataTableRows</summary>
        public void BulkCreateDataTableRows()
        {
            // Snippet: BulkCreateDataTableRows(string, IEnumerable<CreateDataTableRowRequest>, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            IEnumerable<CreateDataTableRowRequest> requests = new CreateDataTableRowRequest[]
            {
                new CreateDataTableRowRequest(),
            };
            // Make the request
            BulkCreateDataTableRowsResponse response = dataTableServiceClient.BulkCreateDataTableRows(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkCreateDataTableRowsAsync</summary>
        public async Task BulkCreateDataTableRowsAsync()
        {
            // Snippet: BulkCreateDataTableRowsAsync(string, IEnumerable<CreateDataTableRowRequest>, CallSettings)
            // Additional: BulkCreateDataTableRowsAsync(string, IEnumerable<CreateDataTableRowRequest>, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            IEnumerable<CreateDataTableRowRequest> requests = new CreateDataTableRowRequest[]
            {
                new CreateDataTableRowRequest(),
            };
            // Make the request
            BulkCreateDataTableRowsResponse response = await dataTableServiceClient.BulkCreateDataTableRowsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkCreateDataTableRows</summary>
        public void BulkCreateDataTableRowsResourceNames()
        {
            // Snippet: BulkCreateDataTableRows(DataTableName, IEnumerable<CreateDataTableRowRequest>, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTableName parent = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            IEnumerable<CreateDataTableRowRequest> requests = new CreateDataTableRowRequest[]
            {
                new CreateDataTableRowRequest(),
            };
            // Make the request
            BulkCreateDataTableRowsResponse response = dataTableServiceClient.BulkCreateDataTableRows(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkCreateDataTableRowsAsync</summary>
        public async Task BulkCreateDataTableRowsResourceNamesAsync()
        {
            // Snippet: BulkCreateDataTableRowsAsync(DataTableName, IEnumerable<CreateDataTableRowRequest>, CallSettings)
            // Additional: BulkCreateDataTableRowsAsync(DataTableName, IEnumerable<CreateDataTableRowRequest>, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTableName parent = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            IEnumerable<CreateDataTableRowRequest> requests = new CreateDataTableRowRequest[]
            {
                new CreateDataTableRowRequest(),
            };
            // Make the request
            BulkCreateDataTableRowsResponse response = await dataTableServiceClient.BulkCreateDataTableRowsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkGetDataTableRows</summary>
        public void BulkGetDataTableRowsRequestObject()
        {
            // Snippet: BulkGetDataTableRows(BulkGetDataTableRowsRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            BulkGetDataTableRowsRequest request = new BulkGetDataTableRowsRequest
            {
                ParentAsDataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                Requests =
                {
                    new GetDataTableRowRequest(),
                },
            };
            // Make the request
            BulkGetDataTableRowsResponse response = dataTableServiceClient.BulkGetDataTableRows(request);
            // End snippet
        }

        /// <summary>Snippet for BulkGetDataTableRowsAsync</summary>
        public async Task BulkGetDataTableRowsRequestObjectAsync()
        {
            // Snippet: BulkGetDataTableRowsAsync(BulkGetDataTableRowsRequest, CallSettings)
            // Additional: BulkGetDataTableRowsAsync(BulkGetDataTableRowsRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            BulkGetDataTableRowsRequest request = new BulkGetDataTableRowsRequest
            {
                ParentAsDataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                Requests =
                {
                    new GetDataTableRowRequest(),
                },
            };
            // Make the request
            BulkGetDataTableRowsResponse response = await dataTableServiceClient.BulkGetDataTableRowsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BulkGetDataTableRows</summary>
        public void BulkGetDataTableRows()
        {
            // Snippet: BulkGetDataTableRows(string, IEnumerable<GetDataTableRowRequest>, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            IEnumerable<GetDataTableRowRequest> requests = new GetDataTableRowRequest[]
            {
                new GetDataTableRowRequest(),
            };
            // Make the request
            BulkGetDataTableRowsResponse response = dataTableServiceClient.BulkGetDataTableRows(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkGetDataTableRowsAsync</summary>
        public async Task BulkGetDataTableRowsAsync()
        {
            // Snippet: BulkGetDataTableRowsAsync(string, IEnumerable<GetDataTableRowRequest>, CallSettings)
            // Additional: BulkGetDataTableRowsAsync(string, IEnumerable<GetDataTableRowRequest>, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            IEnumerable<GetDataTableRowRequest> requests = new GetDataTableRowRequest[]
            {
                new GetDataTableRowRequest(),
            };
            // Make the request
            BulkGetDataTableRowsResponse response = await dataTableServiceClient.BulkGetDataTableRowsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkGetDataTableRows</summary>
        public void BulkGetDataTableRowsResourceNames()
        {
            // Snippet: BulkGetDataTableRows(DataTableName, IEnumerable<GetDataTableRowRequest>, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTableName parent = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            IEnumerable<GetDataTableRowRequest> requests = new GetDataTableRowRequest[]
            {
                new GetDataTableRowRequest(),
            };
            // Make the request
            BulkGetDataTableRowsResponse response = dataTableServiceClient.BulkGetDataTableRows(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkGetDataTableRowsAsync</summary>
        public async Task BulkGetDataTableRowsResourceNamesAsync()
        {
            // Snippet: BulkGetDataTableRowsAsync(DataTableName, IEnumerable<GetDataTableRowRequest>, CallSettings)
            // Additional: BulkGetDataTableRowsAsync(DataTableName, IEnumerable<GetDataTableRowRequest>, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTableName parent = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            IEnumerable<GetDataTableRowRequest> requests = new GetDataTableRowRequest[]
            {
                new GetDataTableRowRequest(),
            };
            // Make the request
            BulkGetDataTableRowsResponse response = await dataTableServiceClient.BulkGetDataTableRowsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkReplaceDataTableRows</summary>
        public void BulkReplaceDataTableRowsRequestObject()
        {
            // Snippet: BulkReplaceDataTableRows(BulkReplaceDataTableRowsRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            BulkReplaceDataTableRowsRequest request = new BulkReplaceDataTableRowsRequest
            {
                ParentAsDataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                Requests =
                {
                    new CreateDataTableRowRequest(),
                },
            };
            // Make the request
            BulkReplaceDataTableRowsResponse response = dataTableServiceClient.BulkReplaceDataTableRows(request);
            // End snippet
        }

        /// <summary>Snippet for BulkReplaceDataTableRowsAsync</summary>
        public async Task BulkReplaceDataTableRowsRequestObjectAsync()
        {
            // Snippet: BulkReplaceDataTableRowsAsync(BulkReplaceDataTableRowsRequest, CallSettings)
            // Additional: BulkReplaceDataTableRowsAsync(BulkReplaceDataTableRowsRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            BulkReplaceDataTableRowsRequest request = new BulkReplaceDataTableRowsRequest
            {
                ParentAsDataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                Requests =
                {
                    new CreateDataTableRowRequest(),
                },
            };
            // Make the request
            BulkReplaceDataTableRowsResponse response = await dataTableServiceClient.BulkReplaceDataTableRowsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BulkReplaceDataTableRows</summary>
        public void BulkReplaceDataTableRows()
        {
            // Snippet: BulkReplaceDataTableRows(string, IEnumerable<CreateDataTableRowRequest>, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            IEnumerable<CreateDataTableRowRequest> requests = new CreateDataTableRowRequest[]
            {
                new CreateDataTableRowRequest(),
            };
            // Make the request
            BulkReplaceDataTableRowsResponse response = dataTableServiceClient.BulkReplaceDataTableRows(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkReplaceDataTableRowsAsync</summary>
        public async Task BulkReplaceDataTableRowsAsync()
        {
            // Snippet: BulkReplaceDataTableRowsAsync(string, IEnumerable<CreateDataTableRowRequest>, CallSettings)
            // Additional: BulkReplaceDataTableRowsAsync(string, IEnumerable<CreateDataTableRowRequest>, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            IEnumerable<CreateDataTableRowRequest> requests = new CreateDataTableRowRequest[]
            {
                new CreateDataTableRowRequest(),
            };
            // Make the request
            BulkReplaceDataTableRowsResponse response = await dataTableServiceClient.BulkReplaceDataTableRowsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkReplaceDataTableRows</summary>
        public void BulkReplaceDataTableRowsResourceNames()
        {
            // Snippet: BulkReplaceDataTableRows(DataTableName, IEnumerable<CreateDataTableRowRequest>, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTableName parent = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            IEnumerable<CreateDataTableRowRequest> requests = new CreateDataTableRowRequest[]
            {
                new CreateDataTableRowRequest(),
            };
            // Make the request
            BulkReplaceDataTableRowsResponse response = dataTableServiceClient.BulkReplaceDataTableRows(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkReplaceDataTableRowsAsync</summary>
        public async Task BulkReplaceDataTableRowsResourceNamesAsync()
        {
            // Snippet: BulkReplaceDataTableRowsAsync(DataTableName, IEnumerable<CreateDataTableRowRequest>, CallSettings)
            // Additional: BulkReplaceDataTableRowsAsync(DataTableName, IEnumerable<CreateDataTableRowRequest>, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTableName parent = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            IEnumerable<CreateDataTableRowRequest> requests = new CreateDataTableRowRequest[]
            {
                new CreateDataTableRowRequest(),
            };
            // Make the request
            BulkReplaceDataTableRowsResponse response = await dataTableServiceClient.BulkReplaceDataTableRowsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkUpdateDataTableRows</summary>
        public void BulkUpdateDataTableRowsRequestObject()
        {
            // Snippet: BulkUpdateDataTableRows(BulkUpdateDataTableRowsRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            BulkUpdateDataTableRowsRequest request = new BulkUpdateDataTableRowsRequest
            {
                ParentAsDataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                Requests =
                {
                    new UpdateDataTableRowRequest(),
                },
            };
            // Make the request
            BulkUpdateDataTableRowsResponse response = dataTableServiceClient.BulkUpdateDataTableRows(request);
            // End snippet
        }

        /// <summary>Snippet for BulkUpdateDataTableRowsAsync</summary>
        public async Task BulkUpdateDataTableRowsRequestObjectAsync()
        {
            // Snippet: BulkUpdateDataTableRowsAsync(BulkUpdateDataTableRowsRequest, CallSettings)
            // Additional: BulkUpdateDataTableRowsAsync(BulkUpdateDataTableRowsRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            BulkUpdateDataTableRowsRequest request = new BulkUpdateDataTableRowsRequest
            {
                ParentAsDataTableName = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]"),
                Requests =
                {
                    new UpdateDataTableRowRequest(),
                },
            };
            // Make the request
            BulkUpdateDataTableRowsResponse response = await dataTableServiceClient.BulkUpdateDataTableRowsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for BulkUpdateDataTableRows</summary>
        public void BulkUpdateDataTableRows()
        {
            // Snippet: BulkUpdateDataTableRows(string, IEnumerable<UpdateDataTableRowRequest>, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            IEnumerable<UpdateDataTableRowRequest> requests = new UpdateDataTableRowRequest[]
            {
                new UpdateDataTableRowRequest(),
            };
            // Make the request
            BulkUpdateDataTableRowsResponse response = dataTableServiceClient.BulkUpdateDataTableRows(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkUpdateDataTableRowsAsync</summary>
        public async Task BulkUpdateDataTableRowsAsync()
        {
            // Snippet: BulkUpdateDataTableRowsAsync(string, IEnumerable<UpdateDataTableRowRequest>, CallSettings)
            // Additional: BulkUpdateDataTableRowsAsync(string, IEnumerable<UpdateDataTableRowRequest>, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTables/[DATA_TABLE]";
            IEnumerable<UpdateDataTableRowRequest> requests = new UpdateDataTableRowRequest[]
            {
                new UpdateDataTableRowRequest(),
            };
            // Make the request
            BulkUpdateDataTableRowsResponse response = await dataTableServiceClient.BulkUpdateDataTableRowsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkUpdateDataTableRows</summary>
        public void BulkUpdateDataTableRowsResourceNames()
        {
            // Snippet: BulkUpdateDataTableRows(DataTableName, IEnumerable<UpdateDataTableRowRequest>, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTableName parent = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            IEnumerable<UpdateDataTableRowRequest> requests = new UpdateDataTableRowRequest[]
            {
                new UpdateDataTableRowRequest(),
            };
            // Make the request
            BulkUpdateDataTableRowsResponse response = dataTableServiceClient.BulkUpdateDataTableRows(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for BulkUpdateDataTableRowsAsync</summary>
        public async Task BulkUpdateDataTableRowsResourceNamesAsync()
        {
            // Snippet: BulkUpdateDataTableRowsAsync(DataTableName, IEnumerable<UpdateDataTableRowRequest>, CallSettings)
            // Additional: BulkUpdateDataTableRowsAsync(DataTableName, IEnumerable<UpdateDataTableRowRequest>, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTableName parent = DataTableName.FromProjectLocationInstanceDataTable("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE]");
            IEnumerable<UpdateDataTableRowRequest> requests = new UpdateDataTableRowRequest[]
            {
                new UpdateDataTableRowRequest(),
            };
            // Make the request
            BulkUpdateDataTableRowsResponse response = await dataTableServiceClient.BulkUpdateDataTableRowsAsync(parent, requests);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableOperationErrors</summary>
        public void GetDataTableOperationErrorsRequestObject()
        {
            // Snippet: GetDataTableOperationErrors(GetDataTableOperationErrorsRequest, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            GetDataTableOperationErrorsRequest request = new GetDataTableOperationErrorsRequest
            {
                DataTableOperationErrorsName = DataTableOperationErrorsName.FromProjectLocationInstanceDataTableOperationErrors("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE_OPERATION_ERRORS]"),
            };
            // Make the request
            DataTableOperationErrors response = dataTableServiceClient.GetDataTableOperationErrors(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableOperationErrorsAsync</summary>
        public async Task GetDataTableOperationErrorsRequestObjectAsync()
        {
            // Snippet: GetDataTableOperationErrorsAsync(GetDataTableOperationErrorsRequest, CallSettings)
            // Additional: GetDataTableOperationErrorsAsync(GetDataTableOperationErrorsRequest, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetDataTableOperationErrorsRequest request = new GetDataTableOperationErrorsRequest
            {
                DataTableOperationErrorsName = DataTableOperationErrorsName.FromProjectLocationInstanceDataTableOperationErrors("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE_OPERATION_ERRORS]"),
            };
            // Make the request
            DataTableOperationErrors response = await dataTableServiceClient.GetDataTableOperationErrorsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableOperationErrors</summary>
        public void GetDataTableOperationErrors()
        {
            // Snippet: GetDataTableOperationErrors(string, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTableOperationErrors/[DATA_TABLE_OPERATION_ERRORS]";
            // Make the request
            DataTableOperationErrors response = dataTableServiceClient.GetDataTableOperationErrors(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableOperationErrorsAsync</summary>
        public async Task GetDataTableOperationErrorsAsync()
        {
            // Snippet: GetDataTableOperationErrorsAsync(string, CallSettings)
            // Additional: GetDataTableOperationErrorsAsync(string, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/instances/[INSTANCE]/dataTableOperationErrors/[DATA_TABLE_OPERATION_ERRORS]";
            // Make the request
            DataTableOperationErrors response = await dataTableServiceClient.GetDataTableOperationErrorsAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableOperationErrors</summary>
        public void GetDataTableOperationErrorsResourceNames()
        {
            // Snippet: GetDataTableOperationErrors(DataTableOperationErrorsName, CallSettings)
            // Create client
            DataTableServiceClient dataTableServiceClient = DataTableServiceClient.Create();
            // Initialize request argument(s)
            DataTableOperationErrorsName name = DataTableOperationErrorsName.FromProjectLocationInstanceDataTableOperationErrors("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE_OPERATION_ERRORS]");
            // Make the request
            DataTableOperationErrors response = dataTableServiceClient.GetDataTableOperationErrors(name);
            // End snippet
        }

        /// <summary>Snippet for GetDataTableOperationErrorsAsync</summary>
        public async Task GetDataTableOperationErrorsResourceNamesAsync()
        {
            // Snippet: GetDataTableOperationErrorsAsync(DataTableOperationErrorsName, CallSettings)
            // Additional: GetDataTableOperationErrorsAsync(DataTableOperationErrorsName, CancellationToken)
            // Create client
            DataTableServiceClient dataTableServiceClient = await DataTableServiceClient.CreateAsync();
            // Initialize request argument(s)
            DataTableOperationErrorsName name = DataTableOperationErrorsName.FromProjectLocationInstanceDataTableOperationErrors("[PROJECT]", "[LOCATION]", "[INSTANCE]", "[DATA_TABLE_OPERATION_ERRORS]");
            // Make the request
            DataTableOperationErrors response = await dataTableServiceClient.GetDataTableOperationErrorsAsync(name);
            // End snippet
        }
    }
}
