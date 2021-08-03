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
    /// <summary>Settings for <see cref="RegionTargetHttpsProxiesClient"/> instances.</summary>
    public sealed partial class RegionTargetHttpsProxiesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RegionTargetHttpsProxiesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RegionTargetHttpsProxiesSettings"/>.</returns>
        public static RegionTargetHttpsProxiesSettings GetDefault() => new RegionTargetHttpsProxiesSettings();

        /// <summary>
        /// Constructs a new <see cref="RegionTargetHttpsProxiesSettings"/> object with default settings.
        /// </summary>
        public RegionTargetHttpsProxiesSettings()
        {
        }

        private RegionTargetHttpsProxiesSettings(RegionTargetHttpsProxiesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            SetSslCertificatesSettings = existing.SetSslCertificatesSettings;
            SetUrlMapSettings = existing.SetUrlMapSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RegionTargetHttpsProxiesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionTargetHttpsProxiesClient.Delete</c> and <c>RegionTargetHttpsProxiesClient.DeleteAsync</c>.
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
        /// <c>RegionTargetHttpsProxiesClient.Get</c> and <c>RegionTargetHttpsProxiesClient.GetAsync</c>.
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
        /// <c>RegionTargetHttpsProxiesClient.Insert</c> and <c>RegionTargetHttpsProxiesClient.InsertAsync</c>.
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
        /// <c>RegionTargetHttpsProxiesClient.List</c> and <c>RegionTargetHttpsProxiesClient.ListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionTargetHttpsProxiesClient.SetSslCertificates</c> and
        /// <c>RegionTargetHttpsProxiesClient.SetSslCertificatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSslCertificatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RegionTargetHttpsProxiesClient.SetUrlMap</c> and <c>RegionTargetHttpsProxiesClient.SetUrlMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetUrlMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RegionTargetHttpsProxiesSettings"/> object.</returns>
        public RegionTargetHttpsProxiesSettings Clone() => new RegionTargetHttpsProxiesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RegionTargetHttpsProxiesClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class RegionTargetHttpsProxiesClientBuilder : gaxgrpc::ClientBuilderBase<RegionTargetHttpsProxiesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RegionTargetHttpsProxiesSettings Settings { get; set; }

        partial void InterceptBuild(ref RegionTargetHttpsProxiesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RegionTargetHttpsProxiesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RegionTargetHttpsProxiesClient Build()
        {
            RegionTargetHttpsProxiesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RegionTargetHttpsProxiesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RegionTargetHttpsProxiesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RegionTargetHttpsProxiesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RegionTargetHttpsProxiesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<RegionTargetHttpsProxiesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RegionTargetHttpsProxiesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => RegionTargetHttpsProxiesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => RegionTargetHttpsProxiesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RegionTargetHttpsProxiesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>RegionTargetHttpsProxies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The RegionTargetHttpsProxies API.
    /// </remarks>
    public abstract partial class RegionTargetHttpsProxiesClient
    {
        /// <summary>
        /// The default endpoint for the RegionTargetHttpsProxies service, which is a host of "compute.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default RegionTargetHttpsProxies scopes.</summary>
        /// <remarks>
        /// The default RegionTargetHttpsProxies scopes are:
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
        /// Asynchronously creates a <see cref="RegionTargetHttpsProxiesClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionTargetHttpsProxiesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RegionTargetHttpsProxiesClient"/>.</returns>
        public static stt::Task<RegionTargetHttpsProxiesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RegionTargetHttpsProxiesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RegionTargetHttpsProxiesClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="RegionTargetHttpsProxiesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RegionTargetHttpsProxiesClient"/>.</returns>
        public static RegionTargetHttpsProxiesClient Create() => new RegionTargetHttpsProxiesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RegionTargetHttpsProxiesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RegionTargetHttpsProxiesSettings"/>.</param>
        /// <returns>The created <see cref="RegionTargetHttpsProxiesClient"/>.</returns>
        internal static RegionTargetHttpsProxiesClient Create(grpccore::CallInvoker callInvoker, RegionTargetHttpsProxiesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient grpcClient = new RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient(callInvoker);
            return new RegionTargetHttpsProxiesClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC RegionTargetHttpsProxies client</summary>
        public virtual RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteRegionTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string region, string targetHttpsProxy, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteRegionTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string targetHttpsProxy, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteRegionTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string region, string targetHttpsProxy, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, region, targetHttpsProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource in the specified region. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetHttpsProxy Get(GetRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource in the specified region. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxy> GetAsync(GetRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource in the specified region. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxy> GetAsync(GetRegionTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource in the specified region. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetHttpsProxy Get(string project, string region, string targetHttpsProxy, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetRegionTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource in the specified region. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxy> GetAsync(string project, string region, string targetHttpsProxy, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetRegionTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource in the specified region. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxy> GetAsync(string project, string region, string targetHttpsProxy, st::CancellationToken cancellationToken) =>
            GetAsync(project, region, targetHttpsProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertRegionTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, string region, TargetHttpsProxy targetHttpsProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertRegionTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetHttpsProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxyResource, nameof(targetHttpsProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, TargetHttpsProxy targetHttpsProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertRegionTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetHttpsProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxyResource, nameof(targetHttpsProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, string region, TargetHttpsProxy targetHttpsProxyResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, region, targetHttpsProxyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetHttpsProxy"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetHttpsProxyList, TargetHttpsProxy> List(ListRegionTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetHttpsProxy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetHttpsProxyList, TargetHttpsProxy> ListAsync(ListRegionTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project in the specified region.
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
        /// <returns>A pageable sequence of <see cref="TargetHttpsProxy"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetHttpsProxyList, TargetHttpsProxy> List(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListRegionTargetHttpsProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project in the specified region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetHttpsProxy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetHttpsProxyList, TargetHttpsProxy> ListAsync(string project, string region, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListRegionTargetHttpsProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetSslCertificates(SetSslCertificatesRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslCertificatesAsync(SetSslCertificatesRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslCertificatesAsync(SetSslCertificatesRegionTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            SetSslCertificatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set an SslCertificates resource for.
        /// </param>
        /// <param name="regionTargetHttpsProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetSslCertificates(string project, string region, string targetHttpsProxy, RegionTargetHttpsProxiesSetSslCertificatesRequest regionTargetHttpsProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslCertificates(new SetSslCertificatesRegionTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionTargetHttpsProxiesSetSslCertificatesRequestResource = gax::GaxPreconditions.CheckNotNull(regionTargetHttpsProxiesSetSslCertificatesRequestResource, nameof(regionTargetHttpsProxiesSetSslCertificatesRequestResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set an SslCertificates resource for.
        /// </param>
        /// <param name="regionTargetHttpsProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslCertificatesAsync(string project, string region, string targetHttpsProxy, RegionTargetHttpsProxiesSetSslCertificatesRequest regionTargetHttpsProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslCertificatesAsync(new SetSslCertificatesRegionTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                RegionTargetHttpsProxiesSetSslCertificatesRequestResource = gax::GaxPreconditions.CheckNotNull(regionTargetHttpsProxiesSetSslCertificatesRequestResource, nameof(regionTargetHttpsProxiesSetSslCertificatesRequestResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set an SslCertificates resource for.
        /// </param>
        /// <param name="regionTargetHttpsProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslCertificatesAsync(string project, string region, string targetHttpsProxy, RegionTargetHttpsProxiesSetSslCertificatesRequest regionTargetHttpsProxiesSetSslCertificatesRequestResource, st::CancellationToken cancellationToken) =>
            SetSslCertificatesAsync(project, region, targetHttpsProxy, regionTargetHttpsProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetUrlMap(SetUrlMapRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetUrlMapAsync(SetUrlMapRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetUrlMapAsync(SetUrlMapRegionTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            SetUrlMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy to set a URL map for.
        /// </param>
        /// <param name="urlMapReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetUrlMap(string project, string region, string targetHttpsProxy, UrlMapReference urlMapReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetUrlMap(new SetUrlMapRegionTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
                UrlMapReferenceResource = gax::GaxPreconditions.CheckNotNull(urlMapReferenceResource, nameof(urlMapReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy to set a URL map for.
        /// </param>
        /// <param name="urlMapReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetUrlMapAsync(string project, string region, string targetHttpsProxy, UrlMapReference urlMapReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetUrlMapAsync(new SetUrlMapRegionTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                Region = gax::GaxPreconditions.CheckNotNullOrEmpty(region, nameof(region)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
                UrlMapReferenceResource = gax::GaxPreconditions.CheckNotNull(urlMapReferenceResource, nameof(urlMapReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="region">
        /// Name of the region scoping this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy to set a URL map for.
        /// </param>
        /// <param name="urlMapReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetUrlMapAsync(string project, string region, string targetHttpsProxy, UrlMapReference urlMapReferenceResource, st::CancellationToken cancellationToken) =>
            SetUrlMapAsync(project, region, targetHttpsProxy, urlMapReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RegionTargetHttpsProxies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The RegionTargetHttpsProxies API.
    /// </remarks>
    public sealed partial class RegionTargetHttpsProxiesClientImpl : RegionTargetHttpsProxiesClient
    {
        private readonly gaxgrpc::ApiCall<DeleteRegionTargetHttpsProxyRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetRegionTargetHttpsProxyRequest, TargetHttpsProxy> _callGet;

        private readonly gaxgrpc::ApiCall<InsertRegionTargetHttpsProxyRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListRegionTargetHttpsProxiesRequest, TargetHttpsProxyList> _callList;

        private readonly gaxgrpc::ApiCall<SetSslCertificatesRegionTargetHttpsProxyRequest, Operation> _callSetSslCertificates;

        private readonly gaxgrpc::ApiCall<SetUrlMapRegionTargetHttpsProxyRequest, Operation> _callSetUrlMap;

        /// <summary>
        /// Constructs a client wrapper for the RegionTargetHttpsProxies service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RegionTargetHttpsProxiesSettings"/> used within this client.
        /// </param>
        public RegionTargetHttpsProxiesClientImpl(RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient grpcClient, RegionTargetHttpsProxiesSettings settings)
        {
            GrpcClient = grpcClient;
            RegionTargetHttpsProxiesSettings effectiveSettings = settings ?? RegionTargetHttpsProxiesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callDelete = clientHelper.BuildApiCall<DeleteRegionTargetHttpsProxyRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetRegionTargetHttpsProxyRequest, TargetHttpsProxy>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertRegionTargetHttpsProxyRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListRegionTargetHttpsProxiesRequest, TargetHttpsProxyList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callSetSslCertificates = clientHelper.BuildApiCall<SetSslCertificatesRegionTargetHttpsProxyRequest, Operation>(grpcClient.SetSslCertificatesAsync, grpcClient.SetSslCertificates, effectiveSettings.SetSslCertificatesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callSetSslCertificates);
            Modify_SetSslCertificatesApiCall(ref _callSetSslCertificates);
            _callSetUrlMap = clientHelper.BuildApiCall<SetUrlMapRegionTargetHttpsProxyRequest, Operation>(grpcClient.SetUrlMapAsync, grpcClient.SetUrlMap, effectiveSettings.SetUrlMapSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("region", request => request.Region).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callSetUrlMap);
            Modify_SetUrlMapApiCall(ref _callSetUrlMap);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteRegionTargetHttpsProxyRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetRegionTargetHttpsProxyRequest, TargetHttpsProxy> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertRegionTargetHttpsProxyRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListRegionTargetHttpsProxiesRequest, TargetHttpsProxyList> call);

        partial void Modify_SetSslCertificatesApiCall(ref gaxgrpc::ApiCall<SetSslCertificatesRegionTargetHttpsProxyRequest, Operation> call);

        partial void Modify_SetUrlMapApiCall(ref gaxgrpc::ApiCall<SetUrlMapRegionTargetHttpsProxyRequest, Operation> call);

        partial void OnConstruction(RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient grpcClient, RegionTargetHttpsProxiesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RegionTargetHttpsProxies client</summary>
        public override RegionTargetHttpsProxies.RegionTargetHttpsProxiesClient GrpcClient { get; }

        partial void Modify_DeleteRegionTargetHttpsProxyRequest(ref DeleteRegionTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRegionTargetHttpsProxyRequest(ref GetRegionTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertRegionTargetHttpsProxyRequest(ref InsertRegionTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRegionTargetHttpsProxiesRequest(ref ListRegionTargetHttpsProxiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSslCertificatesRegionTargetHttpsProxyRequest(ref SetSslCertificatesRegionTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetUrlMapRegionTargetHttpsProxyRequest(ref SetUrlMapRegionTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteRegionTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource in the specified region. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetHttpsProxy Get(GetRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource in the specified region. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetHttpsProxy> GetAsync(GetRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRegionTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project and region using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertRegionTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetHttpsProxy"/> resources.</returns>
        public override gax::PagedEnumerable<TargetHttpsProxyList, TargetHttpsProxy> List(ListRegionTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionTargetHttpsProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRegionTargetHttpsProxiesRequest, TargetHttpsProxyList, TargetHttpsProxy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project in the specified region.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetHttpsProxy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<TargetHttpsProxyList, TargetHttpsProxy> ListAsync(ListRegionTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRegionTargetHttpsProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRegionTargetHttpsProxiesRequest, TargetHttpsProxyList, TargetHttpsProxy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetSslCertificates(SetSslCertificatesRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslCertificatesRegionTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callSetSslCertificates.Sync(request, callSettings);
        }

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetSslCertificatesAsync(SetSslCertificatesRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslCertificatesRegionTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callSetSslCertificates.Async(request, callSettings);
        }

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetUrlMap(SetUrlMapRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUrlMapRegionTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callSetUrlMap.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetUrlMapAsync(SetUrlMapRegionTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUrlMapRegionTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callSetUrlMap.Async(request, callSettings);
        }
    }

    public partial class ListRegionTargetHttpsProxiesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class TargetHttpsProxyList : gaxgrpc::IPageResponse<TargetHttpsProxy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TargetHttpsProxy> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
