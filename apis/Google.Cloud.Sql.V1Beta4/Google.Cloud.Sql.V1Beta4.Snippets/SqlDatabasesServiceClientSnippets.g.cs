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
    using Google.Cloud.Sql.V1Beta4;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSqlDatabasesServiceClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(SqlDatabasesDeleteRequest, CallSettings)
            // Create client
            SqlDatabasesServiceClient sqlDatabasesServiceClient = SqlDatabasesServiceClient.Create();
            // Initialize request argument(s)
            SqlDatabasesDeleteRequest request = new SqlDatabasesDeleteRequest
            {
                Database = "",
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = sqlDatabasesServiceClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(SqlDatabasesDeleteRequest, CallSettings)
            // Additional: DeleteAsync(SqlDatabasesDeleteRequest, CancellationToken)
            // Create client
            SqlDatabasesServiceClient sqlDatabasesServiceClient = await SqlDatabasesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlDatabasesDeleteRequest request = new SqlDatabasesDeleteRequest
            {
                Database = "",
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = await sqlDatabasesServiceClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(SqlDatabasesGetRequest, CallSettings)
            // Create client
            SqlDatabasesServiceClient sqlDatabasesServiceClient = SqlDatabasesServiceClient.Create();
            // Initialize request argument(s)
            SqlDatabasesGetRequest request = new SqlDatabasesGetRequest
            {
                Database = "",
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Database response = sqlDatabasesServiceClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(SqlDatabasesGetRequest, CallSettings)
            // Additional: GetAsync(SqlDatabasesGetRequest, CancellationToken)
            // Create client
            SqlDatabasesServiceClient sqlDatabasesServiceClient = await SqlDatabasesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlDatabasesGetRequest request = new SqlDatabasesGetRequest
            {
                Database = "",
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Database response = await sqlDatabasesServiceClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(SqlDatabasesInsertRequest, CallSettings)
            // Create client
            SqlDatabasesServiceClient sqlDatabasesServiceClient = SqlDatabasesServiceClient.Create();
            // Initialize request argument(s)
            SqlDatabasesInsertRequest request = new SqlDatabasesInsertRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new Database(),
            };
            // Make the request
            Operation response = sqlDatabasesServiceClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(SqlDatabasesInsertRequest, CallSettings)
            // Additional: InsertAsync(SqlDatabasesInsertRequest, CancellationToken)
            // Create client
            SqlDatabasesServiceClient sqlDatabasesServiceClient = await SqlDatabasesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlDatabasesInsertRequest request = new SqlDatabasesInsertRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new Database(),
            };
            // Make the request
            Operation response = await sqlDatabasesServiceClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(SqlDatabasesListRequest, CallSettings)
            // Create client
            SqlDatabasesServiceClient sqlDatabasesServiceClient = SqlDatabasesServiceClient.Create();
            // Initialize request argument(s)
            SqlDatabasesListRequest request = new SqlDatabasesListRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            DatabasesListResponse response = sqlDatabasesServiceClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(SqlDatabasesListRequest, CallSettings)
            // Additional: ListAsync(SqlDatabasesListRequest, CancellationToken)
            // Create client
            SqlDatabasesServiceClient sqlDatabasesServiceClient = await SqlDatabasesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlDatabasesListRequest request = new SqlDatabasesListRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            DatabasesListResponse response = await sqlDatabasesServiceClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Patch</summary>
        public void PatchRequestObject()
        {
            // Snippet: Patch(SqlDatabasesUpdateRequest, CallSettings)
            // Create client
            SqlDatabasesServiceClient sqlDatabasesServiceClient = SqlDatabasesServiceClient.Create();
            // Initialize request argument(s)
            SqlDatabasesUpdateRequest request = new SqlDatabasesUpdateRequest
            {
                Database = "",
                Instance = "",
                Project = "",
                Location = "",
                Body = new Database(),
            };
            // Make the request
            Operation response = sqlDatabasesServiceClient.Patch(request);
            // End snippet
        }

        /// <summary>Snippet for PatchAsync</summary>
        public async Task PatchRequestObjectAsync()
        {
            // Snippet: PatchAsync(SqlDatabasesUpdateRequest, CallSettings)
            // Additional: PatchAsync(SqlDatabasesUpdateRequest, CancellationToken)
            // Create client
            SqlDatabasesServiceClient sqlDatabasesServiceClient = await SqlDatabasesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlDatabasesUpdateRequest request = new SqlDatabasesUpdateRequest
            {
                Database = "",
                Instance = "",
                Project = "",
                Location = "",
                Body = new Database(),
            };
            // Make the request
            Operation response = await sqlDatabasesServiceClient.PatchAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(SqlDatabasesUpdateRequest, CallSettings)
            // Create client
            SqlDatabasesServiceClient sqlDatabasesServiceClient = SqlDatabasesServiceClient.Create();
            // Initialize request argument(s)
            SqlDatabasesUpdateRequest request = new SqlDatabasesUpdateRequest
            {
                Database = "",
                Instance = "",
                Project = "",
                Location = "",
                Body = new Database(),
            };
            // Make the request
            Operation response = sqlDatabasesServiceClient.Update(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(SqlDatabasesUpdateRequest, CallSettings)
            // Additional: UpdateAsync(SqlDatabasesUpdateRequest, CancellationToken)
            // Create client
            SqlDatabasesServiceClient sqlDatabasesServiceClient = await SqlDatabasesServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlDatabasesUpdateRequest request = new SqlDatabasesUpdateRequest
            {
                Database = "",
                Instance = "",
                Project = "",
                Location = "",
                Body = new Database(),
            };
            // Make the request
            Operation response = await sqlDatabasesServiceClient.UpdateAsync(request);
            // End snippet
        }
    }
}
