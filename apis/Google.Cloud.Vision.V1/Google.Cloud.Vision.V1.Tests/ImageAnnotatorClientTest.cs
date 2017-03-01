// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeatureType = Google.Cloud.Vision.V1.Feature.Types.Type;
using Xunit;
using Google.Type;
using Google.Api.Gax;
using Google.Protobuf.Collections;
using Google.Api.Gax.Grpc;

namespace Google.Cloud.Vision.V1.Tests
{
    public class ImageAnnotatorClientTest
    {
        // Response with some information about everything - although most annotations are "incomplete" in terms
        // of bounding boxes etc. We trust that the client code just passes the annotations through without
        // further processing. All repeated annotations have two values to allow testing for MaxResults.
        private static readonly AnnotateImageResponse s_allAnnotationsResponse = new AnnotateImageResponse
        {
            FaceAnnotations =
            {
                new FaceAnnotation { DetectionConfidence = 0.5f },
                new FaceAnnotation { DetectionConfidence = 0.3f }
            },
            ImagePropertiesAnnotation = new ImageProperties
            {
                DominantColors = new DominantColorsAnnotation
                {
                    Colors = {
                        new ColorInfo { Color = new Color { Red = 255 }, PixelFraction = 0.75f, Score = 0.5f },
                        new ColorInfo { Color = new Color { Blue = 255 }, PixelFraction = 0.25f, Score = 0.25f }
                    }
                }
            },
            LabelAnnotations =
            {
                new EntityAnnotation { Description = "Food" },
                new EntityAnnotation { Description = "Sheds" }
            },
            LandmarkAnnotations =
            {
                new EntityAnnotation { Description = "Big Ben" },
                new EntityAnnotation { Description = "Houses of Parliament" }
            },
            LogoAnnotations =
            {
                new EntityAnnotation { Description = "Transport for London" },
                new EntityAnnotation { Description = "London Eye" }
            },
            SafeSearchAnnotation = new SafeSearchAnnotation
            {
                Adult = Likelihood.Unlikely,
                Spoof = Likelihood.VeryLikely,
                Medical = Likelihood.VeryUnlikely,
                Violence = Likelihood.Possible
            },
            TextAnnotations =
            {
                new EntityAnnotation { Description = "Mind the gap" },
                new EntityAnnotation { Description = "Queue here" }
            },
            CropHintsAnnotation = new CropHintsAnnotation {
                CropHints = {
                    new CropHint {
                        BoundingPoly = new BoundingPoly {
                            Vertices = {
                                new Vertex { X = 0, Y = 0},
                                new Vertex { X = 100, Y = 0},
                                new Vertex { X = 100, Y = 100},
                                new Vertex { X = 0, Y = 1000}
                            }
                        }
                    }
                }
            },
            WebDetection = new WebDetection
            {
                WebEntities = { new WebDetection.Types.WebEntity { Description = "Statue Of Liberty" } }
            },
            FullTextAnnotation = new TextAnnotation
            {
                Text = "The cat sat on the mat"
            }
        };
        // Image corresponding to s_allAnnotationsResponse.
        private static readonly Image s_allAnnotationsImage = CreateFakeImage(s_allAnnotationsResponse);

        // Response with an error and no annotations
        private static readonly AnnotateImageResponse s_errorResponse = new AnnotateImageResponse
        {
            Error = new Rpc.Status { Code = 1, Message = "Bad image" }
        };

        // Image corresponding to s_errorResponse
        private static readonly Image s_errorImage = CreateFakeImage(s_errorResponse);

        private static Image CreateFakeImage(AnnotateImageResponse response) => new Image { Content = response.ToByteString() };

        [Fact]
        public async Task Annotate()
        {
            ImageAnnotatorClient client = new FakeImageAnnotator();
            var request = new AnnotateImageRequest
            {
                Image = s_allAnnotationsImage,
                Features =
                {
                    new Feature { Type = FeatureType.FaceDetection },
                    new Feature { Type = FeatureType.LogoDetection, MaxResults = 1 }
                }
            };
            var expectedResponse = new AnnotateImageResponse
            {
                FaceAnnotations = { s_allAnnotationsResponse.FaceAnnotations },
                LogoAnnotations = { s_allAnnotationsResponse.LogoAnnotations.Take(1) }
            };
            Assert.Equal(expectedResponse, client.Annotate(request));
            Assert.Equal(expectedResponse, await client.AnnotateAsync(request));
        }

