// Copyright 2021 Google LLC
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

using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DocumentAI.V1Beta2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedDocumentUnderstandingServiceClientTest
    {
        [xunit::FactAttribute]
        public void ProcessDocumentRequestObject()
        {
            moq::Mock<DocumentUnderstandingService.DocumentUnderstandingServiceClient> mockGrpcClient = new moq::Mock<DocumentUnderstandingService.DocumentUnderstandingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ProcessDocumentRequest request = new ProcessDocumentRequest
            {
                InputConfig = new InputConfig
                {
                    GcsSource = new GcsSource { Uri = "uri3db70593", },
                    MimeType = "mime_type606a0ffc",
                    Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                },
                OutputConfig = new OutputConfig
                {
                    GcsDestination = new GcsDestination { Uri = "uri3db70593", },
                    PagesPerShard = -47938902,
                },
                DocumentType = "document_typeba9d5586",
                TableExtractionParams = new TableExtractionParams
                {
                    Enabled = true,
                    TableBoundHints =
                    {
                        new TableBoundHint
                        {
                            PageNumber = 291687312,
                            BoundingBox = new BoundingPoly
                            {
                                Vertices =
                                {
                                    new Vertex
                                    {
                                        X = 1642386589,
                                        Y = 1989169729,
                                    },
                                },
                                NormalizedVertices =
                                {
                                    new NormalizedVertex
                                    {
                                        X = 4.7289724E+17F,
                                        Y = 1.2858411E+17F,
                                    },
                                },
                            },
                        },
                    },
                    HeaderHints =
                    {
                        "header_hints48b12a97",
                    },
                    ModelVersion = "model_versionc74dd723",
                },
                FormExtractionParams = new FormExtractionParams
                {
                    Enabled = true,
                    KeyValuePairHints =
                    {
                        new KeyValuePairHint
                        {
                            Key = "key8a0b6e3c",
                            ValueTypes =
                            {
                                "value_types04984c77",
                            },
                        },
                    },
                    ModelVersion = "model_versionc74dd723",
                },
                EntityExtractionParams = new EntityExtractionParams
                {
                    Enabled = true,
                    ModelVersion = "model_versionc74dd723",
                },
                OcrParams = new OcrParams
                {
                    LanguageHints =
                    {
                        "language_hints03225ef4",
                    },
                },
                AutomlParams = new AutoMlParams
                {
                    Model = "model635ef320",
                },
                Parent = "parent7858e4d0",
            };
            Document expectedResponse = new Document
            {
                Uri = "uri3db70593",
                Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                MimeType = "mime_type606a0ffc",
                Text = "textec51b21c",
                TextStyles =
                {
                    new Document.Types.Style
                    {
                        TextAnchor = new Document.Types.TextAnchor
                        {
                            TextSegments =
                            {
                                new Document.Types.TextAnchor.Types.TextSegment
                                {
                                    StartIndex = 1249496745906949862L,
                                    EndIndex = -3405900056693704065L,
                                },
                            },
                        },
                        Color = new gt::Color
                        {
                            Red = 3.070673E+17F,
                            Green = -4.994538E+17F,
                            Blue = 8.9135635E+17F,
                            Alpha = -5.821188E+17F,
                        },
                        BackgroundColor = new gt::Color
                        {
                            Red = 3.070673E+17F,
                            Green = -4.994538E+17F,
                            Blue = 8.9135635E+17F,
                            Alpha = -5.821188E+17F,
                        },
                        FontWeight = "font_weight4dec3312",
                        TextStyle = "text_styleb6610518",
                        TextDecoration = "text_decoration643d0f7a",
                        FontSize = new Document.Types.Style.Types.FontSize
                        {
                            Size = -9.021568E+17F,
                            Unit = "unitebbd343e",
                        },
                    },
                },
                Pages =
                {
                    new Document.Types.Page
                    {
                        PageNumber = 291687312,
                        Dimension = new Document.Types.Page.Types.Dimension
                        {
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                            Unit = "unitebbd343e",
                        },
                        Layout = new Document.Types.Page.Types.Layout
                        {
                            TextAnchor = new Document.Types.TextAnchor
                            {
                                TextSegments =
                                {
                                    new Document.Types.TextAnchor.Types.TextSegment
                                    {
                                        StartIndex = 1249496745906949862L,
                                        EndIndex = -3405900056693704065L,
                                    },
                                },
                            },
                            Confidence = 8.101506E+17F,
                            BoundingPoly = new BoundingPoly
                            {
                                Vertices =
                                {
                                    new Vertex
                                    {
                                        X = 1642386589,
                                        Y = 1989169729,
                                    },
                                },
                                NormalizedVertices =
                                {
                                    new NormalizedVertex
                                    {
                                        X = 4.7289724E+17F,
                                        Y = 1.2858411E+17F,
                                    },
                                },
                            },
                            Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                            Id = "id74b70bb8",
                        },
                        DetectedLanguages =
                        {
                            new Document.Types.Page.Types.DetectedLanguage
                            {
                                LanguageCode = "language_code2f6c7160",
                                Confidence = 8.101506E+17F,
                            },
                        },
                        Blocks =
                        {
                            new Document.Types.Page.Types.Block
                            {
                                Layout = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                DetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                            },
                        },
                        Paragraphs =
                        {
                            new Document.Types.Page.Types.Paragraph
                            {
                                Layout = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                DetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                            },
                        },
                        Lines =
                        {
                            new Document.Types.Page.Types.Line
                            {
                                Layout = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                DetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                            },
                        },
                        Tokens =
                        {
                            new Document.Types.Page.Types.Token
                            {
                                Layout = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                DetectedBreak = new Document.Types.Page.Types.Token.Types.DetectedBreak
                                {
                                    Type = Document.Types.Page.Types.Token.Types.DetectedBreak.Types.Type.Hyphen,
                                },
                                DetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                            },
                        },
                        VisualElements =
                        {
                            new Document.Types.Page.Types.VisualElement
                            {
                                Layout = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                Type = "typee2cc9d59",
                                DetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                            },
                        },
                        Tables =
                        {
                            new Document.Types.Page.Types.Table
                            {
                                Layout = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                HeaderRows =
                                {
                                    new Document.Types.Page.Types.Table.Types.TableRow
                                    {
                                        Cells =
                                        {
                                            new Document.Types.Page.Types.Table.Types.TableCell
                                            {
                                                Layout = new Document.Types.Page.Types.Layout
                                                {
                                                    TextAnchor = new Document.Types.TextAnchor
                                                    {
                                                        TextSegments =
                                                        {
                                                            new Document.Types.TextAnchor.Types.TextSegment
                                                            {
                                                                StartIndex = 1249496745906949862L,
                                                                EndIndex = -3405900056693704065L,
                                                            },
                                                        },
                                                    },
                                                    Confidence = 8.101506E+17F,
                                                    BoundingPoly = new BoundingPoly
                                                    {
                                                        Vertices =
                                                        {
                                                            new Vertex
                                                            {
                                                                X = 1642386589,
                                                                Y = 1989169729,
                                                            },
                                                        },
                                                        NormalizedVertices =
                                                        {
                                                            new NormalizedVertex
                                                            {
                                                                X = 4.7289724E+17F,
                                                                Y = 1.2858411E+17F,
                                                            },
                                                        },
                                                    },
                                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                                    Id = "id74b70bb8",
                                                },
                                                RowSpan = 1078778551,
                                                ColSpan = -1827988322,
                                                DetectedLanguages =
                                                {
                                                    new Document.Types.Page.Types.DetectedLanguage
                                                    {
                                                        LanguageCode = "language_code2f6c7160",
                                                        Confidence = 8.101506E+17F,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                BodyRows =
                                {
                                    new Document.Types.Page.Types.Table.Types.TableRow
                                    {
                                        Cells =
                                        {
                                            new Document.Types.Page.Types.Table.Types.TableCell
                                            {
                                                Layout = new Document.Types.Page.Types.Layout
                                                {
                                                    TextAnchor = new Document.Types.TextAnchor
                                                    {
                                                        TextSegments =
                                                        {
                                                            new Document.Types.TextAnchor.Types.TextSegment
                                                            {
                                                                StartIndex = 1249496745906949862L,
                                                                EndIndex = -3405900056693704065L,
                                                            },
                                                        },
                                                    },
                                                    Confidence = 8.101506E+17F,
                                                    BoundingPoly = new BoundingPoly
                                                    {
                                                        Vertices =
                                                        {
                                                            new Vertex
                                                            {
                                                                X = 1642386589,
                                                                Y = 1989169729,
                                                            },
                                                        },
                                                        NormalizedVertices =
                                                        {
                                                            new NormalizedVertex
                                                            {
                                                                X = 4.7289724E+17F,
                                                                Y = 1.2858411E+17F,
                                                            },
                                                        },
                                                    },
                                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                                    Id = "id74b70bb8",
                                                },
                                                RowSpan = 1078778551,
                                                ColSpan = -1827988322,
                                                DetectedLanguages =
                                                {
                                                    new Document.Types.Page.Types.DetectedLanguage
                                                    {
                                                        LanguageCode = "language_code2f6c7160",
                                                        Confidence = 8.101506E+17F,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                DetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                            },
                        },
                        FormFields =
                        {
                            new Document.Types.Page.Types.FormField
                            {
                                FieldName = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                FieldValue = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                NameDetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                                ValueDetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                                ValueType = "value_type1f3e9cc8",
                                CorrectedKeyText = "corrected_key_texte3ad6916",
                                CorrectedValueText = "corrected_value_text8dfa9175",
                            },
                        },
                    },
                },
                Entities =
                {
                    new Document.Types.Entity
                    {
                        TextAnchor = new Document.Types.TextAnchor
                        {
                            TextSegments =
                            {
                                new Document.Types.TextAnchor.Types.TextSegment
                                {
                                    StartIndex = 1249496745906949862L,
                                    EndIndex = -3405900056693704065L,
                                },
                            },
                        },
                        Type = "typee2cc9d59",
                        MentionText = "mention_text409ea7b5",
                        MentionId = "mention_id7edce031",
                        Confidence = 8.101506E+17F,
                        PageAnchor = new Document.Types.PageAnchor
                        {
                            PageRefs =
                            {
                                new Document.Types.PageAnchor.Types.PageRef
                                {
                                    Page = 8742459697405920881L,
                                    LayoutType = Document.Types.PageAnchor.Types.PageRef.Types.LayoutType.Unspecified,
                                    LayoutId = "layout_ide01bbc72",
                                },
                            },
                        },
                        Id = "id74b70bb8",
                        BoundingPolyForDemoFrontend = new BoundingPoly
                        {
                            Vertices =
                            {
                                new Vertex
                                {
                                    X = 1642386589,
                                    Y = 1989169729,
                                },
                            },
                            NormalizedVertices =
                            {
                                new NormalizedVertex
                                {
                                    X = 4.7289724E+17F,
                                    Y = 1.2858411E+17F,
                                },
                            },
                        },
                    },
                },
                EntityRelations =
                {
                    new Document.Types.EntityRelation
                    {
                        SubjectId = "subject_idd1a1abff",
                        ObjectId = "object_id7c4331af",
                        Relation = "relation38c91726",
                    },
                },
                ShardInfo = new Document.Types.ShardInfo
                {
                    ShardIndex = 7116426909464676672L,
                    ShardCount = -2642643082932059151L,
                    TextOffset = -9070303115812227795L,
                },
                Error = new gr::Status
                {
                    Code = -1805175871,
                    Message = "message0231e778",
                    Details =
                    {
                        new wkt::Any
                        {
                            TypeUrl = "type_urlfde5623b",
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
                Labels =
                {
                    new Document.Types.Label
                    {
                        Name = "name1c9368b0",
                        AutomlModel = "automl_model9e46e4b4",
                        Confidence = 8.101506E+17F,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.ProcessDocument(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            DocumentUnderstandingServiceClient client = new DocumentUnderstandingServiceClientImpl(mockGrpcClient.Object, null);
            Document response = client.ProcessDocument(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ProcessDocumentRequestObjectAsync()
        {
            moq::Mock<DocumentUnderstandingService.DocumentUnderstandingServiceClient> mockGrpcClient = new moq::Mock<DocumentUnderstandingService.DocumentUnderstandingServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ProcessDocumentRequest request = new ProcessDocumentRequest
            {
                InputConfig = new InputConfig
                {
                    GcsSource = new GcsSource { Uri = "uri3db70593", },
                    MimeType = "mime_type606a0ffc",
                    Contents = proto::ByteString.CopyFromUtf8("contents8c7dbf98"),
                },
                OutputConfig = new OutputConfig
                {
                    GcsDestination = new GcsDestination { Uri = "uri3db70593", },
                    PagesPerShard = -47938902,
                },
                DocumentType = "document_typeba9d5586",
                TableExtractionParams = new TableExtractionParams
                {
                    Enabled = true,
                    TableBoundHints =
                    {
                        new TableBoundHint
                        {
                            PageNumber = 291687312,
                            BoundingBox = new BoundingPoly
                            {
                                Vertices =
                                {
                                    new Vertex
                                    {
                                        X = 1642386589,
                                        Y = 1989169729,
                                    },
                                },
                                NormalizedVertices =
                                {
                                    new NormalizedVertex
                                    {
                                        X = 4.7289724E+17F,
                                        Y = 1.2858411E+17F,
                                    },
                                },
                            },
                        },
                    },
                    HeaderHints =
                    {
                        "header_hints48b12a97",
                    },
                    ModelVersion = "model_versionc74dd723",
                },
                FormExtractionParams = new FormExtractionParams
                {
                    Enabled = true,
                    KeyValuePairHints =
                    {
                        new KeyValuePairHint
                        {
                            Key = "key8a0b6e3c",
                            ValueTypes =
                            {
                                "value_types04984c77",
                            },
                        },
                    },
                    ModelVersion = "model_versionc74dd723",
                },
                EntityExtractionParams = new EntityExtractionParams
                {
                    Enabled = true,
                    ModelVersion = "model_versionc74dd723",
                },
                OcrParams = new OcrParams
                {
                    LanguageHints =
                    {
                        "language_hints03225ef4",
                    },
                },
                AutomlParams = new AutoMlParams
                {
                    Model = "model635ef320",
                },
                Parent = "parent7858e4d0",
            };
            Document expectedResponse = new Document
            {
                Uri = "uri3db70593",
                Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                MimeType = "mime_type606a0ffc",
                Text = "textec51b21c",
                TextStyles =
                {
                    new Document.Types.Style
                    {
                        TextAnchor = new Document.Types.TextAnchor
                        {
                            TextSegments =
                            {
                                new Document.Types.TextAnchor.Types.TextSegment
                                {
                                    StartIndex = 1249496745906949862L,
                                    EndIndex = -3405900056693704065L,
                                },
                            },
                        },
                        Color = new gt::Color
                        {
                            Red = 3.070673E+17F,
                            Green = -4.994538E+17F,
                            Blue = 8.9135635E+17F,
                            Alpha = -5.821188E+17F,
                        },
                        BackgroundColor = new gt::Color
                        {
                            Red = 3.070673E+17F,
                            Green = -4.994538E+17F,
                            Blue = 8.9135635E+17F,
                            Alpha = -5.821188E+17F,
                        },
                        FontWeight = "font_weight4dec3312",
                        TextStyle = "text_styleb6610518",
                        TextDecoration = "text_decoration643d0f7a",
                        FontSize = new Document.Types.Style.Types.FontSize
                        {
                            Size = -9.021568E+17F,
                            Unit = "unitebbd343e",
                        },
                    },
                },
                Pages =
                {
                    new Document.Types.Page
                    {
                        PageNumber = 291687312,
                        Dimension = new Document.Types.Page.Types.Dimension
                        {
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                            Unit = "unitebbd343e",
                        },
                        Layout = new Document.Types.Page.Types.Layout
                        {
                            TextAnchor = new Document.Types.TextAnchor
                            {
                                TextSegments =
                                {
                                    new Document.Types.TextAnchor.Types.TextSegment
                                    {
                                        StartIndex = 1249496745906949862L,
                                        EndIndex = -3405900056693704065L,
                                    },
                                },
                            },
                            Confidence = 8.101506E+17F,
                            BoundingPoly = new BoundingPoly
                            {
                                Vertices =
                                {
                                    new Vertex
                                    {
                                        X = 1642386589,
                                        Y = 1989169729,
                                    },
                                },
                                NormalizedVertices =
                                {
                                    new NormalizedVertex
                                    {
                                        X = 4.7289724E+17F,
                                        Y = 1.2858411E+17F,
                                    },
                                },
                            },
                            Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                            Id = "id74b70bb8",
                        },
                        DetectedLanguages =
                        {
                            new Document.Types.Page.Types.DetectedLanguage
                            {
                                LanguageCode = "language_code2f6c7160",
                                Confidence = 8.101506E+17F,
                            },
                        },
                        Blocks =
                        {
                            new Document.Types.Page.Types.Block
                            {
                                Layout = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                DetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                            },
                        },
                        Paragraphs =
                        {
                            new Document.Types.Page.Types.Paragraph
                            {
                                Layout = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                DetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                            },
                        },
                        Lines =
                        {
                            new Document.Types.Page.Types.Line
                            {
                                Layout = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                DetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                            },
                        },
                        Tokens =
                        {
                            new Document.Types.Page.Types.Token
                            {
                                Layout = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                DetectedBreak = new Document.Types.Page.Types.Token.Types.DetectedBreak
                                {
                                    Type = Document.Types.Page.Types.Token.Types.DetectedBreak.Types.Type.Hyphen,
                                },
                                DetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                            },
                        },
                        VisualElements =
                        {
                            new Document.Types.Page.Types.VisualElement
                            {
                                Layout = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                Type = "typee2cc9d59",
                                DetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                            },
                        },
                        Tables =
                        {
                            new Document.Types.Page.Types.Table
                            {
                                Layout = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                HeaderRows =
                                {
                                    new Document.Types.Page.Types.Table.Types.TableRow
                                    {
                                        Cells =
                                        {
                                            new Document.Types.Page.Types.Table.Types.TableCell
                                            {
                                                Layout = new Document.Types.Page.Types.Layout
                                                {
                                                    TextAnchor = new Document.Types.TextAnchor
                                                    {
                                                        TextSegments =
                                                        {
                                                            new Document.Types.TextAnchor.Types.TextSegment
                                                            {
                                                                StartIndex = 1249496745906949862L,
                                                                EndIndex = -3405900056693704065L,
                                                            },
                                                        },
                                                    },
                                                    Confidence = 8.101506E+17F,
                                                    BoundingPoly = new BoundingPoly
                                                    {
                                                        Vertices =
                                                        {
                                                            new Vertex
                                                            {
                                                                X = 1642386589,
                                                                Y = 1989169729,
                                                            },
                                                        },
                                                        NormalizedVertices =
                                                        {
                                                            new NormalizedVertex
                                                            {
                                                                X = 4.7289724E+17F,
                                                                Y = 1.2858411E+17F,
                                                            },
                                                        },
                                                    },
                                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                                    Id = "id74b70bb8",
                                                },
                                                RowSpan = 1078778551,
                                                ColSpan = -1827988322,
                                                DetectedLanguages =
                                                {
                                                    new Document.Types.Page.Types.DetectedLanguage
                                                    {
                                                        LanguageCode = "language_code2f6c7160",
                                                        Confidence = 8.101506E+17F,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                BodyRows =
                                {
                                    new Document.Types.Page.Types.Table.Types.TableRow
                                    {
                                        Cells =
                                        {
                                            new Document.Types.Page.Types.Table.Types.TableCell
                                            {
                                                Layout = new Document.Types.Page.Types.Layout
                                                {
                                                    TextAnchor = new Document.Types.TextAnchor
                                                    {
                                                        TextSegments =
                                                        {
                                                            new Document.Types.TextAnchor.Types.TextSegment
                                                            {
                                                                StartIndex = 1249496745906949862L,
                                                                EndIndex = -3405900056693704065L,
                                                            },
                                                        },
                                                    },
                                                    Confidence = 8.101506E+17F,
                                                    BoundingPoly = new BoundingPoly
                                                    {
                                                        Vertices =
                                                        {
                                                            new Vertex
                                                            {
                                                                X = 1642386589,
                                                                Y = 1989169729,
                                                            },
                                                        },
                                                        NormalizedVertices =
                                                        {
                                                            new NormalizedVertex
                                                            {
                                                                X = 4.7289724E+17F,
                                                                Y = 1.2858411E+17F,
                                                            },
                                                        },
                                                    },
                                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                                    Id = "id74b70bb8",
                                                },
                                                RowSpan = 1078778551,
                                                ColSpan = -1827988322,
                                                DetectedLanguages =
                                                {
                                                    new Document.Types.Page.Types.DetectedLanguage
                                                    {
                                                        LanguageCode = "language_code2f6c7160",
                                                        Confidence = 8.101506E+17F,
                                                    },
                                                },
                                            },
                                        },
                                    },
                                },
                                DetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                            },
                        },
                        FormFields =
                        {
                            new Document.Types.Page.Types.FormField
                            {
                                FieldName = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                FieldValue = new Document.Types.Page.Types.Layout
                                {
                                    TextAnchor = new Document.Types.TextAnchor
                                    {
                                        TextSegments =
                                        {
                                            new Document.Types.TextAnchor.Types.TextSegment
                                            {
                                                StartIndex = 1249496745906949862L,
                                                EndIndex = -3405900056693704065L,
                                            },
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                    BoundingPoly = new BoundingPoly
                                    {
                                        Vertices =
                                        {
                                            new Vertex
                                            {
                                                X = 1642386589,
                                                Y = 1989169729,
                                            },
                                        },
                                        NormalizedVertices =
                                        {
                                            new NormalizedVertex
                                            {
                                                X = 4.7289724E+17F,
                                                Y = 1.2858411E+17F,
                                            },
                                        },
                                    },
                                    Orientation = Document.Types.Page.Types.Layout.Types.Orientation.PageDown,
                                    Id = "id74b70bb8",
                                },
                                NameDetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                                ValueDetectedLanguages =
                                {
                                    new Document.Types.Page.Types.DetectedLanguage
                                    {
                                        LanguageCode = "language_code2f6c7160",
                                        Confidence = 8.101506E+17F,
                                    },
                                },
                                ValueType = "value_type1f3e9cc8",
                                CorrectedKeyText = "corrected_key_texte3ad6916",
                                CorrectedValueText = "corrected_value_text8dfa9175",
                            },
                        },
                    },
                },
                Entities =
                {
                    new Document.Types.Entity
                    {
                        TextAnchor = new Document.Types.TextAnchor
                        {
                            TextSegments =
                            {
                                new Document.Types.TextAnchor.Types.TextSegment
                                {
                                    StartIndex = 1249496745906949862L,
                                    EndIndex = -3405900056693704065L,
                                },
                            },
                        },
                        Type = "typee2cc9d59",
                        MentionText = "mention_text409ea7b5",
                        MentionId = "mention_id7edce031",
                        Confidence = 8.101506E+17F,
                        PageAnchor = new Document.Types.PageAnchor
                        {
                            PageRefs =
                            {
                                new Document.Types.PageAnchor.Types.PageRef
                                {
                                    Page = 8742459697405920881L,
                                    LayoutType = Document.Types.PageAnchor.Types.PageRef.Types.LayoutType.Unspecified,
                                    LayoutId = "layout_ide01bbc72",
                                },
                            },
                        },
                        Id = "id74b70bb8",
                        BoundingPolyForDemoFrontend = new BoundingPoly
                        {
                            Vertices =
                            {
                                new Vertex
                                {
                                    X = 1642386589,
                                    Y = 1989169729,
                                },
                            },
                            NormalizedVertices =
                            {
                                new NormalizedVertex
                                {
                                    X = 4.7289724E+17F,
                                    Y = 1.2858411E+17F,
                                },
                            },
                        },
                    },
                },
                EntityRelations =
                {
                    new Document.Types.EntityRelation
                    {
                        SubjectId = "subject_idd1a1abff",
                        ObjectId = "object_id7c4331af",
                        Relation = "relation38c91726",
                    },
                },
                ShardInfo = new Document.Types.ShardInfo
                {
                    ShardIndex = 7116426909464676672L,
                    ShardCount = -2642643082932059151L,
                    TextOffset = -9070303115812227795L,
                },
                Error = new gr::Status
                {
                    Code = -1805175871,
                    Message = "message0231e778",
                    Details =
                    {
                        new wkt::Any
                        {
                            TypeUrl = "type_urlfde5623b",
                            Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                        },
                    },
                },
                Labels =
                {
                    new Document.Types.Label
                    {
                        Name = "name1c9368b0",
                        AutomlModel = "automl_model9e46e4b4",
                        Confidence = 8.101506E+17F,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.ProcessDocumentAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Document>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            DocumentUnderstandingServiceClient client = new DocumentUnderstandingServiceClientImpl(mockGrpcClient.Object, null);
            Document responseCallSettings = await client.ProcessDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Document responseCancellationToken = await client.ProcessDocumentAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
