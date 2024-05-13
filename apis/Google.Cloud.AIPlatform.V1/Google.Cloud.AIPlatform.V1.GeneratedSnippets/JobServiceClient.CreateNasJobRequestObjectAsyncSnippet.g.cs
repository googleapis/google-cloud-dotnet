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
    // [START aiplatform_v1_generated_JobService_CreateNasJob_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Google.Rpc;
    using System.Threading.Tasks;

    public sealed partial class GeneratedJobServiceClientSnippets
    {
        /// <summary>Snippet for CreateNasJobAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateNasJobRequestObjectAsync()
        {
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateNasJobRequest request = new CreateNasJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                NasJob = new NasJob
                {
                    NasJobName = NasJobName.FromProjectLocationNasJob("[PROJECT]", "[LOCATION]", "[NAS_JOB]"),
                    DisplayName = "",
                    NasJobSpec = new NasJobSpec
                    {
                        SearchSpaceSpec = "",
                        MultiTrialAlgorithmSpec = new NasJobSpec.Types.MultiTrialAlgorithmSpec
                        {
                            MultiTrialAlgorithm = NasJobSpec.Types.MultiTrialAlgorithmSpec.Types.MultiTrialAlgorithm.Unspecified,
                            Metric = new NasJobSpec.Types.MultiTrialAlgorithmSpec.Types.MetricSpec
                            {
                                MetricId = "",
                                Goal = NasJobSpec.Types.MultiTrialAlgorithmSpec.Types.MetricSpec.Types.GoalType.Unspecified,
                            },
                            SearchTrialSpec = new NasJobSpec.Types.MultiTrialAlgorithmSpec.Types.SearchTrialSpec
                            {
                                SearchTrialJobSpec = new CustomJobSpec
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
                                MaxTrialCount = 0,
                                MaxParallelTrialCount = 0,
                                MaxFailedTrialCount = 0,
                            },
                            TrainTrialSpec = new NasJobSpec.Types.MultiTrialAlgorithmSpec.Types.TrainTrialSpec
                            {
                                TrainTrialJobSpec = new CustomJobSpec
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
                                MaxParallelTrialCount = 0,
                                Frequency = 0,
                            },
                        },
                        ResumeNasJobId = "",
                    },
                    NasJobOutput = new NasJobOutput
                    {
                        MultiTrialJobOutput = new NasJobOutput.Types.MultiTrialJobOutput
                        {
                            SearchTrials =
                            {
                                new NasTrial
                                {
                                    Id = "",
                                    State = NasTrial.Types.State.Unspecified,
                                    FinalMeasurement = new Measurement
                                    {
                                        ElapsedDuration = new Duration
                                        {
                                            Seconds = 0L,
                                            Nanos = 0,
                                        },
                                        StepCount = 0L,
                                        Metrics =
                                        {
                                            new Measurement.Types.Metric
                                            {
                                                MetricId = "",
                                                Value = 0,
                                            },
                                        },
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
                                },
                            },
                            TrainTrials =
                            {
                                new NasTrial
                                {
                                    Id = "",
                                    State = NasTrial.Types.State.Unspecified,
                                    FinalMeasurement = new Measurement
                                    {
                                        ElapsedDuration = new Duration
                                        {
                                            Seconds = 0L,
                                            Nanos = 0,
                                        },
                                        StepCount = 0L,
                                        Metrics =
                                        {
                                            new Measurement.Types.Metric
                                            {
                                                MetricId = "",
                                                Value = 0,
                                            },
                                        },
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
                                },
                            },
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
                },
            };
            // Make the request
            NasJob response = await jobServiceClient.CreateNasJobAsync(request);
        }
    }
    // [END aiplatform_v1_generated_JobService_CreateNasJob_async]
}
