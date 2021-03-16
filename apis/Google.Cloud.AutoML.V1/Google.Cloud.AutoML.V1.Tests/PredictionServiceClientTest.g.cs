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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AutoML.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPredictionServiceClientTest
    {
        [xunit::FactAttribute]
        public void PredictRequestObject()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PredictRequest request = new PredictRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload
                {
                    Image = new Image
                    {
                        ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                        ThumbnailUri = "thumbnail_urie7bd82de",
                    },
                    TextSnippet = new TextSnippet
                    {
                        Content = "contentb964039a",
                        MimeType = "mime_type606a0ffc",
                        ContentUri = "content_uriaf560198",
                    },
                    Document = new Document
                    {
                        InputConfig = new DocumentInputConfig
                        {
                            GcsSource = new GcsSource
                            {
                                InputUris =
                                {
                                    "input_urisd64c3b58",
                                },
                            },
                        },
                        DocumentText = new TextSnippet
                        {
                            Content = "contentb964039a",
                            MimeType = "mime_type606a0ffc",
                            ContentUri = "content_uriaf560198",
                        },
                        Layout =
                        {
                            new Document.Types.Layout
                            {
                                TextSegment = new TextSegment
                                {
                                    StartOffset = 6160653193643117332L,
                                    EndOffset = -5902643571191717951L,
                                    Content = "contentb964039a",
                                },
                                PageNumber = 291687312,
                                BoundingPoly = new BoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                                TextSegmentType = Document.Types.Layout.Types.TextSegmentType.FormFieldName,
                            },
                        },
                        DocumentDimensions = new DocumentDimensions
                        {
                            Unit = DocumentDimensions.Types.DocumentDimensionUnit.Centimeter,
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                        },
                        PageCount = 1114157676,
                    },
                },
                Params =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Payload =
                {
                    new AnnotationPayload
                    {
                        AnnotationSpecId = "annotation_spec_ide0c3e8b2",
                        Translation = new TranslationAnnotation
                        {
                            TranslatedContent = new TextSnippet
                            {
                                Content = "contentb964039a",
                                MimeType = "mime_type606a0ffc",
                                ContentUri = "content_uriaf560198",
                            },
                        },
                        Classification = new ClassificationAnnotation
                        {
                            Score = -5.80354E+17F,
                        },
                        ImageObjectDetection = new ImageObjectDetectionAnnotation
                        {
                            BoundingBox = new BoundingPoly
                            {
                                NormalizedVertices =
                                {
                                    new NormalizedVertex
                                    {
                                        X = 4.7289724E+17F,
                                        Y = 1.2858411E+17F,
                                    },
                                },
                            },
                            Score = -5.80354E+17F,
                        },
                        DisplayName = "display_name137f65c2",
                        TextExtraction = new TextExtractionAnnotation
                        {
                            Score = -5.80354E+17F,
                            TextSegment = new TextSegment
                            {
                                StartOffset = 6160653193643117332L,
                                EndOffset = -5902643571191717951L,
                                Content = "contentb964039a",
                            },
                        },
                        TextSentiment = new TextSentimentAnnotation
                        {
                            Sentiment = 364187332,
                        },
                    },
                },
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                PreprocessedInput = new ExamplePayload
                {
                    Image = new Image
                    {
                        ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                        ThumbnailUri = "thumbnail_urie7bd82de",
                    },
                    TextSnippet = new TextSnippet
                    {
                        Content = "contentb964039a",
                        MimeType = "mime_type606a0ffc",
                        ContentUri = "content_uriaf560198",
                    },
                    Document = new Document
                    {
                        InputConfig = new DocumentInputConfig
                        {
                            GcsSource = new GcsSource
                            {
                                InputUris =
                                {
                                    "input_urisd64c3b58",
                                },
                            },
                        },
                        DocumentText = new TextSnippet
                        {
                            Content = "contentb964039a",
                            MimeType = "mime_type606a0ffc",
                            ContentUri = "content_uriaf560198",
                        },
                        Layout =
                        {
                            new Document.Types.Layout
                            {
                                TextSegment = new TextSegment
                                {
                                    StartOffset = 6160653193643117332L,
                                    EndOffset = -5902643571191717951L,
                                    Content = "contentb964039a",
                                },
                                PageNumber = 291687312,
                                BoundingPoly = new BoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                                TextSegmentType = Document.Types.Layout.Types.TextSegmentType.FormFieldName,
                            },
                        },
                        DocumentDimensions = new DocumentDimensions
                        {
                            Unit = DocumentDimensions.Types.DocumentDimensionUnit.Centimeter,
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                        },
                        PageCount = 1114157676,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Predict(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse response = client.Predict(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PredictRequestObjectAsync()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PredictRequest request = new PredictRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload
                {
                    Image = new Image
                    {
                        ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                        ThumbnailUri = "thumbnail_urie7bd82de",
                    },
                    TextSnippet = new TextSnippet
                    {
                        Content = "contentb964039a",
                        MimeType = "mime_type606a0ffc",
                        ContentUri = "content_uriaf560198",
                    },
                    Document = new Document
                    {
                        InputConfig = new DocumentInputConfig
                        {
                            GcsSource = new GcsSource
                            {
                                InputUris =
                                {
                                    "input_urisd64c3b58",
                                },
                            },
                        },
                        DocumentText = new TextSnippet
                        {
                            Content = "contentb964039a",
                            MimeType = "mime_type606a0ffc",
                            ContentUri = "content_uriaf560198",
                        },
                        Layout =
                        {
                            new Document.Types.Layout
                            {
                                TextSegment = new TextSegment
                                {
                                    StartOffset = 6160653193643117332L,
                                    EndOffset = -5902643571191717951L,
                                    Content = "contentb964039a",
                                },
                                PageNumber = 291687312,
                                BoundingPoly = new BoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                                TextSegmentType = Document.Types.Layout.Types.TextSegmentType.FormFieldName,
                            },
                        },
                        DocumentDimensions = new DocumentDimensions
                        {
                            Unit = DocumentDimensions.Types.DocumentDimensionUnit.Centimeter,
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                        },
                        PageCount = 1114157676,
                    },
                },
                Params =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Payload =
                {
                    new AnnotationPayload
                    {
                        AnnotationSpecId = "annotation_spec_ide0c3e8b2",
                        Translation = new TranslationAnnotation
                        {
                            TranslatedContent = new TextSnippet
                            {
                                Content = "contentb964039a",
                                MimeType = "mime_type606a0ffc",
                                ContentUri = "content_uriaf560198",
                            },
                        },
                        Classification = new ClassificationAnnotation
                        {
                            Score = -5.80354E+17F,
                        },
                        ImageObjectDetection = new ImageObjectDetectionAnnotation
                        {
                            BoundingBox = new BoundingPoly
                            {
                                NormalizedVertices =
                                {
                                    new NormalizedVertex
                                    {
                                        X = 4.7289724E+17F,
                                        Y = 1.2858411E+17F,
                                    },
                                },
                            },
                            Score = -5.80354E+17F,
                        },
                        DisplayName = "display_name137f65c2",
                        TextExtraction = new TextExtractionAnnotation
                        {
                            Score = -5.80354E+17F,
                            TextSegment = new TextSegment
                            {
                                StartOffset = 6160653193643117332L,
                                EndOffset = -5902643571191717951L,
                                Content = "contentb964039a",
                            },
                        },
                        TextSentiment = new TextSentimentAnnotation
                        {
                            Sentiment = 364187332,
                        },
                    },
                },
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                PreprocessedInput = new ExamplePayload
                {
                    Image = new Image
                    {
                        ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                        ThumbnailUri = "thumbnail_urie7bd82de",
                    },
                    TextSnippet = new TextSnippet
                    {
                        Content = "contentb964039a",
                        MimeType = "mime_type606a0ffc",
                        ContentUri = "content_uriaf560198",
                    },
                    Document = new Document
                    {
                        InputConfig = new DocumentInputConfig
                        {
                            GcsSource = new GcsSource
                            {
                                InputUris =
                                {
                                    "input_urisd64c3b58",
                                },
                            },
                        },
                        DocumentText = new TextSnippet
                        {
                            Content = "contentb964039a",
                            MimeType = "mime_type606a0ffc",
                            ContentUri = "content_uriaf560198",
                        },
                        Layout =
                        {
                            new Document.Types.Layout
                            {
                                TextSegment = new TextSegment
                                {
                                    StartOffset = 6160653193643117332L,
                                    EndOffset = -5902643571191717951L,
                                    Content = "contentb964039a",
                                },
                                PageNumber = 291687312,
                                BoundingPoly = new BoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                                TextSegmentType = Document.Types.Layout.Types.TextSegmentType.FormFieldName,
                            },
                        },
                        DocumentDimensions = new DocumentDimensions
                        {
                            Unit = DocumentDimensions.Types.DocumentDimensionUnit.Centimeter,
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                        },
                        PageCount = 1114157676,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.PredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse responseCallSettings = await client.PredictAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PredictResponse responseCancellationToken = await client.PredictAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Predict()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PredictRequest request = new PredictRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload
                {
                    Image = new Image
                    {
                        ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                        ThumbnailUri = "thumbnail_urie7bd82de",
                    },
                    TextSnippet = new TextSnippet
                    {
                        Content = "contentb964039a",
                        MimeType = "mime_type606a0ffc",
                        ContentUri = "content_uriaf560198",
                    },
                    Document = new Document
                    {
                        InputConfig = new DocumentInputConfig
                        {
                            GcsSource = new GcsSource
                            {
                                InputUris =
                                {
                                    "input_urisd64c3b58",
                                },
                            },
                        },
                        DocumentText = new TextSnippet
                        {
                            Content = "contentb964039a",
                            MimeType = "mime_type606a0ffc",
                            ContentUri = "content_uriaf560198",
                        },
                        Layout =
                        {
                            new Document.Types.Layout
                            {
                                TextSegment = new TextSegment
                                {
                                    StartOffset = 6160653193643117332L,
                                    EndOffset = -5902643571191717951L,
                                    Content = "contentb964039a",
                                },
                                PageNumber = 291687312,
                                BoundingPoly = new BoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                                TextSegmentType = Document.Types.Layout.Types.TextSegmentType.FormFieldName,
                            },
                        },
                        DocumentDimensions = new DocumentDimensions
                        {
                            Unit = DocumentDimensions.Types.DocumentDimensionUnit.Centimeter,
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                        },
                        PageCount = 1114157676,
                    },
                },
                Params =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Payload =
                {
                    new AnnotationPayload
                    {
                        AnnotationSpecId = "annotation_spec_ide0c3e8b2",
                        Translation = new TranslationAnnotation
                        {
                            TranslatedContent = new TextSnippet
                            {
                                Content = "contentb964039a",
                                MimeType = "mime_type606a0ffc",
                                ContentUri = "content_uriaf560198",
                            },
                        },
                        Classification = new ClassificationAnnotation
                        {
                            Score = -5.80354E+17F,
                        },
                        ImageObjectDetection = new ImageObjectDetectionAnnotation
                        {
                            BoundingBox = new BoundingPoly
                            {
                                NormalizedVertices =
                                {
                                    new NormalizedVertex
                                    {
                                        X = 4.7289724E+17F,
                                        Y = 1.2858411E+17F,
                                    },
                                },
                            },
                            Score = -5.80354E+17F,
                        },
                        DisplayName = "display_name137f65c2",
                        TextExtraction = new TextExtractionAnnotation
                        {
                            Score = -5.80354E+17F,
                            TextSegment = new TextSegment
                            {
                                StartOffset = 6160653193643117332L,
                                EndOffset = -5902643571191717951L,
                                Content = "contentb964039a",
                            },
                        },
                        TextSentiment = new TextSentimentAnnotation
                        {
                            Sentiment = 364187332,
                        },
                    },
                },
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                PreprocessedInput = new ExamplePayload
                {
                    Image = new Image
                    {
                        ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                        ThumbnailUri = "thumbnail_urie7bd82de",
                    },
                    TextSnippet = new TextSnippet
                    {
                        Content = "contentb964039a",
                        MimeType = "mime_type606a0ffc",
                        ContentUri = "content_uriaf560198",
                    },
                    Document = new Document
                    {
                        InputConfig = new DocumentInputConfig
                        {
                            GcsSource = new GcsSource
                            {
                                InputUris =
                                {
                                    "input_urisd64c3b58",
                                },
                            },
                        },
                        DocumentText = new TextSnippet
                        {
                            Content = "contentb964039a",
                            MimeType = "mime_type606a0ffc",
                            ContentUri = "content_uriaf560198",
                        },
                        Layout =
                        {
                            new Document.Types.Layout
                            {
                                TextSegment = new TextSegment
                                {
                                    StartOffset = 6160653193643117332L,
                                    EndOffset = -5902643571191717951L,
                                    Content = "contentb964039a",
                                },
                                PageNumber = 291687312,
                                BoundingPoly = new BoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                                TextSegmentType = Document.Types.Layout.Types.TextSegmentType.FormFieldName,
                            },
                        },
                        DocumentDimensions = new DocumentDimensions
                        {
                            Unit = DocumentDimensions.Types.DocumentDimensionUnit.Centimeter,
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                        },
                        PageCount = 1114157676,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Predict(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse response = client.Predict(request.Name, request.Payload, request.Params);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PredictAsync()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PredictRequest request = new PredictRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload
                {
                    Image = new Image
                    {
                        ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                        ThumbnailUri = "thumbnail_urie7bd82de",
                    },
                    TextSnippet = new TextSnippet
                    {
                        Content = "contentb964039a",
                        MimeType = "mime_type606a0ffc",
                        ContentUri = "content_uriaf560198",
                    },
                    Document = new Document
                    {
                        InputConfig = new DocumentInputConfig
                        {
                            GcsSource = new GcsSource
                            {
                                InputUris =
                                {
                                    "input_urisd64c3b58",
                                },
                            },
                        },
                        DocumentText = new TextSnippet
                        {
                            Content = "contentb964039a",
                            MimeType = "mime_type606a0ffc",
                            ContentUri = "content_uriaf560198",
                        },
                        Layout =
                        {
                            new Document.Types.Layout
                            {
                                TextSegment = new TextSegment
                                {
                                    StartOffset = 6160653193643117332L,
                                    EndOffset = -5902643571191717951L,
                                    Content = "contentb964039a",
                                },
                                PageNumber = 291687312,
                                BoundingPoly = new BoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                                TextSegmentType = Document.Types.Layout.Types.TextSegmentType.FormFieldName,
                            },
                        },
                        DocumentDimensions = new DocumentDimensions
                        {
                            Unit = DocumentDimensions.Types.DocumentDimensionUnit.Centimeter,
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                        },
                        PageCount = 1114157676,
                    },
                },
                Params =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Payload =
                {
                    new AnnotationPayload
                    {
                        AnnotationSpecId = "annotation_spec_ide0c3e8b2",
                        Translation = new TranslationAnnotation
                        {
                            TranslatedContent = new TextSnippet
                            {
                                Content = "contentb964039a",
                                MimeType = "mime_type606a0ffc",
                                ContentUri = "content_uriaf560198",
                            },
                        },
                        Classification = new ClassificationAnnotation
                        {
                            Score = -5.80354E+17F,
                        },
                        ImageObjectDetection = new ImageObjectDetectionAnnotation
                        {
                            BoundingBox = new BoundingPoly
                            {
                                NormalizedVertices =
                                {
                                    new NormalizedVertex
                                    {
                                        X = 4.7289724E+17F,
                                        Y = 1.2858411E+17F,
                                    },
                                },
                            },
                            Score = -5.80354E+17F,
                        },
                        DisplayName = "display_name137f65c2",
                        TextExtraction = new TextExtractionAnnotation
                        {
                            Score = -5.80354E+17F,
                            TextSegment = new TextSegment
                            {
                                StartOffset = 6160653193643117332L,
                                EndOffset = -5902643571191717951L,
                                Content = "contentb964039a",
                            },
                        },
                        TextSentiment = new TextSentimentAnnotation
                        {
                            Sentiment = 364187332,
                        },
                    },
                },
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                PreprocessedInput = new ExamplePayload
                {
                    Image = new Image
                    {
                        ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                        ThumbnailUri = "thumbnail_urie7bd82de",
                    },
                    TextSnippet = new TextSnippet
                    {
                        Content = "contentb964039a",
                        MimeType = "mime_type606a0ffc",
                        ContentUri = "content_uriaf560198",
                    },
                    Document = new Document
                    {
                        InputConfig = new DocumentInputConfig
                        {
                            GcsSource = new GcsSource
                            {
                                InputUris =
                                {
                                    "input_urisd64c3b58",
                                },
                            },
                        },
                        DocumentText = new TextSnippet
                        {
                            Content = "contentb964039a",
                            MimeType = "mime_type606a0ffc",
                            ContentUri = "content_uriaf560198",
                        },
                        Layout =
                        {
                            new Document.Types.Layout
                            {
                                TextSegment = new TextSegment
                                {
                                    StartOffset = 6160653193643117332L,
                                    EndOffset = -5902643571191717951L,
                                    Content = "contentb964039a",
                                },
                                PageNumber = 291687312,
                                BoundingPoly = new BoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                                TextSegmentType = Document.Types.Layout.Types.TextSegmentType.FormFieldName,
                            },
                        },
                        DocumentDimensions = new DocumentDimensions
                        {
                            Unit = DocumentDimensions.Types.DocumentDimensionUnit.Centimeter,
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                        },
                        PageCount = 1114157676,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.PredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse responseCallSettings = await client.PredictAsync(request.Name, request.Payload, request.Params, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PredictResponse responseCancellationToken = await client.PredictAsync(request.Name, request.Payload, request.Params, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PredictResourceNames()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PredictRequest request = new PredictRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload
                {
                    Image = new Image
                    {
                        ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                        ThumbnailUri = "thumbnail_urie7bd82de",
                    },
                    TextSnippet = new TextSnippet
                    {
                        Content = "contentb964039a",
                        MimeType = "mime_type606a0ffc",
                        ContentUri = "content_uriaf560198",
                    },
                    Document = new Document
                    {
                        InputConfig = new DocumentInputConfig
                        {
                            GcsSource = new GcsSource
                            {
                                InputUris =
                                {
                                    "input_urisd64c3b58",
                                },
                            },
                        },
                        DocumentText = new TextSnippet
                        {
                            Content = "contentb964039a",
                            MimeType = "mime_type606a0ffc",
                            ContentUri = "content_uriaf560198",
                        },
                        Layout =
                        {
                            new Document.Types.Layout
                            {
                                TextSegment = new TextSegment
                                {
                                    StartOffset = 6160653193643117332L,
                                    EndOffset = -5902643571191717951L,
                                    Content = "contentb964039a",
                                },
                                PageNumber = 291687312,
                                BoundingPoly = new BoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                                TextSegmentType = Document.Types.Layout.Types.TextSegmentType.FormFieldName,
                            },
                        },
                        DocumentDimensions = new DocumentDimensions
                        {
                            Unit = DocumentDimensions.Types.DocumentDimensionUnit.Centimeter,
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                        },
                        PageCount = 1114157676,
                    },
                },
                Params =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Payload =
                {
                    new AnnotationPayload
                    {
                        AnnotationSpecId = "annotation_spec_ide0c3e8b2",
                        Translation = new TranslationAnnotation
                        {
                            TranslatedContent = new TextSnippet
                            {
                                Content = "contentb964039a",
                                MimeType = "mime_type606a0ffc",
                                ContentUri = "content_uriaf560198",
                            },
                        },
                        Classification = new ClassificationAnnotation
                        {
                            Score = -5.80354E+17F,
                        },
                        ImageObjectDetection = new ImageObjectDetectionAnnotation
                        {
                            BoundingBox = new BoundingPoly
                            {
                                NormalizedVertices =
                                {
                                    new NormalizedVertex
                                    {
                                        X = 4.7289724E+17F,
                                        Y = 1.2858411E+17F,
                                    },
                                },
                            },
                            Score = -5.80354E+17F,
                        },
                        DisplayName = "display_name137f65c2",
                        TextExtraction = new TextExtractionAnnotation
                        {
                            Score = -5.80354E+17F,
                            TextSegment = new TextSegment
                            {
                                StartOffset = 6160653193643117332L,
                                EndOffset = -5902643571191717951L,
                                Content = "contentb964039a",
                            },
                        },
                        TextSentiment = new TextSentimentAnnotation
                        {
                            Sentiment = 364187332,
                        },
                    },
                },
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                PreprocessedInput = new ExamplePayload
                {
                    Image = new Image
                    {
                        ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                        ThumbnailUri = "thumbnail_urie7bd82de",
                    },
                    TextSnippet = new TextSnippet
                    {
                        Content = "contentb964039a",
                        MimeType = "mime_type606a0ffc",
                        ContentUri = "content_uriaf560198",
                    },
                    Document = new Document
                    {
                        InputConfig = new DocumentInputConfig
                        {
                            GcsSource = new GcsSource
                            {
                                InputUris =
                                {
                                    "input_urisd64c3b58",
                                },
                            },
                        },
                        DocumentText = new TextSnippet
                        {
                            Content = "contentb964039a",
                            MimeType = "mime_type606a0ffc",
                            ContentUri = "content_uriaf560198",
                        },
                        Layout =
                        {
                            new Document.Types.Layout
                            {
                                TextSegment = new TextSegment
                                {
                                    StartOffset = 6160653193643117332L,
                                    EndOffset = -5902643571191717951L,
                                    Content = "contentb964039a",
                                },
                                PageNumber = 291687312,
                                BoundingPoly = new BoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                                TextSegmentType = Document.Types.Layout.Types.TextSegmentType.FormFieldName,
                            },
                        },
                        DocumentDimensions = new DocumentDimensions
                        {
                            Unit = DocumentDimensions.Types.DocumentDimensionUnit.Centimeter,
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                        },
                        PageCount = 1114157676,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Predict(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse response = client.Predict(request.ModelName, request.Payload, request.Params);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PredictResourceNamesAsync()
        {
            moq::Mock<PredictionService.PredictionServiceClient> mockGrpcClient = new moq::Mock<PredictionService.PredictionServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PredictRequest request = new PredictRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                Payload = new ExamplePayload
                {
                    Image = new Image
                    {
                        ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                        ThumbnailUri = "thumbnail_urie7bd82de",
                    },
                    TextSnippet = new TextSnippet
                    {
                        Content = "contentb964039a",
                        MimeType = "mime_type606a0ffc",
                        ContentUri = "content_uriaf560198",
                    },
                    Document = new Document
                    {
                        InputConfig = new DocumentInputConfig
                        {
                            GcsSource = new GcsSource
                            {
                                InputUris =
                                {
                                    "input_urisd64c3b58",
                                },
                            },
                        },
                        DocumentText = new TextSnippet
                        {
                            Content = "contentb964039a",
                            MimeType = "mime_type606a0ffc",
                            ContentUri = "content_uriaf560198",
                        },
                        Layout =
                        {
                            new Document.Types.Layout
                            {
                                TextSegment = new TextSegment
                                {
                                    StartOffset = 6160653193643117332L,
                                    EndOffset = -5902643571191717951L,
                                    Content = "contentb964039a",
                                },
                                PageNumber = 291687312,
                                BoundingPoly = new BoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                                TextSegmentType = Document.Types.Layout.Types.TextSegmentType.FormFieldName,
                            },
                        },
                        DocumentDimensions = new DocumentDimensions
                        {
                            Unit = DocumentDimensions.Types.DocumentDimensionUnit.Centimeter,
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                        },
                        PageCount = 1114157676,
                    },
                },
                Params =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            PredictResponse expectedResponse = new PredictResponse
            {
                Payload =
                {
                    new AnnotationPayload
                    {
                        AnnotationSpecId = "annotation_spec_ide0c3e8b2",
                        Translation = new TranslationAnnotation
                        {
                            TranslatedContent = new TextSnippet
                            {
                                Content = "contentb964039a",
                                MimeType = "mime_type606a0ffc",
                                ContentUri = "content_uriaf560198",
                            },
                        },
                        Classification = new ClassificationAnnotation
                        {
                            Score = -5.80354E+17F,
                        },
                        ImageObjectDetection = new ImageObjectDetectionAnnotation
                        {
                            BoundingBox = new BoundingPoly
                            {
                                NormalizedVertices =
                                {
                                    new NormalizedVertex
                                    {
                                        X = 4.7289724E+17F,
                                        Y = 1.2858411E+17F,
                                    },
                                },
                            },
                            Score = -5.80354E+17F,
                        },
                        DisplayName = "display_name137f65c2",
                        TextExtraction = new TextExtractionAnnotation
                        {
                            Score = -5.80354E+17F,
                            TextSegment = new TextSegment
                            {
                                StartOffset = 6160653193643117332L,
                                EndOffset = -5902643571191717951L,
                                Content = "contentb964039a",
                            },
                        },
                        TextSentiment = new TextSentimentAnnotation
                        {
                            Sentiment = 364187332,
                        },
                    },
                },
                Metadata =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                PreprocessedInput = new ExamplePayload
                {
                    Image = new Image
                    {
                        ImageBytes = proto::ByteString.CopyFromUtf8("image_bytesb9388415"),
                        ThumbnailUri = "thumbnail_urie7bd82de",
                    },
                    TextSnippet = new TextSnippet
                    {
                        Content = "contentb964039a",
                        MimeType = "mime_type606a0ffc",
                        ContentUri = "content_uriaf560198",
                    },
                    Document = new Document
                    {
                        InputConfig = new DocumentInputConfig
                        {
                            GcsSource = new GcsSource
                            {
                                InputUris =
                                {
                                    "input_urisd64c3b58",
                                },
                            },
                        },
                        DocumentText = new TextSnippet
                        {
                            Content = "contentb964039a",
                            MimeType = "mime_type606a0ffc",
                            ContentUri = "content_uriaf560198",
                        },
                        Layout =
                        {
                            new Document.Types.Layout
                            {
                                TextSegment = new TextSegment
                                {
                                    StartOffset = 6160653193643117332L,
                                    EndOffset = -5902643571191717951L,
                                    Content = "contentb964039a",
                                },
                                PageNumber = 291687312,
                                BoundingPoly = new BoundingPoly
                                {
                                    NormalizedVertices =
                                    {
                                        new NormalizedVertex
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                        },
                                    },
                                },
                                TextSegmentType = Document.Types.Layout.Types.TextSegmentType.FormFieldName,
                            },
                        },
                        DocumentDimensions = new DocumentDimensions
                        {
                            Unit = DocumentDimensions.Types.DocumentDimensionUnit.Centimeter,
                            Width = 5.667896E+17F,
                            Height = 2.7137237E+17F,
                        },
                        PageCount = 1114157676,
                    },
                },
            };
            mockGrpcClient.Setup(x => x.PredictAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionServiceClient client = new PredictionServiceClientImpl(mockGrpcClient.Object, null);
            PredictResponse responseCallSettings = await client.PredictAsync(request.ModelName, request.Payload, request.Params, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PredictResponse responseCancellationToken = await client.PredictAsync(request.ModelName, request.Payload, request.Params, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
