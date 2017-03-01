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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FeatureType = Google.Cloud.Vision.V1.Feature.Types.Type;

namespace Google.Cloud.Vision.V1.Tests
{
    /// <summary>
    /// Fake annotator used for testing.
    /// Only the RPC methods are overridden, so this is *effectively* faking out the server.
    /// The implementation expects the "image" content to actually be a protobuf AnnotateImageResponse
    /// with all relevant fields filled in; it then examines the request to find out which aspects
    /// were requested (faces, text etc).
    /// </summary>
    public class FakeImageAnnotator : ImageAnnotatorClient
    {
        public override BatchAnnotateImagesResponse BatchAnnotateImages(IEnumerable<AnnotateImageRequest> requests, CallSettings callSettings = null)
            => new BatchAnnotateImagesResponse { Responses = { requests.Select(r => ProcessRequest(r)) } };

        public override Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(IEnumerable<AnnotateImageRequest> requests, CallSettings callSettings = null)
            => Task.FromResult(BatchAnnotateImages(requests, callSettings));

        private static AnnotateImageResponse ProcessRequest(AnnotateImageRequest request)
        {
            var fullResponse = AnnotateImageResponse.Parser.ParseFrom(request.Image.Content);
            var actualResponse = new AnnotateImageResponse { Error = fullResponse.Error };
            AddRepeatedFeatures(request, fullResponse, actualResponse, FeatureType.FaceDetection, r => r.FaceAnnotations);
            AddRepeatedFeatures(request, fullResponse, actualResponse, FeatureType.LabelDetection, r => r.LabelAnnotations);
            AddRepeatedFeatures(request, fullResponse, actualResponse, FeatureType.LandmarkDetection, r => r.LandmarkAnnotations);
            AddRepeatedFeatures(request, fullResponse, actualResponse, FeatureType.LogoDetection, r => r.LogoAnnotations);
            AddRepeatedFeatures(request, fullResponse, actualResponse, FeatureType.TextDetection, r => r.TextAnnotations);
            AddSingularFeature(request, fullResponse, actualResponse, FeatureType.CropHints, r => r.CropHintsAnnotation, (r, v) => r.CropHintsAnnotation = v);
            AddSingularFeature(request, fullResponse, actualResponse, FeatureType.WebDetection, r => r.WebDetection, (r, v) => r.WebDetection = v);
            AddSingularFeature(request, fullResponse, actualResponse, FeatureType.DocumentTextDetection, r => r.FullTextAnnotation, (r, v) => r.FullTextAnnotation = v);
            AddSingularFeature(request, fullResponse, actualResponse, FeatureType.SafeSearchDetection, r => r.SafeSearchAnnotation, (r, v) => r.SafeSearchAnnotation = v);
            AddSingularFeature(request, fullResponse, actualResponse, FeatureType.ImageProperties, r => r.ImagePropertiesAnnotation, (r, v) => r.ImagePropertiesAnnotation = v);
            return actualResponse;
        }

        private static void AddRepeatedFeatures<T>(
            AnnotateImageRequest request,
            AnnotateImageResponse fullResponse,
            AnnotateImageResponse actualResponse,
            FeatureType featureType,
            Func<AnnotateImageResponse, RepeatedField<T>> extractor)
        {
            var featureRequest = request.Features.Where(f => f.Type == featureType).FirstOrDefault();
            if (featureRequest == null)
            {
                return;
            }
            var maxEntries = featureRequest.MaxResults == 0 ? int.MaxValue : featureRequest.MaxResults;
            extractor(actualResponse).AddRange(extractor(fullResponse).Take(maxEntries));
        }

        private static void AddSingularFeature<T>(
            AnnotateImageRequest request,
            AnnotateImageResponse fullResponse,
            AnnotateImageResponse actualResponse,
            FeatureType featureType,
            Func<AnnotateImageResponse, T> extractor,
            Action<AnnotateImageResponse, T> assigner)
        {
            if (request.Features.Any(f => f.Type == featureType))
            {
                assigner(actualResponse, extractor(fullResponse));
            }
        }
    }
}
