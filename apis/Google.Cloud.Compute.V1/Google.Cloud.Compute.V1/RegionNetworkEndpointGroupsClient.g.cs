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
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="RegionNetworkEndpointGroupsClient"/> instances.</summary>
    public sealed partial class RegionNetworkEndpointGroupsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionNetworkEndpointGroupsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionNetworkEndpointGroupsSettings"/>.</returns>
        public static RegionNetworkEndpointGroupsSettings GetDefault() => new RegionNetworkEndpointGroupsSettings();

        /// <summary>
        /// Constructs a new <see cref="RegionNetworkEndpointGroupsSettings"/> object with default settings.
        /// </summary>
        public RegionNetworkEndpointGroupsSettings()
        {
        }

        private RegionNetworkEndpointGroupsSettings(RegionNetworkEndpointGroupsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegionNetworkEndpointGroupsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionNetworkEndpointGroupsClient.Delete</c> and <c>RegionNetworkEndpointGroupsClient.DeleteAsync</c>.
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
        /// <c>RegionNetworkEndpointGroupsClient.Get</c> and <c>RegionNetworkEndpointGroupsClient.GetAsync</c>.
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
        /// <c>RegionNetworkEndpointGroupsClient.Insert</c> and <c>RegionNetworkEndpointGroupsClient.InsertAsync</c>.
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
        /// <c>RegionNetworkEndpointGroupsClient.List</c> and <c>RegionNetworkEndpointGroupsClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionNetworkEndpointGroupsSettings"/> object.</returns>
        public RegionNetworkEndpointGroupsSettings Clone() => new RegionNetworkEndpointGroupsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionNetworkEndpointGroupsClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class RegionNetworkEndpointGroupsClientBuilder : gaxgrpc::ClientBuilderBase<RegionNetworkEndpointGroupsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionNetworkEndpointGroupsSettings Settings { get; set; }

        partial void InterceptBuild(ref RegionNetworkEndpointGroupsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionNetworkEndpointGroupsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionNetworkEndpointGroupsClient Build()
        {
            RegionNetworkEndpointGroupsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionNetworkEndpointGroupsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionNetworkEndpointGroupsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionNetworkEndpointGroupsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionNetworkEndpointGroupsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<RegionNetworkEndpointGroupsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionNetworkEndpointGroupsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => RegionNetworkEndpointGroupsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => RegionNetworkEndpointGroupsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionNetworkEndpointGroupsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>RegionNetworkEndpointGroups client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionNetworkEndpointGroups API.
    /// </remarks>
    public abstract partial class RegionNetworkEndpointGroupsClient
    {
        /// <summary>
        /// The default endpoint for the RegionNetworkEndpointGroups service, which is a host of
        /// "compute.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionNetworkEndpointGroups scopes.</summary>
        /// <remarks>
        /// The default RegionNetworkEndpointGroups scopes are:
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
        /// Asynchronously creates a <see cref="RegionNetworkEndpointGroupsClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionNetworkEndpointGroupsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionNetworkEndpointGroupsClient"/>.</returns>
        public static stt::Task<RegionNetworkEndpointGroupsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionNetworkEndpointGroupsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionNetworkEndpointGroupsClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionNetworkEndpointGroupsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionNetworkEndpointGroupsClient"/>.</returns>
        public static RegionNetworkEndpointGroupsClient Create() => new RegionNetworkEndpointGroupsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionNetworkEndpointGroupsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionNetworkEndpointGroupsSettings"/>.</param>
        /// <returns>The created <see cref="RegionNetworkEndpointGroupsClient"/>.</returns>
        internal static RegionNetworkEndpointGroupsClient Create(grpccore::CallInvoker callInvoker, RegionNetworkEndpointGroupsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient grpcClient = new RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient(callInvoker);
            return new RegionNetworkEndpointGroupsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC RegionNetworkEndpointGroups client</summary>
        public virtual RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteRegionNetworkEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroup">
        /// The name of the network endpoint group to delete. It should comply with RFC1035.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string region, string networkEndpointGroup, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteRegionNetworkEndpointGroupRequest
            {
                NetworkEndpointGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(networkEndpointGroup, nameof(networkEndpointGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroup">
        /// The name of the network endpoint group to delete. It should comply with RFC1035.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string networkEndpointGroup, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteRegionNetworkEndpointGroupRequest
            {
                NetworkEndpointGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(networkEndpointGroup, nameof(networkEndpointGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroup">
        /// The name of the network endpoint group to delete. It should comply with RFC1035.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string networkEndpointGroup, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, networkEndpointGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NetworkEndpointGroup Get(GetRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkEndpointGroup> GetAsync(GetRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkEndpointGroup> GetAsync(GetRegionNetworkEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroup">
        /// The name of the network endpoint group. It should comply with RFC1035.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual NetworkEndpointGroup Get(string project, string region, string networkEndpointGroup, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRegionNetworkEndpointGroupRequest
            {
                NetworkEndpointGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(networkEndpointGroup, nameof(networkEndpointGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroup">
        /// The name of the network endpoint group. It should comply with RFC1035.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkEndpointGroup> GetAsync(string project, string region, string networkEndpointGroup, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRegionNetworkEndpointGroupRequest
            {
                NetworkEndpointGroup = gax::GaxPreconditions.CheckNotNullOrEmpty(networkEndpointGroup, nameof(networkEndpointGroup)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroup">
        /// The name of the network endpoint group. It should comply with RFC1035.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<NetworkEndpointGroup> GetAsync(string project, string region, string networkEndpointGroup, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, networkEndpointGroup, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertRegionNetworkEndpointGroupRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where you want to create the network endpoint group. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroupResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, string region, NetworkEndpointGroup networkEndpointGroupResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertRegionNetworkEndpointGroupRequest
            {
                NetworkEndpointGroupResource = gax::GaxPreconditions.CheckNotNull(networkEndpointGroupResource, nameof(networkEndpointGroupResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where you want to create the network endpoint group. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroupResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, NetworkEndpointGroup networkEndpointGroupResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertRegionNetworkEndpointGroupRequest
            {
                NetworkEndpointGroupResource = gax::GaxPreconditions.CheckNotNull(networkEndpointGroupResource, nameof(networkEndpointGroupResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
            }, callSettings);

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where you want to create the network endpoint group. It should comply with RFC1035.
        /// </param>
        /// <param name="networkEndpointGroupResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, NetworkEndpointGroup networkEndpointGroupResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, networkEndpointGroupResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of regional network endpoint groups available to the specified project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NetworkEndpointGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> List(ListRegionNetworkEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of regional network endpoint groups available to the specified project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkEndpointGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> ListAsync(ListRegionNetworkEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of regional network endpoint groups available to the specified project in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
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
        /// <returns>A pageable sequence of <see cref="NetworkEndpointGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListRegionNetworkEndpointGroupsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the list of regional network endpoint groups available to the specified project in the given region.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// The name of the region where the network endpoint group is located. It should comply with RFC1035.
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
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkEndpointGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListRegionNetworkEndpointGroupsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>RegionNetworkEndpointGroups client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionNetworkEndpointGroups API.
    /// </remarks>
    public sealed partial class RegionNetworkEndpointGroupsClientImpl : RegionNetworkEndpointGroupsClient
    {
        private readonly gaxgrpc::ApiCall<DeleteRegionNetworkEndpointGroupRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetRegionNetworkEndpointGroupRequest, NetworkEndpointGroup> _callGet;

        private readonly gaxgrpc::ApiCall<InsertRegionNetworkEndpointGroupRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListRegionNetworkEndpointGroupsRequest, NetworkEndpointGroupList> _callList;

        /// <summary>
        /// Constructs a client wrapper for the RegionNetworkEndpointGroups service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RegionNetworkEndpointGroupsSettings"/> used within this client.
        /// </param>
        public RegionNetworkEndpointGroupsClientImpl(RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient grpcClient, RegionNetworkEndpointGroupsSettings settings)
        {
            GrpcClient = grpcClient;
            RegionNetworkEndpointGroupsSettings effectiveSettings = settings ?? RegionNetworkEndpointGroupsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callDelete = clientHelper.BuildApiCall<DeleteRegionNetworkEndpointGroupRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("network_endpoint_group", request => request.NetworkEndpointGroup);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetRegionNetworkEndpointGroupRequest, NetworkEndpointGroup>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("network_endpoint_group", request => request.NetworkEndpointGroup);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertRegionNetworkEndpointGroupRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListRegionNetworkEndpointGroupsRequest, NetworkEndpointGroupList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteRegionNetworkEndpointGroupRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRegionNetworkEndpointGroupRequest, NetworkEndpointGroup> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertRegionNetworkEndpointGroupRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRegionNetworkEndpointGroupsRequest, NetworkEndpointGroupList> call);

        partial void OnConstruction(RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient grpcClient, RegionNetworkEndpointGroupsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionNetworkEndpointGroups client</summary>
        public override RegionNetworkEndpointGroups.RegionNetworkEndpointGroupsClient GrpcClient { get; }

        partial void Modify_DeleteRegionNetworkEndpointGroupRequest(ref DeleteRegionNetworkEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRegionNetworkEndpointGroupRequest(ref GetRegionNetworkEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertRegionNetworkEndpointGroupRequest(ref InsertRegionNetworkEndpointGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegionNetworkEndpointGroupsRequest(ref ListRegionNetworkEndpointGroupsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionNetworkEndpointGroupRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified network endpoint group. Note that the NEG cannot be deleted if it is configured as a backend of a backend service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionNetworkEndpointGroupRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override NetworkEndpointGroup Get(GetRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionNetworkEndpointGroupRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified network endpoint group. Gets a list of available network endpoint groups by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<NetworkEndpointGroup> GetAsync(GetRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionNetworkEndpointGroupRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionNetworkEndpointGroupRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a network endpoint group in the specified project using the parameters that are included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertRegionNetworkEndpointGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionNetworkEndpointGroupRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of regional network endpoint groups available to the specified project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="NetworkEndpointGroup"/> resources.</returns>
        public override gax::PagedEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> List(ListRegionNetworkEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionNetworkEndpointGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionNetworkEndpointGroupsRequest, NetworkEndpointGroupList, NetworkEndpointGroup>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of regional network endpoint groups available to the specified project in the given region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="NetworkEndpointGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<NetworkEndpointGroupList, NetworkEndpointGroup> ListAsync(ListRegionNetworkEndpointGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionNetworkEndpointGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionNetworkEndpointGroupsRequest, NetworkEndpointGroupList, NetworkEndpointGroup>(_callList, request, callSettings);
        }
    }

    public partial class ListRegionNetworkEndpointGroupsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }
}
