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
    /// <summary>Settings for <see cref="TargetHttpsProxiesClient"/> instances.</summary>
    public sealed partial class TargetHttpsProxiesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TargetHttpsProxiesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TargetHttpsProxiesSettings"/>.</returns>
        public static TargetHttpsProxiesSettings GetDefault() => new TargetHttpsProxiesSettings();

        /// <summary>Constructs a new <see cref="TargetHttpsProxiesSettings"/> object with default settings.</summary>
        public TargetHttpsProxiesSettings()
        {
        }

        private TargetHttpsProxiesSettings(TargetHttpsProxiesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AggregatedListSettings = existing.AggregatedListSettings;
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            SetQuicOverrideSettings = existing.SetQuicOverrideSettings;
            SetSslCertificatesSettings = existing.SetSslCertificatesSettings;
            SetSslPolicySettings = existing.SetSslPolicySettings;
            SetUrlMapSettings = existing.SetUrlMapSettings;
            OnCopy(existing);
        }

        partial void OnCopy(TargetHttpsProxiesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.AggregatedList</c> and <c>TargetHttpsProxiesClient.AggregatedListAsync</c>.
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
        /// <c>TargetHttpsProxiesClient.Delete</c> and <c>TargetHttpsProxiesClient.DeleteAsync</c>.
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
        /// <c>TargetHttpsProxiesClient.Get</c> and <c>TargetHttpsProxiesClient.GetAsync</c>.
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
        /// <c>TargetHttpsProxiesClient.Insert</c> and <c>TargetHttpsProxiesClient.InsertAsync</c>.
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
        /// <c>TargetHttpsProxiesClient.List</c> and <c>TargetHttpsProxiesClient.ListAsync</c>.
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
        /// <c>TargetHttpsProxiesClient.Patch</c> and <c>TargetHttpsProxiesClient.PatchAsync</c>.
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
        /// <c>TargetHttpsProxiesClient.SetQuicOverride</c> and <c>TargetHttpsProxiesClient.SetQuicOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetQuicOverrideSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.SetSslCertificates</c> and <c>TargetHttpsProxiesClient.SetSslCertificatesAsync</c>
        /// .
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
        /// <c>TargetHttpsProxiesClient.SetSslPolicy</c> and <c>TargetHttpsProxiesClient.SetSslPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSslPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.SetUrlMap</c> and <c>TargetHttpsProxiesClient.SetUrlMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetUrlMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TargetHttpsProxiesSettings"/> object.</returns>
        public TargetHttpsProxiesSettings Clone() => new TargetHttpsProxiesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TargetHttpsProxiesClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class TargetHttpsProxiesClientBuilder : gaxgrpc::ClientBuilderBase<TargetHttpsProxiesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TargetHttpsProxiesSettings Settings { get; set; }

        partial void InterceptBuild(ref TargetHttpsProxiesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TargetHttpsProxiesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TargetHttpsProxiesClient Build()
        {
            TargetHttpsProxiesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TargetHttpsProxiesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TargetHttpsProxiesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TargetHttpsProxiesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TargetHttpsProxiesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<TargetHttpsProxiesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TargetHttpsProxiesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => TargetHttpsProxiesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => TargetHttpsProxiesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TargetHttpsProxiesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>TargetHttpsProxies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The TargetHttpsProxies API.
    /// </remarks>
    public abstract partial class TargetHttpsProxiesClient
    {
        /// <summary>
        /// The default endpoint for the TargetHttpsProxies service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default TargetHttpsProxies scopes.</summary>
        /// <remarks>
        /// The default TargetHttpsProxies scopes are:
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
        /// Asynchronously creates a <see cref="TargetHttpsProxiesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetHttpsProxiesClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TargetHttpsProxiesClient"/>.</returns>
        public static stt::Task<TargetHttpsProxiesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TargetHttpsProxiesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TargetHttpsProxiesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetHttpsProxiesClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="TargetHttpsProxiesClient"/>.</returns>
        public static TargetHttpsProxiesClient Create() => new TargetHttpsProxiesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TargetHttpsProxiesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TargetHttpsProxiesSettings"/>.</param>
        /// <returns>The created <see cref="TargetHttpsProxiesClient"/>.</returns>
        internal static TargetHttpsProxiesClient Create(grpccore::CallInvoker callInvoker, TargetHttpsProxiesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TargetHttpsProxies.TargetHttpsProxiesClient grpcClient = new TargetHttpsProxies.TargetHttpsProxiesClient(callInvoker);
            return new TargetHttpsProxiesClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC TargetHttpsProxies client</summary>
        public virtual TargetHttpsProxies.TargetHttpsProxiesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetHttpsProxyAggregatedList AggregatedList(AggregatedListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxyAggregatedList> AggregatedListAsync(AggregatedListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxyAggregatedList> AggregatedListAsync(AggregatedListTargetHttpsProxiesRequest request, st::CancellationToken cancellationToken) =>
            AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetHttpsProxyAggregatedList AggregatedList(string project, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedList(new AggregatedListTargetHttpsProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxyAggregatedList> AggregatedListAsync(string project, gaxgrpc::CallSettings callSettings = null) =>
            AggregatedListAsync(new AggregatedListTargetHttpsProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxyAggregatedList> AggregatedListAsync(string project, st::CancellationToken cancellationToken) =>
            AggregatedListAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string targetHttpsProxy, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string targetHttpsProxy, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string targetHttpsProxy, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, targetHttpsProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource. Gets a list of available target HTTPS proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetHttpsProxy Get(GetTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource. Gets a list of available target HTTPS proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxy> GetAsync(GetTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource. Gets a list of available target HTTPS proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxy> GetAsync(GetTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource. Gets a list of available target HTTPS proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetHttpsProxy Get(string project, string targetHttpsProxy, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource. Gets a list of available target HTTPS proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxy> GetAsync(string project, string targetHttpsProxy, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource. Gets a list of available target HTTPS proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxy> GetAsync(string project, string targetHttpsProxy, st::CancellationToken cancellationToken) =>
            GetAsync(project, targetHttpsProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, TargetHttpsProxy targetHttpsProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxyResource, nameof(targetHttpsProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, TargetHttpsProxy targetHttpsProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxyResource, nameof(targetHttpsProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, TargetHttpsProxy targetHttpsProxyResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, targetHttpsProxyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetHttpsProxyList List(ListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxyList> ListAsync(ListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxyList> ListAsync(ListTargetHttpsProxiesRequest request, st::CancellationToken cancellationToken) =>
            ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetHttpsProxyList List(string project, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListTargetHttpsProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxyList> ListAsync(string project, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListTargetHttpsProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxyList> ListAsync(string project, st::CancellationToken cancellationToken) =>
            ListAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(PatchTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(PatchTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to patch.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Patch(string project, string targetHttpsProxy, TargetHttpsProxy targetHttpsProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
                TargetHttpsProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxyResource, nameof(targetHttpsProxyResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to patch.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string targetHttpsProxy, TargetHttpsProxy targetHttpsProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
                TargetHttpsProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxyResource, nameof(targetHttpsProxyResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to patch.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> PatchAsync(string project, string targetHttpsProxy, TargetHttpsProxy targetHttpsProxyResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, targetHttpsProxy, targetHttpsProxyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetQuicOverride(SetQuicOverrideTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetQuicOverrideAsync(SetQuicOverrideTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetQuicOverrideAsync(SetQuicOverrideTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            SetQuicOverrideAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set the QUIC override policy for. The name should conform to RFC1035.
        /// </param>
        /// <param name="targetHttpsProxiesSetQuicOverrideRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetQuicOverride(string project, string targetHttpsProxy, TargetHttpsProxiesSetQuicOverrideRequest targetHttpsProxiesSetQuicOverrideRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetQuicOverride(new SetQuicOverrideTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxiesSetQuicOverrideRequestResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxiesSetQuicOverrideRequestResource, nameof(targetHttpsProxiesSetQuicOverrideRequestResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set the QUIC override policy for. The name should conform to RFC1035.
        /// </param>
        /// <param name="targetHttpsProxiesSetQuicOverrideRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetQuicOverrideAsync(string project, string targetHttpsProxy, TargetHttpsProxiesSetQuicOverrideRequest targetHttpsProxiesSetQuicOverrideRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetQuicOverrideAsync(new SetQuicOverrideTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxiesSetQuicOverrideRequestResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxiesSetQuicOverrideRequestResource, nameof(targetHttpsProxiesSetQuicOverrideRequestResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set the QUIC override policy for. The name should conform to RFC1035.
        /// </param>
        /// <param name="targetHttpsProxiesSetQuicOverrideRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetQuicOverrideAsync(string project, string targetHttpsProxy, TargetHttpsProxiesSetQuicOverrideRequest targetHttpsProxiesSetQuicOverrideRequestResource, st::CancellationToken cancellationToken) =>
            SetQuicOverrideAsync(project, targetHttpsProxy, targetHttpsProxiesSetQuicOverrideRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetSslCertificates(SetSslCertificatesTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslCertificatesAsync(SetSslCertificatesTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslCertificatesAsync(SetSslCertificatesTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            SetSslCertificatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set an SslCertificates resource for.
        /// </param>
        /// <param name="targetHttpsProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetSslCertificates(string project, string targetHttpsProxy, TargetHttpsProxiesSetSslCertificatesRequest targetHttpsProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslCertificates(new SetSslCertificatesTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxiesSetSslCertificatesRequestResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxiesSetSslCertificatesRequestResource, nameof(targetHttpsProxiesSetSslCertificatesRequestResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set an SslCertificates resource for.
        /// </param>
        /// <param name="targetHttpsProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslCertificatesAsync(string project, string targetHttpsProxy, TargetHttpsProxiesSetSslCertificatesRequest targetHttpsProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslCertificatesAsync(new SetSslCertificatesTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxiesSetSslCertificatesRequestResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxiesSetSslCertificatesRequestResource, nameof(targetHttpsProxiesSetSslCertificatesRequestResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set an SslCertificates resource for.
        /// </param>
        /// <param name="targetHttpsProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslCertificatesAsync(string project, string targetHttpsProxy, TargetHttpsProxiesSetSslCertificatesRequest targetHttpsProxiesSetSslCertificatesRequestResource, st::CancellationToken cancellationToken) =>
            SetSslCertificatesAsync(project, targetHttpsProxy, targetHttpsProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetSslPolicy(SetSslPolicyTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslPolicyAsync(SetSslPolicyTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslPolicyAsync(SetSslPolicyTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            SetSslPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose SSL policy is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="sslPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetSslPolicy(string project, string targetHttpsProxy, SslPolicyReference sslPolicyReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslPolicy(new SetSslPolicyTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SslPolicyReferenceResource = gax::GaxPreconditions.CheckNotNull(sslPolicyReferenceResource, nameof(sslPolicyReferenceResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose SSL policy is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="sslPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslPolicyAsync(string project, string targetHttpsProxy, SslPolicyReference sslPolicyReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslPolicyAsync(new SetSslPolicyTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SslPolicyReferenceResource = gax::GaxPreconditions.CheckNotNull(sslPolicyReferenceResource, nameof(sslPolicyReferenceResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose SSL policy is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="sslPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslPolicyAsync(string project, string targetHttpsProxy, SslPolicyReference sslPolicyReferenceResource, st::CancellationToken cancellationToken) =>
            SetSslPolicyAsync(project, targetHttpsProxy, sslPolicyReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetUrlMap(SetUrlMapTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetUrlMapAsync(SetUrlMapTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetUrlMapAsync(SetUrlMapTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            SetUrlMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose URL map is to be set.
        /// </param>
        /// <param name="urlMapReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetUrlMap(string project, string targetHttpsProxy, UrlMapReference urlMapReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetUrlMap(new SetUrlMapTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
                UrlMapReferenceResource = gax::GaxPreconditions.CheckNotNull(urlMapReferenceResource, nameof(urlMapReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose URL map is to be set.
        /// </param>
        /// <param name="urlMapReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetUrlMapAsync(string project, string targetHttpsProxy, UrlMapReference urlMapReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetUrlMapAsync(new SetUrlMapTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
                UrlMapReferenceResource = gax::GaxPreconditions.CheckNotNull(urlMapReferenceResource, nameof(urlMapReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose URL map is to be set.
        /// </param>
        /// <param name="urlMapReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetUrlMapAsync(string project, string targetHttpsProxy, UrlMapReference urlMapReferenceResource, st::CancellationToken cancellationToken) =>
            SetUrlMapAsync(project, targetHttpsProxy, urlMapReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TargetHttpsProxies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The TargetHttpsProxies API.
    /// </remarks>
    public sealed partial class TargetHttpsProxiesClientImpl : TargetHttpsProxiesClient
    {
        private readonly gaxgrpc::ApiCall<AggregatedListTargetHttpsProxiesRequest, TargetHttpsProxyAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<DeleteTargetHttpsProxyRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetTargetHttpsProxyRequest, TargetHttpsProxy> _callGet;

        private readonly gaxgrpc::ApiCall<InsertTargetHttpsProxyRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListTargetHttpsProxiesRequest, TargetHttpsProxyList> _callList;

        private readonly gaxgrpc::ApiCall<PatchTargetHttpsProxyRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<SetQuicOverrideTargetHttpsProxyRequest, Operation> _callSetQuicOverride;

        private readonly gaxgrpc::ApiCall<SetSslCertificatesTargetHttpsProxyRequest, Operation> _callSetSslCertificates;

        private readonly gaxgrpc::ApiCall<SetSslPolicyTargetHttpsProxyRequest, Operation> _callSetSslPolicy;

        private readonly gaxgrpc::ApiCall<SetUrlMapTargetHttpsProxyRequest, Operation> _callSetUrlMap;

        /// <summary>
        /// Constructs a client wrapper for the TargetHttpsProxies service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TargetHttpsProxiesSettings"/> used within this client.</param>
        public TargetHttpsProxiesClientImpl(TargetHttpsProxies.TargetHttpsProxiesClient grpcClient, TargetHttpsProxiesSettings settings)
        {
            GrpcClient = grpcClient;
            TargetHttpsProxiesSettings effectiveSettings = settings ?? TargetHttpsProxiesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListTargetHttpsProxiesRequest, TargetHttpsProxyAggregatedList>(grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callDelete = clientHelper.BuildApiCall<DeleteTargetHttpsProxyRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetTargetHttpsProxyRequest, TargetHttpsProxy>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertTargetHttpsProxyRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListTargetHttpsProxiesRequest, TargetHttpsProxyList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchTargetHttpsProxyRequest, Operation>(grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callSetQuicOverride = clientHelper.BuildApiCall<SetQuicOverrideTargetHttpsProxyRequest, Operation>(grpcClient.SetQuicOverrideAsync, grpcClient.SetQuicOverride, effectiveSettings.SetQuicOverrideSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callSetQuicOverride);
            Modify_SetQuicOverrideApiCall(ref _callSetQuicOverride);
            _callSetSslCertificates = clientHelper.BuildApiCall<SetSslCertificatesTargetHttpsProxyRequest, Operation>(grpcClient.SetSslCertificatesAsync, grpcClient.SetSslCertificates, effectiveSettings.SetSslCertificatesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callSetSslCertificates);
            Modify_SetSslCertificatesApiCall(ref _callSetSslCertificates);
            _callSetSslPolicy = clientHelper.BuildApiCall<SetSslPolicyTargetHttpsProxyRequest, Operation>(grpcClient.SetSslPolicyAsync, grpcClient.SetSslPolicy, effectiveSettings.SetSslPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callSetSslPolicy);
            Modify_SetSslPolicyApiCall(ref _callSetSslPolicy);
            _callSetUrlMap = clientHelper.BuildApiCall<SetUrlMapTargetHttpsProxyRequest, Operation>(grpcClient.SetUrlMapAsync, grpcClient.SetUrlMap, effectiveSettings.SetUrlMapSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callSetUrlMap);
            Modify_SetUrlMapApiCall(ref _callSetUrlMap);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListTargetHttpsProxiesRequest, TargetHttpsProxyAggregatedList> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteTargetHttpsProxyRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetTargetHttpsProxyRequest, TargetHttpsProxy> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertTargetHttpsProxyRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListTargetHttpsProxiesRequest, TargetHttpsProxyList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchTargetHttpsProxyRequest, Operation> call);

        partial void Modify_SetQuicOverrideApiCall(ref gaxgrpc::ApiCall<SetQuicOverrideTargetHttpsProxyRequest, Operation> call);

        partial void Modify_SetSslCertificatesApiCall(ref gaxgrpc::ApiCall<SetSslCertificatesTargetHttpsProxyRequest, Operation> call);

        partial void Modify_SetSslPolicyApiCall(ref gaxgrpc::ApiCall<SetSslPolicyTargetHttpsProxyRequest, Operation> call);

        partial void Modify_SetUrlMapApiCall(ref gaxgrpc::ApiCall<SetUrlMapTargetHttpsProxyRequest, Operation> call);

        partial void OnConstruction(TargetHttpsProxies.TargetHttpsProxiesClient grpcClient, TargetHttpsProxiesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TargetHttpsProxies client</summary>
        public override TargetHttpsProxies.TargetHttpsProxiesClient GrpcClient { get; }

        partial void Modify_AggregatedListTargetHttpsProxiesRequest(ref AggregatedListTargetHttpsProxiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTargetHttpsProxyRequest(ref DeleteTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTargetHttpsProxyRequest(ref GetTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertTargetHttpsProxyRequest(ref InsertTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTargetHttpsProxiesRequest(ref ListTargetHttpsProxiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchTargetHttpsProxyRequest(ref PatchTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetQuicOverrideTargetHttpsProxyRequest(ref SetQuicOverrideTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSslCertificatesTargetHttpsProxyRequest(ref SetSslCertificatesTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSslPolicyTargetHttpsProxyRequest(ref SetSslPolicyTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetUrlMapTargetHttpsProxyRequest(ref SetUrlMapTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetHttpsProxyAggregatedList AggregatedList(AggregatedListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListTargetHttpsProxiesRequest(ref request, ref callSettings);
            return _callAggregatedList.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetHttpsProxyAggregatedList> AggregatedListAsync(AggregatedListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListTargetHttpsProxiesRequest(ref request, ref callSettings);
            return _callAggregatedList.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource. Gets a list of available target HTTPS proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetHttpsProxy Get(GetTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource. Gets a list of available target HTTPS proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetHttpsProxy> GetAsync(GetTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetHttpsProxyList List(ListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetHttpsProxiesRequest(ref request, ref callSettings);
            return _callList.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetHttpsProxyList> ListAsync(ListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetHttpsProxiesRequest(ref request, ref callSettings);
            return _callList.Async(request, callSettings);
        }

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Patch(PatchTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callPatch.Sync(request, callSettings);
        }

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules. (== suppress_warning http-rest-shadowed ==)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> PatchAsync(PatchTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callPatch.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetQuicOverride(SetQuicOverrideTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetQuicOverrideTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callSetQuicOverride.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetQuicOverrideAsync(SetQuicOverrideTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetQuicOverrideTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callSetQuicOverride.Async(request, callSettings);
        }

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetSslCertificates(SetSslCertificatesTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslCertificatesTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callSetSslCertificates.Sync(request, callSettings);
        }

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetSslCertificatesAsync(SetSslCertificatesTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslCertificatesTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callSetSslCertificates.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetSslPolicy(SetSslPolicyTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslPolicyTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callSetSslPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetSslPolicyAsync(SetSslPolicyTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslPolicyTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callSetSslPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetUrlMap(SetUrlMapTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUrlMapTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callSetUrlMap.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetUrlMapAsync(SetUrlMapTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUrlMapTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callSetUrlMap.Async(request, callSettings);
        }
    }
}
