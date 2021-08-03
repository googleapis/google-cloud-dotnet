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
    /// <summary>Settings for <see cref="RegionNotificationEndpointsClient"/> instances.</summary>
    public sealed partial class RegionNotificationEndpointsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionNotificationEndpointsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionNotificationEndpointsSettings"/>.</returns>
        public static RegionNotificationEndpointsSettings GetDefault() => new RegionNotificationEndpointsSettings();

        /// <summary>
        /// Constructs a new <see cref="RegionNotificationEndpointsSettings"/> object with default settings.
        /// </summary>
        public RegionNotificationEndpointsSettings()
        {
        }

        private RegionNotificationEndpointsSettings(RegionNotificationEndpointsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegionNotificationEndpointsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionNotificationEndpointsClient.Delete</c> and <c>RegionNotificationEndpointsClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionNotificationEndpointsClient.Get</c> and <c>RegionNotificationEndpointsClient.GetAsync</c>.
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
        /// <c>RegionNotificationEndpointsClient.Insert</c> and <c>RegionNotificationEndpointsClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionNotificationEndpointsClient.List</c> and <c>RegionNotificationEndpointsClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionNotificationEndpointsSettings"/> object.</returns>
        public RegionNotificationEndpointsSettings Clone() => new RegionNotificationEndpointsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionNotificationEndpointsClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class RegionNotificationEndpointsClientBuilder : gaxgrpc::ClientBuilderBase<RegionNotificationEndpointsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionNotificationEndpointsSettings Settings { get; set; }

        partial void InterceptBuild(ref RegionNotificationEndpointsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionNotificationEndpointsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionNotificationEndpointsClient Build()
        {
            RegionNotificationEndpointsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionNotificationEndpointsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionNotificationEndpointsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionNotificationEndpointsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionNotificationEndpointsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<RegionNotificationEndpointsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionNotificationEndpointsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => RegionNotificationEndpointsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => RegionNotificationEndpointsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionNotificationEndpointsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>RegionNotificationEndpoints client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionNotificationEndpoints API.
    /// </remarks>
    public abstract partial class RegionNotificationEndpointsClient
    {
        /// <summary>
        /// The default endpoint for the RegionNotificationEndpoints service, which is a host of
        /// "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionNotificationEndpoints scopes.</summary>
        /// <remarks>
        /// The default RegionNotificationEndpoints scopes are:
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
        /// Asynchronously creates a <see cref="RegionNotificationEndpointsClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionNotificationEndpointsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionNotificationEndpointsClient"/>.</returns>
        public static stt::Task<RegionNotificationEndpointsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionNotificationEndpointsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionNotificationEndpointsClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionNotificationEndpointsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionNotificationEndpointsClient"/>.</returns>
        public static RegionNotificationEndpointsClient Create() => new RegionNotificationEndpointsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionNotificationEndpointsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionNotificationEndpointsSettings"/>.</param>
        /// <returns>The created <see cref="RegionNotificationEndpointsClient"/>.</returns>
        internal static RegionNotificationEndpointsClient Create(grpccore::CallInvoker callInvoker, RegionNotificationEndpointsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionNotificationEndpoints.RegionNotificationEndpointsClient grpcClient = new RegionNotificationEndpoints.RegionNotificationEndpointsClient(callInvoker);
            return new RegionNotificationEndpointsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC RegionNotificationEndpoints client</summary>
        public virtual RegionNotificationEndpoints.RegionNotificationEndpointsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified NotificationEndpoint in the given region
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteRegionNotificationEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified NotificationEndpoint in the given region
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteRegionNotificationEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified NotificationEndpoint in the given region
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteRegionNotificationEndpointRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified NotificationEndpoint in the given region
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="notificationEndpoint">
        /// Name of the NotificationEndpoint resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string region, string notificationEndpoint, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteRegionNotificationEndpointRequest
            {
                NotificationEndpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(notificationEndpoint, nameof(notificationEndpoint)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified NotificationEndpoint in the given region
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="notificationEndpoint">
        /// Name of the NotificationEndpoint resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string notificationEndpoint, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteRegionNotificationEndpointRequest
            {
                NotificationEndpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(notificationEndpoint, nameof(notificationEndpoint)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified NotificationEndpoint in the given region
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="notificationEndpoint">
        /// Name of the NotificationEndpoint resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string notificationEndpoint, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, notificationEndpoint, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified NotificationEndpoint resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationEndpoint Get(GetRegionNotificationEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified NotificationEndpoint resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationEndpoint> GetAsync(GetRegionNotificationEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified NotificationEndpoint resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationEndpoint> GetAsync(GetRegionNotificationEndpointRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified NotificationEndpoint resource in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="notificationEndpoint">
        /// Name of the NotificationEndpoint resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NotificationEndpoint Get(string project, string region, string notificationEndpoint, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRegionNotificationEndpointRequest
            {
                NotificationEndpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(notificationEndpoint, nameof(notificationEndpoint)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified NotificationEndpoint resource in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="notificationEndpoint">
        /// Name of the NotificationEndpoint resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationEndpoint> GetAsync(string project, string region, string notificationEndpoint, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRegionNotificationEndpointRequest
            {
                NotificationEndpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(notificationEndpoint, nameof(notificationEndpoint)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified NotificationEndpoint resource in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="notificationEndpoint">
        /// Name of the NotificationEndpoint resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NotificationEndpoint> GetAsync(string project, string region, string notificationEndpoint, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, notificationEndpoint, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a NotificationEndpoint in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertRegionNotificationEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a NotificationEndpoint in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertRegionNotificationEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a NotificationEndpoint in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertRegionNotificationEndpointRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a NotificationEndpoint in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="notificationEndpointResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, string region, NotificationEndpoint notificationEndpointResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertRegionNotificationEndpointRequest
            {
                NotificationEndpointResource = gax::GaxPreconditions.CheckNotNull(notificationEndpointResource, nameof(notificationEndpointResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Create a NotificationEndpoint in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="notificationEndpointResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, NotificationEndpoint notificationEndpointResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertRegionNotificationEndpointRequest
            {
                NotificationEndpointResource = gax::GaxPreconditions.CheckNotNull(notificationEndpointResource, nameof(notificationEndpointResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Create a NotificationEndpoint in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="notificationEndpointResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, NotificationEndpoint notificationEndpointResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, notificationEndpointResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the NotificationEndpoints for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<NotificationEndpointList, NotificationEndpoint> List(ListRegionNotificationEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the NotificationEndpoints for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<NotificationEndpointList, NotificationEndpoint> ListAsync(ListRegionNotificationEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the NotificationEndpoints for a project in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
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
        /// <returns>A pageable sequence of <see cref="NotificationEndpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<NotificationEndpointList, NotificationEndpoint> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListRegionNotificationEndpointsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists the NotificationEndpoints for a project in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationEndpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<NotificationEndpointList, NotificationEndpoint> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListRegionNotificationEndpointsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>RegionNotificationEndpoints client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionNotificationEndpoints API.
    /// </remarks>
    public sealed partial class RegionNotificationEndpointsClientImpl : RegionNotificationEndpointsClient
    {
        private readonly gaxgrpc::ApiCall<DeleteRegionNotificationEndpointRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetRegionNotificationEndpointRequest, NotificationEndpoint> _callGet;

        private readonly gaxgrpc::ApiCall<InsertRegionNotificationEndpointRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListRegionNotificationEndpointsRequest, NotificationEndpointList> _callList;

        /// <summary>
        /// Constructs a client wrapper for the RegionNotificationEndpoints service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RegionNotificationEndpointsSettings"/> used within this client.
        /// </param>
        public RegionNotificationEndpointsClientImpl(RegionNotificationEndpoints.RegionNotificationEndpointsClient grpcClient, RegionNotificationEndpointsSettings settings)
        {
            GrpcClient = grpcClient;
            RegionNotificationEndpointsSettings effectiveSettings = settings ?? RegionNotificationEndpointsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callDelete = clientHelper.BuildApiCall<DeleteRegionNotificationEndpointRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("notification_endpoint", request => request.NotificationEndpoint);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetRegionNotificationEndpointRequest, NotificationEndpoint>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("notification_endpoint", request => request.NotificationEndpoint);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertRegionNotificationEndpointRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListRegionNotificationEndpointsRequest, NotificationEndpointList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteRegionNotificationEndpointRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRegionNotificationEndpointRequest, NotificationEndpoint> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertRegionNotificationEndpointRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRegionNotificationEndpointsRequest, NotificationEndpointList> call);

        partial void OnConstruction(RegionNotificationEndpoints.RegionNotificationEndpointsClient grpcClient, RegionNotificationEndpointsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionNotificationEndpoints client</summary>
        public override RegionNotificationEndpoints.RegionNotificationEndpointsClient GrpcClient { get; }

        partial void Modify_DeleteRegionNotificationEndpointRequest(ref DeleteRegionNotificationEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRegionNotificationEndpointRequest(ref GetRegionNotificationEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertRegionNotificationEndpointRequest(ref InsertRegionNotificationEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegionNotificationEndpointsRequest(ref ListRegionNotificationEndpointsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Deletes the specified NotificationEndpoint in the given region
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteRegionNotificationEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionNotificationEndpointRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified NotificationEndpoint in the given region
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteRegionNotificationEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionNotificationEndpointRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified NotificationEndpoint resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NotificationEndpoint Get(GetRegionNotificationEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionNotificationEndpointRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified NotificationEndpoint resource in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NotificationEndpoint> GetAsync(GetRegionNotificationEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionNotificationEndpointRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Create a NotificationEndpoint in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertRegionNotificationEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionNotificationEndpointRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a NotificationEndpoint in the specified project in the given region using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertRegionNotificationEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionNotificationEndpointRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the NotificationEndpoints for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NotificationEndpoint"/> resources.</returns>
        public override gax::PagedEnumerable<NotificationEndpointList, NotificationEndpoint> List(ListRegionNotificationEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionNotificationEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionNotificationEndpointsRequest, NotificationEndpointList, NotificationEndpoint>(_callList, request, callSettings);
        }

        /// <summary>
        /// Lists the NotificationEndpoints for a project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NotificationEndpoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<NotificationEndpointList, NotificationEndpoint> ListAsync(ListRegionNotificationEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionNotificationEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionNotificationEndpointsRequest, NotificationEndpointList, NotificationEndpoint>(_callList, request, callSettings);
        }
    }

    public partial class ListRegionNotificationEndpointsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class NotificationEndpointList : gaxgrpc::IPageResponse<NotificationEndpoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<NotificationEndpoint> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
