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
    public sealed class AllGeneratedSqlUsersServiceClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(SqlUsersDeleteRequest, CallSettings)
            // Create client
            SqlUsersServiceClient sqlUsersServiceClient = SqlUsersServiceClient.Create();
            // Initialize request argument(s)
            SqlUsersDeleteRequest request = new SqlUsersDeleteRequest
            {
                Host = "",
                Instance = "",
                Name = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = sqlUsersServiceClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(SqlUsersDeleteRequest, CallSettings)
            // Additional: DeleteAsync(SqlUsersDeleteRequest, CancellationToken)
            // Create client
            SqlUsersServiceClient sqlUsersServiceClient = await SqlUsersServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlUsersDeleteRequest request = new SqlUsersDeleteRequest
            {
                Host = "",
                Instance = "",
                Name = "",
                Project = "",
                Location = "",
            };
            // Make the request
            Operation response = await sqlUsersServiceClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(SqlUsersGetRequest, CallSettings)
            // Create client
            SqlUsersServiceClient sqlUsersServiceClient = SqlUsersServiceClient.Create();
            // Initialize request argument(s)
            SqlUsersGetRequest request = new SqlUsersGetRequest
            {
                Instance = "",
                Name = "",
                Project = "",
                Host = "",
                Location = "",
            };
            // Make the request
            User response = sqlUsersServiceClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(SqlUsersGetRequest, CallSettings)
            // Additional: GetAsync(SqlUsersGetRequest, CancellationToken)
            // Create client
            SqlUsersServiceClient sqlUsersServiceClient = await SqlUsersServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlUsersGetRequest request = new SqlUsersGetRequest
            {
                Instance = "",
                Name = "",
                Project = "",
                Host = "",
                Location = "",
            };
            // Make the request
            User response = await sqlUsersServiceClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(SqlUsersInsertRequest, CallSettings)
            // Create client
            SqlUsersServiceClient sqlUsersServiceClient = SqlUsersServiceClient.Create();
            // Initialize request argument(s)
            SqlUsersInsertRequest request = new SqlUsersInsertRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new User(),
            };
            // Make the request
            Operation response = sqlUsersServiceClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(SqlUsersInsertRequest, CallSettings)
            // Additional: InsertAsync(SqlUsersInsertRequest, CancellationToken)
            // Create client
            SqlUsersServiceClient sqlUsersServiceClient = await SqlUsersServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlUsersInsertRequest request = new SqlUsersInsertRequest
            {
                Instance = "",
                Project = "",
                Location = "",
                Body = new User(),
            };
            // Make the request
            Operation response = await sqlUsersServiceClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(SqlUsersListRequest, CallSettings)
            // Create client
            SqlUsersServiceClient sqlUsersServiceClient = SqlUsersServiceClient.Create();
            // Initialize request argument(s)
            SqlUsersListRequest request = new SqlUsersListRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            UsersListResponse response = sqlUsersServiceClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(SqlUsersListRequest, CallSettings)
            // Additional: ListAsync(SqlUsersListRequest, CancellationToken)
            // Create client
            SqlUsersServiceClient sqlUsersServiceClient = await SqlUsersServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlUsersListRequest request = new SqlUsersListRequest
            {
                Instance = "",
                Project = "",
                Location = "",
            };
            // Make the request
            UsersListResponse response = await sqlUsersServiceClient.ListAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Update</summary>
        public void UpdateRequestObject()
        {
            // Snippet: Update(SqlUsersUpdateRequest, CallSettings)
            // Create client
            SqlUsersServiceClient sqlUsersServiceClient = SqlUsersServiceClient.Create();
            // Initialize request argument(s)
            SqlUsersUpdateRequest request = new SqlUsersUpdateRequest
            {
                Host = "",
                Instance = "",
                Name = "",
                Project = "",
                DatabaseRoles = { "", },
                RevokeExistingRoles = false,
                ServerRoles = { "", },
                RevokeExistingServerRoles = false,
                Location = "",
                Body = new User(),
            };
            // Make the request
            Operation response = sqlUsersServiceClient.Update(request);
            // End snippet
        }

        /// <summary>Snippet for UpdateAsync</summary>
        public async Task UpdateRequestObjectAsync()
        {
            // Snippet: UpdateAsync(SqlUsersUpdateRequest, CallSettings)
            // Additional: UpdateAsync(SqlUsersUpdateRequest, CancellationToken)
            // Create client
            SqlUsersServiceClient sqlUsersServiceClient = await SqlUsersServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlUsersUpdateRequest request = new SqlUsersUpdateRequest
            {
                Host = "",
                Instance = "",
                Name = "",
                Project = "",
                DatabaseRoles = { "", },
                RevokeExistingRoles = false,
                ServerRoles = { "", },
                RevokeExistingServerRoles = false,
                Location = "",
                Body = new User(),
            };
            // Make the request
            Operation response = await sqlUsersServiceClient.UpdateAsync(request);
            // End snippet
        }
    }
}
