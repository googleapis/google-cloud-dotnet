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
    // [START sqladmin_v1_generated_SqlBackupRunsService_Get_sync]
    using Google.Cloud.Sql.V1;

    public sealed partial class GeneratedSqlBackupRunsServiceClientSnippets
    {
        /// <summary>Snippet for Get</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void GetRequestObject()
        {
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
        }
    }
    // [END sqladmin_v1_generated_SqlBackupRunsService_Get_sync]
}
