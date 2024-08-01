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

using Google.Cloud.ClientTesting;
using Google.Rpc;
using Google.Type;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Xunit;

namespace Google.Cloud.Vision.V1.Snippets
{
    [SnippetOutputCollector]
    [Collection(nameof(VisionFixture))]
    public class ImageAnnotatorClientSnippets
    {
        private readonly VisionFixture _fixture;

        public ImageAnnotatorClientSnippets(VisionFixture fixture) =>
            _fixture = fixture;

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
                string poly = string.Join(" - ", face.BoundingPoly.Vertices.Select(v => $"({v.X}, {v.Y})"));
                Console.WriteLine($"  Confidence: {(int)(face.DetectionConfidence * 100)}%; BoundingPoly: {poly}");
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

        // See-also: Annotate(*, *)
        // Member: AnnotateAsync(*, CallSettings)
        // Member: AnnotateAsync(*, CancellationToken)
        // See [Annotate](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void BatchAnnotateImages()
        {
            Image image1 = LoadResourceImage("SchmidtBrinPage.jpg");
            Image image2 = LoadResourceImage("Chrome.png");
            // Sample: BatchAnnotateImages
            // Additional: BatchAnnotateImages(IEnumerable<AnnotateImageRequest>,*)
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
                string poly = string.Join(" - ", face.BoundingPoly.Vertices.Select(v => $"({v.X}, {v.Y})"));
                Console.WriteLine($"  Confidence: {(int)(face.DetectionConfidence * 100)}%; BoundingPoly: {poly}");
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
            // End sample

            Assert.Equal(3, response.Responses[0].FaceAnnotations.Count);
            Assert.Equal(1, response.Responses[1].LogoAnnotations.Count);
        }

        [Fact]
        public void DetectFaces()
        {
            Image image = LoadResourceImage("SchmidtBrinPage.jpg");
            // Snippet: DetectFaces
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            IReadOnlyList<FaceAnnotation> result = client.DetectFaces(image);
            foreach (FaceAnnotation face in result)
            {
                string poly = string.Join(" - ", face.BoundingPoly.Vertices.Select(v => $"({v.X}, {v.Y})"));
                Console.WriteLine($"Confidence: {(int)(face.DetectionConfidence * 100)}%; BoundingPoly: {poly}");
            }
            // End snippet

            Assert.Equal(3, result.Count);

            var rectangles = result.Select(x => Rectangle.FromBoundingPoly(x.BoundingPoly)).ToList();
            Assert.True(rectangles.All(x => x != null));
        }

        // See-also: DetectFaces(*, *, *, *)
        // Member: DetectFacesAsync(*, *, *, *)
        // See [DetectFaces](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DetectLandmarks()
        {
            Image image = LoadResourceImage("vision_eiffel_tower.jpg");
            // Snippet: DetectLandmarks
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            IReadOnlyList<EntityAnnotation> result = client.DetectLandmarks(image);
            foreach (EntityAnnotation landmark in result)
            {
                Console.WriteLine($"Score: {(int)(landmark.Score * 100)}%; Description: {landmark.Description}");
            }
            // End snippet

            Assert.InRange(result.Count, 1, 10);
            var descriptions = result.Select(r => r.Description).ToList();
            Assert.Contains("Eiffel Tower", descriptions);
        }

        // See-also: DetectLandmarks(*, *, *, *)
        // Member: DetectLandmarksAsync(*, *, *, *)
        // See [DetectLandmarks](ref) for a synchronous example.
        // End see-also

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

        // See-also: DetectImageProperties(*, *, *)
        // Member: DetectImagePropertiesAsync(*, *, *)
        // See [DetectImageProperties](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DetectLabels()
        {
            Image image = LoadResourceImage("Gladiolos.jpg");
            // Snippet: DetectLabels
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            IReadOnlyList<EntityAnnotation> labels = client.DetectLabels(image);
            foreach (EntityAnnotation label in labels)
            {
                Console.WriteLine($"Score: {(int)(label.Score * 100)}%; Description: {label.Description}");
            }
            // End snippet

            // Not exhaustive, but let's check certain basic labels.
            var descriptions = labels.Select(l => l.Description).ToList();
            Assert.Contains("flower", descriptions, StringComparer.OrdinalIgnoreCase);
            Assert.Contains("petal", descriptions, StringComparer.OrdinalIgnoreCase);
            Assert.Contains("vase", descriptions, StringComparer.OrdinalIgnoreCase);
        }

