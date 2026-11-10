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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="YieldGroupServiceClient"/> instances.</summary>
    public sealed partial class YieldGroupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="YieldGroupServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="YieldGroupServiceSettings"/>.</returns>
        public static YieldGroupServiceSettings GetDefault() => new YieldGroupServiceSettings();

        /// <summary>Constructs a new <see cref="YieldGroupServiceSettings"/> object with default settings.</summary>
        public YieldGroupServiceSettings()
        {
        }

        private YieldGroupServiceSettings(YieldGroupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetYieldGroupSettings = existing.GetYieldGroupSettings;
            ListYieldGroupsSettings = existing.ListYieldGroupsSettings;
            CreateYieldGroupSettings = existing.CreateYieldGroupSettings;
            BatchCreateYieldGroupsSettings = existing.BatchCreateYieldGroupsSettings;
            UpdateYieldGroupSettings = existing.UpdateYieldGroupSettings;
            BatchUpdateYieldGroupsSettings = existing.BatchUpdateYieldGroupsSettings;
            BatchActivateYieldGroupsSettings = existing.BatchActivateYieldGroupsSettings;
            BatchDeactivateYieldGroupsSettings = existing.BatchDeactivateYieldGroupsSettings;
            BatchArchiveYieldGroupsSettings = existing.BatchArchiveYieldGroupsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(YieldGroupServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YieldGroupServiceClient.GetYieldGroup</c> and <c>YieldGroupServiceClient.GetYieldGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetYieldGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YieldGroupServiceClient.ListYieldGroups</c> and <c>YieldGroupServiceClient.ListYieldGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListYieldGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YieldGroupServiceClient.CreateYieldGroup</c> and <c>YieldGroupServiceClient.CreateYieldGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateYieldGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YieldGroupServiceClient.BatchCreateYieldGroups</c> and
        /// <c>YieldGroupServiceClient.BatchCreateYieldGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCreateYieldGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YieldGroupServiceClient.UpdateYieldGroup</c> and <c>YieldGroupServiceClient.UpdateYieldGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateYieldGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YieldGroupServiceClient.BatchUpdateYieldGroups</c> and
        /// <c>YieldGroupServiceClient.BatchUpdateYieldGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchUpdateYieldGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YieldGroupServiceClient.BatchActivateYieldGroups</c> and
        /// <c>YieldGroupServiceClient.BatchActivateYieldGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchActivateYieldGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YieldGroupServiceClient.BatchDeactivateYieldGroups</c> and
        /// <c>YieldGroupServiceClient.BatchDeactivateYieldGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchDeactivateYieldGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>YieldGroupServiceClient.BatchArchiveYieldGroups</c> and
        /// <c>YieldGroupServiceClient.BatchArchiveYieldGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchArchiveYieldGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="YieldGroupServiceSettings"/> object.</returns>
        public YieldGroupServiceSettings Clone() => new YieldGroupServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="YieldGroupServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class YieldGroupServiceClientBuilder : gaxgrpc::ClientBuilderBase<YieldGroupServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public YieldGroupServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public YieldGroupServiceClientBuilder() : base(YieldGroupServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref YieldGroupServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<YieldGroupServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override YieldGroupServiceClient Build()
        {
            YieldGroupServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<YieldGroupServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<YieldGroupServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private YieldGroupServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return YieldGroupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<YieldGroupServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return YieldGroupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => YieldGroupServiceClient.ChannelPool;
    }

    /// <summary>YieldGroupService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `YieldGroup` objects.
    /// </remarks>
    public abstract partial class YieldGroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the YieldGroupService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default YieldGroupService scopes.</summary>
        /// <remarks>
        /// The default YieldGroupService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(YieldGroupService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="YieldGroupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="YieldGroupServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="YieldGroupServiceClient"/>.</returns>
        public static stt::Task<YieldGroupServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new YieldGroupServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="YieldGroupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="YieldGroupServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="YieldGroupServiceClient"/>.</returns>
        public static YieldGroupServiceClient Create() => new YieldGroupServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="YieldGroupServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="YieldGroupServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="YieldGroupServiceClient"/>.</returns>
        internal static YieldGroupServiceClient Create(grpccore::CallInvoker callInvoker, YieldGroupServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            YieldGroupService.YieldGroupServiceClient grpcClient = new YieldGroupService.YieldGroupServiceClient(callInvoker);
            return new YieldGroupServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC YieldGroupService client</summary>
        public virtual YieldGroupService.YieldGroupServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual YieldGroup GetYieldGroup(GetYieldGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> GetYieldGroupAsync(GetYieldGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> GetYieldGroupAsync(GetYieldGroupRequest request, st::CancellationToken cancellationToken) =>
            GetYieldGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `YieldGroup` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `YieldGroup`.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual YieldGroup GetYieldGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetYieldGroup(new GetYieldGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `YieldGroup` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `YieldGroup`.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> GetYieldGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetYieldGroupAsync(new GetYieldGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `YieldGroup` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `YieldGroup`.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> GetYieldGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetYieldGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `YieldGroup` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `YieldGroup`.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual YieldGroup GetYieldGroup(YieldGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetYieldGroup(new GetYieldGroupRequest
            {
                YieldGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `YieldGroup` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `YieldGroup`.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> GetYieldGroupAsync(YieldGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetYieldGroupAsync(new GetYieldGroupRequest
            {
                YieldGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a `YieldGroup` object.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the `YieldGroup`.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> GetYieldGroupAsync(YieldGroupName name, st::CancellationToken cancellationToken) =>
            GetYieldGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="YieldGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListYieldGroupsResponse, YieldGroup> ListYieldGroups(ListYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="YieldGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListYieldGroupsResponse, YieldGroup> ListYieldGroupsAsync(ListYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
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
        /// <returns>A pageable sequence of <see cref="YieldGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListYieldGroupsResponse, YieldGroup> ListYieldGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListYieldGroupsRequest request = new ListYieldGroupsRequest
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
            return ListYieldGroups(request, callSettings);
        }

        /// <summary>
        /// Lists `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="YieldGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListYieldGroupsResponse, YieldGroup> ListYieldGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListYieldGroupsRequest request = new ListYieldGroupsRequest
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
            return ListYieldGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
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
        /// <returns>A pageable sequence of <see cref="YieldGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListYieldGroupsResponse, YieldGroup> ListYieldGroups(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListYieldGroupsRequest request = new ListYieldGroupsRequest
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
            return ListYieldGroups(request, callSettings);
        }

        /// <summary>
        /// Lists `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="YieldGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListYieldGroupsResponse, YieldGroup> ListYieldGroupsAsync(NetworkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListYieldGroupsRequest request = new ListYieldGroupsRequest
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
            return ListYieldGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual YieldGroup CreateYieldGroup(CreateYieldGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> CreateYieldGroupAsync(CreateYieldGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> CreateYieldGroupAsync(CreateYieldGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateYieldGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `YieldGroup` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `YieldGroup` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="yieldGroup">
        /// Required. The `YieldGroup` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual YieldGroup CreateYieldGroup(string parent, YieldGroup yieldGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateYieldGroup(new CreateYieldGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                YieldGroup = gax::GaxPreconditions.CheckNotNull(yieldGroup, nameof(yieldGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a `YieldGroup` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `YieldGroup` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="yieldGroup">
        /// Required. The `YieldGroup` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> CreateYieldGroupAsync(string parent, YieldGroup yieldGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateYieldGroupAsync(new CreateYieldGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                YieldGroup = gax::GaxPreconditions.CheckNotNull(yieldGroup, nameof(yieldGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a `YieldGroup` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `YieldGroup` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="yieldGroup">
        /// Required. The `YieldGroup` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> CreateYieldGroupAsync(string parent, YieldGroup yieldGroup, st::CancellationToken cancellationToken) =>
            CreateYieldGroupAsync(parent, yieldGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `YieldGroup` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `YieldGroup` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="yieldGroup">
        /// Required. The `YieldGroup` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual YieldGroup CreateYieldGroup(NetworkName parent, YieldGroup yieldGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateYieldGroup(new CreateYieldGroupRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                YieldGroup = gax::GaxPreconditions.CheckNotNull(yieldGroup, nameof(yieldGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a `YieldGroup` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `YieldGroup` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="yieldGroup">
        /// Required. The `YieldGroup` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> CreateYieldGroupAsync(NetworkName parent, YieldGroup yieldGroup, gaxgrpc::CallSettings callSettings = null) =>
            CreateYieldGroupAsync(new CreateYieldGroupRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                YieldGroup = gax::GaxPreconditions.CheckNotNull(yieldGroup, nameof(yieldGroup)),
            }, callSettings);

        /// <summary>
        /// Creates a `YieldGroup` object.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this `YieldGroup` will be created.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="yieldGroup">
        /// Required. The `YieldGroup` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> CreateYieldGroupAsync(NetworkName parent, YieldGroup yieldGroup, st::CancellationToken cancellationToken) =>
            CreateYieldGroupAsync(parent, yieldGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateYieldGroupsResponse BatchCreateYieldGroups(BatchCreateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateYieldGroupsResponse> BatchCreateYieldGroupsAsync(BatchCreateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch creates `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateYieldGroupsResponse> BatchCreateYieldGroupsAsync(BatchCreateYieldGroupsRequest request, st::CancellationToken cancellationToken) =>
            BatchCreateYieldGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `YieldGroups` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the `CreateYieldGroupRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `YieldGroup` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateYieldGroupsResponse BatchCreateYieldGroups(string parent, scg::IEnumerable<CreateYieldGroupRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateYieldGroups(new BatchCreateYieldGroupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `YieldGroups` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the `CreateYieldGroupRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `YieldGroup` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateYieldGroupsResponse> BatchCreateYieldGroupsAsync(string parent, scg::IEnumerable<CreateYieldGroupRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateYieldGroupsAsync(new BatchCreateYieldGroupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `YieldGroups` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the `CreateYieldGroupRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `YieldGroup` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateYieldGroupsResponse> BatchCreateYieldGroupsAsync(string parent, scg::IEnumerable<CreateYieldGroupRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateYieldGroupsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch creates `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `YieldGroups` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the `CreateYieldGroupRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `YieldGroup` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCreateYieldGroupsResponse BatchCreateYieldGroups(NetworkName parent, scg::IEnumerable<CreateYieldGroupRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateYieldGroups(new BatchCreateYieldGroupsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `YieldGroups` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the `CreateYieldGroupRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `YieldGroup` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateYieldGroupsResponse> BatchCreateYieldGroupsAsync(NetworkName parent, scg::IEnumerable<CreateYieldGroupRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchCreateYieldGroupsAsync(new BatchCreateYieldGroupsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch creates `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `YieldGroups` will be created.
        /// Format: `networks/{network_code}`
        /// The parent field in the `CreateYieldGroupRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `YieldGroup` objects to create.
        /// A maximum of 100 objects can be created in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCreateYieldGroupsResponse> BatchCreateYieldGroupsAsync(NetworkName parent, scg::IEnumerable<CreateYieldGroupRequest> requests, st::CancellationToken cancellationToken) =>
            BatchCreateYieldGroupsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual YieldGroup UpdateYieldGroup(UpdateYieldGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> UpdateYieldGroupAsync(UpdateYieldGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> UpdateYieldGroupAsync(UpdateYieldGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateYieldGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `YieldGroup` object.
        /// </summary>
        /// <param name="yieldGroup">
        /// Required. The `YieldGroup` to update.
        /// 
        /// The `YieldGroup`'s `name` is used to identify the `YieldGroup` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual YieldGroup UpdateYieldGroup(YieldGroup yieldGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateYieldGroup(new UpdateYieldGroupRequest
            {
                YieldGroup = gax::GaxPreconditions.CheckNotNull(yieldGroup, nameof(yieldGroup)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `YieldGroup` object.
        /// </summary>
        /// <param name="yieldGroup">
        /// Required. The `YieldGroup` to update.
        /// 
        /// The `YieldGroup`'s `name` is used to identify the `YieldGroup` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> UpdateYieldGroupAsync(YieldGroup yieldGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateYieldGroupAsync(new UpdateYieldGroupRequest
            {
                YieldGroup = gax::GaxPreconditions.CheckNotNull(yieldGroup, nameof(yieldGroup)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `YieldGroup` object.
        /// </summary>
        /// <param name="yieldGroup">
        /// Required. The `YieldGroup` to update.
        /// 
        /// The `YieldGroup`'s `name` is used to identify the `YieldGroup` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<YieldGroup> UpdateYieldGroupAsync(YieldGroup yieldGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateYieldGroupAsync(yieldGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateYieldGroupsResponse BatchUpdateYieldGroups(BatchUpdateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateYieldGroupsResponse> BatchUpdateYieldGroupsAsync(BatchUpdateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Batch updates `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateYieldGroupsResponse> BatchUpdateYieldGroupsAsync(BatchUpdateYieldGroupsRequest request, st::CancellationToken cancellationToken) =>
            BatchUpdateYieldGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `YieldGroups` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the `UpdateYieldGroupRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `YieldGroup` objects to update.
        /// A maximum of 10 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateYieldGroupsResponse BatchUpdateYieldGroups(string parent, scg::IEnumerable<UpdateYieldGroupRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateYieldGroups(new BatchUpdateYieldGroupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `YieldGroups` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the `UpdateYieldGroupRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `YieldGroup` objects to update.
        /// A maximum of 10 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateYieldGroupsResponse> BatchUpdateYieldGroupsAsync(string parent, scg::IEnumerable<UpdateYieldGroupRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateYieldGroupsAsync(new BatchUpdateYieldGroupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `YieldGroups` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the `UpdateYieldGroupRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `YieldGroup` objects to update.
        /// A maximum of 10 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateYieldGroupsResponse> BatchUpdateYieldGroupsAsync(string parent, scg::IEnumerable<UpdateYieldGroupRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateYieldGroupsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Batch updates `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `YieldGroups` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the `UpdateYieldGroupRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `YieldGroup` objects to update.
        /// A maximum of 10 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchUpdateYieldGroupsResponse BatchUpdateYieldGroups(NetworkName parent, scg::IEnumerable<UpdateYieldGroupRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateYieldGroups(new BatchUpdateYieldGroupsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `YieldGroups` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the `UpdateYieldGroupRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `YieldGroup` objects to update.
        /// A maximum of 10 objects can be updated in a batch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateYieldGroupsResponse> BatchUpdateYieldGroupsAsync(NetworkName parent, scg::IEnumerable<UpdateYieldGroupRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchUpdateYieldGroupsAsync(new BatchUpdateYieldGroupsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Batch updates `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where `YieldGroups` will be updated.
        /// Format: `networks/{network_code}`
        /// The parent field in the `UpdateYieldGroupRequest` must match this
        /// field.
        /// </param>
        /// <param name="requests">
        /// Required. The `YieldGroup` objects to update.
        /// A maximum of 10 objects can be updated in a batch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchUpdateYieldGroupsResponse> BatchUpdateYieldGroupsAsync(NetworkName parent, scg::IEnumerable<UpdateYieldGroupRequest> requests, st::CancellationToken cancellationToken) =>
            BatchUpdateYieldGroupsAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateYieldGroupsResponse BatchActivateYieldGroups(BatchActivateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateYieldGroupsResponse> BatchActivateYieldGroupsAsync(BatchActivateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateYieldGroupsResponse> BatchActivateYieldGroupsAsync(BatchActivateYieldGroupsRequest request, st::CancellationToken cancellationToken) =>
            BatchActivateYieldGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to activate.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateYieldGroupsResponse BatchActivateYieldGroups(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateYieldGroups(new BatchActivateYieldGroupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to activate.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateYieldGroupsResponse> BatchActivateYieldGroupsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateYieldGroupsAsync(new BatchActivateYieldGroupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to activate.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateYieldGroupsResponse> BatchActivateYieldGroupsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchActivateYieldGroupsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to activate.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchActivateYieldGroupsResponse BatchActivateYieldGroups(NetworkName parent, scg::IEnumerable<YieldGroupName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateYieldGroups(new BatchActivateYieldGroupsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                YieldGroupNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to activate.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateYieldGroupsResponse> BatchActivateYieldGroupsAsync(NetworkName parent, scg::IEnumerable<YieldGroupName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchActivateYieldGroupsAsync(new BatchActivateYieldGroupsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                YieldGroupNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Activates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to activate.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchActivateYieldGroupsResponse> BatchActivateYieldGroupsAsync(NetworkName parent, scg::IEnumerable<YieldGroupName> names, st::CancellationToken cancellationToken) =>
            BatchActivateYieldGroupsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateYieldGroupsResponse BatchDeactivateYieldGroups(BatchDeactivateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateYieldGroupsResponse> BatchDeactivateYieldGroupsAsync(BatchDeactivateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deactivates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateYieldGroupsResponse> BatchDeactivateYieldGroupsAsync(BatchDeactivateYieldGroupsRequest request, st::CancellationToken cancellationToken) =>
            BatchDeactivateYieldGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to deactivate.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateYieldGroupsResponse BatchDeactivateYieldGroups(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateYieldGroups(new BatchDeactivateYieldGroupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to deactivate.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateYieldGroupsResponse> BatchDeactivateYieldGroupsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateYieldGroupsAsync(new BatchDeactivateYieldGroupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to deactivate.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateYieldGroupsResponse> BatchDeactivateYieldGroupsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateYieldGroupsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deactivates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to deactivate.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchDeactivateYieldGroupsResponse BatchDeactivateYieldGroups(NetworkName parent, scg::IEnumerable<YieldGroupName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateYieldGroups(new BatchDeactivateYieldGroupsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                YieldGroupNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to deactivate.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateYieldGroupsResponse> BatchDeactivateYieldGroupsAsync(NetworkName parent, scg::IEnumerable<YieldGroupName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchDeactivateYieldGroupsAsync(new BatchDeactivateYieldGroupsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                YieldGroupNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Deactivates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to deactivate.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchDeactivateYieldGroupsResponse> BatchDeactivateYieldGroupsAsync(NetworkName parent, scg::IEnumerable<YieldGroupName> names, st::CancellationToken cancellationToken) =>
            BatchDeactivateYieldGroupsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveYieldGroupsResponse BatchArchiveYieldGroups(BatchArchiveYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveYieldGroupsResponse> BatchArchiveYieldGroupsAsync(BatchArchiveYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Archives a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveYieldGroupsResponse> BatchArchiveYieldGroupsAsync(BatchArchiveYieldGroupsRequest request, st::CancellationToken cancellationToken) =>
            BatchArchiveYieldGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to archive.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveYieldGroupsResponse BatchArchiveYieldGroups(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveYieldGroups(new BatchArchiveYieldGroupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to archive.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveYieldGroupsResponse> BatchArchiveYieldGroupsAsync(string parent, scg::IEnumerable<string> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveYieldGroupsAsync(new BatchArchiveYieldGroupsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Names =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to archive.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveYieldGroupsResponse> BatchArchiveYieldGroupsAsync(string parent, scg::IEnumerable<string> names, st::CancellationToken cancellationToken) =>
            BatchArchiveYieldGroupsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Archives a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to archive.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchArchiveYieldGroupsResponse BatchArchiveYieldGroups(NetworkName parent, scg::IEnumerable<YieldGroupName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveYieldGroups(new BatchArchiveYieldGroupsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                YieldGroupNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to archive.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveYieldGroupsResponse> BatchArchiveYieldGroupsAsync(NetworkName parent, scg::IEnumerable<YieldGroupName> names, gaxgrpc::CallSettings callSettings = null) =>
            BatchArchiveYieldGroupsAsync(new BatchArchiveYieldGroupsRequest
            {
                ParentAsNetworkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                YieldGroupNames =
                {
                    gax::GaxPreconditions.CheckNotNull(names, nameof(names)),
                },
            }, callSettings);

        /// <summary>
        /// Archives a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of `YieldGroups`.
        /// Format: `networks/{network_code}`
        /// </param>
        /// <param name="names">
        /// Required. The resource names of the `YieldGroups` to archive.
        /// Format: `networks/{network_code}/yieldGroups/{yield_group_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchArchiveYieldGroupsResponse> BatchArchiveYieldGroupsAsync(NetworkName parent, scg::IEnumerable<YieldGroupName> names, st::CancellationToken cancellationToken) =>
            BatchArchiveYieldGroupsAsync(parent, names, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>YieldGroupService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `YieldGroup` objects.
    /// </remarks>
    public sealed partial class YieldGroupServiceClientImpl : YieldGroupServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetYieldGroupRequest, YieldGroup> _callGetYieldGroup;

        private readonly gaxgrpc::ApiCall<ListYieldGroupsRequest, ListYieldGroupsResponse> _callListYieldGroups;

        private readonly gaxgrpc::ApiCall<CreateYieldGroupRequest, YieldGroup> _callCreateYieldGroup;

        private readonly gaxgrpc::ApiCall<BatchCreateYieldGroupsRequest, BatchCreateYieldGroupsResponse> _callBatchCreateYieldGroups;

        private readonly gaxgrpc::ApiCall<UpdateYieldGroupRequest, YieldGroup> _callUpdateYieldGroup;

        private readonly gaxgrpc::ApiCall<BatchUpdateYieldGroupsRequest, BatchUpdateYieldGroupsResponse> _callBatchUpdateYieldGroups;

        private readonly gaxgrpc::ApiCall<BatchActivateYieldGroupsRequest, BatchActivateYieldGroupsResponse> _callBatchActivateYieldGroups;

        private readonly gaxgrpc::ApiCall<BatchDeactivateYieldGroupsRequest, BatchDeactivateYieldGroupsResponse> _callBatchDeactivateYieldGroups;

        private readonly gaxgrpc::ApiCall<BatchArchiveYieldGroupsRequest, BatchArchiveYieldGroupsResponse> _callBatchArchiveYieldGroups;

        /// <summary>
        /// Constructs a client wrapper for the YieldGroupService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="YieldGroupServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public YieldGroupServiceClientImpl(YieldGroupService.YieldGroupServiceClient grpcClient, YieldGroupServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            YieldGroupServiceSettings effectiveSettings = settings ?? YieldGroupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetYieldGroup = clientHelper.BuildApiCall<GetYieldGroupRequest, YieldGroup>("GetYieldGroup", grpcClient.GetYieldGroupAsync, grpcClient.GetYieldGroup, effectiveSettings.GetYieldGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetYieldGroup);
            Modify_GetYieldGroupApiCall(ref _callGetYieldGroup);
            _callListYieldGroups = clientHelper.BuildApiCall<ListYieldGroupsRequest, ListYieldGroupsResponse>("ListYieldGroups", grpcClient.ListYieldGroupsAsync, grpcClient.ListYieldGroups, effectiveSettings.ListYieldGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListYieldGroups);
            Modify_ListYieldGroupsApiCall(ref _callListYieldGroups);
            _callCreateYieldGroup = clientHelper.BuildApiCall<CreateYieldGroupRequest, YieldGroup>("CreateYieldGroup", grpcClient.CreateYieldGroupAsync, grpcClient.CreateYieldGroup, effectiveSettings.CreateYieldGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateYieldGroup);
            Modify_CreateYieldGroupApiCall(ref _callCreateYieldGroup);
            _callBatchCreateYieldGroups = clientHelper.BuildApiCall<BatchCreateYieldGroupsRequest, BatchCreateYieldGroupsResponse>("BatchCreateYieldGroups", grpcClient.BatchCreateYieldGroupsAsync, grpcClient.BatchCreateYieldGroups, effectiveSettings.BatchCreateYieldGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCreateYieldGroups);
            Modify_BatchCreateYieldGroupsApiCall(ref _callBatchCreateYieldGroups);
            _callUpdateYieldGroup = clientHelper.BuildApiCall<UpdateYieldGroupRequest, YieldGroup>("UpdateYieldGroup", grpcClient.UpdateYieldGroupAsync, grpcClient.UpdateYieldGroup, effectiveSettings.UpdateYieldGroupSettings).WithGoogleRequestParam("yield_group.name", request => request.YieldGroup?.Name);
            Modify_ApiCall(ref _callUpdateYieldGroup);
            Modify_UpdateYieldGroupApiCall(ref _callUpdateYieldGroup);
            _callBatchUpdateYieldGroups = clientHelper.BuildApiCall<BatchUpdateYieldGroupsRequest, BatchUpdateYieldGroupsResponse>("BatchUpdateYieldGroups", grpcClient.BatchUpdateYieldGroupsAsync, grpcClient.BatchUpdateYieldGroups, effectiveSettings.BatchUpdateYieldGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchUpdateYieldGroups);
            Modify_BatchUpdateYieldGroupsApiCall(ref _callBatchUpdateYieldGroups);
            _callBatchActivateYieldGroups = clientHelper.BuildApiCall<BatchActivateYieldGroupsRequest, BatchActivateYieldGroupsResponse>("BatchActivateYieldGroups", grpcClient.BatchActivateYieldGroupsAsync, grpcClient.BatchActivateYieldGroups, effectiveSettings.BatchActivateYieldGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchActivateYieldGroups);
            Modify_BatchActivateYieldGroupsApiCall(ref _callBatchActivateYieldGroups);
            _callBatchDeactivateYieldGroups = clientHelper.BuildApiCall<BatchDeactivateYieldGroupsRequest, BatchDeactivateYieldGroupsResponse>("BatchDeactivateYieldGroups", grpcClient.BatchDeactivateYieldGroupsAsync, grpcClient.BatchDeactivateYieldGroups, effectiveSettings.BatchDeactivateYieldGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchDeactivateYieldGroups);
            Modify_BatchDeactivateYieldGroupsApiCall(ref _callBatchDeactivateYieldGroups);
            _callBatchArchiveYieldGroups = clientHelper.BuildApiCall<BatchArchiveYieldGroupsRequest, BatchArchiveYieldGroupsResponse>("BatchArchiveYieldGroups", grpcClient.BatchArchiveYieldGroupsAsync, grpcClient.BatchArchiveYieldGroups, effectiveSettings.BatchArchiveYieldGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchArchiveYieldGroups);
            Modify_BatchArchiveYieldGroupsApiCall(ref _callBatchArchiveYieldGroups);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetYieldGroupApiCall(ref gaxgrpc::ApiCall<GetYieldGroupRequest, YieldGroup> call);

        partial void Modify_ListYieldGroupsApiCall(ref gaxgrpc::ApiCall<ListYieldGroupsRequest, ListYieldGroupsResponse> call);

        partial void Modify_CreateYieldGroupApiCall(ref gaxgrpc::ApiCall<CreateYieldGroupRequest, YieldGroup> call);

        partial void Modify_BatchCreateYieldGroupsApiCall(ref gaxgrpc::ApiCall<BatchCreateYieldGroupsRequest, BatchCreateYieldGroupsResponse> call);

        partial void Modify_UpdateYieldGroupApiCall(ref gaxgrpc::ApiCall<UpdateYieldGroupRequest, YieldGroup> call);

        partial void Modify_BatchUpdateYieldGroupsApiCall(ref gaxgrpc::ApiCall<BatchUpdateYieldGroupsRequest, BatchUpdateYieldGroupsResponse> call);

        partial void Modify_BatchActivateYieldGroupsApiCall(ref gaxgrpc::ApiCall<BatchActivateYieldGroupsRequest, BatchActivateYieldGroupsResponse> call);

        partial void Modify_BatchDeactivateYieldGroupsApiCall(ref gaxgrpc::ApiCall<BatchDeactivateYieldGroupsRequest, BatchDeactivateYieldGroupsResponse> call);

        partial void Modify_BatchArchiveYieldGroupsApiCall(ref gaxgrpc::ApiCall<BatchArchiveYieldGroupsRequest, BatchArchiveYieldGroupsResponse> call);

        partial void OnConstruction(YieldGroupService.YieldGroupServiceClient grpcClient, YieldGroupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC YieldGroupService client</summary>
        public override YieldGroupService.YieldGroupServiceClient GrpcClient { get; }

        partial void Modify_GetYieldGroupRequest(ref GetYieldGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListYieldGroupsRequest(ref ListYieldGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateYieldGroupRequest(ref CreateYieldGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCreateYieldGroupsRequest(ref BatchCreateYieldGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateYieldGroupRequest(ref UpdateYieldGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchUpdateYieldGroupsRequest(ref BatchUpdateYieldGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchActivateYieldGroupsRequest(ref BatchActivateYieldGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchDeactivateYieldGroupsRequest(ref BatchDeactivateYieldGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchArchiveYieldGroupsRequest(ref BatchArchiveYieldGroupsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override YieldGroup GetYieldGroup(GetYieldGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetYieldGroupRequest(ref request, ref callSettings);
            return _callGetYieldGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<YieldGroup> GetYieldGroupAsync(GetYieldGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetYieldGroupRequest(ref request, ref callSettings);
            return _callGetYieldGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Lists `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="YieldGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListYieldGroupsResponse, YieldGroup> ListYieldGroups(ListYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListYieldGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListYieldGroupsRequest, ListYieldGroupsResponse, YieldGroup>(_callListYieldGroups, request, callSettings);
        }

        /// <summary>
        /// Lists `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="YieldGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListYieldGroupsResponse, YieldGroup> ListYieldGroupsAsync(ListYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListYieldGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListYieldGroupsRequest, ListYieldGroupsResponse, YieldGroup>(_callListYieldGroups, request, callSettings);
        }

        /// <summary>
        /// Creates a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override YieldGroup CreateYieldGroup(CreateYieldGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateYieldGroupRequest(ref request, ref callSettings);
            return _callCreateYieldGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<YieldGroup> CreateYieldGroupAsync(CreateYieldGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateYieldGroupRequest(ref request, ref callSettings);
            return _callCreateYieldGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Batch creates `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCreateYieldGroupsResponse BatchCreateYieldGroups(BatchCreateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateYieldGroupsRequest(ref request, ref callSettings);
            return _callBatchCreateYieldGroups.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch creates `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCreateYieldGroupsResponse> BatchCreateYieldGroupsAsync(BatchCreateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCreateYieldGroupsRequest(ref request, ref callSettings);
            return _callBatchCreateYieldGroups.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override YieldGroup UpdateYieldGroup(UpdateYieldGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateYieldGroupRequest(ref request, ref callSettings);
            return _callUpdateYieldGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `YieldGroup` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<YieldGroup> UpdateYieldGroupAsync(UpdateYieldGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateYieldGroupRequest(ref request, ref callSettings);
            return _callUpdateYieldGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Batch updates `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchUpdateYieldGroupsResponse BatchUpdateYieldGroups(BatchUpdateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateYieldGroupsRequest(ref request, ref callSettings);
            return _callBatchUpdateYieldGroups.Sync(request, callSettings);
        }

        /// <summary>
        /// Batch updates `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchUpdateYieldGroupsResponse> BatchUpdateYieldGroupsAsync(BatchUpdateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchUpdateYieldGroupsRequest(ref request, ref callSettings);
            return _callBatchUpdateYieldGroups.Async(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchActivateYieldGroupsResponse BatchActivateYieldGroups(BatchActivateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateYieldGroupsRequest(ref request, ref callSettings);
            return _callBatchActivateYieldGroups.Sync(request, callSettings);
        }

        /// <summary>
        /// Activates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchActivateYieldGroupsResponse> BatchActivateYieldGroupsAsync(BatchActivateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchActivateYieldGroupsRequest(ref request, ref callSettings);
            return _callBatchActivateYieldGroups.Async(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchDeactivateYieldGroupsResponse BatchDeactivateYieldGroups(BatchDeactivateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateYieldGroupsRequest(ref request, ref callSettings);
            return _callBatchDeactivateYieldGroups.Sync(request, callSettings);
        }

        /// <summary>
        /// Deactivates a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchDeactivateYieldGroupsResponse> BatchDeactivateYieldGroupsAsync(BatchDeactivateYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchDeactivateYieldGroupsRequest(ref request, ref callSettings);
            return _callBatchDeactivateYieldGroups.Async(request, callSettings);
        }

        /// <summary>
        /// Archives a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchArchiveYieldGroupsResponse BatchArchiveYieldGroups(BatchArchiveYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveYieldGroupsRequest(ref request, ref callSettings);
            return _callBatchArchiveYieldGroups.Sync(request, callSettings);
        }

        /// <summary>
        /// Archives a list of `YieldGroup` objects.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchArchiveYieldGroupsResponse> BatchArchiveYieldGroupsAsync(BatchArchiveYieldGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchArchiveYieldGroupsRequest(ref request, ref callSettings);
            return _callBatchArchiveYieldGroups.Async(request, callSettings);
        }
    }

    public partial class ListYieldGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListYieldGroupsResponse : gaxgrpc::IPageResponse<YieldGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<YieldGroup> GetEnumerator() => YieldGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
