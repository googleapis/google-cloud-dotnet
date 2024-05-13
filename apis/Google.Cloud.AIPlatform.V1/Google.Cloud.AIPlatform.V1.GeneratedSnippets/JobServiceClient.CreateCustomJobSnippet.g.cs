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
    // [START aiplatform_v1_generated_JobService_CreateCustomJob_sync_flattened]
    using Google.Cloud.AIPlatform.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Google.Rpc;

    public sealed partial class GeneratedJobServiceClientSnippets
    {
        /// <summary>Snippet for CreateCustomJob</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateCustomJob()
        {
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            CustomJob customJob = new CustomJob
            {
                CustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                DisplayName = "",
                JobSpec = new CustomJobSpec
                {
                    WorkerPoolSpecs =
                    {
                        new WorkerPoolSpec
                        {
                            MachineSpec = new MachineSpec
                            {
                                MachineType = "",
                                AcceleratorType = AcceleratorType.Unspecified,
                                AcceleratorCount = 0,
                                TpuTopology = "",
                            },
                            ReplicaCount = 0L,
                            NfsMounts =
                            {
                                new NfsMount
                                {
                                    Server = "",
                                    Path = "",
                                    MountPoint = "",
                                },
                            },
                            DiskSpec = new DiskSpec
                            {
                                BootDiskType = "",
                                BootDiskSizeGb = 0,
                            },
                            ContainerSpec = new ContainerSpec
                            {
                                ImageUri = "",
                                Command = { "", },
                                Args = { "", },
                                Env =
                                {
                                    new EnvVar { Name = "", Value = "", },
                                },
                            },
                            PythonPackageSpec = new PythonPackageSpec
                            {
                                ExecutorImageUri = "",
                                PackageUris = { "", },
                                PythonModule = "",
                                Args = { "", },
                                Env =
                                {
                                    new EnvVar { Name = "", Value = "", },
                                },
                            },
                        },
                    },
                    Scheduling = new Scheduling
                    {
                        Timeout = new Duration
                        {
                            Seconds = 0L,
                            Nanos = 0,
                        },
                        RestartJobOnWorkerRestart = false,
                        DisableRetries = false,
                    },
                    ServiceAccount = "",
                    NetworkAsNetworkName = NetworkName.FromProjectNetwork("[PROJECT]", "[NETWORK]"),
                    BaseOutputDirectory = new GcsDestination
                    {
                        OutputUriPrefix = "",
                    },
                    TensorboardAsTensorboardName = TensorboardName.FromProjectLocationTensorboard("[PROJECT]", "[LOCATION]", "[TENSORBOARD]"),
                    EnableWebAccess = false,
                    ReservedIpRanges = { "", },
                    PersistentResourceIdAsPersistentResourceName = PersistentResourceName.FromProjectLocationPersistentResource("[PROJECT]", "[LOCATION]", "[PERSISTENT_RESOURCE]"),
                    EnableDashboardAccess = false,
                    ExperimentAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                    ExperimentRunAsContextName = ContextName.FromProjectLocationMetadataStoreContext("[PROJECT]", "[LOCATION]", "[METADATA_STORE]", "[CONTEXT]"),
                    ProtectedArtifactLocationId = "",
                    ModelsAsModelNames =
                    {
                        ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                    },
                },
                State = JobState.Unspecified,
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
                EndTime = new Timestamp
                {
                    Seconds = 0L,
                    Nanos = 0,
                },
                UpdateTime = new Timestamp
                {
                    Seconds = 0L,
                    Nanos = 0,
                },
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
                Labels = { { "", "" }, },
                EncryptionSpec = new EncryptionSpec { KmsKeyName = "", },
                WebAccessUris = { { "", "" }, },
            };
            // Make the request
            CustomJob response = jobServiceClient.CreateCustomJob(parent, customJob);
        }
    }
    // [END aiplatform_v1_generated_JobService_CreateCustomJob_sync_flattened]
}
