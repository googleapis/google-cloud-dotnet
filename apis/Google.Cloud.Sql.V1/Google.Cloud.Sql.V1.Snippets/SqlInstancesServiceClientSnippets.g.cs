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
    using Google.Cloud.Sql.V1;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSqlInstancesServiceClientSnippets
    {
        /// <summary>Snippet for AddServerCa</summary>
        public void AddServerCaRequestObject()
        {
            // Snippet: AddServerCa(SqlInstancesAddServerCaRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesAddServerCaRequest request = new SqlInstancesAddServerCaRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.AddServerCa(request);
            // End snippet
        }

        /// <summary>Snippet for AddServerCaAsync</summary>
        public async Task AddServerCaRequestObjectAsync()
        {
            // Snippet: AddServerCaAsync(SqlInstancesAddServerCaRequest, CallSettings)
            // Additional: AddServerCaAsync(SqlInstancesAddServerCaRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesAddServerCaRequest request = new SqlInstancesAddServerCaRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.AddServerCaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddServerCertificate</summary>
        public void AddServerCertificateRequestObject()
        {
            // Snippet: AddServerCertificate(SqlInstancesAddServerCertificateRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesAddServerCertificateRequest request = new SqlInstancesAddServerCertificateRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.AddServerCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for AddServerCertificateAsync</summary>
        public async Task AddServerCertificateRequestObjectAsync()
        {
            // Snippet: AddServerCertificateAsync(SqlInstancesAddServerCertificateRequest, CallSettings)
            // Additional: AddServerCertificateAsync(SqlInstancesAddServerCertificateRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesAddServerCertificateRequest request = new SqlInstancesAddServerCertificateRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.AddServerCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AddEntraIdCertificate</summary>
        public void AddEntraIdCertificateRequestObject()
        {
            // Snippet: AddEntraIdCertificate(SqlInstancesAddEntraIdCertificateRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesAddEntraIdCertificateRequest request = new SqlInstancesAddEntraIdCertificateRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.AddEntraIdCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for AddEntraIdCertificateAsync</summary>
        public async Task AddEntraIdCertificateRequestObjectAsync()
        {
            // Snippet: AddEntraIdCertificateAsync(SqlInstancesAddEntraIdCertificateRequest, CallSettings)
            // Additional: AddEntraIdCertificateAsync(SqlInstancesAddEntraIdCertificateRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesAddEntraIdCertificateRequest request = new SqlInstancesAddEntraIdCertificateRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.AddEntraIdCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Clone</summary>
        public void CloneRequestObject()
        {
            // Snippet: Clone(SqlInstancesCloneRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesCloneRequest request = new SqlInstancesCloneRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesCloneRequest(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.Clone(request);
            // End snippet
        }

        /// <summary>Snippet for CloneAsync</summary>
        public async Task CloneRequestObjectAsync()
        {
            // Snippet: CloneAsync(SqlInstancesCloneRequest, CallSettings)
            // Additional: CloneAsync(SqlInstancesCloneRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesCloneRequest request = new SqlInstancesCloneRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesCloneRequest(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.CloneAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(SqlInstancesDeleteRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesDeleteRequest request = new SqlInstancesDeleteRequest
            {
                Instance = "",
                Project = "",
                FinalBackupTtlDays = 0L,
                FinalBackupDescription = "",
                EnableFinalBackup = false,
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(SqlInstancesDeleteRequest, CallSettings)
            // Additional: DeleteAsync(SqlInstancesDeleteRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesDeleteRequest request = new SqlInstancesDeleteRequest
            {
                Instance = "",
                Project = "",
                FinalBackupTtlDays = 0L,
                FinalBackupDescription = "",
                EnableFinalBackup = false,
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for DemoteMaster</summary>
        public void DemoteMasterRequestObject()
        {
            // Snippet: DemoteMaster(SqlInstancesDemoteMasterRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesDemoteMasterRequest request = new SqlInstancesDemoteMasterRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesDemoteMasterRequest(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.DemoteMaster(request);
            // End snippet
        }

        /// <summary>Snippet for DemoteMasterAsync</summary>
        public async Task DemoteMasterRequestObjectAsync()
        {
            // Snippet: DemoteMasterAsync(SqlInstancesDemoteMasterRequest, CallSettings)
            // Additional: DemoteMasterAsync(SqlInstancesDemoteMasterRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesDemoteMasterRequest request = new SqlInstancesDemoteMasterRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesDemoteMasterRequest(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.DemoteMasterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Demote</summary>
        public void DemoteRequestObject()
        {
            // Snippet: Demote(SqlInstancesDemoteRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesDemoteRequest request = new SqlInstancesDemoteRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesDemoteRequest(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.Demote(request);
            // End snippet
        }

        /// <summary>Snippet for DemoteAsync</summary>
        public async Task DemoteRequestObjectAsync()
        {
            // Snippet: DemoteAsync(SqlInstancesDemoteRequest, CallSettings)
            // Additional: DemoteAsync(SqlInstancesDemoteRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesDemoteRequest request = new SqlInstancesDemoteRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesDemoteRequest(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.DemoteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Export</summary>
        public void ExportRequestObject()
        {
            // Snippet: Export(SqlInstancesExportRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesExportRequest request = new SqlInstancesExportRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesExportRequest(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.Export(request);
            // End snippet
        }

        /// <summary>Snippet for ExportAsync</summary>
        public async Task ExportRequestObjectAsync()
        {
            // Snippet: ExportAsync(SqlInstancesExportRequest, CallSettings)
            // Additional: ExportAsync(SqlInstancesExportRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesExportRequest request = new SqlInstancesExportRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesExportRequest(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.ExportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Failover</summary>
        public void FailoverRequestObject()
        {
            // Snippet: Failover(SqlInstancesFailoverRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesFailoverRequest request = new SqlInstancesFailoverRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesFailoverRequest(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.Failover(request);
            // End snippet
        }

        /// <summary>Snippet for FailoverAsync</summary>
        public async Task FailoverRequestObjectAsync()
        {
            // Snippet: FailoverAsync(SqlInstancesFailoverRequest, CallSettings)
            // Additional: FailoverAsync(SqlInstancesFailoverRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesFailoverRequest request = new SqlInstancesFailoverRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesFailoverRequest(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.FailoverAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Reencrypt</summary>
        public void ReencryptRequestObject()
        {
            // Snippet: Reencrypt(SqlInstancesReencryptRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesReencryptRequest request = new SqlInstancesReencryptRequest
            {
                Instance = "",
                Project = "",
                Body = new InstancesReencryptRequest(),
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.Reencrypt(request);
            // End snippet
        }

        /// <summary>Snippet for ReencryptAsync</summary>
        public async Task ReencryptRequestObjectAsync()
        {
            // Snippet: ReencryptAsync(SqlInstancesReencryptRequest, CallSettings)
            // Additional: ReencryptAsync(SqlInstancesReencryptRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesReencryptRequest request = new SqlInstancesReencryptRequest
            {
                Instance = "",
                Project = "",
                Body = new InstancesReencryptRequest(),
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.ReencryptAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(SqlInstancesGetRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesGetRequest request = new SqlInstancesGetRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            DatabaseInstance response = sqlInstancesServiceClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(SqlInstancesGetRequest, CallSettings)
            // Additional: GetAsync(SqlInstancesGetRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesGetRequest request = new SqlInstancesGetRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            DatabaseInstance response = await sqlInstancesServiceClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Import</summary>
        public void ImportRequestObject()
        {
            // Snippet: Import(SqlInstancesImportRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesImportRequest request = new SqlInstancesImportRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesImportRequest(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.Import(request);
            // End snippet
        }

        /// <summary>Snippet for ImportAsync</summary>
        public async Task ImportRequestObjectAsync()
        {
            // Snippet: ImportAsync(SqlInstancesImportRequest, CallSettings)
            // Additional: ImportAsync(SqlInstancesImportRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesImportRequest request = new SqlInstancesImportRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesImportRequest(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.ImportAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(SqlInstancesInsertRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesInsertRequest request = new SqlInstancesInsertRequest
            {
                Project = "",
                Location = "",
                Body = new DatabaseInstance(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(SqlInstancesInsertRequest, CallSettings)
            // Additional: InsertAsync(SqlInstancesInsertRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesInsertRequest request = new SqlInstancesInsertRequest
            {
                Project = "",
                Location = "",
                Body = new DatabaseInstance(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(SqlInstancesListRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesListRequest request = new SqlInstancesListRequest
            {
                Filter = "",
                Project = "",
                Location = "",
            };
            // Make the request
            PagedEnumerable<InstancesListResponse, ApiWarning> response = sqlInstancesServiceClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (ApiWarning item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (InstancesListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiWarning item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiWarning> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiWarning item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(SqlInstancesListRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesListRequest request = new SqlInstancesListRequest
            {
                Filter = "",
                Project = "",
                Location = "",
            };
            // Make the request
            PagedAsyncEnumerable<InstancesListResponse, ApiWarning> response = sqlInstancesServiceClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (ApiWarning item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (InstancesListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (ApiWarning item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<ApiWarning> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (ApiWarning item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListServerCas</summary>
        public void ListServerCasRequestObject()
        {
            // Snippet: ListServerCas(SqlInstancesListServerCasRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesListServerCasRequest request = new SqlInstancesListServerCasRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            InstancesListServerCasResponse response = sqlInstancesServiceClient.ListServerCas(request);
            // End snippet
        }

        /// <summary>Snippet for ListServerCasAsync</summary>
        public async Task ListServerCasRequestObjectAsync()
        {
            // Snippet: ListServerCasAsync(SqlInstancesListServerCasRequest, CallSettings)
            // Additional: ListServerCasAsync(SqlInstancesListServerCasRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesListServerCasRequest request = new SqlInstancesListServerCasRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            InstancesListServerCasResponse response = await sqlInstancesServiceClient.ListServerCasAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListServerCertificates</summary>
        public void ListServerCertificatesRequestObject()
        {
            // Snippet: ListServerCertificates(SqlInstancesListServerCertificatesRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesListServerCertificatesRequest request = new SqlInstancesListServerCertificatesRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            InstancesListServerCertificatesResponse response = sqlInstancesServiceClient.ListServerCertificates(request);
            // End snippet
        }

        /// <summary>Snippet for ListServerCertificatesAsync</summary>
        public async Task ListServerCertificatesRequestObjectAsync()
        {
            // Snippet: ListServerCertificatesAsync(SqlInstancesListServerCertificatesRequest, CallSettings)
            // Additional: ListServerCertificatesAsync(SqlInstancesListServerCertificatesRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesListServerCertificatesRequest request = new SqlInstancesListServerCertificatesRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            InstancesListServerCertificatesResponse response = await sqlInstancesServiceClient.ListServerCertificatesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ListEntraIdCertificates</summary>
        public void ListEntraIdCertificatesRequestObject()
        {
            // Snippet: ListEntraIdCertificates(SqlInstancesListEntraIdCertificatesRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesListEntraIdCertificatesRequest request = new SqlInstancesListEntraIdCertificatesRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            InstancesListEntraIdCertificatesResponse response = sqlInstancesServiceClient.ListEntraIdCertificates(request);
            // End snippet
        }

        /// <summary>Snippet for ListEntraIdCertificatesAsync</summary>
        public async Task ListEntraIdCertificatesRequestObjectAsync()
        {
            // Snippet: ListEntraIdCertificatesAsync(SqlInstancesListEntraIdCertificatesRequest, CallSettings)
            // Additional: ListEntraIdCertificatesAsync(SqlInstancesListEntraIdCertificatesRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesListEntraIdCertificatesRequest request = new SqlInstancesListEntraIdCertificatesRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            InstancesListEntraIdCertificatesResponse response = await sqlInstancesServiceClient.ListEntraIdCertificatesAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(SqlInstancesPatchRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesPatchRequest request = new SqlInstancesPatchRequest
            {
                Instance = "",
                Project = "",
                ReconcilePscNetworking = false,
                ReconcilePscNetworkingForce = false,
                Location = "",
                Body = new DatabaseInstance(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(SqlInstancesPatchRequest, CallSettings)
            // Additional: PatchAsync(SqlInstancesPatchRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesPatchRequest request = new SqlInstancesPatchRequest
            {
                Instance = "",
                Project = "",
                ReconcilePscNetworking = false,
                ReconcilePscNetworkingForce = false,
                Location = "",
                Body = new DatabaseInstance(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PromoteReplica</summary>
        public void PromoteReplicaRequestObject()
        {
            // Snippet: PromoteReplica(SqlInstancesPromoteReplicaRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesPromoteReplicaRequest request = new SqlInstancesPromoteReplicaRequest
            {
                Instance = "",
                Project = "",
                Failover = false,
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.PromoteReplica(request);
            // End snippet
        }

        /// <summary>Snippet for PromoteReplicaAsync</summary>
        public async Task PromoteReplicaRequestObjectAsync()
        {
            // Snippet: PromoteReplicaAsync(SqlInstancesPromoteReplicaRequest, CallSettings)
            // Additional: PromoteReplicaAsync(SqlInstancesPromoteReplicaRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesPromoteReplicaRequest request = new SqlInstancesPromoteReplicaRequest
            {
                Instance = "",
                Project = "",
                Failover = false,
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.PromoteReplicaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Switchover</summary>
        public void SwitchoverRequestObject()
        {
            // Snippet: Switchover(SqlInstancesSwitchoverRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesSwitchoverRequest request = new SqlInstancesSwitchoverRequest
            {
                Instance = "",
                Project = "",
                DbTimeout = new Duration(),
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.Switchover(request);
            // End snippet
        }

        /// <summary>Snippet for SwitchoverAsync</summary>
        public async Task SwitchoverRequestObjectAsync()
        {
            // Snippet: SwitchoverAsync(SqlInstancesSwitchoverRequest, CallSettings)
            // Additional: SwitchoverAsync(SqlInstancesSwitchoverRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesSwitchoverRequest request = new SqlInstancesSwitchoverRequest
            {
                Instance = "",
                Project = "",
                DbTimeout = new Duration(),
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.SwitchoverAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResetSslConfig</summary>
        public void ResetSslConfigRequestObject()
        {
            // Snippet: ResetSslConfig(SqlInstancesResetSslConfigRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesResetSslConfigRequest request = new SqlInstancesResetSslConfigRequest
            {
                Instance = "",
                Project = "",
                Mode = SqlInstancesResetSslConfigRequest.Types.ResetSslMode.Unspecified,
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.ResetSslConfig(request);
            // End snippet
        }

        /// <summary>Snippet for ResetSslConfigAsync</summary>
        public async Task ResetSslConfigRequestObjectAsync()
        {
            // Snippet: ResetSslConfigAsync(SqlInstancesResetSslConfigRequest, CallSettings)
            // Additional: ResetSslConfigAsync(SqlInstancesResetSslConfigRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesResetSslConfigRequest request = new SqlInstancesResetSslConfigRequest
            {
                Instance = "",
                Project = "",
                Mode = SqlInstancesResetSslConfigRequest.Types.ResetSslMode.Unspecified,
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.ResetSslConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Restart</summary>
        public void RestartRequestObject()
        {
            // Snippet: Restart(SqlInstancesRestartRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesRestartRequest request = new SqlInstancesRestartRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.Restart(request);
            // End snippet
        }

        /// <summary>Snippet for RestartAsync</summary>
        public async Task RestartRequestObjectAsync()
        {
            // Snippet: RestartAsync(SqlInstancesRestartRequest, CallSettings)
            // Additional: RestartAsync(SqlInstancesRestartRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesRestartRequest request = new SqlInstancesRestartRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.RestartAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RestoreBackup</summary>
        public void RestoreBackupRequestObject()
        {
            // Snippet: RestoreBackup(SqlInstancesRestoreBackupRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesRestoreBackupRequest request = new SqlInstancesRestoreBackupRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesRestoreBackupRequest(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.RestoreBackup(request);
            // End snippet
        }

        /// <summary>Snippet for RestoreBackupAsync</summary>
        public async Task RestoreBackupRequestObjectAsync()
        {
            // Snippet: RestoreBackupAsync(SqlInstancesRestoreBackupRequest, CallSettings)
            // Additional: RestoreBackupAsync(SqlInstancesRestoreBackupRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesRestoreBackupRequest request = new SqlInstancesRestoreBackupRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesRestoreBackupRequest(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.RestoreBackupAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RotateServerCa</summary>
        public void RotateServerCaRequestObject()
        {
            // Snippet: RotateServerCa(SqlInstancesRotateServerCaRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesRotateServerCaRequest request = new SqlInstancesRotateServerCaRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesRotateServerCaRequest(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.RotateServerCa(request);
            // End snippet
        }

        /// <summary>Snippet for RotateServerCaAsync</summary>
        public async Task RotateServerCaRequestObjectAsync()
        {
            // Snippet: RotateServerCaAsync(SqlInstancesRotateServerCaRequest, CallSettings)
            // Additional: RotateServerCaAsync(SqlInstancesRotateServerCaRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesRotateServerCaRequest request = new SqlInstancesRotateServerCaRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesRotateServerCaRequest(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.RotateServerCaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RotateServerCertificate</summary>
        public void RotateServerCertificateRequestObject()
        {
            // Snippet: RotateServerCertificate(SqlInstancesRotateServerCertificateRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesRotateServerCertificateRequest request = new SqlInstancesRotateServerCertificateRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesRotateServerCertificateRequest(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.RotateServerCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for RotateServerCertificateAsync</summary>
        public async Task RotateServerCertificateRequestObjectAsync()
        {
            // Snippet: RotateServerCertificateAsync(SqlInstancesRotateServerCertificateRequest, CallSettings)
            // Additional: RotateServerCertificateAsync(SqlInstancesRotateServerCertificateRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesRotateServerCertificateRequest request = new SqlInstancesRotateServerCertificateRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesRotateServerCertificateRequest(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.RotateServerCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RotateEntraIdCertificate</summary>
        public void RotateEntraIdCertificateRequestObject()
        {
            // Snippet: RotateEntraIdCertificate(SqlInstancesRotateEntraIdCertificateRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesRotateEntraIdCertificateRequest request = new SqlInstancesRotateEntraIdCertificateRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesRotateEntraIdCertificateRequest(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.RotateEntraIdCertificate(request);
            // End snippet
        }

        /// <summary>Snippet for RotateEntraIdCertificateAsync</summary>
        public async Task RotateEntraIdCertificateRequestObjectAsync()
        {
            // Snippet: RotateEntraIdCertificateAsync(SqlInstancesRotateEntraIdCertificateRequest, CallSettings)
            // Additional: RotateEntraIdCertificateAsync(SqlInstancesRotateEntraIdCertificateRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesRotateEntraIdCertificateRequest request = new SqlInstancesRotateEntraIdCertificateRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesRotateEntraIdCertificateRequest(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.RotateEntraIdCertificateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartReplica</summary>
        public void StartReplicaRequestObject()
        {
            // Snippet: StartReplica(SqlInstancesStartReplicaRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesStartReplicaRequest request = new SqlInstancesStartReplicaRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.StartReplica(request);
            // End snippet
        }

        /// <summary>Snippet for StartReplicaAsync</summary>
        public async Task StartReplicaRequestObjectAsync()
        {
            // Snippet: StartReplicaAsync(SqlInstancesStartReplicaRequest, CallSettings)
            // Additional: StartReplicaAsync(SqlInstancesStartReplicaRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesStartReplicaRequest request = new SqlInstancesStartReplicaRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.StartReplicaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StopReplica</summary>
        public void StopReplicaRequestObject()
        {
            // Snippet: StopReplica(SqlInstancesStopReplicaRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesStopReplicaRequest request = new SqlInstancesStopReplicaRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.StopReplica(request);
            // End snippet
        }

        /// <summary>Snippet for StopReplicaAsync</summary>
        public async Task StopReplicaRequestObjectAsync()
        {
            // Snippet: StopReplicaAsync(SqlInstancesStopReplicaRequest, CallSettings)
            // Additional: StopReplicaAsync(SqlInstancesStopReplicaRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesStopReplicaRequest request = new SqlInstancesStopReplicaRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.StopReplicaAsync(request);
            // End snippet
        }

        /// <summary>Snippet for TruncateLog</summary>
        public void TruncateLogRequestObject()
        {
            // Snippet: TruncateLog(SqlInstancesTruncateLogRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesTruncateLogRequest request = new SqlInstancesTruncateLogRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesTruncateLogRequest(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.TruncateLog(request);
            // End snippet
        }

        /// <summary>Snippet for TruncateLogAsync</summary>
        public async Task TruncateLogRequestObjectAsync()
        {
            // Snippet: TruncateLogAsync(SqlInstancesTruncateLogRequest, CallSettings)
            // Additional: TruncateLogAsync(SqlInstancesTruncateLogRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesTruncateLogRequest request = new SqlInstancesTruncateLogRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesTruncateLogRequest(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.TruncateLogAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(SqlInstancesUpdateRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesUpdateRequest request = new SqlInstancesUpdateRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new DatabaseInstance(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.Update(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(SqlInstancesUpdateRequest, CallSettings)
            // Additional: UpdateAsync(SqlInstancesUpdateRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesUpdateRequest request = new SqlInstancesUpdateRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new DatabaseInstance(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.UpdateAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEphemeral</summary>
        public void CreateEphemeralRequestObject()
        {
            // Snippet: CreateEphemeral(SqlInstancesCreateEphemeralCertRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesCreateEphemeralCertRequest request = new SqlInstancesCreateEphemeralCertRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new SslCertsCreateEphemeralRequest(),
            };
            // Make the request
            SslCert response = sqlInstancesServiceClient.CreateEphemeral(request);
            // End snippet
        }

        /// <summary>Snippet for CreateEphemeralAsync</summary>
        public async Task CreateEphemeralRequestObjectAsync()
        {
            // Snippet: CreateEphemeralAsync(SqlInstancesCreateEphemeralCertRequest, CallSettings)
            // Additional: CreateEphemeralAsync(SqlInstancesCreateEphemeralCertRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesCreateEphemeralCertRequest request = new SqlInstancesCreateEphemeralCertRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new SslCertsCreateEphemeralRequest(),
            };
            // Make the request
            SslCert response = await sqlInstancesServiceClient.CreateEphemeralAsync(request);
            // End snippet
        }

        /// <summary>Snippet for RescheduleMaintenance</summary>
        public void RescheduleMaintenanceRequestObject()
        {
            // Snippet: RescheduleMaintenance(SqlInstancesRescheduleMaintenanceRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesRescheduleMaintenanceRequest request = new SqlInstancesRescheduleMaintenanceRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new SqlInstancesRescheduleMaintenanceRequestBody(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.RescheduleMaintenance(request);
            // End snippet
        }

        /// <summary>Snippet for RescheduleMaintenanceAsync</summary>
        public async Task RescheduleMaintenanceRequestObjectAsync()
        {
            // Snippet: RescheduleMaintenanceAsync(SqlInstancesRescheduleMaintenanceRequest, CallSettings)
            // Additional: RescheduleMaintenanceAsync(SqlInstancesRescheduleMaintenanceRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesRescheduleMaintenanceRequest request = new SqlInstancesRescheduleMaintenanceRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new SqlInstancesRescheduleMaintenanceRequestBody(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.RescheduleMaintenanceAsync(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyExternalSyncSettings</summary>
        public void VerifyExternalSyncSettingsRequestObject()
        {
            // Snippet: VerifyExternalSyncSettings(SqlInstancesVerifyExternalSyncSettingsRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesVerifyExternalSyncSettingsRequest request = new SqlInstancesVerifyExternalSyncSettingsRequest
            {
                Instance = "",
                Project = "",
                VerifyConnectionOnly = false,
                SyncMode = SqlInstancesVerifyExternalSyncSettingsRequest.Types.ExternalSyncMode.Unspecified,
                VerifyReplicationOnly = false,
                MysqlSyncConfig = new MySqlSyncConfig(),
                MigrationType = SqlInstancesVerifyExternalSyncSettingsRequest.Types.MigrationType.Unspecified,
                SyncParallelLevel = ExternalSyncParallelLevel.Unspecified,
                SelectedObjects =
                {
                    new ExternalSyncSelectedObject(),
                },
                Location = "",
            };
            // Make the request
            SqlInstancesVerifyExternalSyncSettingsResponse response = sqlInstancesServiceClient.VerifyExternalSyncSettings(request);
            // End snippet
        }

        /// <summary>Snippet for VerifyExternalSyncSettingsAsync</summary>
        public async Task VerifyExternalSyncSettingsRequestObjectAsync()
        {
            // Snippet: VerifyExternalSyncSettingsAsync(SqlInstancesVerifyExternalSyncSettingsRequest, CallSettings)
            // Additional: VerifyExternalSyncSettingsAsync(SqlInstancesVerifyExternalSyncSettingsRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesVerifyExternalSyncSettingsRequest request = new SqlInstancesVerifyExternalSyncSettingsRequest
            {
                Instance = "",
                Project = "",
                VerifyConnectionOnly = false,
                SyncMode = SqlInstancesVerifyExternalSyncSettingsRequest.Types.ExternalSyncMode.Unspecified,
                VerifyReplicationOnly = false,
                MysqlSyncConfig = new MySqlSyncConfig(),
                MigrationType = SqlInstancesVerifyExternalSyncSettingsRequest.Types.MigrationType.Unspecified,
                SyncParallelLevel = ExternalSyncParallelLevel.Unspecified,
                SelectedObjects =
                {
                    new ExternalSyncSelectedObject(),
                },
                Location = "",
            };
            // Make the request
            SqlInstancesVerifyExternalSyncSettingsResponse response = await sqlInstancesServiceClient.VerifyExternalSyncSettingsAsync(request);
            // End snippet
        }

        /// <summary>Snippet for StartExternalSync</summary>
        public void StartExternalSyncRequestObject()
        {
            // Snippet: StartExternalSync(SqlInstancesStartExternalSyncRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesStartExternalSyncRequest request = new SqlInstancesStartExternalSyncRequest
            {
                Instance = "",
                Project = "",
                SyncMode = SqlInstancesVerifyExternalSyncSettingsRequest.Types.ExternalSyncMode.Unspecified,
                SkipVerification = false,
                MysqlSyncConfig = new MySqlSyncConfig(),
                SyncParallelLevel = ExternalSyncParallelLevel.Unspecified,
                MigrationType = SqlInstancesVerifyExternalSyncSettingsRequest.Types.MigrationType.Unspecified,
                ReplicaOverwriteEnabled = false,
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.StartExternalSync(request);
            // End snippet
        }

        /// <summary>Snippet for StartExternalSyncAsync</summary>
        public async Task StartExternalSyncRequestObjectAsync()
        {
            // Snippet: StartExternalSyncAsync(SqlInstancesStartExternalSyncRequest, CallSettings)
            // Additional: StartExternalSyncAsync(SqlInstancesStartExternalSyncRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesStartExternalSyncRequest request = new SqlInstancesStartExternalSyncRequest
            {
                Instance = "",
                Project = "",
                SyncMode = SqlInstancesVerifyExternalSyncSettingsRequest.Types.ExternalSyncMode.Unspecified,
                SkipVerification = false,
                MysqlSyncConfig = new MySqlSyncConfig(),
                SyncParallelLevel = ExternalSyncParallelLevel.Unspecified,
                MigrationType = SqlInstancesVerifyExternalSyncSettingsRequest.Types.MigrationType.Unspecified,
                ReplicaOverwriteEnabled = false,
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.StartExternalSyncAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PerformDiskShrink</summary>
        public void PerformDiskShrinkRequestObject()
        {
            // Snippet: PerformDiskShrink(SqlInstancesPerformDiskShrinkRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesPerformDiskShrinkRequest request = new SqlInstancesPerformDiskShrinkRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new PerformDiskShrinkContext(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.PerformDiskShrink(request);
            // End snippet
        }

        /// <summary>Snippet for PerformDiskShrinkAsync</summary>
        public async Task PerformDiskShrinkRequestObjectAsync()
        {
            // Snippet: PerformDiskShrinkAsync(SqlInstancesPerformDiskShrinkRequest, CallSettings)
            // Additional: PerformDiskShrinkAsync(SqlInstancesPerformDiskShrinkRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesPerformDiskShrinkRequest request = new SqlInstancesPerformDiskShrinkRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new PerformDiskShrinkContext(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.PerformDiskShrinkAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiskShrinkConfig</summary>
        public void GetDiskShrinkConfigRequestObject()
        {
            // Snippet: GetDiskShrinkConfig(SqlInstancesGetDiskShrinkConfigRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesGetDiskShrinkConfigRequest request = new SqlInstancesGetDiskShrinkConfigRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            SqlInstancesGetDiskShrinkConfigResponse response = sqlInstancesServiceClient.GetDiskShrinkConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetDiskShrinkConfigAsync</summary>
        public async Task GetDiskShrinkConfigRequestObjectAsync()
        {
            // Snippet: GetDiskShrinkConfigAsync(SqlInstancesGetDiskShrinkConfigRequest, CallSettings)
            // Additional: GetDiskShrinkConfigAsync(SqlInstancesGetDiskShrinkConfigRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesGetDiskShrinkConfigRequest request = new SqlInstancesGetDiskShrinkConfigRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            SqlInstancesGetDiskShrinkConfigResponse response = await sqlInstancesServiceClient.GetDiskShrinkConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ResetReplicaSize</summary>
        public void ResetReplicaSizeRequestObject()
        {
            // Snippet: ResetReplicaSize(SqlInstancesResetReplicaSizeRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesResetReplicaSizeRequest request = new SqlInstancesResetReplicaSizeRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.ResetReplicaSize(request);
            // End snippet
        }

        /// <summary>Snippet for ResetReplicaSizeAsync</summary>
        public async Task ResetReplicaSizeRequestObjectAsync()
        {
            // Snippet: ResetReplicaSizeAsync(SqlInstancesResetReplicaSizeRequest, CallSettings)
            // Additional: ResetReplicaSizeAsync(SqlInstancesResetReplicaSizeRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesResetReplicaSizeRequest request = new SqlInstancesResetReplicaSizeRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.ResetReplicaSizeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetLatestRecoveryTime</summary>
        public void GetLatestRecoveryTimeRequestObject()
        {
            // Snippet: GetLatestRecoveryTime(SqlInstancesGetLatestRecoveryTimeRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesGetLatestRecoveryTimeRequest request = new SqlInstancesGetLatestRecoveryTimeRequest
            {
                Instance = "",
                Project = "",
                SourceInstanceDeletionTime = new Timestamp(),
                Location = "",
            };
            // Make the request
            SqlInstancesGetLatestRecoveryTimeResponse response = sqlInstancesServiceClient.GetLatestRecoveryTime(request);
            // End snippet
        }

        /// <summary>Snippet for GetLatestRecoveryTimeAsync</summary>
        public async Task GetLatestRecoveryTimeRequestObjectAsync()
        {
            // Snippet: GetLatestRecoveryTimeAsync(SqlInstancesGetLatestRecoveryTimeRequest, CallSettings)
            // Additional: GetLatestRecoveryTimeAsync(SqlInstancesGetLatestRecoveryTimeRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesGetLatestRecoveryTimeRequest request = new SqlInstancesGetLatestRecoveryTimeRequest
            {
                Instance = "",
                Project = "",
                SourceInstanceDeletionTime = new Timestamp(),
                Location = "",
            };
            // Make the request
            SqlInstancesGetLatestRecoveryTimeResponse response = await sqlInstancesServiceClient.GetLatestRecoveryTimeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteSql</summary>
        public void ExecuteSqlRequestObject()
        {
            // Snippet: ExecuteSql(SqlInstancesExecuteSqlRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesExecuteSqlRequest request = new SqlInstancesExecuteSqlRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new ExecuteSqlPayload(),
            };
            // Make the request
            SqlInstancesExecuteSqlResponse response = sqlInstancesServiceClient.ExecuteSql(request);
            // End snippet
        }

        /// <summary>Snippet for ExecuteSqlAsync</summary>
        public async Task ExecuteSqlRequestObjectAsync()
        {
            // Snippet: ExecuteSqlAsync(SqlInstancesExecuteSqlRequest, CallSettings)
            // Additional: ExecuteSqlAsync(SqlInstancesExecuteSqlRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesExecuteSqlRequest request = new SqlInstancesExecuteSqlRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new ExecuteSqlPayload(),
            };
            // Make the request
            SqlInstancesExecuteSqlResponse response = await sqlInstancesServiceClient.ExecuteSqlAsync(request);
            // End snippet
        }

        /// <summary>Snippet for AcquireSsrsLease</summary>
        public void AcquireSsrsLeaseRequestObject()
        {
            // Snippet: AcquireSsrsLease(SqlInstancesAcquireSsrsLeaseRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesAcquireSsrsLeaseRequest request = new SqlInstancesAcquireSsrsLeaseRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesAcquireSsrsLeaseRequest(),
            };
            // Make the request
            SqlInstancesAcquireSsrsLeaseResponse response = sqlInstancesServiceClient.AcquireSsrsLease(request);
            // End snippet
        }

        /// <summary>Snippet for AcquireSsrsLeaseAsync</summary>
        public async Task AcquireSsrsLeaseRequestObjectAsync()
        {
            // Snippet: AcquireSsrsLeaseAsync(SqlInstancesAcquireSsrsLeaseRequest, CallSettings)
            // Additional: AcquireSsrsLeaseAsync(SqlInstancesAcquireSsrsLeaseRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesAcquireSsrsLeaseRequest request = new SqlInstancesAcquireSsrsLeaseRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new InstancesAcquireSsrsLeaseRequest(),
            };
            // Make the request
            SqlInstancesAcquireSsrsLeaseResponse response = await sqlInstancesServiceClient.AcquireSsrsLeaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for ReleaseSsrsLease</summary>
        public void ReleaseSsrsLeaseRequestObject()
        {
            // Snippet: ReleaseSsrsLease(SqlInstancesReleaseSsrsLeaseRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesReleaseSsrsLeaseRequest request = new SqlInstancesReleaseSsrsLeaseRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            SqlInstancesReleaseSsrsLeaseResponse response = sqlInstancesServiceClient.ReleaseSsrsLease(request);
            // End snippet
        }

        /// <summary>Snippet for ReleaseSsrsLeaseAsync</summary>
        public async Task ReleaseSsrsLeaseRequestObjectAsync()
        {
            // Snippet: ReleaseSsrsLeaseAsync(SqlInstancesReleaseSsrsLeaseRequest, CallSettings)
            // Additional: ReleaseSsrsLeaseAsync(SqlInstancesReleaseSsrsLeaseRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesReleaseSsrsLeaseRequest request = new SqlInstancesReleaseSsrsLeaseRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            SqlInstancesReleaseSsrsLeaseResponse response = await sqlInstancesServiceClient.ReleaseSsrsLeaseAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PreCheckMajorVersionUpgrade</summary>
        public void PreCheckMajorVersionUpgradeRequestObject()
        {
            // Snippet: PreCheckMajorVersionUpgrade(SqlInstancesPreCheckMajorVersionUpgradeRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesPreCheckMajorVersionUpgradeRequest request = new SqlInstancesPreCheckMajorVersionUpgradeRequest
            {
                Instance = "",
                Project = "",
                Body = new InstancesPreCheckMajorVersionUpgradeRequest(),
                Location = "",
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.PreCheckMajorVersionUpgrade(request);
            // End snippet
        }

        /// <summary>Snippet for PreCheckMajorVersionUpgradeAsync</summary>
        public async Task PreCheckMajorVersionUpgradeRequestObjectAsync()
        {
            // Snippet: PreCheckMajorVersionUpgradeAsync(SqlInstancesPreCheckMajorVersionUpgradeRequest, CallSettings)
            // Additional: PreCheckMajorVersionUpgradeAsync(SqlInstancesPreCheckMajorVersionUpgradeRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesPreCheckMajorVersionUpgradeRequest request = new SqlInstancesPreCheckMajorVersionUpgradeRequest
            {
                Instance = "",
                Project = "",
                Body = new InstancesPreCheckMajorVersionUpgradeRequest(),
                Location = "",
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.PreCheckMajorVersionUpgradeAsync(request);
            // End snippet
        }

        /// <summary>Snippet for PointInTimeRestore</summary>
        public void PointInTimeRestoreRequestObject()
        {
            // Snippet: PointInTimeRestore(SqlInstancesPointInTimeRestoreRequest, CallSettings)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = SqlInstancesServiceClient.Create();
            // Initialize request argument(s)
            SqlInstancesPointInTimeRestoreRequest request = new SqlInstancesPointInTimeRestoreRequest
            {
                Parent = "",
                Context = new PointInTimeRestoreContext(),
            };
            // Make the request
            Operation response = sqlInstancesServiceClient.PointInTimeRestore(request);
            // End snippet
        }

        /// <summary>Snippet for PointInTimeRestoreAsync</summary>
        public async Task PointInTimeRestoreRequestObjectAsync()
        {
            // Snippet: PointInTimeRestoreAsync(SqlInstancesPointInTimeRestoreRequest, CallSettings)
            // Additional: PointInTimeRestoreAsync(SqlInstancesPointInTimeRestoreRequest, CancellationToken)
            // Create client
            SqlInstancesServiceClient sqlInstancesServiceClient = await SqlInstancesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlInstancesPointInTimeRestoreRequest request = new SqlInstancesPointInTimeRestoreRequest
            {
                Parent = "",
                Context = new PointInTimeRestoreContext(),
            };
            // Make the request
            Operation response = await sqlInstancesServiceClient.PointInTimeRestoreAsync(request);
            // End snippet
        }
    }
}
