// Copyright 2025 Google LLC
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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AlloyDb.V1Beta;
    using Google.LongRunning;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAlloyDBCSQLAdminClientSnippets
    {
        /// <summary>Snippet for RestoreFromCloudSQL</summary>
        public void RestoreFromCloudSQLRequestObject()
        {
            // Snippet: RestoreFromCloudSQL(RestoreFromCloudSQLRequest, CallSettings)
            // Create client
            AlloyDBCSQLAdminClient alloyDBCSQLAdminClient = AlloyDBCSQLAdminClient.Create();
            // Initialize request argument(s)
            RestoreFromCloudSQLRequest request = new RestoreFromCloudSQLRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                CloudsqlBackupRunSource = new CloudSQLBackupRunSource(),
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBCSQLAdminClient.RestoreFromCloudSQL(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBCSQLAdminClient.PollOnceRestoreFromCloudSQL(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreFromCloudSQLAsync</summary>
        public async Task RestoreFromCloudSQLRequestObjectAsync()
        {
            // Snippet: RestoreFromCloudSQLAsync(RestoreFromCloudSQLRequest, CallSettings)
            // Additional: RestoreFromCloudSQLAsync(RestoreFromCloudSQLRequest, CancellationToken)
            // Create client
            AlloyDBCSQLAdminClient alloyDBCSQLAdminClient = await AlloyDBCSQLAdminClient.CreateAsync();
            // Initialize request argument(s)
            RestoreFromCloudSQLRequest request = new RestoreFromCloudSQLRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ClusterId = "",
                Cluster = new Cluster(),
                CloudsqlBackupRunSource = new CloudSQLBackupRunSource(),
            };
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBCSQLAdminClient.RestoreFromCloudSQLAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBCSQLAdminClient.PollOnceRestoreFromCloudSQLAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreFromCloudSQL</summary>
        public void RestoreFromCloudSQL()
        {
            // Snippet: RestoreFromCloudSQL(string, string, CallSettings)
            // Create client
            AlloyDBCSQLAdminClient alloyDBCSQLAdminClient = AlloyDBCSQLAdminClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBCSQLAdminClient.RestoreFromCloudSQL(parent, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBCSQLAdminClient.PollOnceRestoreFromCloudSQL(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreFromCloudSQLAsync</summary>
        public async Task RestoreFromCloudSQLAsync()
        {
            // Snippet: RestoreFromCloudSQLAsync(string, string, CallSettings)
            // Additional: RestoreFromCloudSQLAsync(string, string, CancellationToken)
            // Create client
            AlloyDBCSQLAdminClient alloyDBCSQLAdminClient = await AlloyDBCSQLAdminClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBCSQLAdminClient.RestoreFromCloudSQLAsync(parent, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBCSQLAdminClient.PollOnceRestoreFromCloudSQLAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreFromCloudSQL</summary>
        public void RestoreFromCloudSQLResourceNames()
        {
            // Snippet: RestoreFromCloudSQL(LocationName, string, CallSettings)
            // Create client
            AlloyDBCSQLAdminClient alloyDBCSQLAdminClient = AlloyDBCSQLAdminClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = alloyDBCSQLAdminClient.RestoreFromCloudSQL(parent, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = alloyDBCSQLAdminClient.PollOnceRestoreFromCloudSQL(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for RestoreFromCloudSQLAsync</summary>
        public async Task RestoreFromCloudSQLResourceNamesAsync()
        {
            // Snippet: RestoreFromCloudSQLAsync(LocationName, string, CallSettings)
            // Additional: RestoreFromCloudSQLAsync(LocationName, string, CancellationToken)
            // Create client
            AlloyDBCSQLAdminClient alloyDBCSQLAdminClient = await AlloyDBCSQLAdminClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string clusterId = "";
            // Make the request
            Operation<Cluster, OperationMetadata> response = await alloyDBCSQLAdminClient.RestoreFromCloudSQLAsync(parent, clusterId);

            // Poll until the returned long-running operation is complete
            Operation<Cluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Cluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Cluster, OperationMetadata> retrievedResponse = await alloyDBCSQLAdminClient.PollOnceRestoreFromCloudSQLAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Cluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }
    }
}
