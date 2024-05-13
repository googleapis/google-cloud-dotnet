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
    // [START aiplatform_v1_generated_PipelineService_CreateTrainingPipeline_sync_flattened_resourceNames]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.AIPlatform.V1;
    using Google.Protobuf;
    using Google.Rpc;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedPipelineServiceClientSnippets
    {
        /// <summary>Snippet for CreateTrainingPipeline</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateTrainingPipelineResourceNames()
        {
            // Create client
            PipelineServiceClient pipelineServiceClient = PipelineServiceClient.Create();
            // Initialize request argument(s)
            LocationName parent = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]");
            TrainingPipeline trainingPipeline = new TrainingPipeline
            {
                TrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                DisplayName = "",
                InputDataConfig = new InputDataConfig
                {
                    DatasetId = "",
                    FractionSplit = new FractionSplit
                    {
                        TrainingFraction = 0,
                        ValidationFraction = 0,
                        TestFraction = 0,
                    },
                    FilterSplit = new FilterSplit
                    {
                        TrainingFilter = "",
                        ValidationFilter = "",
                        TestFilter = "",
                    },
                    PredefinedSplit = new PredefinedSplit { Key = "", },
                    TimestampSplit = new TimestampSplit
                    {
                        TrainingFraction = 0,
                        ValidationFraction = 0,
                        TestFraction = 0,
                        Key = "",
                    },
                    AnnotationsFilter = "",
                    SavedQueryId = "",
                    GcsDestination = new GcsDestination
                    {
                        OutputUriPrefix = "",
                    },
                    AnnotationSchemaUri = "",
                    BigqueryDestination = new BigQueryDestination { OutputUri = "", },
                    PersistMlUseAssignment = false,
                    StratifiedSplit = new StratifiedSplit
                    {
                        TrainingFraction = 0,
                        ValidationFraction = 0,
                        TestFraction = 0,
                        Key = "",
                    },
                },
                TrainingTaskDefinition = "",
                TrainingTaskInputs = new wkt::Value
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
                TrainingTaskMetadata = new wkt::Value
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
                ModelToUpload = new Model
                {
                    ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                    DisplayName = "",
                    Description = "",
                    PredictSchemata = new PredictSchemata
                    {
                        InstanceSchemaUri = "",
                        ParametersSchemaUri = "",
                        PredictionSchemaUri = "",
                    },
                    MetadataSchemaUri = "",
                    Metadata = new wkt::Value
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
                    TrainingPipelineAsTrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                    ContainerSpec = new ModelContainerSpec
                    {
                        ImageUri = "",
                        Command = { "", },
                        Args = { "", },
                        Env =
                        {
                            new EnvVar { Name = "", Value = "", },
                        },
                        Ports =
                        {
                            new Port { ContainerPort = 0, },
                        },
                        PredictRoute = "",
                        HealthRoute = "",
                        GrpcPorts =
                        {
                            new Port { ContainerPort = 0, },
                        },
                        DeploymentTimeout = new wkt::Duration
                        {
                            Seconds = 0L,
                            Nanos = 0,
                        },
                        SharedMemorySizeMb = 0L,
                        StartupProbe = new Probe
                        {
                            Exec = new Probe.Types.ExecAction { Command = { "", }, },
                            PeriodSeconds = 0,
                            TimeoutSeconds = 0,
                        },
                        HealthProbe = new Probe
                        {
                            Exec = new Probe.Types.ExecAction { Command = { "", }, },
                            PeriodSeconds = 0,
                            TimeoutSeconds = 0,
                        },
                    },
                    SupportedDeploymentResourcesTypes =
                    {
                        Model.Types.DeploymentResourcesType.Unspecified,
                    },
                    SupportedInputStorageFormats = { "", },
                    SupportedOutputStorageFormats = { "", },
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    UpdateTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    DeployedModels =
                    {
                        new DeployedModelRef
                        {
                            EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                            DeployedModelId = "",
                        },
                    },
                    Etag = "",
                    Labels = { { "", "" }, },
                    SupportedExportFormats =
                    {
                        new Model.Types.ExportFormat
                        {
                            Id = "",
                            ExportableContents =
                            {
                                Model.Types.ExportFormat.Types.ExportableContent.Unspecified,
                            },
                        },
                    },
                    DataStats = new Model.Types.DataStats
                    {
                        TrainingDataItemsCount = 0L,
                        ValidationDataItemsCount = 0L,
                        TestDataItemsCount = 0L,
                        TrainingAnnotationsCount = 0L,
                        ValidationAnnotationsCount = 0L,
                        TestAnnotationsCount = 0L,
                    },
                    ExplanationSpec = new ExplanationSpec
                    {
                        Parameters = new ExplanationParameters
                        {
                            SampledShapleyAttribution = new SampledShapleyAttribution { PathCount = 0, },
                            IntegratedGradientsAttribution = new IntegratedGradientsAttribution
                            {
                                StepCount = 0,
                                SmoothGradConfig = new SmoothGradConfig
                                {
                                    NoiseSigma = 0F,
                                    FeatureNoiseSigma = new FeatureNoiseSigma
                                    {
                                        NoiseSigma =
                                        {
                                            new FeatureNoiseSigma.Types.NoiseSigmaForFeature { Name = "", Sigma = 0F, },
                                        },
                                    },
                                    NoisySampleCount = 0,
                                },
                                BlurBaselineConfig = new BlurBaselineConfig { MaxBlurSigma = 0F, },
                            },
                            XraiAttribution = new XraiAttribution
                            {
                                StepCount = 0,
                                SmoothGradConfig = new SmoothGradConfig
                                {
                                    NoiseSigma = 0F,
                                    FeatureNoiseSigma = new FeatureNoiseSigma
                                    {
                                        NoiseSigma =
                                        {
                                            new FeatureNoiseSigma.Types.NoiseSigmaForFeature { Name = "", Sigma = 0F, },
                                        },
                                    },
                                    NoisySampleCount = 0,
                                },
                                BlurBaselineConfig = new BlurBaselineConfig { MaxBlurSigma = 0F, },
                            },
                            TopK = 0,
                            OutputIndices = new wkt::ListValue
                            {
                                Values =
                                {
                                    new wkt::Value
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
                                        ListValue = new wkt::ListValue { },
                                    },
                                },
                            },
                            Examples = new Examples
                            {
                                NearestNeighborSearchConfig = new wkt::Value
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
                                NeighborCount = 0,
                                Presets = new Presets
                                {
                                    Query = Presets.Types.Query.Precise,
                                    Modality = Presets.Types.Modality.Unspecified,
                                },
                                ExampleGcsSource = new Examples.Types.ExampleGcsSource
                                {
                                    DataFormat = Examples.Types.ExampleGcsSource.Types.DataFormat.Unspecified,
                                    GcsSource = new GcsSource { Uris = { "", }, },
                                },
                            },
                        },
                        Metadata = new ExplanationMetadata
                        {
                            Inputs =
                            {
                                {
                                    "",
                                    new ExplanationMetadata.Types.InputMetadata
                                    {
                                        InputBaselines =
                                        {
                                            new wkt::Value
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
                                        InputTensorName = "",
                                        Encoding = ExplanationMetadata.Types.InputMetadata.Types.Encoding.Unspecified,
                                        Modality = "",
                                        FeatureValueDomain = new ExplanationMetadata.Types.InputMetadata.Types.FeatureValueDomain
                                        {
                                            MinValue = 0F,
                                            MaxValue = 0F,
                                            OriginalMean = 0F,
                                            OriginalStddev = 0F,
                                        },
                                        IndicesTensorName = "",
                                        DenseShapeTensorName = "",
                                        IndexFeatureMapping = { "", },
                                        EncodedTensorName = "",
                                        EncodedBaselines =
                                        {
                                            new wkt::Value
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
                                        Visualization = new ExplanationMetadata.Types.InputMetadata.Types.Visualization
                                        {
                                            Type = ExplanationMetadata.Types.InputMetadata.Types.Visualization.Types.Type.Unspecified,
                                            Polarity = ExplanationMetadata.Types.InputMetadata.Types.Visualization.Types.Polarity.Unspecified,
                                            ColorMap = ExplanationMetadata.Types.InputMetadata.Types.Visualization.Types.ColorMap.Unspecified,
                                            ClipPercentUpperbound = 0F,
                                            ClipPercentLowerbound = 0F,
                                            OverlayType = ExplanationMetadata.Types.InputMetadata.Types.Visualization.Types.OverlayType.Unspecified,
                                        },
                                        GroupName = "",
                                    }
                                },
                            },
                            Outputs =
                            {
                                {
                                    "",
                                    new ExplanationMetadata.Types.OutputMetadata
                                    {
                                        IndexDisplayNameMapping = new wkt::Value
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
                                        DisplayNameMappingKey = "",
                                        OutputTensorName = "",
                                    }
                                },
                            },
                            FeatureAttributionsSchemaUri = "",
                            LatentSpaceSource = "",
                        },
                    },
                    EncryptionSpec = new EncryptionSpec { KmsKeyName = "", },
                    ArtifactUri = "",
                    VersionId = "",
                    VersionAliases = { "", },
                    VersionDescription = "",
                    VersionCreateTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    VersionUpdateTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    OriginalModelInfo = new Model.Types.OriginalModelInfo
                    {
                        ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                    },
                    ModelSourceInfo = new ModelSourceInfo
                    {
                        SourceType = ModelSourceInfo.Types.ModelSourceType.Unspecified,
                        Copy = false,
                    },
                    MetadataArtifact = "",
                    PipelineJobAsPipelineJobName = PipelineJobName.FromProjectLocationPipelineJob("[PROJECT]", "[LOCATION]", "[PIPELINE_JOB]"),
                    BaseModelSource = new Model.Types.BaseModelSource
                    {
                        ModelGardenSource = new ModelGardenSource
                        {
                            PublicModelName = "",
                        },
                        GenieSource = new GenieSource { BaseModelUri = "", },
                    },
                },
                State = PipelineState.Unspecified,
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
                Labels = { { "", "" }, },
                EncryptionSpec = new EncryptionSpec { KmsKeyName = "", },
                ParentModel = "",
                ModelId = "",
            };
            // Make the request
            TrainingPipeline response = pipelineServiceClient.CreateTrainingPipeline(parent, trainingPipeline);
        }
    }
    // [END aiplatform_v1_generated_PipelineService_CreateTrainingPipeline_sync_flattened_resourceNames]
}
