// Copyright 2022 Google LLC
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

namespace Google.Cloud.CloudDms.V1.Snippets
{
    // [START datamigration_v1_generated_DataMigrationService_GenerateSshScript_sync]
    using Google.Cloud.CloudDms.V1;

    public sealed partial class GeneratedDataMigrationServiceClientSnippets
    {
        /// <summary>Snippet for GenerateSshScript</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GenerateSshScriptRequestObject()
        {
            // Create client
            DataMigrationServiceClient dataMigrationServiceClient = DataMigrationServiceClient.Create();
            // Initialize request argument(s)
            GenerateSshScriptRequest request = new GenerateSshScriptRequest
            {
                MigrationJobAsMigrationJobName = MigrationJobName.FromProjectLocationMigrationJob("[PROJECT]", "[LOCATION]", "[MIGRATION_JOB]"),
                Vm = "",
                VmPort = 0,
                VmCreationConfig = new VmCreationConfig(),
            };
            // Make the request
            SshScript response = dataMigrationServiceClient.GenerateSshScript(request);
        }
    }
    // [END datamigration_v1_generated_DataMigrationService_GenerateSshScript_sync]
}
