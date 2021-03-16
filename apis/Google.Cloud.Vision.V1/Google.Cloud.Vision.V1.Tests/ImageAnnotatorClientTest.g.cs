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

namespace Google.Cloud.Vision.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedImageAnnotatorClientTest
    {
        [xunit::FactAttribute]
        public void BatchAnnotateImagesRequestObject()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    new AnnotateImageRequest
                    {
                        Image = new Image
                        {
                            Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                            Source = new ImageSource
                            {
                                GcsImageUri = "gcs_image_urid884f666",
                                ImageUri = "image_urieba3b1bc",
                            },
                        },
                        Features =
                        {
                            new Feature
                            {
                                Type = Feature.Types.Type.CropHints,
                                MaxResults = -1488152846,
                                Model = "model635ef320",
                            },
                        },
                        ImageContext = new ImageContext
                        {
                            LatLongRect = new LatLongRect
                            {
                                MinLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                                MaxLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                            },
                            LanguageHints =
                            {
                                "language_hints03225ef4",
                            },
                            CropHintsParams = new CropHintsParams
                            {
                                AspectRatios = { 1.033126E+18F, },
                            },
                            ProductSearchParams = new ProductSearchParams
                            {
                                ProductSetAsProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                                ProductCategories =
                                {
                                    "product_categories01426367",
                                },
                                Filter = "filtere47ac9b2",
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
                            },
                            WebDetectionParams = new WebDetectionParams
                            {
                                IncludeGeoResults = true,
                            },
                            TextDetectionParams = new TextDetectionParams
                            {
                                EnableTextDetectionConfidenceScore = true,
                            },
                        },
                    },
                },
                Parent = "parent7858e4d0",
            };
            BatchAnnotateImagesResponse expectedResponse = new BatchAnnotateImagesResponse
            {
                Responses =
                {
                    new AnnotateImageResponse
                    {
                        FaceAnnotations =
                        {
                            new FaceAnnotation
                            {
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
                                FdBoundingPoly = new BoundingPoly
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
                                Landmarks =
                                {
                                    new FaceAnnotation.Types.Landmark
                                    {
                                        Type = FaceAnnotation.Types.Landmark.Types.Type.RightEyePupil,
                                        Position = new Position
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                            Z = -4.034153E+17F,
                                        },
                                    },
                                },
                                RollAngle = 5.6015E+17F,
                                PanAngle = -3.964234E+17F,
                                TiltAngle = -4.387485E+17F,
                                DetectionConfidence = -1.11668655E+18F,
                                LandmarkingConfidence = -4.6933908E+17F,
                                JoyLikelihood = Likelihood.Unknown,
                                SorrowLikelihood = Likelihood.VeryLikely,
                                AngerLikelihood = Likelihood.VeryLikely,
                                SurpriseLikelihood = Likelihood.Possible,
                                UnderExposedLikelihood = Likelihood.Likely,
                                BlurredLikelihood = Likelihood.Possible,
                                HeadwearLikelihood = Likelihood.Unknown,
                            },
                        },
                        LandmarkAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        LogoAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        LabelAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        TextAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        SafeSearchAnnotation = new SafeSearchAnnotation
                        {
                            Adult = Likelihood.Unlikely,
                            Spoof = Likelihood.Likely,
                            Medical = Likelihood.Unlikely,
                            Violence = Likelihood.Likely,
                            Racy = Likelihood.Unknown,
#pragma warning disable CS0612
                            AdultConfidence = 7.893828E+17F,
                            SpoofConfidence = 1.21577665E+17F,
                            MedicalConfidence = 5.6571437E+17F,
                            ViolenceConfidence = 3.1119182E+17F,
                            RacyConfidence = -1.14657856E+18F,
                            NsfwConfidence = 6.880875E+17F,
#pragma warning restore CS0612
                        },
                        ImagePropertiesAnnotation = new ImageProperties
                        {
                            DominantColors = new DominantColorsAnnotation
                            {
                                Colors =
                                {
                                    new ColorInfo
                                    {
                                        Color = new gt::Color
                                        {
                                            Red = 3.070673E+17F,
                                            Green = -4.994538E+17F,
                                            Blue = 8.9135635E+17F,
                                            Alpha = -5.821188E+17F,
                                        },
                                        Score = -5.80354E+17F,
                                        PixelFraction = 1.0369602E+18F,
                                    },
                                },
                            },
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
                        CropHintsAnnotation = new CropHintsAnnotation
                        {
                            CropHints =
                            {
                                new CropHint
                                {
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
                                    Confidence = 8.101506E+17F,
                                    ImportanceFraction = -4.309868E+17F,
                                },
                            },
                        },
                        FullTextAnnotation = new TextAnnotation
                        {
                            Pages =
                            {
                                new Page
                                {
                                    Property = new TextAnnotation.Types.TextProperty
                                    {
                                        DetectedLanguages =
                                        {
                                            new TextAnnotation.Types.DetectedLanguage
                                            {
                                                LanguageCode = "language_code2f6c7160",
                                                Confidence = 8.101506E+17F,
                                            },
                                        },
                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                        {
                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                            IsPrefix = false,
                                        },
                                    },
                                    Width = -1507414294,
                                    Height = 669136308,
                                    Blocks =
                                    {
                                        new Block
                                        {
                                            Property = new TextAnnotation.Types.TextProperty
                                            {
                                                DetectedLanguages =
                                                {
                                                    new TextAnnotation.Types.DetectedLanguage
                                                    {
                                                        LanguageCode = "language_code2f6c7160",
                                                        Confidence = 8.101506E+17F,
                                                    },
                                                },
                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                {
                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                    IsPrefix = false,
                                                },
                                            },
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
                                            Paragraphs =
                                            {
                                                new Paragraph
                                                {
                                                    Property = new TextAnnotation.Types.TextProperty
                                                    {
                                                        DetectedLanguages =
                                                        {
                                                            new TextAnnotation.Types.DetectedLanguage
                                                            {
                                                                LanguageCode = "language_code2f6c7160",
                                                                Confidence = 8.101506E+17F,
                                                            },
                                                        },
                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                        {
                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                            IsPrefix = false,
                                                        },
                                                    },
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
                                                    Words =
                                                    {
                                                        new Word
                                                        {
                                                            Property = new TextAnnotation.Types.TextProperty
                                                            {
                                                                DetectedLanguages =
                                                                {
                                                                    new TextAnnotation.Types.DetectedLanguage
                                                                    {
                                                                        LanguageCode = "language_code2f6c7160",
                                                                        Confidence = 8.101506E+17F,
                                                                    },
                                                                },
                                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                {
                                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                    IsPrefix = false,
                                                                },
                                                            },
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
                                                            Symbols =
                                                            {
                                                                new Symbol
                                                                {
                                                                    Property = new TextAnnotation.Types.TextProperty
                                                                    {
                                                                        DetectedLanguages =
                                                                        {
                                                                            new TextAnnotation.Types.DetectedLanguage
                                                                            {
                                                                                LanguageCode = "language_code2f6c7160",
                                                                                Confidence = 8.101506E+17F,
                                                                            },
                                                                        },
                                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                        {
                                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                            IsPrefix = false,
                                                                        },
                                                                    },
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
                                                                    Text = "textec51b21c",
                                                                    Confidence = 8.101506E+17F,
                                                                },
                                                            },
                                                            Confidence = 8.101506E+17F,
                                                        },
                                                    },
                                                    Confidence = 8.101506E+17F,
                                                },
                                            },
                                            BlockType = Block.Types.BlockType.Picture,
                                            Confidence = 8.101506E+17F,
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                },
                            },
                            Text = "textec51b21c",
                        },
                        WebDetection = new WebDetection
                        {
                            WebEntities =
                            {
                                new WebDetection.Types.WebEntity
                                {
                                    EntityId = "entity_id1347fcdf",
                                    Score = -5.80354E+17F,
                                    Description = "description2cf9da67",
                                },
                            },
                            FullMatchingImages =
                            {
                                new WebDetection.Types.WebImage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                },
                            },
                            PartialMatchingImages =
                            {
                                new WebDetection.Types.WebImage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                },
                            },
                            PagesWithMatchingImages =
                            {
                                new WebDetection.Types.WebPage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                    PageTitle = "page_titlef3193bb7",
                                    FullMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    PartialMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                },
                            },
                            VisuallySimilarImages =
                            {
                                new WebDetection.Types.WebImage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                },
                            },
                            BestGuessLabels =
                            {
                                new WebDetection.Types.WebLabel
                                {
                                    Label = "label20ba04d3",
                                    LanguageCode = "language_code2f6c7160",
                                },
                            },
                        },
                        ProductSearchResults = new ProductSearchResults
                        {
                            IndexTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            Results =
                            {
                                new ProductSearchResults.Types.Result
                                {
                                    Product = new Product
                                    {
                                        ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                        DisplayName = "display_name137f65c2",
                                        Description = "description2cf9da67",
                                        ProductCategory = "product_category7fba5b40",
                                        ProductLabels =
                                        {
                                            new Product.Types.KeyValue
                                            {
                                                Key = "key8a0b6e3c",
                                                Value = "value60c16320",
                                            },
                                        },
                                    },
                                    Score = -5.80354E+17F,
                                    Image = "image225a8078",
                                },
                            },
                            ProductGroupedResults =
                            {
                                new ProductSearchResults.Types.GroupedResult
                                {
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
                                    Results =
                                    {
                                        new ProductSearchResults.Types.Result
                                        {
                                            Product = new Product
                                            {
                                                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                                ProductCategory = "product_category7fba5b40",
                                                ProductLabels =
                                                {
                                                    new Product.Types.KeyValue
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Value = "value60c16320",
                                                    },
                                                },
                                            },
                                            Score = -5.80354E+17F,
                                            Image = "image225a8078",
                                        },
                                    },
                                    ObjectAnnotations =
                                    {
                                        new ProductSearchResults.Types.ObjectAnnotation
                                        {
                                            Mid = "mid09473822",
                                            LanguageCode = "language_code2f6c7160",
                                            Name = "name1c9368b0",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                },
                            },
                        },
                        Context = new ImageAnnotationContext
                        {
                            Uri = "uri3db70593",
                            PageNumber = 291687312,
                        },
                        LocalizedObjectAnnotations =
                        {
                            new LocalizedObjectAnnotation
                            {
                                Mid = "mid09473822",
                                LanguageCode = "language_code2f6c7160",
                                Name = "name1c9368b0",
                                Score = -5.80354E+17F,
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
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateImages(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null);
            BatchAnnotateImagesResponse response = client.BatchAnnotateImages(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchAnnotateImagesRequestObjectAsync()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    new AnnotateImageRequest
                    {
                        Image = new Image
                        {
                            Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                            Source = new ImageSource
                            {
                                GcsImageUri = "gcs_image_urid884f666",
                                ImageUri = "image_urieba3b1bc",
                            },
                        },
                        Features =
                        {
                            new Feature
                            {
                                Type = Feature.Types.Type.CropHints,
                                MaxResults = -1488152846,
                                Model = "model635ef320",
                            },
                        },
                        ImageContext = new ImageContext
                        {
                            LatLongRect = new LatLongRect
                            {
                                MinLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                                MaxLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                            },
                            LanguageHints =
                            {
                                "language_hints03225ef4",
                            },
                            CropHintsParams = new CropHintsParams
                            {
                                AspectRatios = { 1.033126E+18F, },
                            },
                            ProductSearchParams = new ProductSearchParams
                            {
                                ProductSetAsProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                                ProductCategories =
                                {
                                    "product_categories01426367",
                                },
                                Filter = "filtere47ac9b2",
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
                            },
                            WebDetectionParams = new WebDetectionParams
                            {
                                IncludeGeoResults = true,
                            },
                            TextDetectionParams = new TextDetectionParams
                            {
                                EnableTextDetectionConfidenceScore = true,
                            },
                        },
                    },
                },
                Parent = "parent7858e4d0",
            };
            BatchAnnotateImagesResponse expectedResponse = new BatchAnnotateImagesResponse
            {
                Responses =
                {
                    new AnnotateImageResponse
                    {
                        FaceAnnotations =
                        {
                            new FaceAnnotation
                            {
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
                                FdBoundingPoly = new BoundingPoly
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
                                Landmarks =
                                {
                                    new FaceAnnotation.Types.Landmark
                                    {
                                        Type = FaceAnnotation.Types.Landmark.Types.Type.RightEyePupil,
                                        Position = new Position
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                            Z = -4.034153E+17F,
                                        },
                                    },
                                },
                                RollAngle = 5.6015E+17F,
                                PanAngle = -3.964234E+17F,
                                TiltAngle = -4.387485E+17F,
                                DetectionConfidence = -1.11668655E+18F,
                                LandmarkingConfidence = -4.6933908E+17F,
                                JoyLikelihood = Likelihood.Unknown,
                                SorrowLikelihood = Likelihood.VeryLikely,
                                AngerLikelihood = Likelihood.VeryLikely,
                                SurpriseLikelihood = Likelihood.Possible,
                                UnderExposedLikelihood = Likelihood.Likely,
                                BlurredLikelihood = Likelihood.Possible,
                                HeadwearLikelihood = Likelihood.Unknown,
                            },
                        },
                        LandmarkAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        LogoAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        LabelAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        TextAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        SafeSearchAnnotation = new SafeSearchAnnotation
                        {
                            Adult = Likelihood.Unlikely,
                            Spoof = Likelihood.Likely,
                            Medical = Likelihood.Unlikely,
                            Violence = Likelihood.Likely,
                            Racy = Likelihood.Unknown,
#pragma warning disable CS0612
                            AdultConfidence = 7.893828E+17F,
                            SpoofConfidence = 1.21577665E+17F,
                            MedicalConfidence = 5.6571437E+17F,
                            ViolenceConfidence = 3.1119182E+17F,
                            RacyConfidence = -1.14657856E+18F,
                            NsfwConfidence = 6.880875E+17F,
#pragma warning restore CS0612
                        },
                        ImagePropertiesAnnotation = new ImageProperties
                        {
                            DominantColors = new DominantColorsAnnotation
                            {
                                Colors =
                                {
                                    new ColorInfo
                                    {
                                        Color = new gt::Color
                                        {
                                            Red = 3.070673E+17F,
                                            Green = -4.994538E+17F,
                                            Blue = 8.9135635E+17F,
                                            Alpha = -5.821188E+17F,
                                        },
                                        Score = -5.80354E+17F,
                                        PixelFraction = 1.0369602E+18F,
                                    },
                                },
                            },
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
                        CropHintsAnnotation = new CropHintsAnnotation
                        {
                            CropHints =
                            {
                                new CropHint
                                {
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
                                    Confidence = 8.101506E+17F,
                                    ImportanceFraction = -4.309868E+17F,
                                },
                            },
                        },
                        FullTextAnnotation = new TextAnnotation
                        {
                            Pages =
                            {
                                new Page
                                {
                                    Property = new TextAnnotation.Types.TextProperty
                                    {
                                        DetectedLanguages =
                                        {
                                            new TextAnnotation.Types.DetectedLanguage
                                            {
                                                LanguageCode = "language_code2f6c7160",
                                                Confidence = 8.101506E+17F,
                                            },
                                        },
                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                        {
                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                            IsPrefix = false,
                                        },
                                    },
                                    Width = -1507414294,
                                    Height = 669136308,
                                    Blocks =
                                    {
                                        new Block
                                        {
                                            Property = new TextAnnotation.Types.TextProperty
                                            {
                                                DetectedLanguages =
                                                {
                                                    new TextAnnotation.Types.DetectedLanguage
                                                    {
                                                        LanguageCode = "language_code2f6c7160",
                                                        Confidence = 8.101506E+17F,
                                                    },
                                                },
                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                {
                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                    IsPrefix = false,
                                                },
                                            },
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
                                            Paragraphs =
                                            {
                                                new Paragraph
                                                {
                                                    Property = new TextAnnotation.Types.TextProperty
                                                    {
                                                        DetectedLanguages =
                                                        {
                                                            new TextAnnotation.Types.DetectedLanguage
                                                            {
                                                                LanguageCode = "language_code2f6c7160",
                                                                Confidence = 8.101506E+17F,
                                                            },
                                                        },
                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                        {
                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                            IsPrefix = false,
                                                        },
                                                    },
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
                                                    Words =
                                                    {
                                                        new Word
                                                        {
                                                            Property = new TextAnnotation.Types.TextProperty
                                                            {
                                                                DetectedLanguages =
                                                                {
                                                                    new TextAnnotation.Types.DetectedLanguage
                                                                    {
                                                                        LanguageCode = "language_code2f6c7160",
                                                                        Confidence = 8.101506E+17F,
                                                                    },
                                                                },
                                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                {
                                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                    IsPrefix = false,
                                                                },
                                                            },
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
                                                            Symbols =
                                                            {
                                                                new Symbol
                                                                {
                                                                    Property = new TextAnnotation.Types.TextProperty
                                                                    {
                                                                        DetectedLanguages =
                                                                        {
                                                                            new TextAnnotation.Types.DetectedLanguage
                                                                            {
                                                                                LanguageCode = "language_code2f6c7160",
                                                                                Confidence = 8.101506E+17F,
                                                                            },
                                                                        },
                                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                        {
                                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                            IsPrefix = false,
                                                                        },
                                                                    },
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
                                                                    Text = "textec51b21c",
                                                                    Confidence = 8.101506E+17F,
                                                                },
                                                            },
                                                            Confidence = 8.101506E+17F,
                                                        },
                                                    },
                                                    Confidence = 8.101506E+17F,
                                                },
                                            },
                                            BlockType = Block.Types.BlockType.Picture,
                                            Confidence = 8.101506E+17F,
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                },
                            },
                            Text = "textec51b21c",
                        },
                        WebDetection = new WebDetection
                        {
                            WebEntities =
                            {
                                new WebDetection.Types.WebEntity
                                {
                                    EntityId = "entity_id1347fcdf",
                                    Score = -5.80354E+17F,
                                    Description = "description2cf9da67",
                                },
                            },
                            FullMatchingImages =
                            {
                                new WebDetection.Types.WebImage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                },
                            },
                            PartialMatchingImages =
                            {
                                new WebDetection.Types.WebImage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                },
                            },
                            PagesWithMatchingImages =
                            {
                                new WebDetection.Types.WebPage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                    PageTitle = "page_titlef3193bb7",
                                    FullMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    PartialMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                },
                            },
                            VisuallySimilarImages =
                            {
                                new WebDetection.Types.WebImage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                },
                            },
                            BestGuessLabels =
                            {
                                new WebDetection.Types.WebLabel
                                {
                                    Label = "label20ba04d3",
                                    LanguageCode = "language_code2f6c7160",
                                },
                            },
                        },
                        ProductSearchResults = new ProductSearchResults
                        {
                            IndexTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            Results =
                            {
                                new ProductSearchResults.Types.Result
                                {
                                    Product = new Product
                                    {
                                        ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                        DisplayName = "display_name137f65c2",
                                        Description = "description2cf9da67",
                                        ProductCategory = "product_category7fba5b40",
                                        ProductLabels =
                                        {
                                            new Product.Types.KeyValue
                                            {
                                                Key = "key8a0b6e3c",
                                                Value = "value60c16320",
                                            },
                                        },
                                    },
                                    Score = -5.80354E+17F,
                                    Image = "image225a8078",
                                },
                            },
                            ProductGroupedResults =
                            {
                                new ProductSearchResults.Types.GroupedResult
                                {
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
                                    Results =
                                    {
                                        new ProductSearchResults.Types.Result
                                        {
                                            Product = new Product
                                            {
                                                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                                ProductCategory = "product_category7fba5b40",
                                                ProductLabels =
                                                {
                                                    new Product.Types.KeyValue
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Value = "value60c16320",
                                                    },
                                                },
                                            },
                                            Score = -5.80354E+17F,
                                            Image = "image225a8078",
                                        },
                                    },
                                    ObjectAnnotations =
                                    {
                                        new ProductSearchResults.Types.ObjectAnnotation
                                        {
                                            Mid = "mid09473822",
                                            LanguageCode = "language_code2f6c7160",
                                            Name = "name1c9368b0",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                },
                            },
                        },
                        Context = new ImageAnnotationContext
                        {
                            Uri = "uri3db70593",
                            PageNumber = 291687312,
                        },
                        LocalizedObjectAnnotations =
                        {
                            new LocalizedObjectAnnotation
                            {
                                Mid = "mid09473822",
                                LanguageCode = "language_code2f6c7160",
                                Name = "name1c9368b0",
                                Score = -5.80354E+17F,
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
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateImagesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchAnnotateImagesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null);
            BatchAnnotateImagesResponse responseCallSettings = await client.BatchAnnotateImagesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchAnnotateImagesResponse responseCancellationToken = await client.BatchAnnotateImagesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchAnnotateImages()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    new AnnotateImageRequest
                    {
                        Image = new Image
                        {
                            Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                            Source = new ImageSource
                            {
                                GcsImageUri = "gcs_image_urid884f666",
                                ImageUri = "image_urieba3b1bc",
                            },
                        },
                        Features =
                        {
                            new Feature
                            {
                                Type = Feature.Types.Type.CropHints,
                                MaxResults = -1488152846,
                                Model = "model635ef320",
                            },
                        },
                        ImageContext = new ImageContext
                        {
                            LatLongRect = new LatLongRect
                            {
                                MinLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                                MaxLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                            },
                            LanguageHints =
                            {
                                "language_hints03225ef4",
                            },
                            CropHintsParams = new CropHintsParams
                            {
                                AspectRatios = { 1.033126E+18F, },
                            },
                            ProductSearchParams = new ProductSearchParams
                            {
                                ProductSetAsProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                                ProductCategories =
                                {
                                    "product_categories01426367",
                                },
                                Filter = "filtere47ac9b2",
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
                            },
                            WebDetectionParams = new WebDetectionParams
                            {
                                IncludeGeoResults = true,
                            },
                            TextDetectionParams = new TextDetectionParams
                            {
                                EnableTextDetectionConfidenceScore = true,
                            },
                        },
                    },
                },
            };
            BatchAnnotateImagesResponse expectedResponse = new BatchAnnotateImagesResponse
            {
                Responses =
                {
                    new AnnotateImageResponse
                    {
                        FaceAnnotations =
                        {
                            new FaceAnnotation
                            {
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
                                FdBoundingPoly = new BoundingPoly
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
                                Landmarks =
                                {
                                    new FaceAnnotation.Types.Landmark
                                    {
                                        Type = FaceAnnotation.Types.Landmark.Types.Type.RightEyePupil,
                                        Position = new Position
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                            Z = -4.034153E+17F,
                                        },
                                    },
                                },
                                RollAngle = 5.6015E+17F,
                                PanAngle = -3.964234E+17F,
                                TiltAngle = -4.387485E+17F,
                                DetectionConfidence = -1.11668655E+18F,
                                LandmarkingConfidence = -4.6933908E+17F,
                                JoyLikelihood = Likelihood.Unknown,
                                SorrowLikelihood = Likelihood.VeryLikely,
                                AngerLikelihood = Likelihood.VeryLikely,
                                SurpriseLikelihood = Likelihood.Possible,
                                UnderExposedLikelihood = Likelihood.Likely,
                                BlurredLikelihood = Likelihood.Possible,
                                HeadwearLikelihood = Likelihood.Unknown,
                            },
                        },
                        LandmarkAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        LogoAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        LabelAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        TextAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        SafeSearchAnnotation = new SafeSearchAnnotation
                        {
                            Adult = Likelihood.Unlikely,
                            Spoof = Likelihood.Likely,
                            Medical = Likelihood.Unlikely,
                            Violence = Likelihood.Likely,
                            Racy = Likelihood.Unknown,
#pragma warning disable CS0612
                            AdultConfidence = 7.893828E+17F,
                            SpoofConfidence = 1.21577665E+17F,
                            MedicalConfidence = 5.6571437E+17F,
                            ViolenceConfidence = 3.1119182E+17F,
                            RacyConfidence = -1.14657856E+18F,
                            NsfwConfidence = 6.880875E+17F,
#pragma warning restore CS0612
                        },
                        ImagePropertiesAnnotation = new ImageProperties
                        {
                            DominantColors = new DominantColorsAnnotation
                            {
                                Colors =
                                {
                                    new ColorInfo
                                    {
                                        Color = new gt::Color
                                        {
                                            Red = 3.070673E+17F,
                                            Green = -4.994538E+17F,
                                            Blue = 8.9135635E+17F,
                                            Alpha = -5.821188E+17F,
                                        },
                                        Score = -5.80354E+17F,
                                        PixelFraction = 1.0369602E+18F,
                                    },
                                },
                            },
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
                        CropHintsAnnotation = new CropHintsAnnotation
                        {
                            CropHints =
                            {
                                new CropHint
                                {
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
                                    Confidence = 8.101506E+17F,
                                    ImportanceFraction = -4.309868E+17F,
                                },
                            },
                        },
                        FullTextAnnotation = new TextAnnotation
                        {
                            Pages =
                            {
                                new Page
                                {
                                    Property = new TextAnnotation.Types.TextProperty
                                    {
                                        DetectedLanguages =
                                        {
                                            new TextAnnotation.Types.DetectedLanguage
                                            {
                                                LanguageCode = "language_code2f6c7160",
                                                Confidence = 8.101506E+17F,
                                            },
                                        },
                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                        {
                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                            IsPrefix = false,
                                        },
                                    },
                                    Width = -1507414294,
                                    Height = 669136308,
                                    Blocks =
                                    {
                                        new Block
                                        {
                                            Property = new TextAnnotation.Types.TextProperty
                                            {
                                                DetectedLanguages =
                                                {
                                                    new TextAnnotation.Types.DetectedLanguage
                                                    {
                                                        LanguageCode = "language_code2f6c7160",
                                                        Confidence = 8.101506E+17F,
                                                    },
                                                },
                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                {
                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                    IsPrefix = false,
                                                },
                                            },
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
                                            Paragraphs =
                                            {
                                                new Paragraph
                                                {
                                                    Property = new TextAnnotation.Types.TextProperty
                                                    {
                                                        DetectedLanguages =
                                                        {
                                                            new TextAnnotation.Types.DetectedLanguage
                                                            {
                                                                LanguageCode = "language_code2f6c7160",
                                                                Confidence = 8.101506E+17F,
                                                            },
                                                        },
                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                        {
                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                            IsPrefix = false,
                                                        },
                                                    },
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
                                                    Words =
                                                    {
                                                        new Word
                                                        {
                                                            Property = new TextAnnotation.Types.TextProperty
                                                            {
                                                                DetectedLanguages =
                                                                {
                                                                    new TextAnnotation.Types.DetectedLanguage
                                                                    {
                                                                        LanguageCode = "language_code2f6c7160",
                                                                        Confidence = 8.101506E+17F,
                                                                    },
                                                                },
                                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                {
                                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                    IsPrefix = false,
                                                                },
                                                            },
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
                                                            Symbols =
                                                            {
                                                                new Symbol
                                                                {
                                                                    Property = new TextAnnotation.Types.TextProperty
                                                                    {
                                                                        DetectedLanguages =
                                                                        {
                                                                            new TextAnnotation.Types.DetectedLanguage
                                                                            {
                                                                                LanguageCode = "language_code2f6c7160",
                                                                                Confidence = 8.101506E+17F,
                                                                            },
                                                                        },
                                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                        {
                                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                            IsPrefix = false,
                                                                        },
                                                                    },
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
                                                                    Text = "textec51b21c",
                                                                    Confidence = 8.101506E+17F,
                                                                },
                                                            },
                                                            Confidence = 8.101506E+17F,
                                                        },
                                                    },
                                                    Confidence = 8.101506E+17F,
                                                },
                                            },
                                            BlockType = Block.Types.BlockType.Picture,
                                            Confidence = 8.101506E+17F,
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                },
                            },
                            Text = "textec51b21c",
                        },
                        WebDetection = new WebDetection
                        {
                            WebEntities =
                            {
                                new WebDetection.Types.WebEntity
                                {
                                    EntityId = "entity_id1347fcdf",
                                    Score = -5.80354E+17F,
                                    Description = "description2cf9da67",
                                },
                            },
                            FullMatchingImages =
                            {
                                new WebDetection.Types.WebImage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                },
                            },
                            PartialMatchingImages =
                            {
                                new WebDetection.Types.WebImage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                },
                            },
                            PagesWithMatchingImages =
                            {
                                new WebDetection.Types.WebPage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                    PageTitle = "page_titlef3193bb7",
                                    FullMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    PartialMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                },
                            },
                            VisuallySimilarImages =
                            {
                                new WebDetection.Types.WebImage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                },
                            },
                            BestGuessLabels =
                            {
                                new WebDetection.Types.WebLabel
                                {
                                    Label = "label20ba04d3",
                                    LanguageCode = "language_code2f6c7160",
                                },
                            },
                        },
                        ProductSearchResults = new ProductSearchResults
                        {
                            IndexTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            Results =
                            {
                                new ProductSearchResults.Types.Result
                                {
                                    Product = new Product
                                    {
                                        ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                        DisplayName = "display_name137f65c2",
                                        Description = "description2cf9da67",
                                        ProductCategory = "product_category7fba5b40",
                                        ProductLabels =
                                        {
                                            new Product.Types.KeyValue
                                            {
                                                Key = "key8a0b6e3c",
                                                Value = "value60c16320",
                                            },
                                        },
                                    },
                                    Score = -5.80354E+17F,
                                    Image = "image225a8078",
                                },
                            },
                            ProductGroupedResults =
                            {
                                new ProductSearchResults.Types.GroupedResult
                                {
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
                                    Results =
                                    {
                                        new ProductSearchResults.Types.Result
                                        {
                                            Product = new Product
                                            {
                                                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                                ProductCategory = "product_category7fba5b40",
                                                ProductLabels =
                                                {
                                                    new Product.Types.KeyValue
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Value = "value60c16320",
                                                    },
                                                },
                                            },
                                            Score = -5.80354E+17F,
                                            Image = "image225a8078",
                                        },
                                    },
                                    ObjectAnnotations =
                                    {
                                        new ProductSearchResults.Types.ObjectAnnotation
                                        {
                                            Mid = "mid09473822",
                                            LanguageCode = "language_code2f6c7160",
                                            Name = "name1c9368b0",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                },
                            },
                        },
                        Context = new ImageAnnotationContext
                        {
                            Uri = "uri3db70593",
                            PageNumber = 291687312,
                        },
                        LocalizedObjectAnnotations =
                        {
                            new LocalizedObjectAnnotation
                            {
                                Mid = "mid09473822",
                                LanguageCode = "language_code2f6c7160",
                                Name = "name1c9368b0",
                                Score = -5.80354E+17F,
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
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateImages(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null);
            BatchAnnotateImagesResponse response = client.BatchAnnotateImages(request.Requests);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchAnnotateImagesAsync()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateImagesRequest request = new BatchAnnotateImagesRequest
            {
                Requests =
                {
                    new AnnotateImageRequest
                    {
                        Image = new Image
                        {
                            Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                            Source = new ImageSource
                            {
                                GcsImageUri = "gcs_image_urid884f666",
                                ImageUri = "image_urieba3b1bc",
                            },
                        },
                        Features =
                        {
                            new Feature
                            {
                                Type = Feature.Types.Type.CropHints,
                                MaxResults = -1488152846,
                                Model = "model635ef320",
                            },
                        },
                        ImageContext = new ImageContext
                        {
                            LatLongRect = new LatLongRect
                            {
                                MinLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                                MaxLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                            },
                            LanguageHints =
                            {
                                "language_hints03225ef4",
                            },
                            CropHintsParams = new CropHintsParams
                            {
                                AspectRatios = { 1.033126E+18F, },
                            },
                            ProductSearchParams = new ProductSearchParams
                            {
                                ProductSetAsProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                                ProductCategories =
                                {
                                    "product_categories01426367",
                                },
                                Filter = "filtere47ac9b2",
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
                            },
                            WebDetectionParams = new WebDetectionParams
                            {
                                IncludeGeoResults = true,
                            },
                            TextDetectionParams = new TextDetectionParams
                            {
                                EnableTextDetectionConfidenceScore = true,
                            },
                        },
                    },
                },
            };
            BatchAnnotateImagesResponse expectedResponse = new BatchAnnotateImagesResponse
            {
                Responses =
                {
                    new AnnotateImageResponse
                    {
                        FaceAnnotations =
                        {
                            new FaceAnnotation
                            {
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
                                FdBoundingPoly = new BoundingPoly
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
                                Landmarks =
                                {
                                    new FaceAnnotation.Types.Landmark
                                    {
                                        Type = FaceAnnotation.Types.Landmark.Types.Type.RightEyePupil,
                                        Position = new Position
                                        {
                                            X = 4.7289724E+17F,
                                            Y = 1.2858411E+17F,
                                            Z = -4.034153E+17F,
                                        },
                                    },
                                },
                                RollAngle = 5.6015E+17F,
                                PanAngle = -3.964234E+17F,
                                TiltAngle = -4.387485E+17F,
                                DetectionConfidence = -1.11668655E+18F,
                                LandmarkingConfidence = -4.6933908E+17F,
                                JoyLikelihood = Likelihood.Unknown,
                                SorrowLikelihood = Likelihood.VeryLikely,
                                AngerLikelihood = Likelihood.VeryLikely,
                                SurpriseLikelihood = Likelihood.Possible,
                                UnderExposedLikelihood = Likelihood.Likely,
                                BlurredLikelihood = Likelihood.Possible,
                                HeadwearLikelihood = Likelihood.Unknown,
                            },
                        },
                        LandmarkAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        LogoAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        LabelAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        TextAnnotations =
                        {
                            new EntityAnnotation
                            {
                                Mid = "mid09473822",
                                Locale = "locale9e6d21fb",
                                Description = "description2cf9da67",
                                Score = -5.80354E+17F,
#pragma warning disable CS0612
                                Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                Topicality = 1.8519913E+17F,
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
                                Locations =
                                {
                                    new LocationInfo
                                    {
                                        LatLng = new gt::LatLng
                                        {
                                            Latitude = 8.158369671878062E+17,
                                            Longitude = 8.869183012043108E+17,
                                        },
                                    },
                                },
                                Properties =
                                {
                                    new Property
                                    {
                                        Name = "name1c9368b0",
                                        Value = "value60c16320",
                                        Uint64Value = 13460318030236737202UL,
                                    },
                                },
                            },
                        },
                        SafeSearchAnnotation = new SafeSearchAnnotation
                        {
                            Adult = Likelihood.Unlikely,
                            Spoof = Likelihood.Likely,
                            Medical = Likelihood.Unlikely,
                            Violence = Likelihood.Likely,
                            Racy = Likelihood.Unknown,
#pragma warning disable CS0612
                            AdultConfidence = 7.893828E+17F,
                            SpoofConfidence = 1.21577665E+17F,
                            MedicalConfidence = 5.6571437E+17F,
                            ViolenceConfidence = 3.1119182E+17F,
                            RacyConfidence = -1.14657856E+18F,
                            NsfwConfidence = 6.880875E+17F,
#pragma warning restore CS0612
                        },
                        ImagePropertiesAnnotation = new ImageProperties
                        {
                            DominantColors = new DominantColorsAnnotation
                            {
                                Colors =
                                {
                                    new ColorInfo
                                    {
                                        Color = new gt::Color
                                        {
                                            Red = 3.070673E+17F,
                                            Green = -4.994538E+17F,
                                            Blue = 8.9135635E+17F,
                                            Alpha = -5.821188E+17F,
                                        },
                                        Score = -5.80354E+17F,
                                        PixelFraction = 1.0369602E+18F,
                                    },
                                },
                            },
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
                        CropHintsAnnotation = new CropHintsAnnotation
                        {
                            CropHints =
                            {
                                new CropHint
                                {
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
                                    Confidence = 8.101506E+17F,
                                    ImportanceFraction = -4.309868E+17F,
                                },
                            },
                        },
                        FullTextAnnotation = new TextAnnotation
                        {
                            Pages =
                            {
                                new Page
                                {
                                    Property = new TextAnnotation.Types.TextProperty
                                    {
                                        DetectedLanguages =
                                        {
                                            new TextAnnotation.Types.DetectedLanguage
                                            {
                                                LanguageCode = "language_code2f6c7160",
                                                Confidence = 8.101506E+17F,
                                            },
                                        },
                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                        {
                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                            IsPrefix = false,
                                        },
                                    },
                                    Width = -1507414294,
                                    Height = 669136308,
                                    Blocks =
                                    {
                                        new Block
                                        {
                                            Property = new TextAnnotation.Types.TextProperty
                                            {
                                                DetectedLanguages =
                                                {
                                                    new TextAnnotation.Types.DetectedLanguage
                                                    {
                                                        LanguageCode = "language_code2f6c7160",
                                                        Confidence = 8.101506E+17F,
                                                    },
                                                },
                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                {
                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                    IsPrefix = false,
                                                },
                                            },
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
                                            Paragraphs =
                                            {
                                                new Paragraph
                                                {
                                                    Property = new TextAnnotation.Types.TextProperty
                                                    {
                                                        DetectedLanguages =
                                                        {
                                                            new TextAnnotation.Types.DetectedLanguage
                                                            {
                                                                LanguageCode = "language_code2f6c7160",
                                                                Confidence = 8.101506E+17F,
                                                            },
                                                        },
                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                        {
                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                            IsPrefix = false,
                                                        },
                                                    },
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
                                                    Words =
                                                    {
                                                        new Word
                                                        {
                                                            Property = new TextAnnotation.Types.TextProperty
                                                            {
                                                                DetectedLanguages =
                                                                {
                                                                    new TextAnnotation.Types.DetectedLanguage
                                                                    {
                                                                        LanguageCode = "language_code2f6c7160",
                                                                        Confidence = 8.101506E+17F,
                                                                    },
                                                                },
                                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                {
                                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                    IsPrefix = false,
                                                                },
                                                            },
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
                                                            Symbols =
                                                            {
                                                                new Symbol
                                                                {
                                                                    Property = new TextAnnotation.Types.TextProperty
                                                                    {
                                                                        DetectedLanguages =
                                                                        {
                                                                            new TextAnnotation.Types.DetectedLanguage
                                                                            {
                                                                                LanguageCode = "language_code2f6c7160",
                                                                                Confidence = 8.101506E+17F,
                                                                            },
                                                                        },
                                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                        {
                                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                            IsPrefix = false,
                                                                        },
                                                                    },
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
                                                                    Text = "textec51b21c",
                                                                    Confidence = 8.101506E+17F,
                                                                },
                                                            },
                                                            Confidence = 8.101506E+17F,
                                                        },
                                                    },
                                                    Confidence = 8.101506E+17F,
                                                },
                                            },
                                            BlockType = Block.Types.BlockType.Picture,
                                            Confidence = 8.101506E+17F,
                                        },
                                    },
                                    Confidence = 8.101506E+17F,
                                },
                            },
                            Text = "textec51b21c",
                        },
                        WebDetection = new WebDetection
                        {
                            WebEntities =
                            {
                                new WebDetection.Types.WebEntity
                                {
                                    EntityId = "entity_id1347fcdf",
                                    Score = -5.80354E+17F,
                                    Description = "description2cf9da67",
                                },
                            },
                            FullMatchingImages =
                            {
                                new WebDetection.Types.WebImage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                },
                            },
                            PartialMatchingImages =
                            {
                                new WebDetection.Types.WebImage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                },
                            },
                            PagesWithMatchingImages =
                            {
                                new WebDetection.Types.WebPage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                    PageTitle = "page_titlef3193bb7",
                                    FullMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    PartialMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                },
                            },
                            VisuallySimilarImages =
                            {
                                new WebDetection.Types.WebImage
                                {
                                    Url = "url424e2d57",
                                    Score = -5.80354E+17F,
                                },
                            },
                            BestGuessLabels =
                            {
                                new WebDetection.Types.WebLabel
                                {
                                    Label = "label20ba04d3",
                                    LanguageCode = "language_code2f6c7160",
                                },
                            },
                        },
                        ProductSearchResults = new ProductSearchResults
                        {
                            IndexTime = new wkt::Timestamp
                            {
                                Seconds = -2106654494186127752L,
                                Nanos = 985689544,
                            },
                            Results =
                            {
                                new ProductSearchResults.Types.Result
                                {
                                    Product = new Product
                                    {
                                        ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                        DisplayName = "display_name137f65c2",
                                        Description = "description2cf9da67",
                                        ProductCategory = "product_category7fba5b40",
                                        ProductLabels =
                                        {
                                            new Product.Types.KeyValue
                                            {
                                                Key = "key8a0b6e3c",
                                                Value = "value60c16320",
                                            },
                                        },
                                    },
                                    Score = -5.80354E+17F,
                                    Image = "image225a8078",
                                },
                            },
                            ProductGroupedResults =
                            {
                                new ProductSearchResults.Types.GroupedResult
                                {
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
                                    Results =
                                    {
                                        new ProductSearchResults.Types.Result
                                        {
                                            Product = new Product
                                            {
                                                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                                ProductCategory = "product_category7fba5b40",
                                                ProductLabels =
                                                {
                                                    new Product.Types.KeyValue
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Value = "value60c16320",
                                                    },
                                                },
                                            },
                                            Score = -5.80354E+17F,
                                            Image = "image225a8078",
                                        },
                                    },
                                    ObjectAnnotations =
                                    {
                                        new ProductSearchResults.Types.ObjectAnnotation
                                        {
                                            Mid = "mid09473822",
                                            LanguageCode = "language_code2f6c7160",
                                            Name = "name1c9368b0",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                },
                            },
                        },
                        Context = new ImageAnnotationContext
                        {
                            Uri = "uri3db70593",
                            PageNumber = 291687312,
                        },
                        LocalizedObjectAnnotations =
                        {
                            new LocalizedObjectAnnotation
                            {
                                Mid = "mid09473822",
                                LanguageCode = "language_code2f6c7160",
                                Name = "name1c9368b0",
                                Score = -5.80354E+17F,
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
                            },
                        },
                    },
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateImagesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchAnnotateImagesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null);
            BatchAnnotateImagesResponse responseCallSettings = await client.BatchAnnotateImagesAsync(request.Requests, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchAnnotateImagesResponse responseCancellationToken = await client.BatchAnnotateImagesAsync(request.Requests, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchAnnotateFilesRequestObject()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateFilesRequest request = new BatchAnnotateFilesRequest
            {
                Requests =
                {
                    new AnnotateFileRequest
                    {
                        InputConfig = new InputConfig
                        {
                            GcsSource = new GcsSource { Uri = "uri3db70593", },
                            MimeType = "mime_type606a0ffc",
                            Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                        },
                        Features =
                        {
                            new Feature
                            {
                                Type = Feature.Types.Type.CropHints,
                                MaxResults = -1488152846,
                                Model = "model635ef320",
                            },
                        },
                        ImageContext = new ImageContext
                        {
                            LatLongRect = new LatLongRect
                            {
                                MinLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                                MaxLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                            },
                            LanguageHints =
                            {
                                "language_hints03225ef4",
                            },
                            CropHintsParams = new CropHintsParams
                            {
                                AspectRatios = { 1.033126E+18F, },
                            },
                            ProductSearchParams = new ProductSearchParams
                            {
                                ProductSetAsProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                                ProductCategories =
                                {
                                    "product_categories01426367",
                                },
                                Filter = "filtere47ac9b2",
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
                            },
                            WebDetectionParams = new WebDetectionParams
                            {
                                IncludeGeoResults = true,
                            },
                            TextDetectionParams = new TextDetectionParams
                            {
                                EnableTextDetectionConfidenceScore = true,
                            },
                        },
                        Pages = { 757773235, },
                    },
                },
                Parent = "parent7858e4d0",
            };
            BatchAnnotateFilesResponse expectedResponse = new BatchAnnotateFilesResponse
            {
                Responses =
                {
                    new AnnotateFileResponse
                    {
                        InputConfig = new InputConfig
                        {
                            GcsSource = new GcsSource { Uri = "uri3db70593", },
                            MimeType = "mime_type606a0ffc",
                            Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                        },
                        Responses =
                        {
                            new AnnotateImageResponse
                            {
                                FaceAnnotations =
                                {
                                    new FaceAnnotation
                                    {
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
                                        FdBoundingPoly = new BoundingPoly
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
                                        Landmarks =
                                        {
                                            new FaceAnnotation.Types.Landmark
                                            {
                                                Type = FaceAnnotation.Types.Landmark.Types.Type.RightEyePupil,
                                                Position = new Position
                                                {
                                                    X = 4.7289724E+17F,
                                                    Y = 1.2858411E+17F,
                                                    Z = -4.034153E+17F,
                                                },
                                            },
                                        },
                                        RollAngle = 5.6015E+17F,
                                        PanAngle = -3.964234E+17F,
                                        TiltAngle = -4.387485E+17F,
                                        DetectionConfidence = -1.11668655E+18F,
                                        LandmarkingConfidence = -4.6933908E+17F,
                                        JoyLikelihood = Likelihood.Unknown,
                                        SorrowLikelihood = Likelihood.VeryLikely,
                                        AngerLikelihood = Likelihood.VeryLikely,
                                        SurpriseLikelihood = Likelihood.Possible,
                                        UnderExposedLikelihood = Likelihood.Likely,
                                        BlurredLikelihood = Likelihood.Possible,
                                        HeadwearLikelihood = Likelihood.Unknown,
                                    },
                                },
                                LandmarkAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                LogoAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                LabelAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                TextAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                SafeSearchAnnotation = new SafeSearchAnnotation
                                {
                                    Adult = Likelihood.Unlikely,
                                    Spoof = Likelihood.Likely,
                                    Medical = Likelihood.Unlikely,
                                    Violence = Likelihood.Likely,
                                    Racy = Likelihood.Unknown,
#pragma warning disable CS0612
                                    AdultConfidence = 7.893828E+17F,
                                    SpoofConfidence = 1.21577665E+17F,
                                    MedicalConfidence = 5.6571437E+17F,
                                    ViolenceConfidence = 3.1119182E+17F,
                                    RacyConfidence = -1.14657856E+18F,
                                    NsfwConfidence = 6.880875E+17F,
#pragma warning restore CS0612
                                },
                                ImagePropertiesAnnotation = new ImageProperties
                                {
                                    DominantColors = new DominantColorsAnnotation
                                    {
                                        Colors =
                                        {
                                            new ColorInfo
                                            {
                                                Color = new gt::Color
                                                {
                                                    Red = 3.070673E+17F,
                                                    Green = -4.994538E+17F,
                                                    Blue = 8.9135635E+17F,
                                                    Alpha = -5.821188E+17F,
                                                },
                                                Score = -5.80354E+17F,
                                                PixelFraction = 1.0369602E+18F,
                                            },
                                        },
                                    },
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
                                CropHintsAnnotation = new CropHintsAnnotation
                                {
                                    CropHints =
                                    {
                                        new CropHint
                                        {
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
                                            Confidence = 8.101506E+17F,
                                            ImportanceFraction = -4.309868E+17F,
                                        },
                                    },
                                },
                                FullTextAnnotation = new TextAnnotation
                                {
                                    Pages =
                                    {
                                        new Page
                                        {
                                            Property = new TextAnnotation.Types.TextProperty
                                            {
                                                DetectedLanguages =
                                                {
                                                    new TextAnnotation.Types.DetectedLanguage
                                                    {
                                                        LanguageCode = "language_code2f6c7160",
                                                        Confidence = 8.101506E+17F,
                                                    },
                                                },
                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                {
                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                    IsPrefix = false,
                                                },
                                            },
                                            Width = -1507414294,
                                            Height = 669136308,
                                            Blocks =
                                            {
                                                new Block
                                                {
                                                    Property = new TextAnnotation.Types.TextProperty
                                                    {
                                                        DetectedLanguages =
                                                        {
                                                            new TextAnnotation.Types.DetectedLanguage
                                                            {
                                                                LanguageCode = "language_code2f6c7160",
                                                                Confidence = 8.101506E+17F,
                                                            },
                                                        },
                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                        {
                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                            IsPrefix = false,
                                                        },
                                                    },
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
                                                    Paragraphs =
                                                    {
                                                        new Paragraph
                                                        {
                                                            Property = new TextAnnotation.Types.TextProperty
                                                            {
                                                                DetectedLanguages =
                                                                {
                                                                    new TextAnnotation.Types.DetectedLanguage
                                                                    {
                                                                        LanguageCode = "language_code2f6c7160",
                                                                        Confidence = 8.101506E+17F,
                                                                    },
                                                                },
                                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                {
                                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                    IsPrefix = false,
                                                                },
                                                            },
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
                                                            Words =
                                                            {
                                                                new Word
                                                                {
                                                                    Property = new TextAnnotation.Types.TextProperty
                                                                    {
                                                                        DetectedLanguages =
                                                                        {
                                                                            new TextAnnotation.Types.DetectedLanguage
                                                                            {
                                                                                LanguageCode = "language_code2f6c7160",
                                                                                Confidence = 8.101506E+17F,
                                                                            },
                                                                        },
                                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                        {
                                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                            IsPrefix = false,
                                                                        },
                                                                    },
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
                                                                    Symbols =
                                                                    {
                                                                        new Symbol
                                                                        {
                                                                            Property = new TextAnnotation.Types.TextProperty
                                                                            {
                                                                                DetectedLanguages =
                                                                                {
                                                                                    new TextAnnotation.Types.DetectedLanguage
                                                                                    {
                                                                                        LanguageCode = "language_code2f6c7160",
                                                                                        Confidence = 8.101506E+17F,
                                                                                    },
                                                                                },
                                                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                                {
                                                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                                    IsPrefix = false,
                                                                                },
                                                                            },
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
                                                                            Text = "textec51b21c",
                                                                            Confidence = 8.101506E+17F,
                                                                        },
                                                                    },
                                                                    Confidence = 8.101506E+17F,
                                                                },
                                                            },
                                                            Confidence = 8.101506E+17F,
                                                        },
                                                    },
                                                    BlockType = Block.Types.BlockType.Picture,
                                                    Confidence = 8.101506E+17F,
                                                },
                                            },
                                            Confidence = 8.101506E+17F,
                                        },
                                    },
                                    Text = "textec51b21c",
                                },
                                WebDetection = new WebDetection
                                {
                                    WebEntities =
                                    {
                                        new WebDetection.Types.WebEntity
                                        {
                                            EntityId = "entity_id1347fcdf",
                                            Score = -5.80354E+17F,
                                            Description = "description2cf9da67",
                                        },
                                    },
                                    FullMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    PartialMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    PagesWithMatchingImages =
                                    {
                                        new WebDetection.Types.WebPage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                            PageTitle = "page_titlef3193bb7",
                                            FullMatchingImages =
                                            {
                                                new WebDetection.Types.WebImage
                                                {
                                                    Url = "url424e2d57",
                                                    Score = -5.80354E+17F,
                                                },
                                            },
                                            PartialMatchingImages =
                                            {
                                                new WebDetection.Types.WebImage
                                                {
                                                    Url = "url424e2d57",
                                                    Score = -5.80354E+17F,
                                                },
                                            },
                                        },
                                    },
                                    VisuallySimilarImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    BestGuessLabels =
                                    {
                                        new WebDetection.Types.WebLabel
                                        {
                                            Label = "label20ba04d3",
                                            LanguageCode = "language_code2f6c7160",
                                        },
                                    },
                                },
                                ProductSearchResults = new ProductSearchResults
                                {
                                    IndexTime = new wkt::Timestamp
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    Results =
                                    {
                                        new ProductSearchResults.Types.Result
                                        {
                                            Product = new Product
                                            {
                                                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                                ProductCategory = "product_category7fba5b40",
                                                ProductLabels =
                                                {
                                                    new Product.Types.KeyValue
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Value = "value60c16320",
                                                    },
                                                },
                                            },
                                            Score = -5.80354E+17F,
                                            Image = "image225a8078",
                                        },
                                    },
                                    ProductGroupedResults =
                                    {
                                        new ProductSearchResults.Types.GroupedResult
                                        {
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
                                            Results =
                                            {
                                                new ProductSearchResults.Types.Result
                                                {
                                                    Product = new Product
                                                    {
                                                        ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                                        DisplayName = "display_name137f65c2",
                                                        Description = "description2cf9da67",
                                                        ProductCategory = "product_category7fba5b40",
                                                        ProductLabels =
                                                        {
                                                            new Product.Types.KeyValue
                                                            {
                                                                Key = "key8a0b6e3c",
                                                                Value = "value60c16320",
                                                            },
                                                        },
                                                    },
                                                    Score = -5.80354E+17F,
                                                    Image = "image225a8078",
                                                },
                                            },
                                            ObjectAnnotations =
                                            {
                                                new ProductSearchResults.Types.ObjectAnnotation
                                                {
                                                    Mid = "mid09473822",
                                                    LanguageCode = "language_code2f6c7160",
                                                    Name = "name1c9368b0",
                                                    Score = -5.80354E+17F,
                                                },
                                            },
                                        },
                                    },
                                },
                                Context = new ImageAnnotationContext
                                {
                                    Uri = "uri3db70593",
                                    PageNumber = 291687312,
                                },
                                LocalizedObjectAnnotations =
                                {
                                    new LocalizedObjectAnnotation
                                    {
                                        Mid = "mid09473822",
                                        LanguageCode = "language_code2f6c7160",
                                        Name = "name1c9368b0",
                                        Score = -5.80354E+17F,
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
                                    },
                                },
                            },
                        },
                        TotalPages = -857731154,
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
                    },
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateFiles(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null);
            BatchAnnotateFilesResponse response = client.BatchAnnotateFiles(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchAnnotateFilesRequestObjectAsync()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateFilesRequest request = new BatchAnnotateFilesRequest
            {
                Requests =
                {
                    new AnnotateFileRequest
                    {
                        InputConfig = new InputConfig
                        {
                            GcsSource = new GcsSource { Uri = "uri3db70593", },
                            MimeType = "mime_type606a0ffc",
                            Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                        },
                        Features =
                        {
                            new Feature
                            {
                                Type = Feature.Types.Type.CropHints,
                                MaxResults = -1488152846,
                                Model = "model635ef320",
                            },
                        },
                        ImageContext = new ImageContext
                        {
                            LatLongRect = new LatLongRect
                            {
                                MinLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                                MaxLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                            },
                            LanguageHints =
                            {
                                "language_hints03225ef4",
                            },
                            CropHintsParams = new CropHintsParams
                            {
                                AspectRatios = { 1.033126E+18F, },
                            },
                            ProductSearchParams = new ProductSearchParams
                            {
                                ProductSetAsProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                                ProductCategories =
                                {
                                    "product_categories01426367",
                                },
                                Filter = "filtere47ac9b2",
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
                            },
                            WebDetectionParams = new WebDetectionParams
                            {
                                IncludeGeoResults = true,
                            },
                            TextDetectionParams = new TextDetectionParams
                            {
                                EnableTextDetectionConfidenceScore = true,
                            },
                        },
                        Pages = { 757773235, },
                    },
                },
                Parent = "parent7858e4d0",
            };
            BatchAnnotateFilesResponse expectedResponse = new BatchAnnotateFilesResponse
            {
                Responses =
                {
                    new AnnotateFileResponse
                    {
                        InputConfig = new InputConfig
                        {
                            GcsSource = new GcsSource { Uri = "uri3db70593", },
                            MimeType = "mime_type606a0ffc",
                            Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                        },
                        Responses =
                        {
                            new AnnotateImageResponse
                            {
                                FaceAnnotations =
                                {
                                    new FaceAnnotation
                                    {
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
                                        FdBoundingPoly = new BoundingPoly
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
                                        Landmarks =
                                        {
                                            new FaceAnnotation.Types.Landmark
                                            {
                                                Type = FaceAnnotation.Types.Landmark.Types.Type.RightEyePupil,
                                                Position = new Position
                                                {
                                                    X = 4.7289724E+17F,
                                                    Y = 1.2858411E+17F,
                                                    Z = -4.034153E+17F,
                                                },
                                            },
                                        },
                                        RollAngle = 5.6015E+17F,
                                        PanAngle = -3.964234E+17F,
                                        TiltAngle = -4.387485E+17F,
                                        DetectionConfidence = -1.11668655E+18F,
                                        LandmarkingConfidence = -4.6933908E+17F,
                                        JoyLikelihood = Likelihood.Unknown,
                                        SorrowLikelihood = Likelihood.VeryLikely,
                                        AngerLikelihood = Likelihood.VeryLikely,
                                        SurpriseLikelihood = Likelihood.Possible,
                                        UnderExposedLikelihood = Likelihood.Likely,
                                        BlurredLikelihood = Likelihood.Possible,
                                        HeadwearLikelihood = Likelihood.Unknown,
                                    },
                                },
                                LandmarkAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                LogoAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                LabelAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                TextAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                SafeSearchAnnotation = new SafeSearchAnnotation
                                {
                                    Adult = Likelihood.Unlikely,
                                    Spoof = Likelihood.Likely,
                                    Medical = Likelihood.Unlikely,
                                    Violence = Likelihood.Likely,
                                    Racy = Likelihood.Unknown,
#pragma warning disable CS0612
                                    AdultConfidence = 7.893828E+17F,
                                    SpoofConfidence = 1.21577665E+17F,
                                    MedicalConfidence = 5.6571437E+17F,
                                    ViolenceConfidence = 3.1119182E+17F,
                                    RacyConfidence = -1.14657856E+18F,
                                    NsfwConfidence = 6.880875E+17F,
#pragma warning restore CS0612
                                },
                                ImagePropertiesAnnotation = new ImageProperties
                                {
                                    DominantColors = new DominantColorsAnnotation
                                    {
                                        Colors =
                                        {
                                            new ColorInfo
                                            {
                                                Color = new gt::Color
                                                {
                                                    Red = 3.070673E+17F,
                                                    Green = -4.994538E+17F,
                                                    Blue = 8.9135635E+17F,
                                                    Alpha = -5.821188E+17F,
                                                },
                                                Score = -5.80354E+17F,
                                                PixelFraction = 1.0369602E+18F,
                                            },
                                        },
                                    },
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
                                CropHintsAnnotation = new CropHintsAnnotation
                                {
                                    CropHints =
                                    {
                                        new CropHint
                                        {
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
                                            Confidence = 8.101506E+17F,
                                            ImportanceFraction = -4.309868E+17F,
                                        },
                                    },
                                },
                                FullTextAnnotation = new TextAnnotation
                                {
                                    Pages =
                                    {
                                        new Page
                                        {
                                            Property = new TextAnnotation.Types.TextProperty
                                            {
                                                DetectedLanguages =
                                                {
                                                    new TextAnnotation.Types.DetectedLanguage
                                                    {
                                                        LanguageCode = "language_code2f6c7160",
                                                        Confidence = 8.101506E+17F,
                                                    },
                                                },
                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                {
                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                    IsPrefix = false,
                                                },
                                            },
                                            Width = -1507414294,
                                            Height = 669136308,
                                            Blocks =
                                            {
                                                new Block
                                                {
                                                    Property = new TextAnnotation.Types.TextProperty
                                                    {
                                                        DetectedLanguages =
                                                        {
                                                            new TextAnnotation.Types.DetectedLanguage
                                                            {
                                                                LanguageCode = "language_code2f6c7160",
                                                                Confidence = 8.101506E+17F,
                                                            },
                                                        },
                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                        {
                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                            IsPrefix = false,
                                                        },
                                                    },
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
                                                    Paragraphs =
                                                    {
                                                        new Paragraph
                                                        {
                                                            Property = new TextAnnotation.Types.TextProperty
                                                            {
                                                                DetectedLanguages =
                                                                {
                                                                    new TextAnnotation.Types.DetectedLanguage
                                                                    {
                                                                        LanguageCode = "language_code2f6c7160",
                                                                        Confidence = 8.101506E+17F,
                                                                    },
                                                                },
                                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                {
                                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                    IsPrefix = false,
                                                                },
                                                            },
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
                                                            Words =
                                                            {
                                                                new Word
                                                                {
                                                                    Property = new TextAnnotation.Types.TextProperty
                                                                    {
                                                                        DetectedLanguages =
                                                                        {
                                                                            new TextAnnotation.Types.DetectedLanguage
                                                                            {
                                                                                LanguageCode = "language_code2f6c7160",
                                                                                Confidence = 8.101506E+17F,
                                                                            },
                                                                        },
                                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                        {
                                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                            IsPrefix = false,
                                                                        },
                                                                    },
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
                                                                    Symbols =
                                                                    {
                                                                        new Symbol
                                                                        {
                                                                            Property = new TextAnnotation.Types.TextProperty
                                                                            {
                                                                                DetectedLanguages =
                                                                                {
                                                                                    new TextAnnotation.Types.DetectedLanguage
                                                                                    {
                                                                                        LanguageCode = "language_code2f6c7160",
                                                                                        Confidence = 8.101506E+17F,
                                                                                    },
                                                                                },
                                                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                                {
                                                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                                    IsPrefix = false,
                                                                                },
                                                                            },
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
                                                                            Text = "textec51b21c",
                                                                            Confidence = 8.101506E+17F,
                                                                        },
                                                                    },
                                                                    Confidence = 8.101506E+17F,
                                                                },
                                                            },
                                                            Confidence = 8.101506E+17F,
                                                        },
                                                    },
                                                    BlockType = Block.Types.BlockType.Picture,
                                                    Confidence = 8.101506E+17F,
                                                },
                                            },
                                            Confidence = 8.101506E+17F,
                                        },
                                    },
                                    Text = "textec51b21c",
                                },
                                WebDetection = new WebDetection
                                {
                                    WebEntities =
                                    {
                                        new WebDetection.Types.WebEntity
                                        {
                                            EntityId = "entity_id1347fcdf",
                                            Score = -5.80354E+17F,
                                            Description = "description2cf9da67",
                                        },
                                    },
                                    FullMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    PartialMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    PagesWithMatchingImages =
                                    {
                                        new WebDetection.Types.WebPage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                            PageTitle = "page_titlef3193bb7",
                                            FullMatchingImages =
                                            {
                                                new WebDetection.Types.WebImage
                                                {
                                                    Url = "url424e2d57",
                                                    Score = -5.80354E+17F,
                                                },
                                            },
                                            PartialMatchingImages =
                                            {
                                                new WebDetection.Types.WebImage
                                                {
                                                    Url = "url424e2d57",
                                                    Score = -5.80354E+17F,
                                                },
                                            },
                                        },
                                    },
                                    VisuallySimilarImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    BestGuessLabels =
                                    {
                                        new WebDetection.Types.WebLabel
                                        {
                                            Label = "label20ba04d3",
                                            LanguageCode = "language_code2f6c7160",
                                        },
                                    },
                                },
                                ProductSearchResults = new ProductSearchResults
                                {
                                    IndexTime = new wkt::Timestamp
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    Results =
                                    {
                                        new ProductSearchResults.Types.Result
                                        {
                                            Product = new Product
                                            {
                                                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                                ProductCategory = "product_category7fba5b40",
                                                ProductLabels =
                                                {
                                                    new Product.Types.KeyValue
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Value = "value60c16320",
                                                    },
                                                },
                                            },
                                            Score = -5.80354E+17F,
                                            Image = "image225a8078",
                                        },
                                    },
                                    ProductGroupedResults =
                                    {
                                        new ProductSearchResults.Types.GroupedResult
                                        {
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
                                            Results =
                                            {
                                                new ProductSearchResults.Types.Result
                                                {
                                                    Product = new Product
                                                    {
                                                        ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                                        DisplayName = "display_name137f65c2",
                                                        Description = "description2cf9da67",
                                                        ProductCategory = "product_category7fba5b40",
                                                        ProductLabels =
                                                        {
                                                            new Product.Types.KeyValue
                                                            {
                                                                Key = "key8a0b6e3c",
                                                                Value = "value60c16320",
                                                            },
                                                        },
                                                    },
                                                    Score = -5.80354E+17F,
                                                    Image = "image225a8078",
                                                },
                                            },
                                            ObjectAnnotations =
                                            {
                                                new ProductSearchResults.Types.ObjectAnnotation
                                                {
                                                    Mid = "mid09473822",
                                                    LanguageCode = "language_code2f6c7160",
                                                    Name = "name1c9368b0",
                                                    Score = -5.80354E+17F,
                                                },
                                            },
                                        },
                                    },
                                },
                                Context = new ImageAnnotationContext
                                {
                                    Uri = "uri3db70593",
                                    PageNumber = 291687312,
                                },
                                LocalizedObjectAnnotations =
                                {
                                    new LocalizedObjectAnnotation
                                    {
                                        Mid = "mid09473822",
                                        LanguageCode = "language_code2f6c7160",
                                        Name = "name1c9368b0",
                                        Score = -5.80354E+17F,
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
                                    },
                                },
                            },
                        },
                        TotalPages = -857731154,
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
                    },
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateFilesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchAnnotateFilesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null);
            BatchAnnotateFilesResponse responseCallSettings = await client.BatchAnnotateFilesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchAnnotateFilesResponse responseCancellationToken = await client.BatchAnnotateFilesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchAnnotateFiles()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateFilesRequest request = new BatchAnnotateFilesRequest
            {
                Requests =
                {
                    new AnnotateFileRequest
                    {
                        InputConfig = new InputConfig
                        {
                            GcsSource = new GcsSource { Uri = "uri3db70593", },
                            MimeType = "mime_type606a0ffc",
                            Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                        },
                        Features =
                        {
                            new Feature
                            {
                                Type = Feature.Types.Type.CropHints,
                                MaxResults = -1488152846,
                                Model = "model635ef320",
                            },
                        },
                        ImageContext = new ImageContext
                        {
                            LatLongRect = new LatLongRect
                            {
                                MinLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                                MaxLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                            },
                            LanguageHints =
                            {
                                "language_hints03225ef4",
                            },
                            CropHintsParams = new CropHintsParams
                            {
                                AspectRatios = { 1.033126E+18F, },
                            },
                            ProductSearchParams = new ProductSearchParams
                            {
                                ProductSetAsProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                                ProductCategories =
                                {
                                    "product_categories01426367",
                                },
                                Filter = "filtere47ac9b2",
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
                            },
                            WebDetectionParams = new WebDetectionParams
                            {
                                IncludeGeoResults = true,
                            },
                            TextDetectionParams = new TextDetectionParams
                            {
                                EnableTextDetectionConfidenceScore = true,
                            },
                        },
                        Pages = { 757773235, },
                    },
                },
            };
            BatchAnnotateFilesResponse expectedResponse = new BatchAnnotateFilesResponse
            {
                Responses =
                {
                    new AnnotateFileResponse
                    {
                        InputConfig = new InputConfig
                        {
                            GcsSource = new GcsSource { Uri = "uri3db70593", },
                            MimeType = "mime_type606a0ffc",
                            Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                        },
                        Responses =
                        {
                            new AnnotateImageResponse
                            {
                                FaceAnnotations =
                                {
                                    new FaceAnnotation
                                    {
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
                                        FdBoundingPoly = new BoundingPoly
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
                                        Landmarks =
                                        {
                                            new FaceAnnotation.Types.Landmark
                                            {
                                                Type = FaceAnnotation.Types.Landmark.Types.Type.RightEyePupil,
                                                Position = new Position
                                                {
                                                    X = 4.7289724E+17F,
                                                    Y = 1.2858411E+17F,
                                                    Z = -4.034153E+17F,
                                                },
                                            },
                                        },
                                        RollAngle = 5.6015E+17F,
                                        PanAngle = -3.964234E+17F,
                                        TiltAngle = -4.387485E+17F,
                                        DetectionConfidence = -1.11668655E+18F,
                                        LandmarkingConfidence = -4.6933908E+17F,
                                        JoyLikelihood = Likelihood.Unknown,
                                        SorrowLikelihood = Likelihood.VeryLikely,
                                        AngerLikelihood = Likelihood.VeryLikely,
                                        SurpriseLikelihood = Likelihood.Possible,
                                        UnderExposedLikelihood = Likelihood.Likely,
                                        BlurredLikelihood = Likelihood.Possible,
                                        HeadwearLikelihood = Likelihood.Unknown,
                                    },
                                },
                                LandmarkAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                LogoAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                LabelAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                TextAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                SafeSearchAnnotation = new SafeSearchAnnotation
                                {
                                    Adult = Likelihood.Unlikely,
                                    Spoof = Likelihood.Likely,
                                    Medical = Likelihood.Unlikely,
                                    Violence = Likelihood.Likely,
                                    Racy = Likelihood.Unknown,
#pragma warning disable CS0612
                                    AdultConfidence = 7.893828E+17F,
                                    SpoofConfidence = 1.21577665E+17F,
                                    MedicalConfidence = 5.6571437E+17F,
                                    ViolenceConfidence = 3.1119182E+17F,
                                    RacyConfidence = -1.14657856E+18F,
                                    NsfwConfidence = 6.880875E+17F,
#pragma warning restore CS0612
                                },
                                ImagePropertiesAnnotation = new ImageProperties
                                {
                                    DominantColors = new DominantColorsAnnotation
                                    {
                                        Colors =
                                        {
                                            new ColorInfo
                                            {
                                                Color = new gt::Color
                                                {
                                                    Red = 3.070673E+17F,
                                                    Green = -4.994538E+17F,
                                                    Blue = 8.9135635E+17F,
                                                    Alpha = -5.821188E+17F,
                                                },
                                                Score = -5.80354E+17F,
                                                PixelFraction = 1.0369602E+18F,
                                            },
                                        },
                                    },
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
                                CropHintsAnnotation = new CropHintsAnnotation
                                {
                                    CropHints =
                                    {
                                        new CropHint
                                        {
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
                                            Confidence = 8.101506E+17F,
                                            ImportanceFraction = -4.309868E+17F,
                                        },
                                    },
                                },
                                FullTextAnnotation = new TextAnnotation
                                {
                                    Pages =
                                    {
                                        new Page
                                        {
                                            Property = new TextAnnotation.Types.TextProperty
                                            {
                                                DetectedLanguages =
                                                {
                                                    new TextAnnotation.Types.DetectedLanguage
                                                    {
                                                        LanguageCode = "language_code2f6c7160",
                                                        Confidence = 8.101506E+17F,
                                                    },
                                                },
                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                {
                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                    IsPrefix = false,
                                                },
                                            },
                                            Width = -1507414294,
                                            Height = 669136308,
                                            Blocks =
                                            {
                                                new Block
                                                {
                                                    Property = new TextAnnotation.Types.TextProperty
                                                    {
                                                        DetectedLanguages =
                                                        {
                                                            new TextAnnotation.Types.DetectedLanguage
                                                            {
                                                                LanguageCode = "language_code2f6c7160",
                                                                Confidence = 8.101506E+17F,
                                                            },
                                                        },
                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                        {
                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                            IsPrefix = false,
                                                        },
                                                    },
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
                                                    Paragraphs =
                                                    {
                                                        new Paragraph
                                                        {
                                                            Property = new TextAnnotation.Types.TextProperty
                                                            {
                                                                DetectedLanguages =
                                                                {
                                                                    new TextAnnotation.Types.DetectedLanguage
                                                                    {
                                                                        LanguageCode = "language_code2f6c7160",
                                                                        Confidence = 8.101506E+17F,
                                                                    },
                                                                },
                                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                {
                                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                    IsPrefix = false,
                                                                },
                                                            },
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
                                                            Words =
                                                            {
                                                                new Word
                                                                {
                                                                    Property = new TextAnnotation.Types.TextProperty
                                                                    {
                                                                        DetectedLanguages =
                                                                        {
                                                                            new TextAnnotation.Types.DetectedLanguage
                                                                            {
                                                                                LanguageCode = "language_code2f6c7160",
                                                                                Confidence = 8.101506E+17F,
                                                                            },
                                                                        },
                                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                        {
                                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                            IsPrefix = false,
                                                                        },
                                                                    },
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
                                                                    Symbols =
                                                                    {
                                                                        new Symbol
                                                                        {
                                                                            Property = new TextAnnotation.Types.TextProperty
                                                                            {
                                                                                DetectedLanguages =
                                                                                {
                                                                                    new TextAnnotation.Types.DetectedLanguage
                                                                                    {
                                                                                        LanguageCode = "language_code2f6c7160",
                                                                                        Confidence = 8.101506E+17F,
                                                                                    },
                                                                                },
                                                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                                {
                                                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                                    IsPrefix = false,
                                                                                },
                                                                            },
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
                                                                            Text = "textec51b21c",
                                                                            Confidence = 8.101506E+17F,
                                                                        },
                                                                    },
                                                                    Confidence = 8.101506E+17F,
                                                                },
                                                            },
                                                            Confidence = 8.101506E+17F,
                                                        },
                                                    },
                                                    BlockType = Block.Types.BlockType.Picture,
                                                    Confidence = 8.101506E+17F,
                                                },
                                            },
                                            Confidence = 8.101506E+17F,
                                        },
                                    },
                                    Text = "textec51b21c",
                                },
                                WebDetection = new WebDetection
                                {
                                    WebEntities =
                                    {
                                        new WebDetection.Types.WebEntity
                                        {
                                            EntityId = "entity_id1347fcdf",
                                            Score = -5.80354E+17F,
                                            Description = "description2cf9da67",
                                        },
                                    },
                                    FullMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    PartialMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    PagesWithMatchingImages =
                                    {
                                        new WebDetection.Types.WebPage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                            PageTitle = "page_titlef3193bb7",
                                            FullMatchingImages =
                                            {
                                                new WebDetection.Types.WebImage
                                                {
                                                    Url = "url424e2d57",
                                                    Score = -5.80354E+17F,
                                                },
                                            },
                                            PartialMatchingImages =
                                            {
                                                new WebDetection.Types.WebImage
                                                {
                                                    Url = "url424e2d57",
                                                    Score = -5.80354E+17F,
                                                },
                                            },
                                        },
                                    },
                                    VisuallySimilarImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    BestGuessLabels =
                                    {
                                        new WebDetection.Types.WebLabel
                                        {
                                            Label = "label20ba04d3",
                                            LanguageCode = "language_code2f6c7160",
                                        },
                                    },
                                },
                                ProductSearchResults = new ProductSearchResults
                                {
                                    IndexTime = new wkt::Timestamp
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    Results =
                                    {
                                        new ProductSearchResults.Types.Result
                                        {
                                            Product = new Product
                                            {
                                                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                                ProductCategory = "product_category7fba5b40",
                                                ProductLabels =
                                                {
                                                    new Product.Types.KeyValue
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Value = "value60c16320",
                                                    },
                                                },
                                            },
                                            Score = -5.80354E+17F,
                                            Image = "image225a8078",
                                        },
                                    },
                                    ProductGroupedResults =
                                    {
                                        new ProductSearchResults.Types.GroupedResult
                                        {
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
                                            Results =
                                            {
                                                new ProductSearchResults.Types.Result
                                                {
                                                    Product = new Product
                                                    {
                                                        ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                                        DisplayName = "display_name137f65c2",
                                                        Description = "description2cf9da67",
                                                        ProductCategory = "product_category7fba5b40",
                                                        ProductLabels =
                                                        {
                                                            new Product.Types.KeyValue
                                                            {
                                                                Key = "key8a0b6e3c",
                                                                Value = "value60c16320",
                                                            },
                                                        },
                                                    },
                                                    Score = -5.80354E+17F,
                                                    Image = "image225a8078",
                                                },
                                            },
                                            ObjectAnnotations =
                                            {
                                                new ProductSearchResults.Types.ObjectAnnotation
                                                {
                                                    Mid = "mid09473822",
                                                    LanguageCode = "language_code2f6c7160",
                                                    Name = "name1c9368b0",
                                                    Score = -5.80354E+17F,
                                                },
                                            },
                                        },
                                    },
                                },
                                Context = new ImageAnnotationContext
                                {
                                    Uri = "uri3db70593",
                                    PageNumber = 291687312,
                                },
                                LocalizedObjectAnnotations =
                                {
                                    new LocalizedObjectAnnotation
                                    {
                                        Mid = "mid09473822",
                                        LanguageCode = "language_code2f6c7160",
                                        Name = "name1c9368b0",
                                        Score = -5.80354E+17F,
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
                                    },
                                },
                            },
                        },
                        TotalPages = -857731154,
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
                    },
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateFiles(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null);
            BatchAnnotateFilesResponse response = client.BatchAnnotateFiles(request.Requests);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchAnnotateFilesAsync()
        {
            moq::Mock<ImageAnnotator.ImageAnnotatorClient> mockGrpcClient = new moq::Mock<ImageAnnotator.ImageAnnotatorClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchAnnotateFilesRequest request = new BatchAnnotateFilesRequest
            {
                Requests =
                {
                    new AnnotateFileRequest
                    {
                        InputConfig = new InputConfig
                        {
                            GcsSource = new GcsSource { Uri = "uri3db70593", },
                            MimeType = "mime_type606a0ffc",
                            Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                        },
                        Features =
                        {
                            new Feature
                            {
                                Type = Feature.Types.Type.CropHints,
                                MaxResults = -1488152846,
                                Model = "model635ef320",
                            },
                        },
                        ImageContext = new ImageContext
                        {
                            LatLongRect = new LatLongRect
                            {
                                MinLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                                MaxLatLng = new gt::LatLng
                                {
                                    Latitude = 8.158369671878062E+17,
                                    Longitude = 8.869183012043108E+17,
                                },
                            },
                            LanguageHints =
                            {
                                "language_hints03225ef4",
                            },
                            CropHintsParams = new CropHintsParams
                            {
                                AspectRatios = { 1.033126E+18F, },
                            },
                            ProductSearchParams = new ProductSearchParams
                            {
                                ProductSetAsProductSetName = ProductSetName.FromProjectLocationProductSet("[PROJECT]", "[LOCATION]", "[PRODUCT_SET]"),
                                ProductCategories =
                                {
                                    "product_categories01426367",
                                },
                                Filter = "filtere47ac9b2",
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
                            },
                            WebDetectionParams = new WebDetectionParams
                            {
                                IncludeGeoResults = true,
                            },
                            TextDetectionParams = new TextDetectionParams
                            {
                                EnableTextDetectionConfidenceScore = true,
                            },
                        },
                        Pages = { 757773235, },
                    },
                },
            };
            BatchAnnotateFilesResponse expectedResponse = new BatchAnnotateFilesResponse
            {
                Responses =
                {
                    new AnnotateFileResponse
                    {
                        InputConfig = new InputConfig
                        {
                            GcsSource = new GcsSource { Uri = "uri3db70593", },
                            MimeType = "mime_type606a0ffc",
                            Content = proto::ByteString.CopyFromUtf8("contentb964039a"),
                        },
                        Responses =
                        {
                            new AnnotateImageResponse
                            {
                                FaceAnnotations =
                                {
                                    new FaceAnnotation
                                    {
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
                                        FdBoundingPoly = new BoundingPoly
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
                                        Landmarks =
                                        {
                                            new FaceAnnotation.Types.Landmark
                                            {
                                                Type = FaceAnnotation.Types.Landmark.Types.Type.RightEyePupil,
                                                Position = new Position
                                                {
                                                    X = 4.7289724E+17F,
                                                    Y = 1.2858411E+17F,
                                                    Z = -4.034153E+17F,
                                                },
                                            },
                                        },
                                        RollAngle = 5.6015E+17F,
                                        PanAngle = -3.964234E+17F,
                                        TiltAngle = -4.387485E+17F,
                                        DetectionConfidence = -1.11668655E+18F,
                                        LandmarkingConfidence = -4.6933908E+17F,
                                        JoyLikelihood = Likelihood.Unknown,
                                        SorrowLikelihood = Likelihood.VeryLikely,
                                        AngerLikelihood = Likelihood.VeryLikely,
                                        SurpriseLikelihood = Likelihood.Possible,
                                        UnderExposedLikelihood = Likelihood.Likely,
                                        BlurredLikelihood = Likelihood.Possible,
                                        HeadwearLikelihood = Likelihood.Unknown,
                                    },
                                },
                                LandmarkAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                LogoAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                LabelAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                TextAnnotations =
                                {
                                    new EntityAnnotation
                                    {
                                        Mid = "mid09473822",
                                        Locale = "locale9e6d21fb",
                                        Description = "description2cf9da67",
                                        Score = -5.80354E+17F,
#pragma warning disable CS0612
                                        Confidence = 8.101506E+17F,
#pragma warning restore CS0612
                                        Topicality = 1.8519913E+17F,
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
                                        Locations =
                                        {
                                            new LocationInfo
                                            {
                                                LatLng = new gt::LatLng
                                                {
                                                    Latitude = 8.158369671878062E+17,
                                                    Longitude = 8.869183012043108E+17,
                                                },
                                            },
                                        },
                                        Properties =
                                        {
                                            new Property
                                            {
                                                Name = "name1c9368b0",
                                                Value = "value60c16320",
                                                Uint64Value = 13460318030236737202UL,
                                            },
                                        },
                                    },
                                },
                                SafeSearchAnnotation = new SafeSearchAnnotation
                                {
                                    Adult = Likelihood.Unlikely,
                                    Spoof = Likelihood.Likely,
                                    Medical = Likelihood.Unlikely,
                                    Violence = Likelihood.Likely,
                                    Racy = Likelihood.Unknown,
#pragma warning disable CS0612
                                    AdultConfidence = 7.893828E+17F,
                                    SpoofConfidence = 1.21577665E+17F,
                                    MedicalConfidence = 5.6571437E+17F,
                                    ViolenceConfidence = 3.1119182E+17F,
                                    RacyConfidence = -1.14657856E+18F,
                                    NsfwConfidence = 6.880875E+17F,
#pragma warning restore CS0612
                                },
                                ImagePropertiesAnnotation = new ImageProperties
                                {
                                    DominantColors = new DominantColorsAnnotation
                                    {
                                        Colors =
                                        {
                                            new ColorInfo
                                            {
                                                Color = new gt::Color
                                                {
                                                    Red = 3.070673E+17F,
                                                    Green = -4.994538E+17F,
                                                    Blue = 8.9135635E+17F,
                                                    Alpha = -5.821188E+17F,
                                                },
                                                Score = -5.80354E+17F,
                                                PixelFraction = 1.0369602E+18F,
                                            },
                                        },
                                    },
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
                                CropHintsAnnotation = new CropHintsAnnotation
                                {
                                    CropHints =
                                    {
                                        new CropHint
                                        {
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
                                            Confidence = 8.101506E+17F,
                                            ImportanceFraction = -4.309868E+17F,
                                        },
                                    },
                                },
                                FullTextAnnotation = new TextAnnotation
                                {
                                    Pages =
                                    {
                                        new Page
                                        {
                                            Property = new TextAnnotation.Types.TextProperty
                                            {
                                                DetectedLanguages =
                                                {
                                                    new TextAnnotation.Types.DetectedLanguage
                                                    {
                                                        LanguageCode = "language_code2f6c7160",
                                                        Confidence = 8.101506E+17F,
                                                    },
                                                },
                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                {
                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                    IsPrefix = false,
                                                },
                                            },
                                            Width = -1507414294,
                                            Height = 669136308,
                                            Blocks =
                                            {
                                                new Block
                                                {
                                                    Property = new TextAnnotation.Types.TextProperty
                                                    {
                                                        DetectedLanguages =
                                                        {
                                                            new TextAnnotation.Types.DetectedLanguage
                                                            {
                                                                LanguageCode = "language_code2f6c7160",
                                                                Confidence = 8.101506E+17F,
                                                            },
                                                        },
                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                        {
                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                            IsPrefix = false,
                                                        },
                                                    },
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
                                                    Paragraphs =
                                                    {
                                                        new Paragraph
                                                        {
                                                            Property = new TextAnnotation.Types.TextProperty
                                                            {
                                                                DetectedLanguages =
                                                                {
                                                                    new TextAnnotation.Types.DetectedLanguage
                                                                    {
                                                                        LanguageCode = "language_code2f6c7160",
                                                                        Confidence = 8.101506E+17F,
                                                                    },
                                                                },
                                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                {
                                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                    IsPrefix = false,
                                                                },
                                                            },
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
                                                            Words =
                                                            {
                                                                new Word
                                                                {
                                                                    Property = new TextAnnotation.Types.TextProperty
                                                                    {
                                                                        DetectedLanguages =
                                                                        {
                                                                            new TextAnnotation.Types.DetectedLanguage
                                                                            {
                                                                                LanguageCode = "language_code2f6c7160",
                                                                                Confidence = 8.101506E+17F,
                                                                            },
                                                                        },
                                                                        DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                        {
                                                                            Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                            IsPrefix = false,
                                                                        },
                                                                    },
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
                                                                    Symbols =
                                                                    {
                                                                        new Symbol
                                                                        {
                                                                            Property = new TextAnnotation.Types.TextProperty
                                                                            {
                                                                                DetectedLanguages =
                                                                                {
                                                                                    new TextAnnotation.Types.DetectedLanguage
                                                                                    {
                                                                                        LanguageCode = "language_code2f6c7160",
                                                                                        Confidence = 8.101506E+17F,
                                                                                    },
                                                                                },
                                                                                DetectedBreak = new TextAnnotation.Types.DetectedBreak
                                                                                {
                                                                                    Type = TextAnnotation.Types.DetectedBreak.Types.BreakType.EolSureSpace,
                                                                                    IsPrefix = false,
                                                                                },
                                                                            },
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
                                                                            Text = "textec51b21c",
                                                                            Confidence = 8.101506E+17F,
                                                                        },
                                                                    },
                                                                    Confidence = 8.101506E+17F,
                                                                },
                                                            },
                                                            Confidence = 8.101506E+17F,
                                                        },
                                                    },
                                                    BlockType = Block.Types.BlockType.Picture,
                                                    Confidence = 8.101506E+17F,
                                                },
                                            },
                                            Confidence = 8.101506E+17F,
                                        },
                                    },
                                    Text = "textec51b21c",
                                },
                                WebDetection = new WebDetection
                                {
                                    WebEntities =
                                    {
                                        new WebDetection.Types.WebEntity
                                        {
                                            EntityId = "entity_id1347fcdf",
                                            Score = -5.80354E+17F,
                                            Description = "description2cf9da67",
                                        },
                                    },
                                    FullMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    PartialMatchingImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    PagesWithMatchingImages =
                                    {
                                        new WebDetection.Types.WebPage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                            PageTitle = "page_titlef3193bb7",
                                            FullMatchingImages =
                                            {
                                                new WebDetection.Types.WebImage
                                                {
                                                    Url = "url424e2d57",
                                                    Score = -5.80354E+17F,
                                                },
                                            },
                                            PartialMatchingImages =
                                            {
                                                new WebDetection.Types.WebImage
                                                {
                                                    Url = "url424e2d57",
                                                    Score = -5.80354E+17F,
                                                },
                                            },
                                        },
                                    },
                                    VisuallySimilarImages =
                                    {
                                        new WebDetection.Types.WebImage
                                        {
                                            Url = "url424e2d57",
                                            Score = -5.80354E+17F,
                                        },
                                    },
                                    BestGuessLabels =
                                    {
                                        new WebDetection.Types.WebLabel
                                        {
                                            Label = "label20ba04d3",
                                            LanguageCode = "language_code2f6c7160",
                                        },
                                    },
                                },
                                ProductSearchResults = new ProductSearchResults
                                {
                                    IndexTime = new wkt::Timestamp
                                    {
                                        Seconds = -2106654494186127752L,
                                        Nanos = 985689544,
                                    },
                                    Results =
                                    {
                                        new ProductSearchResults.Types.Result
                                        {
                                            Product = new Product
                                            {
                                                ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                                DisplayName = "display_name137f65c2",
                                                Description = "description2cf9da67",
                                                ProductCategory = "product_category7fba5b40",
                                                ProductLabels =
                                                {
                                                    new Product.Types.KeyValue
                                                    {
                                                        Key = "key8a0b6e3c",
                                                        Value = "value60c16320",
                                                    },
                                                },
                                            },
                                            Score = -5.80354E+17F,
                                            Image = "image225a8078",
                                        },
                                    },
                                    ProductGroupedResults =
                                    {
                                        new ProductSearchResults.Types.GroupedResult
                                        {
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
                                            Results =
                                            {
                                                new ProductSearchResults.Types.Result
                                                {
                                                    Product = new Product
                                                    {
                                                        ProductName = ProductName.FromProjectLocationProduct("[PROJECT]", "[LOCATION]", "[PRODUCT]"),
                                                        DisplayName = "display_name137f65c2",
                                                        Description = "description2cf9da67",
                                                        ProductCategory = "product_category7fba5b40",
                                                        ProductLabels =
                                                        {
                                                            new Product.Types.KeyValue
                                                            {
                                                                Key = "key8a0b6e3c",
                                                                Value = "value60c16320",
                                                            },
                                                        },
                                                    },
                                                    Score = -5.80354E+17F,
                                                    Image = "image225a8078",
                                                },
                                            },
                                            ObjectAnnotations =
                                            {
                                                new ProductSearchResults.Types.ObjectAnnotation
                                                {
                                                    Mid = "mid09473822",
                                                    LanguageCode = "language_code2f6c7160",
                                                    Name = "name1c9368b0",
                                                    Score = -5.80354E+17F,
                                                },
                                            },
                                        },
                                    },
                                },
                                Context = new ImageAnnotationContext
                                {
                                    Uri = "uri3db70593",
                                    PageNumber = 291687312,
                                },
                                LocalizedObjectAnnotations =
                                {
                                    new LocalizedObjectAnnotation
                                    {
                                        Mid = "mid09473822",
                                        LanguageCode = "language_code2f6c7160",
                                        Name = "name1c9368b0",
                                        Score = -5.80354E+17F,
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
                                    },
                                },
                            },
                        },
                        TotalPages = -857731154,
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
                    },
                },
            };
            mockGrpcClient.Setup(x => x.BatchAnnotateFilesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchAnnotateFilesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ImageAnnotatorClient client = new ImageAnnotatorClientImpl(mockGrpcClient.Object, null);
            BatchAnnotateFilesResponse responseCallSettings = await client.BatchAnnotateFilesAsync(request.Requests, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchAnnotateFilesResponse responseCancellationToken = await client.BatchAnnotateFilesAsync(request.Requests, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
