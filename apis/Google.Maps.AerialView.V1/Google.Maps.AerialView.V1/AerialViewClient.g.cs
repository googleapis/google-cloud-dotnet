// Copyright 2025 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Maps.AerialView.V1
{
    /// <summary>Settings for <see cref="AerialViewClient"/> instances.</summary>
    public sealed partial class AerialViewSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AerialViewSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AerialViewSettings"/>.</returns>
        public static AerialViewSettings GetDefault() => new AerialViewSettings();

        /// <summary>Constructs a new <see cref="AerialViewSettings"/> object with default settings.</summary>
        public AerialViewSettings()
        {
        }

        private AerialViewSettings(AerialViewSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RenderVideoSettings = existing.RenderVideoSettings;
            LookupVideoSettings = existing.LookupVideoSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AerialViewSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AerialViewClient.RenderVideo</c> and <c>AerialViewClient.RenderVideoAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RenderVideoSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AerialViewClient.LookupVideo</c> and <c>AerialViewClient.LookupVideoAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LookupVideoSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AerialViewSettings"/> object.</returns>
        public AerialViewSettings Clone() => new AerialViewSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AerialViewClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AerialViewClientBuilder : gaxgrpc::ClientBuilderBase<AerialViewClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AerialViewSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AerialViewClientBuilder() : base(AerialViewClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AerialViewClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AerialViewClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AerialViewClient Build()
        {
            AerialViewClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AerialViewClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AerialViewClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AerialViewClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AerialViewClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AerialViewClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AerialViewClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AerialViewClient.ChannelPool;
    }

    /// <summary>AerialView client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Aerial View API.
    /// </remarks>
    public abstract partial class AerialViewClient
    {
        /// <summary>
        /// The default endpoint for the AerialView service, which is a host of "aerialview.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aerialview.googleapis.com:443";

        /// <summary>The default AerialView scopes.</summary>
        /// <remarks>
        /// The default AerialView scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AerialView.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AerialViewClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AerialViewClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AerialViewClient"/>.</returns>
        public static stt::Task<AerialViewClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AerialViewClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AerialViewClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="AerialViewClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AerialViewClient"/>.</returns>
        public static AerialViewClient Create() => new AerialViewClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AerialViewClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AerialViewSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AerialViewClient"/>.</returns>
        internal static AerialViewClient Create(grpccore::CallInvoker callInvoker, AerialViewSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AerialView.AerialViewClient grpcClient = new AerialView.AerialViewClient(callInvoker);
            return new AerialViewClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC AerialView client</summary>
        public virtual AerialView.AerialViewClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an address to the renderer's queue if a video hasn't already been
        /// rendered. Otherwise, returns metadata about the video.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderVideoResponse RenderVideo(RenderVideoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an address to the renderer's queue if a video hasn't already been
        /// rendered. Otherwise, returns metadata about the video.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderVideoResponse> RenderVideoAsync(RenderVideoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds an address to the renderer's queue if a video hasn't already been
        /// rendered. Otherwise, returns metadata about the video.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderVideoResponse> RenderVideoAsync(RenderVideoRequest request, st::CancellationToken cancellationToken) =>
            RenderVideoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds an address to the renderer's queue if a video hasn't already been
        /// rendered. Otherwise, returns metadata about the video.
        /// </summary>
        /// <param name="address">
        /// Required. A US postal address for the location to be rendered in the video.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RenderVideoResponse RenderVideo(string address, gaxgrpc::CallSettings callSettings = null) =>
            RenderVideo(new RenderVideoRequest
            {
                Address = gax::GaxPreconditions.CheckNotNullOrEmpty(address, nameof(address)),
            }, callSettings);

        /// <summary>
        /// Adds an address to the renderer's queue if a video hasn't already been
        /// rendered. Otherwise, returns metadata about the video.
        /// </summary>
        /// <param name="address">
        /// Required. A US postal address for the location to be rendered in the video.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderVideoResponse> RenderVideoAsync(string address, gaxgrpc::CallSettings callSettings = null) =>
            RenderVideoAsync(new RenderVideoRequest
            {
                Address = gax::GaxPreconditions.CheckNotNullOrEmpty(address, nameof(address)),
            }, callSettings);

        /// <summary>
        /// Adds an address to the renderer's queue if a video hasn't already been
        /// rendered. Otherwise, returns metadata about the video.
        /// </summary>
        /// <param name="address">
        /// Required. A US postal address for the location to be rendered in the video.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RenderVideoResponse> RenderVideoAsync(string address, st::CancellationToken cancellationToken) =>
            RenderVideoAsync(address, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches a video given its address or videoId. The response will either be
        /// a video with a set of playback URIs for ACTIVE videos, a PROCESSING state
        /// for pending videos, or a 404 error if the video does not exist. Receiving a
        /// video is a billable event, so callers of this method should be ready to use
        /// the returned URIs at the time of request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Video LookupVideo(LookupVideoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a video given its address or videoId. The response will either be
        /// a video with a set of playback URIs for ACTIVE videos, a PROCESSING state
        /// for pending videos, or a 404 error if the video does not exist. Receiving a
        /// video is a billable event, so callers of this method should be ready to use
        /// the returned URIs at the time of request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Video> LookupVideoAsync(LookupVideoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches a video given its address or videoId. The response will either be
        /// a video with a set of playback URIs for ACTIVE videos, a PROCESSING state
        /// for pending videos, or a 404 error if the video does not exist. Receiving a
        /// video is a billable event, so callers of this method should be ready to use
        /// the returned URIs at the time of request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Video> LookupVideoAsync(LookupVideoRequest request, st::CancellationToken cancellationToken) =>
            LookupVideoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AerialView client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service definition for the Aerial View API.
    /// </remarks>
    public sealed partial class AerialViewClientImpl : AerialViewClient
    {
        private readonly gaxgrpc::ApiCall<RenderVideoRequest, RenderVideoResponse> _callRenderVideo;

        private readonly gaxgrpc::ApiCall<LookupVideoRequest, Video> _callLookupVideo;

        /// <summary>
        /// Constructs a client wrapper for the AerialView service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AerialViewSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AerialViewClientImpl(AerialView.AerialViewClient grpcClient, AerialViewSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AerialViewSettings effectiveSettings = settings ?? AerialViewSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callRenderVideo = clientHelper.BuildApiCall<RenderVideoRequest, RenderVideoResponse>("RenderVideo", grpcClient.RenderVideoAsync, grpcClient.RenderVideo, effectiveSettings.RenderVideoSettings);
            Modify_ApiCall(ref _callRenderVideo);
            Modify_RenderVideoApiCall(ref _callRenderVideo);
            _callLookupVideo = clientHelper.BuildApiCall<LookupVideoRequest, Video>("LookupVideo", grpcClient.LookupVideoAsync, grpcClient.LookupVideo, effectiveSettings.LookupVideoSettings);
            Modify_ApiCall(ref _callLookupVideo);
            Modify_LookupVideoApiCall(ref _callLookupVideo);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RenderVideoApiCall(ref gaxgrpc::ApiCall<RenderVideoRequest, RenderVideoResponse> call);

        partial void Modify_LookupVideoApiCall(ref gaxgrpc::ApiCall<LookupVideoRequest, Video> call);

        partial void OnConstruction(AerialView.AerialViewClient grpcClient, AerialViewSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AerialView client</summary>
        public override AerialView.AerialViewClient GrpcClient { get; }

        partial void Modify_RenderVideoRequest(ref RenderVideoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupVideoRequest(ref LookupVideoRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Adds an address to the renderer's queue if a video hasn't already been
        /// rendered. Otherwise, returns metadata about the video.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RenderVideoResponse RenderVideo(RenderVideoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenderVideoRequest(ref request, ref callSettings);
            return _callRenderVideo.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds an address to the renderer's queue if a video hasn't already been
        /// rendered. Otherwise, returns metadata about the video.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RenderVideoResponse> RenderVideoAsync(RenderVideoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RenderVideoRequest(ref request, ref callSettings);
            return _callRenderVideo.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches a video given its address or videoId. The response will either be
        /// a video with a set of playback URIs for ACTIVE videos, a PROCESSING state
        /// for pending videos, or a 404 error if the video does not exist. Receiving a
        /// video is a billable event, so callers of this method should be ready to use
        /// the returned URIs at the time of request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Video LookupVideo(LookupVideoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupVideoRequest(ref request, ref callSettings);
            return _callLookupVideo.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches a video given its address or videoId. The response will either be
        /// a video with a set of playback URIs for ACTIVE videos, a PROCESSING state
        /// for pending videos, or a 404 error if the video does not exist. Receiving a
        /// video is a billable event, so callers of this method should be ready to use
        /// the returned URIs at the time of request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Video> LookupVideoAsync(LookupVideoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupVideoRequest(ref request, ref callSettings);
            return _callLookupVideo.Async(request, callSettings);
        }
    }
}
