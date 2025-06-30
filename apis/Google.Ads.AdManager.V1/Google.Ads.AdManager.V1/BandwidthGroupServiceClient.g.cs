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
    /// <summary>Settings for <see cref="BandwidthGroupServiceClient"/> instances.</summary>
    public sealed partial class BandwidthGroupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BandwidthGroupServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BandwidthGroupServiceSettings"/>.</returns>
        public static BandwidthGroupServiceSettings GetDefault() => new BandwidthGroupServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BandwidthGroupServiceSettings"/> object with default settings.
        /// </summary>
        public BandwidthGroupServiceSettings()
        {
        }

        private BandwidthGroupServiceSettings(BandwidthGroupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetBandwidthGroupSettings = existing.GetBandwidthGroupSettings;
            ListBandwidthGroupsSettings = existing.ListBandwidthGroupsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BandwidthGroupServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BandwidthGroupServiceClient.GetBandwidthGroup</c> and
        /// <c>BandwidthGroupServiceClient.GetBandwidthGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBandwidthGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BandwidthGroupServiceClient.ListBandwidthGroups</c> and
        /// <c>BandwidthGroupServiceClient.ListBandwidthGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBandwidthGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BandwidthGroupServiceSettings"/> object.</returns>
        public BandwidthGroupServiceSettings Clone() => new BandwidthGroupServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BandwidthGroupServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class BandwidthGroupServiceClientBuilder : gaxgrpc::ClientBuilderBase<BandwidthGroupServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BandwidthGroupServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BandwidthGroupServiceClientBuilder() : base(BandwidthGroupServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BandwidthGroupServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BandwidthGroupServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BandwidthGroupServiceClient Build()
        {
            BandwidthGroupServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BandwidthGroupServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BandwidthGroupServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BandwidthGroupServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BandwidthGroupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BandwidthGroupServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BandwidthGroupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BandwidthGroupServiceClient.ChannelPool;
    }

    /// <summary>BandwidthGroupService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `BandwidthGroup` objects.
    /// </remarks>
    public abstract partial class BandwidthGroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the BandwidthGroupService service, which is a host of "admanager.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default BandwidthGroupService scopes.</summary>
        /// <remarks>
        /// The default BandwidthGroupService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BandwidthGroupService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BandwidthGroupServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BandwidthGroupServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BandwidthGroupServiceClient"/>.</returns>
        public static stt::Task<BandwidthGroupServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BandwidthGroupServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BandwidthGroupServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BandwidthGroupServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BandwidthGroupServiceClient"/>.</returns>
        public static BandwidthGroupServiceClient Create() => new BandwidthGroupServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BandwidthGroupServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BandwidthGroupServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BandwidthGroupServiceClient"/>.</returns>
        internal static BandwidthGroupServiceClient Create(grpccore::CallInvoker callInvoker, BandwidthGroupServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BandwidthGroupService.BandwidthGroupServiceClient grpcClient = new BandwidthGroupService.BandwidthGroupServiceClient(callInvoker);
            return new BandwidthGroupServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BandwidthGroupService client</summary>
        public virtual BandwidthGroupService.BandwidthGroupServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `BandwidthGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BandwidthGroup GetBandwidthGroup(GetBandwidthGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `BandwidthGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BandwidthGroup> GetBandwidthGroupAsync(GetBandwidthGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `BandwidthGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BandwidthGroup> GetBandwidthGroupAsync(GetBandwidthGroupRequest request, st::CancellationToken cancellationToken) =>
            GetBandwidthGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `BandwidthGroup` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BandwidthGroup.
        /// Format: `networks/{network_code}/bandwidthGroups/{bandwidth_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BandwidthGroup GetBandwidthGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBandwidthGroup(new GetBandwidthGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `BandwidthGroup` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BandwidthGroup.
        /// Format: `networks/{network_code}/bandwidthGroups/{bandwidth_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BandwidthGroup> GetBandwidthGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBandwidthGroupAsync(new GetBandwidthGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `BandwidthGroup` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BandwidthGroup.
        /// Format: `networks/{network_code}/bandwidthGroups/{bandwidth_group_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BandwidthGroup> GetBandwidthGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetBandwidthGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `BandwidthGroup` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BandwidthGroup.
        /// Format: `networks/{network_code}/bandwidthGroups/{bandwidth_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BandwidthGroup GetBandwidthGroup(BandwidthGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBandwidthGroup(new GetBandwidthGroupRequest
            {
                BandwidthGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `BandwidthGroup` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BandwidthGroup.
        /// Format: `networks/{network_code}/bandwidthGroups/{bandwidth_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BandwidthGroup> GetBandwidthGroupAsync(BandwidthGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBandwidthGroupAsync(new GetBandwidthGroupRequest
            {
                BandwidthGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `BandwidthGroup` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the BandwidthGroup.
        /// Format: `networks/{network_code}/bandwidthGroups/{bandwidth_group_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BandwidthGroup> GetBandwidthGroupAsync(BandwidthGroupName name, st::CancellationToken cancellationToken) =>
            GetBandwidthGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `BandwidthGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BandwidthGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> ListBandwidthGroups(ListBandwidthGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `BandwidthGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BandwidthGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> ListBandwidthGroupsAsync(ListBandwidthGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `BandwidthGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of BandwidthGroups.
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
        /// <returns>A pageable sequence of <see cref="BandwidthGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> ListBandwidthGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBandwidthGroupsRequest request = new ListBandwidthGroupsRequest
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
            return ListBandwidthGroups(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `BandwidthGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of BandwidthGroups.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BandwidthGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> ListBandwidthGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBandwidthGroupsRequest request = new ListBandwidthGroupsRequest
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
            return ListBandwidthGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `BandwidthGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of BandwidthGroups.
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
        /// <returns>A pageable sequence of <see cref="BandwidthGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> ListBandwidthGroups(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBandwidthGroupsRequest request = new ListBandwidthGroupsRequest
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
            return ListBandwidthGroups(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `BandwidthGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of BandwidthGroups.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BandwidthGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> ListBandwidthGroupsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBandwidthGroupsRequest request = new ListBandwidthGroupsRequest
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
            return ListBandwidthGroupsAsync(request, callSettings);
        }
    }

    /// <summary>BandwidthGroupService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `BandwidthGroup` objects.
    /// </remarks>
    public sealed partial class BandwidthGroupServiceClientImpl : BandwidthGroupServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetBandwidthGroupRequest, BandwidthGroup> _callGetBandwidthGroup;

        private readonly gaxgrpc::ApiCall<ListBandwidthGroupsRequest, ListBandwidthGroupsResponse> _callListBandwidthGroups;

        /// <summary>
        /// Constructs a client wrapper for the BandwidthGroupService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BandwidthGroupServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BandwidthGroupServiceClientImpl(BandwidthGroupService.BandwidthGroupServiceClient grpcClient, BandwidthGroupServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BandwidthGroupServiceSettings effectiveSettings = settings ?? BandwidthGroupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetBandwidthGroup = clientHelper.BuildApiCall<GetBandwidthGroupRequest, BandwidthGroup>("GetBandwidthGroup", grpcClient.GetBandwidthGroupAsync, grpcClient.GetBandwidthGroup, effectiveSettings.GetBandwidthGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBandwidthGroup);
            Modify_GetBandwidthGroupApiCall(ref _callGetBandwidthGroup);
            _callListBandwidthGroups = clientHelper.BuildApiCall<ListBandwidthGroupsRequest, ListBandwidthGroupsResponse>("ListBandwidthGroups", grpcClient.ListBandwidthGroupsAsync, grpcClient.ListBandwidthGroups, effectiveSettings.ListBandwidthGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBandwidthGroups);
            Modify_ListBandwidthGroupsApiCall(ref _callListBandwidthGroups);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetBandwidthGroupApiCall(ref gaxgrpc::ApiCall<GetBandwidthGroupRequest, BandwidthGroup> call);

        partial void Modify_ListBandwidthGroupsApiCall(ref gaxgrpc::ApiCall<ListBandwidthGroupsRequest, ListBandwidthGroupsResponse> call);

        partial void OnConstruction(BandwidthGroupService.BandwidthGroupServiceClient grpcClient, BandwidthGroupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BandwidthGroupService client</summary>
        public override BandwidthGroupService.BandwidthGroupServiceClient GrpcClient { get; }

        partial void Modify_GetBandwidthGroupRequest(ref GetBandwidthGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBandwidthGroupsRequest(ref ListBandwidthGroupsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `BandwidthGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BandwidthGroup GetBandwidthGroup(GetBandwidthGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBandwidthGroupRequest(ref request, ref callSettings);
            return _callGetBandwidthGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `BandwidthGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BandwidthGroup> GetBandwidthGroupAsync(GetBandwidthGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBandwidthGroupRequest(ref request, ref callSettings);
            return _callGetBandwidthGroup.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `BandwidthGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BandwidthGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> ListBandwidthGroups(ListBandwidthGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBandwidthGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBandwidthGroupsRequest, ListBandwidthGroupsResponse, BandwidthGroup>(_callListBandwidthGroups, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `BandwidthGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BandwidthGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBandwidthGroupsResponse, BandwidthGroup> ListBandwidthGroupsAsync(ListBandwidthGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBandwidthGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBandwidthGroupsRequest, ListBandwidthGroupsResponse, BandwidthGroup>(_callListBandwidthGroups, request, callSettings);
        }
    }

    public partial class ListBandwidthGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBandwidthGroupsResponse : gaxgrpc::IPageResponse<BandwidthGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BandwidthGroup> GetEnumerator() => BandwidthGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
