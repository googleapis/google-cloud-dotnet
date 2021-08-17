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
    /// <summary>Settings for <see cref="TargetHttpProxiesClient"/> instances.</summary>
    public sealed partial class TargetHttpProxiesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TargetHttpProxiesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TargetHttpProxiesSettings"/>.</returns>
        public static TargetHttpProxiesSettings GetDefault() => new TargetHttpProxiesSettings();

        /// <summary>Constructs a new <see cref="TargetHttpProxiesSettings"/> object with default settings.</summary>
        public TargetHttpProxiesSettings()
        {
        }

        private TargetHttpProxiesSettings(TargetHttpProxiesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AggregatedListSettings = existing.AggregatedListSettings;
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            SetUrlMapSettings = existing.SetUrlMapSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TargetHttpProxiesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpProxiesClient.AggregatedList</c> and <c>TargetHttpProxiesClient.AggregatedListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpProxiesClient.Delete</c> and <c>TargetHttpProxiesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetHttpProxiesClient.Get</c>
        ///  and <c>TargetHttpProxiesClient.GetAsync</c>.
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
        /// <c>TargetHttpProxiesClient.Insert</c> and <c>TargetHttpProxiesClient.InsertAsync</c>.
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
        /// <c>TargetHttpProxiesClient.List</c> and <c>TargetHttpProxiesClient.ListAsync</c>.
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
        /// <c>TargetHttpProxiesClient.Patch</c> and <c>TargetHttpProxiesClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpProxiesClient.SetUrlMap</c> and <c>TargetHttpProxiesClient.SetUrlMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetUrlMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TargetHttpProxiesSettings"/> object.</returns>
        public TargetHttpProxiesSettings Clone() => new TargetHttpProxiesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TargetHttpProxiesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class TargetHttpProxiesClientBuilder : gaxgrpc::ClientBuilderBase<TargetHttpProxiesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TargetHttpProxiesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TargetHttpProxiesClientBuilder()
        {
            UseJwtAccessWithScopes = TargetHttpProxiesClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref TargetHttpProxiesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TargetHttpProxiesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TargetHttpProxiesClient Build()
        {
            TargetHttpProxiesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TargetHttpProxiesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TargetHttpProxiesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TargetHttpProxiesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TargetHttpProxiesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<TargetHttpProxiesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TargetHttpProxiesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => TargetHttpProxiesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => TargetHttpProxiesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TargetHttpProxiesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>TargetHttpProxies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The TargetHttpProxies API.
    /// </remarks>
    public abstract partial class TargetHttpProxiesClient
    {
        /// <summary>
        /// The default endpoint for the TargetHttpProxies service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default TargetHttpProxies scopes.</summary>
        /// <remarks>
        /// The default TargetHttpProxies scopes are:
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
        /// Asynchronously creates a <see cref="TargetHttpProxiesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetHttpProxiesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TargetHttpProxiesClient"/>.</returns>
        public static stt::Task<TargetHttpProxiesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TargetHttpProxiesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TargetHttpProxiesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetHttpProxiesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TargetHttpProxiesClient"/>.</returns>
        public static TargetHttpProxiesClient Create() => new TargetHttpProxiesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TargetHttpProxiesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TargetHttpProxiesSettings"/>.</param>
        /// <returns>The created <see cref="TargetHttpProxiesClient"/>.</returns>
        internal static TargetHttpProxiesClient Create(grpccore::CallInvoker callInvoker, TargetHttpProxiesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TargetHttpProxies.TargetHttpProxiesClient grpcClient = new TargetHttpProxies.TargetHttpProxiesClient(callInvoker);
            return new TargetHttpProxiesClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC TargetHttpProxies client</summary>
        public virtual TargetHttpProxies.TargetHttpProxiesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all TargetHttpProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetHttpProxyAggregatedList, scg::KeyValuePair<string, TargetHttpProxiesScopedList>> AggregatedList(AggregatedListTargetHttpProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all TargetHttpProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<TargetHttpProxyAggregatedList, scg::KeyValuePair<string, TargetHttpProxiesScopedList>> AggregatedListAsync(AggregatedListTargetHttpProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all TargetHttpProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
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
        public virtual gax::PagedEnumerable<TargetHttpProxyAggregatedList, scg::KeyValuePair<string, TargetHttpProxiesScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedList(new AggregatedListTargetHttpProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the list of all TargetHttpProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
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
        public virtual gax::PagedAsyncEnumerable<TargetHttpProxyAggregatedList, scg::KeyValuePair<string, TargetHttpProxiesScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedListAsync(new AggregatedListTargetHttpProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetHttpProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetHttpProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetHttpProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteTargetHttpProxyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified TargetHttpProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxy">
        /// Name of the TargetHttpProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string targetHttpProxy, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteTargetHttpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpProxy, nameof(targetHttpProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetHttpProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxy">
        /// Name of the TargetHttpProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string targetHttpProxy, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteTargetHttpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpProxy, nameof(targetHttpProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetHttpProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxy">
        /// Name of the TargetHttpProxy resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string targetHttpProxy, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, targetHttpProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetHttpProxy resource. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetHttpProxy Get(GetTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetHttpProxy resource. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpProxy> GetAsync(GetTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetHttpProxy resource. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpProxy> GetAsync(GetTargetHttpProxyRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetHttpProxy resource. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxy">
        /// Name of the TargetHttpProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetHttpProxy Get(string project, string targetHttpProxy, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetTargetHttpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpProxy, nameof(targetHttpProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetHttpProxy resource. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxy">
        /// Name of the TargetHttpProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpProxy> GetAsync(string project, string targetHttpProxy, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetTargetHttpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpProxy, nameof(targetHttpProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetHttpProxy resource. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxy">
        /// Name of the TargetHttpProxy resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpProxy> GetAsync(string project, string targetHttpProxy, st::CancellationToken cancellationToken) =>
            GetAsync(project, targetHttpProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TargetHttpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetHttpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetHttpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertTargetHttpProxyRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TargetHttpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, TargetHttpProxy targetHttpProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertTargetHttpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpProxyResource, nameof(targetHttpProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetHttpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, TargetHttpProxy targetHttpProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertTargetHttpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpProxyResource, nameof(targetHttpProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetHttpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, TargetHttpProxy targetHttpProxyResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, targetHttpProxyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of TargetHttpProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetHttpProxy"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetHttpProxyList, TargetHttpProxy> List(ListTargetHttpProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetHttpProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetHttpProxy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetHttpProxyList, TargetHttpProxy> ListAsync(ListTargetHttpProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetHttpProxy resources available to the specified project.
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
        /// <returns>A pageable sequence of <see cref="TargetHttpProxy"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetHttpProxyList, TargetHttpProxy> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListTargetHttpProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the list of TargetHttpProxy resources available to the specified project.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetHttpProxy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetHttpProxyList, TargetHttpProxy> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListTargetHttpProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Patches the specified TargetHttpProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(PatchTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified TargetHttpProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified TargetHttpProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchTargetHttpProxyRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified TargetHttpProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxy">
        /// Name of the TargetHttpProxy resource to patch.
        /// </param>
        /// <param name="targetHttpProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(string project, string targetHttpProxy, TargetHttpProxy targetHttpProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchTargetHttpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpProxy, nameof(targetHttpProxy)),
                TargetHttpProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpProxyResource, nameof(targetHttpProxyResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified TargetHttpProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxy">
        /// Name of the TargetHttpProxy resource to patch.
        /// </param>
        /// <param name="targetHttpProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string targetHttpProxy, TargetHttpProxy targetHttpProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchTargetHttpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpProxy, nameof(targetHttpProxy)),
                TargetHttpProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpProxyResource, nameof(targetHttpProxyResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified TargetHttpProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxy">
        /// Name of the TargetHttpProxy resource to patch.
        /// </param>
        /// <param name="targetHttpProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string targetHttpProxy, TargetHttpProxy targetHttpProxyResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, targetHttpProxy, targetHttpProxyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the URL map for TargetHttpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetUrlMap(SetUrlMapTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the URL map for TargetHttpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetUrlMapAsync(SetUrlMapTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the URL map for TargetHttpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetUrlMapAsync(SetUrlMapTargetHttpProxyRequest request, st::CancellationToken cancellationToken) =>
            SetUrlMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the URL map for TargetHttpProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxy">
        /// Name of the TargetHttpProxy to set a URL map for.
        /// </param>
        /// <param name="urlMapReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetUrlMap(string project, string targetHttpProxy, UrlMapReference urlMapReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetUrlMap(new SetUrlMapTargetHttpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpProxy, nameof(targetHttpProxy)),
                UrlMapReferenceResource = gax::GaxPreconditions.CheckNotNull(urlMapReferenceResource, nameof(urlMapReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Changes the URL map for TargetHttpProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxy">
        /// Name of the TargetHttpProxy to set a URL map for.
        /// </param>
        /// <param name="urlMapReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetUrlMapAsync(string project, string targetHttpProxy, UrlMapReference urlMapReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetUrlMapAsync(new SetUrlMapTargetHttpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpProxy, nameof(targetHttpProxy)),
                UrlMapReferenceResource = gax::GaxPreconditions.CheckNotNull(urlMapReferenceResource, nameof(urlMapReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Changes the URL map for TargetHttpProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpProxy">
        /// Name of the TargetHttpProxy to set a URL map for.
        /// </param>
        /// <param name="urlMapReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetUrlMapAsync(string project, string targetHttpProxy, UrlMapReference urlMapReferenceResource, st::CancellationToken cancellationToken) =>
            SetUrlMapAsync(project, targetHttpProxy, urlMapReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TargetHttpProxies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The TargetHttpProxies API.
    /// </remarks>
    public sealed partial class TargetHttpProxiesClientImpl : TargetHttpProxiesClient
    {
        private readonly gaxgrpc::ApiCall<AggregatedListTargetHttpProxiesRequest, TargetHttpProxyAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<DeleteTargetHttpProxyRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetTargetHttpProxyRequest, TargetHttpProxy> _callGet;

        private readonly gaxgrpc::ApiCall<InsertTargetHttpProxyRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListTargetHttpProxiesRequest, TargetHttpProxyList> _callList;

        private readonly gaxgrpc::ApiCall<PatchTargetHttpProxyRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<SetUrlMapTargetHttpProxyRequest, Operation> _callSetUrlMap;

        /// <summary>
        /// Constructs a client wrapper for the TargetHttpProxies service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TargetHttpProxiesSettings"/> used within this client.</param>
        public TargetHttpProxiesClientImpl(TargetHttpProxies.TargetHttpProxiesClient grpcClient, TargetHttpProxiesSettings settings)
        {
            GrpcClient = grpcClient;
            TargetHttpProxiesSettings effectiveSettings = settings ?? TargetHttpProxiesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListTargetHttpProxiesRequest, TargetHttpProxyAggregatedList>(grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callDelete = clientHelper.BuildApiCall<DeleteTargetHttpProxyRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_http_proxy", request => request.TargetHttpProxy);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetTargetHttpProxyRequest, TargetHttpProxy>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_http_proxy", request => request.TargetHttpProxy);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertTargetHttpProxyRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListTargetHttpProxiesRequest, TargetHttpProxyList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchTargetHttpProxyRequest, Operation>(grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_http_proxy", request => request.TargetHttpProxy);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callSetUrlMap = clientHelper.BuildApiCall<SetUrlMapTargetHttpProxyRequest, Operation>(grpcClient.SetUrlMapAsync, grpcClient.SetUrlMap, effectiveSettings.SetUrlMapSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_http_proxy", request => request.TargetHttpProxy);
            Modify_ApiCall(ref _callSetUrlMap);
            Modify_SetUrlMapApiCall(ref _callSetUrlMap);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListTargetHttpProxiesRequest, TargetHttpProxyAggregatedList> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteTargetHttpProxyRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetTargetHttpProxyRequest, TargetHttpProxy> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertTargetHttpProxyRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListTargetHttpProxiesRequest, TargetHttpProxyList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchTargetHttpProxyRequest, Operation> call);

        partial void Modify_SetUrlMapApiCall(ref gaxgrpc::ApiCall<SetUrlMapTargetHttpProxyRequest, Operation> call);

        partial void OnConstruction(TargetHttpProxies.TargetHttpProxiesClient grpcClient, TargetHttpProxiesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TargetHttpProxies client</summary>
        public override TargetHttpProxies.TargetHttpProxiesClient GrpcClient { get; }

        partial void Modify_AggregatedListTargetHttpProxiesRequest(ref AggregatedListTargetHttpProxiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTargetHttpProxyRequest(ref DeleteTargetHttpProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTargetHttpProxyRequest(ref GetTargetHttpProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertTargetHttpProxyRequest(ref InsertTargetHttpProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTargetHttpProxiesRequest(ref ListTargetHttpProxiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchTargetHttpProxyRequest(ref PatchTargetHttpProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetUrlMapTargetHttpProxyRequest(ref SetUrlMapTargetHttpProxyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the list of all TargetHttpProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<TargetHttpProxyAggregatedList, scg::KeyValuePair<string, TargetHttpProxiesScopedList>> AggregatedList(AggregatedListTargetHttpProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListTargetHttpProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListTargetHttpProxiesRequest, TargetHttpProxyAggregatedList, scg::KeyValuePair<string, TargetHttpProxiesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all TargetHttpProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<TargetHttpProxyAggregatedList, scg::KeyValuePair<string, TargetHttpProxiesScopedList>> AggregatedListAsync(AggregatedListTargetHttpProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListTargetHttpProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListTargetHttpProxiesRequest, TargetHttpProxyAggregatedList, scg::KeyValuePair<string, TargetHttpProxiesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Deletes the specified TargetHttpProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetHttpProxyRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified TargetHttpProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetHttpProxyRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified TargetHttpProxy resource. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetHttpProxy Get(GetTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetHttpProxyRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified TargetHttpProxy resource. Gets a list of available target HTTP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetHttpProxy> GetAsync(GetTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetHttpProxyRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a TargetHttpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetHttpProxyRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a TargetHttpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetHttpProxyRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetHttpProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetHttpProxy"/> resources.</returns>
        public override gax::PagedEnumerable<TargetHttpProxyList, TargetHttpProxy> List(ListTargetHttpProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetHttpProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTargetHttpProxiesRequest, TargetHttpProxyList, TargetHttpProxy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetHttpProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetHttpProxy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<TargetHttpProxyList, TargetHttpProxy> ListAsync(ListTargetHttpProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetHttpProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTargetHttpProxiesRequest, TargetHttpProxyList, TargetHttpProxy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Patches the specified TargetHttpProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Patch(PatchTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchTargetHttpProxyRequest(ref request, ref callSettings);
            return _callPatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Patches the specified TargetHttpProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PatchAsync(PatchTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchTargetHttpProxyRequest(ref request, ref callSettings);
            return _callPatch.Async(request, callSettings);
        }

        /// <summary>
        /// Changes the URL map for TargetHttpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetUrlMap(SetUrlMapTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUrlMapTargetHttpProxyRequest(ref request, ref callSettings);
            return _callSetUrlMap.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes the URL map for TargetHttpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetUrlMapAsync(SetUrlMapTargetHttpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUrlMapTargetHttpProxyRequest(ref request, ref callSettings);
            return _callSetUrlMap.Async(request, callSettings);
        }
    }

    public partial class AggregatedListTargetHttpProxiesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListTargetHttpProxiesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class TargetHttpProxyAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, TargetHttpProxiesScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, TargetHttpProxiesScopedList>> GetEnumerator() =>
            Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
