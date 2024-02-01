// Copyright 2024 Google LLC
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
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.GkeMultiCloud.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedAttachedClustersClientSnippets
    {
        /// <summary>Snippet for CreateAttachedCluster</summary>
        public void CreateAttachedClusterRequestObject()
        {
            // Snippet: CreateAttachedCluster(CreateAttachedClusterRequest, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            CreateAttachedClusterRequest request = new CreateAttachedClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AttachedCluster = new AttachedCluster(),
                AttachedClusterId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = attachedClustersClient.CreateAttachedCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = attachedClustersClient.PollOnceCreateAttachedCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAttachedClusterAsync</summary>
        public async Task CreateAttachedClusterRequestObjectAsync()
        {
            // Snippet: CreateAttachedClusterAsync(CreateAttachedClusterRequest, CallSettings)
            // Additional: CreateAttachedClusterAsync(CreateAttachedClusterRequest, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            CreateAttachedClusterRequest request = new CreateAttachedClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AttachedCluster = new AttachedCluster(),
                AttachedClusterId = "",
                ValidateOnly = false,
            };
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = await attachedClustersClient.CreateAttachedClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = await attachedClustersClient.PollOnceCreateAttachedClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAttachedCluster</summary>
        public void CreateAttachedCluster()
        {
            // Snippet: CreateAttachedCluster(string, AttachedCluster, string, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AttachedCluster attachedCluster = new AttachedCluster();
            string attachedClusterId = "";
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = attachedClustersClient.CreateAttachedCluster(parent, attachedCluster, attachedClusterId);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = attachedClustersClient.PollOnceCreateAttachedCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAttachedClusterAsync</summary>
        public async Task CreateAttachedClusterAsync()
        {
            // Snippet: CreateAttachedClusterAsync(string, AttachedCluster, string, CallSettings)
            // Additional: CreateAttachedClusterAsync(string, AttachedCluster, string, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            AttachedCluster attachedCluster = new AttachedCluster();
            string attachedClusterId = "";
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = await attachedClustersClient.CreateAttachedClusterAsync(parent, attachedCluster, attachedClusterId);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = await attachedClustersClient.PollOnceCreateAttachedClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAttachedCluster</summary>
        public void CreateAttachedClusterResourceNames()
        {
            // Snippet: CreateAttachedCluster(LocationName, AttachedCluster, string, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AttachedCluster attachedCluster = new AttachedCluster();
            string attachedClusterId = "";
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = attachedClustersClient.CreateAttachedCluster(parent, attachedCluster, attachedClusterId);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = attachedClustersClient.PollOnceCreateAttachedCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for CreateAttachedClusterAsync</summary>
        public async Task CreateAttachedClusterResourceNamesAsync()
        {
            // Snippet: CreateAttachedClusterAsync(LocationName, AttachedCluster, string, CallSettings)
            // Additional: CreateAttachedClusterAsync(LocationName, AttachedCluster, string, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            AttachedCluster attachedCluster = new AttachedCluster();
            string attachedClusterId = "";
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = await attachedClustersClient.CreateAttachedClusterAsync(parent, attachedCluster, attachedClusterId);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = await attachedClustersClient.PollOnceCreateAttachedClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAttachedCluster</summary>
        public void UpdateAttachedClusterRequestObject()
        {
            // Snippet: UpdateAttachedCluster(UpdateAttachedClusterRequest, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            UpdateAttachedClusterRequest request = new UpdateAttachedClusterRequest
            {
                AttachedCluster = new AttachedCluster(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = attachedClustersClient.UpdateAttachedCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = attachedClustersClient.PollOnceUpdateAttachedCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAttachedClusterAsync</summary>
        public async Task UpdateAttachedClusterRequestObjectAsync()
        {
            // Snippet: UpdateAttachedClusterAsync(UpdateAttachedClusterRequest, CallSettings)
            // Additional: UpdateAttachedClusterAsync(UpdateAttachedClusterRequest, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            UpdateAttachedClusterRequest request = new UpdateAttachedClusterRequest
            {
                AttachedCluster = new AttachedCluster(),
                ValidateOnly = false,
                UpdateMask = new FieldMask(),
            };
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = await attachedClustersClient.UpdateAttachedClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = await attachedClustersClient.PollOnceUpdateAttachedClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAttachedCluster</summary>
        public void UpdateAttachedCluster()
        {
            // Snippet: UpdateAttachedCluster(AttachedCluster, FieldMask, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            AttachedCluster attachedCluster = new AttachedCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = attachedClustersClient.UpdateAttachedCluster(attachedCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = attachedClustersClient.PollOnceUpdateAttachedCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for UpdateAttachedClusterAsync</summary>
        public async Task UpdateAttachedClusterAsync()
        {
            // Snippet: UpdateAttachedClusterAsync(AttachedCluster, FieldMask, CallSettings)
            // Additional: UpdateAttachedClusterAsync(AttachedCluster, FieldMask, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            AttachedCluster attachedCluster = new AttachedCluster();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = await attachedClustersClient.UpdateAttachedClusterAsync(attachedCluster, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = await attachedClustersClient.PollOnceUpdateAttachedClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAttachedCluster</summary>
        public void ImportAttachedClusterRequestObject()
        {
            // Snippet: ImportAttachedCluster(ImportAttachedClusterRequest, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            ImportAttachedClusterRequest request = new ImportAttachedClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                FleetMembership = "",
                PlatformVersion = "",
                Distribution = "",
                ProxyConfig = new AttachedProxyConfig(),
            };
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = attachedClustersClient.ImportAttachedCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = attachedClustersClient.PollOnceImportAttachedCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAttachedClusterAsync</summary>
        public async Task ImportAttachedClusterRequestObjectAsync()
        {
            // Snippet: ImportAttachedClusterAsync(ImportAttachedClusterRequest, CallSettings)
            // Additional: ImportAttachedClusterAsync(ImportAttachedClusterRequest, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            ImportAttachedClusterRequest request = new ImportAttachedClusterRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ValidateOnly = false,
                FleetMembership = "",
                PlatformVersion = "",
                Distribution = "",
                ProxyConfig = new AttachedProxyConfig(),
            };
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = await attachedClustersClient.ImportAttachedClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = await attachedClustersClient.PollOnceImportAttachedClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAttachedCluster</summary>
        public void ImportAttachedCluster()
        {
            // Snippet: ImportAttachedCluster(string, string, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string fleetMembership = "";
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = attachedClustersClient.ImportAttachedCluster(parent, fleetMembership);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = attachedClustersClient.PollOnceImportAttachedCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAttachedClusterAsync</summary>
        public async Task ImportAttachedClusterAsync()
        {
            // Snippet: ImportAttachedClusterAsync(string, string, CallSettings)
            // Additional: ImportAttachedClusterAsync(string, string, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string fleetMembership = "";
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = await attachedClustersClient.ImportAttachedClusterAsync(parent, fleetMembership);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = await attachedClustersClient.PollOnceImportAttachedClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAttachedCluster</summary>
        public void ImportAttachedClusterResourceNames()
        {
            // Snippet: ImportAttachedCluster(LocationName, string, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string fleetMembership = "";
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = attachedClustersClient.ImportAttachedCluster(parent, fleetMembership);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = attachedClustersClient.PollOnceImportAttachedCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for ImportAttachedClusterAsync</summary>
        public async Task ImportAttachedClusterResourceNamesAsync()
        {
            // Snippet: ImportAttachedClusterAsync(LocationName, string, CallSettings)
            // Additional: ImportAttachedClusterAsync(LocationName, string, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string fleetMembership = "";
            // Make the request
            Operation<AttachedCluster, OperationMetadata> response = await attachedClustersClient.ImportAttachedClusterAsync(parent, fleetMembership);

            // Poll until the returned long-running operation is complete
            Operation<AttachedCluster, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            AttachedCluster result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<AttachedCluster, OperationMetadata> retrievedResponse = await attachedClustersClient.PollOnceImportAttachedClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                AttachedCluster retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAttachedCluster</summary>
        public void GetAttachedClusterRequestObject()
        {
            // Snippet: GetAttachedCluster(GetAttachedClusterRequest, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            GetAttachedClusterRequest request = new GetAttachedClusterRequest
            {
                AttachedClusterName = AttachedClusterName.FromProjectLocationAttachedCluster("[PROJECT]", "[LOCATION]", "[ATTACHED_CLUSTER]"),
            };
            // Make the request
            AttachedCluster response = attachedClustersClient.GetAttachedCluster(request);
            // End snippet
        }

        /// <summary>Snippet for GetAttachedClusterAsync</summary>
        public async Task GetAttachedClusterRequestObjectAsync()
        {
            // Snippet: GetAttachedClusterAsync(GetAttachedClusterRequest, CallSettings)
            // Additional: GetAttachedClusterAsync(GetAttachedClusterRequest, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAttachedClusterRequest request = new GetAttachedClusterRequest
            {
                AttachedClusterName = AttachedClusterName.FromProjectLocationAttachedCluster("[PROJECT]", "[LOCATION]", "[ATTACHED_CLUSTER]"),
            };
            // Make the request
            AttachedCluster response = await attachedClustersClient.GetAttachedClusterAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAttachedCluster</summary>
        public void GetAttachedCluster()
        {
            // Snippet: GetAttachedCluster(string, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/attachedClusters/[ATTACHED_CLUSTER]";
            // Make the request
            AttachedCluster response = attachedClustersClient.GetAttachedCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttachedClusterAsync</summary>
        public async Task GetAttachedClusterAsync()
        {
            // Snippet: GetAttachedClusterAsync(string, CallSettings)
            // Additional: GetAttachedClusterAsync(string, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/attachedClusters/[ATTACHED_CLUSTER]";
            // Make the request
            AttachedCluster response = await attachedClustersClient.GetAttachedClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttachedCluster</summary>
        public void GetAttachedClusterResourceNames()
        {
            // Snippet: GetAttachedCluster(AttachedClusterName, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            AttachedClusterName name = AttachedClusterName.FromProjectLocationAttachedCluster("[PROJECT]", "[LOCATION]", "[ATTACHED_CLUSTER]");
            // Make the request
            AttachedCluster response = attachedClustersClient.GetAttachedCluster(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttachedClusterAsync</summary>
        public async Task GetAttachedClusterResourceNamesAsync()
        {
            // Snippet: GetAttachedClusterAsync(AttachedClusterName, CallSettings)
            // Additional: GetAttachedClusterAsync(AttachedClusterName, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            AttachedClusterName name = AttachedClusterName.FromProjectLocationAttachedCluster("[PROJECT]", "[LOCATION]", "[ATTACHED_CLUSTER]");
            // Make the request
            AttachedCluster response = await attachedClustersClient.GetAttachedClusterAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListAttachedClusters</summary>
        public void ListAttachedClustersRequestObject()
        {
            // Snippet: ListAttachedClusters(ListAttachedClustersRequest, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            ListAttachedClustersRequest request = new ListAttachedClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedEnumerable<ListAttachedClustersResponse, AttachedCluster> response = attachedClustersClient.ListAttachedClusters(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AttachedCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttachedClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttachedCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttachedCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttachedCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttachedClustersAsync</summary>
        public async Task ListAttachedClustersRequestObjectAsync()
        {
            // Snippet: ListAttachedClustersAsync(ListAttachedClustersRequest, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            ListAttachedClustersRequest request = new ListAttachedClustersRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            PagedAsyncEnumerable<ListAttachedClustersResponse, AttachedCluster> response = attachedClustersClient.ListAttachedClustersAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AttachedCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttachedClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttachedCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttachedCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttachedCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttachedClusters</summary>
        public void ListAttachedClusters()
        {
            // Snippet: ListAttachedClusters(string, string, int?, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedEnumerable<ListAttachedClustersResponse, AttachedCluster> response = attachedClustersClient.ListAttachedClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AttachedCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttachedClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttachedCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttachedCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttachedCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttachedClustersAsync</summary>
        public async Task ListAttachedClustersAsync()
        {
            // Snippet: ListAttachedClustersAsync(string, string, int?, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            // Make the request
            PagedAsyncEnumerable<ListAttachedClustersResponse, AttachedCluster> response = attachedClustersClient.ListAttachedClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AttachedCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttachedClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttachedCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttachedCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttachedCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttachedClusters</summary>
        public void ListAttachedClustersResourceNames()
        {
            // Snippet: ListAttachedClusters(LocationName, string, int?, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedEnumerable<ListAttachedClustersResponse, AttachedCluster> response = attachedClustersClient.ListAttachedClusters(parent);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (AttachedCluster item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListAttachedClustersResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttachedCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttachedCluster> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttachedCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListAttachedClustersAsync</summary>
        public async Task ListAttachedClustersResourceNamesAsync()
        {
            // Snippet: ListAttachedClustersAsync(LocationName, string, int?, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            PagedAsyncEnumerable<ListAttachedClustersResponse, AttachedCluster> response = attachedClustersClient.ListAttachedClustersAsync(parent);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((AttachedCluster item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListAttachedClustersResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (AttachedCluster item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<AttachedCluster> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (AttachedCluster item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for DeleteAttachedCluster</summary>
        public void DeleteAttachedClusterRequestObject()
        {
            // Snippet: DeleteAttachedCluster(DeleteAttachedClusterRequest, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            DeleteAttachedClusterRequest request = new DeleteAttachedClusterRequest
            {
                AttachedClusterName = AttachedClusterName.FromProjectLocationAttachedCluster("[PROJECT]", "[LOCATION]", "[ATTACHED_CLUSTER]"),
                ValidateOnly = false,
                AllowMissing = false,
                Etag = "",
                IgnoreErrors = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = attachedClustersClient.DeleteAttachedCluster(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = attachedClustersClient.PollOnceDeleteAttachedCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAttachedClusterAsync</summary>
        public async Task DeleteAttachedClusterRequestObjectAsync()
        {
            // Snippet: DeleteAttachedClusterAsync(DeleteAttachedClusterRequest, CallSettings)
            // Additional: DeleteAttachedClusterAsync(DeleteAttachedClusterRequest, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            DeleteAttachedClusterRequest request = new DeleteAttachedClusterRequest
            {
                AttachedClusterName = AttachedClusterName.FromProjectLocationAttachedCluster("[PROJECT]", "[LOCATION]", "[ATTACHED_CLUSTER]"),
                ValidateOnly = false,
                AllowMissing = false,
                Etag = "",
                IgnoreErrors = false,
            };
            // Make the request
            Operation<Empty, OperationMetadata> response = await attachedClustersClient.DeleteAttachedClusterAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await attachedClustersClient.PollOnceDeleteAttachedClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAttachedCluster</summary>
        public void DeleteAttachedCluster()
        {
            // Snippet: DeleteAttachedCluster(string, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/attachedClusters/[ATTACHED_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = attachedClustersClient.DeleteAttachedCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = attachedClustersClient.PollOnceDeleteAttachedCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAttachedClusterAsync</summary>
        public async Task DeleteAttachedClusterAsync()
        {
            // Snippet: DeleteAttachedClusterAsync(string, CallSettings)
            // Additional: DeleteAttachedClusterAsync(string, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/attachedClusters/[ATTACHED_CLUSTER]";
            // Make the request
            Operation<Empty, OperationMetadata> response = await attachedClustersClient.DeleteAttachedClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await attachedClustersClient.PollOnceDeleteAttachedClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAttachedCluster</summary>
        public void DeleteAttachedClusterResourceNames()
        {
            // Snippet: DeleteAttachedCluster(AttachedClusterName, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            AttachedClusterName name = AttachedClusterName.FromProjectLocationAttachedCluster("[PROJECT]", "[LOCATION]", "[ATTACHED_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = attachedClustersClient.DeleteAttachedCluster(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = attachedClustersClient.PollOnceDeleteAttachedCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for DeleteAttachedClusterAsync</summary>
        public async Task DeleteAttachedClusterResourceNamesAsync()
        {
            // Snippet: DeleteAttachedClusterAsync(AttachedClusterName, CallSettings)
            // Additional: DeleteAttachedClusterAsync(AttachedClusterName, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            AttachedClusterName name = AttachedClusterName.FromProjectLocationAttachedCluster("[PROJECT]", "[LOCATION]", "[ATTACHED_CLUSTER]");
            // Make the request
            Operation<Empty, OperationMetadata> response = await attachedClustersClient.DeleteAttachedClusterAsync(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = await attachedClustersClient.PollOnceDeleteAttachedClusterAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
            // End snippet
        }

        /// <summary>Snippet for GetAttachedServerConfig</summary>
        public void GetAttachedServerConfigRequestObject()
        {
            // Snippet: GetAttachedServerConfig(GetAttachedServerConfigRequest, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            GetAttachedServerConfigRequest request = new GetAttachedServerConfigRequest
            {
                AttachedServerConfigName = AttachedServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            AttachedServerConfig response = attachedClustersClient.GetAttachedServerConfig(request);
            // End snippet
        }

        /// <summary>Snippet for GetAttachedServerConfigAsync</summary>
        public async Task GetAttachedServerConfigRequestObjectAsync()
        {
            // Snippet: GetAttachedServerConfigAsync(GetAttachedServerConfigRequest, CallSettings)
            // Additional: GetAttachedServerConfigAsync(GetAttachedServerConfigRequest, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            GetAttachedServerConfigRequest request = new GetAttachedServerConfigRequest
            {
                AttachedServerConfigName = AttachedServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            // Make the request
            AttachedServerConfig response = await attachedClustersClient.GetAttachedServerConfigAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetAttachedServerConfig</summary>
        public void GetAttachedServerConfig()
        {
            // Snippet: GetAttachedServerConfig(string, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/attachedServerConfig";
            // Make the request
            AttachedServerConfig response = attachedClustersClient.GetAttachedServerConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttachedServerConfigAsync</summary>
        public async Task GetAttachedServerConfigAsync()
        {
            // Snippet: GetAttachedServerConfigAsync(string, CallSettings)
            // Additional: GetAttachedServerConfigAsync(string, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/attachedServerConfig";
            // Make the request
            AttachedServerConfig response = await attachedClustersClient.GetAttachedServerConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttachedServerConfig</summary>
        public void GetAttachedServerConfigResourceNames()
        {
            // Snippet: GetAttachedServerConfig(AttachedServerConfigName, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            AttachedServerConfigName name = AttachedServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            AttachedServerConfig response = attachedClustersClient.GetAttachedServerConfig(name);
            // End snippet
        }

        /// <summary>Snippet for GetAttachedServerConfigAsync</summary>
        public async Task GetAttachedServerConfigResourceNamesAsync()
        {
            // Snippet: GetAttachedServerConfigAsync(AttachedServerConfigName, CallSettings)
            // Additional: GetAttachedServerConfigAsync(AttachedServerConfigName, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            AttachedServerConfigName name = AttachedServerConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            // Make the request
            AttachedServerConfig response = await attachedClustersClient.GetAttachedServerConfigAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GenerateAttachedClusterInstallManifest</summary>
        public void GenerateAttachedClusterInstallManifestRequestObject()
        {
            // Snippet: GenerateAttachedClusterInstallManifest(GenerateAttachedClusterInstallManifestRequest, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            GenerateAttachedClusterInstallManifestRequest request = new GenerateAttachedClusterInstallManifestRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AttachedClusterId = "",
                PlatformVersion = "",
                ProxyConfig = new AttachedProxyConfig(),
            };
            // Make the request
            GenerateAttachedClusterInstallManifestResponse response = attachedClustersClient.GenerateAttachedClusterInstallManifest(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAttachedClusterInstallManifestAsync</summary>
        public async Task GenerateAttachedClusterInstallManifestRequestObjectAsync()
        {
            // Snippet: GenerateAttachedClusterInstallManifestAsync(GenerateAttachedClusterInstallManifestRequest, CallSettings)
            // Additional: GenerateAttachedClusterInstallManifestAsync(GenerateAttachedClusterInstallManifestRequest, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            GenerateAttachedClusterInstallManifestRequest request = new GenerateAttachedClusterInstallManifestRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                AttachedClusterId = "",
                PlatformVersion = "",
                ProxyConfig = new AttachedProxyConfig(),
            };
            // Make the request
            GenerateAttachedClusterInstallManifestResponse response = await attachedClustersClient.GenerateAttachedClusterInstallManifestAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAttachedClusterInstallManifest</summary>
        public void GenerateAttachedClusterInstallManifest()
        {
            // Snippet: GenerateAttachedClusterInstallManifest(string, string, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string attachedClusterId = "";
            // Make the request
            GenerateAttachedClusterInstallManifestResponse response = attachedClustersClient.GenerateAttachedClusterInstallManifest(parent, attachedClusterId);
            // End snippet
        }

        /// <summary>Snippet for GenerateAttachedClusterInstallManifestAsync</summary>
        public async Task GenerateAttachedClusterInstallManifestAsync()
        {
            // Snippet: GenerateAttachedClusterInstallManifestAsync(string, string, CallSettings)
            // Additional: GenerateAttachedClusterInstallManifestAsync(string, string, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            string attachedClusterId = "";
            // Make the request
            GenerateAttachedClusterInstallManifestResponse response = await attachedClustersClient.GenerateAttachedClusterInstallManifestAsync(parent, attachedClusterId);
            // End snippet
        }

        /// <summary>Snippet for GenerateAttachedClusterInstallManifest</summary>
        public void GenerateAttachedClusterInstallManifestResourceNames()
        {
            // Snippet: GenerateAttachedClusterInstallManifest(LocationName, string, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string attachedClusterId = "";
            // Make the request
            GenerateAttachedClusterInstallManifestResponse response = attachedClustersClient.GenerateAttachedClusterInstallManifest(parent, attachedClusterId);
            // End snippet
        }

        /// <summary>Snippet for GenerateAttachedClusterInstallManifestAsync</summary>
        public async Task GenerateAttachedClusterInstallManifestResourceNamesAsync()
        {
            // Snippet: GenerateAttachedClusterInstallManifestAsync(LocationName, string, CallSettings)
            // Additional: GenerateAttachedClusterInstallManifestAsync(LocationName, string, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            string attachedClusterId = "";
            // Make the request
            GenerateAttachedClusterInstallManifestResponse response = await attachedClustersClient.GenerateAttachedClusterInstallManifestAsync(parent, attachedClusterId);
            // End snippet
        }

        /// <summary>Snippet for GenerateAttachedClusterAgentToken</summary>
        public void GenerateAttachedClusterAgentTokenRequestObject()
        {
            // Snippet: GenerateAttachedClusterAgentToken(GenerateAttachedClusterAgentTokenRequest, CallSettings)
            // Create client
            AttachedClustersClient attachedClustersClient = AttachedClustersClient.Create();
            // Initialize request argument(s)
            GenerateAttachedClusterAgentTokenRequest request = new GenerateAttachedClusterAgentTokenRequest
            {
                AttachedClusterAsAttachedClusterName = AttachedClusterName.FromProjectLocationAttachedCluster("[PROJECT]", "[LOCATION]", "[ATTACHED_CLUSTER]"),
                SubjectToken = "",
                SubjectTokenType = "",
                Version = "",
                GrantType = "",
                Audience = "",
                Scope = "",
                RequestedTokenType = "",
                Options = "",
            };
            // Make the request
            GenerateAttachedClusterAgentTokenResponse response = attachedClustersClient.GenerateAttachedClusterAgentToken(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateAttachedClusterAgentTokenAsync</summary>
        public async Task GenerateAttachedClusterAgentTokenRequestObjectAsync()
        {
            // Snippet: GenerateAttachedClusterAgentTokenAsync(GenerateAttachedClusterAgentTokenRequest, CallSettings)
            // Additional: GenerateAttachedClusterAgentTokenAsync(GenerateAttachedClusterAgentTokenRequest, CancellationToken)
            // Create client
            AttachedClustersClient attachedClustersClient = await AttachedClustersClient.CreateAsync();
            // Initialize request argument(s)
            GenerateAttachedClusterAgentTokenRequest request = new GenerateAttachedClusterAgentTokenRequest
            {
                AttachedClusterAsAttachedClusterName = AttachedClusterName.FromProjectLocationAttachedCluster("[PROJECT]", "[LOCATION]", "[ATTACHED_CLUSTER]"),
                SubjectToken = "",
                SubjectTokenType = "",
                Version = "",
                GrantType = "",
                Audience = "",
                Scope = "",
                RequestedTokenType = "",
                Options = "",
            };
            // Make the request
            GenerateAttachedClusterAgentTokenResponse response = await attachedClustersClient.GenerateAttachedClusterAgentTokenAsync(request);
            // End snippet
        }
    }
}
