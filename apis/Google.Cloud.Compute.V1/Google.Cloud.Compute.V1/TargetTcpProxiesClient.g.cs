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
    /// <summary>Settings for <see cref="TargetTcpProxiesClient"/> instances.</summary>
    public sealed partial class TargetTcpProxiesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TargetTcpProxiesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TargetTcpProxiesSettings"/>.</returns>
        public static TargetTcpProxiesSettings GetDefault() => new TargetTcpProxiesSettings();

        /// <summary>Constructs a new <see cref="TargetTcpProxiesSettings"/> object with default settings.</summary>
        public TargetTcpProxiesSettings()
        {
        }

        private TargetTcpProxiesSettings(TargetTcpProxiesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            SetBackendServiceSettings = existing.SetBackendServiceSettings;
            SetProxyHeaderSettings = existing.SetProxyHeaderSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TargetTcpProxiesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetTcpProxiesClient.Delete</c> and <c>TargetTcpProxiesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetTcpProxiesClient.Get</c>
        ///  and <c>TargetTcpProxiesClient.GetAsync</c>.
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
        /// <c>TargetTcpProxiesClient.Insert</c> and <c>TargetTcpProxiesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetTcpProxiesClient.List</c>
        ///  and <c>TargetTcpProxiesClient.ListAsync</c>.
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
        /// <c>TargetTcpProxiesClient.SetBackendService</c> and <c>TargetTcpProxiesClient.SetBackendServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetBackendServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetTcpProxiesClient.SetProxyHeader</c> and <c>TargetTcpProxiesClient.SetProxyHeaderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetProxyHeaderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TargetTcpProxiesSettings"/> object.</returns>
        public TargetTcpProxiesSettings Clone() => new TargetTcpProxiesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TargetTcpProxiesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class TargetTcpProxiesClientBuilder : gaxgrpc::ClientBuilderBase<TargetTcpProxiesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TargetTcpProxiesSettings Settings { get; set; }

        partial void InterceptBuild(ref TargetTcpProxiesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TargetTcpProxiesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TargetTcpProxiesClient Build()
        {
            TargetTcpProxiesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TargetTcpProxiesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TargetTcpProxiesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TargetTcpProxiesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TargetTcpProxiesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<TargetTcpProxiesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TargetTcpProxiesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => TargetTcpProxiesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => TargetTcpProxiesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TargetTcpProxiesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>TargetTcpProxies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The TargetTcpProxies API.
    /// </remarks>
    public abstract partial class TargetTcpProxiesClient
    {
        /// <summary>
        /// The default endpoint for the TargetTcpProxies service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default TargetTcpProxies scopes.</summary>
        /// <remarks>
        /// The default TargetTcpProxies scopes are:
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
        /// Asynchronously creates a <see cref="TargetTcpProxiesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetTcpProxiesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TargetTcpProxiesClient"/>.</returns>
        public static stt::Task<TargetTcpProxiesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TargetTcpProxiesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TargetTcpProxiesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetTcpProxiesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TargetTcpProxiesClient"/>.</returns>
        public static TargetTcpProxiesClient Create() => new TargetTcpProxiesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TargetTcpProxiesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TargetTcpProxiesSettings"/>.</param>
        /// <returns>The created <see cref="TargetTcpProxiesClient"/>.</returns>
        internal static TargetTcpProxiesClient Create(grpccore::CallInvoker callInvoker, TargetTcpProxiesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TargetTcpProxies.TargetTcpProxiesClient grpcClient = new TargetTcpProxies.TargetTcpProxiesClient(callInvoker);
            return new TargetTcpProxiesClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC TargetTcpProxies client</summary>
        public virtual TargetTcpProxies.TargetTcpProxiesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetTcpProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetTcpProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetTcpProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteTargetTcpProxyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified TargetTcpProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxy">
        /// Name of the TargetTcpProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string targetTcpProxy, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteTargetTcpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetTcpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetTcpProxy, nameof(targetTcpProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetTcpProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxy">
        /// Name of the TargetTcpProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string targetTcpProxy, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteTargetTcpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetTcpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetTcpProxy, nameof(targetTcpProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetTcpProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxy">
        /// Name of the TargetTcpProxy resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string targetTcpProxy, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, targetTcpProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetTcpProxy resource. Gets a list of available target TCP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetTcpProxy Get(GetTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetTcpProxy resource. Gets a list of available target TCP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetTcpProxy> GetAsync(GetTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetTcpProxy resource. Gets a list of available target TCP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetTcpProxy> GetAsync(GetTargetTcpProxyRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetTcpProxy resource. Gets a list of available target TCP proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxy">
        /// Name of the TargetTcpProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetTcpProxy Get(string project, string targetTcpProxy, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetTargetTcpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetTcpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetTcpProxy, nameof(targetTcpProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetTcpProxy resource. Gets a list of available target TCP proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxy">
        /// Name of the TargetTcpProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetTcpProxy> GetAsync(string project, string targetTcpProxy, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetTargetTcpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetTcpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetTcpProxy, nameof(targetTcpProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetTcpProxy resource. Gets a list of available target TCP proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxy">
        /// Name of the TargetTcpProxy resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetTcpProxy> GetAsync(string project, string targetTcpProxy, st::CancellationToken cancellationToken) =>
            GetAsync(project, targetTcpProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TargetTcpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetTcpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetTcpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertTargetTcpProxyRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TargetTcpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, TargetTcpProxy targetTcpProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertTargetTcpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetTcpProxyResource = gax::GaxPreconditions.CheckNotNull(targetTcpProxyResource, nameof(targetTcpProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetTcpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, TargetTcpProxy targetTcpProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertTargetTcpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetTcpProxyResource = gax::GaxPreconditions.CheckNotNull(targetTcpProxyResource, nameof(targetTcpProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetTcpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, TargetTcpProxy targetTcpProxyResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, targetTcpProxyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of TargetTcpProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetTcpProxy"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetTcpProxyList, TargetTcpProxy> List(ListTargetTcpProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetTcpProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetTcpProxy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetTcpProxyList, TargetTcpProxy> ListAsync(ListTargetTcpProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetTcpProxy resources available to the specified project.
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
        /// <returns>A pageable sequence of <see cref="TargetTcpProxy"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetTcpProxyList, TargetTcpProxy> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListTargetTcpProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the list of TargetTcpProxy resources available to the specified project.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetTcpProxy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetTcpProxyList, TargetTcpProxy> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListTargetTcpProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Changes the BackendService for TargetTcpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetBackendService(SetBackendServiceTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the BackendService for TargetTcpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetBackendServiceAsync(SetBackendServiceTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the BackendService for TargetTcpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetBackendServiceAsync(SetBackendServiceTargetTcpProxyRequest request, st::CancellationToken cancellationToken) =>
            SetBackendServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the BackendService for TargetTcpProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxy">
        /// Name of the TargetTcpProxy resource whose BackendService resource is to be set.
        /// </param>
        /// <param name="targetTcpProxiesSetBackendServiceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetBackendService(string project, string targetTcpProxy, TargetTcpProxiesSetBackendServiceRequest targetTcpProxiesSetBackendServiceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetBackendService(new SetBackendServiceTargetTcpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetTcpProxiesSetBackendServiceRequestResource = gax::GaxPreconditions.CheckNotNull(targetTcpProxiesSetBackendServiceRequestResource, nameof(targetTcpProxiesSetBackendServiceRequestResource)),
                TargetTcpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetTcpProxy, nameof(targetTcpProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the BackendService for TargetTcpProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxy">
        /// Name of the TargetTcpProxy resource whose BackendService resource is to be set.
        /// </param>
        /// <param name="targetTcpProxiesSetBackendServiceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetBackendServiceAsync(string project, string targetTcpProxy, TargetTcpProxiesSetBackendServiceRequest targetTcpProxiesSetBackendServiceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetBackendServiceAsync(new SetBackendServiceTargetTcpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetTcpProxiesSetBackendServiceRequestResource = gax::GaxPreconditions.CheckNotNull(targetTcpProxiesSetBackendServiceRequestResource, nameof(targetTcpProxiesSetBackendServiceRequestResource)),
                TargetTcpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetTcpProxy, nameof(targetTcpProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the BackendService for TargetTcpProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxy">
        /// Name of the TargetTcpProxy resource whose BackendService resource is to be set.
        /// </param>
        /// <param name="targetTcpProxiesSetBackendServiceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetBackendServiceAsync(string project, string targetTcpProxy, TargetTcpProxiesSetBackendServiceRequest targetTcpProxiesSetBackendServiceRequestResource, st::CancellationToken cancellationToken) =>
            SetBackendServiceAsync(project, targetTcpProxy, targetTcpProxiesSetBackendServiceRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the ProxyHeaderType for TargetTcpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetProxyHeader(SetProxyHeaderTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the ProxyHeaderType for TargetTcpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetProxyHeaderAsync(SetProxyHeaderTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the ProxyHeaderType for TargetTcpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetProxyHeaderAsync(SetProxyHeaderTargetTcpProxyRequest request, st::CancellationToken cancellationToken) =>
            SetProxyHeaderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the ProxyHeaderType for TargetTcpProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxy">
        /// Name of the TargetTcpProxy resource whose ProxyHeader is to be set.
        /// </param>
        /// <param name="targetTcpProxiesSetProxyHeaderRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetProxyHeader(string project, string targetTcpProxy, TargetTcpProxiesSetProxyHeaderRequest targetTcpProxiesSetProxyHeaderRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetProxyHeader(new SetProxyHeaderTargetTcpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetTcpProxiesSetProxyHeaderRequestResource = gax::GaxPreconditions.CheckNotNull(targetTcpProxiesSetProxyHeaderRequestResource, nameof(targetTcpProxiesSetProxyHeaderRequestResource)),
                TargetTcpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetTcpProxy, nameof(targetTcpProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the ProxyHeaderType for TargetTcpProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxy">
        /// Name of the TargetTcpProxy resource whose ProxyHeader is to be set.
        /// </param>
        /// <param name="targetTcpProxiesSetProxyHeaderRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetProxyHeaderAsync(string project, string targetTcpProxy, TargetTcpProxiesSetProxyHeaderRequest targetTcpProxiesSetProxyHeaderRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetProxyHeaderAsync(new SetProxyHeaderTargetTcpProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetTcpProxiesSetProxyHeaderRequestResource = gax::GaxPreconditions.CheckNotNull(targetTcpProxiesSetProxyHeaderRequestResource, nameof(targetTcpProxiesSetProxyHeaderRequestResource)),
                TargetTcpProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetTcpProxy, nameof(targetTcpProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the ProxyHeaderType for TargetTcpProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetTcpProxy">
        /// Name of the TargetTcpProxy resource whose ProxyHeader is to be set.
        /// </param>
        /// <param name="targetTcpProxiesSetProxyHeaderRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetProxyHeaderAsync(string project, string targetTcpProxy, TargetTcpProxiesSetProxyHeaderRequest targetTcpProxiesSetProxyHeaderRequestResource, st::CancellationToken cancellationToken) =>
            SetProxyHeaderAsync(project, targetTcpProxy, targetTcpProxiesSetProxyHeaderRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TargetTcpProxies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The TargetTcpProxies API.
    /// </remarks>
    public sealed partial class TargetTcpProxiesClientImpl : TargetTcpProxiesClient
    {
        private readonly gaxgrpc::ApiCall<DeleteTargetTcpProxyRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetTargetTcpProxyRequest, TargetTcpProxy> _callGet;

        private readonly gaxgrpc::ApiCall<InsertTargetTcpProxyRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListTargetTcpProxiesRequest, TargetTcpProxyList> _callList;

        private readonly gaxgrpc::ApiCall<SetBackendServiceTargetTcpProxyRequest, Operation> _callSetBackendService;

        private readonly gaxgrpc::ApiCall<SetProxyHeaderTargetTcpProxyRequest, Operation> _callSetProxyHeader;

        /// <summary>
        /// Constructs a client wrapper for the TargetTcpProxies service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TargetTcpProxiesSettings"/> used within this client.</param>
        public TargetTcpProxiesClientImpl(TargetTcpProxies.TargetTcpProxiesClient grpcClient, TargetTcpProxiesSettings settings)
        {
            GrpcClient = grpcClient;
            TargetTcpProxiesSettings effectiveSettings = settings ?? TargetTcpProxiesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callDelete = clientHelper.BuildApiCall<DeleteTargetTcpProxyRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_tcp_proxy", request => request.TargetTcpProxy);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetTargetTcpProxyRequest, TargetTcpProxy>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_tcp_proxy", request => request.TargetTcpProxy);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertTargetTcpProxyRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListTargetTcpProxiesRequest, TargetTcpProxyList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callSetBackendService = clientHelper.BuildApiCall<SetBackendServiceTargetTcpProxyRequest, Operation>(grpcClient.SetBackendServiceAsync, grpcClient.SetBackendService, effectiveSettings.SetBackendServiceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_tcp_proxy", request => request.TargetTcpProxy);
            Modify_ApiCall(ref _callSetBackendService);
            Modify_SetBackendServiceApiCall(ref _callSetBackendService);
            _callSetProxyHeader = clientHelper.BuildApiCall<SetProxyHeaderTargetTcpProxyRequest, Operation>(grpcClient.SetProxyHeaderAsync, grpcClient.SetProxyHeader, effectiveSettings.SetProxyHeaderSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_tcp_proxy", request => request.TargetTcpProxy);
            Modify_ApiCall(ref _callSetProxyHeader);
            Modify_SetProxyHeaderApiCall(ref _callSetProxyHeader);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteTargetTcpProxyRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetTargetTcpProxyRequest, TargetTcpProxy> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertTargetTcpProxyRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListTargetTcpProxiesRequest, TargetTcpProxyList> call);

        partial void Modify_SetBackendServiceApiCall(ref gaxgrpc::ApiCall<SetBackendServiceTargetTcpProxyRequest, Operation> call);

        partial void Modify_SetProxyHeaderApiCall(ref gaxgrpc::ApiCall<SetProxyHeaderTargetTcpProxyRequest, Operation> call);

        partial void OnConstruction(TargetTcpProxies.TargetTcpProxiesClient grpcClient, TargetTcpProxiesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TargetTcpProxies client</summary>
        public override TargetTcpProxies.TargetTcpProxiesClient GrpcClient { get; }

        partial void Modify_DeleteTargetTcpProxyRequest(ref DeleteTargetTcpProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTargetTcpProxyRequest(ref GetTargetTcpProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertTargetTcpProxyRequest(ref InsertTargetTcpProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTargetTcpProxiesRequest(ref ListTargetTcpProxiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetBackendServiceTargetTcpProxyRequest(ref SetBackendServiceTargetTcpProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetProxyHeaderTargetTcpProxyRequest(ref SetProxyHeaderTargetTcpProxyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Deletes the specified TargetTcpProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetTcpProxyRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified TargetTcpProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetTcpProxyRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified TargetTcpProxy resource. Gets a list of available target TCP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetTcpProxy Get(GetTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetTcpProxyRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified TargetTcpProxy resource. Gets a list of available target TCP proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetTcpProxy> GetAsync(GetTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetTcpProxyRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a TargetTcpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetTcpProxyRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a TargetTcpProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetTcpProxyRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetTcpProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetTcpProxy"/> resources.</returns>
        public override gax::PagedEnumerable<TargetTcpProxyList, TargetTcpProxy> List(ListTargetTcpProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetTcpProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTargetTcpProxiesRequest, TargetTcpProxyList, TargetTcpProxy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetTcpProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetTcpProxy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<TargetTcpProxyList, TargetTcpProxy> ListAsync(ListTargetTcpProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetTcpProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTargetTcpProxiesRequest, TargetTcpProxyList, TargetTcpProxy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Changes the BackendService for TargetTcpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetBackendService(SetBackendServiceTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetBackendServiceTargetTcpProxyRequest(ref request, ref callSettings);
            return _callSetBackendService.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes the BackendService for TargetTcpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetBackendServiceAsync(SetBackendServiceTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetBackendServiceTargetTcpProxyRequest(ref request, ref callSettings);
            return _callSetBackendService.Async(request, callSettings);
        }

        /// <summary>
        /// Changes the ProxyHeaderType for TargetTcpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetProxyHeader(SetProxyHeaderTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetProxyHeaderTargetTcpProxyRequest(ref request, ref callSettings);
            return _callSetProxyHeader.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes the ProxyHeaderType for TargetTcpProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetProxyHeaderAsync(SetProxyHeaderTargetTcpProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetProxyHeaderTargetTcpProxyRequest(ref request, ref callSettings);
            return _callSetProxyHeader.Async(request, callSettings);
        }
    }

    public partial class ListTargetTcpProxiesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            set => MaxResults = (uint)value;
        }
    }

    public partial class TargetTcpProxyList : gaxgrpc::IPageResponse<TargetTcpProxy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TargetTcpProxy> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
