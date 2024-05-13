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
    // [START aiplatform_v1_generated_ModelService_BatchImportModelEvaluationSlices_async_flattened_resourceNames]
    using Google.Cloud.AIPlatform.V1;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedModelServiceClientSnippets
    {
        /// <summary>Snippet for BatchImportModelEvaluationSlicesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task BatchImportModelEvaluationSlicesResourceNamesAsync()
        {
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelEvaluationName parent = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]");
            IEnumerable<ModelEvaluationSlice> modelEvaluationSlices = new ModelEvaluationSlice[]
            {
                new ModelEvaluationSlice
                {
                    ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
                    Slice = new ModelEvaluationSlice.Types.Slice
                    {
                        Dimension = "",
                        Value = "",
                        SliceSpec = new ModelEvaluationSlice.Types.Slice.Types.SliceSpec
                        {
                            Configs =
                            {
                                {
                                    "",
                                    new ModelEvaluationSlice.Types.Slice.Types.SliceSpec.Types.SliceConfig
                                    {
                                        Value = new ModelEvaluationSlice.Types.Slice.Types.SliceSpec.Types.Value
                                        {
                                            StringValue = "",
                                            FloatValue = 0F,
                                        },
                                        Range = new ModelEvaluationSlice.Types.Slice.Types.SliceSpec.Types.Range { Low = 0F, High = 0F, },
                                        AllValues = false,
                                    }
                                },
                            },
                        },
                    },
                    MetricsSchemaUri = "",
                    Metrics = new wkt::Value
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
                    CreateTime = new wkt::Timestamp
                    {
                        Seconds = 0L,
                        Nanos = 0,
                    },
                    ModelExplanation = new ModelExplanation
                    {
                        MeanAttributions =
                        {
                            new Attribution
                            {
                                BaselineOutputValue = 0,
                                InstanceOutputValue = 0,
                                FeatureAttributions = new wkt::Value
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
                                OutputIndex = { 0, },
                                OutputDisplayName = "",
                                ApproximationError = 0,
                                OutputName = "",
                            },
                        },
                    },
                },
            };
            // Make the request
            BatchImportModelEvaluationSlicesResponse response = await modelServiceClient.BatchImportModelEvaluationSlicesAsync(parent, modelEvaluationSlices);
        }
    }
    // [END aiplatform_v1_generated_ModelService_BatchImportModelEvaluationSlices_async_flattened_resourceNames]
}