        [Fact]
        public async Task DetectFaces()
        {
            ImageAnnotatorClient client = new FakeImageAnnotator();
            var image = CreateFakeImage(s_allAnnotationsResponse);
            await AssertRepeatedAnnotation(client.DetectFaces, client.DetectFacesAsync, s_allAnnotationsResponse.FaceAnnotations);
        }

        [Fact]
        public async Task DetectText()
        {
            ImageAnnotatorClient client = new FakeImageAnnotator();
            await AssertRepeatedAnnotation(client.DetectText, client.DetectTextAsync, s_allAnnotationsResponse.TextAnnotations);
        }

        [Fact]
        public async Task DetectLogos()
        {
            ImageAnnotatorClient client = new FakeImageAnnotator();
            await AssertRepeatedAnnotation(client.DetectLogos, client.DetectLogosAsync, s_allAnnotationsResponse.LogoAnnotations);
        }

        [Fact]
        public async Task DetectLabels()
        {
            ImageAnnotatorClient client = new FakeImageAnnotator();
            await AssertRepeatedAnnotation(client.DetectLabels, client.DetectLabelsAsync, s_allAnnotationsResponse.LabelAnnotations);
        }

        [Fact]
        public async Task DetectLandmarks()
        {
            ImageAnnotatorClient client = new FakeImageAnnotator();
            await AssertRepeatedAnnotation(client.DetectLandmarks, client.DetectLandmarksAsync, s_allAnnotationsResponse.LandmarkAnnotations);
        }

        [Fact]
        public async Task DetectSafeSearch()
        {
            ImageAnnotatorClient client = new FakeImageAnnotator();
            Assert.Equal(s_allAnnotationsResponse.SafeSearchAnnotation, client.DetectSafeSearch(s_allAnnotationsImage));
            Assert.Equal(s_allAnnotationsResponse.SafeSearchAnnotation, await client.DetectSafeSearchAsync(s_allAnnotationsImage));
        }

        [Fact]
        public async Task DetectDocumentText()
        {
            ImageAnnotatorClient client = new FakeImageAnnotator();
            Assert.Equal(s_allAnnotationsResponse.FullTextAnnotation, client.DetectDocumentText(s_allAnnotationsImage));
            Assert.Equal(s_allAnnotationsResponse.FullTextAnnotation, await client.DetectDocumentTextAsync(s_allAnnotationsImage));
        }

        [Fact]
        public async Task DetectCropHints()
        {
            ImageAnnotatorClient client = new FakeImageAnnotator();
            Assert.Equal(s_allAnnotationsResponse.CropHintsAnnotation, client.DetectCropHints(s_allAnnotationsImage));
            Assert.Equal(s_allAnnotationsResponse.CropHintsAnnotation, await client.DetectCropHintsAsync(s_allAnnotationsImage));
        }

        [Fact]
        public async Task DetectWebInformation()
        {
            ImageAnnotatorClient client = new FakeImageAnnotator();
            Assert.Equal(s_allAnnotationsResponse.WebDetection, client.DetectWebInformation(s_allAnnotationsImage));
            Assert.Equal(s_allAnnotationsResponse.WebDetection, await client.DetectWebInformationAsync(s_allAnnotationsImage));
        }

        [Fact]
        public async Task DetectImageProperties()
        {
            ImageAnnotatorClient client = new FakeImageAnnotator();
            Assert.Equal(s_allAnnotationsResponse.ImagePropertiesAnnotation, client.DetectImageProperties(s_allAnnotationsImage));
            Assert.Equal(s_allAnnotationsResponse.ImagePropertiesAnnotation, await client.DetectImagePropertiesAsync(s_allAnnotationsImage));
        }

        private async Task AssertRepeatedAnnotation<T>(
            Func<Image, ImageContext, int, CallSettings, IReadOnlyList<T>> syncCall,
            Func<Image, ImageContext, int, CallSettings, Task<IReadOnlyList<T>>> asyncCall,
            RepeatedField<T> allAnnotations)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => syncCall(s_allAnnotationsImage, null, -1, null));
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => asyncCall(s_allAnnotationsImage, null, -1, null));
            Assert.Equal(allAnnotations, syncCall(s_allAnnotationsImage, null, 0, null));
            Assert.Equal(allAnnotations, await asyncCall(s_allAnnotationsImage, null, 0, null));
            Assert.Throws<AnnotateImageException>(() => syncCall(s_errorImage, null, 0, null));
            await Assert.ThrowsAsync<AnnotateImageException>(() => asyncCall(s_errorImage, null, 0, null));
        }
    }
}
