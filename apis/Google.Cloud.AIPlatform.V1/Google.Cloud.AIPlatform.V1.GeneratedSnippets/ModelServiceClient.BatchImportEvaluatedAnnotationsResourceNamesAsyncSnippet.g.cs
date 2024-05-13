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
    // [START aiplatform_v1_generated_ModelService_BatchImportEvaluatedAnnotations_async_flattened_resourceNames]
    using Google.Cloud.AIPlatform.V1;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedModelServiceClientSnippets
    {
        /// <summary>Snippet for BatchImportEvaluatedAnnotationsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task BatchImportEvaluatedAnnotationsResourceNamesAsync()
        {
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelEvaluationSliceName parent = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]");
            IEnumerable<EvaluatedAnnotation> evaluatedAnnotations = new EvaluatedAnnotation[]
            {
                new EvaluatedAnnotation
                {
                    Type = EvaluatedAnnotation.Types.EvaluatedAnnotationType.Unspecified,
                    Predictions =
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
                    GroundTruths =
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
                    DataItemPayload = new wkt::Value
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
                    EvaluatedDataItemViewId = "",
                    Explanations =
                    {
                        new EvaluatedAnnotationExplanation
                        {
                            ExplanationType = "",
                            Explanation = new Explanation
                            {
                                Attributions =
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
                                Neighbors =
                                {
                                    new Neighbor
                                    {
                                        NeighborId = "",
                                        NeighborDistance = 0,
                                    },
                                },
                            },
                        },
                    },
                    ErrorAnalysisAnnotations =
                    {
                        new ErrorAnalysisAnnotation
                        {
                            AttributedItems =
                            {
                                new ErrorAnalysisAnnotation.Types.AttributedItem
                                {
                                    AnnotationResourceName = "",
                                    Distance = 0,
                                },
                            },
                            QueryType = ErrorAnalysisAnnotation.Types.QueryType.Unspecified,
                            OutlierScore = 0,
                            OutlierThreshold = 0,
                        },
                    },
                },
            };
            // Make the request
            BatchImportEvaluatedAnnotationsResponse response = await modelServiceClient.BatchImportEvaluatedAnnotationsAsync(parent, evaluatedAnnotations);
        }
    }
    // [END aiplatform_v1_generated_ModelService_BatchImportEvaluatedAnnotations_async_flattened_resourceNames]
}
