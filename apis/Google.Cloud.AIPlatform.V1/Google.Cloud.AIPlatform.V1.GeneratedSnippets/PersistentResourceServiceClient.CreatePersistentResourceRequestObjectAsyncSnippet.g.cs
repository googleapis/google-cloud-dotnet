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
    // [START aiplatform_v1_generated_PersistentResourceService_CreatePersistentResource_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Google.Rpc;
    using System.Threading.Tasks;

    public sealed partial class GeneratedPersistentResourceServiceClientSnippets
    {
        /// <summary>Snippet for CreatePersistentResourceAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreatePersistentResourceRequestObjectAsync()
        {
            // Create client
            PersistentResourceServiceClient persistentResourceServiceClient = await PersistentResourceServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreatePersistentResourceRequest request = new CreatePersistentResourceRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PersistentResource = new PersistentResource
                {
                    PersistentResourceName = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]"),
                    DisplayName = "",
                    ResourcePools =
                    {
                        new ResourcePool
                        {
                            Id = "",
                            MachineSpec = new MachineSpec
                            {
                                MachineType = "",
                                AcceleratorType = AcceleratorType.Unspecified,
                                AcceleratorCount = 0,
                                TpuTopology = "",
                            },
                            ReplicaCount = 0L,
                            DiskSpec = new DiskSpec
                            {
                                BootDiskType = "",
                                BootDiskSizeGb = 0,
                            },
                            UsedReplicaCount = 0L,
                            AutoscalingSpec = new ResourcePool.Types.AutoscalingSpec
                            {
                                MinReplicaCount = 0L,
                                MaxReplicaCount = 0L,
                            },
                        },
                    },
                    State = PersistentResource.Types.State.Unspecified,
                    Error = new Status
                    {
                        Code = 0,
                        Message = "",
                        Details =
                        {
                            new Any
                            {
                                TypeUrl = "",
                                Value = ByteString.Empty,
                            },
                        },
                    },
                    CreateTime = new Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    StartTime = new Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    UpdateTime = new Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    Labels = { { "", "" }, },
                    NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                    EncryptionSpec = new EncryptionSpec { KmsKeyName = "", },
                    ResourceRuntimeSpec = new ResourceRuntimeSpec
                    {
                        RaySpec = new RaySpec { },
                        ServiceAccountSpec = new ServiceAccountSpec
                        {
                            EnableCustomServiceAccount = false,
                            ServiceAccount = "",
                        },
                    },
                    ResourceRuntime = new ResourceRuntime { },
                    ReservedIpRanges = { "", },
                },
                PersistentResourceId = "",
            };
            // Make the request
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> response = await persistentResourceServiceClient.CreatePersistentResourceAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            PersistentResource result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PersistentResource, CreatePersistentResourceOperationMetadata> retrievedResponse = await persistentResourceServiceClient.PollOnceCreatePersistentResourceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PersistentResource retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_PersistentResourceService_CreatePersistentResource_async]
}
