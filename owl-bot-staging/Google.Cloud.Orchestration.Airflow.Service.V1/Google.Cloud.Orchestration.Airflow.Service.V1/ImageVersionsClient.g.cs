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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Orchestration.Airflow.Service.V1
{
    /// <summary>Settings for <see cref="ImageVersionsClient"/> instances.</summary>
    public sealed partial class ImageVersionsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ImageVersionsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ImageVersionsSettings"/>.</returns>
        public static ImageVersionsSettings GetDefault() => new ImageVersionsSettings();

        /// <summary>Constructs a new <see cref="ImageVersionsSettings"/> object with default settings.</summary>
        public ImageVersionsSettings()
        {
        }

        private ImageVersionsSettings(ImageVersionsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListImageVersionsSettings = existing.ListImageVersionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ImageVersionsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ImageVersionsClient.ListImageVersions</c> and <c>ImageVersionsClient.ListImageVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListImageVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ImageVersionsSettings"/> object.</returns>
        public ImageVersionsSettings Clone() => new ImageVersionsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ImageVersionsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ImageVersionsClientBuilder : gaxgrpc::ClientBuilderBase<ImageVersionsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ImageVersionsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ImageVersionsClientBuilder() : base(ImageVersionsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ImageVersionsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ImageVersionsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ImageVersionsClient Build()
        {
            ImageVersionsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ImageVersionsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ImageVersionsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ImageVersionsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ImageVersionsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ImageVersionsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ImageVersionsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ImageVersionsClient.ChannelPool;
    }

    /// <summary>ImageVersions client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Readonly service to query available ImageVersions.
    /// </remarks>
    public abstract partial class ImageVersionsClient
    {
        /// <summary>
        /// The default endpoint for the ImageVersions service, which is a host of "composer.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "composer.googleapis.com:443";

        /// <summary>The default ImageVersions scopes.</summary>
        /// <remarks>
        /// The default ImageVersions scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ImageVersions.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ImageVersionsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ImageVersionsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ImageVersionsClient"/>.</returns>
        public static stt::Task<ImageVersionsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ImageVersionsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ImageVersionsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ImageVersionsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ImageVersionsClient"/>.</returns>
        public static ImageVersionsClient Create() => new ImageVersionsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ImageVersionsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ImageVersionsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ImageVersionsClient"/>.</returns>
        internal static ImageVersionsClient Create(grpccore::CallInvoker callInvoker, ImageVersionsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ImageVersions.ImageVersionsClient grpcClient = new ImageVersions.ImageVersionsClient(callInvoker);
            return new ImageVersionsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ImageVersions client</summary>
        public virtual ImageVersions.ImageVersionsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// List ImageVersions for provided location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ImageVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListImageVersionsResponse, ImageVersion> ListImageVersions(ListImageVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List ImageVersions for provided location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ImageVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListImageVersionsResponse, ImageVersion> ListImageVersionsAsync(ListImageVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List ImageVersions for provided location.
        /// </summary>
        /// <param name="parent">
        /// List ImageVersions in the given project and location, in the form:
        /// "projects/{projectId}/locations/{locationId}"
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
        /// <returns>A pageable sequence of <see cref="ImageVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListImageVersionsResponse, ImageVersion> ListImageVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListImageVersionsRequest request = new ListImageVersionsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListImageVersions(request, callSettings);
        }

        /// <summary>
        /// List ImageVersions for provided location.
        /// </summary>
        /// <param name="parent">
        /// List ImageVersions in the given project and location, in the form:
        /// "projects/{projectId}/locations/{locationId}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="ImageVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListImageVersionsResponse, ImageVersion> ListImageVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListImageVersionsRequest request = new ListImageVersionsRequest { Parent = parent ?? "", };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListImageVersionsAsync(request, callSettings);
        }
    }

    /// <summary>ImageVersions client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Readonly service to query available ImageVersions.
    /// </remarks>
    public sealed partial class ImageVersionsClientImpl : ImageVersionsClient
    {
        private readonly gaxgrpc::ApiCall<ListImageVersionsRequest, ListImageVersionsResponse> _callListImageVersions;

        /// <summary>
        /// Constructs a client wrapper for the ImageVersions service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ImageVersionsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ImageVersionsClientImpl(ImageVersions.ImageVersionsClient grpcClient, ImageVersionsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ImageVersionsSettings effectiveSettings = settings ?? ImageVersionsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListImageVersions = clientHelper.BuildApiCall<ListImageVersionsRequest, ListImageVersionsResponse>("ListImageVersions", grpcClient.ListImageVersionsAsync, grpcClient.ListImageVersions, effectiveSettings.ListImageVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListImageVersions);
            Modify_ListImageVersionsApiCall(ref _callListImageVersions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListImageVersionsApiCall(ref gaxgrpc::ApiCall<ListImageVersionsRequest, ListImageVersionsResponse> call);

        partial void OnConstruction(ImageVersions.ImageVersionsClient grpcClient, ImageVersionsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ImageVersions client</summary>
        public override ImageVersions.ImageVersionsClient GrpcClient { get; }

        partial void Modify_ListImageVersionsRequest(ref ListImageVersionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// List ImageVersions for provided location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ImageVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListImageVersionsResponse, ImageVersion> ListImageVersions(ListImageVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListImageVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListImageVersionsRequest, ListImageVersionsResponse, ImageVersion>(_callListImageVersions, request, callSettings);
        }

        /// <summary>
        /// List ImageVersions for provided location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ImageVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListImageVersionsResponse, ImageVersion> ListImageVersionsAsync(ListImageVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListImageVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListImageVersionsRequest, ListImageVersionsResponse, ImageVersion>(_callListImageVersions, request, callSettings);
        }
    }

    public partial class ListImageVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListImageVersionsResponse : gaxgrpc::IPageResponse<ImageVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ImageVersion> GetEnumerator() => ImageVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
