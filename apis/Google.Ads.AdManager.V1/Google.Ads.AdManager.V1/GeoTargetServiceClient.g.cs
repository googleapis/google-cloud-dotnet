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

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="GeoTargetServiceClient"/> instances.</summary>
    public sealed partial class GeoTargetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GeoTargetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GeoTargetServiceSettings"/>.</returns>
        public static GeoTargetServiceSettings GetDefault() => new GeoTargetServiceSettings();

        /// <summary>Constructs a new <see cref="GeoTargetServiceSettings"/> object with default settings.</summary>
        public GeoTargetServiceSettings()
        {
        }

        private GeoTargetServiceSettings(GeoTargetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetGeoTargetSettings = existing.GetGeoTargetSettings;
            ListGeoTargetsSettings = existing.ListGeoTargetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GeoTargetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeoTargetServiceClient.GetGeoTarget</c> and <c>GeoTargetServiceClient.GetGeoTargetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGeoTargetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GeoTargetServiceClient.ListGeoTargets</c> and <c>GeoTargetServiceClient.ListGeoTargetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListGeoTargetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GeoTargetServiceSettings"/> object.</returns>
        public GeoTargetServiceSettings Clone() => new GeoTargetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GeoTargetServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class GeoTargetServiceClientBuilder : gaxgrpc::ClientBuilderBase<GeoTargetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GeoTargetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GeoTargetServiceClientBuilder() : base(GeoTargetServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GeoTargetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GeoTargetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GeoTargetServiceClient Build()
        {
            GeoTargetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GeoTargetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GeoTargetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GeoTargetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GeoTargetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GeoTargetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GeoTargetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GeoTargetServiceClient.ChannelPool;
    }

    /// <summary>GeoTargetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `GeoTarget` objects.
    /// </remarks>
    public abstract partial class GeoTargetServiceClient
    {
        /// <summary>
        /// The default endpoint for the GeoTargetService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default GeoTargetService scopes.</summary>
        /// <remarks>
        /// The default GeoTargetService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GeoTargetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GeoTargetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GeoTargetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GeoTargetServiceClient"/>.</returns>
        public static stt::Task<GeoTargetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GeoTargetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GeoTargetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GeoTargetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GeoTargetServiceClient"/>.</returns>
        public static GeoTargetServiceClient Create() => new GeoTargetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GeoTargetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GeoTargetServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GeoTargetServiceClient"/>.</returns>
        internal static GeoTargetServiceClient Create(grpccore::CallInvoker callInvoker, GeoTargetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GeoTargetService.GeoTargetServiceClient grpcClient = new GeoTargetService.GeoTargetServiceClient(callInvoker);
            return new GeoTargetServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GeoTargetService client</summary>
        public virtual GeoTargetService.GeoTargetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `GeoTarget` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GeoTarget GetGeoTarget(GetGeoTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `GeoTarget` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeoTarget> GetGeoTargetAsync(GetGeoTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `GeoTarget` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeoTarget> GetGeoTargetAsync(GetGeoTargetRequest request, st::CancellationToken cancellationToken) =>
            GetGeoTargetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `GeoTarget` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the GeoTarget.
        /// Format: `networks/{network_code}/geoTargets/{geo_target_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GeoTarget GetGeoTarget(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGeoTarget(new GetGeoTargetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `GeoTarget` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the GeoTarget.
        /// Format: `networks/{network_code}/geoTargets/{geo_target_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeoTarget> GetGeoTargetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetGeoTargetAsync(new GetGeoTargetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `GeoTarget` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the GeoTarget.
        /// Format: `networks/{network_code}/geoTargets/{geo_target_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeoTarget> GetGeoTargetAsync(string name, st::CancellationToken cancellationToken) =>
            GetGeoTargetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `GeoTarget` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the GeoTarget.
        /// Format: `networks/{network_code}/geoTargets/{geo_target_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GeoTarget GetGeoTarget(GeoTargetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGeoTarget(new GetGeoTargetRequest
            {
                GeoTargetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `GeoTarget` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the GeoTarget.
        /// Format: `networks/{network_code}/geoTargets/{geo_target_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeoTarget> GetGeoTargetAsync(GeoTargetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetGeoTargetAsync(new GetGeoTargetRequest
            {
                GeoTargetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `GeoTarget` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the GeoTarget.
        /// Format: `networks/{network_code}/geoTargets/{geo_target_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GeoTarget> GetGeoTargetAsync(GeoTargetName name, st::CancellationToken cancellationToken) =>
            GetGeoTargetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `GeoTarget` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GeoTarget"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGeoTargetsResponse, GeoTarget> ListGeoTargets(ListGeoTargetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `GeoTarget` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GeoTarget"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGeoTargetsResponse, GeoTarget> ListGeoTargetsAsync(ListGeoTargetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `GeoTarget` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of GeoTargets.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="GeoTarget"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGeoTargetsResponse, GeoTarget> ListGeoTargets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGeoTargetsRequest request = new ListGeoTargetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGeoTargets(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `GeoTarget` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of GeoTargets.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="GeoTarget"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGeoTargetsResponse, GeoTarget> ListGeoTargetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGeoTargetsRequest request = new ListGeoTargetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGeoTargetsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `GeoTarget` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of GeoTargets.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable sequence of <see cref="GeoTarget"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListGeoTargetsResponse, GeoTarget> ListGeoTargets(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGeoTargetsRequest request = new ListGeoTargetsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGeoTargets(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `GeoTarget` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of GeoTargets.
        /// Format: `networks/{network_code}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="GeoTarget"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListGeoTargetsResponse, GeoTarget> ListGeoTargetsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListGeoTargetsRequest request = new ListGeoTargetsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListGeoTargetsAsync(request, callSettings);
        }
    }

    /// <summary>GeoTargetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `GeoTarget` objects.
    /// </remarks>
    public sealed partial class GeoTargetServiceClientImpl : GeoTargetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetGeoTargetRequest, GeoTarget> _callGetGeoTarget;

        private readonly gaxgrpc::ApiCall<ListGeoTargetsRequest, ListGeoTargetsResponse> _callListGeoTargets;

        /// <summary>
        /// Constructs a client wrapper for the GeoTargetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GeoTargetServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GeoTargetServiceClientImpl(GeoTargetService.GeoTargetServiceClient grpcClient, GeoTargetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GeoTargetServiceSettings effectiveSettings = settings ?? GeoTargetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetGeoTarget = clientHelper.BuildApiCall<GetGeoTargetRequest, GeoTarget>("GetGeoTarget", grpcClient.GetGeoTargetAsync, grpcClient.GetGeoTarget, effectiveSettings.GetGeoTargetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetGeoTarget);
            Modify_GetGeoTargetApiCall(ref _callGetGeoTarget);
            _callListGeoTargets = clientHelper.BuildApiCall<ListGeoTargetsRequest, ListGeoTargetsResponse>("ListGeoTargets", grpcClient.ListGeoTargetsAsync, grpcClient.ListGeoTargets, effectiveSettings.ListGeoTargetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListGeoTargets);
            Modify_ListGeoTargetsApiCall(ref _callListGeoTargets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetGeoTargetApiCall(ref gaxgrpc::ApiCall<GetGeoTargetRequest, GeoTarget> call);

        partial void Modify_ListGeoTargetsApiCall(ref gaxgrpc::ApiCall<ListGeoTargetsRequest, ListGeoTargetsResponse> call);

        partial void OnConstruction(GeoTargetService.GeoTargetServiceClient grpcClient, GeoTargetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GeoTargetService client</summary>
        public override GeoTargetService.GeoTargetServiceClient GrpcClient { get; }

        partial void Modify_GetGeoTargetRequest(ref GetGeoTargetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListGeoTargetsRequest(ref ListGeoTargetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `GeoTarget` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GeoTarget GetGeoTarget(GetGeoTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGeoTargetRequest(ref request, ref callSettings);
            return _callGetGeoTarget.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `GeoTarget` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GeoTarget> GetGeoTargetAsync(GetGeoTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGeoTargetRequest(ref request, ref callSettings);
            return _callGetGeoTarget.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `GeoTarget` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GeoTarget"/> resources.</returns>
        public override gax::PagedEnumerable<ListGeoTargetsResponse, GeoTarget> ListGeoTargets(ListGeoTargetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGeoTargetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGeoTargetsRequest, ListGeoTargetsResponse, GeoTarget>(_callListGeoTargets, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `GeoTarget` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GeoTarget"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListGeoTargetsResponse, GeoTarget> ListGeoTargetsAsync(ListGeoTargetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGeoTargetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGeoTargetsRequest, ListGeoTargetsResponse, GeoTarget>(_callListGeoTargets, request, callSettings);
        }
    }

    public partial class ListGeoTargetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListGeoTargetsResponse : gaxgrpc::IPageResponse<GeoTarget>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GeoTarget> GetEnumerator() => GeoTargets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
