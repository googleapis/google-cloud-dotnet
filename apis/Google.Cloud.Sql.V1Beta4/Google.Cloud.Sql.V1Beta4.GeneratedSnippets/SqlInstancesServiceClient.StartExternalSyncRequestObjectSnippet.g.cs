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
    // [START sqladmin_v1beta4_generated_SqlInstancesService_StartExternalSync_sync]
    using Google.Cloud.Sql.V1Beta4;

    public sealed partial class GeneratedSqlInstancesServiceClientSnippets
    {
        /// <summary>Snippet for StartExternalSync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void StartExternalSyncRequestObject()
        {
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
        }
    }
    // [END sqladmin_v1beta4_generated_SqlInstancesService_StartExternalSync_sync]
}
