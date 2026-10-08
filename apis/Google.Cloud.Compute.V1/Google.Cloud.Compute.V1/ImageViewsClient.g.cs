// Copyright 2026 Google LLC
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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="ImageViewsClient"/> instances.</summary>
    public sealed partial class ImageViewsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ImageViewsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ImageViewsSettings"/>.</returns>
        public static ImageViewsSettings GetDefault() => new ImageViewsSettings();

        /// <summary>Constructs a new <see cref="ImageViewsSettings"/> object with default settings.</summary>
        public ImageViewsSettings()
        {
        }

        private ImageViewsSettings(ImageViewsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSettings = existing.GetSettings;
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ImageViewsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ImageViewsClient.Get</c>
        /// and <c>ImageViewsClient.GetAsync</c>.
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

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ImageViewsClient.List</c>
        /// and <c>ImageViewsClient.ListAsync</c>.
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
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ImageViewsSettings"/> object.</returns>
        public ImageViewsSettings Clone() => new ImageViewsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ImageViewsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ImageViewsClientBuilder : gaxgrpc::ClientBuilderBase<ImageViewsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ImageViewsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ImageViewsClientBuilder() : base(ImageViewsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ImageViewsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ImageViewsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ImageViewsClient Build()
        {
            ImageViewsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ImageViewsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ImageViewsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ImageViewsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ImageViewsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ImageViewsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ImageViewsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ImageViewsClient.ChannelPool;
    }

    /// <summary>ImageViews client wrapper, for convenient use. This client implements API version 2026-09-01.</summary>
    /// <remarks>
    /// The ImageViews API.
    /// </remarks>
    public abstract partial class ImageViewsClient
    {
        /// <summary>
        /// The default endpoint for the ImageViews service, which is a host of "compute.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default ImageViews scopes.</summary>
        /// <remarks>
        /// The default ImageViews scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ImageViews.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ImageViewsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ImageViewsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ImageViewsClient"/>.</returns>
        public static stt::Task<ImageViewsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ImageViewsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ImageViewsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="ImageViewsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ImageViewsClient"/>.</returns>
        public static ImageViewsClient Create() => new ImageViewsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ImageViewsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ImageViewsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ImageViewsClient"/>.</returns>
        internal static ImageViewsClient Create(grpccore::CallInvoker callInvoker, ImageViewsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ImageViews.ImageViewsClient grpcClient = new ImageViews.ImageViewsClient(callInvoker);
            return new ImageViewsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ImageViews client</summary>
        public virtual ImageViews.ImageViewsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified global ImageView resource, with a regional
        /// context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImageView Get(GetImageViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified global ImageView resource, with a regional
        /// context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImageView> GetAsync(GetImageViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified global ImageView resource, with a regional
        /// context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImageView> GetAsync(GetImageViewRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified global ImageView resource, with a regional
        /// context.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Required. Name of the region for this request.
        /// </param>
        /// <param name="resourceId">
        /// Name of the image resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImageView Get(string project, string region, string resourceId, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetImageViewRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ResourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceId, nameof(resourceId)),
            }, callSettings);

        /// <summary>
        /// Returns the specified global ImageView resource, with a regional
        /// context.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Required. Name of the region for this request.
        /// </param>
        /// <param name="resourceId">
        /// Name of the image resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImageView> GetAsync(string project, string region, string resourceId, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetImageViewRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                ResourceId = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceId, nameof(resourceId)),
            }, callSettings);

        /// <summary>
        /// Returns the specified global ImageView resource, with a regional
        /// context.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Required. Name of the region for this request.
        /// </param>
        /// <param name="resourceId">
        /// Name of the image resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImageView> GetAsync(string project, string region, string resourceId, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, resourceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of global ImageView resources, with a regional
        /// context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ImageView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ImageViewsListResponse, ImageView> List(ListImageViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of global ImageView resources, with a regional
        /// context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ImageView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ImageViewsListResponse, ImageView> ListAsync(ListImageViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of global ImageView resources, with a regional
        /// context.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Required. Name of the region for this request.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ImageView"/> resources.</returns>
        public virtual gax::PagedEnumerable<ImageViewsListResponse, ImageView> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListImageViewsRequest request = new ListImageViewsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return List(request, callSettings);
        }

        /// <summary>
        /// Returns a list of global ImageView resources, with a regional
        /// context.
        /// </summary>
        /// <param name="project">
        /// Required. Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Required. Name of the region for this request.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ImageView"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ImageViewsListResponse, ImageView> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListImageViewsRequest request = new ListImageViewsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAsync(request, callSettings);
        }
    }

    /// <summary>ImageViews client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The ImageViews API.
    /// </remarks>
    public sealed partial class ImageViewsClientImpl : ImageViewsClient
    {
        private readonly gaxgrpc::ApiCall<GetImageViewRequest, ImageView> _callGet;

        private readonly gaxgrpc::ApiCall<ListImageViewsRequest, ImageViewsListResponse> _callList;

        /// <summary>
        /// Constructs a client wrapper for the ImageViews service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ImageViewsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ImageViewsClientImpl(ImageViews.ImageViewsClient grpcClient, ImageViewsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ImageViewsSettings effectiveSettings = settings ?? ImageViewsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
                ApiVersion = "2026-09-01",
            });
            _callGet = clientHelper.BuildApiCall<GetImageViewRequest, ImageView>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("resource_id", request => request.ResourceId);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callList = clientHelper.BuildApiCall<ListImageViewsRequest, ImageViewsListResponse>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetImageViewRequest, ImageView> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListImageViewsRequest, ImageViewsListResponse> call);

        partial void OnConstruction(ImageViews.ImageViewsClient grpcClient, ImageViewsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ImageViews client</summary>
        public override ImageViews.ImageViewsClient GrpcClient { get; }

        partial void Modify_GetImageViewRequest(ref GetImageViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListImageViewsRequest(ref ListImageViewsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the specified global ImageView resource, with a regional
        /// context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ImageView Get(GetImageViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetImageViewRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified global ImageView resource, with a regional
        /// context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ImageView> GetAsync(GetImageViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetImageViewRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of global ImageView resources, with a regional
        /// context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ImageView"/> resources.</returns>
        public override gax::PagedEnumerable<ImageViewsListResponse, ImageView> List(ListImageViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListImageViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListImageViewsRequest, ImageViewsListResponse, ImageView>(_callList, request, callSettings);
        }

        /// <summary>
        /// Returns a list of global ImageView resources, with a regional
        /// context.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ImageView"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ImageViewsListResponse, ImageView> ListAsync(ListImageViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListImageViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListImageViewsRequest, ImageViewsListResponse, ImageView>(_callList, request, callSettings);
        }
    }

    public partial class ListImageViewsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ImageViewsListResponse : gaxgrpc::IPageResponse<ImageView>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ImageView> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
