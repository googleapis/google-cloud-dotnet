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

namespace Google.Cloud.Bigtable.Admin.V2.Snippets
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.Bigtable.Admin.V2;
    using Google.Cloud.Bigtable.Common.V2;
    using Google.Cloud.Iam.V1;
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

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync()
        {
            // Snippet: GetIamPolicyAsync(string,CallSettings)
            // Additional: GetIamPolicyAsync(string,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            // Make the request
            Policy response = await bigtableTableAdminClient.GetIamPolicyAsync(formattedResource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy()
        {
            // Snippet: GetIamPolicy(string,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string formattedResource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            // Make the request
            Policy response = bigtableTableAdminClient.GetIamPolicy(formattedResource);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicyAsync</summary>
        public async Task GetIamPolicyAsync_RequestObject()
        {
            // Snippet: GetIamPolicyAsync(GetIamPolicyRequest,CallSettings)
            // Additional: GetIamPolicyAsync(GetIamPolicyRequest,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
            };
            // Make the request
            Policy response = await bigtableTableAdminClient.GetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetIamPolicy</summary>
        public void GetIamPolicy_RequestObject()
        {
            // Snippet: GetIamPolicy(GetIamPolicyRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            GetIamPolicyRequest request = new GetIamPolicyRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
            };
            // Make the request
            Policy response = bigtableTableAdminClient.GetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync()
        {
            // Snippet: SetIamPolicyAsync(string,Policy,CallSettings)
            // Additional: SetIamPolicyAsync(string,Policy,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = await bigtableTableAdminClient.SetIamPolicyAsync(formattedResource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy()
        {
            // Snippet: SetIamPolicy(string,Policy,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string formattedResource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            Policy policy = new Policy();
            // Make the request
            Policy response = bigtableTableAdminClient.SetIamPolicy(formattedResource, policy);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicyAsync</summary>
        public async Task SetIamPolicyAsync_RequestObject()
        {
            // Snippet: SetIamPolicyAsync(SetIamPolicyRequest,CallSettings)
            // Additional: SetIamPolicyAsync(SetIamPolicyRequest,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = await bigtableTableAdminClient.SetIamPolicyAsync(request);
            // End snippet
        }

        /// <summary>Snippet for SetIamPolicy</summary>
        public void SetIamPolicy_RequestObject()
        {
            // Snippet: SetIamPolicy(SetIamPolicyRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            SetIamPolicyRequest request = new SetIamPolicyRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                Policy = new Policy(),
            };
            // Make the request
            Policy response = bigtableTableAdminClient.SetIamPolicy(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync()
        {
            // Snippet: TestIamPermissionsAsync(string,IEnumerable<string>,CallSettings)
            // Additional: TestIamPermissionsAsync(string,IEnumerable<string>,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            string formattedResource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = await bigtableTableAdminClient.TestIamPermissionsAsync(formattedResource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions()
        {
            // Snippet: TestIamPermissions(string,IEnumerable<string>,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            string formattedResource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString();
            IEnumerable<string> permissions = new List<string>();
            // Make the request
            TestIamPermissionsResponse response = bigtableTableAdminClient.TestIamPermissions(formattedResource, permissions);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissionsAsync</summary>
        public async Task TestIamPermissionsAsync_RequestObject()
        {
            // Snippet: TestIamPermissionsAsync(TestIamPermissionsRequest,CallSettings)
            // Additional: TestIamPermissionsAsync(TestIamPermissionsRequest,CancellationToken)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = await BigtableTableAdminClient.CreateAsync();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = await bigtableTableAdminClient.TestIamPermissionsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TestIamPermissions</summary>
        public void TestIamPermissions_RequestObject()
        {
            // Snippet: TestIamPermissions(TestIamPermissionsRequest,CallSettings)
            // Create client
            BigtableTableAdminClient bigtableTableAdminClient = BigtableTableAdminClient.Create();
            // Initialize request argument(s)
            TestIamPermissionsRequest request = new TestIamPermissionsRequest
            {
                Resource = new Google.Cloud.Bigtable.Common.V2.TableName("[PROJECT]", "[INSTANCE]", "[TABLE]").ToString(),
                Permissions = { },
            };
            // Make the request
            TestIamPermissionsResponse response = bigtableTableAdminClient.TestIamPermissions(request);
            // End snippet
        }

    }
}
