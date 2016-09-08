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

using Google.Rpc;
using Google.Type;
using System;
using System.Linq;
using Xunit;

namespace Google.Cloud.Vision.V1.Snippets
{
    public class ImageAnnotatorClientSnippets
    {
        [Fact]
        public void Annotate()
        {
            Image image = LoadResourceImage("SchmidtBrinPage.jpg");
            // Snippet: Annotate
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            AnnotateImageRequest request = new AnnotateImageRequest
            {
                Image = image,
                Features =
                {
                    new Feature { Type = Feature.Types.Type.FaceDetection },
                    // By default, no limits are put on the number of results per annotation.
                    // Use the MaxResults property to specify a limit.
                    new Feature { Type = Feature.Types.Type.LandmarkDetection, MaxResults = 5 },
                }
            };
            AnnotateImageResponse response = client.Annotate(request);
            Console.WriteLine("Faces:");
            foreach (FaceAnnotation face in response.FaceAnnotations)
            {
                Console.WriteLine($"  Confidence: {(int)(face.DetectionConfidence * 100)}%; BoundingPoly: {face.BoundingPoly}");
            }
            Console.WriteLine("Landmarks:");
            foreach (EntityAnnotation landmark in response.LandmarkAnnotations)
            {
                Console.WriteLine($"Score: {(int)(landmark.Score * 100)}%; Description: {landmark.Description}");
            }
            if (response.Error != null)
            {
                Console.WriteLine($"Error detected: {response.Error}");
            }
            // End snippet

            Assert.Equal(3, response.FaceAnnotations.Count);
            Assert.Equal(0, response.LandmarkAnnotations.Count);
        }

        [Fact]
        public void BatchAnnotateImages()
        {
            Image image1 = LoadResourceImage("SchmidtBrinPage.jpg");
            Image image2 = LoadResourceImage("Chrome.png");
            // Snippet: BatchAnnotateImages
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            // Perform face recognition on one image, and logo recognition on another.
            AnnotateImageRequest request1 = new AnnotateImageRequest
            {
                Image = image1,
                Features = { new Feature { Type = Feature.Types.Type.FaceDetection } }
            };
            AnnotateImageRequest request2 = new AnnotateImageRequest
            {
                Image = image2,
                Features = { new Feature { Type = Feature.Types.Type.LogoDetection } }
            };

            BatchAnnotateImagesResponse response = client.BatchAnnotateImages(new[] { request1, request2 });
            Console.WriteLine("Faces in image 1:");
            foreach (FaceAnnotation face in response.Responses[0].FaceAnnotations)
            {
                Console.WriteLine($"  Confidence: {(int)(face.DetectionConfidence * 100)}%; BoundingPoly: {face.BoundingPoly}");
            }
            Console.WriteLine("Logos in image 2:");
            foreach (EntityAnnotation logo in response.Responses[1].LogoAnnotations)
            {
                Console.WriteLine($"Description: {logo.Description}");
            }
            foreach (Status error in response.Responses.Select(r => r.Error))
            {
                Console.WriteLine($"Error detected: error");
            }
            // End snippet

            Assert.Equal(3, response.Responses[0].FaceAnnotations.Count);
            Assert.Equal(1, response.Responses[1].LogoAnnotations.Count);
        }

        [Fact]
        public void DetectFaces()
        {
            Image image = LoadResourceImage("SchmidtBrinPage.jpg");
            // Snippet: DetectFaces
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            AnnotationResult<FaceAnnotation> result = client.DetectFaces(image);
            foreach (FaceAnnotation face in result)
            {
                Console.WriteLine($"Confidence: {(int)(face.DetectionConfidence * 100)}%; BoundingPoly: {face.BoundingPoly}");
            }
            if (result.Error != null)
            {
                Console.WriteLine($"Additional error detected: {result.Error}");
            }
            // End snippet

            Assert.Equal(3, result.Count);

            // Check the bounding boxes of the faces, with a tolerance of 5px on each edge.
            var rectangles = result.Select(x => Rectangle.FromBoundingPoly(x.BoundingPoly)).ToList();
            Assert.True(rectangles.All(x => x != null));
            rectangles = rectangles.OrderBy(r => r.Left).ToList();
            Assert.True(rectangles[0].Equals(new Rectangle(196, 64, 293, 177), 5.0));
            Assert.True(rectangles[1].Equals(new Rectangle(721, 162, 846, 308), 5.0));
            Assert.True(rectangles[2].Equals(new Rectangle(1009, 113, 1149, 276), 5.0));
        }