        // See-also: DetectLabels(*, *, *, *)
        // Member: DetectLabelsAsync(*, *, *, *)
        // See [DetectLabels](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DetectText()
        {
            Image image = LoadResourceImage("Ellesborough.png");
            // Snippet: DetectText
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            IReadOnlyList<EntityAnnotation> textAnnotations = client.DetectText(image);
            foreach (EntityAnnotation text in textAnnotations)
            {
                Console.WriteLine($"Description: {text.Description}");
            }
            // End snippet

            var descriptions = textAnnotations.Select(t => t.Description).ToList();
            Assert.Contains("Ellesborough", descriptions);
        }

        // See-also: DetectText(*, *, *, *)
        // Member: DetectTextAsync(*, *, *, *)
        // See [DetectText](ref) for a synchronous example.
        // End see-also

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

        // See-also: DetectSafeSearch(*, *, *)
        // Member: DetectSafeSearchAsync(*, *, *)
        // See [DetectSafeSearch](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DetectLogos()
        {
            Image image = LoadResourceImage("Chrome.png");
            // Snippet: DetectLogos
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            IReadOnlyList<EntityAnnotation> logos = client.DetectLogos(image);
            foreach (EntityAnnotation logo in logos)
            {
                Console.WriteLine($"Description: {logo.Description}");
            }
            // End snippet
            Assert.Equal(1, logos.Count);
            Assert.Contains("chrome", logos[0].Description, StringComparison.OrdinalIgnoreCase);
        }

        // See-also: DetectLogos(*, *, *, *)
        // Member: DetectLogosAsync(*, *, *, *)
        // See [DetectLogos](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DetectCropHints()
        {
            Image image = LoadResourceImage("Gladiolos.jpg");
            // Snippet: DetectCropHints
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            CropHintsAnnotation cropHints = client.DetectCropHints(image);
            foreach (CropHint hint in cropHints.CropHints)
            {
                Console.WriteLine("Crop hint:");
                string poly = string.Join(" - ", hint.BoundingPoly.Vertices.Select(v => $"({v.X}, {v.Y})"));
                Console.WriteLine($"  Poly: {poly}");
                Console.WriteLine($"  Confidence: {hint.Confidence}");
                Console.WriteLine($"  Importance fraction: {hint.ImportanceFraction}");
            }
            // End snippet
            Assert.Equal(1, cropHints.CropHints.Count);
        }

        // See-also: DetectCropHints(*, *, *)
        // Member: DetectCropHintsAsync(*, *, *)
        // See [DetectCropHints](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DetectDocumentText()
        {
            Image image = LoadResourceImage("DocumentText.png");
            // Snippet: DetectDocumentText
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            TextAnnotation text = client.DetectDocumentText(image);
            Console.WriteLine($"Text: {text.Text}");
            foreach (var page in text.Pages)
            {
                foreach (var block in page.Blocks)
                {
                    string box = string.Join(" - ", block.BoundingBox.Vertices.Select(v => $"({v.X}, {v.Y})"));
                    Console.WriteLine($"Block {block.BlockType} at {box}");
                    foreach (var paragraph in block.Paragraphs)
                    {
                        box = string.Join(" - ", paragraph.BoundingBox.Vertices.Select(v => $"({v.X}, {v.Y})"));
                        Console.WriteLine($"  Paragraph at {box}");
                        foreach (var word in paragraph.Words)
                        {
                            Console.WriteLine($"    Word: {string.Join("", word.Symbols.Select(s => s.Text))}");
                        }
                    }
                }
            }
            // End snippet
            var lines = text.Pages[0].Blocks
                .Select(b => b.Paragraphs[0].Words.Select(w => string.Join("", w.Symbols.Select(s => s.Text))))
                .ToList();
            Assert.Equal(new[] { "Sample", "text", "line", "1", }, lines[0]);
            Assert.Equal(new[] { "Text", "near", "the", "middle", }, lines[1]);
            Assert.Equal(new[] { "Text", "near", "bottom", "right", }, lines[2]);
        }

        // See-also: DetectDocumentText(*, *, *)
        // Member: DetectDocumentTextAsync(*, *, *)
        // See [DetectDocumentText](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DetectWebInformation()
        {
            Image image = LoadResourceImage("SchmidtBrinPage.jpg");
            // Snippet: DetectWebInformation
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            WebDetection webDetection = client.DetectWebInformation(image);
            foreach (WebDetection.Types.WebImage webImage in webDetection.FullMatchingImages)
            {
                Console.WriteLine($"Full image: {webImage.Url} ({webImage.Score})");
            }
            foreach (WebDetection.Types.WebImage webImage in webDetection.PartialMatchingImages)
            {
                Console.WriteLine($"Partial image: {webImage.Url} ({webImage.Score})");
            }
            foreach (WebDetection.Types.WebPage webPage in webDetection.PagesWithMatchingImages)
            {
                Console.WriteLine($"Page with matching image: {webPage.Url} ({webPage.Score})");
            }
            foreach (WebDetection.Types.WebEntity entity in webDetection.WebEntities)
            {
                Console.WriteLine($"Web entity: {entity.EntityId} / {entity.Description} ({entity.Score})");
            }
            // End snippet
        }

