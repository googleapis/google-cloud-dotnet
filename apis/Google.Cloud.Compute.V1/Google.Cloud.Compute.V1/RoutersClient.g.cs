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
    /// <summary>Settings for <see cref="RoutersClient"/> instances.</summary>
    public sealed partial class RoutersSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RoutersSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RoutersSettings"/>.</returns>
        public static RoutersSettings GetDefault() => new RoutersSettings();

        /// <summary>Constructs a new <see cref="RoutersSettings"/> object with default settings.</summary>
        public RoutersSettings()
        {
        }

        private RoutersSettings(RoutersSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AggregatedListSettings = existing.AggregatedListSettings;
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            GetNatMappingInfoSettings = existing.GetNatMappingInfoSettings;
            GetRouterStatusSettings = existing.GetRouterStatusSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            PreviewSettings = existing.PreviewSettings;
            UpdateSettings = existing.UpdateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RoutersSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RoutersClient.AggregatedList</c> and <c>RoutersClient.AggregatedListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RoutersClient.Delete</c>
        /// and <c>RoutersClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RoutersClient.Get</c> and
        /// <c>RoutersClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RoutersClient.GetNatMappingInfo</c> and <c>RoutersClient.GetNatMappingInfoAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNatMappingInfoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RoutersClient.GetRouterStatus</c> and <c>RoutersClient.GetRouterStatusAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRouterStatusSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RoutersClient.Insert</c>
        /// and <c>RoutersClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RoutersClient.List</c> and
        /// <c>RoutersClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RoutersClient.Patch</c> and
        /// <c>RoutersClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RoutersClient.Preview</c>
        /// and <c>RoutersClient.PreviewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PreviewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RoutersClient.Update</c>
        /// and <c>RoutersClient.UpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RoutersSettings"/> object.</returns>
        public RoutersSettings Clone() => new RoutersSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RoutersClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class RoutersClientBuilder : gaxgrpc::ClientBuilderBase<RoutersClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RoutersSettings Settings { get; set; }

        partial void InterceptBuild(ref RoutersClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RoutersClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RoutersClient Build()
        {
            RoutersClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RoutersClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RoutersClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RoutersClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RoutersClient.Create(callInvoker, Settings);
        }

        private async stt::Task<RoutersClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RoutersClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => RoutersClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => RoutersClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RoutersClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>Routers client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Routers API.
    /// </remarks>
    public abstract partial class RoutersClient
    {
        /// <summary>
        /// The default endpoint for the Routers service, which is a host of "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default Routers scopes.</summary>
        /// <remarks>
        /// The default Routers scopes are:
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

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="RoutersClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="RoutersClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RoutersClient"/>.</returns>
        public static stt::Task<RoutersClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RoutersClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RoutersClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="RoutersClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RoutersClient"/>.</returns>
        public static RoutersClient Create() => new RoutersClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RoutersClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RoutersSettings"/>.</param>
        /// <returns>The created <see cref="RoutersClient"/>.</returns>
        internal static RoutersClient Create(grpccore::CallInvoker callInvoker, RoutersSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Routers.RoutersClient grpcClient = new Routers.RoutersClient(callInvoker);
            return new RoutersClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC Routers client</summary>
        public virtual Routers.RoutersClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of routers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<RouterAggregatedList, scg::KeyValuePair<string, RoutersScopedList>> AggregatedList(AggregatedListRoutersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of routers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<RouterAggregatedList, scg::KeyValuePair<string, RoutersScopedList>> AggregatedListAsync(AggregatedListRoutersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an aggregated list of routers.
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
        public virtual gax::PagedEnumerable<RouterAggregatedList, scg::KeyValuePair<string, RoutersScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedList(new AggregatedListRoutersRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves an aggregated list of routers.
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
        public virtual gax::PagedAsyncEnumerable<RouterAggregatedList, scg::KeyValuePair<string, RoutersScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedListAsync(new AggregatedListRoutersRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes the specified Router resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Router resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Router resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteRouterRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified Router resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string region, string router, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified Router resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string router, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified Router resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string router, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, router, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified Router resource. Gets a list of available routers by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Router Get(GetRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified Router resource. Gets a list of available routers by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Router> GetAsync(GetRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified Router resource. Gets a list of available routers by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Router> GetAsync(GetRouterRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified Router resource. Gets a list of available routers by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Router Get(string project, string region, string router, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
            }, callSettings);

        /// <summary>
        /// Returns the specified Router resource. Gets a list of available routers by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Router> GetAsync(string project, string region, string router, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
            }, callSettings);

        /// <summary>
        /// Returns the specified Router resource. Gets a list of available routers by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Router> GetAsync(string project, string region, string router, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, router, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves runtime Nat mapping information of VM endpoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VmEndpointNatMappings"/> resources.</returns>
        public virtual gax::PagedEnumerable<VmEndpointNatMappingsList, VmEndpointNatMappings> GetNatMappingInfo(GetNatMappingInfoRoutersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves runtime Nat mapping information of VM endpoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VmEndpointNatMappings"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<VmEndpointNatMappingsList, VmEndpointNatMappings> GetNatMappingInfoAsync(GetNatMappingInfoRoutersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves runtime Nat mapping information of VM endpoints.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to query for Nat Mapping information of VM endpoints.
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
        /// <returns>A pageable sequence of <see cref="VmEndpointNatMappings"/> resources.</returns>
        public virtual gax::PagedEnumerable<VmEndpointNatMappingsList, VmEndpointNatMappings> GetNatMappingInfo(string project, string region, string router, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            GetNatMappingInfo(new GetNatMappingInfoRoutersRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves runtime Nat mapping information of VM endpoints.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to query for Nat Mapping information of VM endpoints.
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
        /// <returns>A pageable asynchronous sequence of <see cref="VmEndpointNatMappings"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<VmEndpointNatMappingsList, VmEndpointNatMappings> GetNatMappingInfoAsync(string project, string region, string router, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            GetNatMappingInfoAsync(new GetNatMappingInfoRoutersRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves runtime information of the specified router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RouterStatusResponse GetRouterStatus(GetRouterStatusRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves runtime information of the specified router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RouterStatusResponse> GetRouterStatusAsync(GetRouterStatusRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves runtime information of the specified router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RouterStatusResponse> GetRouterStatusAsync(GetRouterStatusRouterRequest request, st::CancellationToken cancellationToken) =>
            GetRouterStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves runtime information of the specified router.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to query.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RouterStatusResponse GetRouterStatus(string project, string region, string router, gaxgrpc::CallSettings callSettings = null) =>
            GetRouterStatus(new GetRouterStatusRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
            }, callSettings);

        /// <summary>
        /// Retrieves runtime information of the specified router.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to query.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RouterStatusResponse> GetRouterStatusAsync(string project, string region, string router, gaxgrpc::CallSettings callSettings = null) =>
            GetRouterStatusAsync(new GetRouterStatusRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
            }, callSettings);

        /// <summary>
        /// Retrieves runtime information of the specified router.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to query.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RouterStatusResponse> GetRouterStatusAsync(string project, string region, string router, st::CancellationToken cancellationToken) =>
            GetRouterStatusAsync(project, region, router, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Router resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Router resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Router resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertRouterRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Router resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="routerResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, string region, Router routerResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RouterResource = gax::GaxPreconditions.CheckNotNull(routerResource, nameof(routerResource)),
            }, callSettings);

        /// <summary>
        /// Creates a Router resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="routerResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, Router routerResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RouterResource = gax::GaxPreconditions.CheckNotNull(routerResource, nameof(routerResource)),
            }, callSettings);

        /// <summary>
        /// Creates a Router resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="routerResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, Router routerResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, routerResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a list of Router resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Router"/> resources.</returns>
        public virtual gax::PagedEnumerable<RouterList, Router> List(ListRoutersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of Router resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Router"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RouterList, Router> ListAsync(ListRoutersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a list of Router resources available to the specified project.
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
        /// <returns>A pageable sequence of <see cref="Router"/> resources.</returns>
        public virtual gax::PagedEnumerable<RouterList, Router> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListRoutersRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves a list of Router resources available to the specified project.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Router"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<RouterList, Router> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListRoutersRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(PatchRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchRouterRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to patch.
        /// </param>
        /// <param name="routerResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(string project, string region, string router, Router routerResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
                RouterResource = gax::GaxPreconditions.CheckNotNull(routerResource, nameof(routerResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to patch.
        /// </param>
        /// <param name="routerResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string region, string router, Router routerResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
                RouterResource = gax::GaxPreconditions.CheckNotNull(routerResource, nameof(routerResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to patch.
        /// </param>
        /// <param name="routerResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string region, string router, Router routerResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, region, router, routerResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Preview fields auto-generated during router create and update operations. Calling this method does NOT create or update the router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RoutersPreviewResponse Preview(PreviewRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Preview fields auto-generated during router create and update operations. Calling this method does NOT create or update the router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RoutersPreviewResponse> PreviewAsync(PreviewRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Preview fields auto-generated during router create and update operations. Calling this method does NOT create or update the router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RoutersPreviewResponse> PreviewAsync(PreviewRouterRequest request, st::CancellationToken cancellationToken) =>
            PreviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Preview fields auto-generated during router create and update operations. Calling this method does NOT create or update the router.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to query.
        /// </param>
        /// <param name="routerResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RoutersPreviewResponse Preview(string project, string region, string router, Router routerResource, gaxgrpc::CallSettings callSettings = null) =>
            Preview(new PreviewRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
                RouterResource = gax::GaxPreconditions.CheckNotNull(routerResource, nameof(routerResource)),
            }, callSettings);

        /// <summary>
        /// Preview fields auto-generated during router create and update operations. Calling this method does NOT create or update the router.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to query.
        /// </param>
        /// <param name="routerResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RoutersPreviewResponse> PreviewAsync(string project, string region, string router, Router routerResource, gaxgrpc::CallSettings callSettings = null) =>
            PreviewAsync(new PreviewRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
                RouterResource = gax::GaxPreconditions.CheckNotNull(routerResource, nameof(routerResource)),
            }, callSettings);

        /// <summary>
        /// Preview fields auto-generated during router create and update operations. Calling this method does NOT create or update the router.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to query.
        /// </param>
        /// <param name="routerResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RoutersPreviewResponse> PreviewAsync(string project, string region, string router, Router routerResource, st::CancellationToken cancellationToken) =>
            PreviewAsync(project, region, router, routerResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified Router resource with the data included in the request. This method conforms to PUT semantics, which requests that the state of the target resource be created or replaced with the state defined by the representation enclosed in the request message payload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Update(UpdateRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified Router resource with the data included in the request. This method conforms to PUT semantics, which requests that the state of the target resource be created or replaced with the state defined by the representation enclosed in the request message payload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(UpdateRouterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified Router resource with the data included in the request. This method conforms to PUT semantics, which requests that the state of the target resource be created or replaced with the state defined by the representation enclosed in the request message payload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(UpdateRouterRequest request, st::CancellationToken cancellationToken) =>
            UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified Router resource with the data included in the request. This method conforms to PUT semantics, which requests that the state of the target resource be created or replaced with the state defined by the representation enclosed in the request message payload.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to update.
        /// </param>
        /// <param name="routerResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Update(string project, string region, string router, Router routerResource, gaxgrpc::CallSettings callSettings = null) =>
            Update(new UpdateRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
                RouterResource = gax::GaxPreconditions.CheckNotNull(routerResource, nameof(routerResource)),
            }, callSettings);

        /// <summary>
        /// Updates the specified Router resource with the data included in the request. This method conforms to PUT semantics, which requests that the state of the target resource be created or replaced with the state defined by the representation enclosed in the request message payload.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to update.
        /// </param>
        /// <param name="routerResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(string project, string region, string router, Router routerResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsync(new UpdateRouterRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                Router = gax::GaxPreconditions.CheckNotNullOrEmpty(router, nameof(router)),
                RouterResource = gax::GaxPreconditions.CheckNotNull(routerResource, nameof(routerResource)),
            }, callSettings);

        /// <summary>
        /// Updates the specified Router resource with the data included in the request. This method conforms to PUT semantics, which requests that the state of the target resource be created or replaced with the state defined by the representation enclosed in the request message payload.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region for this request.
        /// </param>
        /// <param name="router">
        /// Name of the Router resource to update.
        /// </param>
        /// <param name="routerResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(string project, string region, string router, Router routerResource, st::CancellationToken cancellationToken) =>
            UpdateAsync(project, region, router, routerResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Routers client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Routers API.
    /// </remarks>
    public sealed partial class RoutersClientImpl : RoutersClient
    {
        private readonly gaxgrpc::ApiCall<AggregatedListRoutersRequest, RouterAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<DeleteRouterRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetRouterRequest, Router> _callGet;

        private readonly gaxgrpc::ApiCall<GetNatMappingInfoRoutersRequest, VmEndpointNatMappingsList> _callGetNatMappingInfo;

        private readonly gaxgrpc::ApiCall<GetRouterStatusRouterRequest, RouterStatusResponse> _callGetRouterStatus;

        private readonly gaxgrpc::ApiCall<InsertRouterRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListRoutersRequest, RouterList> _callList;

        private readonly gaxgrpc::ApiCall<PatchRouterRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<PreviewRouterRequest, RoutersPreviewResponse> _callPreview;

        private readonly gaxgrpc::ApiCall<UpdateRouterRequest, Operation> _callUpdate;

        /// <summary>
        /// Constructs a client wrapper for the Routers service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RoutersSettings"/> used within this client.</param>
        public RoutersClientImpl(Routers.RoutersClient grpcClient, RoutersSettings settings)
        {
            GrpcClient = grpcClient;
            RoutersSettings effectiveSettings = settings ?? RoutersSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListRoutersRequest, RouterAggregatedList>(grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callDelete = clientHelper.BuildApiCall<DeleteRouterRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("router", request => request.Router);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetRouterRequest, Router>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("router", request => request.Router);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetNatMappingInfo = clientHelper.BuildApiCall<GetNatMappingInfoRoutersRequest, VmEndpointNatMappingsList>(grpcClient.GetNatMappingInfoAsync, grpcClient.GetNatMappingInfo, effectiveSettings.GetNatMappingInfoSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("router", request => request.Router);
            Modify_ApiCall(ref _callGetNatMappingInfo);
            Modify_GetNatMappingInfoApiCall(ref _callGetNatMappingInfo);
            _callGetRouterStatus = clientHelper.BuildApiCall<GetRouterStatusRouterRequest, RouterStatusResponse>(grpcClient.GetRouterStatusAsync, grpcClient.GetRouterStatus, effectiveSettings.GetRouterStatusSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("router", request => request.Router);
            Modify_ApiCall(ref _callGetRouterStatus);
            Modify_GetRouterStatusApiCall(ref _callGetRouterStatus);
            _callInsert = clientHelper.BuildApiCall<InsertRouterRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListRoutersRequest, RouterList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchRouterRequest, Operation>(grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("router", request => request.Router);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callPreview = clientHelper.BuildApiCall<PreviewRouterRequest, RoutersPreviewResponse>(grpcClient.PreviewAsync, grpcClient.Preview, effectiveSettings.PreviewSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("router", request => request.Router);
            Modify_ApiCall(ref _callPreview);
            Modify_PreviewApiCall(ref _callPreview);
            _callUpdate = clientHelper.BuildApiCall<UpdateRouterRequest, Operation>(grpcClient.UpdateAsync, grpcClient.Update, effectiveSettings.UpdateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("router", request => request.Router);
            Modify_ApiCall(ref _callUpdate);
            Modify_UpdateApiCall(ref _callUpdate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListRoutersRequest, RouterAggregatedList> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteRouterRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRouterRequest, Router> call);

        partial void Modify_GetNatMappingInfoApiCall(ref gaxgrpc::ApiCall<GetNatMappingInfoRoutersRequest, VmEndpointNatMappingsList> call);

        partial void Modify_GetRouterStatusApiCall(ref gaxgrpc::ApiCall<GetRouterStatusRouterRequest, RouterStatusResponse> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertRouterRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRoutersRequest, RouterList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchRouterRequest, Operation> call);

        partial void Modify_PreviewApiCall(ref gaxgrpc::ApiCall<PreviewRouterRequest, RoutersPreviewResponse> call);

        partial void Modify_UpdateApiCall(ref gaxgrpc::ApiCall<UpdateRouterRequest, Operation> call);

        partial void OnConstruction(Routers.RoutersClient grpcClient, RoutersSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Routers client</summary>
        public override Routers.RoutersClient GrpcClient { get; }

        partial void Modify_AggregatedListRoutersRequest(ref AggregatedListRoutersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteRouterRequest(ref DeleteRouterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRouterRequest(ref GetRouterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetNatMappingInfoRoutersRequest(ref GetNatMappingInfoRoutersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRouterStatusRouterRequest(ref GetRouterStatusRouterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertRouterRequest(ref InsertRouterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRoutersRequest(ref ListRoutersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchRouterRequest(ref PatchRouterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PreviewRouterRequest(ref PreviewRouterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRouterRequest(ref UpdateRouterRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves an aggregated list of routers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<RouterAggregatedList, scg::KeyValuePair<string, RoutersScopedList>> AggregatedList(AggregatedListRoutersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListRoutersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListRoutersRequest, RouterAggregatedList, scg::KeyValuePair<string, RoutersScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves an aggregated list of routers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<RouterAggregatedList, scg::KeyValuePair<string, RoutersScopedList>> AggregatedListAsync(AggregatedListRoutersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListRoutersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListRoutersRequest, RouterAggregatedList, scg::KeyValuePair<string, RoutersScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Deletes the specified Router resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRouterRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified Router resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRouterRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified Router resource. Gets a list of available routers by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Router Get(GetRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRouterRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified Router resource. Gets a list of available routers by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Router> GetAsync(GetRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRouterRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves runtime Nat mapping information of VM endpoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="VmEndpointNatMappings"/> resources.</returns>
        public override gax::PagedEnumerable<VmEndpointNatMappingsList, VmEndpointNatMappings> GetNatMappingInfo(GetNatMappingInfoRoutersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNatMappingInfoRoutersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<GetNatMappingInfoRoutersRequest, VmEndpointNatMappingsList, VmEndpointNatMappings>(_callGetNatMappingInfo, request, callSettings);
        }

        /// <summary>
        /// Retrieves runtime Nat mapping information of VM endpoints.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="VmEndpointNatMappings"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<VmEndpointNatMappingsList, VmEndpointNatMappings> GetNatMappingInfoAsync(GetNatMappingInfoRoutersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNatMappingInfoRoutersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<GetNatMappingInfoRoutersRequest, VmEndpointNatMappingsList, VmEndpointNatMappings>(_callGetNatMappingInfo, request, callSettings);
        }

        /// <summary>
        /// Retrieves runtime information of the specified router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RouterStatusResponse GetRouterStatus(GetRouterStatusRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRouterStatusRouterRequest(ref request, ref callSettings);
            return _callGetRouterStatus.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves runtime information of the specified router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RouterStatusResponse> GetRouterStatusAsync(GetRouterStatusRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRouterStatusRouterRequest(ref request, ref callSettings);
            return _callGetRouterStatus.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a Router resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRouterRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a Router resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRouterRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of Router resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Router"/> resources.</returns>
        public override gax::PagedEnumerable<RouterList, Router> List(ListRoutersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRoutersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRoutersRequest, RouterList, Router>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves a list of Router resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Router"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<RouterList, Router> ListAsync(ListRoutersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRoutersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRoutersRequest, RouterList, Router>(_callList, request, callSettings);
        }

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Patch(PatchRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRouterRequest(ref request, ref callSettings);
            return _callPatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Patches the specified Router resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PatchAsync(PatchRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRouterRequest(ref request, ref callSettings);
            return _callPatch.Async(request, callSettings);
        }

        /// <summary>
        /// Preview fields auto-generated during router create and update operations. Calling this method does NOT create or update the router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RoutersPreviewResponse Preview(PreviewRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewRouterRequest(ref request, ref callSettings);
            return _callPreview.Sync(request, callSettings);
        }

        /// <summary>
        /// Preview fields auto-generated during router create and update operations. Calling this method does NOT create or update the router.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RoutersPreviewResponse> PreviewAsync(PreviewRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewRouterRequest(ref request, ref callSettings);
            return _callPreview.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified Router resource with the data included in the request. This method conforms to PUT semantics, which requests that the state of the target resource be created or replaced with the state defined by the representation enclosed in the request message payload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Update(UpdateRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRouterRequest(ref request, ref callSettings);
            return _callUpdate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified Router resource with the data included in the request. This method conforms to PUT semantics, which requests that the state of the target resource be created or replaced with the state defined by the representation enclosed in the request message payload.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateAsync(UpdateRouterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRouterRequest(ref request, ref callSettings);
            return _callUpdate.Async(request, callSettings);
        }
    }

    public partial class AggregatedListRoutersRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class GetNatMappingInfoRoutersRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListRoutersRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class RouterAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, RoutersScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, RoutersScopedList>> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class VmEndpointNatMappingsList : gaxgrpc::IPageResponse<VmEndpointNatMappings>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<VmEndpointNatMappings> GetEnumerator() => Result.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class RouterList : gaxgrpc::IPageResponse<Router>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Router> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
