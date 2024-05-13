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
    // [START aiplatform_v1_generated_EndpointService_DeployModel_sync]
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedEndpointServiceClientSnippets
    {
        /// <summary>Snippet for DeployModel</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void DeployModelRequestObject()
        {
            // Create client
            EndpointServiceClient endpointServiceClient = EndpointServiceClient.Create();
            // Initialize request argument(s)
            DeployModelRequest request = new DeployModelRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DeployedModel = new DeployedModel
                {
                    Id = "",
                    ModelAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                    DisplayName = "",
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
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
                    AutomaticResources = new AutomaticResources
                    {
                        MinReplicaCount = 0,
                        MaxReplicaCount = 0,
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
                    ServiceAccount = "",
                    EnableAccessLogging = false,
                    PrivateEndpoints = new PrivateEndpoints
                    {
                        PredictHttpUri = "",
                        ExplainHttpUri = "",
                        HealthHttpUri = "",
                        ServiceAttachment = "",
                    },
                    DisableContainerLogging = false,
                    SharedResourcesAsDeploymentResourcePoolName = DeploymentResourcePoolName.FromProjectLocationDeploymentResourcePool("[PROJECT]", "[LOCATION]", "[DEPLOYMENT_RESOURCE_POOL]"),
                    ModelVersionId = "",
                    DisableExplanations = false,
                },
                TrafficSplit = { { "", 0 }, },
            };
            // Make the request
            Operation<DeployModelResponse, DeployModelOperationMetadata> response = endpointServiceClient.DeployModel(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployModelResponse, DeployModelOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DeployModelResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployModelResponse, DeployModelOperationMetadata> retrievedResponse = endpointServiceClient.PollOnceDeployModel(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployModelResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_EndpointService_DeployModel_sync]
}
