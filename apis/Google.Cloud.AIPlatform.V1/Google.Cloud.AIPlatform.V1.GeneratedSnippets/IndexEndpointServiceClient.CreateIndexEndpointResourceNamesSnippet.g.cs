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
    // [START aiplatform_v1_generated_IndexEndpointService_CreateIndexEndpoint_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedIndexEndpointServiceClientSnippets
    {
        /// <summary>Snippet for CreateIndexEndpoint</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateIndexEndpointResourceNames()
        {
            // Create client
            IndexEndpointServiceClient indexEndpointServiceClient = IndexEndpointServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            IndexEndpoint indexEndpoint = new IndexEndpoint
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DisplayName = "",
                Description = "",
                DeployedIndexes =
                {
                    new DeployedIndex
                    {
                        Id = "",
                        IndexAsIndexName = IndexName.FromProjectLocationIndex("[PROJECT]", "[LOCATION]", "[INDEX]"),
                        DisplayName = "",
                        CreateTime = new Timestamp
                        {
                            Seconds = 0L,
                            Nanos = 0,
                        },
                        PrivateEndpoints = new IndexPrivateEndpoints
                        {
                            MatchGrpcAddress = "",
                            ServiceAttachment = "",
                            PscAutomatedEndpoints =
                            {
                                new PscAutomatedEndpoints
                                {
                                    ProjectId = "",
                                    Network = "",
                                    MatchAddress = "",
                                },
                            },
                        },
                        IndexSyncTime = new Timestamp
                        {
                            Seconds = 0L,
                            Nanos = 0,
                        },
                        AutomaticResources = new AutomaticResources
                        {
                            MinReplicaCount = 0,
                            MaxReplicaCount = 0,
                        },
                        EnableAccessLogging = false,
                        DeployedIndexAuthConfig = new DeployedIndexAuthConfig
                        {
                            AuthProvider = new DeployedIndexAuthConfig.Types.AuthProvider
                            {
                                Audiences = { "", },
                                AllowedIssuers = { "", },
                            },
                        },
                        ReservedIpRanges = { "", },
                        DeploymentGroup = "",
                        DedicatedResources = new DedicatedResources
                        {
                            MachineSpec = new MachineSpec
                            {
                                MachineType = "",
                                AcceleratorType = AcceleratorType.Unspecified,
                                AcceleratorCount = 0,
                                TpuTopology = "",
                            },
                            MinReplicaCount = 0,
                            MaxReplicaCount = 0,
                            AutoscalingMetricSpecs =
                            {
                                new AutoscalingMetricSpec
                                {
                                    MetricName = "",
                                    Target = 0,
                                },
                            },
                        },
                    },
                },
                Etag = "",
                Labels = { { "", "" }, },
                CreateTime = new Timestamp
                {
                    Seconds = 0L,
                    Nanos = 0,
                },
                UpdateTime = new Timestamp
                {
                    Seconds = 0L,
                    Nanos = 0,
                },
                Network = "",
                PrivateServiceConnectConfig = new PrivateServiceConnectConfig
                {
                    EnablePrivateServiceConnect = false,
                    ProjectAllowlist = { "", },
                },
                PublicEndpointEnabled = false,
                PublicEndpointDomainName = "",
                EncryptionSpec = new EncryptionSpec { KmsKeyName = "", },
            };
            // Make the request
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> response = indexEndpointServiceClient.CreateIndexEndpoint(parent, indexEndpoint);

            // Poll until the returned long-running operation is complete
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            IndexEndpoint result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<IndexEndpoint, CreateIndexEndpointOperationMetadata> retrievedResponse = indexEndpointServiceClient.PollOnceCreateIndexEndpoint(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                IndexEndpoint retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_IndexEndpointService_CreateIndexEndpoint_sync_flattened_resourceNames]
}
