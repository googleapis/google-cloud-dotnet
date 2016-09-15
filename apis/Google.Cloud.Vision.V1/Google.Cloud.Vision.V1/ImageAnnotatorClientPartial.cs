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
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Vision.V1
{
    public partial class ImageAnnotatorClient
    {
        // TODO: Async Detect* overloads accepting a CancellationToken? Can't be the last parameter, as it's not optional...

        /// <summary>
        /// Detects the faces in a single image.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>A set of annotations.</returns>
        public IReadOnlyList<FaceAnnotation> DetectFaces(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureType(Feature.Types.Type.FaceDetection, r => r.FaceAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects the faces in a single image asynchronously.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>A task representing the asynchronous operation. The task result will be a set of annotations.</returns>
        public Task<IReadOnlyList<FaceAnnotation>> DetectFacesAsync(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureTypeAsync(Feature.Types.Type.FaceDetection, r => r.FaceAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects labels for a single image.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>A set of annotations.</returns>
        public IReadOnlyList<EntityAnnotation> DetectLabels(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureType(Feature.Types.Type.LabelDetection, r => r.LabelAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects labels for a single image asynchronously.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>A task representing the asynchronous operation. The task result will be a set of annotations.</returns>
        public Task<IReadOnlyList<EntityAnnotation>> DetectLabelsAsync(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureTypeAsync(Feature.Types.Type.LabelDetection, r => r.LabelAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects landmarks in a single image.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>A set of annotations.</returns>
        public IReadOnlyList<EntityAnnotation> DetectLandmarks(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureType(Feature.Types.Type.LandmarkDetection, r => r.LandmarkAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects the landmarks in a single image asynchronously.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>A task representing the asynchronous operation. The task result will be a set of annotations.</returns>
        public Task<IReadOnlyList<EntityAnnotation>> DetectLandmarksAsync(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureTypeAsync(Feature.Types.Type.LandmarkDetection, r => r.LandmarkAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects logos in a single image.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>A set of annotations.</returns>
        public IReadOnlyList<EntityAnnotation> DetectLogos(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureType(Feature.Types.Type.LogoDetection, r => r.LogoAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects logos in a single image asynchronously.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>A task representing the asynchronous operation. The task result will be a set of annotations.</returns>
        public Task<IReadOnlyList<EntityAnnotation>> DetectLogosAsync(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureTypeAsync(Feature.Types.Type.LogoDetection, r => r.LogoAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects text in a single image.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>A set of annotations.</returns>
        public IReadOnlyList<EntityAnnotation> DetectText(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureType(Feature.Types.Type.TextDetection, r => r.TextAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Detects text in a single image asynchronously.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>A task representing the asynchronous operation. The task result will be a set of annotations.</returns>
        public Task<IReadOnlyList<EntityAnnotation>> DetectTextAsync(Image image, ImageContext context = null, int maxResults = 0, CallSettings callSettings = null)
            => AnnotateSingleFeatureTypeAsync(Feature.Types.Type.TextDetection, r => r.TextAnnotations, image, context, maxResults, callSettings);

        /// <summary>
        /// Performs "safe search" processing on a single image.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
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
            return response.SafeSearchAnnotation;
        }

        /// <summary>
        /// Performs "safe search" processing on a single image asynchronously.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
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
            return response.SafeSearchAnnotation;
        }

        /// <summary>
        /// Performs image property processing on a single image.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
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
            return response.ImagePropertiesAnnotation;
        }

        /// <summary>
        /// Performs image property processing on a single image asynchronously.
        /// </summary>
        /// <remarks>
        /// If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </remarks>
        /// <param name="image">The image to process. Must not be null.</param>
        /// <param name="context">Additional contextual information, if any.</param>
        /// <param name="maxResults">The maximum number of results to return. 0 (the default) means "unlimited". Must not be negative.</param>
        /// <param name="callSettings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
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
            return response.ImagePropertiesAnnotation;
        }

        /// <summary>
        /// Annotates a single image.
        /// </summary>
        /// <remarks>
        /// <para>This simply delegates to <see cref="BatchAnnotateImages(System.Collections.Generic.IEnumerable{AnnotateImageRequest}, CallSettings)"/>
        /// by creating a batch with a single request, and returns the single response.</para>
        /// <para>If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.
        /// </para>
        /// </remarks>
        /// <param name="request">The annotation request to process. Must not be null.</param>
        /// <param name="settings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>The annotation response.</returns>
        public AnnotateImageResponse Annotate(AnnotateImageRequest request, CallSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            var batchResponse = BatchAnnotateImages(new[] { request }, settings);
            return batchResponse.Responses[0].ThrowOnError();
        }

        /// <summary>
        /// Annotates a single image asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>This simply delegates to <see cref="BatchAnnotateImagesAsync(System.Collections.Generic.IEnumerable{AnnotateImageRequest}, CallSettings)"/>
        /// by creating a batch with a single request, and returns the single response.</para>
        /// <para>If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.</para>
        /// </remarks>
        /// <param name="request">The annotation request to process. Must not be null.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>A task representing the asynchronous operation. The task result will be the annotation response.</returns>
        public Task<AnnotateImageResponse> AnnotateAsync(AnnotateImageRequest request, CancellationToken cancellationToken)
            => AnnotateAsync(request, new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Annotates a single image asynchronously.
        /// </summary>
        /// <remarks>
        /// <para>This simply delegates to <see cref="BatchAnnotateImagesAsync(System.Collections.Generic.IEnumerable{AnnotateImageRequest}, CallSettings)"/>
        /// by creating a batch with a single request, and returns the single response.</para>
        /// <para>If <see cref="AnnotateImageException"/> is thrown, the original response can still be retrieved using
        /// <see cref="AnnotateImageException.Response"/>.</para>
        /// </remarks>
        /// <param name="request">The annotation request to process. Must not be null.</param>
        /// <param name="settings">Call settings to apply to the RPC, if any.</param>
        /// <exception cref="AnnotateImageException">The RPC returns a response, but the response contains an error.</exception>
        /// <returns>A task representing the asynchronous operation. The task result will be the annotation response.</returns>
        public async Task<AnnotateImageResponse> AnnotateAsync(AnnotateImageRequest request, CallSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(request, nameof(request));
            var batchResponse = await BatchAnnotateImagesAsync(new[] { request }, settings).ConfigureAwait(false);
            return batchResponse.Responses[0].ThrowOnError();
        }

        private IReadOnlyList<T> AnnotateSingleFeatureType<T>(
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
            // This will throw on error.
            var response = Annotate(request, callSettings);
            return new RepeatedFieldWrapper<T>(annotationExtractor(response));
        }

        private async Task<IReadOnlyList<T>> AnnotateSingleFeatureTypeAsync<T>(
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
            // This will throw on error.
            var response = await AnnotateAsync(request, callSettings).ConfigureAwait(false);
            return new RepeatedFieldWrapper<T>(annotationExtractor(response));
        }
    }
}
