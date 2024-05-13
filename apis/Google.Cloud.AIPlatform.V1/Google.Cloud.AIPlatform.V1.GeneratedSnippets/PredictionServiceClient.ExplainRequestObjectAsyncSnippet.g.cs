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
    // [START aiplatform_v1_generated_PredictionService_Explain_async]
    using Google.Cloud.AIPlatform.V1;
    using System.Threading.Tasks;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedPredictionServiceClientSnippets
    {
        /// <summary>Snippet for ExplainAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task ExplainRequestObjectAsync()
        {
            // Create client
            PredictionServiceClient predictionServiceClient = await PredictionServiceClient.CreateAsync();
            // Initialize request argument(s)
            ExplainRequest request = new ExplainRequest
            {
                EndpointAsEndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                Instances =
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
                DeployedModelId = "",
                Parameters = new wkt::Value
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
                ExplanationSpecOverride = new ExplanationSpecOverride
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
                    Metadata = new ExplanationMetadataOverride
                    {
                        Inputs =
                        {
                            {
                                "",
                                new ExplanationMetadataOverride.Types.InputMetadataOverride
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
                                }
                            },
                        },
                    },
                    ExamplesOverride = new ExamplesOverride
                    {
                        NeighborCount = 0,
                        CrowdingCount = 0,
                        Restrictions =
                        {
                            new ExamplesRestrictionsNamespace
                            {
                                NamespaceName = "",
                                Allow = { "", },
                                Deny = { "", },
                            },
                        },
                        ReturnEmbeddings = false,
                        DataFormat = ExamplesOverride.Types.DataFormat.Unspecified,
                    },
                },
            };
            // Make the request
            ExplainResponse response = await predictionServiceClient.ExplainAsync(request);
        }
    }
    // [END aiplatform_v1_generated_PredictionService_Explain_async]
}
