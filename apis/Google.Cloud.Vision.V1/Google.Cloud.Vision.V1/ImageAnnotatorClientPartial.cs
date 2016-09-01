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
using Google.Protobuf.Collections;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Vision.V1
{
    public partial class ImageAnnotatorClient
    {
        // TODO: Async Detect* overloads accepting a CancellationToken? Can't be the last parameter, as it's not optional...
        // TODO: Revisit error handling once we know what the semantics are.

        /// <summary>
        /// Detects the faces in a single image.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A set of annotations.</returns>
        public AnnotationResult<FaceAnnotation> DetectFaces(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureType(Feature.Types.Type.FaceDetection, r => r.FaceAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects the faces in a single image asynchronously.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A task representing the asynchronous operation. The task result will be a set of annotations.</returns>
        public Task<AnnotationResult<FaceAnnotation>> DetectFacesAsync(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureTypeAsync(Feature.Types.Type.FaceDetection, r => r.FaceAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects labels for a single image.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A set of annotations.</returns>
        public AnnotationResult<EntityAnnotation> DetectLabels(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureType(Feature.Types.Type.LabelDetection, r => r.LabelAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects labels for a single image asynchronously.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A task representing the asynchronous operation. The task result will be a set of annotations.</returns>
        public Task<AnnotationResult<EntityAnnotation>> DetectLabelsAsync(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureTypeAsync(Feature.Types.Type.LabelDetection, r => r.LabelAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects landmarks in a single image.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A set of annotations.</returns>
        public AnnotationResult<EntityAnnotation> DetectLandmarks(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureType(Feature.Types.Type.LandmarkDetection, r => r.LandmarkAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects the landmarks in a single image asynchronously.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A task representing the asynchronous operation. The task result will be a set of annotations.</returns>
        public Task<AnnotationResult<EntityAnnotation>> DetectLandmarksAsync(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureTypeAsync(Feature.Types.Type.LandmarkDetection, r => r.LandmarkAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects logos in a single image.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A set of annotations.</returns>
        public AnnotationResult<EntityAnnotation> DetectLogos(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureType(Feature.Types.Type.LogoDetection, r => r.LogoAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects logos in a single image asynchronously.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A task representing the asynchronous operation. The task result will be a set of annotations.</returns>
        public Task<AnnotationResult<EntityAnnotation>> DetectLogosAsync(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureTypeAsync(Feature.Types.Type.LogoDetection, r => r.LogoAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects text in a single image.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A set of annotations.</returns>
        public AnnotationResult<EntityAnnotation> DetectText(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureType(Feature.Types.Type.TextDetection, r => r.TextAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects text in a single image asynchronously.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A task representing the asynchronous operation. The task result will be a set of annotations.</returns>
        public Task<AnnotationResult<EntityAnnotation>> DetectTextAsync(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureTypeAsync(Feature.Types.Type.TextDetection, r => r.TextAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Performs "safe search" processing on a single image.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>The safe search categorization for the image.</returns>
        public SafeSearchAnnotation DetectSafeSearch(Image image, ImageContext context = null, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(image, nameof(image));
            var request = new AnnotateImageRequest
            {
                Image = image,
                ImageContext = context,
                Features = { new Feature { Type = Feature.Types.Type.SafeSearchDetection } }
            };
            var response = Annotate(request, callSettings);
            // FIXME: Handle errors
            return response.SafeSearchAnnotation;
        }

        /// <summary>
        /// Performs "safe search" processing on a single image asynchronously.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A task representing the asynchronous operation. The task result will be the safe search categorization for the image.</returns>
        public async Task<SafeSearchAnnotation> DetectSafeSearchAsync(Image image, ImageContext context = null, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(image, nameof(image));
            var request = new AnnotateImageRequest
            {
                Image = image,
                ImageContext = context,
                Features = { new Feature { Type = Feature.Types.Type.SafeSearchDetection } }
            };
            var response = await AnnotateAsync(request, callSettings).ConfigureAwait(false);
            // FIXME: Handle errors
            return response.SafeSearchAnnotation;
        }

        /// <summary>
        /// Performs image property processing on a single image.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>The detected properties for the image.</returns>
        public ImageProperties DetectImageProperties(Image image, ImageContext context = null, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(image, nameof(image));
            var request = new AnnotateImageRequest
            {
                Image = image,
                ImageContext = context,
                Features = { new Feature { Type = Feature.Types.Type.ImageProperties } }
            };
            var response = Annotate(request, callSettings);
            // FIXME: Handle errors
            return response.ImagePropertiesAnnotation;
        }

        /// <summary>
        /// Performs image property processing on a single image asynchronously.
        /// </summary>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A task representing the asynchronous operation. The task result will be the detected properties for the image.</returns>
        public async Task<ImageProperties> DetectImagePropertiesAsync(Image image, ImageContext context = null, CallSettings callSettings = null)
        {
            GaxPreconditions.CheckNotNull(image, nameof(image));
            var request = new AnnotateImageRequest
            {
                Image = image,
                ImageContext = context,
                Features = { new Feature { Type = Feature.Types.Type.ImageProperties } }
            };
            var response = await AnnotateAsync(request, callSettings).ConfigureAwait(false);
            // FIXME: Handle errors
            return response.ImagePropertiesAnnotation;
        }

        /// <summary>
        /// Annotates a single image.
        /// </summary>
        /// <remarks>This simply delegates to <see cref="BatchAnnotateImages(System.Collections.Generic.IEnumerable{AnnotateImageRequest}, CallSettings)"/>
        /// by creating a batch with a single request, and returns the single response.</remarks>
        /// <param name="request">The annotation request to process. Must not be null.</param>
        /// <param name="settings">Call settings to apply to the RPC, if any.</param>
        /// <returns>The annotation response.</returns>
        public AnnotateImageResponse Annotate(AnnotateImageRequest request, CallSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            var batchResponse = BatchAnnotateImages(new[] { request }, settings);
            return batchResponse.Responses[0];
        }

        /// <summary>
        /// Annotates a single image asynchronously.
        /// </summary>
        /// <remarks>This simply delegates to <see cref="BatchAnnotateImagesAsync(System.Collections.Generic.IEnumerable{AnnotateImageRequest}, CallSettings)"/>
        /// by creating a batch with a single request, and returns the single response.</remarks>
        /// <param name="request">The annotation request to process. Must not be null.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A task representing the asynchronous operation. The task result will be the annotation response.</returns>
        public Task<AnnotateImageResponse> AnnotateAsync(AnnotateImageRequest request, CancellationToken cancellationToken)
            => AnnotateAsync(request, new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Annotates a single image asynchronously.
        /// </summary>
        /// <remarks>This simply delegates to <see cref="BatchAnnotateImagesAsync(System.Collections.Generic.IEnumerable{AnnotateImageRequest}, CallSettings)"/>
        /// by creating a batch with a single request, and returns the single response.</remarks>
        /// <param name="request">The annotation request to process. Must not be null.</param>
        /// <param name="settings">Call settings to apply to the RPC, if any.</param>
        /// <returns>A task representing the asynchronous operation. The task result will be the annotation response.</returns>
        public async Task<AnnotateImageResponse> AnnotateAsync(AnnotateImageRequest request, CallSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            var batchResponse = await BatchAnnotateImagesAsync(new[] { request }, settings).ConfigureAwait(false);
            return batchResponse.Responses[0];
        }

        private AnnotationResult<T> AnnotateSingleFeatureType<T>(
            Feature.Types.Type featureType,
            Func<AnnotateImageResponse, RepeatedField<T>> annotationExtractor,
            Image image,
            ImageContext context,
            int maxResults,
            CallSettings callSettings)
        {
            GaxPreconditions.CheckNotNull(image, nameof(image));
            GaxPreconditions.CheckArgumentRange(maxResults, nameof(maxResults), 0, int.MaxValue);
            var request = new AnnotateImageRequest
            {
                Image = image,
                ImageContext = context,
                Features = { new Feature { Type = featureType, MaxResults = maxResults } }
            };
            var response = Annotate(request, callSettings);
            return new AnnotationResult<T>(response.Error, annotationExtractor(response));
        }

        private async Task<AnnotationResult<T>> AnnotateSingleFeatureTypeAsync<T>(
            Feature.Types.Type featureType,
            Func<AnnotateImageResponse, RepeatedField<T>> annotationExtractor,
            Image image,
            ImageContext context,
            int maxResults,
            CallSettings callSettings)
        {
            GaxPreconditions.CheckNotNull(image, nameof(image));
            GaxPreconditions.CheckArgumentRange(maxResults, nameof(maxResults), 0, int.MaxValue);
            var request = new AnnotateImageRequest
            {
                Image = image,
                ImageContext = context,
                Features = { new Feature { Type = featureType, MaxResults = maxResults } }
            };
            var response = await AnnotateAsync(request, callSettings).ConfigureAwait(false);
            return new AnnotationResult<T>(response.Error, annotationExtractor(response));
        }
    }
}
