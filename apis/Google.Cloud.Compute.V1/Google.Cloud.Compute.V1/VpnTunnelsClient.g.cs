// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;

using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="VpnTunnelsClient"/> instances.</summary>
    public sealed partial class VpnTunnelsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VpnTunnelsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VpnTunnelsSettings"/>.</returns>
        public static VpnTunnelsSettings GetDefault() => new VpnTunnelsSettings();

        /// <summary>Constructs a new <see cref="VpnTunnelsSettings"/> object with default settings.</summary>
        public VpnTunnelsSettings()
        {
        }

        private VpnTunnelsSettings(VpnTunnelsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AggregatedListSettings = existing.AggregatedListSettings;
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(VpnTunnelsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VpnTunnelsClient.AggregatedList</c> and <c>VpnTunnelsClient.AggregatedListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>VpnTunnelsClient.Delete</c>
        /// and <c>VpnTunnelsClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>VpnTunnelsClient.Get</c>
        /// and <c>VpnTunnelsClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>VpnTunnelsClient.Insert</c>
        /// and <c>VpnTunnelsClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>VpnTunnelsClient.List</c>
        /// and <c>VpnTunnelsClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VpnTunnelsSettings"/> object.</returns>
        public VpnTunnelsSettings Clone() => new VpnTunnelsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VpnTunnelsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class VpnTunnelsClientBuilder : gaxgrpc::ClientBuilderBase<VpnTunnelsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VpnTunnelsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VpnTunnelsClientBuilder()
        {
            UseJwtAccessWithScopes = VpnTunnelsClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref VpnTunnelsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VpnTunnelsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VpnTunnelsClient Build()
        {
            VpnTunnelsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VpnTunnelsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VpnTunnelsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VpnTunnelsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VpnTunnelsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<VpnTunnelsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VpnTunnelsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => VpnTunnelsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => VpnTunnelsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VpnTunnelsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>VpnTunnels client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The VpnTunnels API.
    /// </remarks>
    public abstract partial class VpnTunnelsClient
    {
        /// <summary>
        /// The default endpoint for the VpnTunnels service, which is a host of "compute.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default VpnTunnels scopes.</summary>
        /// <remarks>
        /// The default VpnTunnels scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="VpnTunnelsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VpnTunnelsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VpnTunnelsClient"/>.</returns>
        public static stt::Task<VpnTunnelsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VpnTunnelsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VpnTunnelsClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="VpnTunnelsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VpnTunnelsClient"/>.</returns>
        public static VpnTunnelsClient Create() => new VpnTunnelsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VpnTunnelsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VpnTunnelsSettings"/>.</param>
        /// <returns>The created <see cref="VpnTunnelsClient"/>.</returns>
        internal static VpnTunnelsClient Create(grpccore::CallInvoker callInvoker, VpnTunnelsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VpnTunnels.VpnTunnelsClient grpcClient = new VpnTunnels.VpnTunnelsClient(callInvoker);
            return new VpnTunnelsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC VpnTunnels client</summary>
        public virtual VpnTunnels.VpnTunnelsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of VPN tunnels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<VpnTunnelAggregatedList, scg::KeyValuePair<string, VpnTunnelsScopedList>> AggregatedList(AggregatedListVpnTunnelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of VPN tunnels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<VpnTunnelAggregatedList, scg::KeyValuePair<string, VpnTunnelsScopedList>> AggregatedListAsync(AggregatedListVpnTunnelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of VPN tunnels.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<VpnTunnelAggregatedList, scg::KeyValuePair<string, VpnTunnelsScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedList(new AggregatedListVpnTunnelsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves an aggregated list of VPN tunnels.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<VpnTunnelAggregatedList, scg::KeyValuePair<string, VpnTunnelsScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedListAsync(new AggregatedListVpnTunnelsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes the specified VpnTunnel resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteVpnTunnelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified VpnTunnel resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteVpnTunnelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified VpnTunnel resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteVpnTunnelRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified VpnTunnel resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="vpnTunnel">
        /// Name of the VpnTunnel resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string region, string vpnTunnel, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteVpnTunnelRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                VpnTunnel = gax::GaxPreconditions.CheckNotNullOrEmpty(vpnTunnel, nameof(vpnTunnel)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified VpnTunnel resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="vpnTunnel">
        /// Name of the VpnTunnel resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string vpnTunnel, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteVpnTunnelRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                VpnTunnel = gax::GaxPreconditions.CheckNotNullOrEmpty(vpnTunnel, nameof(vpnTunnel)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified VpnTunnel resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="vpnTunnel">
        /// Name of the VpnTunnel resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string vpnTunnel, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, vpnTunnel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified VpnTunnel resource. Gets a list of available VPN tunnels by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VpnTunnel Get(GetVpnTunnelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified VpnTunnel resource. Gets a list of available VPN tunnels by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VpnTunnel> GetAsync(GetVpnTunnelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified VpnTunnel resource. Gets a list of available VPN tunnels by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VpnTunnel> GetAsync(GetVpnTunnelRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified VpnTunnel resource. Gets a list of available VPN tunnels by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="vpnTunnel">
        /// Name of the VpnTunnel resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual VpnTunnel Get(string project, string region, string vpnTunnel, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetVpnTunnelRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                VpnTunnel = gax::GaxPreconditions.CheckNotNullOrEmpty(vpnTunnel, nameof(vpnTunnel)),
            }, callSettings);

        /// <summary>
        /// Returns the specified VpnTunnel resource. Gets a list of available VPN tunnels by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="vpnTunnel">
        /// Name of the VpnTunnel resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VpnTunnel> GetAsync(string project, string region, string vpnTunnel, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetVpnTunnelRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                VpnTunnel = gax::GaxPreconditions.CheckNotNullOrEmpty(vpnTunnel, nameof(vpnTunnel)),
            }, callSettings);

        /// <summary>
        /// Returns the specified VpnTunnel resource. Gets a list of available VPN tunnels by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="vpnTunnel">
        /// Name of the VpnTunnel resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<VpnTunnel> GetAsync(string project, string region, string vpnTunnel, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, vpnTunnel, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a VpnTunnel resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertVpnTunnelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a VpnTunnel resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertVpnTunnelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a VpnTunnel resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertVpnTunnelRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a VpnTunnel resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="vpnTunnelResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, string region, VpnTunnel vpnTunnelResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertVpnTunnelRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                VpnTunnelResource = gax::GaxPreconditions.CheckNotNull(vpnTunnelResource, nameof(vpnTunnelResource)),
            }, callSettings);

        /// <summary>
        /// Creates a VpnTunnel resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="vpnTunnelResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, VpnTunnel vpnTunnelResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertVpnTunnelRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                VpnTunnelResource = gax::GaxPreconditions.CheckNotNull(vpnTunnelResource, nameof(vpnTunnelResource)),
            }, callSettings);

        /// <summary>
        /// Creates a VpnTunnel resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="vpnTunnelResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, VpnTunnel vpnTunnelResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, vpnTunnelResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of VpnTunnel resources contained in the specified project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VpnTunnel"/> resources.</returns>
        public virtual gax::PagedEnumerable<VpnTunnelList, VpnTunnel> List(ListVpnTunnelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of VpnTunnel resources contained in the specified project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VpnTunnel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<VpnTunnelList, VpnTunnel> ListAsync(ListVpnTunnelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of VpnTunnel resources contained in the specified project and region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
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
        /// <returns>A pageable sequence of <see cref="VpnTunnel"/> resources.</returns>
        public virtual gax::PagedEnumerable<VpnTunnelList, VpnTunnel> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListVpnTunnelsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of VpnTunnel resources contained in the specified project and region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VpnTunnel"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<VpnTunnelList, VpnTunnel> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListVpnTunnelsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>VpnTunnels client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The VpnTunnels API.
    /// </remarks>
    public sealed partial class VpnTunnelsClientImpl : VpnTunnelsClient
    {
        private readonly gaxgrpc::ApiCall<AggregatedListVpnTunnelsRequest, VpnTunnelAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<DeleteVpnTunnelRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetVpnTunnelRequest, VpnTunnel> _callGet;

        private readonly gaxgrpc::ApiCall<InsertVpnTunnelRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListVpnTunnelsRequest, VpnTunnelList> _callList;

        /// <summary>
        /// Constructs a client wrapper for the VpnTunnels service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VpnTunnelsSettings"/> used within this client.</param>
        public VpnTunnelsClientImpl(VpnTunnels.VpnTunnelsClient grpcClient, VpnTunnelsSettings settings)
        {
            GrpcClient = grpcClient;
            VpnTunnelsSettings effectiveSettings = settings ?? VpnTunnelsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListVpnTunnelsRequest, VpnTunnelAggregatedList>(grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callDelete = clientHelper.BuildApiCall<DeleteVpnTunnelRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("vpn_tunnel", request => request.VpnTunnel);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetVpnTunnelRequest, VpnTunnel>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("vpn_tunnel", request => request.VpnTunnel);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertVpnTunnelRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListVpnTunnelsRequest, VpnTunnelList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListVpnTunnelsRequest, VpnTunnelAggregatedList> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteVpnTunnelRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetVpnTunnelRequest, VpnTunnel> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertVpnTunnelRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListVpnTunnelsRequest, VpnTunnelList> call);

        partial void OnConstruction(VpnTunnels.VpnTunnelsClient grpcClient, VpnTunnelsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VpnTunnels client</summary>
        public override VpnTunnels.VpnTunnelsClient GrpcClient { get; }

        partial void Modify_AggregatedListVpnTunnelsRequest(ref AggregatedListVpnTunnelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVpnTunnelRequest(ref DeleteVpnTunnelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVpnTunnelRequest(ref GetVpnTunnelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertVpnTunnelRequest(ref InsertVpnTunnelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVpnTunnelsRequest(ref ListVpnTunnelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves an aggregated list of VPN tunnels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<VpnTunnelAggregatedList, scg::KeyValuePair<string, VpnTunnelsScopedList>> AggregatedList(AggregatedListVpnTunnelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListVpnTunnelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListVpnTunnelsRequest, VpnTunnelAggregatedList, scg::KeyValuePair<string, VpnTunnelsScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves an aggregated list of VPN tunnels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<VpnTunnelAggregatedList, scg::KeyValuePair<string, VpnTunnelsScopedList>> AggregatedListAsync(AggregatedListVpnTunnelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListVpnTunnelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListVpnTunnelsRequest, VpnTunnelAggregatedList, scg::KeyValuePair<string, VpnTunnelsScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Deletes the specified VpnTunnel resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteVpnTunnelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVpnTunnelRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified VpnTunnel resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteVpnTunnelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVpnTunnelRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified VpnTunnel resource. Gets a list of available VPN tunnels by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override VpnTunnel Get(GetVpnTunnelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVpnTunnelRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified VpnTunnel resource. Gets a list of available VPN tunnels by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<VpnTunnel> GetAsync(GetVpnTunnelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVpnTunnelRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a VpnTunnel resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertVpnTunnelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertVpnTunnelRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a VpnTunnel resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertVpnTunnelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertVpnTunnelRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of VpnTunnel resources contained in the specified project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VpnTunnel"/> resources.</returns>
        public override gax::PagedEnumerable<VpnTunnelList, VpnTunnel> List(ListVpnTunnelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVpnTunnelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVpnTunnelsRequest, VpnTunnelList, VpnTunnel>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of VpnTunnel resources contained in the specified project and region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VpnTunnel"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<VpnTunnelList, VpnTunnel> ListAsync(ListVpnTunnelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVpnTunnelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVpnTunnelsRequest, VpnTunnelList, VpnTunnel>(_callList, request, callSettings);
        }
    }

    public partial class AggregatedListVpnTunnelsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListVpnTunnelsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class VpnTunnelAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, VpnTunnelsScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, VpnTunnelsScopedList>> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class VpnTunnelList : gaxgrpc::IPageResponse<VpnTunnel>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<VpnTunnel> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