        [Fact]
        public void DetectLandmarks()
        {
            Image image = LoadResourceImage("SydneyOperaHouse.jpg");
            // Snippet: DetectLandmarks
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            AnnotationResult<EntityAnnotation> result = client.DetectLandmarks(image);
            foreach (EntityAnnotation landmark in result)
            {
                Console.WriteLine($"Score: {(int)(landmark.Score * 100)}%; Description: {landmark.Description}");
            }
            if (result.Error != null)
            {
                Console.WriteLine($"Additional error detected: {result.Error}");
            }
            // End snippet

            Assert.Equal(2, result.Count);
            var descriptions = result.Select(r => r.Description).OrderBy(d => d).ToList();
            Assert.Equal(new[] { "Sydney Harbour Bridge", "Sydney Opera House" }, descriptions);
        }

        [Fact]
        public void DetectImageProperties()
        {
            Image image = LoadResourceImage("SchmidtBrinPage.jpg");
            // Snippet: DetectImageProperties
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            ImageProperties properties = client.DetectImageProperties(image);
            ColorInfo dominantColor = properties.DominantColors.Colors.OrderByDescending(c => c.PixelFraction).First();
            Console.WriteLine($"Dominant color in image: {dominantColor}");
            // End snippet

            Assert.Equal(0.18, dominantColor.PixelFraction, 2);
            Assert.Equal(new Color { Red = 16, Green = 13, Blue = 8 }, dominantColor.Color);
        }

        [Fact]
        public void DetectLabels()
        {
            Image image = LoadResourceImage("Gladiolos.jpg");
            // Snippet: DetectLabels
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            AnnotationResult<EntityAnnotation> labels = client.DetectLabels(image);
            foreach (EntityAnnotation label in labels)
            {
                Console.WriteLine($"Score: {(int)(label.Score * 100)}%; Description: {label.Description}");
            }
            // End snippet

            // Not exhaustive, but let's check certain basic labels.
            var descriptions = labels.Select(l => l.Description).ToList();
            Assert.Contains("flower", descriptions);
            Assert.Contains("plant", descriptions);
            Assert.Contains("vase", descriptions);
        }

        [Fact]
        public void DetectText()
        {
            Image image = LoadResourceImage("Ellesborough.png");
            // Snippet: DetectText
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            AnnotationResult<EntityAnnotation> textAnnotations = client.DetectText(image);
            foreach (EntityAnnotation text in textAnnotations)
            {
                Console.WriteLine($"Description: {text.Description}");
            }
            // End snippet

            var descriptions = textAnnotations.Select(t => t.Description).ToList();
            Assert.Contains("Ellesborough", descriptions);
        }

        [Fact]
        public void DetectSafeSearch()
        {
            Image image = LoadResourceImage("SchmidtBrinPage.jpg");
            // Snippet: DetectSafeSearch
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            SafeSearchAnnotation annotation = client.DetectSafeSearch(image);
            // Each category is classified as Very Unlikely, Unlikely, Possible, Likely or Very Likely.
            Console.WriteLine($"Adult? {annotation.Adult}");
            Console.WriteLine($"Spoof? {annotation.Spoof}");
            Console.WriteLine($"Violence? {annotation.Violence}");
            Console.WriteLine($"Medical? {annotation.Medical}");
            // End snippet
            Assert.InRange(annotation.Adult, Likelihood.VeryUnlikely, Likelihood.Unlikely);
            Assert.InRange(annotation.Spoof, Likelihood.VeryUnlikely, Likelihood.Unlikely);
            Assert.InRange(annotation.Violence, Likelihood.VeryUnlikely, Likelihood.Unlikely);
            Assert.InRange(annotation.Medical, Likelihood.VeryUnlikely, Likelihood.Unlikely);
        }

        [Fact]
        public void DetectLogos()
        {
            Image image = LoadResourceImage("Chrome.png");
            // Snippet: DetectLogos
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            AnnotationResult<EntityAnnotation> logos = client.DetectLogos(image);
            foreach (EntityAnnotation logo in logos)
            {
                Console.WriteLine($"Description: {logo.Description}");
            }
            // End snippet
            Assert.Equal(1, logos.Count);
            Assert.Equal("Google Chrome", logos[0].Description);
        }

        private static Image LoadResourceImage(string name)
        {
            var type = typeof(ImageAnnotatorClientSnippets);
            using (var stream = type.Assembly.GetManifestResourceStream($"{type.Namespace}.{name}"))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
