// Copyright 2024 Google LLC
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
    /// <summary>Settings for <see cref="PlacementServiceClient"/> instances.</summary>
    public sealed partial class PlacementServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PlacementServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PlacementServiceSettings"/>.</returns>
        public static PlacementServiceSettings GetDefault() => new PlacementServiceSettings();

        /// <summary>Constructs a new <see cref="PlacementServiceSettings"/> object with default settings.</summary>
        public PlacementServiceSettings()
        {
        }

        private PlacementServiceSettings(PlacementServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetPlacementSettings = existing.GetPlacementSettings;
            ListPlacementsSettings = existing.ListPlacementsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PlacementServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlacementServiceClient.GetPlacement</c> and <c>PlacementServiceClient.GetPlacementAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetPlacementSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PlacementServiceClient.ListPlacements</c> and <c>PlacementServiceClient.ListPlacementsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPlacementsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PlacementServiceSettings"/> object.</returns>
        public PlacementServiceSettings Clone() => new PlacementServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PlacementServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class PlacementServiceClientBuilder : gaxgrpc::ClientBuilderBase<PlacementServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PlacementServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PlacementServiceClientBuilder() : base(PlacementServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PlacementServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PlacementServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PlacementServiceClient Build()
        {
            PlacementServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PlacementServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PlacementServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PlacementServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PlacementServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PlacementServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PlacementServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PlacementServiceClient.ChannelPool;
    }

    /// <summary>PlacementService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Placement` objects.
    /// </remarks>
    public abstract partial class PlacementServiceClient
    {
        /// <summary>
        /// The default endpoint for the PlacementService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default PlacementService scopes.</summary>
        /// <remarks>The default PlacementService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PlacementService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PlacementServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PlacementServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PlacementServiceClient"/>.</returns>
        public static stt::Task<PlacementServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PlacementServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PlacementServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="PlacementServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PlacementServiceClient"/>.</returns>
        public static PlacementServiceClient Create() => new PlacementServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PlacementServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PlacementServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PlacementServiceClient"/>.</returns>
        internal static PlacementServiceClient Create(grpccore::CallInvoker callInvoker, PlacementServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PlacementService.PlacementServiceClient grpcClient = new PlacementService.PlacementServiceClient(callInvoker);
            return new PlacementServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PlacementService client</summary>
        public virtual PlacementService.PlacementServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Placement` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Placement GetPlacement(GetPlacementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Placement` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Placement> GetPlacementAsync(GetPlacementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Placement` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Placement> GetPlacementAsync(GetPlacementRequest request, st::CancellationToken cancellationToken) =>
            GetPlacementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Placement` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Placement.
        /// Format: `networks/{network_code}/placements/{placement_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Placement GetPlacement(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlacement(new GetPlacementRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Placement` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Placement.
        /// Format: `networks/{network_code}/placements/{placement_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Placement> GetPlacementAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlacementAsync(new GetPlacementRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Placement` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Placement.
        /// Format: `networks/{network_code}/placements/{placement_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Placement> GetPlacementAsync(string name, st::CancellationToken cancellationToken) =>
            GetPlacementAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Placement` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Placement.
        /// Format: `networks/{network_code}/placements/{placement_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Placement GetPlacement(PlacementName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlacement(new GetPlacementRequest
            {
                PlacementName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Placement` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Placement.
        /// Format: `networks/{network_code}/placements/{placement_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Placement> GetPlacementAsync(PlacementName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPlacementAsync(new GetPlacementRequest
            {
                PlacementName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Placement` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Placement.
        /// Format: `networks/{network_code}/placements/{placement_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Placement> GetPlacementAsync(PlacementName name, st::CancellationToken cancellationToken) =>
            GetPlacementAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `Placement` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Placement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPlacementsResponse, Placement> ListPlacements(ListPlacementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Placement` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Placement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPlacementsResponse, Placement> ListPlacementsAsync(ListPlacementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Placement` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Placements.
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
        /// <returns>A pageable sequence of <see cref="Placement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPlacementsResponse, Placement> ListPlacements(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPlacementsRequest request = new ListPlacementsRequest
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
            return ListPlacements(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Placement` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Placements.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Placement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPlacementsResponse, Placement> ListPlacementsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPlacementsRequest request = new ListPlacementsRequest
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
            return ListPlacementsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Placement` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Placements.
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
        /// <returns>A pageable sequence of <see cref="Placement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPlacementsResponse, Placement> ListPlacements(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPlacementsRequest request = new ListPlacementsRequest
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
            return ListPlacements(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Placement` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Placements.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Placement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPlacementsResponse, Placement> ListPlacementsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPlacementsRequest request = new ListPlacementsRequest
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
            return ListPlacementsAsync(request, callSettings);
        }
    }

    /// <summary>PlacementService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Placement` objects.
    /// </remarks>
    public sealed partial class PlacementServiceClientImpl : PlacementServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetPlacementRequest, Placement> _callGetPlacement;

        private readonly gaxgrpc::ApiCall<ListPlacementsRequest, ListPlacementsResponse> _callListPlacements;

        /// <summary>
        /// Constructs a client wrapper for the PlacementService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="PlacementServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PlacementServiceClientImpl(PlacementService.PlacementServiceClient grpcClient, PlacementServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PlacementServiceSettings effectiveSettings = settings ?? PlacementServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetPlacement = clientHelper.BuildApiCall<GetPlacementRequest, Placement>("GetPlacement", grpcClient.GetPlacementAsync, grpcClient.GetPlacement, effectiveSettings.GetPlacementSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPlacement);
            Modify_GetPlacementApiCall(ref _callGetPlacement);
            _callListPlacements = clientHelper.BuildApiCall<ListPlacementsRequest, ListPlacementsResponse>("ListPlacements", grpcClient.ListPlacementsAsync, grpcClient.ListPlacements, effectiveSettings.ListPlacementsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPlacements);
            Modify_ListPlacementsApiCall(ref _callListPlacements);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetPlacementApiCall(ref gaxgrpc::ApiCall<GetPlacementRequest, Placement> call);

        partial void Modify_ListPlacementsApiCall(ref gaxgrpc::ApiCall<ListPlacementsRequest, ListPlacementsResponse> call);

        partial void OnConstruction(PlacementService.PlacementServiceClient grpcClient, PlacementServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PlacementService client</summary>
        public override PlacementService.PlacementServiceClient GrpcClient { get; }

        partial void Modify_GetPlacementRequest(ref GetPlacementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPlacementsRequest(ref ListPlacementsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `Placement` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Placement GetPlacement(GetPlacementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPlacementRequest(ref request, ref callSettings);
            return _callGetPlacement.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `Placement` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Placement> GetPlacementAsync(GetPlacementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPlacementRequest(ref request, ref callSettings);
            return _callGetPlacement.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Placement` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Placement"/> resources.</returns>
        public override gax::PagedEnumerable<ListPlacementsResponse, Placement> ListPlacements(ListPlacementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlacementsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPlacementsRequest, ListPlacementsResponse, Placement>(_callListPlacements, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Placement` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Placement"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPlacementsResponse, Placement> ListPlacementsAsync(ListPlacementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlacementsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPlacementsRequest, ListPlacementsResponse, Placement>(_callListPlacements, request, callSettings);
        }
    }

    public partial class ListPlacementsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPlacementsResponse : gaxgrpc::IPageResponse<Placement>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Placement> GetEnumerator() => Placements.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