        // See-also: DetectWebInformation(*, *, *)
        // Member: DetectWebInformationAsync(*, *, *)
        // See [DetectWebInformation](ref) for a synchronous example.
        // End see-also

        [Fact(Skip = "Flaky; see https://github.com/googleapis/google-cloud-dotnet/issues/3174")]
        public void DetectLocalizedObjects()
        {
            Image image = Image.FromUri("https://cloud.google.com/vision/docs/images/bicycle_example.png");
            // Snippet: DetectLocalizedObjects
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            IReadOnlyList<LocalizedObjectAnnotation> annotations = client.DetectLocalizedObjects(image);
            foreach (LocalizedObjectAnnotation annotation in annotations)
            {
                string poly = string.Join(" - ", annotation.BoundingPoly.NormalizedVertices.Select(v => $"({v.X}, {v.Y})"));
                Console.WriteLine(
                    $"Name: {annotation.Name}; ID: {annotation.Mid}; Score: {annotation.Score}; Bounding poly: {poly}");
            }
            // End snippet

            // We don't want to be too strict about what we get back here, but these should be okay.
            Assert.Contains(annotations, a => a.Name == "Bicycle");
            Assert.Contains(annotations, a => a.Name == "Picture frame");
        }

        // See-also: DetectLocalizedObjects(*, *, *, *)
        // Member: DetectLocalizedObjectsAsync(*, *, *, *)
        // See [DetectLocalizedObjects](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void ErrorHandling_SingleImage()
        {
            // Sample: ErrorHandling_SingleImage
            // We create a request which passes simple validation, but isn't a valid image.
            Image image = Image.FromBytes(new byte[10]);
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            try
            {
                IReadOnlyList<EntityAnnotation> logos = client.DetectLogos(image);
                // Normally use logos here...
            }
            catch (AnnotateImageException e)
            {
                AnnotateImageResponse response = e.Response;
                Console.WriteLine(response.Error);
            }
            // End sample
        }

        [Fact]
        public void DetectSimilarProducts()
        {
            Image image = LoadResourceImage("shoes_1.jpg");
            string projectId = _fixture.ProjectId;
            string locationId = "us-west1";
            string productSetId = $"{projectId}_product_search_test";

            // Sample: ProductSearch
            // Additional: DetectSimilarProducts(*, *, *)
            ProductSetName productSetName = new ProductSetName(projectId, locationId, productSetId);
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            ProductSearchParams searchParams = new ProductSearchParams
            {
                ProductCategories = { "apparel" },
                ProductSetAsProductSetName = productSetName,
            };
            ProductSearchResults results = client.DetectSimilarProducts(image, searchParams);
            foreach (var result in results.Results)
            {
                Console.WriteLine($"{result.Product.DisplayName}: {result.Score}");
            }
            // End sample
        }

        // See-also: DetectSimilarProducts(*, *, *)
        // Member: DetectSimilarProductsAsync(*, *, *)
        // See [DetectSimilarProducts](ref) for a synchronous example.
        // End see-also

        [Fact]
        public void DetectSimilarProducts_WithFilter()
        {
            Image image = LoadResourceImage("shoes_1.jpg");
            string projectId = _fixture.ProjectId;
            string locationId = "us-west1";
            string productSetId = $"{projectId}_product_search_test";

            // Sample: ProductSearchWithFilter
            ProductSetName productSetName = new ProductSetName(projectId, locationId, productSetId);
            ImageAnnotatorClient client = ImageAnnotatorClient.Create();
            ProductSearchParams searchParams = new ProductSearchParams
            {
                ProductCategories = { "apparel" },
                ProductSetAsProductSetName = productSetName,
                Filter = "style=womens"
            };
            ProductSearchResults results = client.DetectSimilarProducts(image, searchParams);
            foreach (var result in results.Results)
            {
                Console.WriteLine($"{result.Product.DisplayName}: {result.Score}");
            }
            // End sample
        }

        private static Image LoadResourceImage(string name)
        {
            var type = typeof(ImageAnnotatorClientSnippets);
            using (var stream = type.GetTypeInfo().Assembly.GetManifestResourceStream($"{type.Namespace}.{name}"))
            {
                return Image.FromStream(stream);
            }
        }
    }
}
