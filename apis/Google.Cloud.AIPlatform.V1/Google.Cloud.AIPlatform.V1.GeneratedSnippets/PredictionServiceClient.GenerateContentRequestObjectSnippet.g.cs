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
    // [START aiplatform_v1_generated_PredictionService_GenerateContent_sync]
    using Google.Cloud.AIPlatform.V1;
    using Google.Protobuf;
    using wkt = Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedPredictionServiceClientSnippets
    {
        /// <summary>Snippet for GenerateContent</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void GenerateContentRequestObject()
        {
            // Create client
            PredictionServiceClient predictionServiceClient = PredictionServiceClient.Create();
            // Initialize request argument(s)
            GenerateContentRequest request = new GenerateContentRequest
            {
                Contents =
                {
                    new Content
                    {
                        Role = "",
                        Parts =
                        {
                            new Part
                            {
                                Text = "",
                                InlineData = new Blob
                                {
                                    MimeType = "",
                                    Data = ByteString.Empty,
                                },
                                FileData = new FileData
                                {
                                    MimeType = "",
                                    FileUri = "",
                                },
                                VideoMetadata = new VideoMetadata
                                {
                                    StartOffset = new wkt::Duration
                                    {
                                        Seconds = 0L,
                                        Nanos = 0,
                                    },
                                    EndOffset = new wkt::Duration
                                    {
                                        Seconds = 0L,
                                        Nanos = 0,
                                    },
                                },
                                FunctionCall = new FunctionCall
                                {
                                    Name = "",
                                    Args = new wkt::Struct
                                    {
                                        Fields =
                                        {
                                            {
                                                "",
                                                new wkt::Value
                                                {
                                                    NullValue = wkt::NullValue.NullValue,
                                                    NumberValue = 0,
                                                    StringValue = "",
                                                    BoolValue = false,
                                                    StructValue = new wkt::Struct { },
                                                    ListValue = new wkt::ListValue
                                                    {
                                                        Values = { new wkt::Value { }, },
                                                    },
                                                }
                                            },
                                        },
                                    },
                                },
                                FunctionResponse = new FunctionResponse
                                {
                                    Name = "",
                                    Response = new wkt::Struct
                                    {
                                        Fields =
                                        {
                                            {
                                                "",
                                                new wkt::Value
                                                {
                                                    NullValue = wkt::NullValue.NullValue,
                                                    NumberValue = 0,
                                                    StringValue = "",
                                                    BoolValue = false,
                                                    StructValue = new wkt::Struct { },
                                                    ListValue = new wkt::ListValue
                                                    {
                                                        Values = { new wkt::Value { }, },
                                                    },
                                                }
                                            },
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
                SafetySettings =
                {
                    new SafetySetting
                    {
                        Category = HarmCategory.Unspecified,
                        Threshold = SafetySetting.Types.HarmBlockThreshold.Unspecified,
                        Method = SafetySetting.Types.HarmBlockMethod.Unspecified,
                    },
                },
                GenerationConfig = new GenerationConfig
                {
                    Temperature = 0F,
                    TopP = 0F,
                    TopK = 0F,
                    CandidateCount = 0,
                    MaxOutputTokens = 0,
                    StopSequences = { "", },
                    PresencePenalty = 0F,
                    FrequencyPenalty = 0F,
                    ResponseMimeType = "",
                },
                Model = "",
                Tools =
                {
                    new Tool
                    {
                        FunctionDeclarations =
                        {
                            new FunctionDeclaration
                            {
                                Name = "",
                                Description = "",
                                Parameters = new OpenApiSchema
                                {
                                    Type = Type.Unspecified,
                                    Items = new OpenApiSchema { },
                                    Properties =
                                    {
                                        {
                                            "",
                                            new OpenApiSchema { }
                                        },
                                    },
                                    Example = new wkt::Value
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
                                    Required = { "", },
                                    Nullable = false,
                                    Format = "",
                                    Description = "",
                                    Enum = { "", },
                                    MinProperties = 0L,
                                    MaxProperties = 0L,
                                    Minimum = 0,
                                    Maximum = 0,
                                    MinLength = 0L,
                                    MaxLength = 0L,
                                    Pattern = "",
                                    MinItems = 0L,
                                    MaxItems = 0L,
                                    Default = new wkt::Value
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
                                    Title = "",
                                },
                            },
                        },
                        Retrieval = new Retrieval
                        {
                            VertexAiSearch = new VertexAISearch { Datastore = "", },
                            DisableAttribution = false,
                        },
                        GoogleSearchRetrieval = new GoogleSearchRetrieval
                        {
                            DisableAttribution = false,
                        },
                    },
                },
                SystemInstruction = new Content
                {
                    Role = "",
                    Parts =
                    {
                        new Part
                        {
                            Text = "",
                            InlineData = new Blob
                            {
                                MimeType = "",
                                Data = ByteString.Empty,
                            },
                            FileData = new FileData
                            {
                                MimeType = "",
                                FileUri = "",
                            },
                            VideoMetadata = new VideoMetadata
                            {
                                StartOffset = new wkt::Duration
                                {
                                    Seconds = 0L,
                                    Nanos = 0,
                                },
                                EndOffset = new wkt::Duration
                                {
                                    Seconds = 0L,
                                    Nanos = 0,
                                },
                            },
                            FunctionCall = new FunctionCall
                            {
                                Name = "",
                                Args = new wkt::Struct
                                {
                                    Fields =
                                    {
                                        {
                                            "",
                                            new wkt::Value
                                            {
                                                NullValue = wkt::NullValue.NullValue,
                                                NumberValue = 0,
                                                StringValue = "",
                                                BoolValue = false,
                                                StructValue = new wkt::Struct { },
                                                ListValue = new wkt::ListValue
                                                {
                                                    Values = { new wkt::Value { }, },
                                                },
                                            }
                                        },
                                    },
                                },
                            },
                            FunctionResponse = new FunctionResponse
                            {
                                Name = "",
                                Response = new wkt::Struct
                                {
                                    Fields =
                                    {
                                        {
                                            "",
                                            new wkt::Value
                                            {
                                                NullValue = wkt::NullValue.NullValue,
                                                NumberValue = 0,
                                                StringValue = "",
                                                BoolValue = false,
                                                StructValue = new wkt::Struct { },
                                                ListValue = new wkt::ListValue
                                                {
                                                    Values = { new wkt::Value { }, },
                                                },
                                            }
                                        },
                                    },
                                },
                            },
                        },
                    },
                },
            };
            // Make the request
            GenerateContentResponse response = predictionServiceClient.GenerateContent(request);
        }
    }
    // [END aiplatform_v1_generated_PredictionService_GenerateContent_sync]
}
