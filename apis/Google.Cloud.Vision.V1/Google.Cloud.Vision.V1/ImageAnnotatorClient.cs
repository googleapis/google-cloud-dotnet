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

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Vision.V1
{

    /// <summary>
    /// Extension methods to assist with using <see cref="ImageAnnotatorClient"/>.
    /// </summary>
    public static partial class ImageAnnotatorExtensions
    {
        /// <summary>
        /// Wrap a GRPC ImageAnnotator client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="ImageAnnotatorSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="ImageAnnotatorClient"/> that wraps the specified GRPC client.</returns>
        public static ImageAnnotatorClient ToClient(
            this ImageAnnotator.ImageAnnotatorClient grpcClient,
            ImageAnnotatorSettings settings = null
        ) => new ImageAnnotatorClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a ImageAnnotator wrapper.
    /// </summary>
    public sealed partial class ImageAnnotatorSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ImageAnnotatorSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default ImageAnnotatorSettings.</returns>
        public static ImageAnnotatorSettings GetDefault() => new ImageAnnotatorSettings();

        /// <summary>
        /// Constructs a new ImageAnnotatorSettings object with default settings.
        /// </summary>
        public ImageAnnotatorSettings() { }

        private ImageAnnotatorSettings(ImageAnnotatorSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            BatchAnnotateImagesSettings = existing.BatchAnnotateImagesSettings?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ImageAnnotatorClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="ImageAnnotatorClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ImageAnnotatorClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" retry backoff for <see cref="ImageAnnotatorClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ImageAnnotatorClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.3,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// "Default" timeout backoff for <see cref="ImageAnnotatorClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="ImageAnnotatorClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ImageAnnotatorClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(60000),
            DelayMultiplier = 1.0,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="ImageAnnotatorClient.BatchAnnotateImages"/> and <see cref="ImageAnnotatorClient.BatchAnnotateImagesAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="ImageAnnotatorClient.BatchAnnotateImages"/> and
        /// <see cref="ImageAnnotatorClient.BatchAnnotateImagesAsync"/> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings BatchAnnotateImagesSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of ImageAnnotator settings.</returns>
        public ImageAnnotatorSettings Clone() => new ImageAnnotatorSettings(this);
    }

    /// <summary>
    /// ImageAnnotator client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ImageAnnotatorClient
    {
        /// <summary>
        /// The default endpoint for the ImageAnnotator service, which is a host of "vision.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("vision.googleapis.com", 443);

        /// <summary>
        /// The default ImageAnnotator scopes
        /// </summary>
        /// <remarks>
        /// The default ImageAnnotator scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="ImageAnnotatorClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ImageAnnotatorSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ImageAnnotatorClient"/>.</returns>
        public static async Task<ImageAnnotatorClient> CreateAsync(ServiceEndpoint endpoint = null, ImageAnnotatorSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ImageAnnotatorClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ImageAnnotatorSettings"/>.</param>
        /// <returns>The created <see cref="ImageAnnotatorClient"/>.</returns>
        public static ImageAnnotatorClient Create(ServiceEndpoint endpoint = null, ImageAnnotatorSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ImageAnnotatorClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ImageAnnotatorSettings"/>.</param>
        /// <returns>The created <see cref="ImageAnnotatorClient"/>.</returns>
        public static ImageAnnotatorClient Create(Channel channel, ImageAnnotatorSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            ImageAnnotator.ImageAnnotatorClient grpcClient = new ImageAnnotator.ImageAnnotatorClient(channel);
            return new ImageAnnotatorClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, ImageAnnotatorSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ImageAnnotatorSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, ImageAnnotatorSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, ImageAnnotatorSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying GRPC ImageAnnotator client.
        /// </summary>
        public virtual ImageAnnotator.ImageAnnotatorClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="requests">Individual image annotation requests for this batch.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(
            IEnumerable<AnnotateImageRequest> requests,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="requests">Individual image annotation requests for this batch.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(
            IEnumerable<AnnotateImageRequest> requests,
            CancellationToken cancellationToken) => BatchAnnotateImagesAsync(
                requests,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="requests">Individual image annotation requests for this batch.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchAnnotateImagesResponse BatchAnnotateImages(
            IEnumerable<AnnotateImageRequest> requests,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class ImageAnnotatorClientImpl : ImageAnnotatorClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<BatchAnnotateImagesRequest, BatchAnnotateImagesResponse> _callBatchAnnotateImages;

        public ImageAnnotatorClientImpl(ImageAnnotator.ImageAnnotatorClient grpcClient, ImageAnnotatorSettings settings)
        {
            this.GrpcClient = grpcClient;
            ImageAnnotatorSettings effectiveSettings = settings ?? ImageAnnotatorSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callBatchAnnotateImages = _clientHelper.BuildApiCall<BatchAnnotateImagesRequest, BatchAnnotateImagesResponse>(
                GrpcClient.BatchAnnotateImagesAsync, GrpcClient.BatchAnnotateImages, effectiveSettings.BatchAnnotateImagesSettings);
        }

        public override ImageAnnotator.ImageAnnotatorClient GrpcClient { get; }

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="requests">Individual image annotation requests for this batch.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<BatchAnnotateImagesResponse> BatchAnnotateImagesAsync(
            IEnumerable<AnnotateImageRequest> requests,
            CallSettings callSettings = null) => _callBatchAnnotateImages.Async(
                new BatchAnnotateImagesRequest
                {
                    Requests = { requests },
                },
                callSettings);

        /// <summary>
        /// Run image detection and annotation for a batch of images.
        /// </summary>
        /// <param name="requests">Individual image annotation requests for this batch.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchAnnotateImagesResponse BatchAnnotateImages(
            IEnumerable<AnnotateImageRequest> requests,
            CallSettings callSettings = null) => _callBatchAnnotateImages.Sync(
                new BatchAnnotateImagesRequest
                {
                    Requests = { requests },
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

}