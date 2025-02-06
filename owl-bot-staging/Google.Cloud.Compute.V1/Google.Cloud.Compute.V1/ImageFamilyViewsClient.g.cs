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

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="ImageFamilyViewsClient"/> instances.</summary>
    public sealed partial class ImageFamilyViewsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ImageFamilyViewsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ImageFamilyViewsSettings"/>.</returns>
        public static ImageFamilyViewsSettings GetDefault() => new ImageFamilyViewsSettings();

        /// <summary>Constructs a new <see cref="ImageFamilyViewsSettings"/> object with default settings.</summary>
        public ImageFamilyViewsSettings()
        {
        }

        private ImageFamilyViewsSettings(ImageFamilyViewsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ImageFamilyViewsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ImageFamilyViewsClient.Get</c>
        ///  and <c>ImageFamilyViewsClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ImageFamilyViewsSettings"/> object.</returns>
        public ImageFamilyViewsSettings Clone() => new ImageFamilyViewsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ImageFamilyViewsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ImageFamilyViewsClientBuilder : gaxgrpc::ClientBuilderBase<ImageFamilyViewsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ImageFamilyViewsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ImageFamilyViewsClientBuilder() : base(ImageFamilyViewsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ImageFamilyViewsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ImageFamilyViewsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ImageFamilyViewsClient Build()
        {
            ImageFamilyViewsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ImageFamilyViewsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ImageFamilyViewsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ImageFamilyViewsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ImageFamilyViewsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ImageFamilyViewsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ImageFamilyViewsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ImageFamilyViewsClient.ChannelPool;
    }

    /// <summary>ImageFamilyViews client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The ImageFamilyViews API.
    /// </remarks>
    public abstract partial class ImageFamilyViewsClient
    {
        /// <summary>
        /// The default endpoint for the ImageFamilyViews service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default ImageFamilyViews scopes.</summary>
        /// <remarks>
        /// The default ImageFamilyViews scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute.readonly</description></item>
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute.readonly",
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ImageFamilyViews.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ImageFamilyViewsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ImageFamilyViewsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ImageFamilyViewsClient"/>.</returns>
        public static stt::Task<ImageFamilyViewsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ImageFamilyViewsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ImageFamilyViewsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ImageFamilyViewsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ImageFamilyViewsClient"/>.</returns>
        public static ImageFamilyViewsClient Create() => new ImageFamilyViewsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ImageFamilyViewsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ImageFamilyViewsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ImageFamilyViewsClient"/>.</returns>
        internal static ImageFamilyViewsClient Create(grpccore::CallInvoker callInvoker, ImageFamilyViewsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ImageFamilyViews.ImageFamilyViewsClient grpcClient = new ImageFamilyViews.ImageFamilyViewsClient(callInvoker);
            return new ImageFamilyViewsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ImageFamilyViews client</summary>
        public virtual ImageFamilyViews.ImageFamilyViewsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the latest image that is part of an image family, is not deprecated and is rolled out in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImageFamilyView Get(GetImageFamilyViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the latest image that is part of an image family, is not deprecated and is rolled out in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImageFamilyView> GetAsync(GetImageFamilyViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the latest image that is part of an image family, is not deprecated and is rolled out in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImageFamilyView> GetAsync(GetImageFamilyViewRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the latest image that is part of an image family, is not deprecated and is rolled out in the specified zone.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="family">
        /// Name of the image family to search for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImageFamilyView Get(string project, string zone, string family, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetImageFamilyViewRequest
            {
                Family = gax::GaxPreconditions.CheckNotNullOrEmpty(family, nameof(family)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the latest image that is part of an image family, is not deprecated and is rolled out in the specified zone.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="family">
        /// Name of the image family to search for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImageFamilyView> GetAsync(string project, string zone, string family, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetImageFamilyViewRequest
            {
                Family = gax::GaxPreconditions.CheckNotNullOrEmpty(family, nameof(family)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Zone = gax::GaxPreconditions.CheckNotNullOrEmpty(zone, nameof(zone)),
            }, callSettings);

        /// <summary>
        /// Returns the latest image that is part of an image family, is not deprecated and is rolled out in the specified zone.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="zone">
        /// The name of the zone for this request.
        /// </param>
        /// <param name="family">
        /// Name of the image family to search for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImageFamilyView> GetAsync(string project, string zone, string family, st::CancellationToken cancellationToken) =>
            GetAsync(project, zone, family, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ImageFamilyViews client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The ImageFamilyViews API.
    /// </remarks>
    public sealed partial class ImageFamilyViewsClientImpl : ImageFamilyViewsClient
    {
        private readonly gaxgrpc::ApiCall<GetImageFamilyViewRequest, ImageFamilyView> _callGet;

        /// <summary>
        /// Constructs a client wrapper for the ImageFamilyViews service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ImageFamilyViewsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ImageFamilyViewsClientImpl(ImageFamilyViews.ImageFamilyViewsClient grpcClient, ImageFamilyViewsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ImageFamilyViewsSettings effectiveSettings = settings ?? ImageFamilyViewsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGet = clientHelper.BuildApiCall<GetImageFamilyViewRequest, ImageFamilyView>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("zone", request => request.Zone).WithGoogleRequestParam("family", request => request.Family);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetImageFamilyViewRequest, ImageFamilyView> call);

        partial void OnConstruction(ImageFamilyViews.ImageFamilyViewsClient grpcClient, ImageFamilyViewsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ImageFamilyViews client</summary>
        public override ImageFamilyViews.ImageFamilyViewsClient GrpcClient { get; }

        partial void Modify_GetImageFamilyViewRequest(ref GetImageFamilyViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the latest image that is part of an image family, is not deprecated and is rolled out in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ImageFamilyView Get(GetImageFamilyViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetImageFamilyViewRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the latest image that is part of an image family, is not deprecated and is rolled out in the specified zone.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ImageFamilyView> GetAsync(GetImageFamilyViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetImageFamilyViewRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }
    }
}
