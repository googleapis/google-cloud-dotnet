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
    using System;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedSqlBackupRunsServiceClientSnippets
    {
        /// <summary>Snippet for Delete</summary>
        public void DeleteRequestObject()
        {
            // Snippet: Delete(SqlBackupRunsDeleteRequest, CallSettings)
            // Create client
            SqlBackupRunsServiceClient sqlBackupRunsServiceClient = SqlBackupRunsServiceClient.Create();
            // Initialize request argument(s)
            SqlBackupRunsDeleteRequest request = new SqlBackupRunsDeleteRequest
            {
                Id = 0L,
                Instance = "",
                Project = "",
            };
            // Make the request
            Operation response = sqlBackupRunsServiceClient.Delete(request);
            // End snippet
        }

        /// <summary>Snippet for DeleteAsync</summary>
        public async Task DeleteRequestObjectAsync()
        {
            // Snippet: DeleteAsync(SqlBackupRunsDeleteRequest, CallSettings)
            // Additional: DeleteAsync(SqlBackupRunsDeleteRequest, CancellationToken)
            // Create client
            SqlBackupRunsServiceClient sqlBackupRunsServiceClient = await SqlBackupRunsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlBackupRunsDeleteRequest request = new SqlBackupRunsDeleteRequest
            {
                Id = 0L,
                Instance = "",
                Project = "",
            };
            // Make the request
            Operation response = await sqlBackupRunsServiceClient.DeleteAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Get</summary>
        public void GetRequestObject()
        {
            // Snippet: Get(SqlBackupRunsGetRequest, CallSettings)
            // Create client
            SqlBackupRunsServiceClient sqlBackupRunsServiceClient = SqlBackupRunsServiceClient.Create();
            // Initialize request argument(s)
            SqlBackupRunsGetRequest request = new SqlBackupRunsGetRequest
            {
                Id = 0L,
                Instance = "",
                Project = "",
            };
            // Make the request
            BackupRun response = sqlBackupRunsServiceClient.Get(request);
            // End snippet
        }

        /// <summary>Snippet for GetAsync</summary>
        public async Task GetRequestObjectAsync()
        {
            // Snippet: GetAsync(SqlBackupRunsGetRequest, CallSettings)
            // Additional: GetAsync(SqlBackupRunsGetRequest, CancellationToken)
            // Create client
            SqlBackupRunsServiceClient sqlBackupRunsServiceClient = await SqlBackupRunsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlBackupRunsGetRequest request = new SqlBackupRunsGetRequest
            {
                Id = 0L,
                Instance = "",
                Project = "",
            };
            // Make the request
            BackupRun response = await sqlBackupRunsServiceClient.GetAsync(request);
            // End snippet
        }

        /// <summary>Snippet for Insert</summary>
        public void InsertRequestObject()
        {
            // Snippet: Insert(SqlBackupRunsInsertRequest, CallSettings)
            // Create client
            SqlBackupRunsServiceClient sqlBackupRunsServiceClient = SqlBackupRunsServiceClient.Create();
            // Initialize request argument(s)
            SqlBackupRunsInsertRequest request = new SqlBackupRunsInsertRequest
            {
                Instance = "",
                Project = "",
                Body = new BackupRun(),
            };
            // Make the request
            Operation response = sqlBackupRunsServiceClient.Insert(request);
            // End snippet
        }

        /// <summary>Snippet for InsertAsync</summary>
        public async Task InsertRequestObjectAsync()
        {
            // Snippet: InsertAsync(SqlBackupRunsInsertRequest, CallSettings)
            // Additional: InsertAsync(SqlBackupRunsInsertRequest, CancellationToken)
            // Create client
            SqlBackupRunsServiceClient sqlBackupRunsServiceClient = await SqlBackupRunsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlBackupRunsInsertRequest request = new SqlBackupRunsInsertRequest
            {
                Instance = "",
                Project = "",
                Body = new BackupRun(),
            };
            // Make the request
            Operation response = await sqlBackupRunsServiceClient.InsertAsync(request);
            // End snippet
        }

        /// <summary>Snippet for List</summary>
        public void ListRequestObject()
        {
            // Snippet: List(SqlBackupRunsListRequest, CallSettings)
            // Create client
            SqlBackupRunsServiceClient sqlBackupRunsServiceClient = SqlBackupRunsServiceClient.Create();
            // Initialize request argument(s)
            SqlBackupRunsListRequest request = new SqlBackupRunsListRequest
            {
                Instance = "",
                Project = "",
            };
            // Make the request
            PagedEnumerable<BackupRunsListResponse, BackupRun> response = sqlBackupRunsServiceClient.List(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (BackupRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (BackupRunsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupRun> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupRun item in singlePage)
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
            // Snippet: ListAsync(SqlBackupRunsListRequest, CallSettings)
            // Create client
            SqlBackupRunsServiceClient sqlBackupRunsServiceClient = await SqlBackupRunsServiceClient.CreateAsync();
            // Initialize request argument(s)
            SqlBackupRunsListRequest request = new SqlBackupRunsListRequest
            {
                Instance = "",
                Project = "",
            };
            // Make the request
            PagedAsyncEnumerable<BackupRunsListResponse, BackupRun> response = sqlBackupRunsServiceClient.ListAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await foreach (BackupRun item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await foreach (BackupRunsListResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (BackupRun item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<BackupRun> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (BackupRun item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
