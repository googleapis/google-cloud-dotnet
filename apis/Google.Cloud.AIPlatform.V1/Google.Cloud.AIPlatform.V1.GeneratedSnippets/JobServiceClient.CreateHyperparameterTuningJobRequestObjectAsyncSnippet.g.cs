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

#pragma warning disable CS8981

namespace GoogleCSharpSnippets
{
    // [START aiplatform_v1_generated_JobService_CreateHyperparameterTuningJob_async]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.Protobuf;
    using Google.Rpc;
    using System.Threading.Tasks;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedJobServiceClientSnippets
    {
        /// <summary>Snippet for CreateHyperparameterTuningJobAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task CreateHyperparameterTuningJobRequestObjectAsync()
        {
            // Create client
            JobServiceClient jobServiceClient = await JobServiceClient.CreateAsync();
            // Initialize request argument(s)
            CreateHyperparameterTuningJobRequest request = new CreateHyperparameterTuningJobRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                HyperparameterTuningJob = new HyperparameterTuningJob
                {
                    HyperparameterTuningJobName = HyperparameterTuningJobName.FromProjectLocationHyperparameterTuningJob("[PROJECT]", "[LOCATION]", "[HYPERPARAMETER_TUNING_JOB]"),
                    DisplayName = "",
                    StudySpec = new StudySpec
                    {
                        Metrics =
                        {
                            new StudySpec.Types.MetricSpec
                            {
                                MetricId = "",
                                Goal = StudySpec.Types.MetricSpec.Types.GoalType.Unspecified,
                                SafetyConfig = new StudySpec.Types.MetricSpec.Types.SafetyMetricConfig
                                {
                                    SafetyThreshold = 0,
                                    DesiredMinSafeTrialsFraction = 0,
                                },
                            },
                        },
                        Parameters =
                        {
                            new StudySpec.Types.ParameterSpec
                            {
                                ParameterId = "",
                                DoubleValueSpec = new StudySpec.Types.ParameterSpec.Types.DoubleValueSpec
                                {
                                    MinValue = 0,
                                    MaxValue = 0,
                                    DefaultValue = 0,
                                },
                                IntegerValueSpec = new StudySpec.Types.ParameterSpec.Types.IntegerValueSpec
                                {
                                    MinValue = 0L,
                                    MaxValue = 0L,
                                    DefaultValue = 0L,
                                },
                                CategoricalValueSpec = new StudySpec.Types.ParameterSpec.Types.CategoricalValueSpec
                                {
                                    Values = { "", },
                                    DefaultValue = "",
                                },
                                DiscreteValueSpec = new StudySpec.Types.ParameterSpec.Types.DiscreteValueSpec
                                {
                                    Values = { 0, },
                                    DefaultValue = 0,
                                },
                                ScaleType = StudySpec.Types.ParameterSpec.Types.ScaleType.Unspecified,
                                ConditionalParameterSpecs =
                                {
                                    new StudySpec.Types.ParameterSpec.Types.ConditionalParameterSpec
                                    {
                                        ParameterSpec = new StudySpec.Types.ParameterSpec { },
                                        ParentDiscreteValues = new StudySpec.Types.ParameterSpec.Types.ConditionalParameterSpec.Types.DiscreteValueCondition { Values = { 0, }, },
                                        ParentIntValues = new StudySpec.Types.ParameterSpec.Types.ConditionalParameterSpec.Types.IntValueCondition { Values = { 0L, }, },
                                        ParentCategoricalValues = new StudySpec.Types.ParameterSpec.Types.ConditionalParameterSpec.Types.CategoricalValueCondition { Values = { "", }, },
                                    },
                                },
                            },
                        },
                        Algorithm = StudySpec.Types.Algorithm.Unspecified,
                        DecayCurveStoppingSpec = new StudySpec.Types.DecayCurveAutomatedStoppingSpec
                        {
                            UseElapsedDuration = false,
                        },
                        MedianAutomatedStoppingSpec = new StudySpec.Types.MedianAutomatedStoppingSpec
                        {
                            UseElapsedDuration = false,
                        },
                        ObservationNoise = StudySpec.Types.ObservationNoise.Unspecified,
                        MeasurementSelectionType = StudySpec.Types.MeasurementSelectionType.Unspecified,
                        ConvexAutomatedStoppingSpec = new StudySpec.Types.ConvexAutomatedStoppingSpec
                        {
                            MaxStepCount = 0L,
                            MinStepCount = 0L,
                            MinMeasurementCount = 0L,
                            LearningRateParameterName = "",
                            UseElapsedDuration = false,
                            UpdateAllStoppedTrials = false,
                        },
                        StudyStoppingConfig = new StudySpec.Types.StudyStoppingConfig
                        {
                            ShouldStopAsap = false,
                            MinimumRuntimeConstraint = new StudyTimeConstraint
                            {
                                MaxDuration = new wkt::Duration
                                {
                                    Seconds = 0L,
                                    Nanos = 0,
                                },
                                EndTime = new wkt::Timestamp
                                {
                                    Seconds = 0L,
                                    Nanos = 0,
                                },
                            },
                            MaximumRuntimeConstraint = new StudyTimeConstraint
                            {
                                MaxDuration = new wkt::Duration
                                {
                                    Seconds = 0L,
                                    Nanos = 0,
                                },
                                EndTime = new wkt::Timestamp
                                {
                                    Seconds = 0L,
                                    Nanos = 0,
                                },
                            },
                            MinNumTrials = 0,
                            MaxNumTrials = 0,
                            MaxNumTrialsNoProgress = 0,
                            MaxDurationNoProgress = new wkt::Duration
                            {
                                Seconds = 0L,
                                Nanos = 0,
                            },
                        },
                    },
                    MaxTrialCount = 0,
                    ParallelTrialCount = 0,
                    MaxFailedTrialCount = 0,
                    TrialJobSpec = new CustomJobSpec
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
                            Timeout = new wkt::Duration
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
                    Trials =
                    {
                        new Trial
                        {
                            TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                            Id = "",
                            State = Trial.Types.State.Unspecified,
                            Parameters =
                            {
                                new Trial.Types.Parameter
                                {
                                    ParameterId = "",
                                    Value = new wkt::Value
                                    {
                                        NullValue = wkt::NullValue.NullValue,
                                        NumberValue = 0,
                                        StringValue = "",
                                        BoolValue = false,
                                        StructValue = new wkt::Struct
                                        {
                                            Fields =
                                            {
                                                {
                                                    "",
                                                    new wkt::Value { }
                                                },
                                            },
                                        },
                                        ListValue = new wkt::ListValue
                                        {
                                            Values = { new wkt::Value { }, },
                                        },
                                    },
                                },
                            },
                            FinalMeasurement = new Measurement
                            {
                                ElapsedDuration = new wkt::Duration
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
                            Measurements =
                            {
                                new Measurement
                                {
                                    ElapsedDuration = new wkt::Duration
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
                            },
                            StartTime = new wkt::Timestamp
                            {
                                Seconds = 0L,
                                Nanos = 0,
                            },
                            EndTime = new wkt::Timestamp
                            {
                                Seconds = 0L,
                                Nanos = 0,
                            },
                            ClientId = "",
                            InfeasibleReason = "",
                            CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                            WebAccessUris = { { "", "" }, },
                        },
                    },
                    State = JobState.Unspecified,
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    StartTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    EndTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    UpdateTime = new wkt::Timestamp
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
                            new wkt::Any
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
            HyperparameterTuningJob response = await jobServiceClient.CreateHyperparameterTuningJobAsync(request);
        }
    }
    // [END aiplatform_v1_generated_JobService_CreateHyperparameterTuningJob_async]
}
