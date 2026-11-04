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
    using Google.Cloud.Sql.V1;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSqlTiersServiceClientSnippets
    {
        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(SqlTiersListRequest, CallSettings)
            // Create client
            SqlTiersServiceClient sqlTiersServiceClient = SqlTiersServiceClient.Create();
            // Initialize request argument(s)
            SqlTiersListRequest request = new SqlTiersListRequest { Project = "", };
            // Make the request
            TiersListResponse response = sqlTiersServiceClient.List(request);
            // End snippet
        }

        /// <summary>Snippet for ListAsync</summary>
        public async Task ListRequestObjectAsync()
        {
            // Snippet: ListAsync(SqlTiersListRequest, CallSettings)
            // Additional: ListAsync(SqlTiersListRequest, CancellationToken)
            // Create client
            SqlTiersServiceClient sqlTiersServiceClient = await SqlTiersServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlTiersListRequest request = new SqlTiersListRequest { Project = "", };
            // Make the request
            TiersListResponse response = await sqlTiersServiceClient.ListAsync(request);
            // End snippet
        }
    }
}
