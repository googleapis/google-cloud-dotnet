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
    /// <summary>Settings for <see cref="RegionUrlMapsClient"/> instances.</summary>
    public sealed partial class RegionUrlMapsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionUrlMapsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionUrlMapsSettings"/>.</returns>
        public static RegionUrlMapsSettings GetDefault() => new RegionUrlMapsSettings();

        /// <summary>Constructs a new <see cref="RegionUrlMapsSettings"/> object with default settings.</summary>
        public RegionUrlMapsSettings()
        {
        }

        private RegionUrlMapsSettings(RegionUrlMapsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            UpdateSettings = existing.UpdateSettings;
            ValidateSettings = existing.ValidateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegionUrlMapsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionUrlMapsClient.Delete</c>
        ///  and <c>RegionUrlMapsClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionUrlMapsClient.Get</c>
        /// and <c>RegionUrlMapsClient.GetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionUrlMapsClient.Insert</c>
        ///  and <c>RegionUrlMapsClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionUrlMapsClient.List</c>
        ///  and <c>RegionUrlMapsClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionUrlMapsClient.Patch</c>
        ///  and <c>RegionUrlMapsClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>RegionUrlMapsClient.Update</c>
        ///  and <c>RegionUrlMapsClient.UpdateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionUrlMapsClient.Validate</c> and <c>RegionUrlMapsClient.ValidateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ValidateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionUrlMapsSettings"/> object.</returns>
        public RegionUrlMapsSettings Clone() => new RegionUrlMapsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionUrlMapsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class RegionUrlMapsClientBuilder : gaxgrpc::ClientBuilderBase<RegionUrlMapsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionUrlMapsSettings Settings { get; set; }

        partial void InterceptBuild(ref RegionUrlMapsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionUrlMapsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionUrlMapsClient Build()
        {
            RegionUrlMapsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionUrlMapsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionUrlMapsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionUrlMapsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionUrlMapsClient.Create(callInvoker, Settings);
        }

        private async stt::Task<RegionUrlMapsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionUrlMapsClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => RegionUrlMapsClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => RegionUrlMapsClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionUrlMapsClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>RegionUrlMaps client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionUrlMaps API.
    /// </remarks>
    public abstract partial class RegionUrlMapsClient
    {
        /// <summary>
        /// The default endpoint for the RegionUrlMaps service, which is a host of "compute.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionUrlMaps scopes.</summary>
        /// <remarks>
        /// The default RegionUrlMaps scopes are:
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
        /// Asynchronously creates a <see cref="RegionUrlMapsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegionUrlMapsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionUrlMapsClient"/>.</returns>
        public static stt::Task<RegionUrlMapsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionUrlMapsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionUrlMapsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="RegionUrlMapsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionUrlMapsClient"/>.</returns>
        public static RegionUrlMapsClient Create() => new RegionUrlMapsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionUrlMapsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionUrlMapsSettings"/>.</param>
        /// <returns>The created <see cref="RegionUrlMapsClient"/>.</returns>
        internal static RegionUrlMapsClient Create(grpccore::CallInvoker callInvoker, RegionUrlMapsSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionUrlMaps.RegionUrlMapsClient grpcClient = new RegionUrlMaps.RegionUrlMapsClient(callInvoker);
            return new RegionUrlMapsClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC RegionUrlMaps client</summary>
        public virtual RegionUrlMaps.RegionUrlMapsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteRegionUrlMapRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string region, string urlMap, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteRegionUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string urlMap, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteRegionUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string urlMap, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, urlMap, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified UrlMap resource. Gets a list of available URL maps by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UrlMap Get(GetRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified UrlMap resource. Gets a list of available URL maps by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMap> GetAsync(GetRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified UrlMap resource. Gets a list of available URL maps by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMap> GetAsync(GetRegionUrlMapRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified UrlMap resource. Gets a list of available URL maps by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UrlMap Get(string project, string region, string urlMap, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRegionUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
            }, callSettings);

        /// <summary>
        /// Returns the specified UrlMap resource. Gets a list of available URL maps by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMap> GetAsync(string project, string region, string urlMap, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRegionUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
            }, callSettings);

        /// <summary>
        /// Returns the specified UrlMap resource. Gets a list of available URL maps by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMap> GetAsync(string project, string region, string urlMap, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, urlMap, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertRegionUrlMapRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, string region, UrlMap urlMapResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertRegionUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                UrlMapResource = gax::GaxPreconditions.CheckNotNull(urlMapResource, nameof(urlMapResource)),
            }, callSettings);

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, UrlMap urlMapResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertRegionUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                UrlMapResource = gax::GaxPreconditions.CheckNotNull(urlMapResource, nameof(urlMapResource)),
            }, callSettings);

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, UrlMap urlMapResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, urlMapResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of UrlMap resources available to the specified project in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UrlMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<UrlMapList, UrlMap> List(ListRegionUrlMapsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of UrlMap resources available to the specified project in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UrlMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<UrlMapList, UrlMap> ListAsync(ListRegionUrlMapsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of UrlMap resources available to the specified project in the specified region.
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
        /// <returns>A pageable sequence of <see cref="UrlMap"/> resources.</returns>
        public virtual gax::PagedEnumerable<UrlMapList, UrlMap> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListRegionUrlMapsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the list of UrlMap resources available to the specified project in the specified region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="UrlMap"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<UrlMapList, UrlMap> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListRegionUrlMapsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(PatchRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchRegionUrlMapRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to patch.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(string project, string region, string urlMap, UrlMap urlMapResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchRegionUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
                UrlMapResource = gax::GaxPreconditions.CheckNotNull(urlMapResource, nameof(urlMapResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to patch.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string region, string urlMap, UrlMap urlMapResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchRegionUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
                UrlMapResource = gax::GaxPreconditions.CheckNotNull(urlMapResource, nameof(urlMapResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to patch.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string region, string urlMap, UrlMap urlMapResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, region, urlMap, urlMapResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Update(UpdateRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(UpdateRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(UpdateRegionUrlMapRequest request, st::CancellationToken cancellationToken) =>
            UpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to update.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Update(string project, string region, string urlMap, UrlMap urlMapResource, gaxgrpc::CallSettings callSettings = null) =>
            Update(new UpdateRegionUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
                UrlMapResource = gax::GaxPreconditions.CheckNotNull(urlMapResource, nameof(urlMapResource)),
            }, callSettings);

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to update.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(string project, string region, string urlMap, UrlMap urlMapResource, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAsync(new UpdateRegionUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
                UrlMapResource = gax::GaxPreconditions.CheckNotNull(urlMapResource, nameof(urlMapResource)),
            }, callSettings);

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to update.
        /// </param>
        /// <param name="urlMapResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> UpdateAsync(string project, string region, string urlMap, UrlMap urlMapResource, st::CancellationToken cancellationToken) =>
            UpdateAsync(project, region, urlMap, urlMapResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UrlMapsValidateResponse Validate(ValidateRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMapsValidateResponse> ValidateAsync(ValidateRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMapsValidateResponse> ValidateAsync(ValidateRegionUrlMapRequest request, st::CancellationToken cancellationToken) =>
            ValidateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to be validated as.
        /// </param>
        /// <param name="regionUrlMapsValidateRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UrlMapsValidateResponse Validate(string project, string region, string urlMap, RegionUrlMapsValidateRequest regionUrlMapsValidateRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            Validate(new ValidateRegionUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionUrlMapsValidateRequestResource = gax::GaxPreconditions.CheckNotNull(regionUrlMapsValidateRequestResource, nameof(regionUrlMapsValidateRequestResource)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
            }, callSettings);

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to be validated as.
        /// </param>
        /// <param name="regionUrlMapsValidateRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMapsValidateResponse> ValidateAsync(string project, string region, string urlMap, RegionUrlMapsValidateRequest regionUrlMapsValidateRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            ValidateAsync(new ValidateRegionUrlMapRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionUrlMapsValidateRequestResource = gax::GaxPreconditions.CheckNotNull(regionUrlMapsValidateRequestResource, nameof(regionUrlMapsValidateRequestResource)),
                UrlMap = gax::GaxPreconditions.CheckNotNullOrEmpty(urlMap, nameof(urlMap)),
            }, callSettings);

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="urlMap">
        /// Name of the UrlMap resource to be validated as.
        /// </param>
        /// <param name="regionUrlMapsValidateRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UrlMapsValidateResponse> ValidateAsync(string project, string region, string urlMap, RegionUrlMapsValidateRequest regionUrlMapsValidateRequestResource, st::CancellationToken cancellationToken) =>
            ValidateAsync(project, region, urlMap, regionUrlMapsValidateRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RegionUrlMaps client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionUrlMaps API.
    /// </remarks>
    public sealed partial class RegionUrlMapsClientImpl : RegionUrlMapsClient
    {
        private readonly gaxgrpc::ApiCall<DeleteRegionUrlMapRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetRegionUrlMapRequest, UrlMap> _callGet;

        private readonly gaxgrpc::ApiCall<InsertRegionUrlMapRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListRegionUrlMapsRequest, UrlMapList> _callList;

        private readonly gaxgrpc::ApiCall<PatchRegionUrlMapRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<UpdateRegionUrlMapRequest, Operation> _callUpdate;

        private readonly gaxgrpc::ApiCall<ValidateRegionUrlMapRequest, UrlMapsValidateResponse> _callValidate;

        /// <summary>
        /// Constructs a client wrapper for the RegionUrlMaps service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RegionUrlMapsSettings"/> used within this client.</param>
        public RegionUrlMapsClientImpl(RegionUrlMaps.RegionUrlMapsClient grpcClient, RegionUrlMapsSettings settings)
        {
            GrpcClient = grpcClient;
            RegionUrlMapsSettings effectiveSettings = settings ?? RegionUrlMapsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callDelete = clientHelper.BuildApiCall<DeleteRegionUrlMapRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("url_map", request => request.UrlMap);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetRegionUrlMapRequest, UrlMap>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("url_map", request => request.UrlMap);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertRegionUrlMapRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListRegionUrlMapsRequest, UrlMapList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchRegionUrlMapRequest, Operation>(grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("url_map", request => request.UrlMap);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callUpdate = clientHelper.BuildApiCall<UpdateRegionUrlMapRequest, Operation>(grpcClient.UpdateAsync, grpcClient.Update, effectiveSettings.UpdateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("url_map", request => request.UrlMap);
            Modify_ApiCall(ref _callUpdate);
            Modify_UpdateApiCall(ref _callUpdate);
            _callValidate = clientHelper.BuildApiCall<ValidateRegionUrlMapRequest, UrlMapsValidateResponse>(grpcClient.ValidateAsync, grpcClient.Validate, effectiveSettings.ValidateSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("url_map", request => request.UrlMap);
            Modify_ApiCall(ref _callValidate);
            Modify_ValidateApiCall(ref _callValidate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteRegionUrlMapRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRegionUrlMapRequest, UrlMap> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertRegionUrlMapRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRegionUrlMapsRequest, UrlMapList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchRegionUrlMapRequest, Operation> call);

        partial void Modify_UpdateApiCall(ref gaxgrpc::ApiCall<UpdateRegionUrlMapRequest, Operation> call);

        partial void Modify_ValidateApiCall(ref gaxgrpc::ApiCall<ValidateRegionUrlMapRequest, UrlMapsValidateResponse> call);

        partial void OnConstruction(RegionUrlMaps.RegionUrlMapsClient grpcClient, RegionUrlMapsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionUrlMaps client</summary>
        public override RegionUrlMaps.RegionUrlMapsClient GrpcClient { get; }

        partial void Modify_DeleteRegionUrlMapRequest(ref DeleteRegionUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRegionUrlMapRequest(ref GetRegionUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertRegionUrlMapRequest(ref InsertRegionUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegionUrlMapsRequest(ref ListRegionUrlMapsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchRegionUrlMapRequest(ref PatchRegionUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateRegionUrlMapRequest(ref UpdateRegionUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ValidateRegionUrlMapRequest(ref ValidateRegionUrlMapRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionUrlMapRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified UrlMap resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionUrlMapRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified UrlMap resource. Gets a list of available URL maps by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UrlMap Get(GetRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionUrlMapRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified UrlMap resource. Gets a list of available URL maps by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UrlMap> GetAsync(GetRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionUrlMapRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionUrlMapRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a UrlMap resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionUrlMapRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of UrlMap resources available to the specified project in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="UrlMap"/> resources.</returns>
        public override gax::PagedEnumerable<UrlMapList, UrlMap> List(ListRegionUrlMapsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionUrlMapsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionUrlMapsRequest, UrlMapList, UrlMap>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of UrlMap resources available to the specified project in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="UrlMap"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<UrlMapList, UrlMap> ListAsync(ListRegionUrlMapsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionUrlMapsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionUrlMapsRequest, UrlMapList, UrlMap>(_callList, request, callSettings);
        }

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Patch(PatchRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRegionUrlMapRequest(ref request, ref callSettings);
            return _callPatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Patches the specified UrlMap resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PatchAsync(PatchRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchRegionUrlMapRequest(ref request, ref callSettings);
            return _callPatch.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Update(UpdateRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRegionUrlMapRequest(ref request, ref callSettings);
            return _callUpdate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the specified UrlMap resource with the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> UpdateAsync(UpdateRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateRegionUrlMapRequest(ref request, ref callSettings);
            return _callUpdate.Async(request, callSettings);
        }

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UrlMapsValidateResponse Validate(ValidateRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateRegionUrlMapRequest(ref request, ref callSettings);
            return _callValidate.Sync(request, callSettings);
        }

        /// <summary>
        /// Runs static validation for the UrlMap. In particular, the tests of the provided UrlMap will be run. Calling this method does NOT create the UrlMap.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UrlMapsValidateResponse> ValidateAsync(ValidateRegionUrlMapRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateRegionUrlMapRequest(ref request, ref callSettings);
            return _callValidate.Async(request, callSettings);
        }
    }

    public partial class ListRegionUrlMapsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class UrlMapList : gaxgrpc::IPageResponse<UrlMap>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<UrlMap> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
