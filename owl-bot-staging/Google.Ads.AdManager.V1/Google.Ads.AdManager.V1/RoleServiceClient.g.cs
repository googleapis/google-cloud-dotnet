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
    /// <summary>Settings for <see cref="RoleServiceClient"/> instances.</summary>
    public sealed partial class RoleServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RoleServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RoleServiceSettings"/>.</returns>
        public static RoleServiceSettings GetDefault() => new RoleServiceSettings();

        /// <summary>Constructs a new <see cref="RoleServiceSettings"/> object with default settings.</summary>
        public RoleServiceSettings()
        {
        }

        private RoleServiceSettings(RoleServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetRoleSettings = existing.GetRoleSettings;
            ListRolesSettings = existing.ListRolesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RoleServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RoleServiceClient.GetRole</c>
        ///  and <c>RoleServiceClient.GetRoleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRoleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RoleServiceClient.ListRoles</c>
        ///  and <c>RoleServiceClient.ListRolesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRolesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RoleServiceSettings"/> object.</returns>
        public RoleServiceSettings Clone() => new RoleServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RoleServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RoleServiceClientBuilder : gaxgrpc::ClientBuilderBase<RoleServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RoleServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public RoleServiceClientBuilder() : base(RoleServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref RoleServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RoleServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RoleServiceClient Build()
        {
            RoleServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RoleServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RoleServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RoleServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RoleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<RoleServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RoleServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RoleServiceClient.ChannelPool;
    }

    /// <summary>RoleService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Role` objects.
    /// </remarks>
    public abstract partial class RoleServiceClient
    {
        /// <summary>
        /// The default endpoint for the RoleService service, which is a host of "admanager.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default RoleService scopes.</summary>
        /// <remarks>The default RoleService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(RoleService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="RoleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RoleServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RoleServiceClient"/>.</returns>
        public static stt::Task<RoleServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RoleServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RoleServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RoleServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RoleServiceClient"/>.</returns>
        public static RoleServiceClient Create() => new RoleServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RoleServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RoleServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="RoleServiceClient"/>.</returns>
        internal static RoleServiceClient Create(grpccore::CallInvoker callInvoker, RoleServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RoleService.RoleServiceClient grpcClient = new RoleService.RoleServiceClient(callInvoker);
            return new RoleServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC RoleService client</summary>
        public virtual RoleService.RoleServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Role` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Role GetRole(GetRoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Role` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> GetRoleAsync(GetRoleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a `Role` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> GetRoleAsync(GetRoleRequest request, st::CancellationToken cancellationToken) =>
            GetRoleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Role` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Role.
        /// Format: `networks/{network_code}/roles/{role_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Role GetRole(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRole(new GetRoleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Role` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Role.
        /// Format: `networks/{network_code}/roles/{role_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> GetRoleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRoleAsync(new GetRoleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Role` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Role.
        /// Format: `networks/{network_code}/roles/{role_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> GetRoleAsync(string name, st::CancellationToken cancellationToken) =>
            GetRoleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a `Role` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Role.
        /// Format: `networks/{network_code}/roles/{role_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Role GetRole(RoleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRole(new GetRoleRequest
            {
                RoleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Role` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Role.
        /// Format: `networks/{network_code}/roles/{role_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> GetRoleAsync(RoleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRoleAsync(new GetRoleRequest
            {
                RoleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a `Role` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Role.
        /// Format: `networks/{network_code}/roles/{role_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Role> GetRoleAsync(RoleName name, st::CancellationToken cancellationToken) =>
            GetRoleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a list of `Role` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Role"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolesResponse, Role> ListRoles(ListRolesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Role` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Role"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolesResponse, Role> ListRolesAsync(ListRolesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a list of `Role` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Roles.
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
        /// <returns>A pageable sequence of <see cref="Role"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolesResponse, Role> ListRoles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolesRequest request = new ListRolesRequest
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
            return ListRoles(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Role` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Roles.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Role"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolesResponse, Role> ListRolesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolesRequest request = new ListRolesRequest
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
            return ListRolesAsync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Role` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Roles.
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
        /// <returns>A pageable sequence of <see cref="Role"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolesResponse, Role> ListRoles(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolesRequest request = new ListRolesRequest
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
            return ListRoles(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Role` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of Roles.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Role"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolesResponse, Role> ListRolesAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolesRequest request = new ListRolesRequest
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
            return ListRolesAsync(request, callSettings);
        }
    }

    /// <summary>RoleService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Role` objects.
    /// </remarks>
    public sealed partial class RoleServiceClientImpl : RoleServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetRoleRequest, Role> _callGetRole;

        private readonly gaxgrpc::ApiCall<ListRolesRequest, ListRolesResponse> _callListRoles;

        /// <summary>
        /// Constructs a client wrapper for the RoleService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RoleServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public RoleServiceClientImpl(RoleService.RoleServiceClient grpcClient, RoleServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            RoleServiceSettings effectiveSettings = settings ?? RoleServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetRole = clientHelper.BuildApiCall<GetRoleRequest, Role>("GetRole", grpcClient.GetRoleAsync, grpcClient.GetRole, effectiveSettings.GetRoleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRole);
            Modify_GetRoleApiCall(ref _callGetRole);
            _callListRoles = clientHelper.BuildApiCall<ListRolesRequest, ListRolesResponse>("ListRoles", grpcClient.ListRolesAsync, grpcClient.ListRoles, effectiveSettings.ListRolesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRoles);
            Modify_ListRolesApiCall(ref _callListRoles);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetRoleApiCall(ref gaxgrpc::ApiCall<GetRoleRequest, Role> call);

        partial void Modify_ListRolesApiCall(ref gaxgrpc::ApiCall<ListRolesRequest, ListRolesResponse> call);

        partial void OnConstruction(RoleService.RoleServiceClient grpcClient, RoleServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RoleService client</summary>
        public override RoleService.RoleServiceClient GrpcClient { get; }

        partial void Modify_GetRoleRequest(ref GetRoleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRolesRequest(ref ListRolesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a `Role` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Role GetRole(GetRoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRoleRequest(ref request, ref callSettings);
            return _callGetRole.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a `Role` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Role> GetRoleAsync(GetRoleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRoleRequest(ref request, ref callSettings);
            return _callGetRole.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Role` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Role"/> resources.</returns>
        public override gax::PagedEnumerable<ListRolesResponse, Role> ListRoles(ListRolesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRolesRequest, ListRolesResponse, Role>(_callListRoles, request, callSettings);
        }

        /// <summary>
        /// API to retrieve a list of `Role` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Role"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRolesResponse, Role> ListRolesAsync(ListRolesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRolesRequest, ListRolesResponse, Role>(_callListRoles, request, callSettings);
        }
    }

    public partial class ListRolesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRolesResponse : gaxgrpc::IPageResponse<Role>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Role> GetEnumerator() => Roles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
